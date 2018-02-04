using System;
using System.IO;

namespace EasyTravelWeb.Infrastructure
{
	/// <summary>
	///     Logs applicatuon exceptions and messages into 
	///		EasyTravelLog.txt in C:\Users\current user's directory
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
		private static readonly Stream FileStream = new FileStream(
			Constants.Constants.LoggerConstants.PathForFileStream,
			FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

		/// <summary>
		///     Instance of the StreamWriter class
		/// </summary>
		private readonly StreamWriter streamWriter = new StreamWriter(FileStream);

		#endregion

		#region Constructors

		/// <summary>
		///     Specified to execute only when an instance of the class is created 
		///     or a static member is referenced, and to execute only once per AppDomain. 
		///     Given that check for the type being newly constructed needs to be executed 
		///     whatever else happens, it will be faster than adding extra checking 
		/// </summary>
		static Logger()
		{
		}

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
		
		#region Public Methods

		/// <summary>
		///     Returns a new instance of the Logger class for exceptions logging.
		/// </summary>
		/// <returns>Instance of the Logger class.</returns>
		public static Logger GetInstance()
		{
			return logger ?? (logger = new Logger());
		}

		/// <summary>
		///     Writes the exception details into the file.
		/// </summary>
		/// <param name="ex">Instence of the Exception class.</param>
		public async void AsyncLogException(Exception ex)
		{
			this.streamWriter.WriteLine(DateTime.Now + "\n" + ex + "\n");
		}

		/// <summary>
		///     Writes the message into the file.
		/// </summary>
		/// <param name="message">Message that should be logged.</param>
		public async void AsyncLogMessage(string message)
		{
			this.streamWriter.WriteLine(DateTime.Now + "\n" + message + "\n");
		}

		#endregion
	}
}