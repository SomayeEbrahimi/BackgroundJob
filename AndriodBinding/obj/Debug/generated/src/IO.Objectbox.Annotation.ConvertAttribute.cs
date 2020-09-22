using System;

namespace IO.Objectbox.Annotation {

	[global::Android.Runtime.Annotation ("io.objectbox.annotation.Convert")]
	public partial class ConvertAttribute : Attribute
	{
		[global::Android.Runtime.Register ("converter")]
		public global::Java.Lang.Class Converter { get; set; }

		[global::Android.Runtime.Register ("dbType")]
		public global::Java.Lang.Class DbType { get; set; }

	}
}
