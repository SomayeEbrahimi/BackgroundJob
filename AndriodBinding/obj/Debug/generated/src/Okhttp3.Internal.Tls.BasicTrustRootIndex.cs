using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Tls {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicTrustRootIndex']"
	[global::Android.Runtime.Register ("okhttp3/internal/tls/BasicTrustRootIndex", DoNotGenerateAcw=true)]
	public sealed partial class BasicTrustRootIndex : global::Java.Lang.Object, global::Okhttp3.Internal.Tls.ITrustRootIndex {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/tls/BasicTrustRootIndex", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicTrustRootIndex); }
		}

		internal BasicTrustRootIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLjava_security_cert_X509Certificate_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicTrustRootIndex']/constructor[@name='BasicTrustRootIndex' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate...']]"
		[Register (".ctor", "([Ljava/security/cert/X509Certificate;)V", "")]
		public unsafe BasicTrustRootIndex (params global::Java.Security.Cert.X509Certificate[] caCerts)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_caCerts = JNIEnv.NewArray (caCerts);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_caCerts);
				if (((object) this).GetType () != typeof (BasicTrustRootIndex)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Ljava/security/cert/X509Certificate;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Ljava/security/cert/X509Certificate;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_security_cert_X509Certificate_ == IntPtr.Zero)
					id_ctor_arrayLjava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/security/cert/X509Certificate;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_security_cert_X509Certificate_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLjava_security_cert_X509Certificate_, __args);
			} finally {
				if (caCerts != null) {
					JNIEnv.CopyArray (native_caCerts, caCerts);
					JNIEnv.DeleteLocalRef (native_caCerts);
				}
			}
		}

		static IntPtr id_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicTrustRootIndex']/method[@name='findByIssuerAndSignature' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("findByIssuerAndSignature", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;", "")]
		public unsafe global::Java.Security.Cert.X509Certificate FindByIssuerAndSignature (global::Java.Security.Cert.X509Certificate cert)
		{
			if (id_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "findByIssuerAndSignature", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509Certificate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cert);
				global::Java.Security.Cert.X509Certificate __ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_findByIssuerAndSignature_Ljava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
