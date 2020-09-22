using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Tls {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']"
	[global::Android.Runtime.Register ("okhttp3/internal/tls/OkHostnameVerifier", DoNotGenerateAcw=true)]
	public sealed partial class OkHostnameVerifier : global::Java.Lang.Object, global::Javax.Net.Ssl.IHostnameVerifier {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Okhttp3.Internal.Tls.OkHostnameVerifier Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lokhttp3/internal/tls/OkHostnameVerifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.OkHostnameVerifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/tls/OkHostnameVerifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OkHostnameVerifier); }
		}

		internal OkHostnameVerifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_allSubjectAltNames_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='allSubjectAltNames' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("allSubjectAltNames", "(Ljava/security/cert/X509Certificate;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> AllSubjectAltNames (global::Java.Security.Cert.X509Certificate certificate)
		{
			if (id_allSubjectAltNames_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_allSubjectAltNames_Ljava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "allSubjectAltNames", "(Ljava/security/cert/X509Certificate;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (certificate);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_allSubjectAltNames_Ljava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_verify_Ljava_lang_String_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='verify' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.security.cert.X509Certificate']]"
		[Register ("verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)Z", "")]
		public unsafe bool Verify (string host, global::Java.Security.Cert.X509Certificate certificate)
		{
			if (id_verify_Ljava_lang_String_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_verify_Ljava_lang_String_Ljava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)Z");
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_host);
				__args [1] = new JValue (certificate);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_verify_Ljava_lang_String_Ljava_security_cert_X509Certificate_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		static IntPtr id_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='verify' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='javax.net.ssl.SSLSession']]"
		[Register ("verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", "")]
		public unsafe bool Verify (string host, global::Javax.Net.Ssl.ISSLSession session)
		{
			if (id_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_ == IntPtr.Zero)
				id_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_ = JNIEnv.GetMethodID (class_ref, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z");
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_host);
				__args [1] = new JValue (session);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		static IntPtr id_verifyHostname_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='verifyHostname' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("verifyHostname", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public unsafe bool VerifyHostname (string hostname, string pattern)
		{
			if (id_verifyHostname_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_verifyHostname_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "verifyHostname", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_hostname);
				__args [1] = new JValue (native_pattern);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_verifyHostname_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_hostname);
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

	}
}
