﻿namespace ClearSight.Core.Log
{
    /// <summary>
    /// Interface for all log writers.
    /// </summary>
    public interface ILogWriter
    {
        /// <summary>
        /// Handles a log event.
        /// </summary>
        /// <param name="logEvent"></param>
        void OnLogEvent(EventData logEvent);

        /// <summary>
        /// Handles flushing of the log.
        /// </summary>
        void OnLogHistoryFlushed();
    }
}
