using System;
using System.Collections.Generic;
using System.Text;

using TPH.Tools.Shared.BaseClasses;

using System.ComponentModel;
using System.Linq;
using rx = System.Text.RegularExpressions;

namespace TPH.Tools.Regex.Tester
{
	public class RegexViewModel : BaseViewModel
	{
		#region Private Data Members

		private string _searchText;
		private string _searchRegex;

		private bool? _success;
		private IEnumerable<string> _matches;
		private string _error;

		#endregion

		#region Properties

		public string SearchText
		{
			get { return _searchText; }
			set
			{
				_searchText = value;
				NotifyPropertyChanged();
			}
		}

		public string SearchRegex
		{
			get { return _searchRegex; }
			set
			{
				_searchRegex = value;
				NotifyPropertyChanged();
			}
		}

		public bool? Success
		{
			private get { return _success; }
			set
			{
				_success = value;
				NotifyPropertyChanged();
			}
		}

		public IEnumerable<string> Matches
		{
			get { return _matches; }
			set
			{
				_matches = value;
				NotifyPropertyChanged();
			}
		}

		public string Error
		{
			get { return _error; }
			set
			{
				_error = value;
				NotifyPropertyChanged();
			}
		}

		#endregion

		#region Public Methods

		public void Match()
		{
			bool? success = null;
			IEnumerable<string> matches = null;
			string error = string.Empty;

			if (string.IsNullOrEmpty(SearchText))
				error = "Search text must be specified!";
			else if (string.IsNullOrEmpty(SearchRegex))
				error = "Search regex must be specified!";
			else
			{
				rx.Regex r = new rx.Regex(SearchRegex);

				success = r.IsMatch(SearchText);
				matches = r.Matches(SearchText).Select<rx.Match, string>(x => x.Value);
			}

			Success = success;
			Matches = matches;
			Error = error;
		}

		#endregion
	}
}
