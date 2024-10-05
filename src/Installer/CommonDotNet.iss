[Code]
function IsDotNetDetected(version: string; service: cardinal): boolean;
// Indicates whether the specified version and service pack of the .NET Framework is installed.
//
// version -- Specify one of these strings for the required .NET Framework version:
//    'v1.1.4322'     .NET Framework 1.1
//    'v2.0.50727'    .NET Framework 2.0
//    'v3.0'          .NET Framework 3.0
//    'v3.5'          .NET Framework 3.5
//    'v4\Client'     .NET Framework 4.0 Client Profile
//    'v4\Full'       .NET Framework 4.0 Full Installation
//    'v4.5'          .NET Framework 4.5
//
// service -- Specify any non-negative integer for the required service pack level:
//    0               No service packs required
//    1, 2, etc.      Service pack 1, 2, etc. required
var
    key: string;
    install, release, serviceCount: cardinal;
    check45, success: boolean;
begin
    // .NET 4.5 installs as update to .NET 4.0 Full
    if version = 'v4.5' then begin
        version := 'v4\Full';
        check45 := true;
    end else
        check45 := false;

    // installation key group for all .NET versions
    key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\' + version;

    // .NET 3.0 uses value InstallSuccess in subkey Setup
    if Pos('v3.0', version) = 1 then begin
        success := RegQueryDWordValue(HKLM, key + '\Setup', 'InstallSuccess', install);
    end else begin
        success := RegQueryDWordValue(HKLM, key, 'Install', install);
    end;

    // .NET 4.0/4.5 uses value Servicing instead of SP
    if Pos('v4', version) = 1 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Servicing', serviceCount);
    end else begin
        success := success and RegQueryDWordValue(HKLM, key, 'SP', serviceCount);
    end;

    // .NET 4.5 uses additional value Release
    if check45 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Release', release);
        success := success and (release >= 378389);
        if (release >= 378675) then begin
          serviceCount := 1; // .NET 4.5.1
        end;
        if (release >= 379893) then begin
          serviceCount := 2; // .NET 4.5.2
        end;
    end;

    result := success and (install = 1) and (serviceCount >= service);
end;


function RequireDotNet(): Boolean;
begin
  Result := true;

  // Check for required netfx installation
  if (not IsDotNetDetected('v4.5', 2)) then begin
    if (not IsAdminLoggedOn()) then begin
      MsgBox('This program needs .NET 4.5.2. Please ask an administrator to install it.', mbInformation, MB_OK);
      Result := false;
    end
    else begin
      MsgBox('This program needs .NET 4.5.2. Please install it.', mbInformation, MB_OK);
      Result := false;
    end;
  end
  else begin
     // MsgBox('Microsoft .NET Framework 4.5.2 ist bereits installiert.', mbInformation, MB_OK);
  end;

end;