﻿using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TPH.Tools.Common.BaseClasses
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
;