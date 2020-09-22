using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/CharSet", DoNotGenerateAcw=true)]
	public partial class CharSet : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr ASCII_ALPHA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']/field[@name='ASCII_ALPHA']"
		[Register ("ASCII_ALPHA")]
		public static global::Org.Apache.Commons.Lang3.CharSet AsciiAlpha {
			get {
				if (ASCII_ALPHA_jfieldId == IntPtr.Zero)
					ASCII_ALPHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASCII_ALPHA", "Lorg/apache/commons/lang3/CharSet;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASCII_ALPHA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.CharSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ASCII_ALPHA_LOWER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']/field[@name='ASCII_ALPHA_LOWER']"
		[Register ("ASCII_ALPHA_LOWER")]
		public static global::Org.Apache.Commons.Lang3.CharSet AsciiAlphaLower {
			get {
				if (ASCII_ALPHA_LOWER_jfieldId == IntPtr.Zero)
					ASCII_ALPHA_LOWER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASCII_ALPHA_LOWER", "Lorg/apache/commons/lang3/CharSet;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASCII_ALPHA_LOWER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.CharSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ASCII_ALPHA_UPPER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']/field[@name='ASCII_ALPHA_UPPER']"
		[Register ("ASCII_ALPHA_UPPER")]
		public static global::Org.Apache.Commons.Lang3.CharSet AsciiAlphaUpper {
			get {
				if (ASCII_ALPHA_UPPER_jfieldId == IntPtr.Zero)
					ASCII_ALPHA_UPPER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASCII_ALPHA_UPPER", "Lorg/apache/commons/lang3/CharSet;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASCII_ALPHA_UPPER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.CharSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ASCII_NUMERIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']/field[@name='ASCII_NUMERIC']"
		[Register ("ASCII_NUMERIC")]
		public static global::Org.Apache.Commons.Lang3.CharSet AsciiNumeric {
			get {
				if (ASCII_NUMERIC_jfieldId == IntPtr.Zero)
					ASCII_NUMERIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASCII_NUMERIC", "Lorg/apache/commons/lang3/CharSet;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASCII_NUMERIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.CharSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COMMON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']/field[@name='COMMON']"
		[Register ("COMMON")]
		protected static global::System.Collections.IDictionary Common {
			get {
				if (COMMON_jfieldId == IntPtr.Zero)
					COMMON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMMON", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMMON_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']/field[@name='EMPTY']"
		[Register ("EMPTY")]
		public static global::Org.Apache.Commons.Lang3.CharSet Empty {
			get {
				if (EMPTY_jfieldId == IntPtr.Zero)
					EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY", "Lorg/apache/commons/lang3/CharSet;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.CharSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/CharSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharSet); }
		}

		protected CharSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']/constructor[@name='CharSet' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register (".ctor", "([Ljava/lang/String;)V", "")]
		protected unsafe CharSet (params string[] set)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_set = JNIEnv.NewArray (set);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_set);
				if (((object) this).GetType () != typeof (CharSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_lang_String_ == IntPtr.Zero)
					id_ctor_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLjava_lang_String_, __args);
			} finally {
				if (set != null) {
					JNIEnv.CopyArray (native_set, set);
					JNIEnv.DeleteLocalRef (native_set);
				}
			}
		}

		static Delegate cb_add_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Handler ()
		{
			if (cb_add_Ljava_lang_String_ == null)
				cb_add_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Ljava_lang_String_);
			return cb_add_Ljava_lang_String_;
		}

		static void n_Add_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.CharSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			__this.Add (str);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)V", "GetAdd_Ljava_lang_String_Handler")]
		protected virtual unsafe void Add (string str)
		{
			if (id_add_Ljava_lang_String_ == IntPtr.Zero)
				id_add_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;)V");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_contains_C;
#pragma warning disable 0169
		static Delegate GetContains_CHandler ()
		{
			if (cb_contains_C == null)
				cb_contains_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_Z) n_Contains_C);
			return cb_contains_C;
		}

		static bool n_Contains_C (IntPtr jnienv, IntPtr native__this, char ch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.CharSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Contains (ch);
		}
#pragma warning restore 0169

		static IntPtr id_contains_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("contains", "(C)Z", "GetContains_CHandler")]
		public virtual unsafe bool Contains (char ch)
		{
			if (id_contains_C == IntPtr.Zero)
				id_contains_C = JNIEnv.GetMethodID (class_ref, "contains", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_C, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(C)Z"), __args);
			} finally {
			}
		}

		static IntPtr id_getInstance_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSet']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("getInstance", "([Ljava/lang/String;)Lorg/apache/commons/lang3/CharSet;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.CharSet GetInstance (params string[] setStrs)
		{
			if (id_getInstance_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getInstance_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "([Ljava/lang/String;)Lorg/apache/commons/lang3/CharSet;");
			IntPtr native_setStrs = JNIEnv.NewArray (setStrs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_setStrs);
				global::Org.Apache.Commons.Lang3.CharSet __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.CharSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (setStrs != null) {
					JNIEnv.CopyArray (native_setStrs, setStrs);
					JNIEnv.DeleteLocalRef (native_setStrs);
				}
			}
		}

	}
}
