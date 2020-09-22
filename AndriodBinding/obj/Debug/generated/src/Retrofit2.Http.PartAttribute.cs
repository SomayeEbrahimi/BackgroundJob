using System;

namespace Retrofit2.Http {

	[global::Android.Runtime.Annotation ("retrofit2.http.Part")]
	public partial class PartAttribute : Attribute
	{
		[global::Android.Runtime.Register ("encoding")]
		public string Encoding { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
