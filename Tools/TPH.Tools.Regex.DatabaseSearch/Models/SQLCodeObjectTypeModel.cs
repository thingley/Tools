using System;
using System.Collections.Generic;
using System.Text;

using TPH.Tools.Common.BaseClasses;

namespace TPH.Tools.Regex.DatabaseSearch
{
	public class SQLCodeObjectTypeModel : BaseModel
	{
		private string type;
		private string typeDescription;

		public string Type { get => type; private set => type = value; }
		public string TypeDescription { get => typeDescription; private set => typeDescription = value; }

		public SQLCodeObjectTypeModel(string type, string typeDescription)
		{
			Type = type;
			TypeDescription = typeDescription;
		}

		public override string ToString()
		{
			return $"{Type} - {TypeDescription}";
		}
	}
}
