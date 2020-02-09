using System;
using System.Collections.Generic;
using System.Text;

using rx = System.Text.RegularExpressions;

using TPH.Tools.Common.BaseClasses;

namespace TPH.Tools.Regex.DatabaseSearch
{
	public class DatabaseSearchModel : BaseModel
	{
		private string _searchSQLObjectTypeModel;
		private string _searchSchemaRegex;
		private string _searchNameRegex;
		private string _searchCodeRegex;

		public string SearchSQLObjectTypeModel { set { _searchSQLObjectTypeModel = value; } }

		public string SearchSchemaRegex { set { _searchSchemaRegex = value; } }

		public string SearchNameRegex { set { _searchNameRegex = value; } }

		public string SearchCodeRegex { set { _searchCodeRegex = value; } }
	}
}
