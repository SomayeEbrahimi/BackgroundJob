using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='Version']"
	[global::Android.Runtime.Register ("okhttp3/internal/Version", DoNotGenerateAcw=true)]
	public sealed partial class Version : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/Version", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Version); }
		}

		internal Version (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_userAgent;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Version']/method[@name='userAgent' and count(parameter)=0]"
		[Register ("userAgent", "()Ljava/lang/String;", "")]
		public static unsafe string UserAgent ()
		{
			if (id_userAgent == IntPtr.Zero)
				id_userAgent = JNIEnv.GetStaticMethodID (class_ref, "userAgent", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_userAgent), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
