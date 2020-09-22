using System;

namespace Retrofit2.Http {

	[global::Android.Runtime.Annotation ("retrofit2.http.Field")]
	public partial class FieldAttribute : Attribute
	{
		[global::Android.Runtime.Register ("encoded")]
		public bool Encoded { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
