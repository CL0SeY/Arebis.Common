using System;

namespace Arebis.Logging.GrayLog.NetCore
{
    /// <summary>
    /// A GrayLog related exception.
    /// </summary>
    public class GrayLoggingException : Exception
    {
        /// <summary>
        /// Constructs a default GrayLoggingException.
        /// </summary>
        public GrayLoggingException()
            : this("An exception occurred.")
        { }

        /// <summary>
        /// Constructs a GrayLoggingException given a custom message.
        /// </summary>
        public GrayLoggingException(string message)
            : this(message, null)
        { }

        /// <summary>
        /// Constructs a GrayLoggingException for an inner exception.
        /// </summary>
        public GrayLoggingException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
