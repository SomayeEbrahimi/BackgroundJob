using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='CompositeFormat']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/CompositeFormat", DoNotGenerateAcw=true)]
	public partial class CompositeFormat : global::Java.Text._Format {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/CompositeFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompositeFormat); }
		}

		protected CompositeFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_text_Format_Ljava_text_Format_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='CompositeFormat']/constructor[@name='CompositeFormat' and count(parameter)=2 and parameter[1][@type='java.text.Format'] and parameter[2][@type='java.text.Format']]"
		[Register (".ctor", "(Ljava/text/Format;Ljava/text/Format;)V", "")]
		public unsafe CompositeFormat (global::Java.Text._Format parser, global::Java.Text._Format formatter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parser);
				__args [1] = new JValue (formatter);
				if (((object) this).GetType () != typeof (CompositeFormat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/text/Format;Ljava/text/Format;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/text/Format;Ljava/text/Format;)V", __args);
					return;
				}

				if (id_ctor_Ljava_text_Format_Ljava_text_Format_ == IntPtr.Zero)
					id_ctor_Ljava_text_Format_Ljava_text_Format_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/text/Format;Ljava/text/Format;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_text_Format_Ljava_text_Format_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_text_Format_Ljava_text_Format_, __args);
			} finally {
			}
		}

		static Delegate cb_getFormatter;
#pragma warning disable 0169
		static Delegate GetGetFormatterHandler ()
		{
			if (cb_getFormatter == null)
				cb_getFormatter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFormatter);
			return cb_getFormatter;
		}

		static IntPtr n_GetFormatter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.CompositeFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Formatter);
		}
#pragma warning restore 0169

		static IntPtr id_getFormatter;
		public virtual unsafe global::Java.Text._Format Formatter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='CompositeFormat']/method[@name='getFormatter' and count(parameter)=0]"
			[Register ("getFormatter", "()Ljava/text/Format;", "GetGetFormatterHandler")]
			get {
				if (id_getFormatter == IntPtr.Zero)
					id_getFormatter = JNIEnv.GetMethodID (class_ref, "getFormatter", "()Ljava/text/Format;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Text._Format> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormatter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Text._Format> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormatter", "()Ljava/text/Format;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParser;
#pragma warning disable 0169
		static Delegate GetGetParserHandler ()
		{
			if (cb_getParser == null)
				cb_getParser = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParser);
			return cb_getParser;
		}

		static IntPtr n_GetParser (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.CompositeFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parser);
		}
#pragma warning restore 0169

		static IntPtr id_getParser;
		public virtual unsafe global::Java.Text._Format Parser {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='CompositeFormat']/method[@name='getParser' and count(parameter)=0]"
			[Register ("getParser", "()Ljava/text/Format;", "GetGetParserHandler")]
			get {
				if (id_getParser == IntPtr.Zero)
					id_getParser = JNIEnv.GetMethodID (class_ref, "getParser", "()Ljava/text/Format;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Text._Format> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParser), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Text._Format> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParser", "()Ljava/text/Format;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.CompositeFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			var toAppendTo = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_toAppendTo, JniHandleOwnership.DoNotTransfer);
			var pos = global::Java.Lang.Object.GetObject<global::Java.Text.FieldPosition> (native_pos, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (obj, toAppendTo, pos));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_lang_Object_Ljava_lang_StringBuffer_Ljava_text_FieldPosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='CompositeFormat']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.StringBuffer'] and parameter[3][@type='java.text.FieldPosition']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.CompositeFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			var pos = global::Java.Lang.Object.GetObject<global::Java.Text.ParsePosition> (native_pos, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseObject (source, pos));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseObject_Ljava_lang_String_Ljava_text_ParsePosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='CompositeFormat']/method[@name='parseObject' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.text.ParsePosition']]"
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

		static Delegate cb_reformat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReformat_Ljava_lang_String_Handler ()
		{
			if (cb_reformat_Ljava_lang_String_ == null)
				cb_reformat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Reformat_Ljava_lang_String_);
			return cb_reformat_Ljava_lang_String_;
		}

		static IntPtr n_Reformat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.CompositeFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = JNIEnv.GetString (native_input, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Reformat (input));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_reformat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='CompositeFormat']/method[@name='reformat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reformat", "(Ljava/lang/String;)Ljava/lang/String;", "GetReformat_Ljava_lang_String_Handler")]
		public virtual unsafe string Reformat (string input)
		{
			if (id_reformat_Ljava_lang_String_ == IntPtr.Zero)
				id_reformat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "reformat", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reformat_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reformat", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

	}
}
