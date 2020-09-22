using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Time {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/time/DateFormatUtils", DoNotGenerateAcw=true)]
	public partial class DateFormatUtils : global::Java.Lang.Object {


		static IntPtr ISO_8601_EXTENDED_DATETIME_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_8601_EXTENDED_DATETIME_FORMAT']"
		[Register ("ISO_8601_EXTENDED_DATETIME_FORMAT")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat Iso8601ExtendedDatetimeFormat {
			get {
				if (ISO_8601_EXTENDED_DATETIME_FORMAT_jfieldId == IntPtr.Zero)
					ISO_8601_EXTENDED_DATETIME_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_8601_EXTENDED_DATETIME_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_8601_EXTENDED_DATETIME_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_8601_EXTENDED_DATETIME_TIME_ZONE_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_8601_EXTENDED_DATETIME_TIME_ZONE_FORMAT']"
		[Register ("ISO_8601_EXTENDED_DATETIME_TIME_ZONE_FORMAT")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat Iso8601ExtendedDatetimeTimeZoneFormat {
			get {
				if (ISO_8601_EXTENDED_DATETIME_TIME_ZONE_FORMAT_jfieldId == IntPtr.Zero)
					ISO_8601_EXTENDED_DATETIME_TIME_ZONE_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_8601_EXTENDED_DATETIME_TIME_ZONE_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_8601_EXTENDED_DATETIME_TIME_ZONE_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_8601_EXTENDED_DATE_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_8601_EXTENDED_DATE_FORMAT']"
		[Register ("ISO_8601_EXTENDED_DATE_FORMAT")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat Iso8601ExtendedDateFormat {
			get {
				if (ISO_8601_EXTENDED_DATE_FORMAT_jfieldId == IntPtr.Zero)
					ISO_8601_EXTENDED_DATE_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_8601_EXTENDED_DATE_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_8601_EXTENDED_DATE_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_8601_EXTENDED_TIME_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_8601_EXTENDED_TIME_FORMAT']"
		[Register ("ISO_8601_EXTENDED_TIME_FORMAT")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat Iso8601ExtendedTimeFormat {
			get {
				if (ISO_8601_EXTENDED_TIME_FORMAT_jfieldId == IntPtr.Zero)
					ISO_8601_EXTENDED_TIME_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_8601_EXTENDED_TIME_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_8601_EXTENDED_TIME_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_8601_EXTENDED_TIME_TIME_ZONE_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_8601_EXTENDED_TIME_TIME_ZONE_FORMAT']"
		[Register ("ISO_8601_EXTENDED_TIME_TIME_ZONE_FORMAT")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat Iso8601ExtendedTimeTimeZoneFormat {
			get {
				if (ISO_8601_EXTENDED_TIME_TIME_ZONE_FORMAT_jfieldId == IntPtr.Zero)
					ISO_8601_EXTENDED_TIME_TIME_ZONE_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_8601_EXTENDED_TIME_TIME_ZONE_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_8601_EXTENDED_TIME_TIME_ZONE_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_DATETIME_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_DATETIME_FORMAT']"
		[Register ("ISO_DATETIME_FORMAT")]
		[Obsolete ("deprecated")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat IsoDatetimeFormat {
			get {
				if (ISO_DATETIME_FORMAT_jfieldId == IntPtr.Zero)
					ISO_DATETIME_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_DATETIME_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_DATETIME_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_DATETIME_TIME_ZONE_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_DATETIME_TIME_ZONE_FORMAT']"
		[Register ("ISO_DATETIME_TIME_ZONE_FORMAT")]
		[Obsolete ("deprecated")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat IsoDatetimeTimeZoneFormat {
			get {
				if (ISO_DATETIME_TIME_ZONE_FORMAT_jfieldId == IntPtr.Zero)
					ISO_DATETIME_TIME_ZONE_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_DATETIME_TIME_ZONE_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_DATETIME_TIME_ZONE_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_DATE_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_DATE_FORMAT']"
		[Register ("ISO_DATE_FORMAT")]
		[Obsolete ("deprecated")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat IsoDateFormat {
			get {
				if (ISO_DATE_FORMAT_jfieldId == IntPtr.Zero)
					ISO_DATE_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_DATE_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_DATE_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_DATE_TIME_ZONE_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_DATE_TIME_ZONE_FORMAT']"
		[Register ("ISO_DATE_TIME_ZONE_FORMAT")]
		[Obsolete ("deprecated")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat IsoDateTimeZoneFormat {
			get {
				if (ISO_DATE_TIME_ZONE_FORMAT_jfieldId == IntPtr.Zero)
					ISO_DATE_TIME_ZONE_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_DATE_TIME_ZONE_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_DATE_TIME_ZONE_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_TIME_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_TIME_FORMAT']"
		[Register ("ISO_TIME_FORMAT")]
		[Obsolete ("deprecated")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat IsoTimeFormat {
			get {
				if (ISO_TIME_FORMAT_jfieldId == IntPtr.Zero)
					ISO_TIME_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_TIME_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_TIME_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_TIME_NO_T_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_TIME_NO_T_FORMAT']"
		[Register ("ISO_TIME_NO_T_FORMAT")]
		[Obsolete ("deprecated")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat IsoTimeNoTFormat {
			get {
				if (ISO_TIME_NO_T_FORMAT_jfieldId == IntPtr.Zero)
					ISO_TIME_NO_T_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_TIME_NO_T_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_TIME_NO_T_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_TIME_NO_T_TIME_ZONE_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_TIME_NO_T_TIME_ZONE_FORMAT']"
		[Register ("ISO_TIME_NO_T_TIME_ZONE_FORMAT")]
		[Obsolete ("deprecated")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat IsoTimeNoTTimeZoneFormat {
			get {
				if (ISO_TIME_NO_T_TIME_ZONE_FORMAT_jfieldId == IntPtr.Zero)
					ISO_TIME_NO_T_TIME_ZONE_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_TIME_NO_T_TIME_ZONE_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_TIME_NO_T_TIME_ZONE_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_TIME_TIME_ZONE_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='ISO_TIME_TIME_ZONE_FORMAT']"
		[Register ("ISO_TIME_TIME_ZONE_FORMAT")]
		[Obsolete ("deprecated")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat IsoTimeTimeZoneFormat {
			get {
				if (ISO_TIME_TIME_ZONE_FORMAT_jfieldId == IntPtr.Zero)
					ISO_TIME_TIME_ZONE_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_TIME_TIME_ZONE_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_TIME_TIME_ZONE_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SMTP_DATETIME_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/field[@name='SMTP_DATETIME_FORMAT']"
		[Register ("SMTP_DATETIME_FORMAT")]
		public static global::Org.Apache.Commons.Lang3.Time.FastDateFormat SmtpDatetimeFormat {
			get {
				if (SMTP_DATETIME_FORMAT_jfieldId == IntPtr.Zero)
					SMTP_DATETIME_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SMTP_DATETIME_FORMAT", "Lorg/apache/commons/lang3/time/FastDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SMTP_DATETIME_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/time/DateFormatUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateFormatUtils); }
		}

		protected DateFormatUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/constructor[@name='DateFormatUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateFormatUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateFormatUtils)) {
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

		static IntPtr id_format_Ljava_util_Calendar_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.lang.String']]"
		[Register ("format", "(Ljava/util/Calendar;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Calendar calendar, string pattern)
		{
			if (id_format_Ljava_util_Calendar_Ljava_lang_String_ == IntPtr.Zero)
				id_format_Ljava_util_Calendar_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Calendar;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (native_pattern);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Calendar_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Locale']]"
		[Register ("format", "(Ljava/util/Calendar;Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Calendar calendar, string pattern, global::Java.Util.Locale locale)
		{
			if (id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_Locale_ == IntPtr.Zero)
				id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Calendar;Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.TimeZone']]"
		[Register ("format", "(Ljava/util/Calendar;Ljava/lang/String;Ljava/util/TimeZone;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Calendar calendar, string pattern, global::Java.Util.TimeZone timeZone)
		{
			if (id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_TimeZone_ == IntPtr.Zero)
				id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_TimeZone_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Calendar;Ljava/lang/String;Ljava/util/TimeZone;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (timeZone);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=4 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.TimeZone'] and parameter[4][@type='java.util.Locale']]"
		[Register ("format", "(Ljava/util/Calendar;Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Calendar calendar, string pattern, global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale)
		{
			if (id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_ == IntPtr.Zero)
				id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Calendar;Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (timeZone);
				__args [3] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Calendar_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_Ljava_util_Date_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.String']]"
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

		static IntPtr id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Locale']]"
		[Register ("format", "(Ljava/util/Date;Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Date date, string pattern, global::Java.Util.Locale locale)
		{
			if (id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_Locale_ == IntPtr.Zero)
				id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Date;Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (date);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.TimeZone']]"
		[Register ("format", "(Ljava/util/Date;Ljava/lang/String;Ljava/util/TimeZone;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Date date, string pattern, global::Java.Util.TimeZone timeZone)
		{
			if (id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_TimeZone_ == IntPtr.Zero)
				id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_TimeZone_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Date;Ljava/lang/String;Ljava/util/TimeZone;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (date);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (timeZone);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=4 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.TimeZone'] and parameter[4][@type='java.util.Locale']]"
		[Register ("format", "(Ljava/util/Date;Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Date date, string pattern, global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale)
		{
			if (id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_ == IntPtr.Zero)
				id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Date;Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (date);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (timeZone);
				__args [3] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Date_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("format", "(JLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Format (long millis, string pattern)
		{
			if (id_format_JLjava_lang_String_ == IntPtr.Zero)
				id_format_JLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(JLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (millis);
				__args [1] = new JValue (native_pattern);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_JLjava_lang_String_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Locale']]"
		[Register ("format", "(JLjava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string Format (long millis, string pattern, global::Java.Util.Locale locale)
		{
			if (id_format_JLjava_lang_String_Ljava_util_Locale_ == IntPtr.Zero)
				id_format_JLjava_lang_String_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(JLjava/lang/String;Ljava/util/Locale;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (millis);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_JLjava_lang_String_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_JLjava_lang_String_Ljava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.TimeZone']]"
		[Register ("format", "(JLjava/lang/String;Ljava/util/TimeZone;)Ljava/lang/String;", "")]
		public static unsafe string Format (long millis, string pattern, global::Java.Util.TimeZone timeZone)
		{
			if (id_format_JLjava_lang_String_Ljava_util_TimeZone_ == IntPtr.Zero)
				id_format_JLjava_lang_String_Ljava_util_TimeZone_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(JLjava/lang/String;Ljava/util/TimeZone;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (millis);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (timeZone);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_JLjava_lang_String_Ljava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_format_JLjava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='format' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.TimeZone'] and parameter[4][@type='java.util.Locale']]"
		[Register ("format", "(JLjava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string Format (long millis, string pattern, global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale)
		{
			if (id_format_JLjava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_ == IntPtr.Zero)
				id_format_JLjava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(JLjava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (millis);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (timeZone);
				__args [3] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_JLjava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_formatUTC_Ljava_util_Date_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='formatUTC' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.String']]"
		[Register ("formatUTC", "(Ljava/util/Date;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string FormatUTC (global::Java.Util.Date date, string pattern)
		{
			if (id_formatUTC_Ljava_util_Date_Ljava_lang_String_ == IntPtr.Zero)
				id_formatUTC_Ljava_util_Date_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "formatUTC", "(Ljava/util/Date;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (native_pattern);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatUTC_Ljava_util_Date_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_formatUTC_Ljava_util_Date_Ljava_lang_String_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='formatUTC' and count(parameter)=3 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Locale']]"
		[Register ("formatUTC", "(Ljava/util/Date;Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string FormatUTC (global::Java.Util.Date date, string pattern, global::Java.Util.Locale locale)
		{
			if (id_formatUTC_Ljava_util_Date_Ljava_lang_String_Ljava_util_Locale_ == IntPtr.Zero)
				id_formatUTC_Ljava_util_Date_Ljava_lang_String_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "formatUTC", "(Ljava/util/Date;Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (date);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatUTC_Ljava_util_Date_Ljava_lang_String_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_formatUTC_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='formatUTC' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("formatUTC", "(JLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string FormatUTC (long millis, string pattern)
		{
			if (id_formatUTC_JLjava_lang_String_ == IntPtr.Zero)
				id_formatUTC_JLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "formatUTC", "(JLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (millis);
				__args [1] = new JValue (native_pattern);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatUTC_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_formatUTC_JLjava_lang_String_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateFormatUtils']/method[@name='formatUTC' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Locale']]"
		[Register ("formatUTC", "(JLjava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string FormatUTC (long millis, string pattern, global::Java.Util.Locale locale)
		{
			if (id_formatUTC_JLjava_lang_String_Ljava_util_Locale_ == IntPtr.Zero)
				id_formatUTC_JLjava_lang_String_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "formatUTC", "(JLjava/lang/String;Ljava/util/Locale;)Ljava/lang/String;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (millis);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatUTC_JLjava_lang_String_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

	}
}
