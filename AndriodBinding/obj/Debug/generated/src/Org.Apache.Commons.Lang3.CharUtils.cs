using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/CharUtils", DoNotGenerateAcw=true)]
	public partial class CharUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/field[@name='CR']"
		[Register ("CR")]
		public const char Cr = (char) (char)13;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/field[@name='LF']"
		[Register ("LF")]
		public const char Lf = (char) (char)10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/field[@name='NUL']"
		[Register ("NUL")]
		public const char Nul = (char) (char)0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/CharUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharUtils); }
		}

		protected CharUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/constructor[@name='CharUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CharUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CharUtils)) {
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

		static IntPtr id_compare_CC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
		[Register ("compare", "(CC)I", "")]
		public static unsafe int Compare (char x, char y)
		{
			if (id_compare_CC == IntPtr.Zero)
				id_compare_CC = JNIEnv.GetStaticMethodID (class_ref, "compare", "(CC)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compare_CC, __args);
			} finally {
			}
		}

		static IntPtr id_isAscii_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='isAscii' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("isAscii", "(C)Z", "")]
		public static unsafe bool IsAscii (char ch)
		{
			if (id_isAscii_C == IntPtr.Zero)
				id_isAscii_C = JNIEnv.GetStaticMethodID (class_ref, "isAscii", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAscii_C, __args);
			} finally {
			}
		}

		static IntPtr id_isAsciiAlpha_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='isAsciiAlpha' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("isAsciiAlpha", "(C)Z", "")]
		public static unsafe bool IsAsciiAlpha (char ch)
		{
			if (id_isAsciiAlpha_C == IntPtr.Zero)
				id_isAsciiAlpha_C = JNIEnv.GetStaticMethodID (class_ref, "isAsciiAlpha", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAsciiAlpha_C, __args);
			} finally {
			}
		}

		static IntPtr id_isAsciiAlphaLower_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='isAsciiAlphaLower' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("isAsciiAlphaLower", "(C)Z", "")]
		public static unsafe bool IsAsciiAlphaLower (char ch)
		{
			if (id_isAsciiAlphaLower_C == IntPtr.Zero)
				id_isAsciiAlphaLower_C = JNIEnv.GetStaticMethodID (class_ref, "isAsciiAlphaLower", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAsciiAlphaLower_C, __args);
			} finally {
			}
		}

		static IntPtr id_isAsciiAlphaUpper_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='isAsciiAlphaUpper' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("isAsciiAlphaUpper", "(C)Z", "")]
		public static unsafe bool IsAsciiAlphaUpper (char ch)
		{
			if (id_isAsciiAlphaUpper_C == IntPtr.Zero)
				id_isAsciiAlphaUpper_C = JNIEnv.GetStaticMethodID (class_ref, "isAsciiAlphaUpper", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAsciiAlphaUpper_C, __args);
			} finally {
			}
		}

		static IntPtr id_isAsciiAlphanumeric_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='isAsciiAlphanumeric' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("isAsciiAlphanumeric", "(C)Z", "")]
		public static unsafe bool IsAsciiAlphanumeric (char ch)
		{
			if (id_isAsciiAlphanumeric_C == IntPtr.Zero)
				id_isAsciiAlphanumeric_C = JNIEnv.GetStaticMethodID (class_ref, "isAsciiAlphanumeric", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAsciiAlphanumeric_C, __args);
			} finally {
			}
		}

		static IntPtr id_isAsciiControl_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='isAsciiControl' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("isAsciiControl", "(C)Z", "")]
		public static unsafe bool IsAsciiControl (char ch)
		{
			if (id_isAsciiControl_C == IntPtr.Zero)
				id_isAsciiControl_C = JNIEnv.GetStaticMethodID (class_ref, "isAsciiControl", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAsciiControl_C, __args);
			} finally {
			}
		}

		static IntPtr id_isAsciiNumeric_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='isAsciiNumeric' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("isAsciiNumeric", "(C)Z", "")]
		public static unsafe bool IsAsciiNumeric (char ch)
		{
			if (id_isAsciiNumeric_C == IntPtr.Zero)
				id_isAsciiNumeric_C = JNIEnv.GetStaticMethodID (class_ref, "isAsciiNumeric", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAsciiNumeric_C, __args);
			} finally {
			}
		}

		static IntPtr id_isAsciiPrintable_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='isAsciiPrintable' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("isAsciiPrintable", "(C)Z", "")]
		public static unsafe bool IsAsciiPrintable (char ch)
		{
			if (id_isAsciiPrintable_C == IntPtr.Zero)
				id_isAsciiPrintable_C = JNIEnv.GetStaticMethodID (class_ref, "isAsciiPrintable", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAsciiPrintable_C, __args);
			} finally {
			}
		}

		static IntPtr id_toChar_Ljava_lang_Character_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toChar' and count(parameter)=1 and parameter[1][@type='java.lang.Character']]"
		[Register ("toChar", "(Ljava/lang/Character;)C", "")]
		public static unsafe char ToChar (global::Java.Lang.Character ch)
		{
			if (id_toChar_Ljava_lang_Character_ == IntPtr.Zero)
				id_toChar_Ljava_lang_Character_ = JNIEnv.GetStaticMethodID (class_ref, "toChar", "(Ljava/lang/Character;)C");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_toChar_Ljava_lang_Character_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toChar_Ljava_lang_Character_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toChar' and count(parameter)=2 and parameter[1][@type='java.lang.Character'] and parameter[2][@type='char']]"
		[Register ("toChar", "(Ljava/lang/Character;C)C", "")]
		public static unsafe char ToChar (global::Java.Lang.Character ch, char defaultValue)
		{
			if (id_toChar_Ljava_lang_Character_C == IntPtr.Zero)
				id_toChar_Ljava_lang_Character_C = JNIEnv.GetStaticMethodID (class_ref, "toChar", "(Ljava/lang/Character;C)C");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ch);
				__args [1] = new JValue (defaultValue);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_toChar_Ljava_lang_Character_C, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toChar_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toChar' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toChar", "(Ljava/lang/String;)C", "")]
		public static unsafe char ToChar (string str)
		{
			if (id_toChar_Ljava_lang_String_ == IntPtr.Zero)
				id_toChar_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toChar", "(Ljava/lang/String;)C");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_toChar_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toChar_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toChar' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("toChar", "(Ljava/lang/String;C)C", "")]
		public static unsafe char ToChar (string str, char defaultValue)
		{
			if (id_toChar_Ljava_lang_String_C == IntPtr.Zero)
				id_toChar_Ljava_lang_String_C = JNIEnv.GetStaticMethodID (class_ref, "toChar", "(Ljava/lang/String;C)C");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (defaultValue);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_toChar_Ljava_lang_String_C, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toCharacterObject_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toCharacterObject' and count(parameter)=1 and parameter[1][@type='char']]"
		[Obsolete (@"deprecated")]
		[Register ("toCharacterObject", "(C)Ljava/lang/Character;", "")]
		public static unsafe global::Java.Lang.Character ToCharacterObject (char ch)
		{
			if (id_toCharacterObject_C == IntPtr.Zero)
				id_toCharacterObject_C = JNIEnv.GetStaticMethodID (class_ref, "toCharacterObject", "(C)Ljava/lang/Character;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Character> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toCharacterObject_C, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toCharacterObject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toCharacterObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toCharacterObject", "(Ljava/lang/String;)Ljava/lang/Character;", "")]
		public static unsafe global::Java.Lang.Character ToCharacterObject (string str)
		{
			if (id_toCharacterObject_Ljava_lang_String_ == IntPtr.Zero)
				id_toCharacterObject_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toCharacterObject", "(Ljava/lang/String;)Ljava/lang/Character;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Java.Lang.Character __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Character> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toCharacterObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toIntValue_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toIntValue' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("toIntValue", "(C)I", "")]
		public static unsafe int ToIntValue (char ch)
		{
			if (id_toIntValue_C == IntPtr.Zero)
				id_toIntValue_C = JNIEnv.GetStaticMethodID (class_ref, "toIntValue", "(C)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_toIntValue_C, __args);
			} finally {
			}
		}

		static IntPtr id_toIntValue_CI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toIntValue' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='int']]"
		[Register ("toIntValue", "(CI)I", "")]
		public static unsafe int ToIntValue (char ch, int defaultValue)
		{
			if (id_toIntValue_CI == IntPtr.Zero)
				id_toIntValue_CI = JNIEnv.GetStaticMethodID (class_ref, "toIntValue", "(CI)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ch);
				__args [1] = new JValue (defaultValue);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_toIntValue_CI, __args);
			} finally {
			}
		}

		static IntPtr id_toIntValue_Ljava_lang_Character_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toIntValue' and count(parameter)=1 and parameter[1][@type='java.lang.Character']]"
		[Register ("toIntValue", "(Ljava/lang/Character;)I", "")]
		public static unsafe int ToIntValue (global::Java.Lang.Character ch)
		{
			if (id_toIntValue_Ljava_lang_Character_ == IntPtr.Zero)
				id_toIntValue_Ljava_lang_Character_ = JNIEnv.GetStaticMethodID (class_ref, "toIntValue", "(Ljava/lang/Character;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_toIntValue_Ljava_lang_Character_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toIntValue_Ljava_lang_Character_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toIntValue' and count(parameter)=2 and parameter[1][@type='java.lang.Character'] and parameter[2][@type='int']]"
		[Register ("toIntValue", "(Ljava/lang/Character;I)I", "")]
		public static unsafe int ToIntValue (global::Java.Lang.Character ch, int defaultValue)
		{
			if (id_toIntValue_Ljava_lang_Character_I == IntPtr.Zero)
				id_toIntValue_Ljava_lang_Character_I = JNIEnv.GetStaticMethodID (class_ref, "toIntValue", "(Ljava/lang/Character;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ch);
				__args [1] = new JValue (defaultValue);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_toIntValue_Ljava_lang_Character_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("toString", "(C)Ljava/lang/String;", "")]
		public static unsafe string ToString (char ch)
		{
			if (id_toString_C == IntPtr.Zero)
				id_toString_C = JNIEnv.GetStaticMethodID (class_ref, "toString", "(C)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_C, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_Character_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.lang.Character']]"
		[Register ("toString", "(Ljava/lang/Character;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Character ch)
		{
			if (id_toString_Ljava_lang_Character_ == IntPtr.Zero)
				id_toString_Ljava_lang_Character_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Character;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Character_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_unicodeEscaped_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='unicodeEscaped' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("unicodeEscaped", "(C)Ljava/lang/String;", "")]
		public static unsafe string UnicodeEscaped (char ch)
		{
			if (id_unicodeEscaped_C == IntPtr.Zero)
				id_unicodeEscaped_C = JNIEnv.GetStaticMethodID (class_ref, "unicodeEscaped", "(C)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unicodeEscaped_C, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_unicodeEscaped_Ljava_lang_Character_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharUtils']/method[@name='unicodeEscaped' and count(parameter)=1 and parameter[1][@type='java.lang.Character']]"
		[Register ("unicodeEscaped", "(Ljava/lang/Character;)Ljava/lang/String;", "")]
		public static unsafe string UnicodeEscaped (global::Java.Lang.Character ch)
		{
			if (id_unicodeEscaped_Ljava_lang_Character_ == IntPtr.Zero)
				id_unicodeEscaped_Ljava_lang_Character_ = JNIEnv.GetStaticMethodID (class_ref, "unicodeEscaped", "(Ljava/lang/Character;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unicodeEscaped_Ljava_lang_Character_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
