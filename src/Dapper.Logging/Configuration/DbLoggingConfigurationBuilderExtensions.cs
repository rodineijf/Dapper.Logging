﻿using Microsoft.Extensions.Logging;

namespace Dapper.Logging.Configuration
{
    public static class DbLoggingConfigurationBuilderExtensions
    {
        /// <summary>
        /// Sets the log level
        /// </summary>
        /// <param name="x">The builder</param>
        /// <param name="level">The log level</param>
        /// <returns></returns>
        public static DbLoggingConfigurationBuilder WithLogLevel(this DbLoggingConfigurationBuilder x, LogLevel level)
        {
            x.LogLevel = level;
            return x;
        }

        /// <summary>
        /// Sets the Open connection message
        /// </summary>
        /// <param name="x">The builder</param>
        /// <param name="message">The message template (parameters: elapsed ms)</param>
        /// <returns></returns>
        public static DbLoggingConfigurationBuilder WithOpenConnectionMessage(this DbLoggingConfigurationBuilder x, string message)
        {
            x.OpenConnectionMessage = message;
            return x;
        }

        /// <summary>
        /// Sets the Close connection message
        /// </summary>
        /// <param name="x">The builder</param>
        /// <param name="message">The message template (parameters: elapsed ms)</param>
        /// <returns></returns>
        public static DbLoggingConfigurationBuilder WithCloseConnectionMessage(this DbLoggingConfigurationBuilder x, string message)
        {
            x.CloseConnectionMessage = message;
            return x;
        }

        /// <summary>
        /// Sets the message for all query types: Non Query / Scalar / Reader (Sync / Async)
        /// </summary>
        /// <param name="x">The builder</param>
        /// <param name="message">The message template (parameters: 0 = query text, 1 = elapsed ms)</param>
        /// <returns></returns>
        public static DbLoggingConfigurationBuilder WithQueryMessage(this DbLoggingConfigurationBuilder x, string message)
        {
            x.ExecuteQueryMessage = message;
            return x;
        }
    }
}