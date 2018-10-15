using System.Collections.Generic;

namespace DataFeed
{
	public interface IFeedDataParser
	{

		bool ParseFeedData(out List<KeyValuePair<string, decimal>> pricesHorsesSorted);

		bool SortByValue(Dictionary<int, decimal> feedData, out List<KeyValuePair<int, decimal>> sortedData);
	}
}
