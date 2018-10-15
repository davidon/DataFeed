using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;

namespace DataFeed.Test
{
	public class FeedDataParserJsonTest : FeedDataParserTestBase
	{
		[Fact]
		public void ParseFeedDataTest()
		{
			JObject _jsonHandler = JObject.Parse(TestFixture.JsonStr);
			List<KeyValuePair<string, decimal>> _jsonFeedDataSorted;
			FeedDataParserJson<JObject> _parserJson = new FeedDataParserJson<JObject>(_jsonHandler);
			_parserJson.ParseFeedData(out _jsonFeedDataSorted);
			AssertRunnersPrices(_jsonFeedDataSorted);
		}
		
	}

}
