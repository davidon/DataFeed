using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace DataFeed
{
	/// <summary>
	/// parse JSON feed data
	/// </summary>
	public class FeedDataParserJson<T> : FeedDataParser<T> where T: JObject

	{
		/// <summary>
		/// JSON file handler
		/// </summary>
		JObject fileHandler;

		/// <summary>
		/// get JSON file handler from file
		/// </summary>
		public static new JObject FeedFileHandler
		{
			get => JObject.Parse(File.ReadAllText($"{new Settings().FeedDataPath}Demo_Race.json"));
		}

		/// <summary>
		/// constructor
		/// (parameter for DI purpose)
		/// </summary>
		/// <param name="_fileHandler"></param>
		public FeedDataParserJson(JObject _fileHandler)
		{
			fileHandler = _fileHandler;
		}

		/// <summary>
		/// The primary method to parse JSON feed data source
		/// </summary>
		/// <param name="_runnersPricesSorted"></param>
		/// <returns>bool: successful or not</returns>
		public override bool ParseFeedData(out List<KeyValuePair<string, decimal>> _runnersPricesSorted)
		{
			IEnumerable<JToken> _selections = fileHandler.SelectTokens("$..Selections");

			_runnersPricesSorted = new List<KeyValuePair<string, decimal>>();
			Dictionary<string, decimal> _runnersPrices = new Dictionary<string, decimal>();
			foreach (var _selection in _selections)
			{
				foreach (JObject _sel in _selection)
				{
					_runnersPrices.Add((string)_sel["Tags"]["name"], (decimal)_sel["Price"]);
				}

				Trace.WriteLine("\tOriginal runners name and price pair:");
				foreach (var _pair in _runnersPrices)
				{
					Trace.WriteLine($"\t\t{_pair.Key}::${_pair.Value}");
				}

				SortByValue(_runnersPrices, out _runnersPricesSorted);

			}
			return true;
		}
	}
}
