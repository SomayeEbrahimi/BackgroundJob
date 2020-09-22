using System;

namespace IO.Reactivex.Annotations {

	[global::Android.Runtime.Annotation ("io.reactivex.annotations.SchedulerSupport")]
	public partial class SchedulerSupportAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
