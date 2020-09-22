using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Tls {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']"
	[global::Android.Runtime.Register ("okhttp3/internal/tls/CertificateChainCleaner", DoNotGenerateAcw=true)]
	public abstract partial class CertificateChainCleaner : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/tls/CertificateChainCleaner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CertificateChainCleaner); }
		}

		protected CertificateChainCleaner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']/constructor[@name='CertificateChainCleaner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CertificateChainCleaner ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CertificateChainCleaner)) {
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

		static Delegate cb_clean_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClean_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_clean_Ljava_util_List_Ljava_lang_String_ == null)
				cb_clean_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Clean_Ljava_util_List_Ljava_lang_String_);
			return cb_clean_Ljava_util_List_Ljava_lang_String_;
		}

		static IntPtr n_Clean_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (__this.Clean (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']/method[@name='clean' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.security.cert.Certificate&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("clean", "(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;", "GetClean_Ljava_util_List_Ljava_lang_String_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> Clean (global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> p0, string p1);

		static IntPtr id_get_arrayLjava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate...']]"
		[Register ("get", "([Ljava/security/cert/X509Certificate;)Lokhttp3/internal/tls/CertificateChainCleaner;", "")]
		public static unsafe global::Okhttp3.Internal.Tls.CertificateChainCleaner Get (params global::Java.Security.Cert.X509Certificate[] caCerts)
		{
			if (id_get_arrayLjava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_get_arrayLjava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "get", "([Ljava/security/cert/X509Certificate;)Lokhttp3/internal/tls/CertificateChainCleaner;");
			IntPtr native_caCerts = JNIEnv.NewArray (caCerts);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_caCerts);
				global::Okhttp3.Internal.Tls.CertificateChainCleaner __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_arrayLjava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (caCerts != null) {
					JNIEnv.CopyArray (native_caCerts, caCerts);
					JNIEnv.DeleteLocalRef (native_caCerts);
				}
			}
		}

		static IntPtr id_get_Ljavax_net_ssl_X509TrustManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']/method[@name='get' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.X509TrustManager']]"
		[Register ("get", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/CertificateChainCleaner;", "")]
		public static unsafe global::Okhttp3.Internal.Tls.CertificateChainCleaner Get (global::Javax.Net.Ssl.IX509TrustManager trustManager)
		{
			if (id_get_Ljavax_net_ssl_X509TrustManager_ == IntPtr.Zero)
				id_get_Ljavax_net_ssl_X509TrustManager_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/CertificateChainCleaner;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (trustManager);
				global::Okhttp3.Internal.Tls.CertificateChainCleaner __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljavax_net_ssl_X509TrustManager_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okhttp3/internal/tls/CertificateChainCleaner", DoNotGenerateAcw=true)]
	internal partial class CertificateChainCleanerInvoker : CertificateChainCleaner {

		public CertificateChainCleanerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CertificateChainCleanerInvoker); }
		}

		static IntPtr id_clean_Ljava_util_List_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']/method[@name='clean' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.security.cert.Certificate&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("clean", "(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;", "GetClean_Ljava_util_List_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> Clean (global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> p0, string p1)
		{
			if (id_clean_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
				id_clean_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clean", "(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> __ret = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clean_Ljava_util_List_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
