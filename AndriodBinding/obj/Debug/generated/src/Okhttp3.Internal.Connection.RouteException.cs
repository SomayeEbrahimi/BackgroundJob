using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteException']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/RouteException", DoNotGenerateAcw=true)]
	public sealed partial class RouteException : global::Java.Lang.RuntimeException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/connection/RouteException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RouteException); }
		}

		internal RouteException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getFirstConnectException;
		public unsafe global::Java.IO.IOException FirstConnectException {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteException']/method[@name='getFirstConnectException' and count(parameter)=0]"
			[Register ("getFirstConnectException", "()Ljava/io/IOException;", "")]
			get {
				if (id_getFirstConnectException == IntPtr.Zero)
					id_getFirstConnectException = JNIEnv.GetMethodID (class_ref, "getFirstConnectException", "()Ljava/io/IOException;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getFirstConnectException), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLastConnectException;
		public unsafe global::Java.IO.IOException LastConnectException {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RouteException']/method[@name='getLastConnectException' and count(parameter)=0]"
			[Register ("getLastConnectException", "()Ljava/io/IOException;", "")]
			get {
				if (id_getLastConnectException == IntPtr.Zero)
					id_getLastConnectException = JNIEnv.GetMethodID (class_ref, "getLastConnectException", "()Ljava/io/IOException;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getLastConnectException), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
