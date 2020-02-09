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

		private Predicate<object> _canExecute;
		private Action<object> _execute;

		public RelayCommand (Predicate<object> canExecute, Action<object> execute)
		{
			_canExecute = canExecute;
			_execute = execute;
		}

		public bool CanExecute(object parameter)
		{
			return _canExecute?.Invoke(parameter) ?? true;
		}

		public void Execute(object parameter)
		{
			_execute?.Invoke(parameter);
		}
	}
}
