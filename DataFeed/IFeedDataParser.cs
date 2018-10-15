using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;
using Newtonsoft.Json.Linq;

namespace DataFeed
{
	public interface IFeedDataParser<T>
	{
		/// <summary>
		/// generic type of file handler for different source format
		/// </summary>
		T FeedFileHandler { get; set; }

		bool ParseFeedData(out List<KeyValuePair<string, decimal>> pricesHorsesSorted);
		/// <summary>
		///
		/// (have it in interface for unit test) 
		/// </summary>
		/// <param name="feedData"></param>
		/// <param name="sortedData"></param>
		/// <returns></returns>
		bool SortByValue(Dictionary<int, decimal> feedData, out List<KeyValuePair<int, decimal>> sortedData);
	}
}
