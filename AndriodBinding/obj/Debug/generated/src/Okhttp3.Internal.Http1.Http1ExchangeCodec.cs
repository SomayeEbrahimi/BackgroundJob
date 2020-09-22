using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http1 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']"
	[global::Android.Runtime.Register ("okhttp3/internal/http1/Http1ExchangeCodec", DoNotGenerateAcw=true)]
	public sealed partial class Http1ExchangeCodec : global::Java.Lang.Object, global::Okhttp3.Internal.Http.IExchangeCodec {


		public static class InterfaceConsts {

			// The following are fields from: okhttp3.internal.http.ExchangeCodec

			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/field[@name='DISCARD_STREAM_TIMEOUT_MILLIS']"
			[Register ("DISCARD_STREAM_TIMEOUT_MILLIS")]
			public const int DiscardStreamTimeoutMillis = (int) 100;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http1/Http1ExchangeCodec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Http1ExchangeCodec); }
		}

		internal Http1ExchangeCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isClosed;
		public unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosed);
				} finally {
				}
			}
		}

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
			} finally {
			}
		}

		static IntPtr id_connection;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='connection' and count(parameter)=0]"
		[Register ("connection", "()Lokhttp3/internal/connection/RealConnection;", "")]
		public unsafe global::Okhttp3.Internal.Connection.RealConnection Connection ()
		{
			if (id_connection == IntPtr.Zero)
				id_connection = JNIEnv.GetMethodID (class_ref, "connection", "()Lokhttp3/internal/connection/RealConnection;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RealConnection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connection), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_finishRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='finishRequest' and count(parameter)=0]"
		[Register ("finishRequest", "()V", "")]
		public unsafe void FinishRequest ()
		{
			if (id_finishRequest == IntPtr.Zero)
				id_finishRequest = JNIEnv.GetMethodID (class_ref, "finishRequest", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishRequest);
			} finally {
			}
		}

		static IntPtr id_flushRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='flushRequest' and count(parameter)=0]"
		[Register ("flushRequest", "()V", "")]
		public unsafe void FlushRequest ()
		{
			if (id_flushRequest == IntPtr.Zero)
				id_flushRequest = JNIEnv.GetMethodID (class_ref, "flushRequest", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flushRequest);
			} finally {
			}
		}

		static IntPtr id_readResponseHeaders_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='readResponseHeaders' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("readResponseHeaders", "(Z)Lokhttp3/Response$Builder;", "")]
		public unsafe global::Okhttp3.Response.Builder ReadResponseHeaders (bool expectContinue)
		{
			if (id_readResponseHeaders_Z == IntPtr.Zero)
				id_readResponseHeaders_Z = JNIEnv.GetMethodID (class_ref, "readResponseHeaders", "(Z)Lokhttp3/Response$Builder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (expectContinue);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readResponseHeaders_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_reportedContentLength_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='reportedContentLength' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("reportedContentLength", "(Lokhttp3/Response;)J", "")]
		public unsafe long ReportedContentLength (global::Okhttp3.Response response)
		{
			if (id_reportedContentLength_Lokhttp3_Response_ == IntPtr.Zero)
				id_reportedContentLength_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "reportedContentLength", "(Lokhttp3/Response;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_reportedContentLength_Lokhttp3_Response_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skipConnectBody_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='skipConnectBody' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("skipConnectBody", "(Lokhttp3/Response;)V", "")]
		public unsafe void SkipConnectBody (global::Okhttp3.Response response)
		{
			if (id_skipConnectBody_Lokhttp3_Response_ == IntPtr.Zero)
				id_skipConnectBody_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "skipConnectBody", "(Lokhttp3/Response;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipConnectBody_Lokhttp3_Response_, __args);
			} finally {
			}
		}

		static IntPtr id_trailers;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='trailers' and count(parameter)=0]"
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

		static IntPtr id_writeRequest_Lokhttp3_Headers_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='writeRequest' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeRequest", "(Lokhttp3/Headers;Ljava/lang/String;)V", "")]
		public unsafe void WriteRequest (global::Okhttp3.Headers headers, string requestLine)
		{
			if (id_writeRequest_Lokhttp3_Headers_Ljava_lang_String_ == IntPtr.Zero)
				id_writeRequest_Lokhttp3_Headers_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeRequest", "(Lokhttp3/Headers;Ljava/lang/String;)V");
			IntPtr native_requestLine = JNIEnv.NewString (requestLine);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (headers);
				__args [1] = new JValue (native_requestLine);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeRequest_Lokhttp3_Headers_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestLine);
			}
		}

		static IntPtr id_writeRequestHeaders_Lokhttp3_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1ExchangeCodec']/method[@name='writeRequestHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("writeRequestHeaders", "(Lokhttp3/Request;)V", "")]
		public unsafe void WriteRequestHeaders (global::Okhttp3.Request request)
		{
			if (id_writeRequestHeaders_Lokhttp3_Request_ == IntPtr.Zero)
				id_writeRequestHeaders_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "writeRequestHeaders", "(Lokhttp3/Request;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (request);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeRequestHeaders_Lokhttp3_Request_, __args);
			} finally {
			}
		}

	}
}
