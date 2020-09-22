using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Time {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastTimeZone']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/time/FastTimeZone", DoNotGenerateAcw=true)]
	public partial class FastTimeZone : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/time/FastTimeZone", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FastTimeZone); }
		}

		protected FastTimeZone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getGmtTimeZone;
		public static unsafe global::Java.Util.TimeZone GmtTimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastTimeZone']/method[@name='getGmtTimeZone' and count(parameter)=0]"
			[Register ("getGmtTimeZone", "()Ljava/util/TimeZone;", "")]
			get {
				if (id_getGmtTimeZone == IntPtr.Zero)
					id_getGmtTimeZone = JNIEnv.GetStaticMethodID (class_ref, "getGmtTimeZone", "()Ljava/util/TimeZone;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGmtTimeZone), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getGmtTimeZone_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastTimeZone']/method[@name='getGmtTimeZone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getGmtTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;", "")]
		public static unsafe global::Java.Util.TimeZone GetGmtTimeZone (string pattern)
		{
			if (id_getGmtTimeZone_Ljava_lang_String_ == IntPtr.Zero)
				id_getGmtTimeZone_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getGmtTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pattern);
				global::Java.Util.TimeZone __ret = global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGmtTimeZone_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_getTimeZone_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastTimeZone']/method[@name='getTimeZone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;", "")]
		public static unsafe global::Java.Util.TimeZone GetTimeZone (string id)
		{
			if (id_getTimeZone_Ljava_lang_String_ == IntPtr.Zero)
				id_getTimeZone_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;");
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_id);
				global::Java.Util.TimeZone __ret = global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeZone_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

	}
}
