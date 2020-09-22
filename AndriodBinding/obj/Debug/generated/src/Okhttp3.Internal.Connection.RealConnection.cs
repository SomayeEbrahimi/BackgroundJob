using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/RealConnection", DoNotGenerateAcw=true)]
	public sealed partial class RealConnection : global::Okhttp3.Internal.Http2.Http2Connection.Listener, global::Okhttp3.IConnection {


		static IntPtr connectionPool_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/field[@name='connectionPool']"
		[Register ("connectionPool")]
		public global::Okhttp3.Internal.Connection.RealConnectionPool ConnectionPool {
			get {
				if (connectionPool_jfieldId == IntPtr.Zero)
					connectionPool_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionPool", "Lokhttp3/internal/connection/RealConnectionPool;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, connectionPool_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RealConnectionPool> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (connectionPool_jfieldId == IntPtr.Zero)
					connectionPool_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionPool", "Lokhttp3/internal/connection/RealConnectionPool;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connectionPool_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/connection/RealConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RealConnection); }
		}

		internal RealConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_internal_connection_RealConnectionPool_Lokhttp3_Route_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/constructor[@name='RealConnection' and count(parameter)=2 and parameter[1][@type='okhttp3.internal.connection.RealConnectionPool'] and parameter[2][@type='okhttp3.Route']]"
		[Register (".ctor", "(Lokhttp3/internal/connection/RealConnectionPool;Lokhttp3/Route;)V", "")]
		public unsafe RealConnection (global::Okhttp3.Internal.Connection.RealConnectionPool connectionPool, global::Okhttp3.Route route)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (connectionPool);
				__args [1] = new JValue (route);
				if (((object) this).GetType () != typeof (RealConnection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/internal/connection/RealConnectionPool;Lokhttp3/Route;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lokhttp3/internal/connection/RealConnectionPool;Lokhttp3/Route;)V", __args);
					return;
				}

				if (id_ctor_Lokhttp3_internal_connection_RealConnectionPool_Lokhttp3_Route_ == IntPtr.Zero)
					id_ctor_Lokhttp3_internal_connection_RealConnectionPool_Lokhttp3_Route_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/internal/connection/RealConnectionPool;Lokhttp3/Route;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_internal_connection_RealConnectionPool_Lokhttp3_Route_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lokhttp3_internal_connection_RealConnectionPool_Lokhttp3_Route_, __args);
			} finally {
			}
		}

		static IntPtr id_isMultiplexed;
		public unsafe bool IsMultiplexed {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='isMultiplexed' and count(parameter)=0]"
			[Register ("isMultiplexed", "()Z", "")]
			get {
				if (id_isMultiplexed == IntPtr.Zero)
					id_isMultiplexed = JNIEnv.GetMethodID (class_ref, "isMultiplexed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMultiplexed);
				} finally {
				}
			}
		}

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='cancel' and count(parameter)=0]"
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

		static IntPtr id_connect_IIIIZLokhttp3_Call_Lokhttp3_EventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='connect' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='okhttp3.Call'] and parameter[7][@type='okhttp3.EventListener']]"
		[Register ("connect", "(IIIIZLokhttp3/Call;Lokhttp3/EventListener;)V", "")]
		public unsafe void Connect (int connectTimeout, int readTimeout, int writeTimeout, int pingIntervalMillis, bool connectionRetryEnabled, global::Okhttp3.ICall call, global::Okhttp3.EventListener eventListener)
		{
			if (id_connect_IIIIZLokhttp3_Call_Lokhttp3_EventListener_ == IntPtr.Zero)
				id_connect_IIIIZLokhttp3_Call_Lokhttp3_EventListener_ = JNIEnv.GetMethodID (class_ref, "connect", "(IIIIZLokhttp3/Call;Lokhttp3/EventListener;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (connectTimeout);
				__args [1] = new JValue (readTimeout);
				__args [2] = new JValue (writeTimeout);
				__args [3] = new JValue (pingIntervalMillis);
				__args [4] = new JValue (connectionRetryEnabled);
				__args [5] = new JValue (call);
				__args [6] = new JValue (eventListener);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_IIIIZLokhttp3_Call_Lokhttp3_EventListener_, __args);
			} finally {
			}
		}

		static IntPtr id_handshake;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='handshake' and count(parameter)=0]"
		[Register ("handshake", "()Lokhttp3/Handshake;", "")]
		public unsafe global::Okhttp3.Handshake Handshake ()
		{
			if (id_handshake == IntPtr.Zero)
				id_handshake = JNIEnv.GetMethodID (class_ref, "handshake", "()Lokhttp3/Handshake;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handshake), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_isHealthy_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='isHealthy' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isHealthy", "(Z)Z", "")]
		public unsafe bool IsHealthy (bool doExtensiveChecks)
		{
			if (id_isHealthy_Z == IntPtr.Zero)
				id_isHealthy_Z = JNIEnv.GetMethodID (class_ref, "isHealthy", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (doExtensiveChecks);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHealthy_Z, __args);
			} finally {
			}
		}

		static IntPtr id_noNewExchanges;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='noNewExchanges' and count(parameter)=0]"
		[Register ("noNewExchanges", "()V", "")]
		public unsafe void NoNewExchanges ()
		{
			if (id_noNewExchanges == IntPtr.Zero)
				id_noNewExchanges = JNIEnv.GetMethodID (class_ref, "noNewExchanges", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_noNewExchanges);
			} finally {
			}
		}

		static IntPtr id_onStream_Lokhttp3_internal_http2_Http2Stream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='onStream' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Http2Stream']]"
		[Register ("onStream", "(Lokhttp3/internal/http2/Http2Stream;)V", "")]
		public override unsafe void OnStream (global::Okhttp3.Internal.Http2.Http2Stream stream)
		{
			if (id_onStream_Lokhttp3_internal_http2_Http2Stream_ == IntPtr.Zero)
				id_onStream_Lokhttp3_internal_http2_Http2Stream_ = JNIEnv.GetMethodID (class_ref, "onStream", "(Lokhttp3/internal/http2/Http2Stream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (stream);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStream_Lokhttp3_internal_http2_Http2Stream_, __args);
			} finally {
			}
		}

		static IntPtr id_protocol;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='protocol' and count(parameter)=0]"
		[Register ("protocol", "()Lokhttp3/Protocol;", "")]
		public unsafe global::Okhttp3.Protocol Protocol ()
		{
			if (id_protocol == IntPtr.Zero)
				id_protocol = JNIEnv.GetMethodID (class_ref, "protocol", "()Lokhttp3/Protocol;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_protocol), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_route;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='route' and count(parameter)=0]"
		[Register ("route", "()Lokhttp3/Route;", "")]
		public unsafe global::Okhttp3.Route Route ()
		{
			if (id_route == IntPtr.Zero)
				id_route = JNIEnv.GetMethodID (class_ref, "route", "()Lokhttp3/Route;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Route> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_route), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_socket;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='socket' and count(parameter)=0]"
		[Register ("socket", "()Ljava/net/Socket;", "")]
		public unsafe global::Java.Net.Socket Socket ()
		{
			if (id_socket == IntPtr.Zero)
				id_socket = JNIEnv.GetMethodID (class_ref, "socket", "()Ljava/net/Socket;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_socket), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_supportsUrl_Lokhttp3_HttpUrl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='supportsUrl' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
		[Register ("supportsUrl", "(Lokhttp3/HttpUrl;)Z", "")]
		public unsafe bool SupportsUrl (global::Okhttp3.HttpUrl url)
		{
			if (id_supportsUrl_Lokhttp3_HttpUrl_ == IntPtr.Zero)
				id_supportsUrl_Lokhttp3_HttpUrl_ = JNIEnv.GetMethodID (class_ref, "supportsUrl", "(Lokhttp3/HttpUrl;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (url);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_supportsUrl_Lokhttp3_HttpUrl_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
