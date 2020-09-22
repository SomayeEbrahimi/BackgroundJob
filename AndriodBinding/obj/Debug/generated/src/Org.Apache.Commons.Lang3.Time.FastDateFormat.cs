using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Time {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/time/FastDateFormat", DoNotGenerateAcw=true)]
	public partial class FastDateFormat : global::Java.Text._Format, global::Org.Apache.Commons.Lang3.Time.IDateParser, global::Org.Apache.Commons.Lang3.Time.IDatePrinter {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/field[@name='FULL']"
		[Register ("FULL")]
		public const int Full = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/field[@name='LONG']"
		[Register ("LONG")]
		public const int Long = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/field[@name='MEDIUM']"
		[Register ("MEDIUM")]
		public const int Medium = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/field[@name='SHORT']"
		[Register ("SHORT")]
		public const int Short = (int) 3;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/time/FastDateFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FastDateFormat); }
		}

		protected FastDateFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/constructor[@name='FastDateFormat' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.TimeZone'] and parameter[3][@type='java.util.Locale']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)V", "")]
		protected unsafe FastDateFormat (string pattern, global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_pattern);
				__args [1] = new JValue (timeZone);
				__args [2] = new JValue (locale);
				if (((object) this).GetType () != typeof (FastDateFormat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_Ljava_util_Date_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/constructor[@name='FastDateFormat' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.TimeZone'] and parameter[3][@type='java.util.Locale'] and parameter[4][@type='java.util.Date']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;Ljava/util/Date;)V", "")]
		protected unsafe FastDateFormat (string pattern, global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale, global::Java.Util.Date centuryStart)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_pattern);
				__args [1] = new JValue (timeZone);
				__args [2] = new JValue (locale);
				__args [3] = new JValue (centuryStart);
				if (((object) this).GetType () != typeof (FastDateFormat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;Ljava/util/Date;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;Ljava/util/Date;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_Ljava_util_Date_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;Ljava/util/Date;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_Ljava_util_Date_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_Ljava_util_Date_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lorg/apache/commons/lang3/time/FastDateFormat;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocale;
#pragma warning disable 0169
		static Delegate GetGetLocaleHandler ()
		{
			if (cb_getLocale == null)
				cb_getLocale = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocale);
			return cb_getLocale;
		}

		static IntPtr n_GetLocale (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Locale);
		}
#pragma warning restore 0169

		static IntPtr id_getLocale;
		public virtual unsafe global::Java.Util.Locale Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/util/Locale;", "GetGetLocaleHandler")]
			get {
				if (id_getLocale == IntPtr.Zero)
					id_getLocale = JNIEnv.GetMethodID (class_ref, "getLocale", "()Ljava/util/Locale;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocale), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocale", "()Ljava/util/Locale;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxLengthEstimate;
#pragma warning disable 0169
		static Delegate GetGetMaxLengthEstimateHandler ()
		{
			if (cb_getMaxLengthEstimate == null)
				cb_getMaxLengthEstimate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxLengthEstimate);
			return cb_getMaxLengthEstimate;
		}

		static int n_GetMaxLengthEstimate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxLengthEstimate;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxLengthEstimate;
		public virtual unsafe int MaxLengthEstimate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getMaxLengthEstimate' and count(parameter)=0]"
			[Register ("getMaxLengthEstimate", "()I", "GetGetMaxLengthEstimateHandler")]
			get {
				if (id_getMaxLengthEstimate == IntPtr.Zero)
					id_getMaxLengthEstimate = JNIEnv.GetMethodID (class_ref, "getMaxLengthEstimate", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxLengthEstimate);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxLengthEstimate", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPattern;
#pragma warning disable 0169
		static Delegate GetGetPatternHandler ()
		{
			if (cb_getPattern == null)
				cb_getPattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPattern);
			return cb_getPattern;
		}

		static IntPtr n_GetPattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pattern);
		}
#pragma warning restore 0169

		static IntPtr id_getPattern;
		public virtual unsafe string Pattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getPattern' and count(parameter)=0]"
			[Register ("getPattern", "()Ljava/lang/String;", "GetGetPatternHandler")]
			get {
				if (id_getPattern == IntPtr.Zero)
					id_getPattern = JNIEnv.GetMethodID (class_ref, "getPattern", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPattern), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPattern", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeZone;
#pragma warning disable 0169
		static Delegate GetGetTimeZoneHandler ()
		{
			if (cb_getTimeZone == null)
				cb_getTimeZone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTimeZone);
			return cb_getTimeZone;
		}

		static IntPtr n_GetTimeZone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeZone);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeZone;
		public virtual unsafe global::Java.Util.TimeZone TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()Ljava/util/TimeZone;", "GetGetTimeZoneHandler")]
			get {
				if (id_getTimeZone == IntPtr.Zero)
					id_getTimeZone = JNIEnv.GetMethodID (class_ref, "getTimeZone", "()Ljava/util/TimeZone;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeZone), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeZone", "()Ljava/util/TimeZone;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_applyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetApplyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_applyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_ == null)
				cb_applyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ApplyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_);
			return cb_applyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_;
		}

		[Obsolete]
		static IntPtr n_ApplyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar, IntPtr native_buf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplyRules (calendar, buf));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_applyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='applyRules' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.lang.StringBuffer']]"
		[Obsolete (@"deprecated")]
		[Register ("applyRules", "(Ljava/util/Calendar;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", "GetApplyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_Handler")]
		protected virtual unsafe global::Java.Lang.StringBuffer ApplyRules (global::Java.Util.Calendar calendar, global::Java.Lang.StringBuffer buf)
		{
			if (id_applyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_applyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "applyRules", "(Ljava/util/Calendar;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (buf);

				global::Java.Lang.StringBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_applyRules_Ljava_util_Calendar_Ljava_lang_StringBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyRules", "(Ljava/util/Calendar;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_Handler ()
		{
			if (cb_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_ == null)
				cb_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_);
			return cb_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_;
		}

		static IntPtr n_Format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, IntPtr native_toAppendTo, IntPtr native_pos)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			var toAppendTo = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_toAppendTo, JniHandleOwnership.DoNotTransfer);
			var pos = global::Java.Lang.Object.GetObject<global::Java.Text.FieldPosition> (native_pos, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (obj, toAppendTo, pos));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.StringBuffer'] and parameter[3][@type='java.text.FieldPosition']]"
		[Register ("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", "GetFormat_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_Handler")]
		public override unsafe global::Java.Lang.StringBuffer Format (global::Java.Lang.Object obj, global::Java.Lang.StringBuffer toAppendTo, global::Java.Text.FieldPosition pos)
		{
			if (id_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_ == IntPtr.Zero)
				id_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (toAppendTo);
				__args [2] = new JValue (pos);

				global::Java.Lang.StringBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_format_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_Calendar_Handler ()
		{
			if (cb_format_Ljava_util_Calendar_ == null)
				cb_format_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Format_Ljava_util_Calendar_);
			return cb_format_Ljava_util_Calendar_;
		}

		static IntPtr n_Format_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (calendar));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("format", "(Ljava/util/Calendar;)Ljava/lang/String;", "GetFormat_Ljava_util_Calendar_Handler")]
		public virtual unsafe string Format (global::Java.Util.Calendar calendar)
		{
			if (id_format_Ljava_util_Calendar_ == IntPtr.Zero)
				id_format_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Calendar;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/util/Calendar;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_format_Ljava_util_Calendar_Ljava_lang_Appendable_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_Calendar_Ljava_lang_Appendable_Handler ()
		{
			if (cb_format_Ljava_util_Calendar_Ljava_lang_Appendable_ == null)
				cb_format_Ljava_util_Calendar_Ljava_lang_Appendable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Format_Ljava_util_Calendar_Ljava_lang_Appendable_);
			return cb_format_Ljava_util_Calendar_Ljava_lang_Appendable_;
		}

		static IntPtr n_Format_Ljava_util_Calendar_Ljava_lang_Appendable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar, IntPtr native_buf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (calendar, buf));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_util_Calendar_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='B']]"
		[Register ("format", "(Ljava/util/Calendar;Ljava/lang/Appendable;)Ljava/lang/Appendable;", "GetFormat_Ljava_util_Calendar_Ljava_lang_Appendable_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B extends java.lang.Appendable"})]
		public virtual unsafe global::Java.Lang.Object Format (global::Java.Util.Calendar calendar, global::Java.Lang.Object buf)
		{
			if (id_format_Ljava_util_Calendar_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_format_Ljava_util_Calendar_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Calendar;Ljava/lang/Appendable;)Ljava/lang/Appendable;");
			IntPtr native_buf = JNIEnv.ToLocalJniHandle (buf);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (native_buf);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Calendar_Ljava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/util/Calendar;Ljava/lang/Appendable;)Ljava/lang/Appendable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_buf);
			}
		}

		static Delegate cb_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetFormat_Ljava_util_Calendar_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_ == null)
				cb_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Format_Ljava_util_Calendar_Ljava_lang_StringBuffer_);
			return cb_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_;
		}

		[Obsolete]
		static IntPtr n_Format_Ljava_util_Calendar_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar, IntPtr native_buf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (calendar, buf));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.lang.StringBuffer']]"
		[Obsolete (@"deprecated")]
		[Register ("format", "(Ljava/util/Calendar;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", "GetFormat_Ljava_util_Calendar_Ljava_lang_StringBuffer_Handler")]
		public virtual unsafe global::Java.Lang.StringBuffer Format (global::Java.Util.Calendar calendar, global::Java.Lang.StringBuffer buf)
		{
			if (id_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Calendar;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (calendar);
				__args [1] = new JValue (buf);

				global::Java.Lang.StringBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/util/Calendar;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_format_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_Date_Handler ()
		{
			if (cb_format_Ljava_util_Date_ == null)
				cb_format_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Format_Ljava_util_Date_);
			return cb_format_Ljava_util_Date_;
		}

		static IntPtr n_Format_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (date));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("format", "(Ljava/util/Date;)Ljava/lang/String;", "GetFormat_Ljava_util_Date_Handler")]
		public virtual unsafe string Format (global::Java.Util.Date date)
		{
			if (id_format_Ljava_util_Date_ == IntPtr.Zero)
				id_format_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Date;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/util/Date;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_format_Ljava_util_Date_Ljava_lang_Appendable_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_Date_Ljava_lang_Appendable_Handler ()
		{
			if (cb_format_Ljava_util_Date_Ljava_lang_Appendable_ == null)
				cb_format_Ljava_util_Date_Ljava_lang_Appendable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Format_Ljava_util_Date_Ljava_lang_Appendable_);
			return cb_format_Ljava_util_Date_Ljava_lang_Appendable_;
		}

		static IntPtr n_Format_Ljava_util_Date_Ljava_lang_Appendable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date, IntPtr native_buf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (date, buf));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_util_Date_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='B']]"
		[Register ("format", "(Ljava/util/Date;Ljava/lang/Appendable;)Ljava/lang/Appendable;", "GetFormat_Ljava_util_Date_Ljava_lang_Appendable_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B extends java.lang.Appendable"})]
		public virtual unsafe global::Java.Lang.Object Format (global::Java.Util.Date date, global::Java.Lang.Object buf)
		{
			if (id_format_Ljava_util_Date_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_format_Ljava_util_Date_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Date;Ljava/lang/Appendable;)Ljava/lang/Appendable;");
			IntPtr native_buf = JNIEnv.ToLocalJniHandle (buf);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (native_buf);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Date_Ljava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/util/Date;Ljava/lang/Appendable;)Ljava/lang/Appendable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_buf);
			}
		}

		static Delegate cb_format_Ljava_util_Date_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetFormat_Ljava_util_Date_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_format_Ljava_util_Date_Ljava_lang_StringBuffer_ == null)
				cb_format_Ljava_util_Date_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Format_Ljava_util_Date_Ljava_lang_StringBuffer_);
			return cb_format_Ljava_util_Date_Ljava_lang_StringBuffer_;
		}

		[Obsolete]
		static IntPtr n_Format_Ljava_util_Date_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date, IntPtr native_buf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (date, buf));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_util_Date_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.StringBuffer']]"
		[Obsolete (@"deprecated")]
		[Register ("format", "(Ljava/util/Date;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", "GetFormat_Ljava_util_Date_Ljava_lang_StringBuffer_Handler")]
		public virtual unsafe global::Java.Lang.StringBuffer Format (global::Java.Util.Date date, global::Java.Lang.StringBuffer buf)
		{
			if (id_format_Ljava_util_Date_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_format_Ljava_util_Date_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (buf);

				global::Java.Lang.StringBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Date_Ljava_lang_StringBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_format_J;
#pragma warning disable 0169
		static Delegate GetFormat_JHandler ()
		{
			if (cb_format_J == null)
				cb_format_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_Format_J);
			return cb_format_J;
		}

		static IntPtr n_Format_J (IntPtr jnienv, IntPtr native__this, long millis)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Format (millis));
		}
