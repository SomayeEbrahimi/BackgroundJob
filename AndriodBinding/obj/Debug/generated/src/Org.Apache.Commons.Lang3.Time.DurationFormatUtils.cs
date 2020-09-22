using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Time {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/time/DurationFormatUtils", DoNotGenerateAcw=true)]
	public partial class DurationFormatUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']/field[@name='ISO_EXTENDED_FORMAT_PATTERN']"
		[Register ("ISO_EXTENDED_FORMAT_PATTERN")]
		public const string IsoExtendedFormatPattern = (string) "'P'yyyy'Y'M'M'd'DT'H'H'm'M's.SSS'S'";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/time/DurationFormatUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DurationFormatUtils); }
		}

		protected DurationFormatUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']/constructor[@name='DurationFormatUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DurationFormatUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DurationFormatUtils)) {
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

		static IntPtr id_formatDuration_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']/method[@name='formatDuration' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("formatDuration", "(JLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string FormatDuration (long durationMillis, string format)
		{
			if (id_formatDuration_JLjava_lang_String_ == IntPtr.Zero)
				id_formatDuration_JLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "formatDuration", "(JLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (durationMillis);
				__args [1] = new JValue (native_format);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatDuration_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

		static IntPtr id_formatDuration_JLjava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']/method[@name='formatDuration' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("formatDuration", "(JLjava/lang/String;Z)Ljava/lang/String;", "")]
		public static unsafe string FormatDuration (long durationMillis, string format, bool padWithZeros)
		{
			if (id_formatDuration_JLjava_lang_String_Z == IntPtr.Zero)
				id_formatDuration_JLjava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "formatDuration", "(JLjava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (durationMillis);
				__args [1] = new JValue (native_format);
				__args [2] = new JValue (padWithZeros);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatDuration_JLjava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

		static IntPtr id_formatDurationHMS_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']/method[@name='formatDurationHMS' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("formatDurationHMS", "(J)Ljava/lang/String;", "")]
		public static unsafe string FormatDurationHMS (long durationMillis)
		{
			if (id_formatDurationHMS_J == IntPtr.Zero)
				id_formatDurationHMS_J = JNIEnv.GetStaticMethodID (class_ref, "formatDurationHMS", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (durationMillis);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatDurationHMS_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_formatDurationISO_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']/method[@name='formatDurationISO' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("formatDurationISO", "(J)Ljava/lang/String;", "")]
		public static unsafe string FormatDurationISO (long durationMillis)
		{
			if (id_formatDurationISO_J == IntPtr.Zero)
				id_formatDurationISO_J = JNIEnv.GetStaticMethodID (class_ref, "formatDurationISO", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (durationMillis);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatDurationISO_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_formatDurationWords_JZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']/method[@name='formatDurationWords' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("formatDurationWords", "(JZZ)Ljava/lang/String;", "")]
		public static unsafe string FormatDurationWords (long durationMillis, bool suppressLeadingZeroElements, bool suppressTrailingZeroElements)
		{
			if (id_formatDurationWords_JZZ == IntPtr.Zero)
				id_formatDurationWords_JZZ = JNIEnv.GetStaticMethodID (class_ref, "formatDurationWords", "(JZZ)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (durationMillis);
				__args [1] = new JValue (suppressLeadingZeroElements);
				__args [2] = new JValue (suppressTrailingZeroElements);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatDurationWords_JZZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_formatPeriod_JJLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']/method[@name='formatPeriod' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
		[Register ("formatPeriod", "(JJLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string FormatPeriod (long startMillis, long endMillis, string format)
		{
			if (id_formatPeriod_JJLjava_lang_String_ == IntPtr.Zero)
				id_formatPeriod_JJLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "formatPeriod", "(JJLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (startMillis);
				__args [1] = new JValue (endMillis);
				__args [2] = new JValue (native_format);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatPeriod_JJLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

		static IntPtr id_formatPeriod_JJLjava_lang_String_ZLjava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']/method[@name='formatPeriod' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='java.util.TimeZone']]"
		[Register ("formatPeriod", "(JJLjava/lang/String;ZLjava/util/TimeZone;)Ljava/lang/String;", "")]
		public static unsafe string FormatPeriod (long startMillis, long endMillis, string format, bool padWithZeros, global::Java.Util.TimeZone timezone)
		{
			if (id_formatPeriod_JJLjava_lang_String_ZLjava_util_TimeZone_ == IntPtr.Zero)
				id_formatPeriod_JJLjava_lang_String_ZLjava_util_TimeZone_ = JNIEnv.GetStaticMethodID (class_ref, "formatPeriod", "(JJLjava/lang/String;ZLjava/util/TimeZone;)Ljava/lang/String;");
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (startMillis);
				__args [1] = new JValue (endMillis);
				__args [2] = new JValue (native_format);
				__args [3] = new JValue (padWithZeros);
				__args [4] = new JValue (timezone);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatPeriod_JJLjava_lang_String_ZLjava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

		static IntPtr id_formatPeriodISO_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='DurationFormatUtils']/method[@name='formatPeriodISO' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("formatPeriodISO", "(JJ)Ljava/lang/String;", "")]
		public static unsafe string FormatPeriodISO (long startMillis, long endMillis)
		{
			if (id_formatPeriodISO_JJ == IntPtr.Zero)
				id_formatPeriodISO_JJ = JNIEnv.GetStaticMethodID (class_ref, "formatPeriodISO", "(JJ)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startMillis);
				__args [1] = new JValue (endMillis);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatPeriodISO_JJ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
