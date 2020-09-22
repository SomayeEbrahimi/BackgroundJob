using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/RealInterceptorChain", DoNotGenerateAcw=true)]
	public sealed partial class RealInterceptorChain : global::Java.Lang.Object, global::Okhttp3.IInterceptorChain {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http/RealInterceptorChain", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RealInterceptorChain); }
		}

		internal RealInterceptorChain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_Lokhttp3_internal_connection_Transmitter_Lokhttp3_internal_connection_Exchange_ILokhttp3_Request_Lokhttp3_Call_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/constructor[@name='RealInterceptorChain' and count(parameter)=9 and parameter[1][@type='java.util.List&lt;okhttp3.Interceptor&gt;'] and parameter[2][@type='okhttp3.internal.connection.Transmitter'] and parameter[3][@type='okhttp3.internal.connection.Exchange'] and parameter[4][@type='int'] and parameter[5][@type='okhttp3.Request'] and parameter[6][@type='okhttp3.Call'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register (".ctor", "(Ljava/util/List;Lokhttp3/internal/connection/Transmitter;Lokhttp3/internal/connection/Exchange;ILokhttp3/Request;Lokhttp3/Call;III)V", "")]
		public unsafe RealInterceptorChain (global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> interceptors, global::Okhttp3.Internal.Connection.Transmitter transmitter, global::Okhttp3.Internal.Connection.Exchange exchange, int index, global::Okhttp3.Request request, global::Okhttp3.ICall call, int connectTimeout, int readTimeout, int writeTimeout)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_interceptors = global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.ToLocalJniHandle (interceptors);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_interceptors);
				__args [1] = new JValue (transmitter);
				__args [2] = new JValue (exchange);
				__args [3] = new JValue (index);
				__args [4] = new JValue (request);
				__args [5] = new JValue (call);
				__args [6] = new JValue (connectTimeout);
				__args [7] = new JValue (readTimeout);
				__args [8] = new JValue (writeTimeout);
				if (((object) this).GetType () != typeof (RealInterceptorChain)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;Lokhttp3/internal/connection/Transmitter;Lokhttp3/internal/connection/Exchange;ILokhttp3/Request;Lokhttp3/Call;III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;Lokhttp3/internal/connection/Transmitter;Lokhttp3/internal/connection/Exchange;ILokhttp3/Request;Lokhttp3/Call;III)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_Lokhttp3_internal_connection_Transmitter_Lokhttp3_internal_connection_Exchange_ILokhttp3_Request_Lokhttp3_Call_III == IntPtr.Zero)
					id_ctor_Ljava_util_List_Lokhttp3_internal_connection_Transmitter_Lokhttp3_internal_connection_Exchange_ILokhttp3_Request_Lokhttp3_Call_III = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Lokhttp3/internal/connection/Transmitter;Lokhttp3/internal/connection/Exchange;ILokhttp3/Request;Lokhttp3/Call;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Lokhttp3_internal_connection_Transmitter_Lokhttp3_internal_connection_Exchange_ILokhttp3_Request_Lokhttp3_Call_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_Lokhttp3_internal_connection_Transmitter_Lokhttp3_internal_connection_Exchange_ILokhttp3_Request_Lokhttp3_Call_III, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_interceptors);
			}
		}

		static IntPtr id_call;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lokhttp3/Call;", "")]
		public unsafe global::Okhttp3.ICall Call ()
		{
			if (id_call == IntPtr.Zero)
				id_call = JNIEnv.GetMethodID (class_ref, "call", "()Lokhttp3/Call;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_connectTimeoutMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='connectTimeoutMillis' and count(parameter)=0]"
		[Register ("connectTimeoutMillis", "()I", "")]
		public unsafe int ConnectTimeoutMillis ()
		{
			if (id_connectTimeoutMillis == IntPtr.Zero)
				id_connectTimeoutMillis = JNIEnv.GetMethodID (class_ref, "connectTimeoutMillis", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectTimeoutMillis);
			} finally {
			}
		}

		static IntPtr id_connection;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='connection' and count(parameter)=0]"
		[Register ("connection", "()Lokhttp3/Connection;", "")]
		public unsafe global::Okhttp3.IConnection Connection ()
		{
			if (id_connection == IntPtr.Zero)
				id_connection = JNIEnv.GetMethodID (class_ref, "connection", "()Lokhttp3/Connection;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connection), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_exchange;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='exchange' and count(parameter)=0]"
		[Register ("exchange", "()Lokhttp3/internal/connection/Exchange;", "")]
		public unsafe global::Okhttp3.Internal.Connection.Exchange Exchange ()
		{
			if (id_exchange == IntPtr.Zero)
				id_exchange = JNIEnv.GetMethodID (class_ref, "exchange", "()Lokhttp3/internal/connection/Exchange;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.Exchange> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_exchange), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_proceed_Lokhttp3_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='proceed' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("proceed", "(Lokhttp3/Request;)Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response Proceed (global::Okhttp3.Request request)
		{
			if (id_proceed_Lokhttp3_Request_ == IntPtr.Zero)
				id_proceed_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "proceed", "(Lokhttp3/Request;)Lokhttp3/Response;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (request);
				global::Okhttp3.Response __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proceed_Lokhttp3_Request_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_proceed_Lokhttp3_Request_Lokhttp3_internal_connection_Transmitter_Lokhttp3_internal_connection_Exchange_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='proceed' and count(parameter)=3 and parameter[1][@type='okhttp3.Request'] and parameter[2][@type='okhttp3.internal.connection.Transmitter'] and parameter[3][@type='okhttp3.internal.connection.Exchange']]"
		[Register ("proceed", "(Lokhttp3/Request;Lokhttp3/internal/connection/Transmitter;Lokhttp3/internal/connection/Exchange;)Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response Proceed (global::Okhttp3.Request request, global::Okhttp3.Internal.Connection.Transmitter transmitter, global::Okhttp3.Internal.Connection.Exchange exchange)
		{
			if (id_proceed_Lokhttp3_Request_Lokhttp3_internal_connection_Transmitter_Lokhttp3_internal_connection_Exchange_ == IntPtr.Zero)
				id_proceed_Lokhttp3_Request_Lokhttp3_internal_connection_Transmitter_Lokhttp3_internal_connection_Exchange_ = JNIEnv.GetMethodID (class_ref, "proceed", "(Lokhttp3/Request;Lokhttp3/internal/connection/Transmitter;Lokhttp3/internal/connection/Exchange;)Lokhttp3/Response;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (request);
				__args [1] = new JValue (transmitter);
				__args [2] = new JValue (exchange);
				global::Okhttp3.Response __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proceed_Lokhttp3_Request_Lokhttp3_internal_connection_Transmitter_Lokhttp3_internal_connection_Exchange_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readTimeoutMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='readTimeoutMillis' and count(parameter)=0]"
		[Register ("readTimeoutMillis", "()I", "")]
		public unsafe int ReadTimeoutMillis ()
		{
			if (id_readTimeoutMillis == IntPtr.Zero)
				id_readTimeoutMillis = JNIEnv.GetMethodID (class_ref, "readTimeoutMillis", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readTimeoutMillis);
			} finally {
			}
		}

		static IntPtr id_request;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='request' and count(parameter)=0]"
		[Register ("request", "()Lokhttp3/Request;", "")]
		public unsafe global::Okhttp3.Request Request ()
		{
			if (id_request == IntPtr.Zero)
				id_request = JNIEnv.GetMethodID (class_ref, "request", "()Lokhttp3/Request;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_request), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_transmitter;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='transmitter' and count(parameter)=0]"
		[Register ("transmitter", "()Lokhttp3/internal/connection/Transmitter;", "")]
		public unsafe global::Okhttp3.Internal.Connection.Transmitter Transmitter ()
		{
			if (id_transmitter == IntPtr.Zero)
				id_transmitter = JNIEnv.GetMethodID (class_ref, "transmitter", "()Lokhttp3/internal/connection/Transmitter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.Transmitter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transmitter), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_withConnectTimeout_ILjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='withConnectTimeout' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("withConnectTimeout", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;", "")]
		public unsafe global::Okhttp3.IInterceptorChain WithConnectTimeout (int timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_withConnectTimeout_ILjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_withConnectTimeout_ILjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "withConnectTimeout", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::Okhttp3.IInterceptorChain __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptorChain> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withConnectTimeout_ILjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_withReadTimeout_ILjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='withReadTimeout' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("withReadTimeout", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;", "")]
		public unsafe global::Okhttp3.IInterceptorChain WithReadTimeout (int timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_withReadTimeout_ILjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_withReadTimeout_ILjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "withReadTimeout", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::Okhttp3.IInterceptorChain __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptorChain> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withReadTimeout_ILjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_withWriteTimeout_ILjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='withWriteTimeout' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("withWriteTimeout", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;", "")]
		public unsafe global::Okhttp3.IInterceptorChain WithWriteTimeout (int timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_withWriteTimeout_ILjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_withWriteTimeout_ILjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "withWriteTimeout", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::Okhttp3.IInterceptorChain __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptorChain> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withWriteTimeout_ILjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_writeTimeoutMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='writeTimeoutMillis' and count(parameter)=0]"
		[Register ("writeTimeoutMillis", "()I", "")]
		public unsafe int WriteTimeoutMillis ()
		{
			if (id_writeTimeoutMillis == IntPtr.Zero)
				id_writeTimeoutMillis = JNIEnv.GetMethodID (class_ref, "writeTimeoutMillis", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeTimeoutMillis);
			} finally {
			}
		}

	}
}
