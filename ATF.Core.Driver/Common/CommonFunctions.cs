﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ATF.Core.Driver.Common
{
	public static class CommonFunctions
	{
		public static string DoRegexSingle(string pattern, string source, int groupNumber)
		{
			if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(source))
				throw new ArgumentException("Pattern and source must be initialized");

			Regex regex = new Regex(pattern);
			Match match = regex.Match(source);

			string matchValue = match.Groups[groupNumber].Value;

			return matchValue;
		}

		public static IEnumerable<string> Split(string source, char separator = '>')
		{
			string[] menuItems = source.Split(separator)
				.Select(e => e.Trim())
				.ToArray();
			return menuItems;
		}
	}
}
