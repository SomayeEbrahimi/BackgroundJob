using System;

namespace Retrofit2.Http {

	[global::Android.Runtime.Annotation ("retrofit2.http.QueryMap")]
	public partial class QueryMapAttribute : Attribute
	{
		[global::Android.Runtime.Register ("encoded")]
		public bool Encoded { get; set; }

	}
}
