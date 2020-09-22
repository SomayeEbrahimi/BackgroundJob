using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='StreamResetException']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/StreamResetException", DoNotGenerateAcw=true)]
	public sealed partial class StreamResetException : global::Java.IO.IOException {


		static IntPtr errorCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='StreamResetException']/field[@name='errorCode']"
		[Register ("errorCode")]
		public global::Okhttp3.Internal.Http2.ErrorCode ErrorCode {
			get {
				if (errorCode_jfieldId == IntPtr.Zero)
					errorCode_jfieldId = JNIEnv.GetFieldID (class_ref, "errorCode", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Throwable) this).Handle, errorCode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (errorCode_jfieldId == IntPtr.Zero)
					errorCode_jfieldId = JNIEnv.GetFieldID (class_ref, "errorCode", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Throwable) this).Handle, errorCode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http2/StreamResetException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StreamResetException); }
		}

		internal StreamResetException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_internal_http2_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='StreamResetException']/constructor[@name='StreamResetException' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.ErrorCode']]"
		[Register (".ctor", "(Lokhttp3/internal/http2/ErrorCode;)V", "")]
		public unsafe StreamResetException (global::Okhttp3.Internal.Http2.ErrorCode errorCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorCode);
				if (((object) this).GetType () != typeof (StreamResetException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/internal/http2/ErrorCode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lokhttp3/internal/http2/ErrorCode;)V", __args);
					return;
				}

				if (id_ctor_Lokhttp3_internal_http2_ErrorCode_ == IntPtr.Zero)
					id_ctor_Lokhttp3_internal_http2_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/internal/http2/ErrorCode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_internal_http2_ErrorCode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lokhttp3_internal_http2_ErrorCode_, __args);
			} finally {
			}
		}

	}
}
