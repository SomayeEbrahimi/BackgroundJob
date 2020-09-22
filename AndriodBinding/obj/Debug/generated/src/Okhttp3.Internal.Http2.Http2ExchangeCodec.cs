using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2ExchangeCodec", DoNotGenerateAcw=true)]
	public sealed partial class Http2ExchangeCodec : global::Java.Lang.Object, global::Okhttp3.Internal.Http.IExchangeCodec {


		public static class InterfaceConsts {

			// The following are fields from: okhttp3.internal.http.ExchangeCodec

			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/field[@name='DISCARD_STREAM_TIMEOUT_MILLIS']"
			[Register ("DISCARD_STREAM_TIMEOUT_MILLIS")]
			public const int DiscardStreamTimeoutMillis = (int) 100;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http2/Http2ExchangeCodec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Http2ExchangeCodec); }
		}

		internal Http2ExchangeCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_OkHttpClient_Lokhttp3_internal_connection_RealConnection_Lokhttp3_Interceptor_Chain_Lokhttp3_internal_http2_Http2Connection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/constructor[@name='Http2ExchangeCodec' and count(parameter)=4 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='okhttp3.internal.connection.RealConnection'] and parameter[3][@type='okhttp3.Interceptor.Chain'] and parameter[4][@type='okhttp3.internal.http2.Http2Connection']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;Lokhttp3/internal/connection/RealConnection;Lokhttp3/Interceptor$Chain;Lokhttp3/internal/http2/Http2Connection;)V", "")]
		public unsafe Http2ExchangeCodec (global::Okhttp3.OkHttpClient client, global::Okhttp3.Internal.Connection.RealConnection realConnection, global::Okhttp3.IInterceptorChain chain, global::Okhttp3.Internal.Http2.Http2Connection connection)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (client);
				__args [1] = new JValue (realConnection);
				__args [2] = new JValue (chain);
				__args [3] = new JValue (connection);
				if (((object) this).GetType () != typeof (Http2ExchangeCodec)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/OkHttpClient;Lokhttp3/internal/connection/RealConnection;Lokhttp3/Interceptor$Chain;Lokhttp3/internal/http2/Http2Connection;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lokhttp3/OkHttpClient;Lokhttp3/internal/connection/RealConnection;Lokhttp3/Interceptor$Chain;Lokhttp3/internal/http2/Http2Connection;)V", __args);
					return;
				}

				if (id_ctor_Lokhttp3_OkHttpClient_Lokhttp3_internal_connection_RealConnection_Lokhttp3_Interceptor_Chain_Lokhttp3_internal_http2_Http2Connection_ == IntPtr.Zero)
					id_ctor_Lokhttp3_OkHttpClient_Lokhttp3_internal_connection_RealConnection_Lokhttp3_Interceptor_Chain_Lokhttp3_internal_http2_Http2Connection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/OkHttpClient;Lokhttp3/internal/connection/RealConnection;Lokhttp3/Interceptor$Chain;Lokhttp3/internal/http2/Http2Connection;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_OkHttpClient_Lokhttp3_internal_connection_RealConnection_Lokhttp3_Interceptor_Chain_Lokhttp3_internal_http2_Http2Connection_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lokhttp3_OkHttpClient_Lokhttp3_internal_connection_RealConnection_Lokhttp3_Interceptor_Chain_Lokhttp3_internal_http2_Http2Connection_, __args);
			} finally {
			}
		}

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/method[@name='cancel' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/method[@name='connection' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/method[@name='finishRequest' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/method[@name='flushRequest' and count(parameter)=0]"
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

		static IntPtr id_http2HeadersList_Lokhttp3_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/method[@name='http2HeadersList' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("http2HeadersList", "(Lokhttp3/Request;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> Http2HeadersList (global::Okhttp3.Request request)
		{
			if (id_http2HeadersList_Lokhttp3_Request_ == IntPtr.Zero)
				id_http2HeadersList_Lokhttp3_Request_ = JNIEnv.GetStaticMethodID (class_ref, "http2HeadersList", "(Lokhttp3/Request;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (request);
				global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> __ret = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_http2HeadersList_Lokhttp3_Request_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readHttp2HeadersList_Lokhttp3_Headers_Lokhttp3_Protocol_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/method[@name='readHttp2HeadersList' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='okhttp3.Protocol']]"
		[Register ("readHttp2HeadersList", "(Lokhttp3/Headers;Lokhttp3/Protocol;)Lokhttp3/Response$Builder;", "")]
		public static unsafe global::Okhttp3.Response.Builder ReadHttp2HeadersList (global::Okhttp3.Headers headerBlock, global::Okhttp3.Protocol protocol)
		{
			if (id_readHttp2HeadersList_Lokhttp3_Headers_Lokhttp3_Protocol_ == IntPtr.Zero)
				id_readHttp2HeadersList_Lokhttp3_Headers_Lokhttp3_Protocol_ = JNIEnv.GetStaticMethodID (class_ref, "readHttp2HeadersList", "(Lokhttp3/Headers;Lokhttp3/Protocol;)Lokhttp3/Response$Builder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (headerBlock);
				__args [1] = new JValue (protocol);
				global::Okhttp3.Response.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readHttp2HeadersList_Lokhttp3_Headers_Lokhttp3_Protocol_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readResponseHeaders_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/method[@name='readResponseHeaders' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/method[@name='reportedContentLength' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
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

		static IntPtr id_trailers;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/method[@name='trailers' and count(parameter)=0]"
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

		static IntPtr id_writeRequestHeaders_Lokhttp3_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2ExchangeCodec']/method[@name='writeRequestHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
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
