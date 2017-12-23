using System;
using System.IO;

namespace EasyTravelWeb.Infrastructure
{
    /// <summary>
    ///     Logs applicatuon exceptions into EasyTravelLog.txt in C:\Users\Public directory
    /// </summary>
    public class Logger
    {
        #region Private Fields

        /// <summary>
        ///     The only one instance of the Logger class
        /// </summary>
        private static Logger logger;

        /// <summary>
        ///     Instance of the Stream class
        /// </summary>
        private static readonly Stream FileStream = new FileStream(@"C:\Users\Public\EasyTravelLog.txt",
            FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

        /// <summary>
        ///      Instance of the StreamWriter class
        /// </summary>
        private readonly StreamWriter streamWriter = new StreamWriter(FileStream);

        #endregion

        #region Constructor

        /// <summary>
        ///     Prevents a default instance of the Logger class from being created
        /// </summary>
        private Logger()
        {
        }

        #endregion

        #region Finalizer

        /// <summary>
        ///     Finalizes an instance of the Logger class
        /// </summary>
        ~Logger()
        {
            this.streamWriter.FlushAsync();
            FileStream.FlushAsync();
            this.streamWriter.Dispose();
            FileStream.Dispose();
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Returns a new instance of the Logger class for exceptions logging
        /// </summary>
        /// <returns>Instance of the Logger class</returns>
        public static Logger GetInstance()
        {
            return logger ?? (logger = new Logger());
        }

        /// <summary>
        ///     Writes the exception details into the file
        /// </summary>
        /// <param name="ex">Instence of the Exception class</param>
        public async void LogExceptionAsync(Exception ex)
        {
            await this.streamWriter.WriteLineAsync(DateTime.Now + "\n" + ex + "\n");
        }

        public async void LogMessageAsync(string message)
        {
            await this.streamWriter.WriteLineAsync(DateTime.Now + "\n" + message + "\n");
        }

        #endregion
    }
}