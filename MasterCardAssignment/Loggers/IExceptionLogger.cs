﻿using System;
namespace MasterCardAssignment.Loggers
{
    /// <summary>
    /// Defines the method signature for logging exception
    /// </summary>
    public interface IExceptionLogger
    {
        /// <summary>
        /// Defines the method to logs the exception
        /// </summary>
        /// <param name="ex">The exception that needs to be logged</param>
        void LogException(Exception ex);      
    }
}
