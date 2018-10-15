using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataFeed.Test
{
	public class FeedDataParserTestBase
	{
		public void AssertRunnersPrices(List<KeyValuePair<string, decimal>> feedDataSorted)
		{
			Assert.Equal(0, feedDataSorted.IndexOf(new KeyValuePair<string, decimal>("Lookin To Strike", 1.89m)));
			Assert.Equal(1, feedDataSorted.IndexOf(new KeyValuePair<string, decimal>("Curlins Honor", 2.2m)));
			Assert.Equal(2, feedDataSorted.IndexOf(new KeyValuePair<string, decimal>("Mr Ritz", 3.2m)));
			Assert.Equal(3, feedDataSorted.IndexOf(new KeyValuePair<string, decimal>("Coronel", 4.2m)));
			Assert.Equal(4, feedDataSorted.IndexOf(new KeyValuePair<string, decimal>("Peppered", 5.43m)));
			Assert.Equal(5, feedDataSorted.IndexOf(new KeyValuePair<string, decimal>("Flight Deck", 6.54m)));
			Assert.Equal(6, feedDataSorted.IndexOf(new KeyValuePair<string, decimal>("My Mandara", 7.65m)));
			Assert.Equal(7, feedDataSorted.IndexOf(new KeyValuePair<string, decimal>("Strike Me Down", 8.65m)));
			Assert.Equal(8, feedDataSorted.IndexOf(new KeyValuePair<string, decimal>("Advancing", 12m)));
		}
	}
}