#pragma warning restore 0169

		static IntPtr id_format_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='format' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("format", "(J)Ljava/lang/String;", "GetFormat_JHandler")]
		public virtual unsafe string Format (long millis)
		{
			if (id_format_J == IntPtr.Zero)
				id_format_J = JNIEnv.GetMethodID (class_ref, "format", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (millis);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(J)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_format_JLjava_lang_Appendable_;
#pragma warning disable 0169
		static Delegate GetFormat_JLjava_lang_Appendable_Handler ()
		{
			if (cb_format_JLjava_lang_Appendable_ == null)
				cb_format_JLjava_lang_Appendable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_Format_JLjava_lang_Appendable_);
			return cb_format_JLjava_lang_Appendable_;
		}

		static IntPtr n_Format_JLjava_lang_Appendable_ (IntPtr jnienv, IntPtr native__this, long millis, IntPtr native_buf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (millis, buf));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_JLjava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='format' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='B']]"
		[Register ("format", "(JLjava/lang/Appendable;)Ljava/lang/Appendable;", "GetFormat_JLjava_lang_Appendable_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B extends java.lang.Appendable"})]
		public virtual unsafe global::Java.Lang.Object Format (long millis, global::Java.Lang.Object buf)
		{
			if (id_format_JLjava_lang_Appendable_ == IntPtr.Zero)
				id_format_JLjava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "format", "(JLjava/lang/Appendable;)Ljava/lang/Appendable;");
			IntPtr native_buf = JNIEnv.ToLocalJniHandle (buf);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (millis);
				__args [1] = new JValue (native_buf);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_JLjava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(JLjava/lang/Appendable;)Ljava/lang/Appendable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_buf);
			}
		}

		static Delegate cb_format_JLjava_lang_StringBuffer_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetFormat_JLjava_lang_StringBuffer_Handler ()
		{
			if (cb_format_JLjava_lang_StringBuffer_ == null)
				cb_format_JLjava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_Format_JLjava_lang_StringBuffer_);
			return cb_format_JLjava_lang_StringBuffer_;
		}

		[Obsolete]
		static IntPtr n_Format_JLjava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, long millis, IntPtr native_buf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (millis, buf));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_JLjava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='format' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.StringBuffer']]"
		[Obsolete (@"deprecated")]
		[Register ("format", "(JLjava/lang/StringBuffer;)Ljava/lang/StringBuffer;", "GetFormat_JLjava_lang_StringBuffer_Handler")]
		public virtual unsafe global::Java.Lang.StringBuffer Format (long millis, global::Java.Lang.StringBuffer buf)
		{
			if (id_format_JLjava_lang_StringBuffer_ == IntPtr.Zero)
				id_format_JLjava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "format", "(JLjava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (millis);
				__args [1] = new JValue (buf);

				global::Java.Lang.StringBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_JLjava_lang_StringBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(JLjava/lang/StringBuffer;)Ljava/lang/StringBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDateInstance_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getDateInstance' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDateInstance", "(I)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetDateInstance (int style)
		{
			if (id_getDateInstance_I == IntPtr.Zero)
				id_getDateInstance_I = JNIEnv.GetStaticMethodID (class_ref, "getDateInstance", "(I)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (style);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateInstance_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getDateInstance_ILjava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getDateInstance' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Locale']]"
		[Register ("getDateInstance", "(ILjava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetDateInstance (int style, global::Java.Util.Locale locale)
		{
			if (id_getDateInstance_ILjava_util_Locale_ == IntPtr.Zero)
				id_getDateInstance_ILjava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "getDateInstance", "(ILjava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (style);
				__args [1] = new JValue (locale);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateInstance_ILjava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDateInstance_ILjava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getDateInstance' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.TimeZone']]"
		[Register ("getDateInstance", "(ILjava/util/TimeZone;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetDateInstance (int style, global::Java.Util.TimeZone timeZone)
		{
			if (id_getDateInstance_ILjava_util_TimeZone_ == IntPtr.Zero)
				id_getDateInstance_ILjava_util_TimeZone_ = JNIEnv.GetStaticMethodID (class_ref, "getDateInstance", "(ILjava/util/TimeZone;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (style);
				__args [1] = new JValue (timeZone);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateInstance_ILjava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDateInstance_ILjava_util_TimeZone_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getDateInstance' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.TimeZone'] and parameter[3][@type='java.util.Locale']]"
		[Register ("getDateInstance", "(ILjava/util/TimeZone;Ljava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetDateInstance (int style, global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale)
		{
			if (id_getDateInstance_ILjava_util_TimeZone_Ljava_util_Locale_ == IntPtr.Zero)
				id_getDateInstance_ILjava_util_TimeZone_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "getDateInstance", "(ILjava/util/TimeZone;Ljava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (style);
				__args [1] = new JValue (timeZone);
				__args [2] = new JValue (locale);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateInstance_ILjava_util_TimeZone_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDateTimeInstance_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getDateTimeInstance' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDateTimeInstance", "(II)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetDateTimeInstance (int dateStyle, int timeStyle)
		{
			if (id_getDateTimeInstance_II == IntPtr.Zero)
				id_getDateTimeInstance_II = JNIEnv.GetStaticMethodID (class_ref, "getDateTimeInstance", "(II)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dateStyle);
				__args [1] = new JValue (timeStyle);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateTimeInstance_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getDateTimeInstance_IILjava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getDateTimeInstance' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Locale']]"
		[Register ("getDateTimeInstance", "(IILjava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetDateTimeInstance (int dateStyle, int timeStyle, global::Java.Util.Locale locale)
		{
			if (id_getDateTimeInstance_IILjava_util_Locale_ == IntPtr.Zero)
				id_getDateTimeInstance_IILjava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "getDateTimeInstance", "(IILjava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (dateStyle);
				__args [1] = new JValue (timeStyle);
				__args [2] = new JValue (locale);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateTimeInstance_IILjava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDateTimeInstance_IILjava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getDateTimeInstance' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.TimeZone']]"
		[Register ("getDateTimeInstance", "(IILjava/util/TimeZone;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetDateTimeInstance (int dateStyle, int timeStyle, global::Java.Util.TimeZone timeZone)
		{
			if (id_getDateTimeInstance_IILjava_util_TimeZone_ == IntPtr.Zero)
				id_getDateTimeInstance_IILjava_util_TimeZone_ = JNIEnv.GetStaticMethodID (class_ref, "getDateTimeInstance", "(IILjava/util/TimeZone;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (dateStyle);
				__args [1] = new JValue (timeStyle);
				__args [2] = new JValue (timeZone);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateTimeInstance_IILjava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDateTimeInstance_IILjava_util_TimeZone_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getDateTimeInstance' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.TimeZone'] and parameter[4][@type='java.util.Locale']]"
		[Register ("getDateTimeInstance", "(IILjava/util/TimeZone;Ljava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetDateTimeInstance (int dateStyle, int timeStyle, global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale)
		{
			if (id_getDateTimeInstance_IILjava_util_TimeZone_Ljava_util_Locale_ == IntPtr.Zero)
				id_getDateTimeInstance_IILjava_util_TimeZone_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "getDateTimeInstance", "(IILjava/util/TimeZone;Ljava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (dateStyle);
				__args [1] = new JValue (timeStyle);
				__args [2] = new JValue (timeZone);
				__args [3] = new JValue (locale);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateTimeInstance_IILjava_util_TimeZone_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInstance", "(Ljava/lang/String;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetInstance (string pattern)
		{
			if (id_getInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Ljava/lang/String;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pattern);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_getInstance_Ljava_lang_String_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Locale']]"
		[Register ("getInstance", "(Ljava/lang/String;Ljava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetInstance (string pattern, global::Java.Util.Locale locale)
		{
			if (id_getInstance_Ljava_lang_String_Ljava_util_Locale_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_String_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Ljava/lang/String;Ljava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_pattern);
				__args [1] = new JValue (locale);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Ljava_lang_String_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_getInstance_Ljava_lang_String_Ljava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.TimeZone']]"
		[Register ("getInstance", "(Ljava/lang/String;Ljava/util/TimeZone;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetInstance (string pattern, global::Java.Util.TimeZone timeZone)
		{
			if (id_getInstance_Ljava_lang_String_Ljava_util_TimeZone_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_String_Ljava_util_TimeZone_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Ljava/lang/String;Ljava/util/TimeZone;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_pattern);
				__args [1] = new JValue (timeZone);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Ljava_lang_String_Ljava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_getInstance_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getInstance' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.TimeZone'] and parameter[3][@type='java.util.Locale']]"
		[Register ("getInstance", "(Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetInstance (string pattern, global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale)
		{
			if (id_getInstance_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Ljava/lang/String;Ljava/util/TimeZone;Ljava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_pattern);
				__args [1] = new JValue (timeZone);
				__args [2] = new JValue (locale);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Ljava_lang_String_Ljava_util_TimeZone_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_getTimeInstance_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getTimeInstance' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTimeInstance", "(I)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetTimeInstance (int style)
		{
			if (id_getTimeInstance_I == IntPtr.Zero)
				id_getTimeInstance_I = JNIEnv.GetStaticMethodID (class_ref, "getTimeInstance", "(I)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (style);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeInstance_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getTimeInstance_ILjava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getTimeInstance' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Locale']]"
		[Register ("getTimeInstance", "(ILjava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetTimeInstance (int style, global::Java.Util.Locale locale)
		{
			if (id_getTimeInstance_ILjava_util_Locale_ == IntPtr.Zero)
				id_getTimeInstance_ILjava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeInstance", "(ILjava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (style);
				__args [1] = new JValue (locale);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeInstance_ILjava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTimeInstance_ILjava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getTimeInstance' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.TimeZone']]"
		[Register ("getTimeInstance", "(ILjava/util/TimeZone;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetTimeInstance (int style, global::Java.Util.TimeZone timeZone)
		{
			if (id_getTimeInstance_ILjava_util_TimeZone_ == IntPtr.Zero)
				id_getTimeInstance_ILjava_util_TimeZone_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeInstance", "(ILjava/util/TimeZone;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (style);
				__args [1] = new JValue (timeZone);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeInstance_ILjava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTimeInstance_ILjava_util_TimeZone_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='getTimeInstance' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.TimeZone'] and parameter[3][@type='java.util.Locale']]"
		[Register ("getTimeInstance", "(ILjava/util/TimeZone;Ljava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.FastDateFormat GetTimeInstance (int style, global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale)
		{
			if (id_getTimeInstance_ILjava_util_TimeZone_Ljava_util_Locale_ == IntPtr.Zero)
				id_getTimeInstance_ILjava_util_TimeZone_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeInstance", "(ILjava/util/TimeZone;Ljava/util/Locale;)Lorg/apache/commons/lang3/time/FastDateFormat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (style);
				__args [1] = new JValue (timeZone);
				__args [2] = new JValue (locale);
				global::Org.Apache.Commons.Lang3.Time.FastDateFormat __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeInstance_ILjava_util_TimeZone_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_parse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Handler ()
		{
			if (cb_parse_Ljava_lang_String_ == null)
				cb_parse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Parse_Ljava_lang_String_);
			return cb_parse_Ljava_lang_String_;
		}

		static IntPtr n_Parse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (source));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Ljava/util/Date;", "GetParse_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Util.Date Parse (string source)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;)Ljava/util/Date;");
			IntPtr native_source = JNIEnv.NewString (source);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_source);

				global::Java.Util.Date __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Ljava/lang/String;)Ljava/util/Date;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

		static Delegate cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Ljava_text_ParsePosition_Handler ()
		{
			if (cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_ == null)
				cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Parse_Ljava_lang_String_Ljava_text_ParsePosition_);
			return cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_;
		}

		static IntPtr n_Parse_Ljava_lang_String_Ljava_text_ParsePosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_pos)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			var pos = global::Java.Lang.Object.GetObject<global::Java.Text.ParsePosition> (native_pos, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (source, pos));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parse_Ljava_lang_String_Ljava_text_ParsePosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.text.ParsePosition']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", "GetParse_Ljava_lang_String_Ljava_text_ParsePosition_Handler")]
		public virtual unsafe global::Java.Util.Date Parse (string source, global::Java.Text.ParsePosition pos)
		{
			if (id_parse_Ljava_lang_String_Ljava_text_ParsePosition_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_Ljava_text_ParsePosition_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
			IntPtr native_source = JNIEnv.NewString (source);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_source);
				__args [1] = new JValue (pos);

				global::Java.Util.Date __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_lang_String_Ljava_text_ParsePosition_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

		static Delegate cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_Handler ()
		{
			if (cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_ == null)
				cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_Parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_);
			return cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_;
		}

		static bool n_Parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_pos, IntPtr native_calendar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			var pos = global::Java.Lang.Object.GetObject<global::Java.Text.ParsePosition> (native_pos, JniHandleOwnership.DoNotTransfer);
			var calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Parse (source, pos, calendar);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.text.ParsePosition'] and parameter[3][@type='java.util.Calendar']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;Ljava/util/Calendar;)Z", "GetParse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_Handler")]
		public virtual unsafe bool Parse (string source, global::Java.Text.ParsePosition pos, global::Java.Util.Calendar calendar)
		{
			if (id_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;Ljava/util/Calendar;)Z");
			IntPtr native_source = JNIEnv.NewString (source);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_source);
				__args [1] = new JValue (pos);
				__args [2] = new JValue (calendar);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;Ljava/util/Calendar;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

		static Delegate cb_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_;
#pragma warning disable 0169
		static Delegate GetParseObject_Ljava_lang_String_Ljava_text_ParsePosition_Handler ()
		{
			if (cb_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_ == null)
				cb_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ParseObject_Ljava_lang_String_Ljava_text_ParsePosition_);
			return cb_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_;
		}

		static IntPtr n_ParseObject_Ljava_lang_String_Ljava_text_ParsePosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_pos)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.FastDateFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			var pos = global::Java.Lang.Object.GetObject<global::Java.Text.ParsePosition> (native_pos, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseObject (source, pos));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='FastDateFormat']/method[@name='parseObject' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.text.ParsePosition']]"
		[Register ("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", "GetParseObject_Ljava_lang_String_Ljava_text_ParsePosition_Handler")]
		public override unsafe global::Java.Lang.Object ParseObject (string source, global::Java.Text.ParsePosition pos)
		{
			if (id_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_ == IntPtr.Zero)
				id_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_ = JNIEnv.GetMethodID (class_ref, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			IntPtr native_source = JNIEnv.NewString (source);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_source);
				__args [1] = new JValue (pos);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

	}
}
