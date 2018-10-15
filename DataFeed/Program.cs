#define TRACE

using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.XPath;

namespace DataFeed
{
	/// <summary>
	/// main class 
	/// </summary>
	class Program
    {
	    static void Main(string[] args)
        {
	        Configuration.TraceConfig();

	        Trace.Flush();
        }
	}
}
