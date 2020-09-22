using System;

namespace IO.Objectbox.Annotation {

	[global::Android.Runtime.Annotation ("io.objectbox.annotation.NameInDb")]
	public partial class NameInDbAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
