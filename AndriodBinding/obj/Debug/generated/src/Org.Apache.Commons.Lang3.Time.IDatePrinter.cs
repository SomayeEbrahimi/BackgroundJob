using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Time {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']"
	[Register ("org/apache/commons/lang3/time/DatePrinter", "", "Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker")]
	public partial interface IDatePrinter : IJavaObject {

		global::Java.Util.Locale Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/util/Locale;", "GetGetLocaleHandler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")] get;
		}

		string Pattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='getPattern' and count(parameter)=0]"
			[Register ("getPattern", "()Ljava/lang/String;", "GetGetPatternHandler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")] get;
		}

		global::Java.Util.TimeZone TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()Ljava/util/TimeZone;", "GetGetTimeZoneHandler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.StringBuffer'] and parameter[3][@type='java.text.FieldPosition']]"
		[Register ("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", "GetFormat_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_Handler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")]
		global::Java.Lang.StringBuffer Format (global::Java.Lang.Object p0, global::Java.Lang.StringBuffer p1, global::Java.Text.FieldPosition p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("format", "(Ljava/util/Calendar;)Ljava/lang/String;", "GetFormat_Ljava_util_Calendar_Handler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")]
		string Format (global::Java.Util.Calendar p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='B']]"
		[Register ("format", "(Ljava/util/Calendar;Ljava/lang/Appendable;)Ljava/lang/Appendable;", "GetFormat_Ljava_util_Calendar_Ljava_lang_Appendable_Handler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B extends java.lang.Appendable"})]
		global::Java.Lang.Object Format (global::Java.Util.Calendar p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.lang.StringBuffer']]"
[Obsolete (@"deprecated")]
		[Register ("format", "(Ljava/util/Calendar;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", "GetFormat_Ljava_util_Calendar_Ljava_lang_StringBuffer_Handler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")]
		global::Java.Lang.StringBuffer Format (global::Java.Util.Calendar p0, global::Java.Lang.StringBuffer p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("format", "(Ljava/util/Date;)Ljava/lang/String;", "GetFormat_Ljava_util_Date_Handler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")]
		string Format (global::Java.Util.Date p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='B']]"
		[Register ("format", "(Ljava/util/Date;Ljava/lang/Appendable;)Ljava/lang/Appendable;", "GetFormat_Ljava_util_Date_Ljava_lang_Appendable_Handler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B extends java.lang.Appendable"})]
		global::Java.Lang.Object Format (global::Java.Util.Date p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.StringBuffer']]"
[Obsolete (@"deprecated")]
		[Register ("format", "(Ljava/util/Date;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", "GetFormat_Ljava_util_Date_Ljava_lang_StringBuffer_Handler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")]
		global::Java.Lang.StringBuffer Format (global::Java.Util.Date p0, global::Java.Lang.StringBuffer p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='format' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("format", "(J)Ljava/lang/String;", "GetFormat_JHandler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")]
		string Format (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='B']]"
		[Register ("format", "(JLjava/lang/Appendable;)Ljava/lang/Appendable;", "GetFormat_JLjava_lang_Appendable_Handler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B extends java.lang.Appendable"})]
		global::Java.Lang.Object Format (long p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DatePrinter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.StringBuffer']]"
[Obsolete (@"deprecated")]
		[Register ("format", "(JLjava/lang/StringBuffer;)Ljava/lang/StringBuffer;", "GetFormat_JLjava_lang_StringBuffer_Handler:Org.Apache.Commons.Lang3.Time.IDatePrinterInvoker, AndriodBinding")]
		global::Java.Lang.StringBuffer Format (long p0, global::Java.Lang.StringBuffer p1);

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/time/DatePrinter", DoNotGenerateAcw=true)]
	internal partial class IDatePrinterInvoker : global::Java.Lang.Object, IDatePrinter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/time/DatePrinter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDatePrinterInvoker); }
		}

		IntPtr class_ref;

		public static IDatePrinter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDatePrinter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.time.DatePrinter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDatePrinterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Locale);
		}
