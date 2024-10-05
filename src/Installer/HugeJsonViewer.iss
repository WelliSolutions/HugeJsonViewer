#include "CommonDotNet.iss"
#define MainExe "HugeJsonViewer.exe"
#define AppVersion GetFileVersion(AddBackslash(SourcePath) + "..\bin\Release\HugeJsonViewer.exe")
#define Title "Huge JSON Viewer"
#define ShortTitle "Huge JSON Viewer"
#define AppGUID "{F9362D71-9158-40E6-984C-1E5E9EDCFAD8}"


[Setup]
AppName={#Title}
AppVerName={#Title} {#AppVersion}
AppPublisher=WelliSolutions
AppPublisherURL=http://development.wellisolutions.de/huge-json-viewer/
AppSupportURL=http://development.wellisolutions.de/huge-json-viewer/
AppUpdatesURL=http://development.wellisolutions.de/huge-json-viewer/
DefaultDirName={pf}\{#ShortTitle}
DefaultGroupName={#Title}
AllowNoIcons=true
OutputDir=Compiled
OutputBaseFilename={#Title} {#AppVersion} Setup
Compression=lzma
SolidCompression=true
; Make useful description of Setup.exe itself
VersionInfoCompany=WelliSolutions
VersionInfoCopyright=2016 by WelliSolutions
VersionInfoDescription={#Title} {#AppVersion} Setup
VersionInfoProductName={#Title} Setup
VersionInfoProductVersion={#AppVersion}
VersionInfoTextVersion={#AppVersion}
VersionInfoVersion={#AppVersion}
AppCopyright=Copyright © 2016, WelliSolutions
SetupIconFile=Setup.ico
WizardImageFile=Logo.bmp
WizardSmallImageFile=WelliSolutions_Logo.bmp
AppVersion={#AppVersion}
AppContact=Thomas Weller
ChangesAssociations=Yes

[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Files]
Source: ..\bin\Release\{#MainExe}; DestDir: {app}; Flags: ignoreversion
Source: ..\bin\Release\*.dll; DestDir: {app}; Flags: ignoreversion

[Icons]
Name: {group}\{#Title}; Filename: {app}\{#MainExe}; IconFilename: {app}\{#MainExe}; IconIndex: 0;
Name: {userdesktop}\{#Title}; Filename: {app}\{#MainExe}; IconFilename: {app}\Setup.ico; Tasks: desktopicon

[Run]
; Filename: {app}\{#MainExe}; Description: {cm:LaunchProgram, Launch {#Title}}; Flags: nowait postinstall skipifsilent shellexec;

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{#AppGUID}
LicenseFile=MIT.rtf

[Icons]
; Workaround for Windows 10 bug of not displaying duplicate items in start menu: add ? parameter
Name: {group}\Online documentation; Filename: "http://development.wellisolutions.de/huge-json-viewer/"