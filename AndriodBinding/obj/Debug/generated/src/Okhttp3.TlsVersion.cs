using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']"
	[global::Android.Runtime.Register ("okhttp3/TlsVersion", DoNotGenerateAcw=true)]
	public sealed partial class TlsVersion : global::Java.Lang.Enum {


		static IntPtr SSL_3_0_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/field[@name='SSL_3_0']"
		[Register ("SSL_3_0")]
		public static global::Okhttp3.TlsVersion Ssl30 {
			get {
				if (SSL_3_0_jfieldId == IntPtr.Zero)
					SSL_3_0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SSL_3_0", "Lokhttp3/TlsVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SSL_3_0_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_1_0_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/field[@name='TLS_1_0']"
		[Register ("TLS_1_0")]
		public static global::Okhttp3.TlsVersion Tls10 {
			get {
				if (TLS_1_0_jfieldId == IntPtr.Zero)
					TLS_1_0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_1_0", "Lokhttp3/TlsVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_1_0_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_1_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/field[@name='TLS_1_1']"
		[Register ("TLS_1_1")]
		public static global::Okhttp3.TlsVersion Tls11 {
			get {
				if (TLS_1_1_jfieldId == IntPtr.Zero)
					TLS_1_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_1_1", "Lokhttp3/TlsVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_1_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_1_2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/field[@name='TLS_1_2']"
		[Register ("TLS_1_2")]
		public static global::Okhttp3.TlsVersion Tls12 {
			get {
				if (TLS_1_2_jfieldId == IntPtr.Zero)
					TLS_1_2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_1_2", "Lokhttp3/TlsVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_1_2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TLS_1_3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/field[@name='TLS_1_3']"
		[Register ("TLS_1_3")]
		public static global::Okhttp3.TlsVersion Tls13 {
			get {
				if (TLS_1_3_jfieldId == IntPtr.Zero)
					TLS_1_3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TLS_1_3", "Lokhttp3/TlsVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TLS_1_3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/TlsVersion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TlsVersion); }
		}

		internal TlsVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_forJavaName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/method[@name='forJavaName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("forJavaName", "(Ljava/lang/String;)Lokhttp3/TlsVersion;", "")]
		public static unsafe global::Okhttp3.TlsVersion ForJavaName (string javaName)
		{
			if (id_forJavaName_Ljava_lang_String_ == IntPtr.Zero)
				id_forJavaName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "forJavaName", "(Ljava/lang/String;)Lokhttp3/TlsVersion;");
			IntPtr native_javaName = JNIEnv.NewString (javaName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_javaName);
				global::Okhttp3.TlsVersion __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (JNIEnv.CallStaticObjectMethod  (class_ref, id_forJavaName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_javaName);
			}
		}

		static IntPtr id_javaName;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/method[@name='javaName' and count(parameter)=0]"
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

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lokhttp3/TlsVersion;", "")]
		public static unsafe global::Okhttp3.TlsVersion ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lokhttp3/TlsVersion;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Okhttp3.TlsVersion __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='TlsVersion']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lokhttp3/TlsVersion;", "")]
		public static unsafe global::Okhttp3.TlsVersion[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lokhttp3/TlsVersion;");
			try {
				return (global::Okhttp3.TlsVersion[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Okhttp3.TlsVersion));
			} finally {
			}
		}

	}
}
