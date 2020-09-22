using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']"
	[global::Android.Runtime.Register ("okhttp3/CipherSuite", DoNotGenerateAcw=true)]
	public sealed partial class CipherSuite : global::Java.Lang.Object {


		static IntPtr TLS_AES_128_CCM_8_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_AES_128_CCM_8_SHA256']"
		[Register ("TLS_AES_128_CCM_8_SHA256")]
		public static global::Okhttp3.CipherSuite TlsAes128Ccm8Sha256 {
			get {
				if (TLS_AES_128_CCM_8_SHA256_jfieldId == IntPtr.Zero)
					TLS_AES_128_CCM_8_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_AES_128_CCM_8_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_AES_128_CCM_8_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_AES_128_CCM_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_AES_128_CCM_SHA256']"
		[Register ("TLS_AES_128_CCM_SHA256")]
		public static global::Okhttp3.CipherSuite TlsAes128CcmSha256 {
			get {
				if (TLS_AES_128_CCM_SHA256_jfieldId == IntPtr.Zero)
					TLS_AES_128_CCM_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_AES_128_CCM_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_AES_128_CCM_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_AES_128_GCM_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_AES_128_GCM_SHA256']"
		[Register ("TLS_AES_128_GCM_SHA256")]
		public static global::Okhttp3.CipherSuite TlsAes128GcmSha256 {
			get {
				if (TLS_AES_128_GCM_SHA256_jfieldId == IntPtr.Zero)
					TLS_AES_128_GCM_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_AES_128_GCM_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_AES_128_GCM_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_AES_256_GCM_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_AES_256_GCM_SHA384']"
		[Register ("TLS_AES_256_GCM_SHA384")]
		public static global::Okhttp3.CipherSuite TlsAes256GcmSha384 {
			get {
				if (TLS_AES_256_GCM_SHA384_jfieldId == IntPtr.Zero)
					TLS_AES_256_GCM_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_AES_256_GCM_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_AES_256_GCM_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_CHACHA20_POLY1305_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_CHACHA20_POLY1305_SHA256']"
		[Register ("TLS_CHACHA20_POLY1305_SHA256")]
		public static global::Okhttp3.CipherSuite TlsChacha20Poly1305Sha256 {
			get {
				if (TLS_CHACHA20_POLY1305_SHA256_jfieldId == IntPtr.Zero)
					TLS_CHACHA20_POLY1305_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_CHACHA20_POLY1305_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_CHACHA20_POLY1305_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA']"
		[Register ("TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheDssExportWithDes40CbcSha {
			get {
				if (TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheDssWith3desEdeCbcSha {
			get {
				if (TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_DHE_DSS_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheDssWithAes128CbcSha {
			get {
				if (TLS_DHE_DSS_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_WITH_AES_128_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_WITH_AES_128_CBC_SHA256']"
		[Register ("TLS_DHE_DSS_WITH_AES_128_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TlsDheDssWithAes128CbcSha256 {
			get {
				if (TLS_DHE_DSS_WITH_AES_128_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_WITH_AES_128_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_WITH_AES_128_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_WITH_AES_128_GCM_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_WITH_AES_128_GCM_SHA256']"
		[Register ("TLS_DHE_DSS_WITH_AES_128_GCM_SHA256")]
		public static global::Okhttp3.CipherSuite TlsDheDssWithAes128GcmSha256 {
			get {
				if (TLS_DHE_DSS_WITH_AES_128_GCM_SHA256_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_WITH_AES_128_GCM_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_WITH_AES_128_GCM_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_WITH_AES_128_GCM_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_DHE_DSS_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheDssWithAes256CbcSha {
			get {
				if (TLS_DHE_DSS_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_WITH_AES_256_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_WITH_AES_256_CBC_SHA256']"
		[Register ("TLS_DHE_DSS_WITH_AES_256_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TlsDheDssWithAes256CbcSha256 {
			get {
				if (TLS_DHE_DSS_WITH_AES_256_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_WITH_AES_256_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_WITH_AES_256_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_WITH_AES_256_GCM_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_WITH_AES_256_GCM_SHA384']"
		[Register ("TLS_DHE_DSS_WITH_AES_256_GCM_SHA384")]
		public static global::Okhttp3.CipherSuite TlsDheDssWithAes256GcmSha384 {
			get {
				if (TLS_DHE_DSS_WITH_AES_256_GCM_SHA384_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_WITH_AES_256_GCM_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_WITH_AES_256_GCM_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_WITH_AES_256_GCM_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA']"
		[Register ("TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheDssWithCamellia128CbcSha {
			get {
				if (TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA']"
		[Register ("TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheDssWithCamellia256CbcSha {
			get {
				if (TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_DSS_WITH_DES_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_DSS_WITH_DES_CBC_SHA']"
		[Register ("TLS_DHE_DSS_WITH_DES_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheDssWithDesCbcSha {
			get {
				if (TLS_DHE_DSS_WITH_DES_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_DSS_WITH_DES_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_DSS_WITH_DES_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_DSS_WITH_DES_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA']"
		[Register ("TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheRsaExportWithDes40CbcSha {
			get {
				if (TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWith3desEdeCbcSha {
			get {
				if (TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_DHE_RSA_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWithAes128CbcSha {
			get {
				if (TLS_DHE_RSA_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_AES_128_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_AES_128_CBC_SHA256']"
		[Register ("TLS_DHE_RSA_WITH_AES_128_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWithAes128CbcSha256 {
			get {
				if (TLS_DHE_RSA_WITH_AES_128_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_AES_128_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_AES_128_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_AES_128_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_AES_128_GCM_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_AES_128_GCM_SHA256']"
		[Register ("TLS_DHE_RSA_WITH_AES_128_GCM_SHA256")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWithAes128GcmSha256 {
			get {
				if (TLS_DHE_RSA_WITH_AES_128_GCM_SHA256_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_AES_128_GCM_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_AES_128_GCM_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_DHE_RSA_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWithAes256CbcSha {
			get {
				if (TLS_DHE_RSA_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_AES_256_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_AES_256_CBC_SHA256']"
		[Register ("TLS_DHE_RSA_WITH_AES_256_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWithAes256CbcSha256 {
			get {
				if (TLS_DHE_RSA_WITH_AES_256_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_AES_256_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_AES_256_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_AES_256_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_AES_256_GCM_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_AES_256_GCM_SHA384']"
		[Register ("TLS_DHE_RSA_WITH_AES_256_GCM_SHA384")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWithAes256GcmSha384 {
			get {
				if (TLS_DHE_RSA_WITH_AES_256_GCM_SHA384_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_AES_256_GCM_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_AES_256_GCM_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA']"
		[Register ("TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWithCamellia128CbcSha {
			get {
				if (TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA']"
		[Register ("TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWithCamellia256CbcSha {
			get {
				if (TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256']"
		[Register ("TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWithChacha20Poly1305Sha256 {
			get {
				if (TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DHE_RSA_WITH_DES_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DHE_RSA_WITH_DES_CBC_SHA']"
		[Register ("TLS_DHE_RSA_WITH_DES_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsDheRsaWithDesCbcSha {
			get {
				if (TLS_DHE_RSA_WITH_DES_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DHE_RSA_WITH_DES_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DHE_RSA_WITH_DES_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DHE_RSA_WITH_DES_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA']"
		[Register ("TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TLSDHAnonEXPORTWITHDES40CBCSHA {
			get {
				if (TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_EXPORT_WITH_RC4_40_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_EXPORT_WITH_RC4_40_MD5']"
		[Register ("TLS_DH_anon_EXPORT_WITH_RC4_40_MD5")]
		public static global::Okhttp3.CipherSuite TLSDHAnonEXPORTWITHRC440MD5 {
			get {
				if (TLS_DH_anon_EXPORT_WITH_RC4_40_MD5_jfieldId == IntPtr.Zero)
					TLS_DH_anon_EXPORT_WITH_RC4_40_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_EXPORT_WITH_RC4_40_MD5", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_EXPORT_WITH_RC4_40_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_DH_anon_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TLSDHAnonWITH3DESEDECBCSHA {
			get {
				if (TLS_DH_anon_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DH_anon_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_DH_anon_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TLSDHAnonWITHAES128CBCSHA {
			get {
				if (TLS_DH_anon_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DH_anon_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_WITH_AES_128_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_WITH_AES_128_CBC_SHA256']"
		[Register ("TLS_DH_anon_WITH_AES_128_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TLSDHAnonWITHAES128CBCSHA256 {
			get {
				if (TLS_DH_anon_WITH_AES_128_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_DH_anon_WITH_AES_128_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_WITH_AES_128_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_WITH_AES_128_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_WITH_AES_128_GCM_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_WITH_AES_128_GCM_SHA256']"
		[Register ("TLS_DH_anon_WITH_AES_128_GCM_SHA256")]
		public static global::Okhttp3.CipherSuite TLSDHAnonWITHAES128GCMSHA256 {
			get {
				if (TLS_DH_anon_WITH_AES_128_GCM_SHA256_jfieldId == IntPtr.Zero)
					TLS_DH_anon_WITH_AES_128_GCM_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_WITH_AES_128_GCM_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_WITH_AES_128_GCM_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_DH_anon_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TLSDHAnonWITHAES256CBCSHA {
			get {
				if (TLS_DH_anon_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DH_anon_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_WITH_AES_256_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_WITH_AES_256_CBC_SHA256']"
		[Register ("TLS_DH_anon_WITH_AES_256_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TLSDHAnonWITHAES256CBCSHA256 {
			get {
				if (TLS_DH_anon_WITH_AES_256_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_DH_anon_WITH_AES_256_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_WITH_AES_256_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_WITH_AES_256_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_WITH_AES_256_GCM_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_WITH_AES_256_GCM_SHA384']"
		[Register ("TLS_DH_anon_WITH_AES_256_GCM_SHA384")]
		public static global::Okhttp3.CipherSuite TLSDHAnonWITHAES256GCMSHA384 {
			get {
				if (TLS_DH_anon_WITH_AES_256_GCM_SHA384_jfieldId == IntPtr.Zero)
					TLS_DH_anon_WITH_AES_256_GCM_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_WITH_AES_256_GCM_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_WITH_AES_256_GCM_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_WITH_DES_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_WITH_DES_CBC_SHA']"
		[Register ("TLS_DH_anon_WITH_DES_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TLSDHAnonWITHDESCBCSHA {
			get {
				if (TLS_DH_anon_WITH_DES_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_DH_anon_WITH_DES_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_WITH_DES_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_WITH_DES_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_DH_anon_WITH_RC4_128_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_DH_anon_WITH_RC4_128_MD5']"
		[Register ("TLS_DH_anon_WITH_RC4_128_MD5")]
		public static global::Okhttp3.CipherSuite TLSDHAnonWITHRC4128MD5 {
			get {
				if (TLS_DH_anon_WITH_RC4_128_MD5_jfieldId == IntPtr.Zero)
					TLS_DH_anon_WITH_RC4_128_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_DH_anon_WITH_RC4_128_MD5", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_DH_anon_WITH_RC4_128_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdheEcdsaWith3desEdeCbcSha {
			get {
				if (TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdheEcdsaWithAes128CbcSha {
			get {
				if (TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256']"
		[Register ("TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdheEcdsaWithAes128CbcSha256 {
			get {
				if (TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256']"
		[Register ("TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdheEcdsaWithAes128GcmSha256 {
			get {
				if (TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdheEcdsaWithAes256CbcSha {
			get {
				if (TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384']"
		[Register ("TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384")]
		public static global::Okhttp3.CipherSuite TlsEcdheEcdsaWithAes256CbcSha384 {
			get {
				if (TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384_jfieldId == IntPtr.Zero)
					TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384']"
		[Register ("TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384")]
		public static global::Okhttp3.CipherSuite TlsEcdheEcdsaWithAes256GcmSha384 {
			get {
				if (TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384_jfieldId == IntPtr.Zero)
					TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256']"
		[Register ("TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdheEcdsaWithChacha20Poly1305Sha256 {
			get {
				if (TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_ECDSA_WITH_NULL_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_ECDSA_WITH_NULL_SHA']"
		[Register ("TLS_ECDHE_ECDSA_WITH_NULL_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdheEcdsaWithNullSha {
			get {
				if (TLS_ECDHE_ECDSA_WITH_NULL_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_ECDSA_WITH_NULL_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_ECDSA_WITH_NULL_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_ECDSA_WITH_NULL_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_ECDSA_WITH_RC4_128_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_ECDSA_WITH_RC4_128_SHA']"
		[Register ("TLS_ECDHE_ECDSA_WITH_RC4_128_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdheEcdsaWithRc4128Sha {
			get {
				if (TLS_ECDHE_ECDSA_WITH_RC4_128_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_ECDSA_WITH_RC4_128_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_ECDSA_WITH_RC4_128_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_ECDSA_WITH_RC4_128_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhePskWithAes128CbcSha {
			get {
				if (TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhePskWithAes256CbcSha {
			get {
				if (TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256']"
		[Register ("TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdhePskWithChacha20Poly1305Sha256 {
			get {
				if (TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdheRsaWith3desEdeCbcSha {
			get {
				if (TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdheRsaWithAes128CbcSha {
			get {
				if (TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256']"
		[Register ("TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdheRsaWithAes128CbcSha256 {
			get {
				if (TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256']"
		[Register ("TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdheRsaWithAes128GcmSha256 {
			get {
				if (TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdheRsaWithAes256CbcSha {
			get {
				if (TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384']"
		[Register ("TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384")]
		public static global::Okhttp3.CipherSuite TlsEcdheRsaWithAes256CbcSha384 {
			get {
				if (TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384_jfieldId == IntPtr.Zero)
					TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384']"
		[Register ("TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384")]
		public static global::Okhttp3.CipherSuite TlsEcdheRsaWithAes256GcmSha384 {
			get {
				if (TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384_jfieldId == IntPtr.Zero)
					TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256']"
		[Register ("TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdheRsaWithChacha20Poly1305Sha256 {
			get {
				if (TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_RSA_WITH_NULL_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_RSA_WITH_NULL_SHA']"
		[Register ("TLS_ECDHE_RSA_WITH_NULL_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdheRsaWithNullSha {
			get {
				if (TLS_ECDHE_RSA_WITH_NULL_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_RSA_WITH_NULL_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_RSA_WITH_NULL_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_RSA_WITH_NULL_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDHE_RSA_WITH_RC4_128_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDHE_RSA_WITH_RC4_128_SHA']"
		[Register ("TLS_ECDHE_RSA_WITH_RC4_128_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdheRsaWithRc4128Sha {
			get {
				if (TLS_ECDHE_RSA_WITH_RC4_128_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDHE_RSA_WITH_RC4_128_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDHE_RSA_WITH_RC4_128_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDHE_RSA_WITH_RC4_128_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhEcdsaWith3desEdeCbcSha {
			get {
				if (TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhEcdsaWithAes128CbcSha {
			get {
				if (TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256']"
		[Register ("TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdhEcdsaWithAes128CbcSha256 {
			get {
				if (TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256']"
		[Register ("TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdhEcdsaWithAes128GcmSha256 {
			get {
				if (TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhEcdsaWithAes256CbcSha {
			get {
				if (TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384']"
		[Register ("TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384")]
		public static global::Okhttp3.CipherSuite TlsEcdhEcdsaWithAes256CbcSha384 {
			get {
				if (TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384_jfieldId == IntPtr.Zero)
					TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384']"
		[Register ("TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384")]
		public static global::Okhttp3.CipherSuite TlsEcdhEcdsaWithAes256GcmSha384 {
			get {
				if (TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384_jfieldId == IntPtr.Zero)
					TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_ECDSA_WITH_NULL_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_ECDSA_WITH_NULL_SHA']"
		[Register ("TLS_ECDH_ECDSA_WITH_NULL_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhEcdsaWithNullSha {
			get {
				if (TLS_ECDH_ECDSA_WITH_NULL_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_ECDSA_WITH_NULL_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_ECDSA_WITH_NULL_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_ECDSA_WITH_NULL_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_ECDSA_WITH_RC4_128_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_ECDSA_WITH_RC4_128_SHA']"
		[Register ("TLS_ECDH_ECDSA_WITH_RC4_128_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhEcdsaWithRc4128Sha {
			get {
				if (TLS_ECDH_ECDSA_WITH_RC4_128_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_ECDSA_WITH_RC4_128_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_ECDSA_WITH_RC4_128_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_ECDSA_WITH_RC4_128_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhRsaWith3desEdeCbcSha {
			get {
				if (TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_RSA_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_RSA_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_ECDH_RSA_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhRsaWithAes128CbcSha {
			get {
				if (TLS_ECDH_RSA_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_RSA_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_RSA_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_RSA_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256']"
		[Register ("TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdhRsaWithAes128CbcSha256 {
			get {
				if (TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256']"
		[Register ("TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256")]
		public static global::Okhttp3.CipherSuite TlsEcdhRsaWithAes128GcmSha256 {
			get {
				if (TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256_jfieldId == IntPtr.Zero)
					TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_RSA_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_RSA_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_ECDH_RSA_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhRsaWithAes256CbcSha {
			get {
				if (TLS_ECDH_RSA_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_RSA_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_RSA_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_RSA_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384']"
		[Register ("TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384")]
		public static global::Okhttp3.CipherSuite TlsEcdhRsaWithAes256CbcSha384 {
			get {
				if (TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384_jfieldId == IntPtr.Zero)
					TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384']"
		[Register ("TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384")]
		public static global::Okhttp3.CipherSuite TlsEcdhRsaWithAes256GcmSha384 {
			get {
				if (TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384_jfieldId == IntPtr.Zero)
					TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_RSA_WITH_NULL_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_RSA_WITH_NULL_SHA']"
		[Register ("TLS_ECDH_RSA_WITH_NULL_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhRsaWithNullSha {
			get {
				if (TLS_ECDH_RSA_WITH_NULL_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_RSA_WITH_NULL_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_RSA_WITH_NULL_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_RSA_WITH_NULL_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_RSA_WITH_RC4_128_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_RSA_WITH_RC4_128_SHA']"
		[Register ("TLS_ECDH_RSA_WITH_RC4_128_SHA")]
		public static global::Okhttp3.CipherSuite TlsEcdhRsaWithRc4128Sha {
			get {
				if (TLS_ECDH_RSA_WITH_RC4_128_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_RSA_WITH_RC4_128_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_RSA_WITH_RC4_128_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_RSA_WITH_RC4_128_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TLSECDHAnonWITH3DESEDECBCSHA {
			get {
				if (TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_anon_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_anon_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_ECDH_anon_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TLSECDHAnonWITHAES128CBCSHA {
			get {
				if (TLS_ECDH_anon_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_anon_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_anon_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_anon_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_anon_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_anon_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_ECDH_anon_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TLSECDHAnonWITHAES256CBCSHA {
			get {
				if (TLS_ECDH_anon_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_anon_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_anon_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_anon_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_anon_WITH_NULL_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_anon_WITH_NULL_SHA']"
		[Register ("TLS_ECDH_anon_WITH_NULL_SHA")]
		public static global::Okhttp3.CipherSuite TLSECDHAnonWITHNULLSHA {
			get {
				if (TLS_ECDH_anon_WITH_NULL_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_anon_WITH_NULL_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_anon_WITH_NULL_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_anon_WITH_NULL_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_ECDH_anon_WITH_RC4_128_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_ECDH_anon_WITH_RC4_128_SHA']"
		[Register ("TLS_ECDH_anon_WITH_RC4_128_SHA")]
		public static global::Okhttp3.CipherSuite TLSECDHAnonWITHRC4128SHA {
			get {
				if (TLS_ECDH_anon_WITH_RC4_128_SHA_jfieldId == IntPtr.Zero)
					TLS_ECDH_anon_WITH_RC4_128_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_ECDH_anon_WITH_RC4_128_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_ECDH_anon_WITH_RC4_128_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_EMPTY_RENEGOTIATION_INFO_SCSV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_EMPTY_RENEGOTIATION_INFO_SCSV']"
		[Register ("TLS_EMPTY_RENEGOTIATION_INFO_SCSV")]
		public static global::Okhttp3.CipherSuite TlsEmptyRenegotiationInfoScsv {
			get {
				if (TLS_EMPTY_RENEGOTIATION_INFO_SCSV_jfieldId == IntPtr.Zero)
					TLS_EMPTY_RENEGOTIATION_INFO_SCSV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_EMPTY_RENEGOTIATION_INFO_SCSV", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_EMPTY_RENEGOTIATION_INFO_SCSV_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_FALLBACK_SCSV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_FALLBACK_SCSV']"
		[Register ("TLS_FALLBACK_SCSV")]
		public static global::Okhttp3.CipherSuite TlsFallbackScsv {
			get {
				if (TLS_FALLBACK_SCSV_jfieldId == IntPtr.Zero)
					TLS_FALLBACK_SCSV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_FALLBACK_SCSV", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_FALLBACK_SCSV_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_KRB5_EXPORT_WITH_DES_CBC_40_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_KRB5_EXPORT_WITH_DES_CBC_40_MD5']"
		[Register ("TLS_KRB5_EXPORT_WITH_DES_CBC_40_MD5")]
		public static global::Okhttp3.CipherSuite TlsKrb5ExportWithDesCbc40Md5 {
			get {
				if (TLS_KRB5_EXPORT_WITH_DES_CBC_40_MD5_jfieldId == IntPtr.Zero)
					TLS_KRB5_EXPORT_WITH_DES_CBC_40_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_KRB5_EXPORT_WITH_DES_CBC_40_MD5", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_KRB5_EXPORT_WITH_DES_CBC_40_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_KRB5_EXPORT_WITH_DES_CBC_40_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_KRB5_EXPORT_WITH_DES_CBC_40_SHA']"
		[Register ("TLS_KRB5_EXPORT_WITH_DES_CBC_40_SHA")]
		public static global::Okhttp3.CipherSuite TlsKrb5ExportWithDesCbc40Sha {
			get {
				if (TLS_KRB5_EXPORT_WITH_DES_CBC_40_SHA_jfieldId == IntPtr.Zero)
					TLS_KRB5_EXPORT_WITH_DES_CBC_40_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_KRB5_EXPORT_WITH_DES_CBC_40_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_KRB5_EXPORT_WITH_DES_CBC_40_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_KRB5_EXPORT_WITH_RC4_40_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_KRB5_EXPORT_WITH_RC4_40_MD5']"
		[Register ("TLS_KRB5_EXPORT_WITH_RC4_40_MD5")]
		public static global::Okhttp3.CipherSuite TlsKrb5ExportWithRc440Md5 {
			get {
				if (TLS_KRB5_EXPORT_WITH_RC4_40_MD5_jfieldId == IntPtr.Zero)
					TLS_KRB5_EXPORT_WITH_RC4_40_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_KRB5_EXPORT_WITH_RC4_40_MD5", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_KRB5_EXPORT_WITH_RC4_40_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_KRB5_EXPORT_WITH_RC4_40_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_KRB5_EXPORT_WITH_RC4_40_SHA']"
		[Register ("TLS_KRB5_EXPORT_WITH_RC4_40_SHA")]
		public static global::Okhttp3.CipherSuite TlsKrb5ExportWithRc440Sha {
			get {
				if (TLS_KRB5_EXPORT_WITH_RC4_40_SHA_jfieldId == IntPtr.Zero)
					TLS_KRB5_EXPORT_WITH_RC4_40_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_KRB5_EXPORT_WITH_RC4_40_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_KRB5_EXPORT_WITH_RC4_40_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_KRB5_WITH_3DES_EDE_CBC_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_KRB5_WITH_3DES_EDE_CBC_MD5']"
		[Register ("TLS_KRB5_WITH_3DES_EDE_CBC_MD5")]
		public static global::Okhttp3.CipherSuite TlsKrb5With3desEdeCbcMd5 {
			get {
				if (TLS_KRB5_WITH_3DES_EDE_CBC_MD5_jfieldId == IntPtr.Zero)
					TLS_KRB5_WITH_3DES_EDE_CBC_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_KRB5_WITH_3DES_EDE_CBC_MD5", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_KRB5_WITH_3DES_EDE_CBC_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_KRB5_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_KRB5_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_KRB5_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsKrb5With3desEdeCbcSha {
			get {
				if (TLS_KRB5_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_KRB5_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_KRB5_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_KRB5_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_KRB5_WITH_DES_CBC_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_KRB5_WITH_DES_CBC_MD5']"
		[Register ("TLS_KRB5_WITH_DES_CBC_MD5")]
		public static global::Okhttp3.CipherSuite TlsKrb5WithDesCbcMd5 {
			get {
				if (TLS_KRB5_WITH_DES_CBC_MD5_jfieldId == IntPtr.Zero)
					TLS_KRB5_WITH_DES_CBC_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_KRB5_WITH_DES_CBC_MD5", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_KRB5_WITH_DES_CBC_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_KRB5_WITH_DES_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_KRB5_WITH_DES_CBC_SHA']"
		[Register ("TLS_KRB5_WITH_DES_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsKrb5WithDesCbcSha {
			get {
				if (TLS_KRB5_WITH_DES_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_KRB5_WITH_DES_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_KRB5_WITH_DES_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_KRB5_WITH_DES_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_KRB5_WITH_RC4_128_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_KRB5_WITH_RC4_128_MD5']"
		[Register ("TLS_KRB5_WITH_RC4_128_MD5")]
		public static global::Okhttp3.CipherSuite TlsKrb5WithRc4128Md5 {
			get {
				if (TLS_KRB5_WITH_RC4_128_MD5_jfieldId == IntPtr.Zero)
					TLS_KRB5_WITH_RC4_128_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_KRB5_WITH_RC4_128_MD5", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_KRB5_WITH_RC4_128_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_KRB5_WITH_RC4_128_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_KRB5_WITH_RC4_128_SHA']"
		[Register ("TLS_KRB5_WITH_RC4_128_SHA")]
		public static global::Okhttp3.CipherSuite TlsKrb5WithRc4128Sha {
			get {
				if (TLS_KRB5_WITH_RC4_128_SHA_jfieldId == IntPtr.Zero)
					TLS_KRB5_WITH_RC4_128_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_KRB5_WITH_RC4_128_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_KRB5_WITH_RC4_128_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_PSK_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_PSK_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_PSK_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsPskWith3desEdeCbcSha {
			get {
				if (TLS_PSK_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_PSK_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_PSK_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_PSK_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_PSK_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_PSK_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_PSK_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsPskWithAes128CbcSha {
			get {
				if (TLS_PSK_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_PSK_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_PSK_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_PSK_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_PSK_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_PSK_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_PSK_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsPskWithAes256CbcSha {
			get {
				if (TLS_PSK_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_PSK_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_PSK_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_PSK_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_PSK_WITH_RC4_128_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_PSK_WITH_RC4_128_SHA']"
		[Register ("TLS_PSK_WITH_RC4_128_SHA")]
		public static global::Okhttp3.CipherSuite TlsPskWithRc4128Sha {
			get {
				if (TLS_PSK_WITH_RC4_128_SHA_jfieldId == IntPtr.Zero)
					TLS_PSK_WITH_RC4_128_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_PSK_WITH_RC4_128_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_PSK_WITH_RC4_128_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_EXPORT_WITH_DES40_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_EXPORT_WITH_DES40_CBC_SHA']"
		[Register ("TLS_RSA_EXPORT_WITH_DES40_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsRsaExportWithDes40CbcSha {
			get {
				if (TLS_RSA_EXPORT_WITH_DES40_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_RSA_EXPORT_WITH_DES40_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_EXPORT_WITH_DES40_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_EXPORT_WITH_DES40_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_EXPORT_WITH_RC4_40_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_EXPORT_WITH_RC4_40_MD5']"
		[Register ("TLS_RSA_EXPORT_WITH_RC4_40_MD5")]
		public static global::Okhttp3.CipherSuite TlsRsaExportWithRc440Md5 {
			get {
				if (TLS_RSA_EXPORT_WITH_RC4_40_MD5_jfieldId == IntPtr.Zero)
					TLS_RSA_EXPORT_WITH_RC4_40_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_EXPORT_WITH_RC4_40_MD5", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_EXPORT_WITH_RC4_40_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_3DES_EDE_CBC_SHA']"
		[Register ("TLS_RSA_WITH_3DES_EDE_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsRsaWith3desEdeCbcSha {
			get {
				if (TLS_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_3DES_EDE_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_3DES_EDE_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_AES_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_AES_128_CBC_SHA']"
		[Register ("TLS_RSA_WITH_AES_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsRsaWithAes128CbcSha {
			get {
				if (TLS_RSA_WITH_AES_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_AES_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_AES_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_AES_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_AES_128_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_AES_128_CBC_SHA256']"
		[Register ("TLS_RSA_WITH_AES_128_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TlsRsaWithAes128CbcSha256 {
			get {
				if (TLS_RSA_WITH_AES_128_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_AES_128_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_AES_128_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_AES_128_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_AES_128_GCM_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_AES_128_GCM_SHA256']"
		[Register ("TLS_RSA_WITH_AES_128_GCM_SHA256")]
		public static global::Okhttp3.CipherSuite TlsRsaWithAes128GcmSha256 {
			get {
				if (TLS_RSA_WITH_AES_128_GCM_SHA256_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_AES_128_GCM_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_AES_128_GCM_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_AES_128_GCM_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_AES_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_AES_256_CBC_SHA']"
		[Register ("TLS_RSA_WITH_AES_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsRsaWithAes256CbcSha {
			get {
				if (TLS_RSA_WITH_AES_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_AES_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_AES_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_AES_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_AES_256_CBC_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_AES_256_CBC_SHA256']"
		[Register ("TLS_RSA_WITH_AES_256_CBC_SHA256")]
		public static global::Okhttp3.CipherSuite TlsRsaWithAes256CbcSha256 {
			get {
				if (TLS_RSA_WITH_AES_256_CBC_SHA256_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_AES_256_CBC_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_AES_256_CBC_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_AES_256_CBC_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_AES_256_GCM_SHA384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_AES_256_GCM_SHA384']"
		[Register ("TLS_RSA_WITH_AES_256_GCM_SHA384")]
		public static global::Okhttp3.CipherSuite TlsRsaWithAes256GcmSha384 {
			get {
				if (TLS_RSA_WITH_AES_256_GCM_SHA384_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_AES_256_GCM_SHA384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_AES_256_GCM_SHA384", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_AES_256_GCM_SHA384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_CAMELLIA_128_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_CAMELLIA_128_CBC_SHA']"
		[Register ("TLS_RSA_WITH_CAMELLIA_128_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsRsaWithCamellia128CbcSha {
			get {
				if (TLS_RSA_WITH_CAMELLIA_128_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_CAMELLIA_128_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_CAMELLIA_128_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_CAMELLIA_128_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_CAMELLIA_256_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_CAMELLIA_256_CBC_SHA']"
		[Register ("TLS_RSA_WITH_CAMELLIA_256_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsRsaWithCamellia256CbcSha {
			get {
				if (TLS_RSA_WITH_CAMELLIA_256_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_CAMELLIA_256_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_CAMELLIA_256_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_CAMELLIA_256_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_DES_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_DES_CBC_SHA']"
		[Register ("TLS_RSA_WITH_DES_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsRsaWithDesCbcSha {
			get {
				if (TLS_RSA_WITH_DES_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_DES_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_DES_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_DES_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_NULL_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_NULL_MD5']"
		[Register ("TLS_RSA_WITH_NULL_MD5")]
		public static global::Okhttp3.CipherSuite TlsRsaWithNullMd5 {
			get {
				if (TLS_RSA_WITH_NULL_MD5_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_NULL_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_NULL_MD5", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_NULL_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_NULL_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_NULL_SHA']"
		[Register ("TLS_RSA_WITH_NULL_SHA")]
		public static global::Okhttp3.CipherSuite TlsRsaWithNullSha {
			get {
				if (TLS_RSA_WITH_NULL_SHA_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_NULL_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_NULL_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_NULL_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_NULL_SHA256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_NULL_SHA256']"
		[Register ("TLS_RSA_WITH_NULL_SHA256")]
		public static global::Okhttp3.CipherSuite TlsRsaWithNullSha256 {
			get {
				if (TLS_RSA_WITH_NULL_SHA256_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_NULL_SHA256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_NULL_SHA256", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_NULL_SHA256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_RC4_128_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_RC4_128_MD5']"
		[Register ("TLS_RSA_WITH_RC4_128_MD5")]
		public static global::Okhttp3.CipherSuite TlsRsaWithRc4128Md5 {
			get {
				if (TLS_RSA_WITH_RC4_128_MD5_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_RC4_128_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_RC4_128_MD5", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_RC4_128_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_RC4_128_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_RC4_128_SHA']"
		[Register ("TLS_RSA_WITH_RC4_128_SHA")]
		public static global::Okhttp3.CipherSuite TlsRsaWithRc4128Sha {
			get {
				if (TLS_RSA_WITH_RC4_128_SHA_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_RC4_128_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_RC4_128_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_RC4_128_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_RSA_WITH_SEED_CBC_SHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/field[@name='TLS_RSA_WITH_SEED_CBC_SHA']"
		[Register ("TLS_RSA_WITH_SEED_CBC_SHA")]
		public static global::Okhttp3.CipherSuite TlsRsaWithSeedCbcSha {
			get {
				if (TLS_RSA_WITH_SEED_CBC_SHA_jfieldId == IntPtr.Zero)
					TLS_RSA_WITH_SEED_CBC_SHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_RSA_WITH_SEED_CBC_SHA", "Lokhttp3/CipherSuite;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_RSA_WITH_SEED_CBC_SHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/CipherSuite", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CipherSuite); }
		}

		internal CipherSuite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_forJavaName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/method[@name='forJavaName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("forJavaName", "(Ljava/lang/String;)Lokhttp3/CipherSuite;", "")]
		public static unsafe global::Okhttp3.CipherSuite ForJavaName (string javaName)
		{
			if (id_forJavaName_Ljava_lang_String_ == IntPtr.Zero)
				id_forJavaName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "forJavaName", "(Ljava/lang/String;)Lokhttp3/CipherSuite;");
			IntPtr native_javaName = JNIEnv.NewString (javaName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_javaName);
				global::Okhttp3.CipherSuite __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (JNIEnv.CallStaticObjectMethod  (class_ref, id_forJavaName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_javaName);
			}
		}

		static IntPtr id_javaName;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CipherSuite']/method[@name='javaName' and count(parameter)=0]"
		[Register ("javaName", "()Ljava/lang/String;", "")]
		public unsafe string JavaName ()
		{
			if (id_javaName == IntPtr.Zero)
				id_javaName = JNIEnv.GetMethodID (class_ref, "javaName", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_javaName), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
