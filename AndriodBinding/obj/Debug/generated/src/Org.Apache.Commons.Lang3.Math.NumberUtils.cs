using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Math {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/math/NumberUtils", DoNotGenerateAcw=true)]
	public partial class NumberUtils : global::Java.Lang.Object {


		static IntPtr BYTE_MINUS_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='BYTE_MINUS_ONE']"
		[Register ("BYTE_MINUS_ONE")]
		public static global::Java.Lang.Byte ByteMinusOne {
			get {
				if (BYTE_MINUS_ONE_jfieldId == IntPtr.Zero)
					BYTE_MINUS_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE_MINUS_ONE", "Ljava/lang/Byte;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_MINUS_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BYTE_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='BYTE_ONE']"
		[Register ("BYTE_ONE")]
		public static global::Java.Lang.Byte ByteOne {
			get {
				if (BYTE_ONE_jfieldId == IntPtr.Zero)
					BYTE_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE_ONE", "Ljava/lang/Byte;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BYTE_ZERO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='BYTE_ZERO']"
		[Register ("BYTE_ZERO")]
		public static global::Java.Lang.Byte ByteZero {
			get {
				if (BYTE_ZERO_jfieldId == IntPtr.Zero)
					BYTE_ZERO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE_ZERO", "Ljava/lang/Byte;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_ZERO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DOUBLE_MINUS_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='DOUBLE_MINUS_ONE']"
		[Register ("DOUBLE_MINUS_ONE")]
		public static global::Java.Lang.Double DoubleMinusOne {
			get {
				if (DOUBLE_MINUS_ONE_jfieldId == IntPtr.Zero)
					DOUBLE_MINUS_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE_MINUS_ONE", "Ljava/lang/Double;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOUBLE_MINUS_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DOUBLE_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='DOUBLE_ONE']"
		[Register ("DOUBLE_ONE")]
		public static global::Java.Lang.Double DoubleOne {
			get {
				if (DOUBLE_ONE_jfieldId == IntPtr.Zero)
					DOUBLE_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE_ONE", "Ljava/lang/Double;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOUBLE_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DOUBLE_ZERO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='DOUBLE_ZERO']"
		[Register ("DOUBLE_ZERO")]
		public static global::Java.Lang.Double DoubleZero {
			get {
				if (DOUBLE_ZERO_jfieldId == IntPtr.Zero)
					DOUBLE_ZERO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE_ZERO", "Ljava/lang/Double;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOUBLE_ZERO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FLOAT_MINUS_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='FLOAT_MINUS_ONE']"
		[Register ("FLOAT_MINUS_ONE")]
		public static global::Java.Lang.Float FloatMinusOne {
			get {
				if (FLOAT_MINUS_ONE_jfieldId == IntPtr.Zero)
					FLOAT_MINUS_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT_MINUS_ONE", "Ljava/lang/Float;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOAT_MINUS_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FLOAT_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='FLOAT_ONE']"
		[Register ("FLOAT_ONE")]
		public static global::Java.Lang.Float FloatOne {
			get {
				if (FLOAT_ONE_jfieldId == IntPtr.Zero)
					FLOAT_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT_ONE", "Ljava/lang/Float;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOAT_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FLOAT_ZERO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='FLOAT_ZERO']"
		[Register ("FLOAT_ZERO")]
		public static global::Java.Lang.Float FloatZero {
			get {
				if (FLOAT_ZERO_jfieldId == IntPtr.Zero)
					FLOAT_ZERO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT_ZERO", "Ljava/lang/Float;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOAT_ZERO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTEGER_MINUS_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='INTEGER_MINUS_ONE']"
		[Register ("INTEGER_MINUS_ONE")]
		public static global::Java.Lang.Integer IntegerMinusOne {
			get {
				if (INTEGER_MINUS_ONE_jfieldId == IntPtr.Zero)
					INTEGER_MINUS_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTEGER_MINUS_ONE", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTEGER_MINUS_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTEGER_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='INTEGER_ONE']"
		[Register ("INTEGER_ONE")]
		public static global::Java.Lang.Integer IntegerOne {
			get {
				if (INTEGER_ONE_jfieldId == IntPtr.Zero)
					INTEGER_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTEGER_ONE", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTEGER_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTEGER_TWO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='INTEGER_TWO']"
		[Register ("INTEGER_TWO")]
		public static global::Java.Lang.Integer IntegerTwo {
			get {
				if (INTEGER_TWO_jfieldId == IntPtr.Zero)
					INTEGER_TWO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTEGER_TWO", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTEGER_TWO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTEGER_ZERO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='INTEGER_ZERO']"
		[Register ("INTEGER_ZERO")]
		public static global::Java.Lang.Integer IntegerZero {
			get {
				if (INTEGER_ZERO_jfieldId == IntPtr.Zero)
					INTEGER_ZERO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTEGER_ZERO", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTEGER_ZERO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LONG_MINUS_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='LONG_MINUS_ONE']"
		[Register ("LONG_MINUS_ONE")]
		public static global::Java.Lang.Long LongMinusOne {
			get {
				if (LONG_MINUS_ONE_jfieldId == IntPtr.Zero)
					LONG_MINUS_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG_MINUS_ONE", "Ljava/lang/Long;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LONG_MINUS_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LONG_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='LONG_ONE']"
		[Register ("LONG_ONE")]
		public static global::Java.Lang.Long LongOne {
			get {
				if (LONG_ONE_jfieldId == IntPtr.Zero)
					LONG_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG_ONE", "Ljava/lang/Long;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LONG_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LONG_ZERO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='LONG_ZERO']"
		[Register ("LONG_ZERO")]
		public static global::Java.Lang.Long LongZero {
			get {
				if (LONG_ZERO_jfieldId == IntPtr.Zero)
					LONG_ZERO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG_ZERO", "Ljava/lang/Long;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LONG_ZERO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHORT_MINUS_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='SHORT_MINUS_ONE']"
		[Register ("SHORT_MINUS_ONE")]
		public static global::Java.Lang.Short ShortMinusOne {
			get {
				if (SHORT_MINUS_ONE_jfieldId == IntPtr.Zero)
					SHORT_MINUS_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHORT_MINUS_ONE", "Ljava/lang/Short;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHORT_MINUS_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHORT_ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='SHORT_ONE']"
		[Register ("SHORT_ONE")]
		public static global::Java.Lang.Short ShortOne {
			get {
				if (SHORT_ONE_jfieldId == IntPtr.Zero)
					SHORT_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHORT_ONE", "Ljava/lang/Short;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHORT_ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHORT_ZERO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/field[@name='SHORT_ZERO']"
		[Register ("SHORT_ZERO")]
		public static global::Java.Lang.Short ShortZero {
			get {
				if (SHORT_ZERO_jfieldId == IntPtr.Zero)
					SHORT_ZERO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHORT_ZERO", "Ljava/lang/Short;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHORT_ZERO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/math/NumberUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NumberUtils); }
		}

		protected NumberUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/constructor[@name='NumberUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NumberUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NumberUtils)) {
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

		static IntPtr id_compare_BB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("compare", "(BB)I", "")]
		public static unsafe int Compare (sbyte x, sbyte y)
		{
			if (id_compare_BB == IntPtr.Zero)
				id_compare_BB = JNIEnv.GetStaticMethodID (class_ref, "compare", "(BB)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compare_BB, __args);
			} finally {
			}
		}

		static IntPtr id_compare_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("compare", "(II)I", "")]
		public static unsafe int Compare (int x, int y)
		{
			if (id_compare_II == IntPtr.Zero)
				id_compare_II = JNIEnv.GetStaticMethodID (class_ref, "compare", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compare_II, __args);
			} finally {
			}
		}

		static IntPtr id_compare_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("compare", "(JJ)I", "")]
		public static unsafe int Compare (long x, long y)
		{
			if (id_compare_JJ == IntPtr.Zero)
				id_compare_JJ = JNIEnv.GetStaticMethodID (class_ref, "compare", "(JJ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compare_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_compare_SS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
		[Register ("compare", "(SS)I", "")]
		public static unsafe int Compare (short x, short y)
		{
			if (id_compare_SS == IntPtr.Zero)
				id_compare_SS = JNIEnv.GetStaticMethodID (class_ref, "compare", "(SS)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compare_SS, __args);
			} finally {
			}
		}

		static IntPtr id_createBigDecimal_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='createBigDecimal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal CreateBigDecimal (string str)
		{
			if (id_createBigDecimal_Ljava_lang_String_ == IntPtr.Zero)
				id_createBigDecimal_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Java.Math.BigDecimal __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBigDecimal_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_createBigInteger_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='createBigInteger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createBigInteger", "(Ljava/lang/String;)Ljava/math/BigInteger;", "")]
		public static unsafe global::Java.Math.BigInteger CreateBigInteger (string str)
		{
			if (id_createBigInteger_Ljava_lang_String_ == IntPtr.Zero)
				id_createBigInteger_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createBigInteger", "(Ljava/lang/String;)Ljava/math/BigInteger;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Java.Math.BigInteger __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBigInteger_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_createDouble_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='createDouble' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createDouble", "(Ljava/lang/String;)Ljava/lang/Double;", "")]
		public static unsafe global::Java.Lang.Double CreateDouble (string str)
		{
			if (id_createDouble_Ljava_lang_String_ == IntPtr.Zero)
				id_createDouble_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createDouble", "(Ljava/lang/String;)Ljava/lang/Double;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Java.Lang.Double __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDouble_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_createFloat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='createFloat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createFloat", "(Ljava/lang/String;)Ljava/lang/Float;", "")]
		public static unsafe global::Java.Lang.Float CreateFloat (string str)
		{
			if (id_createFloat_Ljava_lang_String_ == IntPtr.Zero)
				id_createFloat_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createFloat", "(Ljava/lang/String;)Ljava/lang/Float;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Java.Lang.Float __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFloat_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_createInteger_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='createInteger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createInteger", "(Ljava/lang/String;)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer CreateInteger (string str)
		{
			if (id_createInteger_Ljava_lang_String_ == IntPtr.Zero)
				id_createInteger_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createInteger_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_createLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='createLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createLong", "(Ljava/lang/String;)Ljava/lang/Long;", "")]
		public static unsafe global::Java.Lang.Long CreateLong (string str)
		{
			if (id_createLong_Ljava_lang_String_ == IntPtr.Zero)
				id_createLong_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLong_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_createNumber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='createNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createNumber", "(Ljava/lang/String;)Ljava/lang/Number;", "")]
		public static unsafe global::Java.Lang.Number CreateNumber (string str)
		{
			if (id_createNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_createNumber_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createNumber", "(Ljava/lang/String;)Ljava/lang/Number;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Java.Lang.Number __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createNumber_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_isCreatable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='isCreatable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isCreatable", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsCreatable (string str)
		{
			if (id_isCreatable_Ljava_lang_String_ == IntPtr.Zero)
				id_isCreatable_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isCreatable", "(Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCreatable_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_isDigits_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='isDigits' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isDigits", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsDigits (string str)
		{
			if (id_isDigits_Ljava_lang_String_ == IntPtr.Zero)
				id_isDigits_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isDigits", "(Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDigits_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_isNumber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='isNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("isNumber", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsNumber (string str)
		{
			if (id_isNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_isNumber_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isNumber", "(Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNumber_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_isParsable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='isParsable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isParsable", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsParsable (string str)
		{
			if (id_isParsable_Ljava_lang_String_ == IntPtr.Zero)
				id_isParsable_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isParsable", "(Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isParsable_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_max_BBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte']]"
		[Register ("max", "(BBB)B", "")]
		public static unsafe sbyte Max (sbyte a, sbyte b, sbyte c)
		{
			if (id_max_BBB == IntPtr.Zero)
				id_max_BBB = JNIEnv.GetStaticMethodID (class_ref, "max", "(BBB)B");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_max_BBB, __args);
			} finally {
			}
		}

		static IntPtr id_max_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=1 and parameter[1][@type='byte...']]"
		[Register ("max", "([B)B", "")]
		public static unsafe sbyte Max (params byte[] array)
		{
			if (id_max_arrayB == IntPtr.Zero)
				id_max_arrayB = JNIEnv.GetStaticMethodID (class_ref, "max", "([B)B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				sbyte __ret = JNIEnv.CallStaticByteMethod  (class_ref, id_max_arrayB, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_max_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("max", "(DDD)D", "")]
		public static unsafe double Max (double a, double b, double c)
		{
			if (id_max_DDD == IntPtr.Zero)
				id_max_DDD = JNIEnv.GetStaticMethodID (class_ref, "max", "(DDD)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_max_DDD, __args);
			} finally {
			}
		}

		static IntPtr id_max_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=1 and parameter[1][@type='double...']]"
		[Register ("max", "([D)D", "")]
		public static unsafe double Max (params double[] array)
		{
			if (id_max_arrayD == IntPtr.Zero)
				id_max_arrayD = JNIEnv.GetStaticMethodID (class_ref, "max", "([D)D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_max_arrayD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_max_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("max", "(FFF)F", "")]
		public static unsafe float Max (float a, float b, float c)
		{
			if (id_max_FFF == IntPtr.Zero)
				id_max_FFF = JNIEnv.GetStaticMethodID (class_ref, "max", "(FFF)F");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_max_FFF, __args);
			} finally {
			}
		}

		static IntPtr id_max_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=1 and parameter[1][@type='float...']]"
		[Register ("max", "([F)F", "")]
		public static unsafe float Max (params float[] array)
		{
			if (id_max_arrayF == IntPtr.Zero)
				id_max_arrayF = JNIEnv.GetStaticMethodID (class_ref, "max", "([F)F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_max_arrayF, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_max_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("max", "(III)I", "")]
		public static unsafe int Max (int a, int b, int c)
		{
			if (id_max_III == IntPtr.Zero)
				id_max_III = JNIEnv.GetStaticMethodID (class_ref, "max", "(III)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_max_III, __args);
			} finally {
			}
		}

		static IntPtr id_max_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("max", "([I)I", "")]
		public static unsafe int Max (params int[] array)
		{
			if (id_max_arrayI == IntPtr.Zero)
				id_max_arrayI = JNIEnv.GetStaticMethodID (class_ref, "max", "([I)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_max_arrayI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_max_JJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("max", "(JJJ)J", "")]
		public static unsafe long Max (long a, long b, long c)
		{
			if (id_max_JJJ == IntPtr.Zero)
				id_max_JJJ = JNIEnv.GetStaticMethodID (class_ref, "max", "(JJJ)J");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_max_JJJ, __args);
			} finally {
			}
		}

		static IntPtr id_max_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=1 and parameter[1][@type='long...']]"
		[Register ("max", "([J)J", "")]
		public static unsafe long Max (params long[] array)
		{
			if (id_max_arrayJ == IntPtr.Zero)
				id_max_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "max", "([J)J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_max_arrayJ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_max_SSS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=3 and parameter[1][@type='short'] and parameter[2][@type='short'] and parameter[3][@type='short']]"
		[Register ("max", "(SSS)S", "")]
		public static unsafe short Max (short a, short b, short c)
		{
			if (id_max_SSS == IntPtr.Zero)
				id_max_SSS = JNIEnv.GetStaticMethodID (class_ref, "max", "(SSS)S");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticShortMethod  (class_ref, id_max_SSS, __args);
			} finally {
			}
		}

		static IntPtr id_max_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='max' and count(parameter)=1 and parameter[1][@type='short...']]"
		[Register ("max", "([S)S", "")]
		public static unsafe short Max (params short[] array)
		{
			if (id_max_arrayS == IntPtr.Zero)
				id_max_arrayS = JNIEnv.GetStaticMethodID (class_ref, "max", "([S)S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_max_arrayS, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_min_BBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte']]"
		[Register ("min", "(BBB)B", "")]
		public static unsafe sbyte Min (sbyte a, sbyte b, sbyte c)
		{
			if (id_min_BBB == IntPtr.Zero)
				id_min_BBB = JNIEnv.GetStaticMethodID (class_ref, "min", "(BBB)B");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_min_BBB, __args);
			} finally {
			}
		}

		static IntPtr id_min_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=1 and parameter[1][@type='byte...']]"
		[Register ("min", "([B)B", "")]
		public static unsafe sbyte Min (params byte[] array)
		{
			if (id_min_arrayB == IntPtr.Zero)
				id_min_arrayB = JNIEnv.GetStaticMethodID (class_ref, "min", "([B)B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				sbyte __ret = JNIEnv.CallStaticByteMethod  (class_ref, id_min_arrayB, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_min_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("min", "(DDD)D", "")]
		public static unsafe double Min (double a, double b, double c)
		{
			if (id_min_DDD == IntPtr.Zero)
				id_min_DDD = JNIEnv.GetStaticMethodID (class_ref, "min", "(DDD)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_min_DDD, __args);
			} finally {
			}
		}

		static IntPtr id_min_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=1 and parameter[1][@type='double...']]"
		[Register ("min", "([D)D", "")]
		public static unsafe double Min (params double[] array)
		{
			if (id_min_arrayD == IntPtr.Zero)
				id_min_arrayD = JNIEnv.GetStaticMethodID (class_ref, "min", "([D)D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_min_arrayD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_min_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("min", "(FFF)F", "")]
		public static unsafe float Min (float a, float b, float c)
		{
			if (id_min_FFF == IntPtr.Zero)
				id_min_FFF = JNIEnv.GetStaticMethodID (class_ref, "min", "(FFF)F");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_min_FFF, __args);
			} finally {
			}
		}

		static IntPtr id_min_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=1 and parameter[1][@type='float...']]"
		[Register ("min", "([F)F", "")]
		public static unsafe float Min (params float[] array)
		{
			if (id_min_arrayF == IntPtr.Zero)
				id_min_arrayF = JNIEnv.GetStaticMethodID (class_ref, "min", "([F)F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_min_arrayF, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_min_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("min", "(III)I", "")]
		public static unsafe int Min (int a, int b, int c)
		{
			if (id_min_III == IntPtr.Zero)
				id_min_III = JNIEnv.GetStaticMethodID (class_ref, "min", "(III)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_min_III, __args);
			} finally {
			}
		}

		static IntPtr id_min_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("min", "([I)I", "")]
		public static unsafe int Min (params int[] array)
		{
			if (id_min_arrayI == IntPtr.Zero)
				id_min_arrayI = JNIEnv.GetStaticMethodID (class_ref, "min", "([I)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_min_arrayI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_min_JJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("min", "(JJJ)J", "")]
		public static unsafe long Min (long a, long b, long c)
		{
			if (id_min_JJJ == IntPtr.Zero)
				id_min_JJJ = JNIEnv.GetStaticMethodID (class_ref, "min", "(JJJ)J");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_min_JJJ, __args);
			} finally {
			}
		}

		static IntPtr id_min_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=1 and parameter[1][@type='long...']]"
		[Register ("min", "([J)J", "")]
		public static unsafe long Min (params long[] array)
		{
			if (id_min_arrayJ == IntPtr.Zero)
				id_min_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "min", "([J)J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_min_arrayJ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_min_SSS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=3 and parameter[1][@type='short'] and parameter[2][@type='short'] and parameter[3][@type='short']]"
		[Register ("min", "(SSS)S", "")]
		public static unsafe short Min (short a, short b, short c)
		{
			if (id_min_SSS == IntPtr.Zero)
				id_min_SSS = JNIEnv.GetStaticMethodID (class_ref, "min", "(SSS)S");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (c);
				return JNIEnv.CallStaticShortMethod  (class_ref, id_min_SSS, __args);
			} finally {
			}
		}

		static IntPtr id_min_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='min' and count(parameter)=1 and parameter[1][@type='short...']]"
		[Register ("min", "([S)S", "")]
		public static unsafe short Min (params short[] array)
		{
			if (id_min_arrayS == IntPtr.Zero)
				id_min_arrayS = JNIEnv.GetStaticMethodID (class_ref, "min", "([S)S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_min_arrayS, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toByte_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toByte' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toByte", "(Ljava/lang/String;)B", "")]
		public static unsafe sbyte ToByte (string str)
		{
			if (id_toByte_Ljava_lang_String_ == IntPtr.Zero)
				id_toByte_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toByte", "(Ljava/lang/String;)B");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				sbyte __ret = JNIEnv.CallStaticByteMethod  (class_ref, id_toByte_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toByte_Ljava_lang_String_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toByte' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte']]"
		[Register ("toByte", "(Ljava/lang/String;B)B", "")]
		public static unsafe sbyte ToByte (string str, sbyte defaultValue)
		{
			if (id_toByte_Ljava_lang_String_B == IntPtr.Zero)
				id_toByte_Ljava_lang_String_B = JNIEnv.GetStaticMethodID (class_ref, "toByte", "(Ljava/lang/String;B)B");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (defaultValue);
				sbyte __ret = JNIEnv.CallStaticByteMethod  (class_ref, id_toByte_Ljava_lang_String_B, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toDouble_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toDouble' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toDouble", "(Ljava/lang/String;)D", "")]
		public static unsafe double ToDouble (string str)
		{
			if (id_toDouble_Ljava_lang_String_ == IntPtr.Zero)
				id_toDouble_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toDouble", "(Ljava/lang/String;)D");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_toDouble_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toDouble_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toDouble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("toDouble", "(Ljava/lang/String;D)D", "")]
		public static unsafe double ToDouble (string str, double defaultValue)
		{
			if (id_toDouble_Ljava_lang_String_D == IntPtr.Zero)
				id_toDouble_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "toDouble", "(Ljava/lang/String;D)D");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (defaultValue);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_toDouble_Ljava_lang_String_D, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toDouble_Ljava_math_BigDecimal_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toDouble' and count(parameter)=1 and parameter[1][@type='java.math.BigDecimal']]"
		[Register ("toDouble", "(Ljava/math/BigDecimal;)D", "")]
		public static unsafe double ToDouble (global::Java.Math.BigDecimal value)
		{
			if (id_toDouble_Ljava_math_BigDecimal_ == IntPtr.Zero)
				id_toDouble_Ljava_math_BigDecimal_ = JNIEnv.GetStaticMethodID (class_ref, "toDouble", "(Ljava/math/BigDecimal;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_toDouble_Ljava_math_BigDecimal_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toDouble_Ljava_math_BigDecimal_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toDouble' and count(parameter)=2 and parameter[1][@type='java.math.BigDecimal'] and parameter[2][@type='double']]"
		[Register ("toDouble", "(Ljava/math/BigDecimal;D)D", "")]
		public static unsafe double ToDouble (global::Java.Math.BigDecimal value, double defaultValue)
		{
			if (id_toDouble_Ljava_math_BigDecimal_D == IntPtr.Zero)
				id_toDouble_Ljava_math_BigDecimal_D = JNIEnv.GetStaticMethodID (class_ref, "toDouble", "(Ljava/math/BigDecimal;D)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (value);
				__args [1] = new JValue (defaultValue);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_toDouble_Ljava_math_BigDecimal_D, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toFloat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toFloat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toFloat", "(Ljava/lang/String;)F", "")]
		public static unsafe float ToFloat (string str)
		{
			if (id_toFloat_Ljava_lang_String_ == IntPtr.Zero)
				id_toFloat_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toFloat", "(Ljava/lang/String;)F");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_toFloat_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toFloat_Ljava_lang_String_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("toFloat", "(Ljava/lang/String;F)F", "")]
		public static unsafe float ToFloat (string str, float defaultValue)
		{
			if (id_toFloat_Ljava_lang_String_F == IntPtr.Zero)
				id_toFloat_Ljava_lang_String_F = JNIEnv.GetStaticMethodID (class_ref, "toFloat", "(Ljava/lang/String;F)F");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (defaultValue);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_toFloat_Ljava_lang_String_F, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toInt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toInt", "(Ljava/lang/String;)I", "")]
		public static unsafe int ToInt (string str)
		{
			if (id_toInt_Ljava_lang_String_ == IntPtr.Zero)
				id_toInt_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toInt", "(Ljava/lang/String;)I");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_toInt_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toInt_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("toInt", "(Ljava/lang/String;I)I", "")]
		public static unsafe int ToInt (string str, int defaultValue)
		{
			if (id_toInt_Ljava_lang_String_I == IntPtr.Zero)
				id_toInt_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "toInt", "(Ljava/lang/String;I)I");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (defaultValue);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_toInt_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toLong", "(Ljava/lang/String;)J", "")]
		public static unsafe long ToLong (string str)
		{
			if (id_toLong_Ljava_lang_String_ == IntPtr.Zero)
				id_toLong_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toLong", "(Ljava/lang/String;)J");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_toLong_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toLong_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("toLong", "(Ljava/lang/String;J)J", "")]
		public static unsafe long ToLong (string str, long defaultValue)
		{
			if (id_toLong_Ljava_lang_String_J == IntPtr.Zero)
				id_toLong_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "toLong", "(Ljava/lang/String;J)J");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (defaultValue);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_toLong_Ljava_lang_String_J, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toScaledBigDecimal_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toScaledBigDecimal' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("toScaledBigDecimal", "(Ljava/lang/Double;)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal ToScaledBigDecimal (global::Java.Lang.Double value)
		{
			if (id_toScaledBigDecimal_Ljava_lang_Double_ == IntPtr.Zero)
				id_toScaledBigDecimal_Ljava_lang_Double_ = JNIEnv.GetStaticMethodID (class_ref, "toScaledBigDecimal", "(Ljava/lang/Double;)Ljava/math/BigDecimal;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				global::Java.Math.BigDecimal __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toScaledBigDecimal_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toScaledBigDecimal_Ljava_lang_Double_ILjava_math_RoundingMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toScaledBigDecimal' and count(parameter)=3 and parameter[1][@type='java.lang.Double'] and parameter[2][@type='int'] and parameter[3][@type='java.math.RoundingMode']]"
		[Register ("toScaledBigDecimal", "(Ljava/lang/Double;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal ToScaledBigDecimal (global::Java.Lang.Double value, int scale, global::Java.Math.RoundingMode roundingMode)
		{
			if (id_toScaledBigDecimal_Ljava_lang_Double_ILjava_math_RoundingMode_ == IntPtr.Zero)
				id_toScaledBigDecimal_Ljava_lang_Double_ILjava_math_RoundingMode_ = JNIEnv.GetStaticMethodID (class_ref, "toScaledBigDecimal", "(Ljava/lang/Double;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (value);
				__args [1] = new JValue (scale);
				__args [2] = new JValue (roundingMode);
				global::Java.Math.BigDecimal __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toScaledBigDecimal_Ljava_lang_Double_ILjava_math_RoundingMode_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toScaledBigDecimal_Ljava_lang_Float_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toScaledBigDecimal' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("toScaledBigDecimal", "(Ljava/lang/Float;)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal ToScaledBigDecimal (global::Java.Lang.Float value)
		{
			if (id_toScaledBigDecimal_Ljava_lang_Float_ == IntPtr.Zero)
				id_toScaledBigDecimal_Ljava_lang_Float_ = JNIEnv.GetStaticMethodID (class_ref, "toScaledBigDecimal", "(Ljava/lang/Float;)Ljava/math/BigDecimal;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				global::Java.Math.BigDecimal __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toScaledBigDecimal_Ljava_lang_Float_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toScaledBigDecimal_Ljava_lang_Float_ILjava_math_RoundingMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toScaledBigDecimal' and count(parameter)=3 and parameter[1][@type='java.lang.Float'] and parameter[2][@type='int'] and parameter[3][@type='java.math.RoundingMode']]"
		[Register ("toScaledBigDecimal", "(Ljava/lang/Float;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal ToScaledBigDecimal (global::Java.Lang.Float value, int scale, global::Java.Math.RoundingMode roundingMode)
		{
			if (id_toScaledBigDecimal_Ljava_lang_Float_ILjava_math_RoundingMode_ == IntPtr.Zero)
				id_toScaledBigDecimal_Ljava_lang_Float_ILjava_math_RoundingMode_ = JNIEnv.GetStaticMethodID (class_ref, "toScaledBigDecimal", "(Ljava/lang/Float;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (value);
				__args [1] = new JValue (scale);
				__args [2] = new JValue (roundingMode);
				global::Java.Math.BigDecimal __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toScaledBigDecimal_Ljava_lang_Float_ILjava_math_RoundingMode_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toScaledBigDecimal_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toScaledBigDecimal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toScaledBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal ToScaledBigDecimal (string value)
		{
			if (id_toScaledBigDecimal_Ljava_lang_String_ == IntPtr.Zero)
				id_toScaledBigDecimal_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toScaledBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;");
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::Java.Math.BigDecimal __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toScaledBigDecimal_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_toScaledBigDecimal_Ljava_lang_String_ILjava_math_RoundingMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toScaledBigDecimal' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.math.RoundingMode']]"
		[Register ("toScaledBigDecimal", "(Ljava/lang/String;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal ToScaledBigDecimal (string value, int scale, global::Java.Math.RoundingMode roundingMode)
		{
			if (id_toScaledBigDecimal_Ljava_lang_String_ILjava_math_RoundingMode_ == IntPtr.Zero)
				id_toScaledBigDecimal_Ljava_lang_String_ILjava_math_RoundingMode_ = JNIEnv.GetStaticMethodID (class_ref, "toScaledBigDecimal", "(Ljava/lang/String;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_value);
				__args [1] = new JValue (scale);
				__args [2] = new JValue (roundingMode);
				global::Java.Math.BigDecimal __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toScaledBigDecimal_Ljava_lang_String_ILjava_math_RoundingMode_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_toScaledBigDecimal_Ljava_math_BigDecimal_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toScaledBigDecimal' and count(parameter)=1 and parameter[1][@type='java.math.BigDecimal']]"
		[Register ("toScaledBigDecimal", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal ToScaledBigDecimal (global::Java.Math.BigDecimal value)
		{
			if (id_toScaledBigDecimal_Ljava_math_BigDecimal_ == IntPtr.Zero)
				id_toScaledBigDecimal_Ljava_math_BigDecimal_ = JNIEnv.GetStaticMethodID (class_ref, "toScaledBigDecimal", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				global::Java.Math.BigDecimal __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toScaledBigDecimal_Ljava_math_BigDecimal_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toScaledBigDecimal_Ljava_math_BigDecimal_ILjava_math_RoundingMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toScaledBigDecimal' and count(parameter)=3 and parameter[1][@type='java.math.BigDecimal'] and parameter[2][@type='int'] and parameter[3][@type='java.math.RoundingMode']]"
		[Register ("toScaledBigDecimal", "(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal ToScaledBigDecimal (global::Java.Math.BigDecimal value, int scale, global::Java.Math.RoundingMode roundingMode)
		{
			if (id_toScaledBigDecimal_Ljava_math_BigDecimal_ILjava_math_RoundingMode_ == IntPtr.Zero)
				id_toScaledBigDecimal_Ljava_math_BigDecimal_ILjava_math_RoundingMode_ = JNIEnv.GetStaticMethodID (class_ref, "toScaledBigDecimal", "(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (value);
				__args [1] = new JValue (scale);
				__args [2] = new JValue (roundingMode);
				global::Java.Math.BigDecimal __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toScaledBigDecimal_Ljava_math_BigDecimal_ILjava_math_RoundingMode_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toShort_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toShort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toShort", "(Ljava/lang/String;)S", "")]
		public static unsafe short ToShort (string str)
		{
			if (id_toShort_Ljava_lang_String_ == IntPtr.Zero)
				id_toShort_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toShort", "(Ljava/lang/String;)S");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_toShort_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_toShort_Ljava_lang_String_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='NumberUtils']/method[@name='toShort' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short']]"
		[Register ("toShort", "(Ljava/lang/String;S)S", "")]
		public static unsafe short ToShort (string str, short defaultValue)
		{
			if (id_toShort_Ljava_lang_String_S == IntPtr.Zero)
				id_toShort_Ljava_lang_String_S = JNIEnv.GetStaticMethodID (class_ref, "toShort", "(Ljava/lang/String;S)S");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (defaultValue);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_toShort_Ljava_lang_String_S, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

	}
}
