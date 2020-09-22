using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/RetryAndFollowUpInterceptor", DoNotGenerateAcw=true)]
	public sealed partial class RetryAndFollowUpInterceptor : global::Java.Lang.Object, global::Okhttp3.IInterceptor {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http/RetryAndFollowUpInterceptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RetryAndFollowUpInterceptor); }
		}

		internal RetryAndFollowUpInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_OkHttpClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/constructor[@name='RetryAndFollowUpInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;)V", "")]
		public unsafe RetryAndFollowUpInterceptor (global::Okhttp3.OkHttpClient client)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (client);
				if (((object) this).GetType () != typeof (RetryAndFollowUpInterceptor)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RetryAndFollowUpInterceptor']/method[@name='intercept' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor.Chain']]"
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
