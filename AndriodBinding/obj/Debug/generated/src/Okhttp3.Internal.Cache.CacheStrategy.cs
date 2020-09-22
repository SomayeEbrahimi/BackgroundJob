using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy']"
	[global::Android.Runtime.Register ("okhttp3/internal/cache/CacheStrategy", DoNotGenerateAcw=true)]
	public sealed partial class CacheStrategy : global::Java.Lang.Object {


		static IntPtr cacheResponse_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy']/field[@name='cacheResponse']"
		[Register ("cacheResponse")]
		public global::Okhttp3.Response CacheResponse {
			get {
				if (cacheResponse_jfieldId == IntPtr.Zero)
					cacheResponse_jfieldId = JNIEnv.GetFieldID (class_ref, "cacheResponse", "Lokhttp3/Response;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cacheResponse_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cacheResponse_jfieldId == IntPtr.Zero)
					cacheResponse_jfieldId = JNIEnv.GetFieldID (class_ref, "cacheResponse", "Lokhttp3/Response;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cacheResponse_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr networkRequest_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy']/field[@name='networkRequest']"
		[Register ("networkRequest")]
		public global::Okhttp3.Request NetworkRequest {
			get {
				if (networkRequest_jfieldId == IntPtr.Zero)
					networkRequest_jfieldId = JNIEnv.GetFieldID (class_ref, "networkRequest", "Lokhttp3/Request;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, networkRequest_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (networkRequest_jfieldId == IntPtr.Zero)
					networkRequest_jfieldId = JNIEnv.GetFieldID (class_ref, "networkRequest", "Lokhttp3/Request;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, networkRequest_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy.Factory']"
		[global::Android.Runtime.Register ("okhttp3/internal/cache/CacheStrategy$Factory", DoNotGenerateAcw=true)]
		public partial class Factory : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/internal/cache/CacheStrategy$Factory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Factory); }
			}

			protected Factory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_JLokhttp3_Request_Lokhttp3_Response_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy.Factory']/constructor[@name='CacheStrategy.Factory' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='okhttp3.Request'] and parameter[3][@type='okhttp3.Response']]"
			[Register (".ctor", "(JLokhttp3/Request;Lokhttp3/Response;)V", "")]
			public unsafe Factory (long nowMillis, global::Okhttp3.Request request, global::Okhttp3.Response cacheResponse)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (nowMillis);
					__args [1] = new JValue (request);
					__args [2] = new JValue (cacheResponse);
					if (((object) this).GetType () != typeof (Factory)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JLokhttp3/Request;Lokhttp3/Response;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JLokhttp3/Request;Lokhttp3/Response;)V", __args);
						return;
					}

					if (id_ctor_JLokhttp3_Request_Lokhttp3_Response_ == IntPtr.Zero)
						id_ctor_JLokhttp3_Request_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JLokhttp3/Request;Lokhttp3/Response;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JLokhttp3_Request_Lokhttp3_Response_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JLokhttp3_Request_Lokhttp3_Response_, __args);
				} finally {
				}
			}

			static Delegate cb_get;
#pragma warning disable 0169
			static Delegate GetGetHandler ()
			{
				if (cb_get == null)
					cb_get = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Get);
				return cb_get;
			}

			static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Cache.CacheStrategy.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Get ());
			}
#pragma warning restore 0169

			static IntPtr id_get;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy.Factory']/method[@name='get' and count(parameter)=0]"
			[Register ("get", "()Lokhttp3/internal/cache/CacheStrategy;", "GetGetHandler")]
			public virtual unsafe global::Okhttp3.Internal.Cache.CacheStrategy Get ()
			{
				if (id_get == IntPtr.Zero)
					id_get = JNIEnv.GetMethodID (class_ref, "get", "()Lokhttp3/internal/cache/CacheStrategy;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Cache.CacheStrategy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Cache.CacheStrategy> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()Lokhttp3/internal/cache/CacheStrategy;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/cache/CacheStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CacheStrategy); }
		}

		internal CacheStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isCacheable_Lokhttp3_Response_Lokhttp3_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='CacheStrategy']/method[@name='isCacheable' and count(parameter)=2 and parameter[1][@type='okhttp3.Response'] and parameter[2][@type='okhttp3.Request']]"
		[Register ("isCacheable", "(Lokhttp3/Response;Lokhttp3/Request;)Z", "")]
		public static unsafe bool IsCacheable (global::Okhttp3.Response response, global::Okhttp3.Request request)
		{
			if (id_isCacheable_Lokhttp3_Response_Lokhttp3_Request_ == IntPtr.Zero)
				id_isCacheable_Lokhttp3_Response_Lokhttp3_Request_ = JNIEnv.GetStaticMethodID (class_ref, "isCacheable", "(Lokhttp3/Response;Lokhttp3/Request;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (response);
				__args [1] = new JValue (request);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCacheable_Lokhttp3_Response_Lokhttp3_Request_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
