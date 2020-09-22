using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheInterceptor']"
	[global::Android.Runtime.Register ("okhttp3/internal/cache/CacheInterceptor", DoNotGenerateAcw=true)]
	public sealed partial class CacheInterceptor : global::Java.Lang.Object, global::Okhttp3.IInterceptor {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/cache/CacheInterceptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CacheInterceptor); }
		}

		internal CacheInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_internal_cache_InternalCache_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheInterceptor']/constructor[@name='CacheInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.cache.InternalCache']]"
		[Register (".ctor", "(Lokhttp3/internal/cache/InternalCache;)V", "")]
		public unsafe CacheInterceptor (global::Okhttp3.Internal.Cache.IInternalCache cache)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cache);
				if (((object) this).GetType () != typeof (CacheInterceptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/internal/cache/InternalCache;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lokhttp3/internal/cache/InternalCache;)V", __args);
					return;
				}

				if (id_ctor_Lokhttp3_internal_cache_InternalCache_ == IntPtr.Zero)
					id_ctor_Lokhttp3_internal_cache_InternalCache_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/internal/cache/InternalCache;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_internal_cache_InternalCache_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lokhttp3_internal_cache_InternalCache_, __args);
			} finally {
			}
		}

		static IntPtr id_intercept_Lokhttp3_Interceptor_Chain_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheInterceptor']/method[@name='intercept' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor.Chain']]"
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
