using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='DateFormat']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/DateFormat", DoNotGenerateAcw=true)]
	public partial class DateFormat : global::Java.Lang.Object {


		static IntPtr sPattern_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='DateFormat']/field[@name='sPattern']"
		[Register ("sPattern")]
		public static string SPattern {
			get {
				if (sPattern_jfieldId == IntPtr.Zero)
					sPattern_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sPattern", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sPattern_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sPattern_jfieldId == IntPtr.Zero)
					sPattern_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sPattern", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, sPattern_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/utils/DateFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateFormat); }
		}

		protected DateFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='DateFormat']/constructor[@name='DateFormat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateFormat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateFormat)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='DateFormat']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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

		static IntPtr id_format_Ljava_util_Date_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='DateFormat']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.String']]"
		[Register ("format", "(Ljava/util/Date;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Date date, string pattern)
		{
			if (id_format_Ljava_util_Date_Ljava_lang_String_ == IntPtr.Zero)
				id_format_Ljava_util_Date_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Date;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (native_pattern);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Date_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='DateFormat']/method[@name='format' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("format", "(J)Ljava/lang/String;", "")]
		public static unsafe string Format (long timeMillis)
		{
			if (id_format_J == IntPtr.Zero)
				id_format_J = JNIEnv.GetStaticMethodID (class_ref, "format", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeMillis);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_format_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='DateFormat']/method[@name='format' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("format", "(JLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Format (long timeMillis, string pattern)
		{
			if (id_format_JLjava_lang_String_ == IntPtr.Zero)
				id_format_JLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(JLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeMillis);
				__args [1] = new JValue (native_pattern);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

	}
}
