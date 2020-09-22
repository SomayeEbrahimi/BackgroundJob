using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/RegExUtils", DoNotGenerateAcw=true)]
	public partial class RegExUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/RegExUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegExUtils); }
		}

		protected RegExUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/constructor[@name='RegExUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RegExUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RegExUtils)) {
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

		static IntPtr id_removeAll_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeAll", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveAll (string text, string regex)
		{
			if (id_removeAll_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_regex = JNIEnv.NewString (regex);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_regex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_regex);
			}
		}

		static IntPtr id_removeAll_Ljava_lang_String_Ljava_util_regex_Pattern_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.regex.Pattern']]"
		[Register ("removeAll", "(Ljava/lang/String;Ljava/util/regex/Pattern;)Ljava/lang/String;", "")]
		public static unsafe string RemoveAll (string text, global::Java.Util.Regex.Pattern regex)
		{
			if (id_removeAll_Ljava_lang_String_Ljava_util_regex_Pattern_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_String_Ljava_util_regex_Pattern_ = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "(Ljava/lang/String;Ljava/util/regex/Pattern;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (regex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_Ljava_lang_String_Ljava_util_regex_Pattern_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static IntPtr id_removeFirst_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/method[@name='removeFirst' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeFirst", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveFirst (string text, string regex)
		{
			if (id_removeFirst_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeFirst_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeFirst", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_regex = JNIEnv.NewString (regex);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_regex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeFirst_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_regex);
			}
		}

		static IntPtr id_removeFirst_Ljava_lang_String_Ljava_util_regex_Pattern_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/method[@name='removeFirst' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.regex.Pattern']]"
		[Register ("removeFirst", "(Ljava/lang/String;Ljava/util/regex/Pattern;)Ljava/lang/String;", "")]
		public static unsafe string RemoveFirst (string text, global::Java.Util.Regex.Pattern regex)
		{
			if (id_removeFirst_Ljava_lang_String_Ljava_util_regex_Pattern_ == IntPtr.Zero)
				id_removeFirst_Ljava_lang_String_Ljava_util_regex_Pattern_ = JNIEnv.GetStaticMethodID (class_ref, "removeFirst", "(Ljava/lang/String;Ljava/util/regex/Pattern;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (regex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeFirst_Ljava_lang_String_Ljava_util_regex_Pattern_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static IntPtr id_removePattern_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/method[@name='removePattern' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removePattern", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemovePattern (string text, string regex)
		{
			if (id_removePattern_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removePattern_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removePattern", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_regex = JNIEnv.NewString (regex);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_regex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removePattern_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_regex);
			}
		}

		static IntPtr id_replaceAll_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/method[@name='replaceAll' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("replaceAll", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceAll (string text, string regex, string replacement)
		{
			if (id_replaceAll_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceAll_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replaceAll", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_regex = JNIEnv.NewString (regex);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_regex);
				__args [2] = new JValue (native_replacement);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceAll_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_regex);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_replaceAll_Ljava_lang_String_Ljava_util_regex_Pattern_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/method[@name='replaceAll' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.regex.Pattern'] and parameter[3][@type='java.lang.String']]"
		[Register ("replaceAll", "(Ljava/lang/String;Ljava/util/regex/Pattern;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceAll (string text, global::Java.Util.Regex.Pattern regex, string replacement)
		{
			if (id_replaceAll_Ljava_lang_String_Ljava_util_regex_Pattern_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceAll_Ljava_lang_String_Ljava_util_regex_Pattern_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replaceAll", "(Ljava/lang/String;Ljava/util/regex/Pattern;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (regex);
				__args [2] = new JValue (native_replacement);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceAll_Ljava_lang_String_Ljava_util_regex_Pattern_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_replaceFirst_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/method[@name='replaceFirst' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("replaceFirst", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceFirst (string text, string regex, string replacement)
		{
			if (id_replaceFirst_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceFirst_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replaceFirst", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_regex = JNIEnv.NewString (regex);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_regex);
				__args [2] = new JValue (native_replacement);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceFirst_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_regex);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_replaceFirst_Ljava_lang_String_Ljava_util_regex_Pattern_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/method[@name='replaceFirst' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.regex.Pattern'] and parameter[3][@type='java.lang.String']]"
		[Register ("replaceFirst", "(Ljava/lang/String;Ljava/util/regex/Pattern;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceFirst (string text, global::Java.Util.Regex.Pattern regex, string replacement)
		{
			if (id_replaceFirst_Ljava_lang_String_Ljava_util_regex_Pattern_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceFirst_Ljava_lang_String_Ljava_util_regex_Pattern_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replaceFirst", "(Ljava/lang/String;Ljava/util/regex/Pattern;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (regex);
				__args [2] = new JValue (native_replacement);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceFirst_Ljava_lang_String_Ljava_util_regex_Pattern_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_replacePattern_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RegExUtils']/method[@name='replacePattern' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("replacePattern", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplacePattern (string text, string regex, string replacement)
		{
			if (id_replacePattern_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replacePattern_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replacePattern", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_regex = JNIEnv.NewString (regex);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_regex);
				__args [2] = new JValue (native_replacement);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replacePattern_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_regex);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

	}
}
