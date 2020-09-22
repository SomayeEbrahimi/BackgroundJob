using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner']"
	[global::Android.Runtime.Register ("okhttp3/CertificatePinner", DoNotGenerateAcw=true)]
	public sealed partial class CertificatePinner : global::Java.Lang.Object {


		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Okhttp3.CertificatePinner Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lokhttp3/CertificatePinner;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CertificatePinner> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner.Builder']"
		[global::Android.Runtime.Register ("okhttp3/CertificatePinner$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/CertificatePinner$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner.Builder']/constructor[@name='CertificatePinner.Builder' and count(parameter)=0]"
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

			static IntPtr id_add_Ljava_lang_String_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner.Builder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
			[Register ("add", "(Ljava/lang/String;[Ljava/lang/String;)Lokhttp3/CertificatePinner$Builder;", "")]
			public unsafe global::Okhttp3.CertificatePinner.Builder Add (string pattern, params string[] pins)
			{
				if (id_add_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
					id_add_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;[Ljava/lang/String;)Lokhttp3/CertificatePinner$Builder;");
				IntPtr native_pattern = JNIEnv.NewString (pattern);
				IntPtr native_pins = JNIEnv.NewArray (pins);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_pattern);
					__args [1] = new JValue (native_pins);
					global::Okhttp3.CertificatePinner.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.CertificatePinner.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_pattern);
					if (pins != null) {
						JNIEnv.CopyArray (native_pins, pins);
						JNIEnv.DeleteLocalRef (native_pins);
					}
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/CertificatePinner;", "")]
			public unsafe global::Okhttp3.CertificatePinner Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/CertificatePinner;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CertificatePinner> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/CertificatePinner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CertificatePinner); }
		}

		internal CertificatePinner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_check_Ljava_lang_String_arrayLjava_security_cert_Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner']/method[@name='check' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.security.cert.Certificate...']]"
		[Obsolete (@"deprecated")]
		[Register ("check", "(Ljava/lang/String;[Ljava/security/cert/Certificate;)V", "")]
		public unsafe void Check (string hostname, params global::Java.Security.Cert.Certificate[] peerCertificates)
		{
			if (id_check_Ljava_lang_String_arrayLjava_security_cert_Certificate_ == IntPtr.Zero)
				id_check_Ljava_lang_String_arrayLjava_security_cert_Certificate_ = JNIEnv.GetMethodID (class_ref, "check", "(Ljava/lang/String;[Ljava/security/cert/Certificate;)V");
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			IntPtr native_peerCertificates = JNIEnv.NewArray (peerCertificates);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_hostname);
				__args [1] = new JValue (native_peerCertificates);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_check_Ljava_lang_String_arrayLjava_security_cert_Certificate_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_hostname);
				if (peerCertificates != null) {
					JNIEnv.CopyArray (native_peerCertificates, peerCertificates);
					JNIEnv.DeleteLocalRef (native_peerCertificates);
				}
			}
		}

		static IntPtr id_check_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner']/method[@name='check' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.security.cert.Certificate&gt;']]"
		[Register ("check", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe void Check (string hostname, global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> peerCertificates)
		{
			if (id_check_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_check_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "check", "(Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			IntPtr native_peerCertificates = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (peerCertificates);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_hostname);
				__args [1] = new JValue (native_peerCertificates);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_check_Ljava_lang_String_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_hostname);
				JNIEnv.DeleteLocalRef (native_peerCertificates);
			}
		}

		static IntPtr id_pin_Ljava_security_cert_Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CertificatePinner']/method[@name='pin' and count(parameter)=1 and parameter[1][@type='java.security.cert.Certificate']]"
		[Register ("pin", "(Ljava/security/cert/Certificate;)Ljava/lang/String;", "")]
		public static unsafe string Pin (global::Java.Security.Cert.Certificate certificate)
		{
			if (id_pin_Ljava_security_cert_Certificate_ == IntPtr.Zero)
				id_pin_Ljava_security_cert_Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "pin", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (certificate);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_pin_Ljava_security_cert_Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
