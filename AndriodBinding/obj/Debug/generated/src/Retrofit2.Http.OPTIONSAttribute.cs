using System;

namespace Retrofit2.Http {

	[global::Android.Runtime.Annotation ("retrofit2.http.OPTIONS")]
	public partial class OPTIONSAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
