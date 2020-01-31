using System;
using System.Collections.Generic;
using System.Text;

using rx = System.Text.RegularExpressions;

namespace TPH.Tools.Regex.Tester
{
	public class RegexModel
	{
		public string SearchText { get; set; }
		
		public string SearchRegex { get; set; }

		public bool IsMatch
		{
			get
			{
				rx.Regex r = new rx.Regex(SearchRegex);
				return r.IsMatch(SearchText);
			}
		}

		public rx.MatchCollection GetMatches
		{
			get
			{
				rx.Regex r = new rx.Regex(SearchRegex);
				return r.Matches(SearchText);
			}
		}
	}
}
