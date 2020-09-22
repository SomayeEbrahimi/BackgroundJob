using System;

namespace IO.Objectbox.Annotation {

	[global::Android.Runtime.Annotation ("io.objectbox.annotation.TargetIdProperty")]
	public partial class TargetIdPropertyAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
