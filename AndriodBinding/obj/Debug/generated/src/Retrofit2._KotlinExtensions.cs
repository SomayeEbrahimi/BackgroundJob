using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Retrofit2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='retrofit2']/class[@name='-KotlinExtensions']"
	[global::Android.Runtime.Register ("retrofit2/-KotlinExtensions", DoNotGenerateAcw=true)]
	public sealed partial class _KotlinExtensions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("retrofit2/-KotlinExtensions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (_KotlinExtensions); }
		}

		internal _KotlinExtensions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
