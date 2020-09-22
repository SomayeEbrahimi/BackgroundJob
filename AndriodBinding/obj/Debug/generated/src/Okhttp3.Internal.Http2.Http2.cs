using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2", DoNotGenerateAcw=true)]
	public sealed partial class Http2 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http2/Http2", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Http2); }
		}

		internal Http2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
