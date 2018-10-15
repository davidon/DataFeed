using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DataFeed
{
	public class FeedDataParserXml : FeedDataParser
	{
		public override bool ParseFeedData(out List<KeyValuePair<string, decimal>> pricesHorsesSorted)
		{
			throw new NotImplementedException();
		}
	}
}
