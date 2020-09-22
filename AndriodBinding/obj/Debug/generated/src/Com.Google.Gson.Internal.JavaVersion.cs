using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JavaVersion']"
	[global::Android.Runtime.Register ("com/google/gson/internal/JavaVersion", DoNotGenerateAcw=true)]
	public sealed partial class JavaVersion : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/JavaVersion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JavaVersion); }
		}

		internal JavaVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isJava9OrLater;
		public static unsafe bool IsJava9OrLater {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JavaVersion']/method[@name='isJava9OrLater' and count(parameter)=0]"
			[Register ("isJava9OrLater", "()Z", "")]
			get {
				if (id_isJava9OrLater == IntPtr.Zero)
					id_isJava9OrLater = JNIEnv.GetStaticMethodID (class_ref, "isJava9OrLater", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isJava9OrLater);
				} finally {
				}
			}
		}

		static IntPtr id_getMajorJavaVersion;
		public static unsafe int MajorJavaVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JavaVersion']/method[@name='getMajorJavaVersion' and count(parameter)=0]"
			[Register ("getMajorJavaVersion", "()I", "")]
			get {
				if (id_getMajorJavaVersion == IntPtr.Zero)
					id_getMajorJavaVersion = JNIEnv.GetStaticMethodID (class_ref, "getMajorJavaVersion", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMajorJavaVersion);
				} finally {
				}
			}
		}

	}
}
