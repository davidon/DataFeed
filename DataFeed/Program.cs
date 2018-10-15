#define TRACE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.XPath;
using Newtonsoft.Json.Linq;

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
			
			//process JSON data feed file
			Trace.WriteLine("\n\r\n\rprocessing JSON data feed file...");
	        List<KeyValuePair<string, decimal>> jsonFeedDataSorted;
			FeedDataParserJson<JObject> parserJson = (FeedDataParserJson<JObject>)FeedDataParser<JObject>.ParserFactory(FeedDataParserJson<JObject>.FeedFileHandler);
			parserJson.ParseFeedData(out jsonFeedDataSorted);

	        Trace.WriteLine("\n\r\tAfter sorted by prices ascending, runners name and price pair:");
	        foreach (var _pair in jsonFeedDataSorted)
	        {
		        Trace.WriteLine($"\t\t{_pair.Key}::${_pair.Value}");
	        }

	        Trace.Flush();
        }
	}
}
