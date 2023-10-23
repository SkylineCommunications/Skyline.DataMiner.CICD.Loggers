namespace Skyline.DataMiner.CICD.Loggers
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a log collector.
    /// </summary>
    public class LogCollector : ILogCollector
    {
        private readonly bool logDebug;
        private readonly ConcurrentQueue<string> logging;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogCollector"/> class.
        /// </summary>
        public LogCollector(bool logDebug = false)
        {
            this.logDebug = logDebug;
            logging = new ConcurrentQueue<string>();
        }

        /// <summary>
        /// Gets the collected log messages.
        /// </summary>
        /// <value>The collected log messages.</value>
        public IReadOnlyList<string> Logging => new List<string>(logging);

        /// <summary>
        /// Logs the specified error message.
        /// </summary>
        /// <param name="error">The error message to log.</param>
        public void ReportError(string error) => ReportLog("ERROR: " + error);

        /// <summary>
        /// Logs the specified status message.
        /// </summary>
        /// <param name="status">The status message to log.</param>
        public void ReportStatus(string status) => ReportLog("STATUS: " + status);

        /// <summary>
        /// Logs the specified warning message.
        /// </summary>
        /// <param name="warning">The warning message to log.</param>
        public void ReportWarning(string warning) => ReportLog("WARNING: " + warning);

        /// <summary>
        /// Logs the specified debug message.
        /// </summary>
        /// <param name="debug">The debug message to log.</param>
        public void ReportDebug(string debug)
        {
            if (logDebug)
            {
                ReportLog("DEBUG: " + debug);
            }
        }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public void ReportLog(string message)
        {
            logging.Enqueue(message);
        }
    }
}