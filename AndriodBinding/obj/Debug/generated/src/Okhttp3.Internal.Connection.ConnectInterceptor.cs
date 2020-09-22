using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='ConnectInterceptor']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/ConnectInterceptor", DoNotGenerateAcw=true)]
	public sealed partial class ConnectInterceptor : global::Java.Lang.Object, global::Okhttp3.IInterceptor {


		static IntPtr client_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='ConnectInterceptor']/field[@name='client']"
		[Register ("client")]
		public global::Okhttp3.OkHttpClient Client {
			get {
				if (client_jfieldId == IntPtr.Zero)
					client_jfieldId = JNIEnv.GetFieldID (class_ref, "client", "Lokhttp3/OkHttpClient;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, client_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (client_jfieldId == IntPtr.Zero)
					client_jfieldId = JNIEnv.GetFieldID (class_ref, "client", "Lokhttp3/OkHttpClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, client_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/connection/ConnectInterceptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectInterceptor); }
		}

		internal ConnectInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_OkHttpClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='ConnectInterceptor']/constructor[@name='ConnectInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;)V", "")]
		public unsafe ConnectInterceptor (global::Okhttp3.OkHttpClient client)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (client);
				if (((object) this).GetType () != typeof (ConnectInterceptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/OkHttpClient;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lokhttp3/OkHttpClient;)V", __args);
					return;
				}

				if (id_ctor_Lokhttp3_OkHttpClient_ == IntPtr.Zero)
					id_ctor_Lokhttp3_OkHttpClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/OkHttpClient;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_OkHttpClient_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lokhttp3_OkHttpClient_, __args);
			} finally {
			}
		}

		static IntPtr id_intercept_Lokhttp3_Interceptor_Chain_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='ConnectInterceptor']/method[@name='intercept' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor.Chain']]"
		[Register ("intercept", "(Lokhttp3/Interceptor$Chain;)Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response Intercept (global::Okhttp3.IInterceptorChain chain)
		{
			if (id_intercept_Lokhttp3_Interceptor_Chain_ == IntPtr.Zero)
				id_intercept_Lokhttp3_Interceptor_Chain_ = JNIEnv.GetMethodID (class_ref, "intercept", "(Lokhttp3/Interceptor$Chain;)Lokhttp3/Response;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (chain);
				global::Okhttp3.Response __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_intercept_Lokhttp3_Interceptor_Chain_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
