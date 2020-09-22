using System;

namespace IO.Objectbox.Annotation {

	[global::Android.Runtime.Annotation ("io.objectbox.annotation.Uid")]
	public partial class UidAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public long Value { get; set; }

	}
}
