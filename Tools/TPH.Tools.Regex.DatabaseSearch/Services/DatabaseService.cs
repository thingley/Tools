using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.SqlClient;
using System.Collections.ObjectModel;

namespace TPH.Tools.Regex.DatabaseSearch
{
	public class DatabaseService
	{
		static public ObservableCollection<SQLCodeObjectTypeModel> GetSQLCodeObjectTypeModelCollection()
		{
			ObservableCollection<SQLCodeObjectTypeModel> col = new ObservableCollection<SQLCodeObjectTypeModel>();

			col.Add(new SQLCodeObjectTypeModel("", "ALL"));
			col.Add(new SQLCodeObjectTypeModel("P", "SQL PROCEDURE"));
			col.Add(new SQLCodeObjectTypeModel("TR", "SQL TRIGGER"));
			col.Add(new SQLCodeObjectTypeModel("V", "VIEW"));

			return col;
		}

		/*
		 * TODO: Implement search based on 
		 * SELECT o.[schema_id] , o.[type] , sm.[definition] FROM sys.objects o JOIN sys.sql_modules sm ON o.object_id = sm.object_id;
		*/

	}
}
