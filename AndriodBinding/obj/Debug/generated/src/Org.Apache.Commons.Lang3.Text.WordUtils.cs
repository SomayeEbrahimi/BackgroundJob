using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/WordUtils", DoNotGenerateAcw=true)]
	public partial class WordUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/WordUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WordUtils); }
		}

		protected WordUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/constructor[@name='WordUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WordUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (WordUtils)) {
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

		static IntPtr id_capitalize_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='capitalize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_capitalize_Ljava_lang_String_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='capitalize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char...']]"
		[Register ("capitalize", "(Ljava/lang/String;[C)Ljava/lang/String;", "")]
		public static unsafe string Capitalize (string str, params char[] delimiters)
		{
			if (id_capitalize_Ljava_lang_String_arrayC == IntPtr.Zero)
				id_capitalize_Ljava_lang_String_arrayC = JNIEnv.GetStaticMethodID (class_ref, "capitalize", "(Ljava/lang/String;[C)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_delimiters = JNIEnv.NewArray (delimiters);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_delimiters);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_capitalize_Ljava_lang_String_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (delimiters != null) {
					JNIEnv.CopyArray (native_delimiters, delimiters);
					JNIEnv.DeleteLocalRef (native_delimiters);
				}
			}
		}

		static IntPtr id_capitalizeFully_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='capitalizeFully' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("capitalizeFully", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CapitalizeFully (string str)
		{
			if (id_capitalizeFully_Ljava_lang_String_ == IntPtr.Zero)
				id_capitalizeFully_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "capitalizeFully", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_capitalizeFully_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_capitalizeFully_Ljava_lang_String_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='capitalizeFully' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char...']]"
		[Register ("capitalizeFully", "(Ljava/lang/String;[C)Ljava/lang/String;", "")]
		public static unsafe string CapitalizeFully (string str, params char[] delimiters)
		{
			if (id_capitalizeFully_Ljava_lang_String_arrayC == IntPtr.Zero)
				id_capitalizeFully_Ljava_lang_String_arrayC = JNIEnv.GetStaticMethodID (class_ref, "capitalizeFully", "(Ljava/lang/String;[C)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_delimiters = JNIEnv.NewArray (delimiters);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_delimiters);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_capitalizeFully_Ljava_lang_String_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (delimiters != null) {
					JNIEnv.CopyArray (native_delimiters, delimiters);
					JNIEnv.DeleteLocalRef (native_delimiters);
				}
			}
		}

		static IntPtr id_containsAllWords_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='containsAllWords' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence...']]"
		[Register ("containsAllWords", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool ContainsAllWords (global::Java.Lang.ICharSequence word, params global::Java.Lang.ICharSequence[] words)
		{
			if (id_containsAllWords_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_containsAllWords_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "containsAllWords", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z");
			IntPtr native_word = CharSequence.ToLocalJniHandle (word);
			IntPtr native_words = JNIEnv.NewArray (words);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_word);
				__args [1] = new JValue (native_words);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsAllWords_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_word);
				if (words != null) {
					JNIEnv.CopyArray (native_words, words);
					JNIEnv.DeleteLocalRef (native_words);
				}
			}
		}

		public static bool ContainsAllWords (string word, params string[] words)
		{
			var jls_word = word == null ? null : new global::Java.Lang.String (word);
			var jlca_words = CharSequence.ArrayFromStringArray(words);
			bool __result = ContainsAllWords (jls_word, jlca_words);
			var __rsval = __result;
			jls_word?.Dispose ();
			return __rsval;
		}

		static IntPtr id_initials_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='initials' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initials", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Initials (string str)
		{
			if (id_initials_Ljava_lang_String_ == IntPtr.Zero)
				id_initials_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "initials", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_initials_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_initials_Ljava_lang_String_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='initials' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char...']]"
		[Register ("initials", "(Ljava/lang/String;[C)Ljava/lang/String;", "")]
		public static unsafe string Initials (string str, params char[] delimiters)
		{
			if (id_initials_Ljava_lang_String_arrayC == IntPtr.Zero)
				id_initials_Ljava_lang_String_arrayC = JNIEnv.GetStaticMethodID (class_ref, "initials", "(Ljava/lang/String;[C)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_delimiters = JNIEnv.NewArray (delimiters);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_delimiters);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_initials_Ljava_lang_String_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (delimiters != null) {
					JNIEnv.CopyArray (native_delimiters, delimiters);
					JNIEnv.DeleteLocalRef (native_delimiters);
				}
			}
		}

		static IntPtr id_swapCase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='swapCase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_uncapitalize_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='uncapitalize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_uncapitalize_Ljava_lang_String_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='uncapitalize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char...']]"
		[Register ("uncapitalize", "(Ljava/lang/String;[C)Ljava/lang/String;", "")]
		public static unsafe string Uncapitalize (string str, params char[] delimiters)
		{
			if (id_uncapitalize_Ljava_lang_String_arrayC == IntPtr.Zero)
				id_uncapitalize_Ljava_lang_String_arrayC = JNIEnv.GetStaticMethodID (class_ref, "uncapitalize", "(Ljava/lang/String;[C)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_delimiters = JNIEnv.NewArray (delimiters);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_delimiters);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_uncapitalize_Ljava_lang_String_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (delimiters != null) {
					JNIEnv.CopyArray (native_delimiters, delimiters);
					JNIEnv.DeleteLocalRef (native_delimiters);
				}
			}
		}

		static IntPtr id_wrap_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='wrap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("wrap", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Wrap (string str, int wrapLength)
		{
			if (id_wrap_Ljava_lang_String_I == IntPtr.Zero)
				id_wrap_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (wrapLength);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_wrap_Ljava_lang_String_ILjava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='wrap' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("wrap", "(Ljava/lang/String;ILjava/lang/String;Z)Ljava/lang/String;", "")]
		public static unsafe string Wrap (string str, int wrapLength, string newLineStr, bool wrapLongWords)
		{
			if (id_wrap_Ljava_lang_String_ILjava_lang_String_Z == IntPtr.Zero)
				id_wrap_Ljava_lang_String_ILjava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Ljava/lang/String;ILjava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_newLineStr = JNIEnv.NewString (newLineStr);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (wrapLength);
				__args [2] = new JValue (native_newLineStr);
				__args [3] = new JValue (wrapLongWords);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Ljava_lang_String_ILjava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_newLineStr);
			}
		}

		static IntPtr id_wrap_Ljava_lang_String_ILjava_lang_String_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='WordUtils']/method[@name='wrap' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String']]"
		[Register ("wrap", "(Ljava/lang/String;ILjava/lang/String;ZLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Wrap (string str, int wrapLength, string newLineStr, bool wrapLongWords, string wrapOn)
		{
			if (id_wrap_Ljava_lang_String_ILjava_lang_String_ZLjava_lang_String_ == IntPtr.Zero)
				id_wrap_Ljava_lang_String_ILjava_lang_String_ZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Ljava/lang/String;ILjava/lang/String;ZLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_newLineStr = JNIEnv.NewString (newLineStr);
			IntPtr native_wrapOn = JNIEnv.NewString (wrapOn);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (wrapLength);
				__args [2] = new JValue (native_newLineStr);
				__args [3] = new JValue (wrapLongWords);
				__args [4] = new JValue (native_wrapOn);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Ljava_lang_String_ILjava_lang_String_ZLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_newLineStr);
				JNIEnv.DeleteLocalRef (native_wrapOn);
			}
		}

	}
}
