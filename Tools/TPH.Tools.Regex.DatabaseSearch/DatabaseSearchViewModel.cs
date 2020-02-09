using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.ObjectModel;

using TPH.Tools.Common.BaseClasses;

namespace TPH.Tools.Regex.DatabaseSearch
{
	public class DatabaseSearchViewModel : BaseViewModelWithConnectionDetails
	{
		private DatabaseSearchModel _model;
		private ObservableCollection<SQLCodeObjectTypeModel> _sqlCodeObjectTypeModelCollection;
		private SQLCodeObjectTypeModel _selectedSQLCodeObjectTypeModel;

		public ObservableCollection<SQLCodeObjectTypeModel> SQLCodeObjectTypeModelCollection
		{
			get { return _sqlCodeObjectTypeModelCollection; }
			set
			{
				_sqlCodeObjectTypeModelCollection = value;
				NotifyPropertyChanged();
			}
		}

		public SQLCodeObjectTypeModel SelectedSQLCodeObjectTypeModel
		{
			get { return _selectedSQLCodeObjectTypeModel; }
			set
			{
				_selectedSQLCodeObjectTypeModel = value;
				NotifyPropertyChanged();
			}
		}

		public string SearchSchemaRegex
		{
			set
			{
				_model.SearchSchemaRegex = value;
				NotifyPropertyChanged();
			}
		}

		public string SearchNameRegex
		{
			set
			{
				_model.SearchNameRegex = value;
				NotifyPropertyChanged();
			}
		}

		public string SearchCodeRegex
		{
			set
			{
				_model.SearchCodeRegex = value;
				NotifyPropertyChanged();
			}
		}

		public DatabaseSearchViewModel()
		{
			_model = new DatabaseSearchModel();
			_sqlCodeObjectTypeModelCollection = DatabaseService.GetSQLCodeObjectTypeModelCollection();
		}
	}
}
