using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']"
	[global::Android.Runtime.Register ("okhttp3/ConnectionSpec", DoNotGenerateAcw=true)]
	public sealed partial class ConnectionSpec : global::Java.Lang.Object {


		static IntPtr CLEARTEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/field[@name='CLEARTEXT']"
		[Register ("CLEARTEXT")]
		public static global::Okhttp3.ConnectionSpec Cleartext {
			get {
				if (CLEARTEXT_jfieldId == IntPtr.Zero)
					CLEARTEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLEARTEXT", "Lokhttp3/ConnectionSpec;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLEARTEXT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COMPATIBLE_TLS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/field[@name='COMPATIBLE_TLS']"
		[Register ("COMPATIBLE_TLS")]
		public static global::Okhttp3.ConnectionSpec CompatibleTls {
			get {
				if (COMPATIBLE_TLS_jfieldId == IntPtr.Zero)
					COMPATIBLE_TLS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPATIBLE_TLS", "Lokhttp3/ConnectionSpec;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPATIBLE_TLS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MODERN_TLS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/field[@name='MODERN_TLS']"
		[Register ("MODERN_TLS")]
		public static global::Okhttp3.ConnectionSpec ModernTls {
			get {
				if (MODERN_TLS_jfieldId == IntPtr.Zero)
					MODERN_TLS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MODERN_TLS", "Lokhttp3/ConnectionSpec;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MODERN_TLS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RESTRICTED_TLS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/field[@name='RESTRICTED_TLS']"
		[Register ("RESTRICTED_TLS")]
		public static global::Okhttp3.ConnectionSpec RestrictedTls {
			get {
				if (RESTRICTED_TLS_jfieldId == IntPtr.Zero)
					RESTRICTED_TLS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESTRICTED_TLS", "Lokhttp3/ConnectionSpec;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESTRICTED_TLS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']"
		[global::Android.Runtime.Register ("okhttp3/ConnectionSpec$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/ConnectionSpec$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lokhttp3_ConnectionSpec_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/constructor[@name='ConnectionSpec.Builder' and count(parameter)=1 and parameter[1][@type='okhttp3.ConnectionSpec']]"
			[Register (".ctor", "(Lokhttp3/ConnectionSpec;)V", "")]
			public unsafe Builder (global::Okhttp3.ConnectionSpec connectionSpec)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (connectionSpec);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/ConnectionSpec;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lokhttp3/ConnectionSpec;)V", __args);
						return;
					}

					if (id_ctor_Lokhttp3_ConnectionSpec_ == IntPtr.Zero)
						id_ctor_Lokhttp3_ConnectionSpec_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/ConnectionSpec;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_ConnectionSpec_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lokhttp3_ConnectionSpec_, __args);
				} finally {
				}
			}

			static IntPtr id_allEnabledCipherSuites;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='allEnabledCipherSuites' and count(parameter)=0]"
			[Register ("allEnabledCipherSuites", "()Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder AllEnabledCipherSuites ()
			{
				if (id_allEnabledCipherSuites == IntPtr.Zero)
					id_allEnabledCipherSuites = JNIEnv.GetMethodID (class_ref, "allEnabledCipherSuites", "()Lokhttp3/ConnectionSpec$Builder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_allEnabledCipherSuites), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_allEnabledTlsVersions;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='allEnabledTlsVersions' and count(parameter)=0]"
			[Register ("allEnabledTlsVersions", "()Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder AllEnabledTlsVersions ()
			{
				if (id_allEnabledTlsVersions == IntPtr.Zero)
					id_allEnabledTlsVersions = JNIEnv.GetMethodID (class_ref, "allEnabledTlsVersions", "()Lokhttp3/ConnectionSpec$Builder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_allEnabledTlsVersions), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/ConnectionSpec;", "")]
			public unsafe global::Okhttp3.ConnectionSpec Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/ConnectionSpec;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_cipherSuites_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='cipherSuites' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
			[Register ("cipherSuites", "([Ljava/lang/String;)Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder CipherSuites (params string[] cipherSuites)
			{
				if (id_cipherSuites_arrayLjava_lang_String_ == IntPtr.Zero)
					id_cipherSuites_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cipherSuites", "([Ljava/lang/String;)Lokhttp3/ConnectionSpec$Builder;");
				IntPtr native_cipherSuites = JNIEnv.NewArray (cipherSuites);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_cipherSuites);
					global::Okhttp3.ConnectionSpec.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cipherSuites_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (cipherSuites != null) {
						JNIEnv.CopyArray (native_cipherSuites, cipherSuites);
						JNIEnv.DeleteLocalRef (native_cipherSuites);
					}
				}
			}

			static IntPtr id_cipherSuites_arrayLokhttp3_CipherSuite_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='cipherSuites' and count(parameter)=1 and parameter[1][@type='okhttp3.CipherSuite...']]"
			[Register ("cipherSuites", "([Lokhttp3/CipherSuite;)Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder CipherSuites (params global::Okhttp3.CipherSuite[] cipherSuites)
			{
				if (id_cipherSuites_arrayLokhttp3_CipherSuite_ == IntPtr.Zero)
					id_cipherSuites_arrayLokhttp3_CipherSuite_ = JNIEnv.GetMethodID (class_ref, "cipherSuites", "([Lokhttp3/CipherSuite;)Lokhttp3/ConnectionSpec$Builder;");
				IntPtr native_cipherSuites = JNIEnv.NewArray (cipherSuites);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_cipherSuites);
					global::Okhttp3.ConnectionSpec.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cipherSuites_arrayLokhttp3_CipherSuite_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (cipherSuites != null) {
						JNIEnv.CopyArray (native_cipherSuites, cipherSuites);
						JNIEnv.DeleteLocalRef (native_cipherSuites);
					}
				}
			}

			static IntPtr id_supportsTlsExtensions_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='supportsTlsExtensions' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Obsolete (@"deprecated")]
			[Register ("supportsTlsExtensions", "(Z)Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder SupportsTlsExtensions (bool supportsTlsExtensions)
			{
				if (id_supportsTlsExtensions_Z == IntPtr.Zero)
					id_supportsTlsExtensions_Z = JNIEnv.GetMethodID (class_ref, "supportsTlsExtensions", "(Z)Lokhttp3/ConnectionSpec$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (supportsTlsExtensions);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_supportsTlsExtensions_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_tlsVersions_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='tlsVersions' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
			[Register ("tlsVersions", "([Ljava/lang/String;)Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder TlsVersions (params string[] tlsVersions)
			{
				if (id_tlsVersions_arrayLjava_lang_String_ == IntPtr.Zero)
					id_tlsVersions_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "tlsVersions", "([Ljava/lang/String;)Lokhttp3/ConnectionSpec$Builder;");
				IntPtr native_tlsVersions = JNIEnv.NewArray (tlsVersions);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_tlsVersions);
					global::Okhttp3.ConnectionSpec.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tlsVersions_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (tlsVersions != null) {
						JNIEnv.CopyArray (native_tlsVersions, tlsVersions);
						JNIEnv.DeleteLocalRef (native_tlsVersions);
					}
				}
			}

			static IntPtr id_tlsVersions_arrayLokhttp3_TlsVersion_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec.Builder']/method[@name='tlsVersions' and count(parameter)=1 and parameter[1][@type='okhttp3.TlsVersion...']]"
			[Register ("tlsVersions", "([Lokhttp3/TlsVersion;)Lokhttp3/ConnectionSpec$Builder;", "")]
			public unsafe global::Okhttp3.ConnectionSpec.Builder TlsVersions (params global::Okhttp3.TlsVersion[] tlsVersions)
			{
				if (id_tlsVersions_arrayLokhttp3_TlsVersion_ == IntPtr.Zero)
					id_tlsVersions_arrayLokhttp3_TlsVersion_ = JNIEnv.GetMethodID (class_ref, "tlsVersions", "([Lokhttp3/TlsVersion;)Lokhttp3/ConnectionSpec$Builder;");
				IntPtr native_tlsVersions = JNIEnv.NewArray (tlsVersions);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_tlsVersions);
					global::Okhttp3.ConnectionSpec.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tlsVersions_arrayLokhttp3_TlsVersion_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (tlsVersions != null) {
						JNIEnv.CopyArray (native_tlsVersions, tlsVersions);
						JNIEnv.DeleteLocalRef (native_tlsVersions);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/ConnectionSpec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionSpec); }
		}

		internal ConnectionSpec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isTls;
		public unsafe bool IsTls {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/method[@name='isTls' and count(parameter)=0]"
			[Register ("isTls", "()Z", "")]
			get {
				if (id_isTls == IntPtr.Zero)
					id_isTls = JNIEnv.GetMethodID (class_ref, "isTls", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTls);
				} finally {
				}
			}
		}

		static IntPtr id_cipherSuites;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/method[@name='cipherSuites' and count(parameter)=0]"
		[Register ("cipherSuites", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.CipherSuite> CipherSuites ()
		{
			if (id_cipherSuites == IntPtr.Zero)
				id_cipherSuites = JNIEnv.GetMethodID (class_ref, "cipherSuites", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Okhttp3.CipherSuite>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cipherSuites), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_isCompatible_Ljavax_net_ssl_SSLSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/method[@name='isCompatible' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocket']]"
		[Register ("isCompatible", "(Ljavax/net/ssl/SSLSocket;)Z", "")]
		public unsafe bool IsCompatible (global::Javax.Net.Ssl.SSLSocket socket)
		{
			if (id_isCompatible_Ljavax_net_ssl_SSLSocket_ == IntPtr.Zero)
				id_isCompatible_Ljavax_net_ssl_SSLSocket_ = JNIEnv.GetMethodID (class_ref, "isCompatible", "(Ljavax/net/ssl/SSLSocket;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (socket);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCompatible_Ljavax_net_ssl_SSLSocket_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_supportsTlsExtensions;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/method[@name='supportsTlsExtensions' and count(parameter)=0]"
		[Register ("supportsTlsExtensions", "()Z", "")]
		public unsafe bool SupportsTlsExtensions ()
		{
			if (id_supportsTlsExtensions == IntPtr.Zero)
				id_supportsTlsExtensions = JNIEnv.GetMethodID (class_ref, "supportsTlsExtensions", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_supportsTlsExtensions);
			} finally {
			}
		}

		static IntPtr id_tlsVersions;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionSpec']/method[@name='tlsVersions' and count(parameter)=0]"
		[Register ("tlsVersions", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.TlsVersion> TlsVersions ()
		{
			if (id_tlsVersions == IntPtr.Zero)
				id_tlsVersions = JNIEnv.GetMethodID (class_ref, "tlsVersions", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Okhttp3.TlsVersion>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tlsVersions), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
