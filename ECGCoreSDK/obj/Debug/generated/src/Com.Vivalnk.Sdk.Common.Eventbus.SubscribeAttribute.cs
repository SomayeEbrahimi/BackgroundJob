using System;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	[global::Android.Runtime.Annotation ("com.vivalnk.sdk.common.eventbus.Subscribe")]
	public partial class SubscribeAttribute : Attribute
	{
		[global::Android.Runtime.Register ("priority")]
		public int Priority { get; set; }

		[global::Android.Runtime.Register ("sticky")]
		public bool Sticky { get; set; }

	}
}
