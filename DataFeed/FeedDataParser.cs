using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace DataFeed
{
	public abstract class FeedDataParser<T> : IFeedDataParser<T>
	{
		public T FeedFileHandler { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

		public abstract bool ParseFeedData(out List<KeyValuePair<string, decimal>> pricesHorsesSorted);

		public bool SortByValue(Dictionary<int, decimal> feedData, out List<KeyValuePair<int, decimal>> sortedData)
		{
			sortedData = feedData.ToList();

			sortedData.Sort((_aPair, _bPair) => _aPair.Value.CompareTo(_bPair.Value));
			return true;
		}

		public bool SortByValue(Dictionary<string, decimal> feedData, out List<KeyValuePair<string, decimal>> sortedData)
		{
			sortedData = feedData.ToList();

			sortedData.Sort((_aPair, _bPair) => _aPair.Value.CompareTo(_bPair.Value));
			return true;
		}

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
