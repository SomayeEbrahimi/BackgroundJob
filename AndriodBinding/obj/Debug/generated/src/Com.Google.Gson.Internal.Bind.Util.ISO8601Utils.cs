using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal.Bind.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/util/ISO8601Utils", DoNotGenerateAcw=true)]
	public partial class ISO8601Utils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/bind/util/ISO8601Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISO8601Utils); }
		}

		protected ISO8601Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']/constructor[@name='ISO8601Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ISO8601Utils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ISO8601Utils)) {
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

		static IntPtr id_format_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("format", "(Ljava/util/Date;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Date date)
		{
			if (id_format_Ljava_util_Date_ == IntPtr.Zero)
				id_format_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Date;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_format_Ljava_util_Date_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='boolean']]"
		[Register ("format", "(Ljava/util/Date;Z)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Date date, bool millis)
		{
			if (id_format_Ljava_util_Date_Z == IntPtr.Zero)
				id_format_Ljava_util_Date_Z = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Date;Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (millis);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Date_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_format_Ljava_util_Date_ZLjava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.util.Date'] and parameter[2][@type='boolean'] and parameter[3][@type='java.util.TimeZone']]"
		[Register ("format", "(Ljava/util/Date;ZLjava/util/TimeZone;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Date date, bool millis, global::Java.Util.TimeZone tz)
		{
			if (id_format_Ljava_util_Date_ZLjava_util_TimeZone_ == IntPtr.Zero)
				id_format_Ljava_util_Date_ZLjava_util_TimeZone_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Date;ZLjava/util/TimeZone;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (date);
				__args [1] = new JValue (millis);
				__args [2] = new JValue (tz);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Date_ZLjava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_lang_String_Ljava_text_ParsePosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.text.ParsePosition']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Parse (string date, global::Java.Text.ParsePosition pos)
		{
			if (id_parse_Ljava_lang_String_Ljava_text_ParsePosition_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_Ljava_text_ParsePosition_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
			IntPtr native_date = JNIEnv.NewString (date);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_date);
				__args [1] = new JValue (pos);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_Ljava_text_ParsePosition_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_date);
			}
		}

	}
}
