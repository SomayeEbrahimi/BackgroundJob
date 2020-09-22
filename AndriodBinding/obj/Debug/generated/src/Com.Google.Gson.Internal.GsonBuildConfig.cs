using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='GsonBuildConfig']"
	[global::Android.Runtime.Register ("com/google/gson/internal/GsonBuildConfig", DoNotGenerateAcw=true)]
	public sealed partial class GsonBuildConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal']/class[@name='GsonBuildConfig']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "2.8.5";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/GsonBuildConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GsonBuildConfig); }
		}

		internal GsonBuildConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
