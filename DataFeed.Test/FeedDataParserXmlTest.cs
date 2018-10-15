using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;
using Xunit;

namespace DataFeed.Test
{
	public class FeedDataParserXmlTest : FeedDataParserTestBase
	{
		string XmlStr { get; set; }

		[Fact]
		public void ParseFeedDataTest()
		{
			StringReader _xmlReader = new StringReader(TestFixture.XmlStr);
			XPathDocument _xmlHandler = new XPathDocument(_xmlReader);
			List<KeyValuePair<string, decimal>> _xmlFeedDataSorted;
			FeedDataParserXml<XPathDocument> parserXml = new FeedDataParserXml<XPathDocument>();
			parserXml.ParseFeedData(out _xmlFeedDataSorted);
			AssertRunnersPrices(_xmlFeedDataSorted);
		}
	}

}
