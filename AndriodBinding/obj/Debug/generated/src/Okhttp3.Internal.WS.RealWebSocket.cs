using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.WS {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']"
	[global::Android.Runtime.Register ("okhttp3/internal/ws/RealWebSocket", DoNotGenerateAcw=true)]
	public sealed partial class RealWebSocket : global::Java.Lang.Object, global::Okhttp3.IWebSocket {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.Streams']"
		[global::Android.Runtime.Register ("okhttp3/internal/ws/RealWebSocket$Streams", DoNotGenerateAcw=true)]
		public abstract partial class Streams : global::Java.Lang.Object, global::Java.IO.ICloseable {


			static IntPtr client_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.Streams']/field[@name='client']"
			[Register ("client")]
			public bool Client {
				get {
					if (client_jfieldId == IntPtr.Zero)
						client_jfieldId = JNIEnv.GetFieldID (class_ref, "client", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, client_jfieldId);
				}
				set {
					if (client_jfieldId == IntPtr.Zero)
						client_jfieldId = JNIEnv.GetFieldID (class_ref, "client", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, client_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/internal/ws/RealWebSocket$Streams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Streams); }
			}

			protected Streams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_close;
#pragma warning disable 0169
			static Delegate GetCloseHandler ()
			{
				if (cb_close == null)
					cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
				return cb_close;
			}

			static void n_Close (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.WS.RealWebSocket.Streams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			[Register ("close", "()V", "GetCloseHandler")]
			public abstract void Close ();

		}

		[global::Android.Runtime.Register ("okhttp3/internal/ws/RealWebSocket$Streams", DoNotGenerateAcw=true)]
		internal partial class StreamsInvoker : Streams {

			public StreamsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (StreamsInvoker); }
			}

			static IntPtr id_close;
			[Register ("close", "()V", "GetCloseHandler")]
			public override unsafe void Close ()
			{
				if (id_close == IntPtr.Zero)
					id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				} finally {
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/ws/RealWebSocket", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RealWebSocket); }
		}

		internal RealWebSocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_Request_Lokhttp3_WebSocketListener_Ljava_util_Random_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/constructor[@name='RealWebSocket' and count(parameter)=4 and parameter[1][@type='okhttp3.Request'] and parameter[2][@type='okhttp3.WebSocketListener'] and parameter[3][@type='java.util.Random'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Lokhttp3/Request;Lokhttp3/WebSocketListener;Ljava/util/Random;J)V", "")]
		public unsafe RealWebSocket (global::Okhttp3.Request request, global::Okhttp3.WebSocketListener listener, global::Java.Util.Random random, long pingIntervalMillis)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (request);
				__args [1] = new JValue (listener);
				__args [2] = new JValue (random);
				__args [3] = new JValue (pingIntervalMillis);
				if (((object) this).GetType () != typeof (RealWebSocket)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/Request;Lokhttp3/WebSocketListener;Ljava/util/Random;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lokhttp3/Request;Lokhttp3/WebSocketListener;Ljava/util/Random;J)V", __args);
					return;
				}

				if (id_ctor_Lokhttp3_Request_Lokhttp3_WebSocketListener_Ljava_util_Random_J == IntPtr.Zero)
					id_ctor_Lokhttp3_Request_Lokhttp3_WebSocketListener_Ljava_util_Random_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/Request;Lokhttp3/WebSocketListener;Ljava/util/Random;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_Request_Lokhttp3_WebSocketListener_Ljava_util_Random_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lokhttp3_Request_Lokhttp3_WebSocketListener_Ljava_util_Random_J, __args);
			} finally {
			}
		}

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='cancel' and count(parameter)=0]"
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

		static IntPtr id_close_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='close' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("close", "(ILjava/lang/String;)Z", "")]
		public unsafe bool Close (int code, string reason)
		{
			if (id_close_ILjava_lang_String_ == IntPtr.Zero)
				id_close_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "close", "(ILjava/lang/String;)Z");
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (code);
				__args [1] = new JValue (native_reason);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_close_ILjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static IntPtr id_connect_Lokhttp3_OkHttpClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
		[Register ("connect", "(Lokhttp3/OkHttpClient;)V", "")]
		public unsafe void Connect (global::Okhttp3.OkHttpClient client)
		{
			if (id_connect_Lokhttp3_OkHttpClient_ == IntPtr.Zero)
				id_connect_Lokhttp3_OkHttpClient_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lokhttp3/OkHttpClient;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (client);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lokhttp3_OkHttpClient_, __args);
			} finally {
			}
		}

		static IntPtr id_failWebSocket_Ljava_lang_Exception_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='failWebSocket' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("failWebSocket", "(Ljava/lang/Exception;Lokhttp3/Response;)V", "")]
		public unsafe void FailWebSocket (global::Java.Lang.Exception e, global::Okhttp3.Response response)
		{
			if (id_failWebSocket_Ljava_lang_Exception_Lokhttp3_Response_ == IntPtr.Zero)
				id_failWebSocket_Ljava_lang_Exception_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "failWebSocket", "(Ljava/lang/Exception;Lokhttp3/Response;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (e);
				__args [1] = new JValue (response);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_failWebSocket_Ljava_lang_Exception_Lokhttp3_Response_, __args);
			} finally {
			}
		}

		static IntPtr id_initReaderAndWriter_Ljava_lang_String_Lokhttp3_internal_ws_RealWebSocket_Streams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='initReaderAndWriter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='okhttp3.internal.ws.RealWebSocket.Streams']]"
		[Register ("initReaderAndWriter", "(Ljava/lang/String;Lokhttp3/internal/ws/RealWebSocket$Streams;)V", "")]
		public unsafe void InitReaderAndWriter (string name, global::Okhttp3.Internal.WS.RealWebSocket.Streams streams)
		{
			if (id_initReaderAndWriter_Ljava_lang_String_Lokhttp3_internal_ws_RealWebSocket_Streams_ == IntPtr.Zero)
				id_initReaderAndWriter_Ljava_lang_String_Lokhttp3_internal_ws_RealWebSocket_Streams_ = JNIEnv.GetMethodID (class_ref, "initReaderAndWriter", "(Ljava/lang/String;Lokhttp3/internal/ws/RealWebSocket$Streams;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (streams);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initReaderAndWriter_Ljava_lang_String_Lokhttp3_internal_ws_RealWebSocket_Streams_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_loopReader;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='loopReader' and count(parameter)=0]"
		[Register ("loopReader", "()V", "")]
		public unsafe void LoopReader ()
		{
			if (id_loopReader == IntPtr.Zero)
				id_loopReader = JNIEnv.GetMethodID (class_ref, "loopReader", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loopReader);
			} finally {
			}
		}

		static IntPtr id_onReadClose_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='onReadClose' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onReadClose", "(ILjava/lang/String;)V", "")]
		public unsafe void OnReadClose (int code, string reason)
		{
			if (id_onReadClose_ILjava_lang_String_ == IntPtr.Zero)
				id_onReadClose_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReadClose", "(ILjava/lang/String;)V");
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (code);
				__args [1] = new JValue (native_reason);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadClose_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static IntPtr id_onReadMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='onReadMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReadMessage", "(Ljava/lang/String;)V", "")]
		public unsafe void OnReadMessage (string text)
		{
			if (id_onReadMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_onReadMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReadMessage", "(Ljava/lang/String;)V");
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_text);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadMessage_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static IntPtr id_queueSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='queueSize' and count(parameter)=0]"
		[Register ("queueSize", "()J", "")]
		public unsafe long QueueSize ()
		{
			if (id_queueSize == IntPtr.Zero)
				id_queueSize = JNIEnv.GetMethodID (class_ref, "queueSize", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_queueSize);
			} finally {
			}
		}

		static IntPtr id_request;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='request' and count(parameter)=0]"
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

		static IntPtr id_send_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Send (string text)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)Z");
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_text);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

	}
}