#pragma warning restore 0169

		IntPtr id_getLocale;
		public unsafe global::Java.Util.Locale Locale {
			get {
				if (id_getLocale == IntPtr.Zero)
					id_getLocale = JNIEnv.GetMethodID (class_ref, "getLocale", "()Ljava/util/Locale;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocale), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pattern);
		}
#pragma warning restore 0169

		IntPtr id_getPattern;
		public unsafe string Pattern {
			get {
				if (id_getPattern == IntPtr.Zero)
					id_getPattern = JNIEnv.GetMethodID (class_ref, "getPattern", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPattern), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeZone);
		}
#pragma warning restore 0169

		IntPtr id_getTimeZone;
		public unsafe global::Java.Util.TimeZone TimeZone {
			get {
				if (id_getTimeZone == IntPtr.Zero)
					id_getTimeZone = JNIEnv.GetMethodID (class_ref, "getTimeZone", "()Ljava/util/TimeZone;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeZone), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Text.FieldPosition> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_;
		public unsafe global::Java.Lang.StringBuffer Format (global::Java.Lang.Object p0, global::Java.Lang.StringBuffer p1, global::Java.Text.FieldPosition p2)
		{
			if (id_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_ == IntPtr.Zero)
				id_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_format_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_Calendar_Handler ()
		{
			if (cb_format_Ljava_util_Calendar_ == null)
				cb_format_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Format_Ljava_util_Calendar_);
			return cb_format_Ljava_util_Calendar_;
		}

		static IntPtr n_Format_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_format_Ljava_util_Calendar_;
		public unsafe string Format (global::Java.Util.Calendar p0)
		{
			if (id_format_Ljava_util_Calendar_ == IntPtr.Zero)
				id_format_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Calendar;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_format_Ljava_util_Calendar_Ljava_lang_Appendable_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_Calendar_Ljava_lang_Appendable_Handler ()
		{
			if (cb_format_Ljava_util_Calendar_Ljava_lang_Appendable_ == null)
				cb_format_Ljava_util_Calendar_Ljava_lang_Appendable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Format_Ljava_util_Calendar_Ljava_lang_Appendable_);
			return cb_format_Ljava_util_Calendar_Ljava_lang_Appendable_;
		}

		static IntPtr n_Format_Ljava_util_Calendar_Ljava_lang_Appendable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_format_Ljava_util_Calendar_Ljava_lang_Appendable_;
		public unsafe global::Java.Lang.Object Format (global::Java.Util.Calendar p0, global::Java.Lang.Object p1)
		{
			if (id_format_Ljava_util_Calendar_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_format_Ljava_util_Calendar_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Calendar;Ljava/lang/Appendable;)Ljava/lang/Appendable;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Calendar_Ljava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
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
		static IntPtr n_Format_Ljava_util_Calendar_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_;
		public unsafe global::Java.Lang.StringBuffer Format (global::Java.Util.Calendar p0, global::Java.Lang.StringBuffer p1)
		{
			if (id_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Calendar;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Calendar_Ljava_lang_StringBuffer_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_format_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_Date_Handler ()
		{
			if (cb_format_Ljava_util_Date_ == null)
				cb_format_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Format_Ljava_util_Date_);
			return cb_format_Ljava_util_Date_;
		}

		static IntPtr n_Format_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_format_Ljava_util_Date_;
		public unsafe string Format (global::Java.Util.Date p0)
		{
			if (id_format_Ljava_util_Date_ == IntPtr.Zero)
				id_format_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Date;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_format_Ljava_util_Date_Ljava_lang_Appendable_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_Date_Ljava_lang_Appendable_Handler ()
		{
			if (cb_format_Ljava_util_Date_Ljava_lang_Appendable_ == null)
				cb_format_Ljava_util_Date_Ljava_lang_Appendable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Format_Ljava_util_Date_Ljava_lang_Appendable_);
			return cb_format_Ljava_util_Date_Ljava_lang_Appendable_;
		}

		static IntPtr n_Format_Ljava_util_Date_Ljava_lang_Appendable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_format_Ljava_util_Date_Ljava_lang_Appendable_;
		public unsafe global::Java.Lang.Object Format (global::Java.Util.Date p0, global::Java.Lang.Object p1)
		{
			if (id_format_Ljava_util_Date_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_format_Ljava_util_Date_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Date;Ljava/lang/Appendable;)Ljava/lang/Appendable;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Date_Ljava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
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
		static IntPtr n_Format_Ljava_util_Date_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_format_Ljava_util_Date_Ljava_lang_StringBuffer_;
		public unsafe global::Java.Lang.StringBuffer Format (global::Java.Util.Date p0, global::Java.Lang.StringBuffer p1)
		{
			if (id_format_Ljava_util_Date_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_format_Ljava_util_Date_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_Date_Ljava_lang_StringBuffer_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_format_J;
#pragma warning disable 0169
		static Delegate GetFormat_JHandler ()
		{
			if (cb_format_J == null)
				cb_format_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_Format_J);
			return cb_format_J;
		}

		static IntPtr n_Format_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Format (p0));
		}
#pragma warning restore 0169

		IntPtr id_format_J;
		public unsafe string Format (long p0)
		{
			if (id_format_J == IntPtr.Zero)
				id_format_J = JNIEnv.GetMethodID (class_ref, "format", "(J)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_format_JLjava_lang_Appendable_;
#pragma warning disable 0169
		static Delegate GetFormat_JLjava_lang_Appendable_Handler ()
		{
			if (cb_format_JLjava_lang_Appendable_ == null)
				cb_format_JLjava_lang_Appendable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_Format_JLjava_lang_Appendable_);
			return cb_format_JLjava_lang_Appendable_;
		}

		static IntPtr n_Format_JLjava_lang_Appendable_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_format_JLjava_lang_Appendable_;
		public unsafe global::Java.Lang.Object Format (long p0, global::Java.Lang.Object p1)
		{
			if (id_format_JLjava_lang_Appendable_ == IntPtr.Zero)
				id_format_JLjava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "format", "(JLjava/lang/Appendable;)Ljava/lang/Appendable;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_JLjava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
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
		static IntPtr n_Format_JLjava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDatePrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_format_JLjava_lang_StringBuffer_;
		public unsafe global::Java.Lang.StringBuffer Format (long p0, global::Java.Lang.StringBuffer p1)
		{
			if (id_format_JLjava_lang_StringBuffer_ == IntPtr.Zero)
				id_format_JLjava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "format", "(JLjava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_JLjava_lang_StringBuffer_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
