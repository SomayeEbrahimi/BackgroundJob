using System;

namespace Retrofit2.Http {

	[global::Android.Runtime.Annotation ("retrofit2.http.Headers")]
	public partial class HeadersAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string[] Value { get; set; }

	}
}
