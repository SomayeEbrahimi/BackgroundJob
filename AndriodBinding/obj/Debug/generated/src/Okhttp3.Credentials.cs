using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Credentials']"
	[global::Android.Runtime.Register ("okhttp3/Credentials", DoNotGenerateAcw=true)]
	public sealed partial class Credentials : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Credentials", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Credentials); }
		}

		internal Credentials (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_basic_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Credentials']/method[@name='basic' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("basic", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Basic (string username, string password)
		{
			if (id_basic_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_basic_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "basic", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_username = JNIEnv.NewString (username);
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_username);
				__args [1] = new JValue (native_password);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_basic_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_username);
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

		static IntPtr id_basic_Ljava_lang_String_Ljava_lang_String_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Credentials']/method[@name='basic' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.nio.charset.Charset']]"
		[Register ("basic", "(Ljava/lang/String;Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public static unsafe string Basic (string username, string password, global::Java.Nio.Charset.Charset charset)
		{
			if (id_basic_Ljava_lang_String_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_basic_Ljava_lang_String_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetStaticMethodID (class_ref, "basic", "(Ljava/lang/String;Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;");
			IntPtr native_username = JNIEnv.NewString (username);
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_username);
				__args [1] = new JValue (native_password);
				__args [2] = new JValue (charset);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_basic_Ljava_lang_String_Ljava_lang_String_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_username);
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

	}
}
