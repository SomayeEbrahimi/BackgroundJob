using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/StringUtils", DoNotGenerateAcw=true)]
	public partial class StringUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/field[@name='CR']"
		[Register ("CR")]
		public const string Cr = (string) "\u000d";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/field[@name='EMPTY']"
		[Register ("EMPTY")]
		public const string Empty = (string) "";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/field[@name='INDEX_NOT_FOUND']"
		[Register ("INDEX_NOT_FOUND")]
		public const int IndexNotFound = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/field[@name='LF']"
		[Register ("LF")]
		public const string Lf = (string) "\u000a";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/field[@name='SPACE']"
		[Register ("SPACE")]
		public const string Space = (string) " ";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/StringUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringUtils); }
		}

		protected StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/constructor[@name='StringUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StringUtils)) {
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

		static IntPtr id_abbreviate_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='abbreviate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("abbreviate", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Abbreviate (string str, int maxWidth)
		{
			if (id_abbreviate_Ljava_lang_String_I == IntPtr.Zero)
				id_abbreviate_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "abbreviate", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (maxWidth);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_abbreviate_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_abbreviate_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='abbreviate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("abbreviate", "(Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string Abbreviate (string str, int offset, int maxWidth)
		{
			if (id_abbreviate_Ljava_lang_String_II == IntPtr.Zero)
				id_abbreviate_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "abbreviate", "(Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (maxWidth);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_abbreviate_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_abbreviate_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='abbreviate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("abbreviate", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Abbreviate (string str, string abbrevMarker, int maxWidth)
		{
			if (id_abbreviate_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_abbreviate_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "abbreviate", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_abbrevMarker = JNIEnv.NewString (abbrevMarker);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_abbrevMarker);
				__args [2] = new JValue (maxWidth);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_abbreviate_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_abbrevMarker);
			}
		}

		static IntPtr id_abbreviate_Ljava_lang_String_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='abbreviate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("abbreviate", "(Ljava/lang/String;Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string Abbreviate (string str, string abbrevMarker, int offset, int maxWidth)
		{
			if (id_abbreviate_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
				id_abbreviate_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "abbreviate", "(Ljava/lang/String;Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_abbrevMarker = JNIEnv.NewString (abbrevMarker);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_abbrevMarker);
				__args [2] = new JValue (offset);
				__args [3] = new JValue (maxWidth);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_abbreviate_Ljava_lang_String_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_abbrevMarker);
			}
		}

		static IntPtr id_abbreviateMiddle_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='abbreviateMiddle' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("abbreviateMiddle", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string AbbreviateMiddle (string str, string middle, int length)
		{
			if (id_abbreviateMiddle_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_abbreviateMiddle_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "abbreviateMiddle", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_middle = JNIEnv.NewString (middle);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_middle);
				__args [2] = new JValue (length);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_abbreviateMiddle_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_middle);
			}
		}

		static IntPtr id_appendIfMissing_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='appendIfMissing' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.CharSequence...']]"
		[Register ("appendIfMissing", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;", "")]
		public static unsafe string AppendIfMissing (string str, global::Java.Lang.ICharSequence suffix, params global::Java.Lang.ICharSequence[] suffixes)
		{
			if (id_appendIfMissing_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_appendIfMissing_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "appendIfMissing", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_suffix = CharSequence.ToLocalJniHandle (suffix);
			IntPtr native_suffixes = JNIEnv.NewArray (suffixes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_suffix);
				__args [2] = new JValue (native_suffixes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_appendIfMissing_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_suffix);
				if (suffixes != null) {
					JNIEnv.CopyArray (native_suffixes, suffixes);
					JNIEnv.DeleteLocalRef (native_suffixes);
				}
			}
		}

		public static string AppendIfMissing (string str, string suffix, params string[] suffixes)
		{
			var jls_suffix = suffix == null ? null : new global::Java.Lang.String (suffix);
			var jlca_suffixes = CharSequence.ArrayFromStringArray(suffixes);
			string __result = AppendIfMissing (str, jls_suffix, jlca_suffixes);
			var __rsval = __result;
			jls_suffix?.Dispose ();
			return __rsval;
		}

		static IntPtr id_appendIfMissingIgnoreCase_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='appendIfMissingIgnoreCase' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.CharSequence...']]"
		[Register ("appendIfMissingIgnoreCase", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;", "")]
		public static unsafe string AppendIfMissingIgnoreCase (string str, global::Java.Lang.ICharSequence suffix, params global::Java.Lang.ICharSequence[] suffixes)
		{
			if (id_appendIfMissingIgnoreCase_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_appendIfMissingIgnoreCase_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "appendIfMissingIgnoreCase", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_suffix = CharSequence.ToLocalJniHandle (suffix);
			IntPtr native_suffixes = JNIEnv.NewArray (suffixes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_suffix);
				__args [2] = new JValue (native_suffixes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_appendIfMissingIgnoreCase_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_suffix);
				if (suffixes != null) {
					JNIEnv.CopyArray (native_suffixes, suffixes);
					JNIEnv.DeleteLocalRef (native_suffixes);
				}
			}
		}

		public static string AppendIfMissingIgnoreCase (string str, string suffix, params string[] suffixes)
		{
			var jls_suffix = suffix == null ? null : new global::Java.Lang.String (suffix);
			var jlca_suffixes = CharSequence.ArrayFromStringArray(suffixes);
			string __result = AppendIfMissingIgnoreCase (str, jls_suffix, jlca_suffixes);
			var __rsval = __result;
			jls_suffix?.Dispose ();
			return __rsval;
		}

		static IntPtr id_capitalize_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='capitalize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("capitalize", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Capitalize (string str)
		{
			if (id_capitalize_Ljava_lang_String_ == IntPtr.Zero)
				id_capitalize_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "capitalize", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_capitalize_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_center_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='center' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("center", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Center (string str, int size)
		{
			if (id_center_Ljava_lang_String_I == IntPtr.Zero)
				id_center_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "center", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (size);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_center_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_center_Ljava_lang_String_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='center' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("center", "(Ljava/lang/String;IC)Ljava/lang/String;", "")]
		public static unsafe string Center (string str, int size, char padChar)
		{
			if (id_center_Ljava_lang_String_IC == IntPtr.Zero)
				id_center_Ljava_lang_String_IC = JNIEnv.GetStaticMethodID (class_ref, "center", "(Ljava/lang/String;IC)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (size);
				__args [2] = new JValue (padChar);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_center_Ljava_lang_String_IC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_center_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='center' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("center", "(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Center (string str, int size, string padStr)
		{
			if (id_center_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_center_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "center", "(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_padStr = JNIEnv.NewString (padStr);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (size);
				__args [2] = new JValue (native_padStr);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_center_Ljava_lang_String_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_padStr);
			}
		}

		static IntPtr id_chomp_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='chomp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("chomp", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Chomp (string str)
		{
			if (id_chomp_Ljava_lang_String_ == IntPtr.Zero)
				id_chomp_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "chomp", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_chomp_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_chomp_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='chomp' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("chomp", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Chomp (string str, string separator)
		{
			if (id_chomp_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_chomp_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "chomp", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_chomp_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_chop_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='chop' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("chop", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Chop (string str)
		{
			if (id_chop_Ljava_lang_String_ == IntPtr.Zero)
				id_chop_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "chop", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_chop_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_compare_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("compare", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int Compare (string str1, string str2)
		{
			if (id_compare_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_compare_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "compare", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_str1 = JNIEnv.NewString (str1);
			IntPtr native_str2 = JNIEnv.NewString (str2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str1);
				__args [1] = new JValue (native_str2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compare_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str1);
				JNIEnv.DeleteLocalRef (native_str2);
			}
		}

		static IntPtr id_compare_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='compare' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("compare", "(Ljava/lang/String;Ljava/lang/String;Z)I", "")]
		public static unsafe int Compare (string str1, string str2, bool nullIsLess)
		{
			if (id_compare_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_compare_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "compare", "(Ljava/lang/String;Ljava/lang/String;Z)I");
			IntPtr native_str1 = JNIEnv.NewString (str1);
			IntPtr native_str2 = JNIEnv.NewString (str2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str1);
				__args [1] = new JValue (native_str2);
				__args [2] = new JValue (nullIsLess);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compare_Ljava_lang_String_Ljava_lang_String_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str1);
				JNIEnv.DeleteLocalRef (native_str2);
			}
		}

		static IntPtr id_compareIgnoreCase_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='compareIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("compareIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CompareIgnoreCase (string str1, string str2)
		{
			if (id_compareIgnoreCase_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_compareIgnoreCase_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "compareIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_str1 = JNIEnv.NewString (str1);
			IntPtr native_str2 = JNIEnv.NewString (str2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str1);
				__args [1] = new JValue (native_str2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareIgnoreCase_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str1);
				JNIEnv.DeleteLocalRef (native_str2);
			}
		}

		static IntPtr id_compareIgnoreCase_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='compareIgnoreCase' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("compareIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;Z)I", "")]
		public static unsafe int CompareIgnoreCase (string str1, string str2, bool nullIsLess)
		{
			if (id_compareIgnoreCase_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_compareIgnoreCase_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "compareIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;Z)I");
			IntPtr native_str1 = JNIEnv.NewString (str1);
			IntPtr native_str2 = JNIEnv.NewString (str2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str1);
				__args [1] = new JValue (native_str2);
				__args [2] = new JValue (nullIsLess);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareIgnoreCase_Ljava_lang_String_Ljava_lang_String_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str1);
				JNIEnv.DeleteLocalRef (native_str2);
			}
		}

		static IntPtr id_contains_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int']]"
		[Register ("contains", "(Ljava/lang/CharSequence;I)Z", "")]
		public static unsafe bool Contains (global::Java.Lang.ICharSequence seq, int searchChar)
		{
			if (id_contains_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_contains_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "contains", "(Ljava/lang/CharSequence;I)Z");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (searchChar);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
			}
		}

		public static bool Contains (string seq, int searchChar)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			bool __result = Contains (jls_seq, searchChar);
			var __rsval = __result;
			jls_seq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_contains_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("contains", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool Contains (global::Java.Lang.ICharSequence seq, global::Java.Lang.ICharSequence searchSeq)
		{
			if (id_contains_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_contains_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "contains", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			IntPtr native_searchSeq = CharSequence.ToLocalJniHandle (searchSeq);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (native_searchSeq);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
				JNIEnv.DeleteLocalRef (native_searchSeq);
			}
		}

		public static bool Contains (string seq, string searchSeq)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			var jls_searchSeq = searchSeq == null ? null : new global::Java.Lang.String (searchSeq);
			bool __result = Contains (jls_seq, jls_searchSeq);
			var __rsval = __result;
			jls_seq?.Dispose ();
			jls_searchSeq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_containsAny_Ljava_lang_CharSequence_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='containsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='char...']]"
		[Register ("containsAny", "(Ljava/lang/CharSequence;[C)Z", "")]
		public static unsafe bool ContainsAny (global::Java.Lang.ICharSequence cs, params char[] searchChars)
		{
			if (id_containsAny_Ljava_lang_CharSequence_arrayC == IntPtr.Zero)
				id_containsAny_Ljava_lang_CharSequence_arrayC = JNIEnv.GetStaticMethodID (class_ref, "containsAny", "(Ljava/lang/CharSequence;[C)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchChars = JNIEnv.NewArray (searchChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_searchChars);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsAny_Ljava_lang_CharSequence_arrayC, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				if (searchChars != null) {
					JNIEnv.CopyArray (native_searchChars, searchChars);
					JNIEnv.DeleteLocalRef (native_searchChars);
				}
			}
		}

		public static bool ContainsAny (string cs, params char[] searchChars)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = ContainsAny (jls_cs, searchChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='containsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("containsAny", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool ContainsAny (global::Java.Lang.ICharSequence cs, global::Java.Lang.ICharSequence searchChars)
		{
			if (id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "containsAny", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchChars = CharSequence.ToLocalJniHandle (searchChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_searchChars);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				JNIEnv.DeleteLocalRef (native_searchChars);
			}
		}

		public static bool ContainsAny (string cs, string searchChars)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			var jls_searchChars = searchChars == null ? null : new global::Java.Lang.String (searchChars);
			bool __result = ContainsAny (jls_cs, jls_searchChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			jls_searchChars?.Dispose ();
			return __rsval;
		}

		static IntPtr id_containsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='containsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence...']]"
		[Register ("containsAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool ContainsAny (global::Java.Lang.ICharSequence cs, params global::Java.Lang.ICharSequence[] searchCharSequences)
		{
			if (id_containsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_containsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "containsAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchCharSequences = JNIEnv.NewArray (searchCharSequences);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_searchCharSequences);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				if (searchCharSequences != null) {
					JNIEnv.CopyArray (native_searchCharSequences, searchCharSequences);
					JNIEnv.DeleteLocalRef (native_searchCharSequences);
				}
			}
		}

		public static bool ContainsAny (string cs, params string[] searchCharSequences)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			var jlca_searchCharSequences = CharSequence.ArrayFromStringArray(searchCharSequences);
			bool __result = ContainsAny (jls_cs, jlca_searchCharSequences);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_containsIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='containsIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("containsIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool ContainsIgnoreCase (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence searchStr)
		{
			if (id_containsIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_containsIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "containsIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_searchStr = CharSequence.ToLocalJniHandle (searchStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_searchStr);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_searchStr);
			}
		}

		public static bool ContainsIgnoreCase (string str, string searchStr)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_searchStr = searchStr == null ? null : new global::Java.Lang.String (searchStr);
			bool __result = ContainsIgnoreCase (jls_str, jls_searchStr);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_searchStr?.Dispose ();
			return __rsval;
		}

		static IntPtr id_containsNone_Ljava_lang_CharSequence_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='containsNone' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='char...']]"
		[Register ("containsNone", "(Ljava/lang/CharSequence;[C)Z", "")]
		public static unsafe bool ContainsNone (global::Java.Lang.ICharSequence cs, params char[] searchChars)
		{
			if (id_containsNone_Ljava_lang_CharSequence_arrayC == IntPtr.Zero)
				id_containsNone_Ljava_lang_CharSequence_arrayC = JNIEnv.GetStaticMethodID (class_ref, "containsNone", "(Ljava/lang/CharSequence;[C)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchChars = JNIEnv.NewArray (searchChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_searchChars);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsNone_Ljava_lang_CharSequence_arrayC, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				if (searchChars != null) {
					JNIEnv.CopyArray (native_searchChars, searchChars);
					JNIEnv.DeleteLocalRef (native_searchChars);
				}
			}
		}

		public static bool ContainsNone (string cs, params char[] searchChars)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = ContainsNone (jls_cs, searchChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_containsNone_Ljava_lang_CharSequence_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='containsNone' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.String']]"
		[Register ("containsNone", "(Ljava/lang/CharSequence;Ljava/lang/String;)Z", "")]
		public static unsafe bool ContainsNone (global::Java.Lang.ICharSequence cs, string invalidChars)
		{
			if (id_containsNone_Ljava_lang_CharSequence_Ljava_lang_String_ == IntPtr.Zero)
				id_containsNone_Ljava_lang_CharSequence_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "containsNone", "(Ljava/lang/CharSequence;Ljava/lang/String;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_invalidChars = JNIEnv.NewString (invalidChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_invalidChars);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsNone_Ljava_lang_CharSequence_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				JNIEnv.DeleteLocalRef (native_invalidChars);
			}
		}

		public static bool ContainsNone (string cs, string invalidChars)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = ContainsNone (jls_cs, invalidChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_containsOnly_Ljava_lang_CharSequence_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='containsOnly' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='char...']]"
		[Register ("containsOnly", "(Ljava/lang/CharSequence;[C)Z", "")]
		public static unsafe bool ContainsOnly (global::Java.Lang.ICharSequence cs, params char[] valid)
		{
			if (id_containsOnly_Ljava_lang_CharSequence_arrayC == IntPtr.Zero)
				id_containsOnly_Ljava_lang_CharSequence_arrayC = JNIEnv.GetStaticMethodID (class_ref, "containsOnly", "(Ljava/lang/CharSequence;[C)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_valid = JNIEnv.NewArray (valid);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_valid);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsOnly_Ljava_lang_CharSequence_arrayC, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				if (valid != null) {
					JNIEnv.CopyArray (native_valid, valid);
					JNIEnv.DeleteLocalRef (native_valid);
				}
			}
		}

		public static bool ContainsOnly (string cs, params char[] valid)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = ContainsOnly (jls_cs, valid);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_containsOnly_Ljava_lang_CharSequence_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='containsOnly' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.String']]"
		[Register ("containsOnly", "(Ljava/lang/CharSequence;Ljava/lang/String;)Z", "")]
		public static unsafe bool ContainsOnly (global::Java.Lang.ICharSequence cs, string validChars)
		{
			if (id_containsOnly_Ljava_lang_CharSequence_Ljava_lang_String_ == IntPtr.Zero)
				id_containsOnly_Ljava_lang_CharSequence_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "containsOnly", "(Ljava/lang/CharSequence;Ljava/lang/String;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_validChars = JNIEnv.NewString (validChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_validChars);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsOnly_Ljava_lang_CharSequence_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				JNIEnv.DeleteLocalRef (native_validChars);
			}
		}

		public static bool ContainsOnly (string cs, string validChars)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = ContainsOnly (jls_cs, validChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_containsWhitespace_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='containsWhitespace' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("containsWhitespace", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool ContainsWhitespace (global::Java.Lang.ICharSequence seq)
		{
			if (id_containsWhitespace_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_containsWhitespace_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "containsWhitespace", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_seq);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsWhitespace_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
			}
		}

		public static bool ContainsWhitespace (string seq)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			bool __result = ContainsWhitespace (jls_seq);
			var __rsval = __result;
			jls_seq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_countMatches_Ljava_lang_CharSequence_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='countMatches' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='char']]"
		[Register ("countMatches", "(Ljava/lang/CharSequence;C)I", "")]
		public static unsafe int CountMatches (global::Java.Lang.ICharSequence str, char ch)
		{
			if (id_countMatches_Ljava_lang_CharSequence_C == IntPtr.Zero)
				id_countMatches_Ljava_lang_CharSequence_C = JNIEnv.GetStaticMethodID (class_ref, "countMatches", "(Ljava/lang/CharSequence;C)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (ch);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_countMatches_Ljava_lang_CharSequence_C, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		public static int CountMatches (string str, char ch)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			int __result = CountMatches (jls_str, ch);
			var __rsval = __result;
			jls_str?.Dispose ();
			return __rsval;
		}

		static IntPtr id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='countMatches' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("countMatches", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int CountMatches (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence sub)
		{
			if (id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "countMatches", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_sub = CharSequence.ToLocalJniHandle (sub);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_sub);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_sub);
			}
		}

		public static int CountMatches (string str, string sub)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_sub = sub == null ? null : new global::Java.Lang.String (sub);
			int __result = CountMatches (jls_str, jls_sub);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_sub?.Dispose ();
			return __rsval;
		}

		static IntPtr id_defaultIfBlank_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='defaultIfBlank' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("defaultIfBlank", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.CharSequence"})]
		public static unsafe global::Java.Lang.Object DefaultIfBlank (global::Java.Lang.Object str, global::Java.Lang.Object defaultStr)
		{
			if (id_defaultIfBlank_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_defaultIfBlank_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "defaultIfBlank", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			IntPtr native_str = JNIEnv.ToLocalJniHandle (str);
			IntPtr native_defaultStr = JNIEnv.ToLocalJniHandle (defaultStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_defaultStr);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultIfBlank_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_defaultStr);
			}
		}

		public static global::Java.Lang.Object DefaultIfBlank (global::Java.Lang.Object str, global::Java.Lang.Object defaultStr)
		{
			global::Java.Lang.Object __result = DefaultIfBlank (str, defaultStr);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_defaultIfEmpty_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='defaultIfEmpty' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("defaultIfEmpty", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.CharSequence"})]
		public static unsafe global::Java.Lang.Object DefaultIfEmpty (global::Java.Lang.Object str, global::Java.Lang.Object defaultStr)
		{
			if (id_defaultIfEmpty_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_defaultIfEmpty_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "defaultIfEmpty", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			IntPtr native_str = JNIEnv.ToLocalJniHandle (str);
			IntPtr native_defaultStr = JNIEnv.ToLocalJniHandle (defaultStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_defaultStr);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultIfEmpty_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_defaultStr);
			}
		}

		public static global::Java.Lang.Object DefaultIfEmpty (global::Java.Lang.Object str, global::Java.Lang.Object defaultStr)
		{
			global::Java.Lang.Object __result = DefaultIfEmpty (str, defaultStr);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_defaultString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='defaultString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("defaultString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DefaultString (string str)
		{
			if (id_defaultString_Ljava_lang_String_ == IntPtr.Zero)
				id_defaultString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "defaultString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_defaultString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='defaultString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("defaultString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DefaultString (string str, string defaultStr)
		{
			if (id_defaultString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_defaultString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "defaultString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_defaultStr = JNIEnv.NewString (defaultStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_defaultStr);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_defaultStr);
			}
		}

		static IntPtr id_deleteWhitespace_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='deleteWhitespace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteWhitespace", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DeleteWhitespace (string str)
		{
			if (id_deleteWhitespace_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteWhitespace_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "deleteWhitespace", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_deleteWhitespace_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_difference_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='difference' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("difference", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Difference (string str1, string str2)
		{
			if (id_difference_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_difference_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "difference", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str1 = JNIEnv.NewString (str1);
			IntPtr native_str2 = JNIEnv.NewString (str2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str1);
				__args [1] = new JValue (native_str2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_difference_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str1);
				JNIEnv.DeleteLocalRef (native_str2);
			}
		}

		static IntPtr id_endsWith_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='endsWith' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("endsWith", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool EndsWith (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence suffix)
		{
			if (id_endsWith_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_endsWith_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "endsWith", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_suffix = CharSequence.ToLocalJniHandle (suffix);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_suffix);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_endsWith_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

		public static bool EndsWith (string str, string suffix)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_suffix = suffix == null ? null : new global::Java.Lang.String (suffix);
			bool __result = EndsWith (jls_str, jls_suffix);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_suffix?.Dispose ();
			return __rsval;
		}

		static IntPtr id_endsWithAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='endsWithAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence...']]"
		[Register ("endsWithAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool EndsWithAny (global::Java.Lang.ICharSequence sequence, params global::Java.Lang.ICharSequence[] searchStrings)
		{
			if (id_endsWithAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_endsWithAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "endsWithAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z");
			IntPtr native_sequence = CharSequence.ToLocalJniHandle (sequence);
			IntPtr native_searchStrings = JNIEnv.NewArray (searchStrings);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_sequence);
				__args [1] = new JValue (native_searchStrings);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_endsWithAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_sequence);
				if (searchStrings != null) {
					JNIEnv.CopyArray (native_searchStrings, searchStrings);
					JNIEnv.DeleteLocalRef (native_searchStrings);
				}
			}
		}

		public static bool EndsWithAny (string sequence, params string[] searchStrings)
		{
			var jls_sequence = sequence == null ? null : new global::Java.Lang.String (sequence);
			var jlca_searchStrings = CharSequence.ArrayFromStringArray(searchStrings);
			bool __result = EndsWithAny (jls_sequence, jlca_searchStrings);
			var __rsval = __result;
			jls_sequence?.Dispose ();
			return __rsval;
		}

		static IntPtr id_endsWithIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='endsWithIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("endsWithIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool EndsWithIgnoreCase (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence suffix)
		{
			if (id_endsWithIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_endsWithIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "endsWithIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_suffix = CharSequence.ToLocalJniHandle (suffix);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_suffix);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_endsWithIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

		public static bool EndsWithIgnoreCase (string str, string suffix)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_suffix = suffix == null ? null : new global::Java.Lang.String (suffix);
			bool __result = EndsWithIgnoreCase (jls_str, jls_suffix);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_suffix?.Dispose ();
			return __rsval;
		}

		static IntPtr id_equals_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool Equals (global::Java.Lang.ICharSequence cs1, global::Java.Lang.ICharSequence cs2)
		{
			if (id_equals_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_equals_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_cs1 = CharSequence.ToLocalJniHandle (cs1);
			IntPtr native_cs2 = CharSequence.ToLocalJniHandle (cs2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs1);
				__args [1] = new JValue (native_cs2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs1);
				JNIEnv.DeleteLocalRef (native_cs2);
			}
		}

		public static bool Equals (string cs1, string cs2)
		{
			var jls_cs1 = cs1 == null ? null : new global::Java.Lang.String (cs1);
			var jls_cs2 = cs2 == null ? null : new global::Java.Lang.String (cs2);
			bool __result = Equals (jls_cs1, jls_cs2);
			var __rsval = __result;
			jls_cs1?.Dispose ();
			jls_cs2?.Dispose ();
			return __rsval;
		}

		static IntPtr id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='equalsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence...']]"
		[Register ("equalsAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool EqualsAny (global::Java.Lang.ICharSequence @string, params global::Java.Lang.ICharSequence[] searchStrings)
		{
			if (id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "equalsAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z");
			IntPtr native__string = CharSequence.ToLocalJniHandle (@string);
			IntPtr native_searchStrings = JNIEnv.NewArray (searchStrings);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__string);
				__args [1] = new JValue (native_searchStrings);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
				if (searchStrings != null) {
					JNIEnv.CopyArray (native_searchStrings, searchStrings);
					JNIEnv.DeleteLocalRef (native_searchStrings);
				}
			}
		}

		public static bool EqualsAny (string @string, params string[] searchStrings)
		{
			var jls_string = @string == null ? null : new global::Java.Lang.String (@string);
			var jlca_searchStrings = CharSequence.ArrayFromStringArray(searchStrings);
			bool __result = EqualsAny (jls_string, jlca_searchStrings);
			var __rsval = __result;
			jls_string?.Dispose ();
			return __rsval;
		}

		static IntPtr id_equalsAnyIgnoreCase_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='equalsAnyIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence...']]"
		[Register ("equalsAnyIgnoreCase", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool EqualsAnyIgnoreCase (global::Java.Lang.ICharSequence @string, params global::Java.Lang.ICharSequence[] searchStrings)
		{
			if (id_equalsAnyIgnoreCase_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_equalsAnyIgnoreCase_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "equalsAnyIgnoreCase", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z");
			IntPtr native__string = CharSequence.ToLocalJniHandle (@string);
			IntPtr native_searchStrings = JNIEnv.NewArray (searchStrings);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__string);
				__args [1] = new JValue (native_searchStrings);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equalsAnyIgnoreCase_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
				if (searchStrings != null) {
					JNIEnv.CopyArray (native_searchStrings, searchStrings);
					JNIEnv.DeleteLocalRef (native_searchStrings);
				}
			}
		}

		public static bool EqualsAnyIgnoreCase (string @string, params string[] searchStrings)
		{
			var jls_string = @string == null ? null : new global::Java.Lang.String (@string);
			var jlca_searchStrings = CharSequence.ArrayFromStringArray(searchStrings);
			bool __result = EqualsAnyIgnoreCase (jls_string, jlca_searchStrings);
			var __rsval = __result;
			jls_string?.Dispose ();
			return __rsval;
		}

		static IntPtr id_equalsIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='equalsIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("equalsIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool EqualsIgnoreCase (global::Java.Lang.ICharSequence str1, global::Java.Lang.ICharSequence str2)
		{
			if (id_equalsIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_equalsIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "equalsIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_str1 = CharSequence.ToLocalJniHandle (str1);
			IntPtr native_str2 = CharSequence.ToLocalJniHandle (str2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str1);
				__args [1] = new JValue (native_str2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equalsIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str1);
				JNIEnv.DeleteLocalRef (native_str2);
			}
		}

		public static bool EqualsIgnoreCase (string str1, string str2)
		{
			var jls_str1 = str1 == null ? null : new global::Java.Lang.String (str1);
			var jls_str2 = str2 == null ? null : new global::Java.Lang.String (str2);
			bool __result = EqualsIgnoreCase (jls_str1, jls_str2);
			var __rsval = __result;
			jls_str1?.Dispose ();
			jls_str2?.Dispose ();
			return __rsval;
		}

		static IntPtr id_firstNonBlank_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='firstNonBlank' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("firstNonBlank", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.CharSequence"})]
		public static unsafe global::Java.Lang.Object FirstNonBlank (params global::Java.Lang.Object[] values)
		{
			if (id_firstNonBlank_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_firstNonBlank_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "firstNonBlank", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_firstNonBlank_arrayLjava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		public static global::Java.Lang.Object FirstNonBlank (params global::Java.Lang.Object[] values)
		{
			global::Java.Lang.Object __result = FirstNonBlank (values);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_firstNonEmpty_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='firstNonEmpty' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("firstNonEmpty", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.CharSequence"})]
		public static unsafe global::Java.Lang.Object FirstNonEmpty (params global::Java.Lang.Object[] values)
		{
			if (id_firstNonEmpty_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_firstNonEmpty_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "firstNonEmpty", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_firstNonEmpty_arrayLjava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		public static global::Java.Lang.Object FirstNonEmpty (params global::Java.Lang.Object[] values)
		{
			global::Java.Lang.Object __result = FirstNonEmpty (values);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_getCommonPrefix_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='getCommonPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("getCommonPrefix", "([Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCommonPrefix (params string[] strs)
		{
			if (id_getCommonPrefix_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getCommonPrefix_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCommonPrefix", "([Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_strs = JNIEnv.NewArray (strs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_strs);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCommonPrefix_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (strs != null) {
					JNIEnv.CopyArray (native_strs, strs);
					JNIEnv.DeleteLocalRef (native_strs);
				}
			}
		}

		static IntPtr id_getDigits_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='getDigits' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDigits", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetDigits (string str)
		{
			if (id_getDigits_Ljava_lang_String_ == IntPtr.Zero)
				id_getDigits_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDigits", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDigits_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_getFuzzyDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='getFuzzyDistance' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.util.Locale']]"
		[Obsolete (@"deprecated")]
		[Register ("getFuzzyDistance", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/util/Locale;)I", "")]
		public static unsafe int GetFuzzyDistance (global::Java.Lang.ICharSequence term, global::Java.Lang.ICharSequence query, global::Java.Util.Locale locale)
		{
			if (id_getFuzzyDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_Ljava_util_Locale_ == IntPtr.Zero)
				id_getFuzzyDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "getFuzzyDistance", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/util/Locale;)I");
			IntPtr native_term = CharSequence.ToLocalJniHandle (term);
			IntPtr native_query = CharSequence.ToLocalJniHandle (query);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_term);
				__args [1] = new JValue (native_query);
				__args [2] = new JValue (locale);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getFuzzyDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_Ljava_util_Locale_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_term);
				JNIEnv.DeleteLocalRef (native_query);
			}
		}

		[Obsolete (@"deprecated")]
		public static int GetFuzzyDistance (string term, string query, global::Java.Util.Locale locale)
		{
			var jls_term = term == null ? null : new global::Java.Lang.String (term);
			var jls_query = query == null ? null : new global::Java.Lang.String (query);
			int __result = GetFuzzyDistance (jls_term, jls_query, locale);
			var __rsval = __result;
			jls_term?.Dispose ();
			jls_query?.Dispose ();
			return __rsval;
		}

		static IntPtr id_getJaroWinklerDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='getJaroWinklerDistance' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Obsolete (@"deprecated")]
		[Register ("getJaroWinklerDistance", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)D", "")]
		public static unsafe double GetJaroWinklerDistance (global::Java.Lang.ICharSequence first, global::Java.Lang.ICharSequence second)
		{
			if (id_getJaroWinklerDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_getJaroWinklerDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "getJaroWinklerDistance", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)D");
			IntPtr native_first = CharSequence.ToLocalJniHandle (first);
			IntPtr native_second = CharSequence.ToLocalJniHandle (second);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_first);
				__args [1] = new JValue (native_second);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_getJaroWinklerDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_first);
				JNIEnv.DeleteLocalRef (native_second);
			}
		}

		[Obsolete (@"deprecated")]
		public static double GetJaroWinklerDistance (string first, string second)
		{
			var jls_first = first == null ? null : new global::Java.Lang.String (first);
			var jls_second = second == null ? null : new global::Java.Lang.String (second);
			double __result = GetJaroWinklerDistance (jls_first, jls_second);
			var __rsval = __result;
			jls_first?.Dispose ();
			jls_second?.Dispose ();
			return __rsval;
		}

		static IntPtr id_getLevenshteinDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='getLevenshteinDistance' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Obsolete (@"deprecated")]
		[Register ("getLevenshteinDistance", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int GetLevenshteinDistance (global::Java.Lang.ICharSequence s, global::Java.Lang.ICharSequence t)
		{
			if (id_getLevenshteinDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_getLevenshteinDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "getLevenshteinDistance", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			IntPtr native_s = CharSequence.ToLocalJniHandle (s);
			IntPtr native_t = CharSequence.ToLocalJniHandle (t);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_s);
				__args [1] = new JValue (native_t);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getLevenshteinDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				JNIEnv.DeleteLocalRef (native_t);
			}
		}

		[Obsolete (@"deprecated")]
		public static int GetLevenshteinDistance (string s, string t)
		{
			var jls_s = s == null ? null : new global::Java.Lang.String (s);
			var jls_t = t == null ? null : new global::Java.Lang.String (t);
			int __result = GetLevenshteinDistance (jls_s, jls_t);
			var __rsval = __result;
			jls_s?.Dispose ();
			jls_t?.Dispose ();
			return __rsval;
		}

		static IntPtr id_getLevenshteinDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='getLevenshteinDistance' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("getLevenshteinDistance", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int GetLevenshteinDistance (global::Java.Lang.ICharSequence s, global::Java.Lang.ICharSequence t, int threshold)
		{
			if (id_getLevenshteinDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_getLevenshteinDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "getLevenshteinDistance", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			IntPtr native_s = CharSequence.ToLocalJniHandle (s);
			IntPtr native_t = CharSequence.ToLocalJniHandle (t);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_s);
				__args [1] = new JValue (native_t);
				__args [2] = new JValue (threshold);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getLevenshteinDistance_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				JNIEnv.DeleteLocalRef (native_t);
			}
		}

		[Obsolete (@"deprecated")]
		public static int GetLevenshteinDistance (string s, string t, int threshold)
		{
			var jls_s = s == null ? null : new global::Java.Lang.String (s);
			var jls_t = t == null ? null : new global::Java.Lang.String (t);
			int __result = GetLevenshteinDistance (jls_s, jls_t, threshold);
			var __rsval = __result;
			jls_s?.Dispose ();
			jls_t?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOf_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int']]"
		[Register ("indexOf", "(Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int IndexOf (global::Java.Lang.ICharSequence seq, int searchChar)
		{
			if (id_indexOf_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_indexOf_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "(Ljava/lang/CharSequence;I)I");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (searchChar);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
			}
		}

		public static int IndexOf (string seq, int searchChar)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			int __result = IndexOf (jls_seq, searchChar);
			var __rsval = __result;
			jls_seq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOf_Ljava_lang_CharSequence_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("indexOf", "(Ljava/lang/CharSequence;II)I", "")]
		public static unsafe int IndexOf (global::Java.Lang.ICharSequence seq, int searchChar, int startPos)
		{
			if (id_indexOf_Ljava_lang_CharSequence_II == IntPtr.Zero)
				id_indexOf_Ljava_lang_CharSequence_II = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "(Ljava/lang/CharSequence;II)I");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (searchChar);
				__args [2] = new JValue (startPos);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_Ljava_lang_CharSequence_II, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
			}
		}

		public static int IndexOf (string seq, int searchChar, int startPos)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			int __result = IndexOf (jls_seq, searchChar, startPos);
			var __rsval = __result;
			jls_seq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int IndexOf (global::Java.Lang.ICharSequence seq, global::Java.Lang.ICharSequence searchSeq)
		{
			if (id_indexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_indexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			IntPtr native_searchSeq = CharSequence.ToLocalJniHandle (searchSeq);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (native_searchSeq);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
				JNIEnv.DeleteLocalRef (native_searchSeq);
			}
		}

		public static int IndexOf (string seq, string searchSeq)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			var jls_searchSeq = searchSeq == null ? null : new global::Java.Lang.String (searchSeq);
			int __result = IndexOf (jls_seq, jls_searchSeq);
			var __rsval = __result;
			jls_seq?.Dispose ();
			jls_searchSeq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='int']]"
		[Register ("indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int IndexOf (global::Java.Lang.ICharSequence seq, global::Java.Lang.ICharSequence searchSeq, int startPos)
		{
			if (id_indexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_indexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			IntPtr native_searchSeq = CharSequence.ToLocalJniHandle (searchSeq);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (native_searchSeq);
				__args [2] = new JValue (startPos);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
				JNIEnv.DeleteLocalRef (native_searchSeq);
			}
		}

		public static int IndexOf (string seq, string searchSeq, int startPos)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			var jls_searchSeq = searchSeq == null ? null : new global::Java.Lang.String (searchSeq);
			int __result = IndexOf (jls_seq, jls_searchSeq, startPos);
			var __rsval = __result;
			jls_seq?.Dispose ();
			jls_searchSeq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOfAny_Ljava_lang_CharSequence_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOfAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='char...']]"
		[Register ("indexOfAny", "(Ljava/lang/CharSequence;[C)I", "")]
		public static unsafe int IndexOfAny (global::Java.Lang.ICharSequence cs, params char[] searchChars)
		{
			if (id_indexOfAny_Ljava_lang_CharSequence_arrayC == IntPtr.Zero)
				id_indexOfAny_Ljava_lang_CharSequence_arrayC = JNIEnv.GetStaticMethodID (class_ref, "indexOfAny", "(Ljava/lang/CharSequence;[C)I");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchChars = JNIEnv.NewArray (searchChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_searchChars);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfAny_Ljava_lang_CharSequence_arrayC, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				if (searchChars != null) {
					JNIEnv.CopyArray (native_searchChars, searchChars);
					JNIEnv.DeleteLocalRef (native_searchChars);
				}
			}
		}

		public static int IndexOfAny (string cs, params char[] searchChars)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			int __result = IndexOfAny (jls_cs, searchChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOfAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOfAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence...']]"
		[Register ("indexOfAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)I", "")]
		public static unsafe int IndexOfAny (global::Java.Lang.ICharSequence str, params global::Java.Lang.ICharSequence[] searchStrs)
		{
			if (id_indexOfAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_indexOfAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_searchStrs = JNIEnv.NewArray (searchStrs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_searchStrs);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (searchStrs != null) {
					JNIEnv.CopyArray (native_searchStrs, searchStrs);
					JNIEnv.DeleteLocalRef (native_searchStrs);
				}
			}
		}

		public static int IndexOfAny (string str, params string[] searchStrs)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jlca_searchStrs = CharSequence.ArrayFromStringArray(searchStrs);
			int __result = IndexOfAny (jls_str, jlca_searchStrs);
			var __rsval = __result;
			jls_str?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOfAny_Ljava_lang_CharSequence_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOfAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.String']]"
		[Register ("indexOfAny", "(Ljava/lang/CharSequence;Ljava/lang/String;)I", "")]
		public static unsafe int IndexOfAny (global::Java.Lang.ICharSequence cs, string searchChars)
		{
			if (id_indexOfAny_Ljava_lang_CharSequence_Ljava_lang_String_ == IntPtr.Zero)
				id_indexOfAny_Ljava_lang_CharSequence_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfAny", "(Ljava/lang/CharSequence;Ljava/lang/String;)I");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchChars = JNIEnv.NewString (searchChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_searchChars);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfAny_Ljava_lang_CharSequence_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				JNIEnv.DeleteLocalRef (native_searchChars);
			}
		}

		public static int IndexOfAny (string cs, string searchChars)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			int __result = IndexOfAny (jls_cs, searchChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOfAnyBut_Ljava_lang_CharSequence_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOfAnyBut' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='char...']]"
		[Register ("indexOfAnyBut", "(Ljava/lang/CharSequence;[C)I", "")]
		public static unsafe int IndexOfAnyBut (global::Java.Lang.ICharSequence cs, params char[] searchChars)
		{
			if (id_indexOfAnyBut_Ljava_lang_CharSequence_arrayC == IntPtr.Zero)
				id_indexOfAnyBut_Ljava_lang_CharSequence_arrayC = JNIEnv.GetStaticMethodID (class_ref, "indexOfAnyBut", "(Ljava/lang/CharSequence;[C)I");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchChars = JNIEnv.NewArray (searchChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_searchChars);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfAnyBut_Ljava_lang_CharSequence_arrayC, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				if (searchChars != null) {
					JNIEnv.CopyArray (native_searchChars, searchChars);
					JNIEnv.DeleteLocalRef (native_searchChars);
				}
			}
		}

		public static int IndexOfAnyBut (string cs, params char[] searchChars)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			int __result = IndexOfAnyBut (jls_cs, searchChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOfAnyBut_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOfAnyBut' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("indexOfAnyBut", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int IndexOfAnyBut (global::Java.Lang.ICharSequence seq, global::Java.Lang.ICharSequence searchChars)
		{
			if (id_indexOfAnyBut_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_indexOfAnyBut_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfAnyBut", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			IntPtr native_searchChars = CharSequence.ToLocalJniHandle (searchChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (native_searchChars);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfAnyBut_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
				JNIEnv.DeleteLocalRef (native_searchChars);
			}
		}

		public static int IndexOfAnyBut (string seq, string searchChars)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			var jls_searchChars = searchChars == null ? null : new global::Java.Lang.String (searchChars);
			int __result = IndexOfAnyBut (jls_seq, jls_searchChars);
			var __rsval = __result;
			jls_seq?.Dispose ();
			jls_searchChars?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOfDifference_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOfDifference' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("indexOfDifference", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int IndexOfDifference (global::Java.Lang.ICharSequence cs1, global::Java.Lang.ICharSequence cs2)
		{
			if (id_indexOfDifference_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_indexOfDifference_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfDifference", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			IntPtr native_cs1 = CharSequence.ToLocalJniHandle (cs1);
			IntPtr native_cs2 = CharSequence.ToLocalJniHandle (cs2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs1);
				__args [1] = new JValue (native_cs2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfDifference_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs1);
				JNIEnv.DeleteLocalRef (native_cs2);
			}
		}

		public static int IndexOfDifference (string cs1, string cs2)
		{
			var jls_cs1 = cs1 == null ? null : new global::Java.Lang.String (cs1);
			var jls_cs2 = cs2 == null ? null : new global::Java.Lang.String (cs2);
			int __result = IndexOfDifference (jls_cs1, jls_cs2);
			var __rsval = __result;
			jls_cs1?.Dispose ();
			jls_cs2?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOfDifference_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOfDifference' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence...']]"
		[Register ("indexOfDifference", "([Ljava/lang/CharSequence;)I", "")]
		public static unsafe int IndexOfDifference (params global::Java.Lang.ICharSequence[] css)
		{
			if (id_indexOfDifference_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_indexOfDifference_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfDifference", "([Ljava/lang/CharSequence;)I");
			IntPtr native_css = JNIEnv.NewArray (css);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_css);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfDifference_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				if (css != null) {
					JNIEnv.CopyArray (native_css, css);
					JNIEnv.DeleteLocalRef (native_css);
				}
			}
		}

		public static int IndexOfDifference (params string[] css)
		{
			var jlca_css = CharSequence.ArrayFromStringArray(css);
			int __result = IndexOfDifference (jlca_css);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_indexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOfIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("indexOfIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int IndexOfIgnoreCase (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence searchStr)
		{
			if (id_indexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_indexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_searchStr = CharSequence.ToLocalJniHandle (searchStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_searchStr);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_searchStr);
			}
		}

		public static int IndexOfIgnoreCase (string str, string searchStr)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_searchStr = searchStr == null ? null : new global::Java.Lang.String (searchStr);
			int __result = IndexOfIgnoreCase (jls_str, jls_searchStr);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_searchStr?.Dispose ();
			return __rsval;
		}

		static IntPtr id_indexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='indexOfIgnoreCase' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='int']]"
		[Register ("indexOfIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int IndexOfIgnoreCase (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence searchStr, int startPos)
		{
			if (id_indexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_indexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "indexOfIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_searchStr = CharSequence.ToLocalJniHandle (searchStr);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_searchStr);
				__args [2] = new JValue (startPos);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_searchStr);
			}
		}

		public static int IndexOfIgnoreCase (string str, string searchStr, int startPos)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_searchStr = searchStr == null ? null : new global::Java.Lang.String (searchStr);
			int __result = IndexOfIgnoreCase (jls_str, jls_searchStr, startPos);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_searchStr?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isAllBlank_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAllBlank' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence...']]"
		[Register ("isAllBlank", "([Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAllBlank (params global::Java.Lang.ICharSequence[] css)
		{
			if (id_isAllBlank_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_isAllBlank_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAllBlank", "([Ljava/lang/CharSequence;)Z");
			IntPtr native_css = JNIEnv.NewArray (css);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_css);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAllBlank_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				if (css != null) {
					JNIEnv.CopyArray (native_css, css);
					JNIEnv.DeleteLocalRef (native_css);
				}
			}
		}

		public static bool IsAllBlank (params string[] css)
		{
			var jlca_css = CharSequence.ArrayFromStringArray(css);
			bool __result = IsAllBlank (jlca_css);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_isAllEmpty_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAllEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence...']]"
		[Register ("isAllEmpty", "([Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAllEmpty (params global::Java.Lang.ICharSequence[] css)
		{
			if (id_isAllEmpty_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_isAllEmpty_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAllEmpty", "([Ljava/lang/CharSequence;)Z");
			IntPtr native_css = JNIEnv.NewArray (css);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_css);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAllEmpty_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				if (css != null) {
					JNIEnv.CopyArray (native_css, css);
					JNIEnv.DeleteLocalRef (native_css);
				}
			}
		}

		public static bool IsAllEmpty (params string[] css)
		{
			var jlca_css = CharSequence.ArrayFromStringArray(css);
			bool __result = IsAllEmpty (jlca_css);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_isAllLowerCase_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAllLowerCase' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isAllLowerCase", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAllLowerCase (global::Java.Lang.ICharSequence cs)
		{
			if (id_isAllLowerCase_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isAllLowerCase_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAllLowerCase", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAllLowerCase_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsAllLowerCase (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsAllLowerCase (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isAllUpperCase_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAllUpperCase' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isAllUpperCase", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAllUpperCase (global::Java.Lang.ICharSequence cs)
		{
			if (id_isAllUpperCase_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isAllUpperCase_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAllUpperCase", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAllUpperCase_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsAllUpperCase (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsAllUpperCase (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isAlpha_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAlpha' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isAlpha", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAlpha (global::Java.Lang.ICharSequence cs)
		{
			if (id_isAlpha_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isAlpha_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAlpha", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAlpha_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsAlpha (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsAlpha (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isAlphaSpace_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAlphaSpace' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isAlphaSpace", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAlphaSpace (global::Java.Lang.ICharSequence cs)
		{
			if (id_isAlphaSpace_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isAlphaSpace_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAlphaSpace", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAlphaSpace_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsAlphaSpace (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsAlphaSpace (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isAlphanumeric_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAlphanumeric' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isAlphanumeric", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAlphanumeric (global::Java.Lang.ICharSequence cs)
		{
			if (id_isAlphanumeric_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isAlphanumeric_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAlphanumeric", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAlphanumeric_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsAlphanumeric (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsAlphanumeric (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isAlphanumericSpace_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAlphanumericSpace' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isAlphanumericSpace", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAlphanumericSpace (global::Java.Lang.ICharSequence cs)
		{
			if (id_isAlphanumericSpace_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isAlphanumericSpace_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAlphanumericSpace", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAlphanumericSpace_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsAlphanumericSpace (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsAlphanumericSpace (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isAnyBlank_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAnyBlank' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence...']]"
		[Register ("isAnyBlank", "([Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAnyBlank (params global::Java.Lang.ICharSequence[] css)
		{
			if (id_isAnyBlank_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_isAnyBlank_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAnyBlank", "([Ljava/lang/CharSequence;)Z");
			IntPtr native_css = JNIEnv.NewArray (css);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_css);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAnyBlank_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				if (css != null) {
					JNIEnv.CopyArray (native_css, css);
					JNIEnv.DeleteLocalRef (native_css);
				}
			}
		}

		public static bool IsAnyBlank (params string[] css)
		{
			var jlca_css = CharSequence.ArrayFromStringArray(css);
			bool __result = IsAnyBlank (jlca_css);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_isAnyEmpty_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAnyEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence...']]"
		[Register ("isAnyEmpty", "([Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAnyEmpty (params global::Java.Lang.ICharSequence[] css)
		{
			if (id_isAnyEmpty_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_isAnyEmpty_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAnyEmpty", "([Ljava/lang/CharSequence;)Z");
			IntPtr native_css = JNIEnv.NewArray (css);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_css);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAnyEmpty_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				if (css != null) {
					JNIEnv.CopyArray (native_css, css);
					JNIEnv.DeleteLocalRef (native_css);
				}
			}
		}

		public static bool IsAnyEmpty (params string[] css)
		{
			var jlca_css = CharSequence.ArrayFromStringArray(css);
			bool __result = IsAnyEmpty (jlca_css);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_isAsciiPrintable_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isAsciiPrintable' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isAsciiPrintable", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsAsciiPrintable (global::Java.Lang.ICharSequence cs)
		{
			if (id_isAsciiPrintable_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isAsciiPrintable_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isAsciiPrintable", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAsciiPrintable_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsAsciiPrintable (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsAsciiPrintable (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isBlank_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isBlank' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isBlank", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsBlank (global::Java.Lang.ICharSequence cs)
		{
			if (id_isBlank_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isBlank_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isBlank", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBlank_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsBlank (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsBlank (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isEmpty_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isEmpty", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsEmpty (global::Java.Lang.ICharSequence cs)
		{
			if (id_isEmpty_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isEmpty_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsEmpty (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsEmpty (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isMixedCase_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isMixedCase' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isMixedCase", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsMixedCase (global::Java.Lang.ICharSequence cs)
		{
			if (id_isMixedCase_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isMixedCase_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isMixedCase", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMixedCase_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsMixedCase (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsMixedCase (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isNoneBlank_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isNoneBlank' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence...']]"
		[Register ("isNoneBlank", "([Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsNoneBlank (params global::Java.Lang.ICharSequence[] css)
		{
			if (id_isNoneBlank_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_isNoneBlank_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isNoneBlank", "([Ljava/lang/CharSequence;)Z");
			IntPtr native_css = JNIEnv.NewArray (css);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_css);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNoneBlank_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				if (css != null) {
					JNIEnv.CopyArray (native_css, css);
					JNIEnv.DeleteLocalRef (native_css);
				}
			}
		}

		public static bool IsNoneBlank (params string[] css)
		{
			var jlca_css = CharSequence.ArrayFromStringArray(css);
			bool __result = IsNoneBlank (jlca_css);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_isNoneEmpty_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isNoneEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence...']]"
		[Register ("isNoneEmpty", "([Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsNoneEmpty (params global::Java.Lang.ICharSequence[] css)
		{
			if (id_isNoneEmpty_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_isNoneEmpty_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isNoneEmpty", "([Ljava/lang/CharSequence;)Z");
			IntPtr native_css = JNIEnv.NewArray (css);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_css);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNoneEmpty_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				if (css != null) {
					JNIEnv.CopyArray (native_css, css);
					JNIEnv.DeleteLocalRef (native_css);
				}
			}
		}

		public static bool IsNoneEmpty (params string[] css)
		{
			var jlca_css = CharSequence.ArrayFromStringArray(css);
			bool __result = IsNoneEmpty (jlca_css);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_isNotBlank_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isNotBlank' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isNotBlank", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsNotBlank (global::Java.Lang.ICharSequence cs)
		{
			if (id_isNotBlank_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isNotBlank_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isNotBlank", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotBlank_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsNotBlank (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsNotBlank (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isNotEmpty_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isNotEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isNotEmpty", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsNotEmpty (global::Java.Lang.ICharSequence cs)
		{
			if (id_isNotEmpty_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isNotEmpty_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isNotEmpty", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotEmpty_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsNotEmpty (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsNotEmpty (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isNumeric_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isNumeric' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isNumeric", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsNumeric (global::Java.Lang.ICharSequence cs)
		{
			if (id_isNumeric_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isNumeric_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isNumeric", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNumeric_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsNumeric (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsNumeric (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isNumericSpace_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isNumericSpace' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isNumericSpace", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsNumericSpace (global::Java.Lang.ICharSequence cs)
		{
			if (id_isNumericSpace_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isNumericSpace_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isNumericSpace", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNumericSpace_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsNumericSpace (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsNumericSpace (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isWhitespace_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='isWhitespace' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isWhitespace", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsWhitespace (global::Java.Lang.ICharSequence cs)
		{
			if (id_isWhitespace_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isWhitespace_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isWhitespace", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isWhitespace_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsWhitespace (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsWhitespace (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_join_arrayBC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='char']]"
		[Register ("join", "([BC)Ljava/lang/String;", "")]
		public static unsafe string Join (byte[] array, char separator)
		{
			if (id_join_arrayBC == IntPtr.Zero)
				id_join_arrayBC = JNIEnv.GetStaticMethodID (class_ref, "join", "([BC)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayBC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayBCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='char'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "([BCII)Ljava/lang/String;", "")]
		public static unsafe string Join (byte[] array, char separator, int startIndex, int endIndex)
		{
			if (id_join_arrayBCII == IntPtr.Zero)
				id_join_arrayBCII = JNIEnv.GetStaticMethodID (class_ref, "join", "([BCII)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayBCII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayCC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char']]"
		[Register ("join", "([CC)Ljava/lang/String;", "")]
		public static unsafe string Join (char[] array, char separator)
		{
			if (id_join_arrayCC == IntPtr.Zero)
				id_join_arrayCC = JNIEnv.GetStaticMethodID (class_ref, "join", "([CC)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayCC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayCCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='char[]'] and parameter[2][@type='char'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "([CCII)Ljava/lang/String;", "")]
		public static unsafe string Join (char[] array, char separator, int startIndex, int endIndex)
		{
			if (id_join_arrayCCII == IntPtr.Zero)
				id_join_arrayCCII = JNIEnv.GetStaticMethodID (class_ref, "join", "([CCII)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayCCII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayDC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='char']]"
		[Register ("join", "([DC)Ljava/lang/String;", "")]
		public static unsafe string Join (double[] array, char separator)
		{
			if (id_join_arrayDC == IntPtr.Zero)
				id_join_arrayDC = JNIEnv.GetStaticMethodID (class_ref, "join", "([DC)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayDC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayDCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='double[]'] and parameter[2][@type='char'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "([DCII)Ljava/lang/String;", "")]
		public static unsafe string Join (double[] array, char separator, int startIndex, int endIndex)
		{
			if (id_join_arrayDCII == IntPtr.Zero)
				id_join_arrayDCII = JNIEnv.GetStaticMethodID (class_ref, "join", "([DCII)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayDCII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayFC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='char']]"
		[Register ("join", "([FC)Ljava/lang/String;", "")]
		public static unsafe string Join (float[] array, char separator)
		{
			if (id_join_arrayFC == IntPtr.Zero)
				id_join_arrayFC = JNIEnv.GetStaticMethodID (class_ref, "join", "([FC)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayFC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayFCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='char'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "([FCII)Ljava/lang/String;", "")]
		public static unsafe string Join (float[] array, char separator, int startIndex, int endIndex)
		{
			if (id_join_arrayFCII == IntPtr.Zero)
				id_join_arrayFCII = JNIEnv.GetStaticMethodID (class_ref, "join", "([FCII)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayFCII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayIC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='char']]"
		[Register ("join", "([IC)Ljava/lang/String;", "")]
		public static unsafe string Join (int[] array, char separator)
		{
			if (id_join_arrayIC == IntPtr.Zero)
				id_join_arrayIC = JNIEnv.GetStaticMethodID (class_ref, "join", "([IC)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayIC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayICII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='char'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "([ICII)Ljava/lang/String;", "")]
		public static unsafe string Join (int[] array, char separator, int startIndex, int endIndex)
		{
			if (id_join_arrayICII == IntPtr.Zero)
				id_join_arrayICII = JNIEnv.GetStaticMethodID (class_ref, "join", "([ICII)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayICII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_Ljava_lang_Iterable_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;?&gt;'] and parameter[2][@type='char']]"
		[Register ("join", "(Ljava/lang/Iterable;C)Ljava/lang/String;", "")]
		public static unsafe string Join (global::Java.Lang.IIterable iterable, char separator)
		{
			if (id_join_Ljava_lang_Iterable_C == IntPtr.Zero)
				id_join_Ljava_lang_Iterable_C = JNIEnv.GetStaticMethodID (class_ref, "join", "(Ljava/lang/Iterable;C)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (iterable);
				__args [1] = new JValue (separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_Ljava_lang_Iterable_C, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_join_Ljava_lang_Iterable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("join", "(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Join (global::Java.Lang.IIterable iterable, string separator)
		{
			if (id_join_Ljava_lang_Iterable_Ljava_lang_String_ == IntPtr.Zero)
				id_join_Ljava_lang_Iterable_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "join", "(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (iterable);
				__args [1] = new JValue (native_separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_Ljava_lang_Iterable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_join_arrayLjava_lang_Object_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='char']]"
		[Register ("join", "([Ljava/lang/Object;C)Ljava/lang/String;", "")]
		public static unsafe string Join (global::Java.Lang.Object[] array, char separator)
		{
			if (id_join_arrayLjava_lang_Object_C == IntPtr.Zero)
				id_join_arrayLjava_lang_Object_C = JNIEnv.GetStaticMethodID (class_ref, "join", "([Ljava/lang/Object;C)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayLjava_lang_Object_C, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayLjava_lang_Object_CII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='char'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "([Ljava/lang/Object;CII)Ljava/lang/String;", "")]
		public static unsafe string Join (global::Java.Lang.Object[] array, char separator, int startIndex, int endIndex)
		{
			if (id_join_arrayLjava_lang_Object_CII == IntPtr.Zero)
				id_join_arrayLjava_lang_Object_CII = JNIEnv.GetStaticMethodID (class_ref, "join", "([Ljava/lang/Object;CII)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayLjava_lang_Object_CII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayLjava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("join", "([Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Join (global::Java.Lang.Object[] array, string separator)
		{
			if (id_join_arrayLjava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_join_arrayLjava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "join", "([Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayLjava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_join_arrayLjava_lang_Object_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "([Ljava/lang/Object;Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string Join (global::Java.Lang.Object[] array, string separator, int startIndex, int endIndex)
		{
			if (id_join_arrayLjava_lang_Object_Ljava_lang_String_II == IntPtr.Zero)
				id_join_arrayLjava_lang_Object_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "join", "([Ljava/lang/Object;Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayLjava_lang_Object_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_join_Ljava_util_Iterator_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;?&gt;'] and parameter[2][@type='char']]"
		[Register ("join", "(Ljava/util/Iterator;C)Ljava/lang/String;", "")]
		public static unsafe string Join (global::Java.Util.IIterator iterator, char separator)
		{
			if (id_join_Ljava_util_Iterator_C == IntPtr.Zero)
				id_join_Ljava_util_Iterator_C = JNIEnv.GetStaticMethodID (class_ref, "join", "(Ljava/util/Iterator;C)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (iterator);
				__args [1] = new JValue (separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_Ljava_util_Iterator_C, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_join_Ljava_util_Iterator_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("join", "(Ljava/util/Iterator;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Join (global::Java.Util.IIterator iterator, string separator)
		{
			if (id_join_Ljava_util_Iterator_Ljava_lang_String_ == IntPtr.Zero)
				id_join_Ljava_util_Iterator_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "join", "(Ljava/util/Iterator;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (iterator);
				__args [1] = new JValue (native_separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_Ljava_util_Iterator_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_join_Ljava_util_List_CII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='java.util.List&lt;?&gt;'] and parameter[2][@type='char'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "(Ljava/util/List;CII)Ljava/lang/String;", "")]
		public static unsafe string Join (global::System.Collections.Generic.IList<object> list, char separator, int startIndex, int endIndex)
		{
			if (id_join_Ljava_util_List_CII == IntPtr.Zero)
				id_join_Ljava_util_List_CII = JNIEnv.GetStaticMethodID (class_ref, "join", "(Ljava/util/List;CII)Ljava/lang/String;");
			IntPtr native_list = global::Android.Runtime.JavaList<object>.ToLocalJniHandle (list);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_list);
				__args [1] = new JValue (separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_Ljava_util_List_CII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
			}
		}

		static IntPtr id_join_Ljava_util_List_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='java.util.List&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "(Ljava/util/List;Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string Join (global::System.Collections.Generic.IList<object> list, string separator, int startIndex, int endIndex)
		{
			if (id_join_Ljava_util_List_Ljava_lang_String_II == IntPtr.Zero)
				id_join_Ljava_util_List_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "join", "(Ljava/util/List;Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native_list = global::Android.Runtime.JavaList<object>.ToLocalJniHandle (list);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_list);
				__args [1] = new JValue (native_separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_Ljava_util_List_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_join_arrayJC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='char']]"
		[Register ("join", "([JC)Ljava/lang/String;", "")]
		public static unsafe string Join (long[] array, char separator)
		{
			if (id_join_arrayJC == IntPtr.Zero)
				id_join_arrayJC = JNIEnv.GetStaticMethodID (class_ref, "join", "([JC)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayJC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayJCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='long[]'] and parameter[2][@type='char'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "([JCII)Ljava/lang/String;", "")]
		public static unsafe string Join (long[] array, char separator, int startIndex, int endIndex)
		{
			if (id_join_arrayJCII == IntPtr.Zero)
				id_join_arrayJCII = JNIEnv.GetStaticMethodID (class_ref, "join", "([JCII)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayJCII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arraySC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='char']]"
		[Register ("join", "([SC)Ljava/lang/String;", "")]
		public static unsafe string Join (short[] array, char separator)
		{
			if (id_join_arraySC == IntPtr.Zero)
				id_join_arraySC = JNIEnv.GetStaticMethodID (class_ref, "join", "([SC)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arraySC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arraySCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=4 and parameter[1][@type='short[]'] and parameter[2][@type='char'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("join", "([SCII)Ljava/lang/String;", "")]
		public static unsafe string Join (short[] array, char separator, int startIndex, int endIndex)
		{
			if (id_join_arraySCII == IntPtr.Zero)
				id_join_arraySCII = JNIEnv.GetStaticMethodID (class_ref, "join", "([SCII)Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (separator);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arraySCII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_join_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='join' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("join", "([Ljava/lang/Object;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe string Join (params global::Java.Lang.Object[] elements)
		{
			if (id_join_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_join_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "join", "([Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_elements = JNIEnv.NewArray (elements);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_elements);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (elements != null) {
					JNIEnv.CopyArray (native_elements, elements);
					JNIEnv.DeleteLocalRef (native_elements);
				}
			}
		}

		static IntPtr id_joinWith_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='joinWith' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("joinWith", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string JoinWith (string separator, params global::Java.Lang.Object[] objects)
		{
			if (id_joinWith_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_joinWith_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "joinWith", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_separator = JNIEnv.NewString (separator);
			IntPtr native_objects = JNIEnv.NewArray (objects);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_separator);
				__args [1] = new JValue (native_objects);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_joinWith_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_separator);
				if (objects != null) {
					JNIEnv.CopyArray (native_objects, objects);
					JNIEnv.DeleteLocalRef (native_objects);
				}
			}
		}

		static IntPtr id_lastIndexOf_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int']]"
		[Register ("lastIndexOf", "(Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int LastIndexOf (global::Java.Lang.ICharSequence seq, int searchChar)
		{
			if (id_lastIndexOf_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_lastIndexOf_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "(Ljava/lang/CharSequence;I)I");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (searchChar);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
			}
		}

		public static int LastIndexOf (string seq, int searchChar)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			int __result = LastIndexOf (jls_seq, searchChar);
			var __rsval = __result;
			jls_seq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_lastIndexOf_Ljava_lang_CharSequence_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "(Ljava/lang/CharSequence;II)I", "")]
		public static unsafe int LastIndexOf (global::Java.Lang.ICharSequence seq, int searchChar, int startPos)
		{
			if (id_lastIndexOf_Ljava_lang_CharSequence_II == IntPtr.Zero)
				id_lastIndexOf_Ljava_lang_CharSequence_II = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "(Ljava/lang/CharSequence;II)I");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (searchChar);
				__args [2] = new JValue (startPos);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_Ljava_lang_CharSequence_II, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
			}
		}

		public static int LastIndexOf (string seq, int searchChar, int startPos)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			int __result = LastIndexOf (jls_seq, searchChar, startPos);
			var __rsval = __result;
			jls_seq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_lastIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("lastIndexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int LastIndexOf (global::Java.Lang.ICharSequence seq, global::Java.Lang.ICharSequence searchSeq)
		{
			if (id_lastIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_lastIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			IntPtr native_searchSeq = CharSequence.ToLocalJniHandle (searchSeq);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (native_searchSeq);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
				JNIEnv.DeleteLocalRef (native_searchSeq);
			}
		}

		public static int LastIndexOf (string seq, string searchSeq)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			var jls_searchSeq = searchSeq == null ? null : new global::Java.Lang.String (searchSeq);
			int __result = LastIndexOf (jls_seq, jls_searchSeq);
			var __rsval = __result;
			jls_seq?.Dispose ();
			jls_searchSeq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_lastIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int LastIndexOf (global::Java.Lang.ICharSequence seq, global::Java.Lang.ICharSequence searchSeq, int startPos)
		{
			if (id_lastIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_lastIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			IntPtr native_searchSeq = CharSequence.ToLocalJniHandle (searchSeq);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (native_searchSeq);
				__args [2] = new JValue (startPos);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
				JNIEnv.DeleteLocalRef (native_searchSeq);
			}
		}

		public static int LastIndexOf (string seq, string searchSeq, int startPos)
		{
			var jls_seq = seq == null ? null : new global::Java.Lang.String (seq);
			var jls_searchSeq = searchSeq == null ? null : new global::Java.Lang.String (searchSeq);
			int __result = LastIndexOf (jls_seq, jls_searchSeq, startPos);
			var __rsval = __result;
			jls_seq?.Dispose ();
			jls_searchSeq?.Dispose ();
			return __rsval;
		}

		static IntPtr id_lastIndexOfAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='lastIndexOfAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence...']]"
		[Register ("lastIndexOfAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)I", "")]
		public static unsafe int LastIndexOfAny (global::Java.Lang.ICharSequence str, params global::Java.Lang.ICharSequence[] searchStrs)
		{
			if (id_lastIndexOfAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_lastIndexOfAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOfAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_searchStrs = JNIEnv.NewArray (searchStrs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_searchStrs);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOfAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (searchStrs != null) {
					JNIEnv.CopyArray (native_searchStrs, searchStrs);
					JNIEnv.DeleteLocalRef (native_searchStrs);
				}
			}
		}

		public static int LastIndexOfAny (string str, params string[] searchStrs)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jlca_searchStrs = CharSequence.ArrayFromStringArray(searchStrs);
			int __result = LastIndexOfAny (jls_str, jlca_searchStrs);
			var __rsval = __result;
			jls_str?.Dispose ();
			return __rsval;
		}

		static IntPtr id_lastIndexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='lastIndexOfIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("lastIndexOfIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int LastIndexOfIgnoreCase (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence searchStr)
		{
			if (id_lastIndexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_lastIndexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOfIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_searchStr = CharSequence.ToLocalJniHandle (searchStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_searchStr);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_searchStr);
			}
		}

		public static int LastIndexOfIgnoreCase (string str, string searchStr)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_searchStr = searchStr == null ? null : new global::Java.Lang.String (searchStr);
			int __result = LastIndexOfIgnoreCase (jls_str, jls_searchStr);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_searchStr?.Dispose ();
			return __rsval;
		}

		static IntPtr id_lastIndexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='lastIndexOfIgnoreCase' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='int']]"
		[Register ("lastIndexOfIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int LastIndexOfIgnoreCase (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence searchStr, int startPos)
		{
			if (id_lastIndexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_lastIndexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOfIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_searchStr = CharSequence.ToLocalJniHandle (searchStr);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_searchStr);
				__args [2] = new JValue (startPos);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOfIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_searchStr);
			}
		}

		public static int LastIndexOfIgnoreCase (string str, string searchStr, int startPos)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_searchStr = searchStr == null ? null : new global::Java.Lang.String (searchStr);
			int __result = LastIndexOfIgnoreCase (jls_str, jls_searchStr, startPos);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_searchStr?.Dispose ();
			return __rsval;
		}

		static IntPtr id_lastOrdinalIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='lastOrdinalIndexOf' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='int']]"
		[Register ("lastOrdinalIndexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int LastOrdinalIndexOf (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence searchStr, int ordinal)
		{
			if (id_lastOrdinalIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_lastOrdinalIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "lastOrdinalIndexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_searchStr = CharSequence.ToLocalJniHandle (searchStr);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_searchStr);
				__args [2] = new JValue (ordinal);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastOrdinalIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_searchStr);
			}
		}

		public static int LastOrdinalIndexOf (string str, string searchStr, int ordinal)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_searchStr = searchStr == null ? null : new global::Java.Lang.String (searchStr);
			int __result = LastOrdinalIndexOf (jls_str, jls_searchStr, ordinal);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_searchStr?.Dispose ();
			return __rsval;
		}

		static IntPtr id_left_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='left' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("left", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Left (string str, int len)
		{
			if (id_left_Ljava_lang_String_I == IntPtr.Zero)
				id_left_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "left", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (len);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_left_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_leftPad_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='leftPad' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("leftPad", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string LeftPad (string str, int size)
		{
			if (id_leftPad_Ljava_lang_String_I == IntPtr.Zero)
				id_leftPad_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "leftPad", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (size);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_leftPad_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_leftPad_Ljava_lang_String_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='leftPad' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("leftPad", "(Ljava/lang/String;IC)Ljava/lang/String;", "")]
		public static unsafe string LeftPad (string str, int size, char padChar)
		{
			if (id_leftPad_Ljava_lang_String_IC == IntPtr.Zero)
				id_leftPad_Ljava_lang_String_IC = JNIEnv.GetStaticMethodID (class_ref, "leftPad", "(Ljava/lang/String;IC)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (size);
				__args [2] = new JValue (padChar);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_leftPad_Ljava_lang_String_IC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_leftPad_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='leftPad' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("leftPad", "(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string LeftPad (string str, int size, string padStr)
		{
			if (id_leftPad_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_leftPad_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "leftPad", "(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_padStr = JNIEnv.NewString (padStr);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (size);
				__args [2] = new JValue (native_padStr);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_leftPad_Ljava_lang_String_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_padStr);
			}
		}

		static IntPtr id_length_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='length' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("length", "(Ljava/lang/CharSequence;)I", "")]
		public static unsafe int Length (global::Java.Lang.ICharSequence cs)
		{
			if (id_length_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_length_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "length", "(Ljava/lang/CharSequence;)I");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_length_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static int Length (string cs)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			int __result = Length (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_lowerCase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='lowerCase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lowerCase", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string LowerCase (string str)
		{
			if (id_lowerCase_Ljava_lang_String_ == IntPtr.Zero)
				id_lowerCase_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "lowerCase", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_lowerCase_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_lowerCase_Ljava_lang_String_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='lowerCase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Locale']]"
		[Register ("lowerCase", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string LowerCase (string str, global::Java.Util.Locale locale)
		{
			if (id_lowerCase_Ljava_lang_String_Ljava_util_Locale_ == IntPtr.Zero)
				id_lowerCase_Ljava_lang_String_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "lowerCase", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_lowerCase_Ljava_lang_String_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_mid_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='mid' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("mid", "(Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string Mid (string str, int pos, int len)
		{
			if (id_mid_Ljava_lang_String_II == IntPtr.Zero)
				id_mid_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "mid", "(Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (pos);
				__args [2] = new JValue (len);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_mid_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_normalizeSpace_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='normalizeSpace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalizeSpace", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string NormalizeSpace (string str)
		{
			if (id_normalizeSpace_Ljava_lang_String_ == IntPtr.Zero)
				id_normalizeSpace_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "normalizeSpace", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_normalizeSpace_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_ordinalIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='ordinalIndexOf' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='int']]"
		[Register ("ordinalIndexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int OrdinalIndexOf (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence searchStr, int ordinal)
		{
			if (id_ordinalIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_ordinalIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "ordinalIndexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_searchStr = CharSequence.ToLocalJniHandle (searchStr);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_searchStr);
				__args [2] = new JValue (ordinal);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_ordinalIndexOf_Ljava_lang_CharSequence_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_searchStr);
			}
		}

		public static int OrdinalIndexOf (string str, string searchStr, int ordinal)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_searchStr = searchStr == null ? null : new global::Java.Lang.String (searchStr);
			int __result = OrdinalIndexOf (jls_str, jls_searchStr, ordinal);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_searchStr?.Dispose ();
			return __rsval;
		}

		static IntPtr id_overlay_Ljava_lang_String_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='overlay' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("overlay", "(Ljava/lang/String;Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string Overlay (string str, string overlay, int start, int end)
		{
			if (id_overlay_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
				id_overlay_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "overlay", "(Ljava/lang/String;Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_overlay = JNIEnv.NewString (overlay);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_overlay);
				__args [2] = new JValue (start);
				__args [3] = new JValue (end);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_overlay_Ljava_lang_String_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_overlay);
			}
		}

		static IntPtr id_prependIfMissing_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='prependIfMissing' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.CharSequence...']]"
		[Register ("prependIfMissing", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;", "")]
		public static unsafe string PrependIfMissing (string str, global::Java.Lang.ICharSequence prefix, params global::Java.Lang.ICharSequence[] prefixes)
		{
			if (id_prependIfMissing_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_prependIfMissing_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "prependIfMissing", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_prefix = CharSequence.ToLocalJniHandle (prefix);
			IntPtr native_prefixes = JNIEnv.NewArray (prefixes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_prefix);
				__args [2] = new JValue (native_prefixes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_prependIfMissing_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_prefix);
				if (prefixes != null) {
					JNIEnv.CopyArray (native_prefixes, prefixes);
					JNIEnv.DeleteLocalRef (native_prefixes);
				}
			}
		}

		public static string PrependIfMissing (string str, string prefix, params string[] prefixes)
		{
			var jls_prefix = prefix == null ? null : new global::Java.Lang.String (prefix);
			var jlca_prefixes = CharSequence.ArrayFromStringArray(prefixes);
			string __result = PrependIfMissing (str, jls_prefix, jlca_prefixes);
			var __rsval = __result;
			jls_prefix?.Dispose ();
			return __rsval;
		}

		static IntPtr id_prependIfMissingIgnoreCase_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='prependIfMissingIgnoreCase' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.CharSequence...']]"
		[Register ("prependIfMissingIgnoreCase", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;", "")]
		public static unsafe string PrependIfMissingIgnoreCase (string str, global::Java.Lang.ICharSequence prefix, params global::Java.Lang.ICharSequence[] prefixes)
		{
			if (id_prependIfMissingIgnoreCase_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_prependIfMissingIgnoreCase_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "prependIfMissingIgnoreCase", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_prefix = CharSequence.ToLocalJniHandle (prefix);
			IntPtr native_prefixes = JNIEnv.NewArray (prefixes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_prefix);
				__args [2] = new JValue (native_prefixes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_prependIfMissingIgnoreCase_Ljava_lang_String_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_prefix);
				if (prefixes != null) {
					JNIEnv.CopyArray (native_prefixes, prefixes);
					JNIEnv.DeleteLocalRef (native_prefixes);
				}
			}
		}

		public static string PrependIfMissingIgnoreCase (string str, string prefix, params string[] prefixes)
		{
			var jls_prefix = prefix == null ? null : new global::Java.Lang.String (prefix);
			var jlca_prefixes = CharSequence.ArrayFromStringArray(prefixes);
			string __result = PrependIfMissingIgnoreCase (str, jls_prefix, jlca_prefixes);
			var __rsval = __result;
			jls_prefix?.Dispose ();
			return __rsval;
		}

		static IntPtr id_remove_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("remove", "(Ljava/lang/String;C)Ljava/lang/String;", "")]
		public static unsafe string Remove (string str, char @remove)
		{
			if (id_remove_Ljava_lang_String_C == IntPtr.Zero)
				id_remove_Ljava_lang_String_C = JNIEnv.GetStaticMethodID (class_ref, "remove", "(Ljava/lang/String;C)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (@remove);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_Ljava_lang_String_C, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_remove_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Remove (string str, string @remove)
		{
			if (id_remove_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "remove", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native__remove = JNIEnv.NewString (@remove);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native__remove);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native__remove);
			}
		}

		static IntPtr id_removeAll_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
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

		static IntPtr id_removeEnd_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='removeEnd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeEnd", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveEnd (string str, string @remove)
		{
			if (id_removeEnd_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeEnd_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeEnd", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native__remove = JNIEnv.NewString (@remove);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native__remove);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeEnd_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native__remove);
			}
		}

		static IntPtr id_removeEndIgnoreCase_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='removeEndIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeEndIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveEndIgnoreCase (string str, string @remove)
		{
			if (id_removeEndIgnoreCase_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeEndIgnoreCase_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeEndIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native__remove = JNIEnv.NewString (@remove);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native__remove);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeEndIgnoreCase_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native__remove);
			}
		}

		static IntPtr id_removeFirst_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='removeFirst' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
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

		static IntPtr id_removeIgnoreCase_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='removeIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveIgnoreCase (string str, string @remove)
		{
			if (id_removeIgnoreCase_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeIgnoreCase_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native__remove = JNIEnv.NewString (@remove);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native__remove);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeIgnoreCase_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native__remove);
			}
		}

		static IntPtr id_removePattern_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='removePattern' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("removePattern", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemovePattern (string source, string regex)
		{
			if (id_removePattern_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removePattern_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removePattern", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_source = JNIEnv.NewString (source);
			IntPtr native_regex = JNIEnv.NewString (regex);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_source);
				__args [1] = new JValue (native_regex);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removePattern_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
				JNIEnv.DeleteLocalRef (native_regex);
			}
		}

		static IntPtr id_removeStart_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='removeStart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeStart", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveStart (string str, string @remove)
		{
			if (id_removeStart_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeStart_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeStart", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native__remove = JNIEnv.NewString (@remove);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native__remove);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeStart_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native__remove);
			}
		}

		static IntPtr id_removeStartIgnoreCase_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='removeStartIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeStartIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveStartIgnoreCase (string str, string @remove)
		{
			if (id_removeStartIgnoreCase_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeStartIgnoreCase_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeStartIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native__remove = JNIEnv.NewString (@remove);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native__remove);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeStartIgnoreCase_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native__remove);
			}
		}

		static IntPtr id_repeat_CI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='repeat' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='int']]"
		[Register ("repeat", "(CI)Ljava/lang/String;", "")]
		public static unsafe string Repeat (char ch, int repeat)
		{
			if (id_repeat_CI == IntPtr.Zero)
				id_repeat_CI = JNIEnv.GetStaticMethodID (class_ref, "repeat", "(CI)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ch);
				__args [1] = new JValue (repeat);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_repeat_CI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_repeat_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='repeat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("repeat", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Repeat (string str, int repeat)
		{
			if (id_repeat_Ljava_lang_String_I == IntPtr.Zero)
				id_repeat_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "repeat", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (repeat);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_repeat_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_repeat_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='repeat' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("repeat", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Repeat (string str, string separator, int repeat)
		{
			if (id_repeat_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_repeat_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "repeat", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separator);
				__args [2] = new JValue (repeat);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_repeat_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_replace_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replace' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("replace", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Replace (string text, string searchString, string replacement)
		{
			if (id_replace_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replace_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replace", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_searchString = JNIEnv.NewString (searchString);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_searchString);
				__args [2] = new JValue (native_replacement);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replace_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_searchString);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_replace_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replace' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("replace", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Replace (string text, string searchString, string replacement, int max)
		{
			if (id_replace_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_replace_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "replace", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_searchString = JNIEnv.NewString (searchString);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_searchString);
				__args [2] = new JValue (native_replacement);
				__args [3] = new JValue (max);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replace_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_searchString);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_replaceAll_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replaceAll' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
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

		static IntPtr id_replaceChars_Ljava_lang_String_CC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replaceChars' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char'] and parameter[3][@type='char']]"
		[Register ("replaceChars", "(Ljava/lang/String;CC)Ljava/lang/String;", "")]
		public static unsafe string ReplaceChars (string str, char searchChar, char replaceChar)
		{
			if (id_replaceChars_Ljava_lang_String_CC == IntPtr.Zero)
				id_replaceChars_Ljava_lang_String_CC = JNIEnv.GetStaticMethodID (class_ref, "replaceChars", "(Ljava/lang/String;CC)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (searchChar);
				__args [2] = new JValue (replaceChar);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceChars_Ljava_lang_String_CC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_replaceChars_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replaceChars' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("replaceChars", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceChars (string str, string searchChars, string replaceChars)
		{
			if (id_replaceChars_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceChars_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replaceChars", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_searchChars = JNIEnv.NewString (searchChars);
			IntPtr native_replaceChars = JNIEnv.NewString (replaceChars);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_searchChars);
				__args [2] = new JValue (native_replaceChars);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceChars_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_searchChars);
				JNIEnv.DeleteLocalRef (native_replaceChars);
			}
		}

		static IntPtr id_replaceEach_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replaceEach' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("replaceEach", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceEach (string text, string[] searchList, string[] replacementList)
		{
			if (id_replaceEach_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_replaceEach_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replaceEach", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_searchList = JNIEnv.NewArray (searchList);
			IntPtr native_replacementList = JNIEnv.NewArray (replacementList);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_searchList);
				__args [2] = new JValue (native_replacementList);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceEach_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				if (searchList != null) {
					JNIEnv.CopyArray (native_searchList, searchList);
					JNIEnv.DeleteLocalRef (native_searchList);
				}
				if (replacementList != null) {
					JNIEnv.CopyArray (native_replacementList, replacementList);
					JNIEnv.DeleteLocalRef (native_replacementList);
				}
			}
		}

		static IntPtr id_replaceEachRepeatedly_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replaceEachRepeatedly' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("replaceEachRepeatedly", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceEachRepeatedly (string text, string[] searchList, string[] replacementList)
		{
			if (id_replaceEachRepeatedly_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_replaceEachRepeatedly_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replaceEachRepeatedly", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_searchList = JNIEnv.NewArray (searchList);
			IntPtr native_replacementList = JNIEnv.NewArray (replacementList);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_searchList);
				__args [2] = new JValue (native_replacementList);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceEachRepeatedly_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				if (searchList != null) {
					JNIEnv.CopyArray (native_searchList, searchList);
					JNIEnv.DeleteLocalRef (native_searchList);
				}
				if (replacementList != null) {
					JNIEnv.CopyArray (native_replacementList, replacementList);
					JNIEnv.DeleteLocalRef (native_replacementList);
				}
			}
		}

		static IntPtr id_replaceFirst_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replaceFirst' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
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

		static IntPtr id_replaceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replaceIgnoreCase' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("replaceIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceIgnoreCase (string text, string searchString, string replacement)
		{
			if (id_replaceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replaceIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_searchString = JNIEnv.NewString (searchString);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_searchString);
				__args [2] = new JValue (native_replacement);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_searchString);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_replaceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replaceIgnoreCase' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("replaceIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string ReplaceIgnoreCase (string text, string searchString, string replacement, int max)
		{
			if (id_replaceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_replaceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "replaceIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_searchString = JNIEnv.NewString (searchString);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_searchString);
				__args [2] = new JValue (native_replacement);
				__args [3] = new JValue (max);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_searchString);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_replaceOnce_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replaceOnce' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("replaceOnce", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceOnce (string text, string searchString, string replacement)
		{
			if (id_replaceOnce_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceOnce_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replaceOnce", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_searchString = JNIEnv.NewString (searchString);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_searchString);
				__args [2] = new JValue (native_replacement);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceOnce_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_searchString);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_replaceOnceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replaceOnceIgnoreCase' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("replaceOnceIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceOnceIgnoreCase (string text, string searchString, string replacement)
		{
			if (id_replaceOnceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceOnceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replaceOnceIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_searchString = JNIEnv.NewString (searchString);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_searchString);
				__args [2] = new JValue (native_replacement);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceOnceIgnoreCase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_searchString);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_replacePattern_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='replacePattern' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("replacePattern", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplacePattern (string source, string regex, string replacement)
		{
			if (id_replacePattern_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replacePattern_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replacePattern", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_source = JNIEnv.NewString (source);
			IntPtr native_regex = JNIEnv.NewString (regex);
			IntPtr native_replacement = JNIEnv.NewString (replacement);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_source);
				__args [1] = new JValue (native_regex);
				__args [2] = new JValue (native_replacement);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replacePattern_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
				JNIEnv.DeleteLocalRef (native_regex);
				JNIEnv.DeleteLocalRef (native_replacement);
			}
		}

		static IntPtr id_reverse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reverse", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Reverse (string str)
		{
			if (id_reverse_Ljava_lang_String_ == IntPtr.Zero)
				id_reverse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reverse", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_reverse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_reverseDelimited_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='reverseDelimited' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("reverseDelimited", "(Ljava/lang/String;C)Ljava/lang/String;", "")]
		public static unsafe string ReverseDelimited (string str, char separatorChar)
		{
			if (id_reverseDelimited_Ljava_lang_String_C == IntPtr.Zero)
				id_reverseDelimited_Ljava_lang_String_C = JNIEnv.GetStaticMethodID (class_ref, "reverseDelimited", "(Ljava/lang/String;C)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (separatorChar);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_reverseDelimited_Ljava_lang_String_C, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_right_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='right' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("right", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Right (string str, int len)
		{
			if (id_right_Ljava_lang_String_I == IntPtr.Zero)
				id_right_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "right", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (len);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_right_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_rightPad_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='rightPad' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("rightPad", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string RightPad (string str, int size)
		{
			if (id_rightPad_Ljava_lang_String_I == IntPtr.Zero)
				id_rightPad_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "rightPad", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (size);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_rightPad_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_rightPad_Ljava_lang_String_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='rightPad' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("rightPad", "(Ljava/lang/String;IC)Ljava/lang/String;", "")]
		public static unsafe string RightPad (string str, int size, char padChar)
		{
			if (id_rightPad_Ljava_lang_String_IC == IntPtr.Zero)
				id_rightPad_Ljava_lang_String_IC = JNIEnv.GetStaticMethodID (class_ref, "rightPad", "(Ljava/lang/String;IC)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (size);
				__args [2] = new JValue (padChar);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_rightPad_Ljava_lang_String_IC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_rightPad_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='rightPad' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("rightPad", "(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RightPad (string str, int size, string padStr)
		{
			if (id_rightPad_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_rightPad_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "rightPad", "(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_padStr = JNIEnv.NewString (padStr);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (size);
				__args [2] = new JValue (native_padStr);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_rightPad_Ljava_lang_String_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_padStr);
			}
		}

		static IntPtr id_rotate_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='rotate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("rotate", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Rotate (string str, int shift)
		{
			if (id_rotate_Ljava_lang_String_I == IntPtr.Zero)
				id_rotate_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "rotate", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (shift);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_rotate_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_split_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='split' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("split", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] Split (string str)
		{
			if (id_split_Ljava_lang_String_ == IntPtr.Zero)
				id_split_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "split", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_split_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_split_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='split' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("split", "(Ljava/lang/String;C)[Ljava/lang/String;", "")]
		public static unsafe string[] Split (string str, char separatorChar)
		{
			if (id_split_Ljava_lang_String_C == IntPtr.Zero)
				id_split_Ljava_lang_String_C = JNIEnv.GetStaticMethodID (class_ref, "split", "(Ljava/lang/String;C)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (separatorChar);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_split_Ljava_lang_String_C, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_split_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='split' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("split", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] Split (string str, string separatorChars)
		{
			if (id_split_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_split_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "split", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separatorChars = JNIEnv.NewString (separatorChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separatorChars);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_split_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separatorChars);
			}
		}

		static IntPtr id_split_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='split' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("split", "(Ljava/lang/String;Ljava/lang/String;I)[Ljava/lang/String;", "")]
		public static unsafe string[] Split (string str, string separatorChars, int max)
		{
			if (id_split_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_split_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "split", "(Ljava/lang/String;Ljava/lang/String;I)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separatorChars = JNIEnv.NewString (separatorChars);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separatorChars);
				__args [2] = new JValue (max);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_split_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separatorChars);
			}
		}

		static IntPtr id_splitByCharacterType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='splitByCharacterType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("splitByCharacterType", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitByCharacterType (string str)
		{
			if (id_splitByCharacterType_Ljava_lang_String_ == IntPtr.Zero)
				id_splitByCharacterType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "splitByCharacterType", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitByCharacterType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_splitByCharacterTypeCamelCase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='splitByCharacterTypeCamelCase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("splitByCharacterTypeCamelCase", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitByCharacterTypeCamelCase (string str)
		{
			if (id_splitByCharacterTypeCamelCase_Ljava_lang_String_ == IntPtr.Zero)
				id_splitByCharacterTypeCamelCase_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "splitByCharacterTypeCamelCase", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitByCharacterTypeCamelCase_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_splitByWholeSeparator_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='splitByWholeSeparator' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("splitByWholeSeparator", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitByWholeSeparator (string str, string separator)
		{
			if (id_splitByWholeSeparator_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_splitByWholeSeparator_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "splitByWholeSeparator", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separator);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitByWholeSeparator_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_splitByWholeSeparator_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='splitByWholeSeparator' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("splitByWholeSeparator", "(Ljava/lang/String;Ljava/lang/String;I)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitByWholeSeparator (string str, string separator, int max)
		{
			if (id_splitByWholeSeparator_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_splitByWholeSeparator_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "splitByWholeSeparator", "(Ljava/lang/String;Ljava/lang/String;I)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separator);
				__args [2] = new JValue (max);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitByWholeSeparator_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_splitByWholeSeparatorPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='splitByWholeSeparatorPreserveAllTokens' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("splitByWholeSeparatorPreserveAllTokens", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitByWholeSeparatorPreserveAllTokens (string str, string separator)
		{
			if (id_splitByWholeSeparatorPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_splitByWholeSeparatorPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "splitByWholeSeparatorPreserveAllTokens", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separator);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitByWholeSeparatorPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_splitByWholeSeparatorPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='splitByWholeSeparatorPreserveAllTokens' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("splitByWholeSeparatorPreserveAllTokens", "(Ljava/lang/String;Ljava/lang/String;I)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitByWholeSeparatorPreserveAllTokens (string str, string separator, int max)
		{
			if (id_splitByWholeSeparatorPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_splitByWholeSeparatorPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "splitByWholeSeparatorPreserveAllTokens", "(Ljava/lang/String;Ljava/lang/String;I)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separator);
				__args [2] = new JValue (max);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitByWholeSeparatorPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_splitPreserveAllTokens_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='splitPreserveAllTokens' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("splitPreserveAllTokens", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitPreserveAllTokens (string str)
		{
			if (id_splitPreserveAllTokens_Ljava_lang_String_ == IntPtr.Zero)
				id_splitPreserveAllTokens_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "splitPreserveAllTokens", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitPreserveAllTokens_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_splitPreserveAllTokens_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='splitPreserveAllTokens' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("splitPreserveAllTokens", "(Ljava/lang/String;C)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitPreserveAllTokens (string str, char separatorChar)
		{
			if (id_splitPreserveAllTokens_Ljava_lang_String_C == IntPtr.Zero)
				id_splitPreserveAllTokens_Ljava_lang_String_C = JNIEnv.GetStaticMethodID (class_ref, "splitPreserveAllTokens", "(Ljava/lang/String;C)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (separatorChar);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitPreserveAllTokens_Ljava_lang_String_C, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_splitPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='splitPreserveAllTokens' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("splitPreserveAllTokens", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitPreserveAllTokens (string str, string separatorChars)
		{
			if (id_splitPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_splitPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "splitPreserveAllTokens", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separatorChars = JNIEnv.NewString (separatorChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separatorChars);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separatorChars);
			}
		}

		static IntPtr id_splitPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='splitPreserveAllTokens' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("splitPreserveAllTokens", "(Ljava/lang/String;Ljava/lang/String;I)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitPreserveAllTokens (string str, string separatorChars, int max)
		{
			if (id_splitPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_splitPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "splitPreserveAllTokens", "(Ljava/lang/String;Ljava/lang/String;I)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separatorChars = JNIEnv.NewString (separatorChars);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separatorChars);
				__args [2] = new JValue (max);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitPreserveAllTokens_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separatorChars);
			}
		}

		static IntPtr id_startsWith_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='startsWith' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("startsWith", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool StartsWith (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence prefix)
		{
			if (id_startsWith_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_startsWith_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "startsWith", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_prefix = CharSequence.ToLocalJniHandle (prefix);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_prefix);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_startsWith_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		public static bool StartsWith (string str, string prefix)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_prefix = prefix == null ? null : new global::Java.Lang.String (prefix);
			bool __result = StartsWith (jls_str, jls_prefix);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_prefix?.Dispose ();
			return __rsval;
		}

		static IntPtr id_startsWithAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='startsWithAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence...']]"
		[Register ("startsWithAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool StartsWithAny (global::Java.Lang.ICharSequence sequence, params global::Java.Lang.ICharSequence[] searchStrings)
		{
			if (id_startsWithAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_startsWithAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "startsWithAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z");
			IntPtr native_sequence = CharSequence.ToLocalJniHandle (sequence);
			IntPtr native_searchStrings = JNIEnv.NewArray (searchStrings);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_sequence);
				__args [1] = new JValue (native_searchStrings);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_startsWithAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_sequence);
				if (searchStrings != null) {
					JNIEnv.CopyArray (native_searchStrings, searchStrings);
					JNIEnv.DeleteLocalRef (native_searchStrings);
				}
			}
		}

		public static bool StartsWithAny (string sequence, params string[] searchStrings)
		{
			var jls_sequence = sequence == null ? null : new global::Java.Lang.String (sequence);
			var jlca_searchStrings = CharSequence.ArrayFromStringArray(searchStrings);
			bool __result = StartsWithAny (jls_sequence, jlca_searchStrings);
			var __rsval = __result;
			jls_sequence?.Dispose ();
			return __rsval;
		}

		static IntPtr id_startsWithIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='startsWithIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("startsWithIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool StartsWithIgnoreCase (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence prefix)
		{
			if (id_startsWithIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_startsWithIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "startsWithIgnoreCase", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_prefix = CharSequence.ToLocalJniHandle (prefix);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_prefix);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_startsWithIgnoreCase_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		public static bool StartsWithIgnoreCase (string str, string prefix)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			var jls_prefix = prefix == null ? null : new global::Java.Lang.String (prefix);
			bool __result = StartsWithIgnoreCase (jls_str, jls_prefix);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_prefix?.Dispose ();
			return __rsval;
		}

		static IntPtr id_strip_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='strip' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("strip", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Strip (string str)
		{
			if (id_strip_Ljava_lang_String_ == IntPtr.Zero)
				id_strip_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "strip", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_strip_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_strip_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='strip' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("strip", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Strip (string str, string stripChars)
		{
			if (id_strip_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_strip_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "strip", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_stripChars = JNIEnv.NewString (stripChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_stripChars);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_strip_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_stripChars);
			}
		}

		static IntPtr id_stripAccents_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='stripAccents' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stripAccents", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string StripAccents (string input)
		{
			if (id_stripAccents_Ljava_lang_String_ == IntPtr.Zero)
				id_stripAccents_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stripAccents", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stripAccents_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_stripAll_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='stripAll' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("stripAll", "([Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] StripAll (params string[] strs)
		{
			if (id_stripAll_arrayLjava_lang_String_ == IntPtr.Zero)
				id_stripAll_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stripAll", "([Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_strs = JNIEnv.NewArray (strs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_strs);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_stripAll_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				if (strs != null) {
					JNIEnv.CopyArray (native_strs, strs);
					JNIEnv.DeleteLocalRef (native_strs);
				}
			}
		}

		static IntPtr id_stripAll_arrayLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='stripAll' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("stripAll", "([Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] StripAll (string[] strs, string stripChars)
		{
			if (id_stripAll_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stripAll_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stripAll", "([Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_strs = JNIEnv.NewArray (strs);
			IntPtr native_stripChars = JNIEnv.NewString (stripChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_strs);
				__args [1] = new JValue (native_stripChars);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_stripAll_arrayLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				if (strs != null) {
					JNIEnv.CopyArray (native_strs, strs);
					JNIEnv.DeleteLocalRef (native_strs);
				}
				JNIEnv.DeleteLocalRef (native_stripChars);
			}
		}

		static IntPtr id_stripEnd_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='stripEnd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("stripEnd", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string StripEnd (string str, string stripChars)
		{
			if (id_stripEnd_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stripEnd_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stripEnd", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_stripChars = JNIEnv.NewString (stripChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_stripChars);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stripEnd_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_stripChars);
			}
		}

		static IntPtr id_stripStart_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='stripStart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("stripStart", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string StripStart (string str, string stripChars)
		{
			if (id_stripStart_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stripStart_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stripStart", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_stripChars = JNIEnv.NewString (stripChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_stripChars);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stripStart_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_stripChars);
			}
		}

		static IntPtr id_stripToEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='stripToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stripToEmpty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string StripToEmpty (string str)
		{
			if (id_stripToEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_stripToEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stripToEmpty", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stripToEmpty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_stripToNull_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='stripToNull' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stripToNull", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string StripToNull (string str)
		{
			if (id_stripToNull_Ljava_lang_String_ == IntPtr.Zero)
				id_stripToNull_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stripToNull", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stripToNull_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_substring_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='substring' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("substring", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Substring (string str, int start)
		{
			if (id_substring_Ljava_lang_String_I == IntPtr.Zero)
				id_substring_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "substring", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (start);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_substring_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_substring_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='substring' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("substring", "(Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string Substring (string str, int start, int end)
		{
			if (id_substring_Ljava_lang_String_II == IntPtr.Zero)
				id_substring_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "substring", "(Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (start);
				__args [2] = new JValue (end);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_substring_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_substringAfter_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='substringAfter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("substringAfter", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SubstringAfter (string str, string separator)
		{
			if (id_substringAfter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_substringAfter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "substringAfter", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_substringAfter_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_substringAfterLast_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='substringAfterLast' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("substringAfterLast", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SubstringAfterLast (string str, string separator)
		{
			if (id_substringAfterLast_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_substringAfterLast_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "substringAfterLast", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_substringAfterLast_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_substringBefore_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='substringBefore' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("substringBefore", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SubstringBefore (string str, string separator)
		{
			if (id_substringBefore_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_substringBefore_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "substringBefore", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_substringBefore_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_substringBeforeLast_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='substringBeforeLast' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("substringBeforeLast", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SubstringBeforeLast (string str, string separator)
		{
			if (id_substringBeforeLast_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_substringBeforeLast_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "substringBeforeLast", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_separator);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_substringBeforeLast_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static IntPtr id_substringBetween_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='substringBetween' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("substringBetween", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SubstringBetween (string str, string tag)
		{
			if (id_substringBetween_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_substringBetween_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "substringBetween", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_tag);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_substringBetween_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_substringBetween_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='substringBetween' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("substringBetween", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SubstringBetween (string str, string open, string close)
		{
			if (id_substringBetween_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_substringBetween_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "substringBetween", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_open = JNIEnv.NewString (open);
			IntPtr native_close = JNIEnv.NewString (close);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_open);
				__args [2] = new JValue (native_close);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_substringBetween_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_open);
				JNIEnv.DeleteLocalRef (native_close);
			}
		}

		static IntPtr id_substringsBetween_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='substringsBetween' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("substringsBetween", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] SubstringsBetween (string str, string open, string close)
		{
			if (id_substringsBetween_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_substringsBetween_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "substringsBetween", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_open = JNIEnv.NewString (open);
			IntPtr native_close = JNIEnv.NewString (close);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_open);
				__args [2] = new JValue (native_close);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_substringsBetween_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_open);
				JNIEnv.DeleteLocalRef (native_close);
			}
		}

		static IntPtr id_swapCase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='swapCase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("swapCase", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SwapCase (string str)
		{
			if (id_swapCase_Ljava_lang_String_ == IntPtr.Zero)
				id_swapCase_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "swapCase", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_swapCase_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toCodePoints_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='toCodePoints' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("toCodePoints", "(Ljava/lang/CharSequence;)[I", "")]
		public static unsafe int[] ToCodePoints (global::Java.Lang.ICharSequence str)
		{
			if (id_toCodePoints_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_toCodePoints_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "toCodePoints", "(Ljava/lang/CharSequence;)[I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toCodePoints_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		public static int[] ToCodePoints (string str)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			int[] __result = ToCodePoints (jls_str);
			var __rsval = __result;
			jls_str?.Dispose ();
			return __rsval;
		}

		static IntPtr id_toEncodedString_arrayBLjava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='toEncodedString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("toEncodedString", "([BLjava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public static unsafe string ToEncodedString (byte[] bytes, global::Java.Nio.Charset.Charset charset)
		{
			if (id_toEncodedString_arrayBLjava_nio_charset_Charset_ == IntPtr.Zero)
				id_toEncodedString_arrayBLjava_nio_charset_Charset_ = JNIEnv.GetStaticMethodID (class_ref, "toEncodedString", "([BLjava/nio/charset/Charset;)Ljava/lang/String;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_bytes);
				__args [1] = new JValue (charset);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toEncodedString_arrayBLjava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_toString_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='toString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("toString", "([BLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToString (byte[] bytes, string charsetName)
		{
			if (id_toString_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_toString_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "([BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_bytes);
				__args [1] = new JValue (native_charsetName);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				JNIEnv.DeleteLocalRef (native_charsetName);
			}
		}

		static IntPtr id_trim_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='trim' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trim", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Trim (string str)
		{
			if (id_trim_Ljava_lang_String_ == IntPtr.Zero)
				id_trim_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trim", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_trim_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_trimToEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='trimToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trimToEmpty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string TrimToEmpty (string str)
		{
			if (id_trimToEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_trimToEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trimToEmpty", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_trimToEmpty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_trimToNull_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='trimToNull' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trimToNull", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string TrimToNull (string str)
		{
			if (id_trimToNull_Ljava_lang_String_ == IntPtr.Zero)
				id_trimToNull_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trimToNull", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_trimToNull_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_truncate_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='truncate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("truncate", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Truncate (string str, int maxWidth)
		{
			if (id_truncate_Ljava_lang_String_I == IntPtr.Zero)
				id_truncate_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "truncate", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (maxWidth);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_truncate_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_truncate_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='truncate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("truncate", "(Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string Truncate (string str, int offset, int maxWidth)
		{
			if (id_truncate_Ljava_lang_String_II == IntPtr.Zero)
				id_truncate_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "truncate", "(Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (maxWidth);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_truncate_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_uncapitalize_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='uncapitalize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("uncapitalize", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Uncapitalize (string str)
		{
			if (id_uncapitalize_Ljava_lang_String_ == IntPtr.Zero)
				id_uncapitalize_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "uncapitalize", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_uncapitalize_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_unwrap_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='unwrap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("unwrap", "(Ljava/lang/String;C)Ljava/lang/String;", "")]
		public static unsafe string Unwrap (string str, char wrapChar)
		{
			if (id_unwrap_Ljava_lang_String_C == IntPtr.Zero)
				id_unwrap_Ljava_lang_String_C = JNIEnv.GetStaticMethodID (class_ref, "unwrap", "(Ljava/lang/String;C)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (wrapChar);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unwrap_Ljava_lang_String_C, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_unwrap_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='unwrap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("unwrap", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Unwrap (string str, string wrapToken)
		{
			if (id_unwrap_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_unwrap_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unwrap", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_wrapToken = JNIEnv.NewString (wrapToken);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_wrapToken);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unwrap_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_wrapToken);
			}
		}

		static IntPtr id_upperCase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='upperCase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("upperCase", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UpperCase (string str)
		{
			if (id_upperCase_Ljava_lang_String_ == IntPtr.Zero)
				id_upperCase_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "upperCase", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_upperCase_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_upperCase_Ljava_lang_String_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='upperCase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Locale']]"
		[Register ("upperCase", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string UpperCase (string str, global::Java.Util.Locale locale)
		{
			if (id_upperCase_Ljava_lang_String_Ljava_util_Locale_ == IntPtr.Zero)
				id_upperCase_Ljava_lang_String_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "upperCase", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_upperCase_Ljava_lang_String_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_wrap_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='wrap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("wrap", "(Ljava/lang/String;C)Ljava/lang/String;", "")]
		public static unsafe string Wrap (string str, char wrapWith)
		{
			if (id_wrap_Ljava_lang_String_C == IntPtr.Zero)
				id_wrap_Ljava_lang_String_C = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Ljava/lang/String;C)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (wrapWith);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Ljava_lang_String_C, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_wrap_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='wrap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("wrap", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Wrap (string str, string wrapWith)
		{
			if (id_wrap_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_wrap_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_wrapWith = JNIEnv.NewString (wrapWith);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_wrapWith);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_wrapWith);
			}
		}

		static IntPtr id_wrapIfMissing_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='wrapIfMissing' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("wrapIfMissing", "(Ljava/lang/String;C)Ljava/lang/String;", "")]
		public static unsafe string WrapIfMissing (string str, char wrapWith)
		{
			if (id_wrapIfMissing_Ljava_lang_String_C == IntPtr.Zero)
				id_wrapIfMissing_Ljava_lang_String_C = JNIEnv.GetStaticMethodID (class_ref, "wrapIfMissing", "(Ljava/lang/String;C)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (wrapWith);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrapIfMissing_Ljava_lang_String_C, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_wrapIfMissing_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringUtils']/method[@name='wrapIfMissing' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("wrapIfMissing", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string WrapIfMissing (string str, string wrapWith)
		{
			if (id_wrapIfMissing_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_wrapIfMissing_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "wrapIfMissing", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_wrapWith = JNIEnv.NewString (wrapWith);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_wrapWith);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrapIfMissing_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_wrapWith);
			}
		}

	}
}
