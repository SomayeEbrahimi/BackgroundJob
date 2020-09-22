using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/Exchange", DoNotGenerateAcw=true)]
	public sealed partial class Exchange : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/connection/Exchange", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Exchange); }
		}

		internal Exchange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isDuplex;
		public unsafe bool IsDuplex {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='isDuplex' and count(parameter)=0]"
			[Register ("isDuplex", "()Z", "")]
			get {
				if (id_isDuplex == IntPtr.Zero)
					id_isDuplex = JNIEnv.GetMethodID (class_ref, "isDuplex", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDuplex);
				} finally {
				}
			}
		}

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='cancel' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='connection' and count(parameter)=0]"
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

		static IntPtr id_detachWithViolence;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='detachWithViolence' and count(parameter)=0]"
		[Register ("detachWithViolence", "()V", "")]
		public unsafe void DetachWithViolence ()
		{
			if (id_detachWithViolence == IntPtr.Zero)
				id_detachWithViolence = JNIEnv.GetMethodID (class_ref, "detachWithViolence", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detachWithViolence);
			} finally {
			}
		}

		static IntPtr id_finishRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='finishRequest' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='flushRequest' and count(parameter)=0]"
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

		static IntPtr id_newWebSocketStreams;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='newWebSocketStreams' and count(parameter)=0]"
		[Register ("newWebSocketStreams", "()Lokhttp3/internal/ws/RealWebSocket$Streams;", "")]
		public unsafe global::Okhttp3.Internal.WS.RealWebSocket.Streams NewWebSocketStreams ()
		{
			if (id_newWebSocketStreams == IntPtr.Zero)
				id_newWebSocketStreams = JNIEnv.GetMethodID (class_ref, "newWebSocketStreams", "()Lokhttp3/internal/ws/RealWebSocket$Streams;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.WS.RealWebSocket.Streams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newWebSocketStreams), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_noNewExchangesOnConnection;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='noNewExchangesOnConnection' and count(parameter)=0]"
		[Register ("noNewExchangesOnConnection", "()V", "")]
		public unsafe void NoNewExchangesOnConnection ()
		{
			if (id_noNewExchangesOnConnection == IntPtr.Zero)
				id_noNewExchangesOnConnection = JNIEnv.GetMethodID (class_ref, "noNewExchangesOnConnection", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_noNewExchangesOnConnection);
			} finally {
			}
		}

		static IntPtr id_noRequestBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='noRequestBody' and count(parameter)=0]"
		[Register ("noRequestBody", "()V", "")]
		public unsafe void NoRequestBody ()
		{
			if (id_noRequestBody == IntPtr.Zero)
				id_noRequestBody = JNIEnv.GetMethodID (class_ref, "noRequestBody", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_noRequestBody);
			} finally {
			}
		}

		static IntPtr id_openResponseBody_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='openResponseBody' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("openResponseBody", "(Lokhttp3/Response;)Lokhttp3/ResponseBody;", "")]
		public unsafe global::Okhttp3.ResponseBody OpenResponseBody (global::Okhttp3.Response response)
		{
			if (id_openResponseBody_Lokhttp3_Response_ == IntPtr.Zero)
				id_openResponseBody_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "openResponseBody", "(Lokhttp3/Response;)Lokhttp3/ResponseBody;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				global::Okhttp3.ResponseBody __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openResponseBody_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readResponseHeaders_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='readResponseHeaders' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static IntPtr id_responseHeadersEnd_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='responseHeadersEnd' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("responseHeadersEnd", "(Lokhttp3/Response;)V", "")]
		public unsafe void ResponseHeadersEnd (global::Okhttp3.Response response)
		{
			if (id_responseHeadersEnd_Lokhttp3_Response_ == IntPtr.Zero)
				id_responseHeadersEnd_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "responseHeadersEnd", "(Lokhttp3/Response;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_responseHeadersEnd_Lokhttp3_Response_, __args);
			} finally {
			}
		}

		static IntPtr id_responseHeadersStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='responseHeadersStart' and count(parameter)=0]"
		[Register ("responseHeadersStart", "()V", "")]
		public unsafe void ResponseHeadersStart ()
		{
			if (id_responseHeadersStart == IntPtr.Zero)
				id_responseHeadersStart = JNIEnv.GetMethodID (class_ref, "responseHeadersStart", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_responseHeadersStart);
			} finally {
			}
		}

		static IntPtr id_timeoutEarlyExit;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='timeoutEarlyExit' and count(parameter)=0]"
		[Register ("timeoutEarlyExit", "()V", "")]
		public unsafe void TimeoutEarlyExit ()
		{
			if (id_timeoutEarlyExit == IntPtr.Zero)
				id_timeoutEarlyExit = JNIEnv.GetMethodID (class_ref, "timeoutEarlyExit", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_timeoutEarlyExit);
			} finally {
			}
		}

		static IntPtr id_trailers;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='trailers' and count(parameter)=0]"
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

		static IntPtr id_webSocketUpgradeFailed;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='webSocketUpgradeFailed' and count(parameter)=0]"
		[Register ("webSocketUpgradeFailed", "()V", "")]
		public unsafe void WebSocketUpgradeFailed ()
		{
			if (id_webSocketUpgradeFailed == IntPtr.Zero)
				id_webSocketUpgradeFailed = JNIEnv.GetMethodID (class_ref, "webSocketUpgradeFailed", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_webSocketUpgradeFailed);
			} finally {
			}
		}

		static IntPtr id_writeRequestHeaders_Lokhttp3_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Exchange']/method[@name='writeRequestHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
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
