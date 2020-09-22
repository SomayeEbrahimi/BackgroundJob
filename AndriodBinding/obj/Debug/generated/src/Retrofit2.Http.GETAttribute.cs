using System;

namespace Retrofit2.Http {

	[global::Android.Runtime.Annotation ("retrofit2.http.GET")]
	public partial class GETAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
