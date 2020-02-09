using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPH.Tools.Common.BaseClasses
{
	public class BaseViewModelWithConnectionDetails : BaseViewModel
	{
		private string _serverInstance;
		private bool? _useWindowsAuthentication;
		private string _username;
		private string _password;
		private string _database;

		public string ServerInstance
		{
			get { return _serverInstance; }
			set
			{
				_serverInstance = value;
				NotifyPropertyChanged();
				NotifyPropertyChanged("ConnectionString");
			}
		}

		public bool? UseWindowsAuthentication
		{
			get { return _useWindowsAuthentication; }
			set
			{
				_useWindowsAuthentication = value;
				NotifyPropertyChanged();
				NotifyPropertyChanged("ConnectionString");
			}
		}

		public string Username
		{
			get { return _username; }
			set
			{
				_username = value;
				NotifyPropertyChanged();
				NotifyPropertyChanged("ConnectionString");
			}
		}

		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				NotifyPropertyChanged();
				NotifyPropertyChanged("ConnectionString");
			}
		}

		public string Database
		{
			get { return _database; }
			set
			{
				_database = value;
				NotifyPropertyChanged();
				NotifyPropertyChanged("ConnectionString");
			}
		}

		public string ConnectionString
		{
			get
			{
				string connectionString = string.Empty;

				if (UseWindowsAuthentication.GetValueOrDefault(true))
				{
					connectionString = $"Server={ServerInstance};Database={Database};Trusted_Connection=True;";
				}
				else
				{
					connectionString = $"Server={ServerInstance};Database={Database};User Id={Username};Password={Password};";
				}

				return connectionString;
			}
		}

		public BaseViewModelWithConnectionDetails()
		{
			ServerInstance = @"DESKTOP-E2NF7OM\DEV01";
			UseWindowsAuthentication = true;
			Username = string.Empty;
			Password = string.Empty;
			Database = string.Empty;
		}
	}
}
