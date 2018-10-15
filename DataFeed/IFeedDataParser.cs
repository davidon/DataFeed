using System.Collections.Generic;

namespace DataFeed
{
	public interface IFeedDataParser<T>
	{
		/// <summary>
		/// generic type of file handler for different source format
		/// </summary>
		T FeedFileHandler { get; set; }

		bool ParseFeedData(out List<KeyValuePair<string, decimal>> pricesHorsesSorted);

		bool SortByValue(Dictionary<int, decimal> feedData, out List<KeyValuePair<int, decimal>> sortedData);
	}
}
