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
		/// <summary>
		/// console running method
		/// </summary>
		/// <param name="args"></param>
	    static void Main(string[] args)
        {
	        Configuration.TraceConfig();

			//process XML data feed file
			Trace.WriteLine("processing XML data feed file...");

			List<KeyValuePair<string, decimal>> xmlFeedDataSorted;
			FeedDataParserXml<XPathDocument> _parserXml = (FeedDataParserXml<XPathDocument>)FeedDataParser<XPathDocument>.ParserFactory(FeedDataParserXml<XPathDocument>.FeedFileHandler);
			_parserXml.ParseFeedData(out xmlFeedDataSorted);

	        Trace.WriteLine("\n\r\tSorted prices and horses names ascending by prices: ");
	        foreach (KeyValuePair<string, decimal> _priceHorse in xmlFeedDataSorted)
	        {
		        Trace.WriteLine($"\t\t{_priceHorse.Key}::${_priceHorse.Value}");
	        }
			
	        Trace.Flush();
        }
	}
}
