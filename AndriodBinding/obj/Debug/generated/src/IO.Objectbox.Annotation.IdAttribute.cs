using System;

namespace IO.Objectbox.Annotation {

	[global::Android.Runtime.Annotation ("io.objectbox.annotation.Id")]
	public partial class IdAttribute : Attribute
	{
		[global::Android.Runtime.Register ("assignable")]
		public bool Assignable { get; set; }

	}
}
