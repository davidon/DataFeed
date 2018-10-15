using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace DataFeed
{
	/// <summary>
	/// Base class of parsing feed data
	/// this class doesn't process file & directory reading
	/// </summary>
	public abstract class FeedDataParser<T> : IFeedDataParser<T>
	{
		/// <summary>
		/// constant of XML
		/// </summary>
		private const string xMLFormat = "xml";
		private const string jSONFormat = "json";

		/// <summary>
		/// handler for different format of data feed source files
		/// </summary>
		public T FeedFileHandler { get; set; }

		/// <summary>
		/// get different parser instance for different format of data feed source file
		/// (overriding to implement factory pattern)
		/// </summary>
		/// <param name="_fileHandler">File handler for different data format</param>
		/// <returns></returns>
		public static IFeedDataParser<XPathDocument> ParserFactory(XPathDocument _fileHandler)
		{
			return new FeedDataParserXml<XPathDocument>(_fileHandler);
		}

		/// <summary>
		/// The primary method to parse feed data source
		/// </summary>
		/// <param name="pricesHorsesSorted">parsed and sorted result</param>
		/// <returns></returns>
		public abstract bool ParseFeedData(out List<KeyValuePair<string, decimal>> pricesHorsesSorted);

		/// <summary>
		///  sort pairs of runners' number and prices by prices ascending order
		/// </summary>
		/// <param name="feedData">original data</param>
		/// <param name="sortedData">sorted data</param>
		/// <returns></returns>
		public bool SortByValue(Dictionary<int, decimal> feedData, out List<KeyValuePair<int, decimal>> sortedData)
		{
			sortedData = feedData.ToList();

			sortedData.Sort((_aPair, _bPair) => _aPair.Value.CompareTo(_bPair.Value));
			return true;
		}

		/// <summary>
		///  sort pairs of runners' name and prices by prices ascending order
		/// </summary>
		/// <param name="feedData">original data</param>
		/// <param name="sortedData">sorted data</param>
		/// <returns></returns>
		public bool SortByValue(Dictionary<string, decimal> feedData, out List<KeyValuePair<string, decimal>> sortedData)
		{
			sortedData = feedData.ToList();

			sortedData.Sort((_aPair, _bPair) => _aPair.Value.CompareTo(_bPair.Value));
			return true;
		}

		/// <summary>
		/// find runner's name by its number
		/// </summary>
		/// <param name="dataList">list of pairs of runner's number and name</param>
		/// <param name="keyNeedle"></param>
		/// <returns></returns>
		protected string findByKey(List<KeyValuePair<int, string>> dataList, int keyNeedle)
		{
			// Get the key value pair for a specific key
			KeyValuePair<int, string> pairFound = (from _pair in dataList.AsEnumerable()
				where _pair.Key == keyNeedle
				select _pair).SingleOrDefault();

			return pairFound.Value;
		}
	}
}
