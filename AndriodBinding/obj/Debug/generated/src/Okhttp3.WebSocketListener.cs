using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']"
	[global::Android.Runtime.Register ("okhttp3/WebSocketListener", DoNotGenerateAcw=true)]
	public abstract partial class WebSocketListener : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/WebSocketListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebSocketListener); }
		}

		protected WebSocketListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/constructor[@name='WebSocketListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebSocketListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (WebSocketListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnClosed_Lokhttp3_WebSocket_ILjava_lang_String_Handler ()
		{
			if (cb_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_ == null)
				cb_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnClosed_Lokhttp3_WebSocket_ILjava_lang_String_);
			return cb_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_;
		}

		static void n_OnClosed_Lokhttp3_WebSocket_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocket, int code, IntPtr native_reason)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var webSocket = (global::Okhttp3.IWebSocket)global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (native_webSocket, JniHandleOwnership.DoNotTransfer);
			var reason = JNIEnv.GetString (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.OnClosed (webSocket, code, reason);
		}
#pragma warning restore 0169

		static IntPtr id_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/method[@name='onClosed' and count(parameter)=3 and parameter[1][@type='okhttp3.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onClosed", "(Lokhttp3/WebSocket;ILjava/lang/String;)V", "GetOnClosed_Lokhttp3_WebSocket_ILjava_lang_String_Handler")]
		public virtual unsafe void OnClosed (global::Okhttp3.IWebSocket webSocket, int code, string reason)
		{
			if (id_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_ == IntPtr.Zero)
				id_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onClosed", "(Lokhttp3/WebSocket;ILjava/lang/String;)V");
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (webSocket);
				__args [1] = new JValue (code);
				__args [2] = new JValue (native_reason);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClosed", "(Lokhttp3/WebSocket;ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static Delegate cb_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnClosing_Lokhttp3_WebSocket_ILjava_lang_String_Handler ()
		{
			if (cb_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_ == null)
				cb_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnClosing_Lokhttp3_WebSocket_ILjava_lang_String_);
			return cb_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_;
		}

		static void n_OnClosing_Lokhttp3_WebSocket_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocket, int code, IntPtr native_reason)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var webSocket = (global::Okhttp3.IWebSocket)global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (native_webSocket, JniHandleOwnership.DoNotTransfer);
			var reason = JNIEnv.GetString (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.OnClosing (webSocket, code, reason);
		}
#pragma warning restore 0169

		static IntPtr id_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/method[@name='onClosing' and count(parameter)=3 and parameter[1][@type='okhttp3.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onClosing", "(Lokhttp3/WebSocket;ILjava/lang/String;)V", "GetOnClosing_Lokhttp3_WebSocket_ILjava_lang_String_Handler")]
		public virtual unsafe void OnClosing (global::Okhttp3.IWebSocket webSocket, int code, string reason)
		{
			if (id_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_ == IntPtr.Zero)
				id_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onClosing", "(Lokhttp3/WebSocket;ILjava/lang/String;)V");
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (webSocket);
				__args [1] = new JValue (code);
				__args [2] = new JValue (native_reason);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClosing", "(Lokhttp3/WebSocket;ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static Delegate cb_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_Handler ()
		{
			if (cb_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_ == null)
				cb_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_);
			return cb_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_;
		}

		static void n_OnFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocket, IntPtr native_t, IntPtr native_response)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var webSocket = (global::Okhttp3.IWebSocket)global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (native_webSocket, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			var response = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (webSocket, t, response);
		}
#pragma warning restore 0169

		static IntPtr id_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/method[@name='onFailure' and count(parameter)=3 and parameter[1][@type='okhttp3.WebSocket'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='okhttp3.Response']]"
		[Register ("onFailure", "(Lokhttp3/WebSocket;Ljava/lang/Throwable;Lokhttp3/Response;)V", "GetOnFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_Handler")]
		public virtual unsafe void OnFailure (global::Okhttp3.IWebSocket webSocket, global::Java.Lang.Throwable t, global::Okhttp3.Response response)
		{
			if (id_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_ == IntPtr.Zero)
				id_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lokhttp3/WebSocket;Ljava/lang/Throwable;Lokhttp3/Response;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (webSocket);
				__args [1] = new JValue (t);
				__args [2] = new JValue (response);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFailure", "(Lokhttp3/WebSocket;Ljava/lang/Throwable;Lokhttp3/Response;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Lokhttp3_WebSocket_Ljava_lang_String_Handler ()
		{
			if (cb_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_ == null)
				cb_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnMessage_Lokhttp3_WebSocket_Ljava_lang_String_);
			return cb_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_;
		}

		static void n_OnMessage_Lokhttp3_WebSocket_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocket, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var webSocket = (global::Okhttp3.IWebSocket)global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (native_webSocket, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (webSocket, text);
		}
#pragma warning restore 0169

		static IntPtr id_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/method[@name='onMessage' and count(parameter)=2 and parameter[1][@type='okhttp3.WebSocket'] and parameter[2][@type='java.lang.String']]"
		[Register ("onMessage", "(Lokhttp3/WebSocket;Ljava/lang/String;)V", "GetOnMessage_Lokhttp3_WebSocket_Ljava_lang_String_Handler")]
		public virtual unsafe void OnMessage (global::Okhttp3.IWebSocket webSocket, string text)
		{
			if (id_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Lokhttp3/WebSocket;Ljava/lang/String;)V");
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (webSocket);
				__args [1] = new JValue (native_text);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessage", "(Lokhttp3/WebSocket;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetOnOpen_Lokhttp3_WebSocket_Lokhttp3_Response_Handler ()
		{
			if (cb_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_ == null)
				cb_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnOpen_Lokhttp3_WebSocket_Lokhttp3_Response_);
			return cb_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_;
		}

		static void n_OnOpen_Lokhttp3_WebSocket_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocket, IntPtr native_response)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var webSocket = (global::Okhttp3.IWebSocket)global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (native_webSocket, JniHandleOwnership.DoNotTransfer);
			var response = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.OnOpen (webSocket, response);
		}
#pragma warning restore 0169

		static IntPtr id_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/method[@name='onOpen' and count(parameter)=2 and parameter[1][@type='okhttp3.WebSocket'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("onOpen", "(Lokhttp3/WebSocket;Lokhttp3/Response;)V", "GetOnOpen_Lokhttp3_WebSocket_Lokhttp3_Response_Handler")]
		public virtual unsafe void OnOpen (global::Okhttp3.IWebSocket webSocket, global::Okhttp3.Response response)
		{
			if (id_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_ == IntPtr.Zero)
				id_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "onOpen", "(Lokhttp3/WebSocket;Lokhttp3/Response;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (webSocket);
				__args [1] = new JValue (response);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOpen", "(Lokhttp3/WebSocket;Lokhttp3/Response;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okhttp3/WebSocketListener", DoNotGenerateAcw=true)]
	internal partial class WebSocketListenerInvoker : WebSocketListener {

		public WebSocketListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebSocketListenerInvoker); }
		}

	}

}
