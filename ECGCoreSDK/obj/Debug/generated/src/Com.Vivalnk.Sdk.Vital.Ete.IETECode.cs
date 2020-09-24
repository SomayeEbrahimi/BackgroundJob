using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Vital.Ete {

	[Register ("com/vivalnk/sdk/vital/ete/ETECode", DoNotGenerateAcw=true)]
	public abstract class ETECode : Java.Lang.Object {

		internal ETECode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETECode']/field[@name='FAILURE']"
		[Register ("FAILURE")]
		public const int Failure = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETECode']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 1;
	}

	[Register ("com/vivalnk/sdk/vital/ete/ETECode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'ETECode' type. This type will be removed in a future release.", error: true)]
	public abstract class ETECodeConsts : ETECode {

		private ETECodeConsts ()
		{
		}
	}

}
