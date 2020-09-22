using System;

namespace Retrofit2.Http {

	[global::Android.Runtime.Annotation ("retrofit2.http.HEAD")]
	public partial class HEADAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
