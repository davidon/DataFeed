using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DataFeed
{
	/// <summary>
	/// parse XML feed data
	/// This class should only be accessed through factory
	/// </summary>
	public class FeedDataParserXml<T> : FeedDataParser<T> where T : XPathDocument
	{
		/// <summary>
		/// get XML file handler from file
		/// </summary>
		public static new XPathDocument FeedFileHandler
		{
			get => new XPathDocument($"{new Settings().FeedDataPath}Demo_Race.xml");
		}

		/// <summary>
		/// XML file handler
		/// </summary>
		private XPathDocument fileHandler;

		/// <summary>
		/// constructor
		/// (parameter for DI purpose)
		/// </summary>
		/// <param name="_fileHandler"></param>
		public FeedDataParserXml(XPathDocument _fileHandler)
		{
			fileHandler = _fileHandler;
		}

		/// <summary>
		/// The primary method to parse XML feed data source
		/// (parameter for DI purpose)
		/// </summary>
		/// <returns>bool: successful or not</returns>
		public override bool ParseFeedData(out List<KeyValuePair<string, decimal>> pricesHorsesSorted)
		{
			pricesHorsesSorted = new List<KeyValuePair<string, decimal>>();
			return true;
		}

	}
}
