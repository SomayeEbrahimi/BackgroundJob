using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Time {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DateParser']"
	[Register ("org/apache/commons/lang3/time/DateParser", "", "Org.Apache.Commons.Lang3.Time.IDateParserInvoker")]
	public partial interface IDateParser : IJavaObject {

		global::Java.Util.Locale Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DateParser']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/util/Locale;", "GetGetLocaleHandler:Org.Apache.Commons.Lang3.Time.IDateParserInvoker, AndriodBinding")] get;
		}

		string Pattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DateParser']/method[@name='getPattern' and count(parameter)=0]"
			[Register ("getPattern", "()Ljava/lang/String;", "GetGetPatternHandler:Org.Apache.Commons.Lang3.Time.IDateParserInvoker, AndriodBinding")] get;
		}

		global::Java.Util.TimeZone TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DateParser']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()Ljava/util/TimeZone;", "GetGetTimeZoneHandler:Org.Apache.Commons.Lang3.Time.IDateParserInvoker, AndriodBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DateParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Ljava/util/Date;", "GetParse_Ljava_lang_String_Handler:Org.Apache.Commons.Lang3.Time.IDateParserInvoker, AndriodBinding")]
		global::Java.Util.Date Parse (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DateParser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.text.ParsePosition']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", "GetParse_Ljava_lang_String_Ljava_text_ParsePosition_Handler:Org.Apache.Commons.Lang3.Time.IDateParserInvoker, AndriodBinding")]
		global::Java.Util.Date Parse (string p0, global::Java.Text.ParsePosition p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DateParser']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.text.ParsePosition'] and parameter[3][@type='java.util.Calendar']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;Ljava/util/Calendar;)Z", "GetParse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_Handler:Org.Apache.Commons.Lang3.Time.IDateParserInvoker, AndriodBinding")]
		bool Parse (string p0, global::Java.Text.ParsePosition p1, global::Java.Util.Calendar p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DateParser']/method[@name='parseObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseObject", "(Ljava/lang/String;)Ljava/lang/Object;", "GetParseObject_Ljava_lang_String_Handler:Org.Apache.Commons.Lang3.Time.IDateParserInvoker, AndriodBinding")]
		global::Java.Lang.Object ParseObject (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/interface[@name='DateParser']/method[@name='parseObject' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.text.ParsePosition']]"
		[Register ("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", "GetParseObject_Ljava_lang_String_Ljava_text_ParsePosition_Handler:Org.Apache.Commons.Lang3.Time.IDateParserInvoker, AndriodBinding")]
		global::Java.Lang.Object ParseObject (string p0, global::Java.Text.ParsePosition p1);

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/time/DateParser", DoNotGenerateAcw=true)]
	internal partial class IDateParserInvoker : global::Java.Lang.Object, IDateParser {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/time/DateParser");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDateParserInvoker); }
		}

		IntPtr class_ref;

		public static IDateParser GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDateParser> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.time.DateParser"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDateParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDateParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDateParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDateParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_parse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Handler ()
		{
			if (cb_parse_Ljava_lang_String_ == null)
				cb_parse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Parse_Ljava_lang_String_);
			return cb_parse_Ljava_lang_String_;
		}

		static IntPtr n_Parse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDateParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parse_Ljava_lang_String_;
		public unsafe global::Java.Util.Date Parse (string p0)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;)Ljava/util/Date;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Ljava_text_ParsePosition_Handler ()
		{
			if (cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_ == null)
				cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Parse_Ljava_lang_String_Ljava_text_ParsePosition_);
			return cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_;
		}

		static IntPtr n_Parse_Ljava_lang_String_Ljava_text_ParsePosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDateParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Text.ParsePosition> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parse_Ljava_lang_String_Ljava_text_ParsePosition_;
		public unsafe global::Java.Util.Date Parse (string p0, global::Java.Text.ParsePosition p1)
		{
			if (id_parse_Ljava_lang_String_Ljava_text_ParsePosition_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_Ljava_text_ParsePosition_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_lang_String_Ljava_text_ParsePosition_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_Handler ()
		{
			if (cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_ == null)
				cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_Parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_);
			return cb_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_;
		}

		static bool n_Parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDateParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Text.ParsePosition> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Parse (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_;
		public unsafe bool Parse (string p0, global::Java.Text.ParsePosition p1, global::Java.Util.Calendar p2)
		{
			if (id_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;Ljava/util/Calendar;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_lang_String_Ljava_text_ParsePosition_Ljava_util_Calendar_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_parseObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParseObject_Ljava_lang_String_Handler ()
		{
			if (cb_parseObject_Ljava_lang_String_ == null)
				cb_parseObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ParseObject_Ljava_lang_String_);
			return cb_parseObject_Ljava_lang_String_;
		}

		static IntPtr n_ParseObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDateParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parseObject_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object ParseObject (string p0)
		{
			if (id_parseObject_Ljava_lang_String_ == IntPtr.Zero)
				id_parseObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parseObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parseObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_;
#pragma warning disable 0169
		static Delegate GetParseObject_Ljava_lang_String_Ljava_text_ParsePosition_Handler ()
		{
			if (cb_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_ == null)
				cb_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ParseObject_Ljava_lang_String_Ljava_text_ParsePosition_);
			return cb_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_;
		}

		static IntPtr n_ParseObject_Ljava_lang_String_Ljava_text_ParsePosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.IDateParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Text.ParsePosition> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseObject (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_;
		public unsafe global::Java.Lang.Object ParseObject (string p0, global::Java.Text.ParsePosition p1)
		{
			if (id_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_ == IntPtr.Zero)
				id_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_ = JNIEnv.GetMethodID (class_ref, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
