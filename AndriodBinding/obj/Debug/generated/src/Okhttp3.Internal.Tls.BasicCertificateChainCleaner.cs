using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Tls {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicCertificateChainCleaner']"
	[global::Android.Runtime.Register ("okhttp3/internal/tls/BasicCertificateChainCleaner", DoNotGenerateAcw=true)]
	public sealed partial class BasicCertificateChainCleaner : global::Okhttp3.Internal.Tls.CertificateChainCleaner {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/tls/BasicCertificateChainCleaner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicCertificateChainCleaner); }
		}

		internal BasicCertificateChainCleaner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_internal_tls_TrustRootIndex_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicCertificateChainCleaner']/constructor[@name='BasicCertificateChainCleaner' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.tls.TrustRootIndex']]"
		[Register (".ctor", "(Lokhttp3/internal/tls/TrustRootIndex;)V", "")]
		public unsafe BasicCertificateChainCleaner (global::Okhttp3.Internal.Tls.ITrustRootIndex trustRootIndex)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (trustRootIndex);
				if (((object) this).GetType () != typeof (BasicCertificateChainCleaner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/internal/tls/TrustRootIndex;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lokhttp3/internal/tls/TrustRootIndex;)V", __args);
					return;
				}

				if (id_ctor_Lokhttp3_internal_tls_TrustRootIndex_ == IntPtr.Zero)
					id_ctor_Lokhttp3_internal_tls_TrustRootIndex_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/internal/tls/TrustRootIndex;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_internal_tls_TrustRootIndex_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lokhttp3_internal_tls_TrustRootIndex_, __args);
			} finally {
			}
		}

		static IntPtr id_clean_Ljava_util_List_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='BasicCertificateChainCleaner']/method[@name='clean' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.security.cert.Certificate&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("clean", "(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;", "")]
		public override unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> Clean (global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> chain, string hostname)
		{
			if (id_clean_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
				id_clean_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clean", "(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_chain = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (chain);
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_chain);
				__args [1] = new JValue (native_hostname);
				global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> __ret = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clean_Ljava_util_List_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_chain);
				JNIEnv.DeleteLocalRef (native_hostname);
			}
		}

	}
}
