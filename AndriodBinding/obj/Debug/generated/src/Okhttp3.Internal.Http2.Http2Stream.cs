using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Stream", DoNotGenerateAcw=true)]
	public sealed partial class Http2Stream : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http2/Http2Stream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Http2Stream); }
		}

		internal Http2Stream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getConnection;
		public unsafe global::Okhttp3.Internal.Http2.Http2Connection Connection {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='getConnection' and count(parameter)=0]"
			[Register ("getConnection", "()Lokhttp3/internal/http2/Http2Connection;", "")]
			get {
				if (id_getConnection == IntPtr.Zero)
					id_getConnection = JNIEnv.GetMethodID (class_ref, "getConnection", "()Lokhttp3/internal/http2/Http2Connection;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnection), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getErrorCode;
		public unsafe global::Okhttp3.Internal.Http2.ErrorCode ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Lokhttp3/internal/http2/ErrorCode;", "")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()Lokhttp3/internal/http2/ErrorCode;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorCode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getId;
		public unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getId);
				} finally {
				}
			}
		}

		static IntPtr id_isLocallyInitiated;
		public unsafe bool IsLocallyInitiated {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='isLocallyInitiated' and count(parameter)=0]"
			[Register ("isLocallyInitiated", "()Z", "")]
			get {
				if (id_isLocallyInitiated == IntPtr.Zero)
					id_isLocallyInitiated = JNIEnv.GetMethodID (class_ref, "isLocallyInitiated", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLocallyInitiated);
				} finally {
				}
			}
		}

		static IntPtr id_isOpen;
		public unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "")]
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
				} finally {
				}
			}
		}

		static IntPtr id_close_Lokhttp3_internal_http2_ErrorCode_Ljava_io_IOException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='close' and count(parameter)=2 and parameter[1][@type='okhttp3.internal.http2.ErrorCode'] and parameter[2][@type='java.io.IOException']]"
		[Register ("close", "(Lokhttp3/internal/http2/ErrorCode;Ljava/io/IOException;)V", "")]
		public unsafe void Close (global::Okhttp3.Internal.Http2.ErrorCode rstStatusCode, global::Java.IO.IOException errorException)
		{
			if (id_close_Lokhttp3_internal_http2_ErrorCode_Ljava_io_IOException_ == IntPtr.Zero)
				id_close_Lokhttp3_internal_http2_ErrorCode_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "close", "(Lokhttp3/internal/http2/ErrorCode;Ljava/io/IOException;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (rstStatusCode);
				__args [1] = new JValue (errorException);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close_Lokhttp3_internal_http2_ErrorCode_Ljava_io_IOException_, __args);
			} finally {
			}
		}

		static IntPtr id_closeLater_Lokhttp3_internal_http2_ErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='closeLater' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.ErrorCode']]"
		[Register ("closeLater", "(Lokhttp3/internal/http2/ErrorCode;)V", "")]
		public unsafe void CloseLater (global::Okhttp3.Internal.Http2.ErrorCode errorCode)
		{
			if (id_closeLater_Lokhttp3_internal_http2_ErrorCode_ == IntPtr.Zero)
				id_closeLater_Lokhttp3_internal_http2_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "closeLater", "(Lokhttp3/internal/http2/ErrorCode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorCode);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeLater_Lokhttp3_internal_http2_ErrorCode_, __args);
			} finally {
			}
		}

		static IntPtr id_enqueueTrailers_Lokhttp3_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='enqueueTrailers' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("enqueueTrailers", "(Lokhttp3/Headers;)V", "")]
		public unsafe void EnqueueTrailers (global::Okhttp3.Headers trailers)
		{
			if (id_enqueueTrailers_Lokhttp3_Headers_ == IntPtr.Zero)
				id_enqueueTrailers_Lokhttp3_Headers_ = JNIEnv.GetMethodID (class_ref, "enqueueTrailers", "(Lokhttp3/Headers;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (trailers);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enqueueTrailers_Lokhttp3_Headers_, __args);
			} finally {
			}
		}

		static IntPtr id_takeHeaders;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='takeHeaders' and count(parameter)=0]"
		[Register ("takeHeaders", "()Lokhttp3/Headers;", "")]
		public unsafe global::Okhttp3.Headers TakeHeaders ()
		{
			if (id_takeHeaders == IntPtr.Zero)
				id_takeHeaders = JNIEnv.GetMethodID (class_ref, "takeHeaders", "()Lokhttp3/Headers;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeHeaders), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_trailers;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='trailers' and count(parameter)=0]"
		[Register ("trailers", "()Lokhttp3/Headers;", "")]
		public unsafe global::Okhttp3.Headers Trailers ()
		{
			if (id_trailers == IntPtr.Zero)
				id_trailers = JNIEnv.GetMethodID (class_ref, "trailers", "()Lokhttp3/Headers;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trailers), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeHeaders_Ljava_util_List_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Stream']/method[@name='writeHeaders' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("writeHeaders", "(Ljava/util/List;ZZ)V", "")]
		public unsafe void WriteHeaders (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> responseHeaders, bool outFinished, bool flushHeaders)
		{
			if (id_writeHeaders_Ljava_util_List_ZZ == IntPtr.Zero)
				id_writeHeaders_Ljava_util_List_ZZ = JNIEnv.GetMethodID (class_ref, "writeHeaders", "(Ljava/util/List;ZZ)V");
			IntPtr native_responseHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (responseHeaders);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_responseHeaders);
				__args [1] = new JValue (outFinished);
				__args [2] = new JValue (flushHeaders);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeHeaders_Ljava_util_List_ZZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_responseHeaders);
			}
		}

	}
}
