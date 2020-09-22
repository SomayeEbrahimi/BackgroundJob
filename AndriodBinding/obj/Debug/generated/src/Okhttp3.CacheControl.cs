using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']"
	[global::Android.Runtime.Register ("okhttp3/CacheControl", DoNotGenerateAcw=true)]
	public sealed partial class CacheControl : global::Java.Lang.Object {


		static IntPtr FORCE_CACHE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/field[@name='FORCE_CACHE']"
		[Register ("FORCE_CACHE")]
		public static global::Okhttp3.CacheControl ForceCache {
			get {
				if (FORCE_CACHE_jfieldId == IntPtr.Zero)
					FORCE_CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORCE_CACHE", "Lokhttp3/CacheControl;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORCE_CACHE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FORCE_NETWORK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/field[@name='FORCE_NETWORK']"
		[Register ("FORCE_NETWORK")]
		public static global::Okhttp3.CacheControl ForceNetwork {
			get {
				if (FORCE_NETWORK_jfieldId == IntPtr.Zero)
					FORCE_NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORCE_NETWORK", "Lokhttp3/CacheControl;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORCE_NETWORK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']"
		[global::Android.Runtime.Register ("okhttp3/CacheControl$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/CacheControl$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/constructor[@name='CacheControl.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/CacheControl;", "")]
			public unsafe global::Okhttp3.CacheControl Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/CacheControl;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_immutable;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='immutable' and count(parameter)=0]"
			[Register ("immutable", "()Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder Immutable ()
			{
				if (id_immutable == IntPtr.Zero)
					id_immutable = JNIEnv.GetMethodID (class_ref, "immutable", "()Lokhttp3/CacheControl$Builder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_immutable), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_maxAge_ILjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='maxAge' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("maxAge", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder MaxAge (int maxAge, global::Java.Util.Concurrent.TimeUnit timeUnit)
			{
				if (id_maxAge_ILjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_maxAge_ILjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "maxAge", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (maxAge);
					__args [1] = new JValue (timeUnit);
					global::Okhttp3.CacheControl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_maxAge_ILjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_maxStale_ILjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='maxStale' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("maxStale", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder MaxStale (int maxStale, global::Java.Util.Concurrent.TimeUnit timeUnit)
			{
				if (id_maxStale_ILjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_maxStale_ILjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "maxStale", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (maxStale);
					__args [1] = new JValue (timeUnit);
					global::Okhttp3.CacheControl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_maxStale_ILjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_minFresh_ILjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='minFresh' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("minFresh", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder MinFresh (int minFresh, global::Java.Util.Concurrent.TimeUnit timeUnit)
			{
				if (id_minFresh_ILjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_minFresh_ILjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "minFresh", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (minFresh);
					__args [1] = new JValue (timeUnit);
					global::Okhttp3.CacheControl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minFresh_ILjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_noCache;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='noCache' and count(parameter)=0]"
			[Register ("noCache", "()Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder NoCache ()
			{
				if (id_noCache == IntPtr.Zero)
					id_noCache = JNIEnv.GetMethodID (class_ref, "noCache", "()Lokhttp3/CacheControl$Builder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_noCache), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_noStore;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='noStore' and count(parameter)=0]"
			[Register ("noStore", "()Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder NoStore ()
			{
				if (id_noStore == IntPtr.Zero)
					id_noStore = JNIEnv.GetMethodID (class_ref, "noStore", "()Lokhttp3/CacheControl$Builder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_noStore), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_noTransform;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='noTransform' and count(parameter)=0]"
			[Register ("noTransform", "()Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder NoTransform ()
			{
				if (id_noTransform == IntPtr.Zero)
					id_noTransform = JNIEnv.GetMethodID (class_ref, "noTransform", "()Lokhttp3/CacheControl$Builder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_noTransform), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_onlyIfCached;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='onlyIfCached' and count(parameter)=0]"
			[Register ("onlyIfCached", "()Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder OnlyIfCached ()
			{
				if (id_onlyIfCached == IntPtr.Zero)
					id_onlyIfCached = JNIEnv.GetMethodID (class_ref, "onlyIfCached", "()Lokhttp3/CacheControl$Builder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onlyIfCached), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/CacheControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CacheControl); }
		}

		internal CacheControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isPrivate;
		public unsafe bool IsPrivate {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='isPrivate' and count(parameter)=0]"
			[Register ("isPrivate", "()Z", "")]
			get {
				if (id_isPrivate == IntPtr.Zero)
					id_isPrivate = JNIEnv.GetMethodID (class_ref, "isPrivate", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPrivate);
				} finally {
				}
			}
		}

		static IntPtr id_isPublic;
		public unsafe bool IsPublic {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='isPublic' and count(parameter)=0]"
			[Register ("isPublic", "()Z", "")]
			get {
				if (id_isPublic == IntPtr.Zero)
					id_isPublic = JNIEnv.GetMethodID (class_ref, "isPublic", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPublic);
				} finally {
				}
			}
		}

		static IntPtr id_immutable;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='immutable' and count(parameter)=0]"
		[Register ("immutable", "()Z", "")]
		public unsafe bool Immutable ()
		{
			if (id_immutable == IntPtr.Zero)
				id_immutable = JNIEnv.GetMethodID (class_ref, "immutable", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_immutable);
			} finally {
			}
		}

		static IntPtr id_maxAgeSeconds;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='maxAgeSeconds' and count(parameter)=0]"
		[Register ("maxAgeSeconds", "()I", "")]
		public unsafe int MaxAgeSeconds ()
		{
			if (id_maxAgeSeconds == IntPtr.Zero)
				id_maxAgeSeconds = JNIEnv.GetMethodID (class_ref, "maxAgeSeconds", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_maxAgeSeconds);
			} finally {
			}
		}

		static IntPtr id_maxStaleSeconds;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='maxStaleSeconds' and count(parameter)=0]"
		[Register ("maxStaleSeconds", "()I", "")]
		public unsafe int MaxStaleSeconds ()
		{
			if (id_maxStaleSeconds == IntPtr.Zero)
				id_maxStaleSeconds = JNIEnv.GetMethodID (class_ref, "maxStaleSeconds", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_maxStaleSeconds);
			} finally {
			}
		}

		static IntPtr id_minFreshSeconds;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='minFreshSeconds' and count(parameter)=0]"
		[Register ("minFreshSeconds", "()I", "")]
		public unsafe int MinFreshSeconds ()
		{
			if (id_minFreshSeconds == IntPtr.Zero)
				id_minFreshSeconds = JNIEnv.GetMethodID (class_ref, "minFreshSeconds", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_minFreshSeconds);
			} finally {
			}
		}

		static IntPtr id_mustRevalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='mustRevalidate' and count(parameter)=0]"
		[Register ("mustRevalidate", "()Z", "")]
		public unsafe bool MustRevalidate ()
		{
			if (id_mustRevalidate == IntPtr.Zero)
				id_mustRevalidate = JNIEnv.GetMethodID (class_ref, "mustRevalidate", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_mustRevalidate);
			} finally {
			}
		}

		static IntPtr id_noCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='noCache' and count(parameter)=0]"
		[Register ("noCache", "()Z", "")]
		public unsafe bool NoCache ()
		{
			if (id_noCache == IntPtr.Zero)
				id_noCache = JNIEnv.GetMethodID (class_ref, "noCache", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_noCache);
			} finally {
			}
		}

		static IntPtr id_noStore;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='noStore' and count(parameter)=0]"
		[Register ("noStore", "()Z", "")]
		public unsafe bool NoStore ()
		{
			if (id_noStore == IntPtr.Zero)
				id_noStore = JNIEnv.GetMethodID (class_ref, "noStore", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_noStore);
			} finally {
			}
		}

		static IntPtr id_noTransform;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='noTransform' and count(parameter)=0]"
		[Register ("noTransform", "()Z", "")]
		public unsafe bool NoTransform ()
		{
			if (id_noTransform == IntPtr.Zero)
				id_noTransform = JNIEnv.GetMethodID (class_ref, "noTransform", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_noTransform);
			} finally {
			}
		}

		static IntPtr id_onlyIfCached;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='onlyIfCached' and count(parameter)=0]"
		[Register ("onlyIfCached", "()Z", "")]
		public unsafe bool OnlyIfCached ()
		{
			if (id_onlyIfCached == IntPtr.Zero)
				id_onlyIfCached = JNIEnv.GetMethodID (class_ref, "onlyIfCached", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onlyIfCached);
			} finally {
			}
		}

		static IntPtr id_parse_Lokhttp3_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("parse", "(Lokhttp3/Headers;)Lokhttp3/CacheControl;", "")]
		public static unsafe global::Okhttp3.CacheControl Parse (global::Okhttp3.Headers headers)
		{
			if (id_parse_Lokhttp3_Headers_ == IntPtr.Zero)
				id_parse_Lokhttp3_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Lokhttp3/Headers;)Lokhttp3/CacheControl;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (headers);
				global::Okhttp3.CacheControl __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Lokhttp3_Headers_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sMaxAgeSeconds;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='sMaxAgeSeconds' and count(parameter)=0]"
		[Register ("sMaxAgeSeconds", "()I", "")]
		public unsafe int SMaxAgeSeconds ()
		{
			if (id_sMaxAgeSeconds == IntPtr.Zero)
				id_sMaxAgeSeconds = JNIEnv.GetMethodID (class_ref, "sMaxAgeSeconds", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sMaxAgeSeconds);
			} finally {
			}
		}

	}
}
