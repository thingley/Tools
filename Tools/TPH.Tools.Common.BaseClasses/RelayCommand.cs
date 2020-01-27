using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;

namespace TPH.Tools.Common.BaseClasses
{
	public class RelayCommand : ICommand
	{
		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		private Func<bool> _canExecute;
		private Action _execute;

		public RelayCommand (Func<bool> canExecute, Action execute)
		{
			_canExecute = canExecute;
			_execute = execute;
		}

		public bool CanExecute(object parameter)
		{
			return _canExecute();
		}

		public void Execute(object parameter)
		{
			_execute();
		}
	}
}
