using System;

namespace Retrofit2.Http {

	[global::Android.Runtime.Annotation ("retrofit2.http.QueryName")]
	public partial class QueryNameAttribute : Attribute
	{
		[global::Android.Runtime.Register ("encoded")]
		public bool Encoded { get; set; }

	}
}
