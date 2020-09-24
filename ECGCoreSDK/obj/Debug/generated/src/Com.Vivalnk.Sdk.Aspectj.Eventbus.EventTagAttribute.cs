using System;

namespace Com.Vivalnk.Sdk.Aspectj.Eventbus {

	[global::Android.Runtime.Annotation ("com.vivalnk.sdk.aspectj.eventbus.EventTag")]
	public partial class EventTagAttribute : Attribute
	{
		[global::Android.Runtime.Register ("tags")]
		public string[] Tags { get; set; }

	}
}
