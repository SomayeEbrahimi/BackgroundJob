using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Time {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/time/DateUtils", DoNotGenerateAcw=true)]
	public partial class DateUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='MILLIS_PER_DAY']"
		[Register ("MILLIS_PER_DAY")]
		public const long MillisPerDay = (long) 86400000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='MILLIS_PER_HOUR']"
		[Register ("MILLIS_PER_HOUR")]
		public const long MillisPerHour = (long) 3600000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='MILLIS_PER_MINUTE']"
		[Register ("MILLIS_PER_MINUTE")]
		public const long MillisPerMinute = (long) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='MILLIS_PER_SECOND']"
		[Register ("MILLIS_PER_SECOND")]
		public const long MillisPerSecond = (long) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='RANGE_MONTH_MONDAY']"
		[Register ("RANGE_MONTH_MONDAY")]
		public const int RangeMonthMonday = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='RANGE_MONTH_SUNDAY']"
		[Register ("RANGE_MONTH_SUNDAY")]
		public const int RangeMonthSunday = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='RANGE_WEEK_CENTER']"
		[Register ("RANGE_WEEK_CENTER")]
		public const int RangeWeekCenter = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='RANGE_WEEK_MONDAY']"
		[Register ("RANGE_WEEK_MONDAY")]
		public const int RangeWeekMonday = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='RANGE_WEEK_RELATIVE']"
		[Register ("RANGE_WEEK_RELATIVE")]
		public const int RangeWeekRelative = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='RANGE_WEEK_SUNDAY']"
		[Register ("RANGE_WEEK_SUNDAY")]
		public const int RangeWeekSunday = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/field[@name='SEMI_MONTH']"
		[Register ("SEMI_MONTH")]
		public const int SemiMonth = (int) 1001;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/time/DateUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateUtils); }
		}

		protected DateUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/constructor[@name='DateUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateUtils)) {
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

		static IntPtr id_addDays_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='addDays' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("addDays", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date AddDays (global::Java.Util.Date date, int amount)
		{
			if (id_addDays_Ljava_util_Date_I == IntPtr.Zero)
				id_addDays_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "addDays", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addDays_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addHours_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='addHours' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("addHours", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date AddHours (global::Java.Util.Date date, int amount)
		{
			if (id_addHours_Ljava_util_Date_I == IntPtr.Zero)
				id_addHours_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "addHours", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addHours_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addMilliseconds_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='addMilliseconds' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("addMilliseconds", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date AddMilliseconds (global::Java.Util.Date date, int amount)
		{
			if (id_addMilliseconds_Ljava_util_Date_I == IntPtr.Zero)
				id_addMilliseconds_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "addMilliseconds", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addMilliseconds_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addMinutes_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='addMinutes' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("addMinutes", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date AddMinutes (global::Java.Util.Date date, int amount)
		{
			if (id_addMinutes_Ljava_util_Date_I == IntPtr.Zero)
				id_addMinutes_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "addMinutes", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addMinutes_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addMonths_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='addMonths' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("addMonths", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date AddMonths (global::Java.Util.Date date, int amount)
		{
			if (id_addMonths_Ljava_util_Date_I == IntPtr.Zero)
				id_addMonths_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "addMonths", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addMonths_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addSeconds_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='addSeconds' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("addSeconds", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date AddSeconds (global::Java.Util.Date date, int amount)
		{
			if (id_addSeconds_Ljava_util_Date_I == IntPtr.Zero)
				id_addSeconds_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "addSeconds", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addSeconds_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addWeeks_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='addWeeks' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("addWeeks", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date AddWeeks (global::Java.Util.Date date, int amount)
		{
			if (id_addWeeks_Ljava_util_Date_I == IntPtr.Zero)
				id_addWeeks_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "addWeeks", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addWeeks_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addYears_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='addYears' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("addYears", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date AddYears (global::Java.Util.Date date, int amount)
		{
			if (id_addYears_Ljava_util_Date_I == IntPtr.Zero)
				id_addYears_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "addYears", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addYears_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ceiling_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='ceiling' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("ceiling", "(Ljava/lang/Object;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Ceiling (global::Java.Lang.Object date, int field)
		{
			if (id_ceiling_Ljava_lang_Object_I == IntPtr.Zero)
				id_ceiling_Ljava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "ceiling", "(Ljava/lang/Object;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (field);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ceiling_Ljava_lang_Object_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ceiling_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='ceiling' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register ("ceiling", "(Ljava/util/Calendar;I)Ljava/util/Calendar;", "")]
		public static unsafe global::Java.Util.Calendar Ceiling (global::Java.Util.Calendar date, int field)
		{
			if (id_ceiling_Ljava_util_Calendar_I == IntPtr.Zero)
				id_ceiling_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "ceiling", "(Ljava/util/Calendar;I)Ljava/util/Calendar;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (field);
				global::Java.Util.Calendar __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ceiling_Ljava_util_Calendar_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ceiling_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='ceiling' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("ceiling", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Ceiling (global::Java.Util.Date date, int field)
		{
			if (id_ceiling_Ljava_util_Date_I == IntPtr.Zero)
				id_ceiling_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "ceiling", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (field);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ceiling_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFragmentInDays_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='getFragmentInDays' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register ("getFragmentInDays", "(Ljava/util/Calendar;I)J", "")]
		public static unsafe long GetFragmentInDays (global::Java.Util.Calendar calendar, int fragment)
		{
			if (id_getFragmentInDays_Ljava_util_Calendar_I == IntPtr.Zero)
				id_getFragmentInDays_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "getFragmentInDays", "(Ljava/util/Calendar;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (fragment);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFragmentInDays_Ljava_util_Calendar_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFragmentInDays_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='getFragmentInDays' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("getFragmentInDays", "(Ljava/util/Date;I)J", "")]
		public static unsafe long GetFragmentInDays (global::Java.Util.Date date, int fragment)
		{
			if (id_getFragmentInDays_Ljava_util_Date_I == IntPtr.Zero)
				id_getFragmentInDays_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "getFragmentInDays", "(Ljava/util/Date;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (fragment);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFragmentInDays_Ljava_util_Date_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFragmentInHours_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='getFragmentInHours' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register ("getFragmentInHours", "(Ljava/util/Calendar;I)J", "")]
		public static unsafe long GetFragmentInHours (global::Java.Util.Calendar calendar, int fragment)
		{
			if (id_getFragmentInHours_Ljava_util_Calendar_I == IntPtr.Zero)
				id_getFragmentInHours_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "getFragmentInHours", "(Ljava/util/Calendar;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (fragment);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFragmentInHours_Ljava_util_Calendar_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFragmentInHours_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='getFragmentInHours' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("getFragmentInHours", "(Ljava/util/Date;I)J", "")]
		public static unsafe long GetFragmentInHours (global::Java.Util.Date date, int fragment)
		{
			if (id_getFragmentInHours_Ljava_util_Date_I == IntPtr.Zero)
				id_getFragmentInHours_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "getFragmentInHours", "(Ljava/util/Date;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (fragment);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFragmentInHours_Ljava_util_Date_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFragmentInMilliseconds_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='getFragmentInMilliseconds' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register ("getFragmentInMilliseconds", "(Ljava/util/Calendar;I)J", "")]
		public static unsafe long GetFragmentInMilliseconds (global::Java.Util.Calendar calendar, int fragment)
		{
			if (id_getFragmentInMilliseconds_Ljava_util_Calendar_I == IntPtr.Zero)
				id_getFragmentInMilliseconds_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "getFragmentInMilliseconds", "(Ljava/util/Calendar;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (fragment);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFragmentInMilliseconds_Ljava_util_Calendar_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFragmentInMilliseconds_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='getFragmentInMilliseconds' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("getFragmentInMilliseconds", "(Ljava/util/Date;I)J", "")]
		public static unsafe long GetFragmentInMilliseconds (global::Java.Util.Date date, int fragment)
		{
			if (id_getFragmentInMilliseconds_Ljava_util_Date_I == IntPtr.Zero)
				id_getFragmentInMilliseconds_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "getFragmentInMilliseconds", "(Ljava/util/Date;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (fragment);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFragmentInMilliseconds_Ljava_util_Date_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFragmentInMinutes_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='getFragmentInMinutes' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register ("getFragmentInMinutes", "(Ljava/util/Calendar;I)J", "")]
		public static unsafe long GetFragmentInMinutes (global::Java.Util.Calendar calendar, int fragment)
		{
			if (id_getFragmentInMinutes_Ljava_util_Calendar_I == IntPtr.Zero)
				id_getFragmentInMinutes_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "getFragmentInMinutes", "(Ljava/util/Calendar;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (fragment);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFragmentInMinutes_Ljava_util_Calendar_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFragmentInMinutes_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='getFragmentInMinutes' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("getFragmentInMinutes", "(Ljava/util/Date;I)J", "")]
		public static unsafe long GetFragmentInMinutes (global::Java.Util.Date date, int fragment)
		{
			if (id_getFragmentInMinutes_Ljava_util_Date_I == IntPtr.Zero)
				id_getFragmentInMinutes_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "getFragmentInMinutes", "(Ljava/util/Date;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (fragment);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFragmentInMinutes_Ljava_util_Date_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFragmentInSeconds_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='getFragmentInSeconds' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register ("getFragmentInSeconds", "(Ljava/util/Calendar;I)J", "")]
		public static unsafe long GetFragmentInSeconds (global::Java.Util.Calendar calendar, int fragment)
		{
			if (id_getFragmentInSeconds_Ljava_util_Calendar_I == IntPtr.Zero)
				id_getFragmentInSeconds_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "getFragmentInSeconds", "(Ljava/util/Calendar;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (fragment);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFragmentInSeconds_Ljava_util_Calendar_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFragmentInSeconds_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='getFragmentInSeconds' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("getFragmentInSeconds", "(Ljava/util/Date;I)J", "")]
		public static unsafe long GetFragmentInSeconds (global::Java.Util.Date date, int fragment)
		{
			if (id_getFragmentInSeconds_Ljava_util_Date_I == IntPtr.Zero)
				id_getFragmentInSeconds_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "getFragmentInSeconds", "(Ljava/util/Date;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (fragment);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFragmentInSeconds_Ljava_util_Date_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isSameDay_Ljava_util_Calendar_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='isSameDay' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("isSameDay", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z", "")]
		public static unsafe bool IsSameDay (global::Java.Util.Calendar cal1, global::Java.Util.Calendar cal2)
		{
			if (id_isSameDay_Ljava_util_Calendar_Ljava_util_Calendar_ == IntPtr.Zero)
				id_isSameDay_Ljava_util_Calendar_Ljava_util_Calendar_ = JNIEnv.GetStaticMethodID (class_ref, "isSameDay", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cal1);
				__args [1] = new JValue (cal2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameDay_Ljava_util_Calendar_Ljava_util_Calendar_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isSameDay_Ljava_util_Date_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='isSameDay' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.util.Date']]"
		[Register ("isSameDay", "(Ljava/util/Date;Ljava/util/Date;)Z", "")]
		public static unsafe bool IsSameDay (global::Java.Util.Date date1, global::Java.Util.Date date2)
		{
			if (id_isSameDay_Ljava_util_Date_Ljava_util_Date_ == IntPtr.Zero)
				id_isSameDay_Ljava_util_Date_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "isSameDay", "(Ljava/util/Date;Ljava/util/Date;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date1);
				__args [1] = new JValue (date2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameDay_Ljava_util_Date_Ljava_util_Date_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isSameInstant_Ljava_util_Calendar_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='isSameInstant' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("isSameInstant", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z", "")]
		public static unsafe bool IsSameInstant (global::Java.Util.Calendar cal1, global::Java.Util.Calendar cal2)
		{
			if (id_isSameInstant_Ljava_util_Calendar_Ljava_util_Calendar_ == IntPtr.Zero)
				id_isSameInstant_Ljava_util_Calendar_Ljava_util_Calendar_ = JNIEnv.GetStaticMethodID (class_ref, "isSameInstant", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cal1);
				__args [1] = new JValue (cal2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameInstant_Ljava_util_Calendar_Ljava_util_Calendar_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isSameInstant_Ljava_util_Date_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='isSameInstant' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.util.Date']]"
		[Register ("isSameInstant", "(Ljava/util/Date;Ljava/util/Date;)Z", "")]
		public static unsafe bool IsSameInstant (global::Java.Util.Date date1, global::Java.Util.Date date2)
		{
			if (id_isSameInstant_Ljava_util_Date_Ljava_util_Date_ == IntPtr.Zero)
				id_isSameInstant_Ljava_util_Date_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "isSameInstant", "(Ljava/util/Date;Ljava/util/Date;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date1);
				__args [1] = new JValue (date2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameInstant_Ljava_util_Date_Ljava_util_Date_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isSameLocalTime_Ljava_util_Calendar_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='isSameLocalTime' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("isSameLocalTime", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z", "")]
		public static unsafe bool IsSameLocalTime (global::Java.Util.Calendar cal1, global::Java.Util.Calendar cal2)
		{
			if (id_isSameLocalTime_Ljava_util_Calendar_Ljava_util_Calendar_ == IntPtr.Zero)
				id_isSameLocalTime_Ljava_util_Calendar_Ljava_util_Calendar_ = JNIEnv.GetStaticMethodID (class_ref, "isSameLocalTime", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cal1);
				__args [1] = new JValue (cal2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameLocalTime_Ljava_util_Calendar_Ljava_util_Calendar_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_iterator_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='iterator' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("iterator", "(Ljava/lang/Object;I)Ljava/util/Iterator;", "")]
		public static unsafe global::Java.Util.IIterator Iterator (global::Java.Lang.Object focus, int rangeStyle)
		{
			if (id_iterator_Ljava_lang_Object_I == IntPtr.Zero)
				id_iterator_Ljava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "iterator", "(Ljava/lang/Object;I)Ljava/util/Iterator;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (focus);
				__args [1] = new JValue (rangeStyle);
				global::Java.Util.IIterator __ret = global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_iterator_Ljava_lang_Object_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_iterator_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='iterator' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register ("iterator", "(Ljava/util/Calendar;I)Ljava/util/Iterator;", "")]
		public static unsafe global::Java.Util.IIterator Iterator (global::Java.Util.Calendar focus, int rangeStyle)
		{
			if (id_iterator_Ljava_util_Calendar_I == IntPtr.Zero)
				id_iterator_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "iterator", "(Ljava/util/Calendar;I)Ljava/util/Iterator;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (focus);
				__args [1] = new JValue (rangeStyle);
				global::Java.Util.IIterator __ret = global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_iterator_Ljava_util_Calendar_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_iterator_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='iterator' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("iterator", "(Ljava/util/Date;I)Ljava/util/Iterator;", "")]
		public static unsafe global::Java.Util.IIterator Iterator (global::Java.Util.Date focus, int rangeStyle)
		{
			if (id_iterator_Ljava_util_Date_I == IntPtr.Zero)
				id_iterator_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "iterator", "(Ljava/util/Date;I)Ljava/util/Iterator;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (focus);
				__args [1] = new JValue (rangeStyle);
				global::Java.Util.IIterator __ret = global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_iterator_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseDate_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='parseDate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register ("parseDate", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date ParseDate (string str, params string[] parsePatterns)
		{
			if (id_parseDate_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_parseDate_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseDate", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/Date;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_parsePatterns = JNIEnv.NewArray (parsePatterns);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_parsePatterns);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDate_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (parsePatterns != null) {
					JNIEnv.CopyArray (native_parsePatterns, parsePatterns);
					JNIEnv.DeleteLocalRef (native_parsePatterns);
				}
			}
		}

		static IntPtr id_parseDate_Ljava_lang_String_Ljava_util_Locale_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='parseDate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Locale'] and parameter[3][@type='java.lang.String...']]"
		[Register ("parseDate", "(Ljava/lang/String;Ljava/util/Locale;[Ljava/lang/String;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date ParseDate (string str, global::Java.Util.Locale locale, params string[] parsePatterns)
		{
			if (id_parseDate_Ljava_lang_String_Ljava_util_Locale_arrayLjava_lang_String_ == IntPtr.Zero)
				id_parseDate_Ljava_lang_String_Ljava_util_Locale_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseDate", "(Ljava/lang/String;Ljava/util/Locale;[Ljava/lang/String;)Ljava/util/Date;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_parsePatterns = JNIEnv.NewArray (parsePatterns);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (locale);
				__args [2] = new JValue (native_parsePatterns);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDate_Ljava_lang_String_Ljava_util_Locale_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (parsePatterns != null) {
					JNIEnv.CopyArray (native_parsePatterns, parsePatterns);
					JNIEnv.DeleteLocalRef (native_parsePatterns);
				}
			}
		}

		static IntPtr id_parseDateStrictly_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='parseDateStrictly' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register ("parseDateStrictly", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date ParseDateStrictly (string str, params string[] parsePatterns)
		{
			if (id_parseDateStrictly_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_parseDateStrictly_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseDateStrictly", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/Date;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_parsePatterns = JNIEnv.NewArray (parsePatterns);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_parsePatterns);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDateStrictly_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (parsePatterns != null) {
					JNIEnv.CopyArray (native_parsePatterns, parsePatterns);
					JNIEnv.DeleteLocalRef (native_parsePatterns);
				}
			}
		}

		static IntPtr id_parseDateStrictly_Ljava_lang_String_Ljava_util_Locale_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='parseDateStrictly' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Locale'] and parameter[3][@type='java.lang.String...']]"
		[Register ("parseDateStrictly", "(Ljava/lang/String;Ljava/util/Locale;[Ljava/lang/String;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date ParseDateStrictly (string str, global::Java.Util.Locale locale, params string[] parsePatterns)
		{
			if (id_parseDateStrictly_Ljava_lang_String_Ljava_util_Locale_arrayLjava_lang_String_ == IntPtr.Zero)
				id_parseDateStrictly_Ljava_lang_String_Ljava_util_Locale_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseDateStrictly", "(Ljava/lang/String;Ljava/util/Locale;[Ljava/lang/String;)Ljava/util/Date;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_parsePatterns = JNIEnv.NewArray (parsePatterns);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (locale);
				__args [2] = new JValue (native_parsePatterns);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDateStrictly_Ljava_lang_String_Ljava_util_Locale_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (parsePatterns != null) {
					JNIEnv.CopyArray (native_parsePatterns, parsePatterns);
					JNIEnv.DeleteLocalRef (native_parsePatterns);
				}
			}
		}

		static IntPtr id_round_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='round' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("round", "(Ljava/lang/Object;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Round (global::Java.Lang.Object date, int field)
		{
			if (id_round_Ljava_lang_Object_I == IntPtr.Zero)
				id_round_Ljava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "round", "(Ljava/lang/Object;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (field);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_round_Ljava_lang_Object_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_round_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='round' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register ("round", "(Ljava/util/Calendar;I)Ljava/util/Calendar;", "")]
		public static unsafe global::Java.Util.Calendar Round (global::Java.Util.Calendar date, int field)
		{
			if (id_round_Ljava_util_Calendar_I == IntPtr.Zero)
				id_round_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "round", "(Ljava/util/Calendar;I)Ljava/util/Calendar;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (field);
				global::Java.Util.Calendar __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_round_Ljava_util_Calendar_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_round_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='round' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("round", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Round (global::Java.Util.Date date, int field)
		{
			if (id_round_Ljava_util_Date_I == IntPtr.Zero)
				id_round_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "round", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (field);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_round_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setDays_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='setDays' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("setDays", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date SetDays (global::Java.Util.Date date, int amount)
		{
			if (id_setDays_Ljava_util_Date_I == IntPtr.Zero)
				id_setDays_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "setDays", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_setDays_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setHours_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='setHours' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("setHours", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date SetHours (global::Java.Util.Date date, int amount)
		{
			if (id_setHours_Ljava_util_Date_I == IntPtr.Zero)
				id_setHours_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "setHours", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_setHours_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setMilliseconds_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='setMilliseconds' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("setMilliseconds", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date SetMilliseconds (global::Java.Util.Date date, int amount)
		{
			if (id_setMilliseconds_Ljava_util_Date_I == IntPtr.Zero)
				id_setMilliseconds_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "setMilliseconds", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_setMilliseconds_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setMinutes_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='setMinutes' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("setMinutes", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date SetMinutes (global::Java.Util.Date date, int amount)
		{
			if (id_setMinutes_Ljava_util_Date_I == IntPtr.Zero)
				id_setMinutes_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "setMinutes", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_setMinutes_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setMonths_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='setMonths' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("setMonths", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date SetMonths (global::Java.Util.Date date, int amount)
		{
			if (id_setMonths_Ljava_util_Date_I == IntPtr.Zero)
				id_setMonths_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "setMonths", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_setMonths_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setSeconds_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='setSeconds' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("setSeconds", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date SetSeconds (global::Java.Util.Date date, int amount)
		{
			if (id_setSeconds_Ljava_util_Date_I == IntPtr.Zero)
				id_setSeconds_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "setSeconds", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_setSeconds_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setYears_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='setYears' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("setYears", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date SetYears (global::Java.Util.Date date, int amount)
		{
			if (id_setYears_Ljava_util_Date_I == IntPtr.Zero)
				id_setYears_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "setYears", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (amount);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_setYears_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toCalendar_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='toCalendar' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("toCalendar", "(Ljava/util/Date;)Ljava/util/Calendar;", "")]
		public static unsafe global::Java.Util.Calendar ToCalendar (global::Java.Util.Date date)
		{
			if (id_toCalendar_Ljava_util_Date_ == IntPtr.Zero)
				id_toCalendar_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "toCalendar", "(Ljava/util/Date;)Ljava/util/Calendar;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);
				global::Java.Util.Calendar __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toCalendar_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toCalendar_Ljava_util_Date_Ljava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='toCalendar' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.util.TimeZone']]"
		[Register ("toCalendar", "(Ljava/util/Date;Ljava/util/TimeZone;)Ljava/util/Calendar;", "")]
		public static unsafe global::Java.Util.Calendar ToCalendar (global::Java.Util.Date date, global::Java.Util.TimeZone tz)
		{
			if (id_toCalendar_Ljava_util_Date_Ljava_util_TimeZone_ == IntPtr.Zero)
				id_toCalendar_Ljava_util_Date_Ljava_util_TimeZone_ = JNIEnv.GetStaticMethodID (class_ref, "toCalendar", "(Ljava/util/Date;Ljava/util/TimeZone;)Ljava/util/Calendar;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (tz);
				global::Java.Util.Calendar __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toCalendar_Ljava_util_Date_Ljava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_truncate_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='truncate' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("truncate", "(Ljava/lang/Object;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Truncate (global::Java.Lang.Object date, int field)
		{
			if (id_truncate_Ljava_lang_Object_I == IntPtr.Zero)
				id_truncate_Ljava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "truncate", "(Ljava/lang/Object;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (field);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_truncate_Ljava_lang_Object_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_truncate_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='truncate' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register ("truncate", "(Ljava/util/Calendar;I)Ljava/util/Calendar;", "")]
		public static unsafe global::Java.Util.Calendar Truncate (global::Java.Util.Calendar date, int field)
		{
			if (id_truncate_Ljava_util_Calendar_I == IntPtr.Zero)
				id_truncate_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "truncate", "(Ljava/util/Calendar;I)Ljava/util/Calendar;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (field);
				global::Java.Util.Calendar __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_truncate_Ljava_util_Calendar_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_truncate_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='truncate' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='int']]"
		[Register ("truncate", "(Ljava/util/Date;I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Truncate (global::Java.Util.Date date, int field)
		{
			if (id_truncate_Ljava_util_Date_I == IntPtr.Zero)
				id_truncate_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "truncate", "(Ljava/util/Date;I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (field);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_truncate_Ljava_util_Date_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_truncatedCompareTo_Ljava_util_Calendar_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='truncatedCompareTo' and count(parameter)=3 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar'] and parameter[3][@type='int']]"
		[Register ("truncatedCompareTo", "(Ljava/util/Calendar;Ljava/util/Calendar;I)I", "")]
		public static unsafe int TruncatedCompareTo (global::Java.Util.Calendar cal1, global::Java.Util.Calendar cal2, int field)
		{
			if (id_truncatedCompareTo_Ljava_util_Calendar_Ljava_util_Calendar_I == IntPtr.Zero)
				id_truncatedCompareTo_Ljava_util_Calendar_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "truncatedCompareTo", "(Ljava/util/Calendar;Ljava/util/Calendar;I)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cal1);
				__args [1] = new JValue (cal2);
				__args [2] = new JValue (field);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_truncatedCompareTo_Ljava_util_Calendar_Ljava_util_Calendar_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_truncatedCompareTo_Ljava_util_Date_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='truncatedCompareTo' and count(parameter)=3 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='int']]"
		[Register ("truncatedCompareTo", "(Ljava/util/Date;Ljava/util/Date;I)I", "")]
		public static unsafe int TruncatedCompareTo (global::Java.Util.Date date1, global::Java.Util.Date date2, int field)
		{
			if (id_truncatedCompareTo_Ljava_util_Date_Ljava_util_Date_I == IntPtr.Zero)
				id_truncatedCompareTo_Ljava_util_Date_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "truncatedCompareTo", "(Ljava/util/Date;Ljava/util/Date;I)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (date1);
				__args [1] = new JValue (date2);
				__args [2] = new JValue (field);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_truncatedCompareTo_Ljava_util_Date_Ljava_util_Date_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_truncatedEquals_Ljava_util_Calendar_Ljava_util_Calendar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='truncatedEquals' and count(parameter)=3 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar'] and parameter[3][@type='int']]"
		[Register ("truncatedEquals", "(Ljava/util/Calendar;Ljava/util/Calendar;I)Z", "")]
		public static unsafe bool TruncatedEquals (global::Java.Util.Calendar cal1, global::Java.Util.Calendar cal2, int field)
		{
			if (id_truncatedEquals_Ljava_util_Calendar_Ljava_util_Calendar_I == IntPtr.Zero)
				id_truncatedEquals_Ljava_util_Calendar_Ljava_util_Calendar_I = JNIEnv.GetStaticMethodID (class_ref, "truncatedEquals", "(Ljava/util/Calendar;Ljava/util/Calendar;I)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cal1);
				__args [1] = new JValue (cal2);
				__args [2] = new JValue (field);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_truncatedEquals_Ljava_util_Calendar_Ljava_util_Calendar_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_truncatedEquals_Ljava_util_Date_Ljava_util_Date_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DateUtils']/method[@name='truncatedEquals' and count(parameter)=3 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='int']]"
		[Register ("truncatedEquals", "(Ljava/util/Date;Ljava/util/Date;I)Z", "")]
		public static unsafe bool TruncatedEquals (global::Java.Util.Date date1, global::Java.Util.Date date2, int field)
		{
			if (id_truncatedEquals_Ljava_util_Date_Ljava_util_Date_I == IntPtr.Zero)
				id_truncatedEquals_Ljava_util_Date_Ljava_util_Date_I = JNIEnv.GetStaticMethodID (class_ref, "truncatedEquals", "(Ljava/util/Date;Ljava/util/Date;I)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (date1);
				__args [1] = new JValue (date2);
				__args [2] = new JValue (field);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_truncatedEquals_Ljava_util_Date_Ljava_util_Date_I, __args);
				return __ret;
			} finally {
			}
		}

	}
}
