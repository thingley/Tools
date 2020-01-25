using System;
using System.Collections.Generic;
using System.Text;

using TPH.Tools.Shared.BaseClasses;

using System.ComponentModel;
using rx = System.Text.RegularExpressions;

namespace TPH.Tools.Regex.Tester
{
	public class RegexViewModel : BaseViewModel
	{
		#region Private Data Members

		private bool? _isMatch;

		#endregion

		#region Read-Write Properties

		public string Regex { get; set; }

		public string SearchText { get; set; }

		#endregion

		#region Read-Only Properties

		public bool? IsMatch
		{
			private get
			{
				return _isMatch;
			}
			set
			{
				_isMatch = value;
				NotifyPropertyChanged();
			}
		}

		public string[] Captures
		{
			get { return new string[] {"aaa", "bbb", "ccc" }; }
		}

		#endregion

		#region Public Methods

		public void TestIsMatch()
		{
			rx.Regex r = new rx.Regex(this.Regex);
			IsMatch = r.IsMatch(this.SearchText);
		}

		#endregion

	}
}
