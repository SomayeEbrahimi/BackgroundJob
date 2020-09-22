using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Time {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='TimeZones']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/time/TimeZones", DoNotGenerateAcw=true)]
	public partial class TimeZones : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='TimeZones']/field[@name='GMT_ID']"
		[Register ("GMT_ID")]
		public const string GmtId = (string) "GMT";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/time/TimeZones", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeZones); }
		}

		protected TimeZones (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
