namespace Skyline.DataMiner.CICD.Loggers
{
    /// <summary>
    /// Log collector interface.
    /// </summary>
    public interface ILogCollector
    {
        /// <summary>
        /// Logs the specified error message.
        /// </summary>
        /// <param name="error">The error message to log.</param>
        void ReportError(string error);

        /// <summary>
        /// Logs the specified status message.
        /// </summary>
        /// <param name="status">The status message to log.</param>
        void ReportStatus(string status);

        /// <summary>
        /// Logs the specified warning message.
        /// </summary>
        /// <param name="warning">The warning message to log.</param>
        void ReportWarning(string warning);

        /// <summary>
        /// Logs the specified debug message.
        /// </summary>
        /// <param name="debug">The debug message to log.</param>
        void ReportDebug(string debug);

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void ReportLog(string message);
    }
}