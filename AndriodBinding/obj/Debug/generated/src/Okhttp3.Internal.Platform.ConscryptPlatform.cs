using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Platform {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='ConscryptPlatform']"
	[global::Android.Runtime.Register ("okhttp3/internal/platform/ConscryptPlatform", DoNotGenerateAcw=true)]
	public partial class ConscryptPlatform : global::Okhttp3.Internal.Platform.Platform {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/platform/ConscryptPlatform", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConscryptPlatform); }
		}

		protected ConscryptPlatform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_buildIfSupported;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='ConscryptPlatform']/method[@name='buildIfSupported' and count(parameter)=0]"
		[Register ("buildIfSupported", "()Lokhttp3/internal/platform/ConscryptPlatform;", "")]
		public static unsafe global::Okhttp3.Internal.Platform.ConscryptPlatform BuildIfSupported ()
		{
			if (id_buildIfSupported == IntPtr.Zero)
				id_buildIfSupported = JNIEnv.GetStaticMethodID (class_ref, "buildIfSupported", "()Lokhttp3/internal/platform/ConscryptPlatform;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.ConscryptPlatform> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildIfSupported), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_;
#pragma warning disable 0169
		static Delegate GetTrustManager_Ljavax_net_ssl_SSLSocketFactory_Handler ()
		{
			if (cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_ == null)
				cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TrustManager_Ljavax_net_ssl_SSLSocketFactory_);
			return cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_;
		}

		static IntPtr n_TrustManager_Ljavax_net_ssl_SSLSocketFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sslSocketFactory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.ConscryptPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sslSocketFactory = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (native_sslSocketFactory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TrustManager (sslSocketFactory));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_trustManager_Ljavax_net_ssl_SSLSocketFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='ConscryptPlatform']/method[@name='trustManager' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
		[Register ("trustManager", "(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/X509TrustManager;", "GetTrustManager_Ljavax_net_ssl_SSLSocketFactory_Handler")]
		public virtual unsafe global::Javax.Net.Ssl.IX509TrustManager TrustManager (global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory)
		{
			if (id_trustManager_Ljavax_net_ssl_SSLSocketFactory_ == IntPtr.Zero)
				id_trustManager_Ljavax_net_ssl_SSLSocketFactory_ = JNIEnv.GetMethodID (class_ref, "trustManager", "(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/X509TrustManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sslSocketFactory);

				global::Javax.Net.Ssl.IX509TrustManager __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trustManager_Ljavax_net_ssl_SSLSocketFactory_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trustManager", "(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/X509TrustManager;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
