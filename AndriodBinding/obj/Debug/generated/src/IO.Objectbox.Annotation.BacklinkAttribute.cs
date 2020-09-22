using System;

namespace IO.Objectbox.Annotation {

	[global::Android.Runtime.Annotation ("io.objectbox.annotation.Backlink")]
	public partial class BacklinkAttribute : Attribute
	{
		[global::Android.Runtime.Register ("to")]
		public string To { get; set; }

	}
}
