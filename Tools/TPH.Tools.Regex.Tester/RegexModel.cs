using System;
using System.Collections.Generic;
using System.Text;

using rx = System.Text.RegularExpressions;

using TPH.Tools.Common.BaseClasses;

namespace TPH.Tools.Regex.Tester
{
	public class RegexModel : BaseModel
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
