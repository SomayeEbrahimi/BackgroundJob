using System;

namespace IO.Objectbox.Annotation {

	[global::Android.Runtime.Annotation ("io.objectbox.annotation.Relation")]
	public partial class RelationAttribute : Attribute
	{
		[global::Android.Runtime.Register ("idProperty")]
		public string IdProperty { get; set; }

	}
}
