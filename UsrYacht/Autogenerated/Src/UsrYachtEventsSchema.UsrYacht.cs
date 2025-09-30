namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2c794808-8cf6-40a9-9669-048b5a80342a");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b8e201a8-1239-4596-b652-c3399610ca30");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,111,139,211,64,16,198,223,11,249,14,67,94,37,80,22,239,173,213,3,91,171,28,28,42,38,21,68,124,177,221,76,211,149,236,110,216,217,244,172,210,239,238,254,233,213,38,119,114,55,16,72,102,159,253,205,60,147,209,92,33,245,92,32,212,104,45,39,179,117,108,105,244,86,182,131,229,78,26,157,253,201,192,199,64,82,183,80,29,200,161,154,95,100,46,111,41,101,244,255,206,44,178,149,118,210,73,164,103,72,216,106,143,218,157,148,223,99,246,16,83,183,210,55,160,209,22,149,216,161,226,31,125,247,240,6,242,53,217,111,92,236,92,94,254,136,87,250,97,211,73,1,162,227,68,16,79,30,97,192,43,88,112,194,71,78,34,35,249,190,160,153,189,111,86,54,8,123,35,27,248,164,43,190,247,22,10,179,249,137,194,1,161,110,208,206,32,225,22,184,245,126,34,244,173,109,9,176,60,211,254,113,67,108,124,7,236,204,186,135,96,57,31,169,18,20,14,193,137,247,91,164,239,50,201,199,210,6,133,84,188,131,222,74,17,102,19,239,176,15,232,234,67,143,205,210,116,131,210,95,121,55,224,235,147,242,186,8,227,251,28,228,249,164,172,220,66,145,56,215,112,245,50,70,57,18,140,189,132,64,118,67,75,174,5,118,216,248,234,206,14,56,207,30,168,200,217,240,247,253,234,17,111,177,70,213,119,220,133,110,53,222,193,173,17,188,147,191,249,166,195,42,234,138,228,97,77,104,253,106,106,63,109,191,151,236,11,146,25,172,240,26,99,61,100,150,189,152,86,9,113,94,141,180,81,249,12,242,7,124,98,113,32,55,84,27,179,144,109,250,202,75,86,155,83,253,242,73,11,190,245,148,96,239,141,85,220,21,19,107,190,236,21,248,241,197,103,93,189,155,78,58,132,219,89,115,23,39,176,250,37,176,15,38,239,49,19,245,49,27,191,29,179,227,95,97,138,237,222,200,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("94fbf9a8-c678-4c9c-13fd-7588afc83cb6"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("b8e201a8-1239-4596-b652-c3399610ca30"),
				CreatedInSchemaUId = new Guid("2c794808-8cf6-40a9-9669-048b5a80342a"),
				ModifiedInSchemaUId = new Guid("2c794808-8cf6-40a9-9669-048b5a80342a")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2c794808-8cf6-40a9-9669-048b5a80342a"));
		}

		#endregion

	}

	#endregion

}

