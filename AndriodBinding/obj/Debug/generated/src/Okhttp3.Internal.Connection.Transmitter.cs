using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/Transmitter", DoNotGenerateAcw=true)]
	public sealed partial class Transmitter : global::Java.Lang.Object {


		static IntPtr connection_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/field[@name='connection']"
		[Register ("connection")]
		public global::Okhttp3.Internal.Connection.RealConnection Connection {
			get {
				if (connection_jfieldId == IntPtr.Zero)
					connection_jfieldId = JNIEnv.GetFieldID (class_ref, "connection", "Lokhttp3/internal/connection/RealConnection;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, connection_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RealConnection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (connection_jfieldId == IntPtr.Zero)
					connection_jfieldId = JNIEnv.GetFieldID (class_ref, "connection", "Lokhttp3/internal/connection/RealConnection;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connection_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/connection/Transmitter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Transmitter); }
		}

		internal Transmitter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_OkHttpClient_Lokhttp3_Call_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/constructor[@name='Transmitter' and count(parameter)=2 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='okhttp3.Call']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;Lokhttp3/Call;)V", "")]
		public unsafe Transmitter (global::Okhttp3.OkHttpClient client, global::Okhttp3.ICall call)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (client);
				__args [1] = new JValue (call);
				if (((object) this).GetType () != typeof (Transmitter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/OkHttpClient;Lokhttp3/Call;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lokhttp3/OkHttpClient;Lokhttp3/Call;)V", __args);
					return;
				}

				if (id_ctor_Lokhttp3_OkHttpClient_Lokhttp3_Call_ == IntPtr.Zero)
					id_ctor_Lokhttp3_OkHttpClient_Lokhttp3_Call_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/OkHttpClient;Lokhttp3/Call;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_OkHttpClient_Lokhttp3_Call_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lokhttp3_OkHttpClient_Lokhttp3_Call_, __args);
			} finally {
			}
		}

		static IntPtr id_hasExchange;
		public unsafe bool HasExchange {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/method[@name='hasExchange' and count(parameter)=0]"
			[Register ("hasExchange", "()Z", "")]
			get {
				if (id_hasExchange == IntPtr.Zero)
					id_hasExchange = JNIEnv.GetMethodID (class_ref, "hasExchange", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasExchange);
				} finally {
				}
			}
		}

		static IntPtr id_isCanceled;
		public unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "")]
			get {
				if (id_isCanceled == IntPtr.Zero)
					id_isCanceled = JNIEnv.GetMethodID (class_ref, "isCanceled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCanceled);
				} finally {
				}
			}
		}

		static IntPtr id_callStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/method[@name='callStart' and count(parameter)=0]"
		[Register ("callStart", "()V", "")]
		public unsafe void CallStart ()
		{
			if (id_callStart == IntPtr.Zero)
				id_callStart = JNIEnv.GetMethodID (class_ref, "callStart", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_callStart);
			} finally {
			}
		}

		static IntPtr id_canRetry;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/method[@name='canRetry' and count(parameter)=0]"
		[Register ("canRetry", "()Z", "")]
		public unsafe bool CanRetry ()
		{
			if (id_canRetry == IntPtr.Zero)
				id_canRetry = JNIEnv.GetMethodID (class_ref, "canRetry", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canRetry);
			} finally {
			}
		}

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/method[@name='cancel' and count(parameter)=0]"
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

		static IntPtr id_exchangeDoneDueToException;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/method[@name='exchangeDoneDueToException' and count(parameter)=0]"
		[Register ("exchangeDoneDueToException", "()V", "")]
		public unsafe void ExchangeDoneDueToException ()
		{
			if (id_exchangeDoneDueToException == IntPtr.Zero)
				id_exchangeDoneDueToException = JNIEnv.GetMethodID (class_ref, "exchangeDoneDueToException", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_exchangeDoneDueToException);
			} finally {
			}
		}

		static IntPtr id_noMoreExchanges_Ljava_io_IOException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/method[@name='noMoreExchanges' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("noMoreExchanges", "(Ljava/io/IOException;)Ljava/io/IOException;", "")]
		public unsafe global::Java.IO.IOException NoMoreExchanges (global::Java.IO.IOException e)
		{
			if (id_noMoreExchanges_Ljava_io_IOException_ == IntPtr.Zero)
				id_noMoreExchanges_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "noMoreExchanges", "(Ljava/io/IOException;)Ljava/io/IOException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				global::Java.IO.IOException __ret = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_noMoreExchanges_Ljava_io_IOException_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_prepareToConnect_Lokhttp3_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/method[@name='prepareToConnect' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("prepareToConnect", "(Lokhttp3/Request;)V", "")]
		public unsafe void PrepareToConnect (global::Okhttp3.Request request)
		{
			if (id_prepareToConnect_Lokhttp3_Request_ == IntPtr.Zero)
				id_prepareToConnect_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "prepareToConnect", "(Lokhttp3/Request;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (request);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareToConnect_Lokhttp3_Request_, __args);
			} finally {
			}
		}

		static IntPtr id_timeoutEarlyExit;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/method[@name='timeoutEarlyExit' and count(parameter)=0]"
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

		static IntPtr id_timeoutEnter;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='Transmitter']/method[@name='timeoutEnter' and count(parameter)=0]"
		[Register ("timeoutEnter", "()V", "")]
		public unsafe void TimeoutEnter ()
		{
			if (id_timeoutEnter == IntPtr.Zero)
				id_timeoutEnter = JNIEnv.GetMethodID (class_ref, "timeoutEnter", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_timeoutEnter);
			} finally {
			}
		}

	}
}
