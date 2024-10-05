namespace HugeJSONViewer
{
    /// <summary>
    /// The delegate for handling a ProgressStream Report event.
    /// </summary>
    /// <param name="sender">The object that raised the event, should be a ProgressStream.</param>
    /// <param name="args">The arguments raised with the event.</param>
    public delegate void ProgressStreamReportDelegate(object sender, ProgressStreamReportEventArgs args);
}