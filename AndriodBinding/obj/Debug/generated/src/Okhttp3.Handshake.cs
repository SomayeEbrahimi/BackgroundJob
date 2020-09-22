using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']"
	[global::Android.Runtime.Register ("okhttp3/Handshake", DoNotGenerateAcw=true)]
	public sealed partial class Handshake : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Handshake", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Handshake); }
		}

		internal Handshake (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_cipherSuite;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='cipherSuite' and count(parameter)=0]"
		[Register ("cipherSuite", "()Lokhttp3/CipherSuite;", "")]
		public unsafe global::Okhttp3.CipherSuite CipherSuite ()
		{
			if (id_cipherSuite == IntPtr.Zero)
				id_cipherSuite = JNIEnv.GetMethodID (class_ref, "cipherSuite", "()Lokhttp3/CipherSuite;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cipherSuite), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_get_Ljavax_net_ssl_SSLSession_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='get' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSession']]"
		[Register ("get", "(Ljavax/net/ssl/SSLSession;)Lokhttp3/Handshake;", "")]
		public static unsafe global::Okhttp3.Handshake Get (global::Javax.Net.Ssl.ISSLSession session)
		{
			if (id_get_Ljavax_net_ssl_SSLSession_ == IntPtr.Zero)
				id_get_Ljavax_net_ssl_SSLSession_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljavax/net/ssl/SSLSession;)Lokhttp3/Handshake;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (session);
				global::Okhttp3.Handshake __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljavax_net_ssl_SSLSession_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_get_Lokhttp3_TlsVersion_Lokhttp3_CipherSuite_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='get' and count(parameter)=4 and parameter[1][@type='okhttp3.TlsVersion'] and parameter[2][@type='okhttp3.CipherSuite'] and parameter[3][@type='java.util.List&lt;java.security.cert.Certificate&gt;'] and parameter[4][@type='java.util.List&lt;java.security.cert.Certificate&gt;']]"
		[Register ("get", "(Lokhttp3/TlsVersion;Lokhttp3/CipherSuite;Ljava/util/List;Ljava/util/List;)Lokhttp3/Handshake;", "")]
		public static unsafe global::Okhttp3.Handshake Get (global::Okhttp3.TlsVersion tlsVersion, global::Okhttp3.CipherSuite cipherSuite, global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> peerCertificates, global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> localCertificates)
		{
			if (id_get_Lokhttp3_TlsVersion_Lokhttp3_CipherSuite_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_get_Lokhttp3_TlsVersion_Lokhttp3_CipherSuite_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Lokhttp3/TlsVersion;Lokhttp3/CipherSuite;Ljava/util/List;Ljava/util/List;)Lokhttp3/Handshake;");
			IntPtr native_peerCertificates = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (peerCertificates);
			IntPtr native_localCertificates = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (localCertificates);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (tlsVersion);
				__args [1] = new JValue (cipherSuite);
				__args [2] = new JValue (native_peerCertificates);
				__args [3] = new JValue (native_localCertificates);
				global::Okhttp3.Handshake __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Lokhttp3_TlsVersion_Lokhttp3_CipherSuite_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_peerCertificates);
				JNIEnv.DeleteLocalRef (native_localCertificates);
			}
		}

		static IntPtr id_localCertificates;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='localCertificates' and count(parameter)=0]"
		[Register ("localCertificates", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> LocalCertificates ()
		{
			if (id_localCertificates == IntPtr.Zero)
				id_localCertificates = JNIEnv.GetMethodID (class_ref, "localCertificates", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_localCertificates), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_localPrincipal;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='localPrincipal' and count(parameter)=0]"
		[Register ("localPrincipal", "()Ljava/security/Principal;", "")]
		public unsafe global::Java.Security.IPrincipal LocalPrincipal ()
		{
			if (id_localPrincipal == IntPtr.Zero)
				id_localPrincipal = JNIEnv.GetMethodID (class_ref, "localPrincipal", "()Ljava/security/Principal;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_localPrincipal), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_peerCertificates;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='peerCertificates' and count(parameter)=0]"
		[Register ("peerCertificates", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> PeerCertificates ()
		{
			if (id_peerCertificates == IntPtr.Zero)
				id_peerCertificates = JNIEnv.GetMethodID (class_ref, "peerCertificates", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peerCertificates), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_peerPrincipal;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='peerPrincipal' and count(parameter)=0]"
		[Register ("peerPrincipal", "()Ljava/security/Principal;", "")]
		public unsafe global::Java.Security.IPrincipal PeerPrincipal ()
		{
			if (id_peerPrincipal == IntPtr.Zero)
				id_peerPrincipal = JNIEnv.GetMethodID (class_ref, "peerPrincipal", "()Ljava/security/Principal;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peerPrincipal), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_tlsVersion;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='tlsVersion' and count(parameter)=0]"
		[Register ("tlsVersion", "()Lokhttp3/TlsVersion;", "")]
		public unsafe global::Okhttp3.TlsVersion TlsVersion ()
		{
			if (id_tlsVersion == IntPtr.Zero)
				id_tlsVersion = JNIEnv.GetMethodID (class_ref, "tlsVersion", "()Lokhttp3/TlsVersion;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tlsVersion), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
