using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DataFeed
{
	/// <summary>
	/// Configuration related
	/// </summary>
	class Configuration
	{
		/// <summary>
		/// config Diagnostics trace
		/// </summary>
		public static void TraceConfig()
		{
			Trace.AutoFlush = false;
			Trace.Listeners.Clear();
			TextWriter tw = Console.Out;
			TextWriterTraceListener tl = new TextWriterTraceListener(tw);
			Trace.Listeners.Add(tl);

			Stream _logFile = File.Create(@"Logs\FeedDataProcess.log");
			TextWriterTraceListener _textListener = new TextWriterTraceListener(_logFile);
			Trace.Listeners.Add(_textListener);
		}
	}
}
