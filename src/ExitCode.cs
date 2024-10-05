namespace HugeJSONViewer
{
    enum ExitCode
    {
        Success = 0,
        NoArguments = 1,
        InvalidFileName = 2,
        FileNotFound = 3,
        PerformanceRejectedByUser=4,
        FileAccessError = 5,
        JsonFormatException = 6,
    }
}
