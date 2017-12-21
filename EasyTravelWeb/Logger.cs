using System;
using System.IO;

namespace EasyTravelWeb
{
	public class Logger
	{
		private static Logger _loggerSingletonInstance;

		private Logger()
		{
		}

		public static Logger GetInstance()
		{
			return _loggerSingletonInstance ?? (_loggerSingletonInstance = new Logger());
		}

		public void Log(string message)
		{
			using (Stream fileStream = new FileStream(@"C:\Users\Public\EasyTravelLog.txt",
				FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
			{
				using (StreamWriter streamWriter = new StreamWriter(fileStream))
				{
					streamWriter.WriteLine(DateTime.Now + ": " + message);
				}
			}
		}
	}
}