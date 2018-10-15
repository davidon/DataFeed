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
		}
	}
}
