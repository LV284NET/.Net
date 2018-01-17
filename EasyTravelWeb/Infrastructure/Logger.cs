using System;
using System.IO;

namespace EasyTravelWeb.Infrastructure
{
	/// <summary>
	///     Logs applicatuon exceptions into EasyTravelLog.txt in C:\Users\Public directory
	/// </summary>
	public class Logger
	{
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
			this.streamWriter.Dispose();
			FileStream.FlushAsync();
			FileStream.Dispose();
		}

		#endregion

		#region Private Fields

		/// <summary>
		///     The only one instance of the Logger class
		/// </summary>
		private static Logger logger;

		/// <summary>
		///     Instance of the Stream class
		/// </summary>
		private static readonly Stream FileStream = new FileStream($@"C:\Users\{Environment.UserName}\EasyTravelLog.txt",
			FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

		/// <summary>
		///     Instance of the StreamWriter class
		/// </summary>
		private readonly StreamWriter streamWriter = new StreamWriter(FileStream);

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
		public void LogException(Exception ex)
		{
			try
			{
				this.streamWriter.WriteLine(DateTime.Now + "\n" + ex + "\n");
			}
			catch (Exception e)
			{
				this.streamWriter.WriteLine(DateTime.Now + "\n" + e + "\n");
			}
		}

		/// <summary>
		///     Writes the message into the file
		/// </summary>
		/// <param name="message"></param>
		public void LogMessage(string message)
		{
			this.streamWriter.WriteLine(DateTime.Now + "\n" + message + "\n");
		}

		#endregion
	}
}