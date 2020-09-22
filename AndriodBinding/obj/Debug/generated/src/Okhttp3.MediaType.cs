using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']"
	[global::Android.Runtime.Register ("okhttp3/MediaType", DoNotGenerateAcw=true)]
	public sealed partial class MediaType : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/MediaType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaType); }
		}

		internal MediaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_charset;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='charset' and count(parameter)=0]"
		[Register ("charset", "()Ljava/nio/charset/Charset;", "")]
		public unsafe global::Java.Nio.Charset.Charset Charset ()
		{
			if (id_charset == IntPtr.Zero)
				id_charset = JNIEnv.GetMethodID (class_ref, "charset", "()Ljava/nio/charset/Charset;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_charset), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_charset_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='charset' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("charset", "(Ljava/nio/charset/Charset;)Ljava/nio/charset/Charset;", "")]
		public unsafe global::Java.Nio.Charset.Charset Charset (global::Java.Nio.Charset.Charset defaultValue)
		{
			if (id_charset_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_charset_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "charset", "(Ljava/nio/charset/Charset;)Ljava/nio/charset/Charset;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultValue);
				global::Java.Nio.Charset.Charset __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_charset_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lokhttp3/MediaType;", "")]
		public static unsafe global::Okhttp3.MediaType Get (string @string)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)Lokhttp3/MediaType;");
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__string);
				global::Okhttp3.MediaType __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lokhttp3/MediaType;", "")]
		public static unsafe global::Okhttp3.MediaType Parse (string @string)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lokhttp3/MediaType;");
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__string);
				global::Okhttp3.MediaType __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static IntPtr id_subtype;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='subtype' and count(parameter)=0]"
		[Register ("subtype", "()Ljava/lang/String;", "")]
		public unsafe string Subtype ()
		{
			if (id_subtype == IntPtr.Zero)
				id_subtype = JNIEnv.GetMethodID (class_ref, "subtype", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subtype), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_type;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Ljava/lang/String;", "")]
		public unsafe string Type ()
		{
			if (id_type == IntPtr.Zero)
				id_type = JNIEnv.GetMethodID (class_ref, "type", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_type), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
