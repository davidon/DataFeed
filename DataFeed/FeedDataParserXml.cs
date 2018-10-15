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
			XPathNavigator navigator = fileHandler.CreateNavigator();
			XPathNodeIterator horse = navigator.Select(new Settings().HorseNodesXPath);

			Dictionary<int, string> horsesFeed = new Dictionary<int, string>();
			Dictionary<int, decimal> pricesFeed = new Dictionary<int, decimal>();

			Trace.WriteLine("\n\r\tOriginal order of horses No. and name pairs");
			while (horse.MoveNext())
			{
				XPathNavigator _horseNode = horse.Current;
				XPathNavigator _numNav = _horseNode.SelectSingleNode("number");
				int _num = _numNav.ValueAsInt;
				string _name = _horseNode.GetAttribute("name", "");
				horsesFeed.Add(_num, _name);
				Trace.WriteLine($"\t\t{_num}::{_name}");
			}

			List<KeyValuePair<int, string>> horsesList;
			horsesList = horsesFeed.ToList();

			XPathNodeIterator priceNodes = navigator.Select(new Settings().PriceNodesXPath);
			Trace.WriteLine("\n\r\tOriginal order of horses No. and price pairs");
			while (priceNodes.MoveNext())
			{
				XPathNavigator _priceNode = priceNodes.Current;
				int _num = Int32.Parse(_priceNode.GetAttribute("number", ""));
				decimal _price = decimal.Parse(_priceNode.GetAttribute("Price", ""));
				pricesFeed.Add(_num, _price);
				Trace.WriteLine($"\t\t{_num}::${_price}");
			}

			List<KeyValuePair<int, decimal>> pricesSorted;
			SortByValue(pricesFeed, out pricesSorted);

			pricesHorsesSorted = new List<KeyValuePair<string, decimal>>();
			foreach (KeyValuePair<int, decimal> _price in pricesSorted)
			{
				var _item = new KeyValuePair<string, decimal>(findByKey(horsesList, _price.Key), _price.Value);
				pricesHorsesSorted.Add(_item);
			}

			return true;
		}

	}
}
