using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']"
	[global::Android.Runtime.Register ("okhttp3/Challenge", DoNotGenerateAcw=true)]
	public sealed partial class Challenge : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Challenge", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Challenge); }
		}

		internal Challenge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/constructor[@name='Challenge' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Challenge (string scheme, string realm)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_scheme = JNIEnv.NewString (scheme);
			IntPtr native_realm = JNIEnv.NewString (realm);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_scheme);
				__args [1] = new JValue (native_realm);
				if (((object) this).GetType () != typeof (Challenge)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
				JNIEnv.DeleteLocalRef (native_realm);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/constructor[@name='Challenge' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe Challenge (string scheme, global::System.Collections.Generic.IDictionary<string, string> authParams)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_scheme = JNIEnv.NewString (scheme);
			IntPtr native_authParams = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (authParams);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_scheme);
				__args [1] = new JValue (native_authParams);
				if (((object) this).GetType () != typeof (Challenge)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
				JNIEnv.DeleteLocalRef (native_authParams);
			}
		}

		static IntPtr id_authParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/method[@name='authParams' and count(parameter)=0]"
		[Register ("authParams", "()Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, string> AuthParams ()
		{
			if (id_authParams == IntPtr.Zero)
				id_authParams = JNIEnv.GetMethodID (class_ref, "authParams", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_authParams), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_charset;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/method[@name='charset' and count(parameter)=0]"
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

		static IntPtr id_realm;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/method[@name='realm' and count(parameter)=0]"
		[Register ("realm", "()Ljava/lang/String;", "")]
		public unsafe string Realm ()
		{
			if (id_realm == IntPtr.Zero)
				id_realm = JNIEnv.GetMethodID (class_ref, "realm", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_realm), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_scheme;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/method[@name='scheme' and count(parameter)=0]"
		[Register ("scheme", "()Ljava/lang/String;", "")]
		public unsafe string Scheme ()
		{
			if (id_scheme == IntPtr.Zero)
				id_scheme = JNIEnv.GetMethodID (class_ref, "scheme", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scheme), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_withCharset_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/method[@name='withCharset' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("withCharset", "(Ljava/nio/charset/Charset;)Lokhttp3/Challenge;", "")]
		public unsafe global::Okhttp3.Challenge WithCharset (global::Java.Nio.Charset.Charset charset)
		{
			if (id_withCharset_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_withCharset_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "withCharset", "(Ljava/nio/charset/Charset;)Lokhttp3/Challenge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (charset);
				global::Okhttp3.Challenge __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Challenge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCharset_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
