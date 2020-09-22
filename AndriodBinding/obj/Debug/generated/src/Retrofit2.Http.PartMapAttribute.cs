using System;

namespace Retrofit2.Http {

	[global::Android.Runtime.Annotation ("retrofit2.http.PartMap")]
	public partial class PartMapAttribute : Attribute
	{
		[global::Android.Runtime.Register ("encoding")]
		public string Encoding { get; set; }

	}
}
