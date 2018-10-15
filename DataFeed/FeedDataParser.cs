using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace DataFeed
{
	public abstract class FeedDataParser : IFeedDataParser
	{
		public abstract bool ParseFeedData(out List<KeyValuePair<string, decimal>> pricesHorsesSorted);

		public bool SortByValue(Dictionary<int, decimal> feedData, out List<KeyValuePair<int, decimal>> sortedData)
		{
			sortedData = new List<KeyValuePair<int, decimal>>();
			return true;
		}

		public bool SortByValue(Dictionary<string, decimal> feedData, out List<KeyValuePair<string, decimal>> sortedData)
		{
			sortedData = new List<KeyValuePair<string, decimal>>();
			return true;
		}

		// Get the key value pair for a specific key
		protected string findByKey(List<KeyValuePair<int, string>> dataList, int keyNeedle)
		{
			KeyValuePair<int, string> pairFound = new KeyValuePair<int, string>(keyNeedle, "Blackdark") ;

			return pairFound.Value;
		}
	}
}
