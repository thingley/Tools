using System;
using System.Collections.Generic;
using System.Text;

using TPH.Tools.Common.BaseClasses;

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

		private RelayCommand _matchCommand;

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

		public RelayCommand MatchCommand
		{
			get { return _matchCommand; }
			private set { _matchCommand = value; }
		}

		#endregion

		#region Constructor(s)

		public RegexViewModel()
		{
			MatchCommand = new RelayCommand(CanMatch, Match);
		}

		#endregion

		#region Public Methods

		public void Match()
		{
			try
			{
				rx.Regex r = new rx.Regex(SearchRegex);
				Success = r.IsMatch(SearchText);
				Matches = r.Matches(SearchText).Select<rx.Match, string>(x => x.Value);
				Error = string.Empty;
			}
			catch (Exception ex)
			{
				Success = null;
				Matches = null;
				Error = ex.Message;
			}
		}

		public bool CanMatch()
		{
			if (string.IsNullOrEmpty(SearchText))
				return false;
			else if (string.IsNullOrEmpty(SearchRegex))
				return false;
			else
				return true;
		}

		#endregion
	}
}
