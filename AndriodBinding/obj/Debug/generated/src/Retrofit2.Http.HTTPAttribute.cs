using System;

namespace Retrofit2.Http {

	[global::Android.Runtime.Annotation ("retrofit2.http.HTTP")]
	public partial class HTTPAttribute : Attribute
	{
		[global::Android.Runtime.Register ("method")]
		public string Method { get; set; }

		[global::Android.Runtime.Register ("path")]
		public string Path { get; set; }

	}
}
