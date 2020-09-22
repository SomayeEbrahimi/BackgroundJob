using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='FormattableUtils']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/FormattableUtils", DoNotGenerateAcw=true)]
	public partial class FormattableUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/FormattableUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FormattableUtils); }
		}

		protected FormattableUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='FormattableUtils']/constructor[@name='FormattableUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FormattableUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FormattableUtils)) {
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

		static IntPtr id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='FormattableUtils']/method[@name='append' and count(parameter)=5 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.util.Formatter'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("append", "(Ljava/lang/CharSequence;Ljava/util/Formatter;III)Ljava/util/Formatter;", "")]
		public static unsafe global::Java.Util.Formatter Append (global::Java.Lang.ICharSequence seq, global::Java.Util.Formatter formatter, int flags, int width, int precision)
		{
			if (id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_III == IntPtr.Zero)
				id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_III = JNIEnv.GetStaticMethodID (class_ref, "append", "(Ljava/lang/CharSequence;Ljava/util/Formatter;III)Ljava/util/Formatter;");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (formatter);
				__args [2] = new JValue (flags);
				__args [3] = new JValue (width);
				__args [4] = new JValue (precision);
				global::Java.Util.Formatter __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Formatter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_III, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
			}
		}

		public static global::Java.Util.Formatter Append (string seq, global::Java.Util.Formatter formatter, int flags, int width, int precision)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			global::Java.Util.Formatter __result = Append (jls_seq, formatter, flags, width, precision);
			var __rsval = __result;
			jls_seq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIIC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='FormattableUtils']/method[@name='append' and count(parameter)=6 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.util.Formatter'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='char']]"
		[Register ("append", "(Ljava/lang/CharSequence;Ljava/util/Formatter;IIIC)Ljava/util/Formatter;", "")]
		public static unsafe global::Java.Util.Formatter Append (global::Java.Lang.ICharSequence seq, global::Java.Util.Formatter formatter, int flags, int width, int precision, char padChar)
		{
			if (id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIIC == IntPtr.Zero)
				id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIIC = JNIEnv.GetStaticMethodID (class_ref, "append", "(Ljava/lang/CharSequence;Ljava/util/Formatter;IIIC)Ljava/util/Formatter;");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (formatter);
				__args [2] = new JValue (flags);
				__args [3] = new JValue (width);
				__args [4] = new JValue (precision);
				__args [5] = new JValue (padChar);
				global::Java.Util.Formatter __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Formatter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIIC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
			}
		}

		public static global::Java.Util.Formatter Append (string seq, global::Java.Util.Formatter formatter, int flags, int width, int precision, char padChar)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			global::Java.Util.Formatter __result = Append (jls_seq, formatter, flags, width, precision, padChar);
			var __rsval = __result;
			jls_seq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIICLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='FormattableUtils']/method[@name='append' and count(parameter)=7 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.util.Formatter'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='char'] and parameter[7][@type='java.lang.CharSequence']]"
		[Register ("append", "(Ljava/lang/CharSequence;Ljava/util/Formatter;IIICLjava/lang/CharSequence;)Ljava/util/Formatter;", "")]
		public static unsafe global::Java.Util.Formatter Append (global::Java.Lang.ICharSequence seq, global::Java.Util.Formatter formatter, int flags, int width, int precision, char padChar, global::Java.Lang.ICharSequence ellipsis)
		{
			if (id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIICLjava_lang_CharSequence_ == IntPtr.Zero)
				id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIICLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "append", "(Ljava/lang/CharSequence;Ljava/util/Formatter;IIICLjava/lang/CharSequence;)Ljava/util/Formatter;");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			IntPtr native_ellipsis = CharSequence.ToLocalJniHandle (ellipsis);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (formatter);
				__args [2] = new JValue (flags);
				__args [3] = new JValue (width);
				__args [4] = new JValue (precision);
				__args [5] = new JValue (padChar);
				__args [6] = new JValue (native_ellipsis);
				global::Java.Util.Formatter __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Formatter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIICLjava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
				JNIEnv.DeleteLocalRef (native_ellipsis);
			}
		}

		public static global::Java.Util.Formatter Append (string seq, global::Java.Util.Formatter formatter, int flags, int width, int precision, char padChar, string ellipsis)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			var jls_ellipsis = ellipsis == null ? null : new global::Java.Lang.String (ellipsis);
			global::Java.Util.Formatter __result = Append (jls_seq, formatter, flags, width, precision, padChar, jls_ellipsis);
			var __rsval = __result;
			jls_seq?.Dispose ();
			jls_ellipsis?.Dispose ();
			return __rsval;
		}

		static IntPtr id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIILjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='FormattableUtils']/method[@name='append' and count(parameter)=6 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.util.Formatter'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.CharSequence']]"
		[Register ("append", "(Ljava/lang/CharSequence;Ljava/util/Formatter;IIILjava/lang/CharSequence;)Ljava/util/Formatter;", "")]
		public static unsafe global::Java.Util.Formatter Append (global::Java.Lang.ICharSequence seq, global::Java.Util.Formatter formatter, int flags, int width, int precision, global::Java.Lang.ICharSequence ellipsis)
		{
			if (id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIILjava_lang_CharSequence_ == IntPtr.Zero)
				id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIILjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "append", "(Ljava/lang/CharSequence;Ljava/util/Formatter;IIILjava/lang/CharSequence;)Ljava/util/Formatter;");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			IntPtr native_ellipsis = CharSequence.ToLocalJniHandle (ellipsis);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (formatter);
				__args [2] = new JValue (flags);
				__args [3] = new JValue (width);
				__args [4] = new JValue (precision);
				__args [5] = new JValue (native_ellipsis);
				global::Java.Util.Formatter __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Formatter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_append_Ljava_lang_CharSequence_Ljava_util_Formatter_IIILjava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
				JNIEnv.DeleteLocalRef (native_ellipsis);
			}
		}

		public static global::Java.Util.Formatter Append (string seq, global::Java.Util.Formatter formatter, int flags, int width, int precision, string ellipsis)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			var jls_ellipsis = ellipsis == null ? null : new global::Java.Lang.String (ellipsis);
			global::Java.Util.Formatter __result = Append (jls_seq, formatter, flags, width, precision, jls_ellipsis);
			var __rsval = __result;
			jls_seq?.Dispose ();
			jls_ellipsis?.Dispose ();
			return __rsval;
		}

		static IntPtr id_toString_Ljava_util_Formattable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='FormattableUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.util.Formattable']]"
		[Register ("toString", "(Ljava/util/Formattable;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Util.IFormattable formattable)
		{
			if (id_toString_Ljava_util_Formattable_ == IntPtr.Zero)
				id_toString_Ljava_util_Formattable_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/util/Formattable;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (formattable);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_util_Formattable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
