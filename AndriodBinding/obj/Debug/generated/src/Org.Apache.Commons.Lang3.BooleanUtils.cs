using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/BooleanUtils", DoNotGenerateAcw=true)]
	public partial class BooleanUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/BooleanUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BooleanUtils); }
		}

		protected BooleanUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/constructor[@name='BooleanUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BooleanUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BooleanUtils)) {
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

		static IntPtr id_and_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='and' and count(parameter)=1 and parameter[1][@type='boolean...']]"
		[Register ("and", "([Z)Z", "")]
		public static unsafe bool And (params bool[] array)
		{
			if (id_and_arrayZ == IntPtr.Zero)
				id_and_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "and", "([Z)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_and_arrayZ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_and_arrayLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='and' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean...']]"
		[Register ("and", "([Ljava/lang/Boolean;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean And (params global::Java.Lang.Boolean[] array)
		{
			if (id_and_arrayLjava_lang_Boolean_ == IntPtr.Zero)
				id_and_arrayLjava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "and", "([Ljava/lang/Boolean;)Ljava/lang/Boolean;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_and_arrayLjava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_compare_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("compare", "(ZZ)I", "")]
		public static unsafe int Compare (bool x, bool y)
		{
			if (id_compare_ZZ == IntPtr.Zero)
				id_compare_ZZ = JNIEnv.GetStaticMethodID (class_ref, "compare", "(ZZ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compare_ZZ, __args);
			} finally {
			}
		}

		static IntPtr id_isFalse_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='isFalse' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("isFalse", "(Ljava/lang/Boolean;)Z", "")]
		public static unsafe bool IsFalse (global::Java.Lang.Boolean @bool)
		{
			if (id_isFalse_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_isFalse_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "isFalse", "(Ljava/lang/Boolean;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFalse_Ljava_lang_Boolean_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNotFalse_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='isNotFalse' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("isNotFalse", "(Ljava/lang/Boolean;)Z", "")]
		public static unsafe bool IsNotFalse (global::Java.Lang.Boolean @bool)
		{
			if (id_isNotFalse_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_isNotFalse_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "isNotFalse", "(Ljava/lang/Boolean;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotFalse_Ljava_lang_Boolean_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNotTrue_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='isNotTrue' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("isNotTrue", "(Ljava/lang/Boolean;)Z", "")]
		public static unsafe bool IsNotTrue (global::Java.Lang.Boolean @bool)
		{
			if (id_isNotTrue_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_isNotTrue_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "isNotTrue", "(Ljava/lang/Boolean;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotTrue_Ljava_lang_Boolean_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isTrue_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='isTrue' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("isTrue", "(Ljava/lang/Boolean;)Z", "")]
		public static unsafe bool IsTrue (global::Java.Lang.Boolean @bool)
		{
			if (id_isTrue_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_isTrue_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "isTrue", "(Ljava/lang/Boolean;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isTrue_Ljava_lang_Boolean_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_negate_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='negate' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("negate", "(Ljava/lang/Boolean;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean Negate (global::Java.Lang.Boolean @bool)
		{
			if (id_negate_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_negate_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "negate", "(Ljava/lang/Boolean;)Ljava/lang/Boolean;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_negate_Ljava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_or_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='or' and count(parameter)=1 and parameter[1][@type='boolean...']]"
		[Register ("or", "([Z)Z", "")]
		public static unsafe bool Or (params bool[] array)
		{
			if (id_or_arrayZ == IntPtr.Zero)
				id_or_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "or", "([Z)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_or_arrayZ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_or_arrayLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='or' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean...']]"
		[Register ("or", "([Ljava/lang/Boolean;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean Or (params global::Java.Lang.Boolean[] array)
		{
			if (id_or_arrayLjava_lang_Boolean_ == IntPtr.Zero)
				id_or_arrayLjava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "or", "([Ljava/lang/Boolean;)Ljava/lang/Boolean;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_or_arrayLjava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toBoolean_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBoolean' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toBoolean", "(I)Z", "")]
		public static unsafe bool ToBoolean (int value)
		{
			if (id_toBoolean_I == IntPtr.Zero)
				id_toBoolean_I = JNIEnv.GetStaticMethodID (class_ref, "toBoolean", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_toBoolean_I, __args);
			} finally {
			}
		}

		static IntPtr id_toBoolean_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBoolean' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("toBoolean", "(III)Z", "")]
		public static unsafe bool ToBoolean (int value, int trueValue, int falseValue)
		{
			if (id_toBoolean_III == IntPtr.Zero)
				id_toBoolean_III = JNIEnv.GetStaticMethodID (class_ref, "toBoolean", "(III)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (value);
				__args [1] = new JValue (trueValue);
				__args [2] = new JValue (falseValue);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_toBoolean_III, __args);
			} finally {
			}
		}

		static IntPtr id_toBoolean_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("toBoolean", "(Ljava/lang/Boolean;)Z", "")]
		public static unsafe bool ToBoolean (global::Java.Lang.Boolean @bool)
		{
			if (id_toBoolean_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_toBoolean_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "toBoolean", "(Ljava/lang/Boolean;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_toBoolean_Ljava_lang_Boolean_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toBoolean_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBoolean' and count(parameter)=3 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("toBoolean", "(Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Z", "")]
		public static unsafe bool ToBoolean (global::Java.Lang.Integer value, global::Java.Lang.Integer trueValue, global::Java.Lang.Integer falseValue)
		{
			if (id_toBoolean_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
				id_toBoolean_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "toBoolean", "(Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (value);
				__args [1] = new JValue (trueValue);
				__args [2] = new JValue (falseValue);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_toBoolean_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toBoolean_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toBoolean", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ToBoolean (string str)
		{
			if (id_toBoolean_Ljava_lang_String_ == IntPtr.Zero)
				id_toBoolean_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toBoolean", "(Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_toBoolean_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBoolean' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("toBoolean", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool ToBoolean (string str, string trueString, string falseString)
		{
			if (id_toBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_toBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toBoolean", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_trueString = JNIEnv.NewString (trueString);
			IntPtr native_falseString = JNIEnv.NewString (falseString);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_trueString);
				__args [2] = new JValue (native_falseString);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_toBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_trueString);
				JNIEnv.DeleteLocalRef (native_falseString);
			}
		}

		static IntPtr id_toBooleanDefaultIfNull_Ljava_lang_Boolean_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBooleanDefaultIfNull' and count(parameter)=2 and parameter[1][@type='java.lang.Boolean'] and parameter[2][@type='boolean']]"
		[Register ("toBooleanDefaultIfNull", "(Ljava/lang/Boolean;Z)Z", "")]
		public static unsafe bool ToBooleanDefaultIfNull (global::Java.Lang.Boolean @bool, bool valueIfNull)
		{
			if (id_toBooleanDefaultIfNull_Ljava_lang_Boolean_Z == IntPtr.Zero)
				id_toBooleanDefaultIfNull_Ljava_lang_Boolean_Z = JNIEnv.GetStaticMethodID (class_ref, "toBooleanDefaultIfNull", "(Ljava/lang/Boolean;Z)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@bool);
				__args [1] = new JValue (valueIfNull);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_toBooleanDefaultIfNull_Ljava_lang_Boolean_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toBooleanObject_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBooleanObject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toBooleanObject", "(I)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean ToBooleanObject (int value)
		{
			if (id_toBooleanObject_I == IntPtr.Zero)
				id_toBooleanObject_I = JNIEnv.GetStaticMethodID (class_ref, "toBooleanObject", "(I)Ljava/lang/Boolean;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBooleanObject_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toBooleanObject_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBooleanObject' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("toBooleanObject", "(IIII)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean ToBooleanObject (int value, int trueValue, int falseValue, int nullValue)
		{
			if (id_toBooleanObject_IIII == IntPtr.Zero)
				id_toBooleanObject_IIII = JNIEnv.GetStaticMethodID (class_ref, "toBooleanObject", "(IIII)Ljava/lang/Boolean;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (value);
				__args [1] = new JValue (trueValue);
				__args [2] = new JValue (falseValue);
				__args [3] = new JValue (nullValue);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBooleanObject_IIII, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toBooleanObject_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBooleanObject' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("toBooleanObject", "(Ljava/lang/Integer;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean ToBooleanObject (global::Java.Lang.Integer value)
		{
			if (id_toBooleanObject_Ljava_lang_Integer_ == IntPtr.Zero)
				id_toBooleanObject_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "toBooleanObject", "(Ljava/lang/Integer;)Ljava/lang/Boolean;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBooleanObject_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toBooleanObject_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBooleanObject' and count(parameter)=4 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.Integer']]"
		[Register ("toBooleanObject", "(Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean ToBooleanObject (global::Java.Lang.Integer value, global::Java.Lang.Integer trueValue, global::Java.Lang.Integer falseValue, global::Java.Lang.Integer nullValue)
		{
			if (id_toBooleanObject_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
				id_toBooleanObject_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "toBooleanObject", "(Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Ljava/lang/Boolean;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (value);
				__args [1] = new JValue (trueValue);
				__args [2] = new JValue (falseValue);
				__args [3] = new JValue (nullValue);
				global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBooleanObject_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toBooleanObject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBooleanObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toBooleanObject", "(Ljava/lang/String;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean ToBooleanObject (string str)
		{
			if (id_toBooleanObject_Ljava_lang_String_ == IntPtr.Zero)
				id_toBooleanObject_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toBooleanObject", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBooleanObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toBooleanObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toBooleanObject' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("toBooleanObject", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean ToBooleanObject (string str, string trueString, string falseString, string nullString)
		{
			if (id_toBooleanObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_toBooleanObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toBooleanObject", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Boolean;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_trueString = JNIEnv.NewString (trueString);
			IntPtr native_falseString = JNIEnv.NewString (falseString);
			IntPtr native_nullString = JNIEnv.NewString (nullString);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_trueString);
				__args [2] = new JValue (native_falseString);
				__args [3] = new JValue (native_nullString);
				global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBooleanObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_trueString);
				JNIEnv.DeleteLocalRef (native_falseString);
				JNIEnv.DeleteLocalRef (native_nullString);
			}
		}

		static IntPtr id_toInteger_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toInteger' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("toInteger", "(Z)I", "")]
		public static unsafe int ToInteger (bool @bool)
		{
			if (id_toInteger_Z == IntPtr.Zero)
				id_toInteger_Z = JNIEnv.GetStaticMethodID (class_ref, "toInteger", "(Z)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_toInteger_Z, __args);
			} finally {
			}
		}

		static IntPtr id_toInteger_ZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toInteger' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("toInteger", "(ZII)I", "")]
		public static unsafe int ToInteger (bool @bool, int trueValue, int falseValue)
		{
			if (id_toInteger_ZII == IntPtr.Zero)
				id_toInteger_ZII = JNIEnv.GetStaticMethodID (class_ref, "toInteger", "(ZII)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@bool);
				__args [1] = new JValue (trueValue);
				__args [2] = new JValue (falseValue);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_toInteger_ZII, __args);
			} finally {
			}
		}

		static IntPtr id_toInteger_Ljava_lang_Boolean_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toInteger' and count(parameter)=4 and parameter[1][@type='java.lang.Boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("toInteger", "(Ljava/lang/Boolean;III)I", "")]
		public static unsafe int ToInteger (global::Java.Lang.Boolean @bool, int trueValue, int falseValue, int nullValue)
		{
			if (id_toInteger_Ljava_lang_Boolean_III == IntPtr.Zero)
				id_toInteger_Ljava_lang_Boolean_III = JNIEnv.GetStaticMethodID (class_ref, "toInteger", "(Ljava/lang/Boolean;III)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (@bool);
				__args [1] = new JValue (trueValue);
				__args [2] = new JValue (falseValue);
				__args [3] = new JValue (nullValue);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_toInteger_Ljava_lang_Boolean_III, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toIntegerObject_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toIntegerObject' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("toIntegerObject", "(Z)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer ToIntegerObject (bool @bool)
		{
			if (id_toIntegerObject_Z == IntPtr.Zero)
				id_toIntegerObject_Z = JNIEnv.GetStaticMethodID (class_ref, "toIntegerObject", "(Z)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toIntegerObject_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toIntegerObject_ZLjava_lang_Integer_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toIntegerObject' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("toIntegerObject", "(ZLjava/lang/Integer;Ljava/lang/Integer;)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer ToIntegerObject (bool @bool, global::Java.Lang.Integer trueValue, global::Java.Lang.Integer falseValue)
		{
			if (id_toIntegerObject_ZLjava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
				id_toIntegerObject_ZLjava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "toIntegerObject", "(ZLjava/lang/Integer;Ljava/lang/Integer;)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@bool);
				__args [1] = new JValue (trueValue);
				__args [2] = new JValue (falseValue);
				global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toIntegerObject_ZLjava_lang_Integer_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toIntegerObject_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toIntegerObject' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("toIntegerObject", "(Ljava/lang/Boolean;)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer ToIntegerObject (global::Java.Lang.Boolean @bool)
		{
			if (id_toIntegerObject_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_toIntegerObject_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "toIntegerObject", "(Ljava/lang/Boolean;)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toIntegerObject_Ljava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toIntegerObject_Ljava_lang_Boolean_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toIntegerObject' and count(parameter)=4 and parameter[1][@type='java.lang.Boolean'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.Integer']]"
		[Register ("toIntegerObject", "(Ljava/lang/Boolean;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer ToIntegerObject (global::Java.Lang.Boolean @bool, global::Java.Lang.Integer trueValue, global::Java.Lang.Integer falseValue, global::Java.Lang.Integer nullValue)
		{
			if (id_toIntegerObject_Ljava_lang_Boolean_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
				id_toIntegerObject_Ljava_lang_Boolean_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "toIntegerObject", "(Ljava/lang/Boolean;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (@bool);
				__args [1] = new JValue (trueValue);
				__args [2] = new JValue (falseValue);
				__args [3] = new JValue (nullValue);
				global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toIntegerObject_Ljava_lang_Boolean_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toString' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("toString", "(ZLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToString (bool @bool, string trueString, string falseString)
		{
			if (id_toString_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_toString_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(ZLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_trueString = JNIEnv.NewString (trueString);
			IntPtr native_falseString = JNIEnv.NewString (falseString);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@bool);
				__args [1] = new JValue (native_trueString);
				__args [2] = new JValue (native_falseString);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_ZLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_trueString);
				JNIEnv.DeleteLocalRef (native_falseString);
			}
		}

		static IntPtr id_toString_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toString' and count(parameter)=4 and parameter[1][@type='java.lang.Boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("toString", "(Ljava/lang/Boolean;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Boolean @bool, string trueString, string falseString, string nullString)
		{
			if (id_toString_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_toString_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Boolean;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_trueString = JNIEnv.NewString (trueString);
			IntPtr native_falseString = JNIEnv.NewString (falseString);
			IntPtr native_nullString = JNIEnv.NewString (nullString);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (@bool);
				__args [1] = new JValue (native_trueString);
				__args [2] = new JValue (native_falseString);
				__args [3] = new JValue (native_nullString);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_trueString);
				JNIEnv.DeleteLocalRef (native_falseString);
				JNIEnv.DeleteLocalRef (native_nullString);
			}
		}

		static IntPtr id_toStringOnOff_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toStringOnOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("toStringOnOff", "(Z)Ljava/lang/String;", "")]
		public static unsafe string ToStringOnOff (bool @bool)
		{
			if (id_toStringOnOff_Z == IntPtr.Zero)
				id_toStringOnOff_Z = JNIEnv.GetStaticMethodID (class_ref, "toStringOnOff", "(Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringOnOff_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toStringOnOff_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toStringOnOff' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("toStringOnOff", "(Ljava/lang/Boolean;)Ljava/lang/String;", "")]
		public static unsafe string ToStringOnOff (global::Java.Lang.Boolean @bool)
		{
			if (id_toStringOnOff_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_toStringOnOff_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "toStringOnOff", "(Ljava/lang/Boolean;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringOnOff_Ljava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toStringTrueFalse_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toStringTrueFalse' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("toStringTrueFalse", "(Z)Ljava/lang/String;", "")]
		public static unsafe string ToStringTrueFalse (bool @bool)
		{
			if (id_toStringTrueFalse_Z == IntPtr.Zero)
				id_toStringTrueFalse_Z = JNIEnv.GetStaticMethodID (class_ref, "toStringTrueFalse", "(Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringTrueFalse_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toStringTrueFalse_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toStringTrueFalse' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("toStringTrueFalse", "(Ljava/lang/Boolean;)Ljava/lang/String;", "")]
		public static unsafe string ToStringTrueFalse (global::Java.Lang.Boolean @bool)
		{
			if (id_toStringTrueFalse_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_toStringTrueFalse_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "toStringTrueFalse", "(Ljava/lang/Boolean;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringTrueFalse_Ljava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toStringYesNo_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toStringYesNo' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("toStringYesNo", "(Z)Ljava/lang/String;", "")]
		public static unsafe string ToStringYesNo (bool @bool)
		{
			if (id_toStringYesNo_Z == IntPtr.Zero)
				id_toStringYesNo_Z = JNIEnv.GetStaticMethodID (class_ref, "toStringYesNo", "(Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringYesNo_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toStringYesNo_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='toStringYesNo' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("toStringYesNo", "(Ljava/lang/Boolean;)Ljava/lang/String;", "")]
		public static unsafe string ToStringYesNo (global::Java.Lang.Boolean @bool)
		{
			if (id_toStringYesNo_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_toStringYesNo_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "toStringYesNo", "(Ljava/lang/Boolean;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringYesNo_Ljava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_xor_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='xor' and count(parameter)=1 and parameter[1][@type='boolean...']]"
		[Register ("xor", "([Z)Z", "")]
		public static unsafe bool Xor (params bool[] array)
		{
			if (id_xor_arrayZ == IntPtr.Zero)
				id_xor_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "xor", "([Z)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_xor_arrayZ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_xor_arrayLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BooleanUtils']/method[@name='xor' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean...']]"
		[Register ("xor", "([Ljava/lang/Boolean;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean Xor (params global::Java.Lang.Boolean[] array)
		{
			if (id_xor_arrayLjava_lang_Boolean_ == IntPtr.Zero)
				id_xor_arrayLjava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "xor", "([Ljava/lang/Boolean;)Ljava/lang/Boolean;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_xor_arrayLjava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

	}
}
