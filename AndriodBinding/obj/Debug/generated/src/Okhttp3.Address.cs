using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Address']"
	[global::Android.Runtime.Register ("okhttp3/Address", DoNotGenerateAcw=true)]
	public sealed partial class Address : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Address", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Address); }
		}

		internal Address (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_ILokhttp3_Dns_Ljavax_net_SocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_HostnameVerifier_Lokhttp3_CertificatePinner_Lokhttp3_Authenticator_Ljava_net_Proxy_Ljava_util_List_Ljava_util_List_Ljava_net_ProxySelector_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Address']/constructor[@name='Address' and count(parameter)=12 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='okhttp3.Dns'] and parameter[4][@type='javax.net.SocketFactory'] and parameter[5][@type='javax.net.ssl.SSLSocketFactory'] and parameter[6][@type='javax.net.ssl.HostnameVerifier'] and parameter[7][@type='okhttp3.CertificatePinner'] and parameter[8][@type='okhttp3.Authenticator'] and parameter[9][@type='java.net.Proxy'] and parameter[10][@type='java.util.List&lt;okhttp3.Protocol&gt;'] and parameter[11][@type='java.util.List&lt;okhttp3.ConnectionSpec&gt;'] and parameter[12][@type='java.net.ProxySelector']]"
		[Register (".ctor", "(Ljava/lang/String;ILokhttp3/Dns;Ljavax/net/SocketFactory;Ljavax/net/ssl/SSLSocketFactory;Ljavax/net/ssl/HostnameVerifier;Lokhttp3/CertificatePinner;Lokhttp3/Authenticator;Ljava/net/Proxy;Ljava/util/List;Ljava/util/List;Ljava/net/ProxySelector;)V", "")]
		public unsafe Address (string uriHost, int uriPort, global::Okhttp3.IDns dns, global::Javax.Net.SocketFactory socketFactory, global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory, global::Javax.Net.Ssl.IHostnameVerifier hostnameVerifier, global::Okhttp3.CertificatePinner certificatePinner, global::Okhttp3.IAuthenticator proxyAuthenticator, global::Java.Net.Proxy proxy, global::System.Collections.Generic.IList<global::Okhttp3.Protocol> protocols, global::System.Collections.Generic.IList<global::Okhttp3.ConnectionSpec> connectionSpecs, global::Java.Net.ProxySelector proxySelector)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_uriHost = JNIEnv.NewString (uriHost);
			IntPtr native_protocols = global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.ToLocalJniHandle (protocols);
			IntPtr native_connectionSpecs = global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.ToLocalJniHandle (connectionSpecs);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native_uriHost);
				__args [1] = new JValue (uriPort);
				__args [2] = new JValue (dns);
				__args [3] = new JValue (socketFactory);
				__args [4] = new JValue (sslSocketFactory);
				__args [5] = new JValue (hostnameVerifier);
				__args [6] = new JValue (certificatePinner);
				__args [7] = new JValue (proxyAuthenticator);
				__args [8] = new JValue (proxy);
				__args [9] = new JValue (native_protocols);
				__args [10] = new JValue (native_connectionSpecs);
				__args [11] = new JValue (proxySelector);
				if (((object) this).GetType () != typeof (Address)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;ILokhttp3/Dns;Ljavax/net/SocketFactory;Ljavax/net/ssl/SSLSocketFactory;Ljavax/net/ssl/HostnameVerifier;Lokhttp3/CertificatePinner;Lokhttp3/Authenticator;Ljava/net/Proxy;Ljava/util/List;Ljava/util/List;Ljava/net/ProxySelector;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;ILokhttp3/Dns;Ljavax/net/SocketFactory;Ljavax/net/ssl/SSLSocketFactory;Ljavax/net/ssl/HostnameVerifier;Lokhttp3/CertificatePinner;Lokhttp3/Authenticator;Ljava/net/Proxy;Ljava/util/List;Ljava/util/List;Ljava/net/ProxySelector;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ILokhttp3_Dns_Ljavax_net_SocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_HostnameVerifier_Lokhttp3_CertificatePinner_Lokhttp3_Authenticator_Ljava_net_Proxy_Ljava_util_List_Ljava_util_List_Ljava_net_ProxySelector_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ILokhttp3_Dns_Ljavax_net_SocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_HostnameVerifier_Lokhttp3_CertificatePinner_Lokhttp3_Authenticator_Ljava_net_Proxy_Ljava_util_List_Ljava_util_List_Ljava_net_ProxySelector_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ILokhttp3/Dns;Ljavax/net/SocketFactory;Ljavax/net/ssl/SSLSocketFactory;Ljavax/net/ssl/HostnameVerifier;Lokhttp3/CertificatePinner;Lokhttp3/Authenticator;Ljava/net/Proxy;Ljava/util/List;Ljava/util/List;Ljava/net/ProxySelector;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ILokhttp3_Dns_Ljavax_net_SocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_HostnameVerifier_Lokhttp3_CertificatePinner_Lokhttp3_Authenticator_Ljava_net_Proxy_Ljava_util_List_Ljava_util_List_Ljava_net_ProxySelector_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_ILokhttp3_Dns_Ljavax_net_SocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_HostnameVerifier_Lokhttp3_CertificatePinner_Lokhttp3_Authenticator_Ljava_net_Proxy_Ljava_util_List_Ljava_util_List_Ljava_net_ProxySelector_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_uriHost);
				JNIEnv.DeleteLocalRef (native_protocols);
				JNIEnv.DeleteLocalRef (native_connectionSpecs);
			}
		}

		static IntPtr id_certificatePinner;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='certificatePinner' and count(parameter)=0]"
		[Register ("certificatePinner", "()Lokhttp3/CertificatePinner;", "")]
		public unsafe global::Okhttp3.CertificatePinner CertificatePinner ()
		{
			if (id_certificatePinner == IntPtr.Zero)
				id_certificatePinner = JNIEnv.GetMethodID (class_ref, "certificatePinner", "()Lokhttp3/CertificatePinner;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CertificatePinner> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_certificatePinner), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_connectionSpecs;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='connectionSpecs' and count(parameter)=0]"
		[Register ("connectionSpecs", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.ConnectionSpec> ConnectionSpecs ()
		{
			if (id_connectionSpecs == IntPtr.Zero)
				id_connectionSpecs = JNIEnv.GetMethodID (class_ref, "connectionSpecs", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connectionSpecs), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_dns;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='dns' and count(parameter)=0]"
		[Register ("dns", "()Lokhttp3/Dns;", "")]
		public unsafe global::Okhttp3.IDns Dns ()
		{
			if (id_dns == IntPtr.Zero)
				id_dns = JNIEnv.GetMethodID (class_ref, "dns", "()Lokhttp3/Dns;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IDns> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dns), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_hostnameVerifier;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='hostnameVerifier' and count(parameter)=0]"
		[Register ("hostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", "")]
		public unsafe global::Javax.Net.Ssl.IHostnameVerifier HostnameVerifier ()
		{
			if (id_hostnameVerifier == IntPtr.Zero)
				id_hostnameVerifier = JNIEnv.GetMethodID (class_ref, "hostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
			try {
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hostnameVerifier), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_protocols;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='protocols' and count(parameter)=0]"
		[Register ("protocols", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.Protocol> Protocols ()
		{
			if (id_protocols == IntPtr.Zero)
				id_protocols = JNIEnv.GetMethodID (class_ref, "protocols", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_protocols), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_proxy;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='proxy' and count(parameter)=0]"
		[Register ("proxy", "()Ljava/net/Proxy;", "")]
		public unsafe global::Java.Net.Proxy Proxy ()
		{
			if (id_proxy == IntPtr.Zero)
				id_proxy = JNIEnv.GetMethodID (class_ref, "proxy", "()Ljava/net/Proxy;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proxy), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_proxyAuthenticator;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='proxyAuthenticator' and count(parameter)=0]"
		[Register ("proxyAuthenticator", "()Lokhttp3/Authenticator;", "")]
		public unsafe global::Okhttp3.IAuthenticator ProxyAuthenticator ()
		{
			if (id_proxyAuthenticator == IntPtr.Zero)
				id_proxyAuthenticator = JNIEnv.GetMethodID (class_ref, "proxyAuthenticator", "()Lokhttp3/Authenticator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IAuthenticator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proxyAuthenticator), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_proxySelector;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='proxySelector' and count(parameter)=0]"
		[Register ("proxySelector", "()Ljava/net/ProxySelector;", "")]
		public unsafe global::Java.Net.ProxySelector ProxySelector ()
		{
			if (id_proxySelector == IntPtr.Zero)
				id_proxySelector = JNIEnv.GetMethodID (class_ref, "proxySelector", "()Ljava/net/ProxySelector;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Net.ProxySelector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proxySelector), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_socketFactory;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='socketFactory' and count(parameter)=0]"
		[Register ("socketFactory", "()Ljavax/net/SocketFactory;", "")]
		public unsafe global::Javax.Net.SocketFactory SocketFactory ()
		{
			if (id_socketFactory == IntPtr.Zero)
				id_socketFactory = JNIEnv.GetMethodID (class_ref, "socketFactory", "()Ljavax/net/SocketFactory;");
			try {
				return global::Java.Lang.Object.GetObject<global::Javax.Net.SocketFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_socketFactory), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_sslSocketFactory;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='sslSocketFactory' and count(parameter)=0]"
		[Register ("sslSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", "")]
		public unsafe global::Javax.Net.Ssl.SSLSocketFactory SslSocketFactory ()
		{
			if (id_sslSocketFactory == IntPtr.Zero)
				id_sslSocketFactory = JNIEnv.GetMethodID (class_ref, "sslSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			try {
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sslSocketFactory), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_url;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Lokhttp3/HttpUrl;", "")]
		public unsafe global::Okhttp3.HttpUrl Url ()
		{
			if (id_url == IntPtr.Zero)
				id_url = JNIEnv.GetMethodID (class_ref, "url", "()Lokhttp3/HttpUrl;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_url), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
