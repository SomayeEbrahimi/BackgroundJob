using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Math {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/math/Fraction", DoNotGenerateAcw=true)]
	public sealed partial class Fraction : global::Java.Lang.Number, global::Java.Lang.IComparable {


		static IntPtr FOUR_FIFTHS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='FOUR_FIFTHS']"
		[Register ("FOUR_FIFTHS")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction FourFifths {
			get {
				if (FOUR_FIFTHS_jfieldId == IntPtr.Zero)
					FOUR_FIFTHS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FOUR_FIFTHS", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FOUR_FIFTHS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='ONE']"
		[Register ("ONE")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction One {
			get {
				if (ONE_jfieldId == IntPtr.Zero)
					ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONE", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ONE_FIFTH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='ONE_FIFTH']"
		[Register ("ONE_FIFTH")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction OneFifth {
			get {
				if (ONE_FIFTH_jfieldId == IntPtr.Zero)
					ONE_FIFTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONE_FIFTH", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONE_FIFTH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ONE_HALF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='ONE_HALF']"
		[Register ("ONE_HALF")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction OneHalf {
			get {
				if (ONE_HALF_jfieldId == IntPtr.Zero)
					ONE_HALF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONE_HALF", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONE_HALF_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ONE_QUARTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='ONE_QUARTER']"
		[Register ("ONE_QUARTER")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction OneQuarter {
			get {
				if (ONE_QUARTER_jfieldId == IntPtr.Zero)
					ONE_QUARTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONE_QUARTER", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONE_QUARTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ONE_THIRD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='ONE_THIRD']"
		[Register ("ONE_THIRD")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction OneThird {
			get {
				if (ONE_THIRD_jfieldId == IntPtr.Zero)
					ONE_THIRD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONE_THIRD", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONE_THIRD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THREE_FIFTHS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='THREE_FIFTHS']"
		[Register ("THREE_FIFTHS")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction ThreeFifths {
			get {
				if (THREE_FIFTHS_jfieldId == IntPtr.Zero)
					THREE_FIFTHS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREE_FIFTHS", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREE_FIFTHS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THREE_QUARTERS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='THREE_QUARTERS']"
		[Register ("THREE_QUARTERS")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction ThreeQuarters {
			get {
				if (THREE_QUARTERS_jfieldId == IntPtr.Zero)
					THREE_QUARTERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREE_QUARTERS", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREE_QUARTERS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TWO_FIFTHS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='TWO_FIFTHS']"
		[Register ("TWO_FIFTHS")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction TwoFifths {
			get {
				if (TWO_FIFTHS_jfieldId == IntPtr.Zero)
					TWO_FIFTHS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWO_FIFTHS", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWO_FIFTHS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TWO_QUARTERS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='TWO_QUARTERS']"
		[Register ("TWO_QUARTERS")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction TwoQuarters {
			get {
				if (TWO_QUARTERS_jfieldId == IntPtr.Zero)
					TWO_QUARTERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWO_QUARTERS", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWO_QUARTERS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TWO_THIRDS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='TWO_THIRDS']"
		[Register ("TWO_THIRDS")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction TwoThirds {
			get {
				if (TWO_THIRDS_jfieldId == IntPtr.Zero)
					TWO_THIRDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWO_THIRDS", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWO_THIRDS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ZERO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/field[@name='ZERO']"
		[Register ("ZERO")]
		public static global::Org.Apache.Commons.Lang3.Math.Fraction Zero {
			get {
				if (ZERO_jfieldId == IntPtr.Zero)
					ZERO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ZERO", "Lorg/apache/commons/lang3/math/Fraction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ZERO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/math/Fraction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Fraction); }
		}

		internal Fraction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDenominator;
		public unsafe int Denominator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='getDenominator' and count(parameter)=0]"
			[Register ("getDenominator", "()I", "")]
			get {
				if (id_getDenominator == IntPtr.Zero)
					id_getDenominator = JNIEnv.GetMethodID (class_ref, "getDenominator", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDenominator);
				} finally {
				}
			}
		}

		static IntPtr id_getNumerator;
		public unsafe int Numerator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='getNumerator' and count(parameter)=0]"
			[Register ("getNumerator", "()I", "")]
			get {
				if (id_getNumerator == IntPtr.Zero)
					id_getNumerator = JNIEnv.GetMethodID (class_ref, "getNumerator", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumerator);
				} finally {
				}
			}
		}

		static IntPtr id_getProperNumerator;
		public unsafe int ProperNumerator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='getProperNumerator' and count(parameter)=0]"
			[Register ("getProperNumerator", "()I", "")]
			get {
				if (id_getProperNumerator == IntPtr.Zero)
					id_getProperNumerator = JNIEnv.GetMethodID (class_ref, "getProperNumerator", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getProperNumerator);
				} finally {
				}
			}
		}

		static IntPtr id_getProperWhole;
		public unsafe int ProperWhole {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='getProperWhole' and count(parameter)=0]"
			[Register ("getProperWhole", "()I", "")]
			get {
				if (id_getProperWhole == IntPtr.Zero)
					id_getProperWhole = JNIEnv.GetMethodID (class_ref, "getProperWhole", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getProperWhole);
				} finally {
				}
			}
		}

		static IntPtr id_abs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='abs' and count(parameter)=0]"
		[Register ("abs", "()Lorg/apache/commons/lang3/math/Fraction;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Math.Fraction Abs ()
		{
			if (id_abs == IntPtr.Zero)
				id_abs = JNIEnv.GetMethodID (class_ref, "abs", "()Lorg/apache/commons/lang3/math/Fraction;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_abs), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_add_Lorg_apache_commons_lang3_math_Fraction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.math.Fraction']]"
		[Register ("add", "(Lorg/apache/commons/lang3/math/Fraction;)Lorg/apache/commons/lang3/math/Fraction;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Math.Fraction Add (global::Org.Apache.Commons.Lang3.Math.Fraction fraction)
		{
			if (id_add_Lorg_apache_commons_lang3_math_Fraction_ == IntPtr.Zero)
				id_add_Lorg_apache_commons_lang3_math_Fraction_ = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/apache/commons/lang3/math/Fraction;)Lorg/apache/commons/lang3/math/Fraction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (fraction);
				global::Org.Apache.Commons.Lang3.Math.Fraction __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Lorg_apache_commons_lang3_math_Fraction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_compareTo_Lorg_apache_commons_lang3_math_Fraction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.math.Fraction']]"
		[Register ("compareTo", "(Lorg/apache/commons/lang3/math/Fraction;)I", "")]
		public unsafe int CompareTo (global::Org.Apache.Commons.Lang3.Math.Fraction other)
		{
			if (id_compareTo_Lorg_apache_commons_lang3_math_Fraction_ == IntPtr.Zero)
				id_compareTo_Lorg_apache_commons_lang3_math_Fraction_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lorg/apache/commons/lang3/math/Fraction;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Lorg_apache_commons_lang3_math_Fraction_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_divideBy_Lorg_apache_commons_lang3_math_Fraction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='divideBy' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.math.Fraction']]"
		[Register ("divideBy", "(Lorg/apache/commons/lang3/math/Fraction;)Lorg/apache/commons/lang3/math/Fraction;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Math.Fraction DivideBy (global::Org.Apache.Commons.Lang3.Math.Fraction fraction)
		{
			if (id_divideBy_Lorg_apache_commons_lang3_math_Fraction_ == IntPtr.Zero)
				id_divideBy_Lorg_apache_commons_lang3_math_Fraction_ = JNIEnv.GetMethodID (class_ref, "divideBy", "(Lorg/apache/commons/lang3/math/Fraction;)Lorg/apache/commons/lang3/math/Fraction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (fraction);
				global::Org.Apache.Commons.Lang3.Math.Fraction __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divideBy_Lorg_apache_commons_lang3_math_Fraction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doubleValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='doubleValue' and count(parameter)=0]"
		[Register ("doubleValue", "()D", "")]
		public override unsafe double DoubleValue ()
		{
			if (id_doubleValue == IntPtr.Zero)
				id_doubleValue = JNIEnv.GetMethodID (class_ref, "doubleValue", "()D");
			try {
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_doubleValue);
			} finally {
			}
		}

		static IntPtr id_floatValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='floatValue' and count(parameter)=0]"
		[Register ("floatValue", "()F", "")]
		public override unsafe float FloatValue ()
		{
			if (id_floatValue == IntPtr.Zero)
				id_floatValue = JNIEnv.GetMethodID (class_ref, "floatValue", "()F");
			try {
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_floatValue);
			} finally {
			}
		}

		static IntPtr id_getFraction_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='getFraction' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getFraction", "(D)Lorg/apache/commons/lang3/math/Fraction;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Math.Fraction GetFraction (double value)
		{
			if (id_getFraction_D == IntPtr.Zero)
				id_getFraction_D = JNIEnv.GetStaticMethodID (class_ref, "getFraction", "(D)Lorg/apache/commons/lang3/math/Fraction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFraction_D, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getFraction_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='getFraction' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getFraction", "(II)Lorg/apache/commons/lang3/math/Fraction;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Math.Fraction GetFraction (int numerator, int denominator)
		{
			if (id_getFraction_II == IntPtr.Zero)
				id_getFraction_II = JNIEnv.GetStaticMethodID (class_ref, "getFraction", "(II)Lorg/apache/commons/lang3/math/Fraction;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (numerator);
				__args [1] = new JValue (denominator);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFraction_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getFraction_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='getFraction' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getFraction", "(III)Lorg/apache/commons/lang3/math/Fraction;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Math.Fraction GetFraction (int whole, int numerator, int denominator)
		{
			if (id_getFraction_III == IntPtr.Zero)
				id_getFraction_III = JNIEnv.GetStaticMethodID (class_ref, "getFraction", "(III)Lorg/apache/commons/lang3/math/Fraction;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (whole);
				__args [1] = new JValue (numerator);
				__args [2] = new JValue (denominator);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFraction_III, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getFraction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='getFraction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFraction", "(Ljava/lang/String;)Lorg/apache/commons/lang3/math/Fraction;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Math.Fraction GetFraction (string str)
		{
			if (id_getFraction_Ljava_lang_String_ == IntPtr.Zero)
				id_getFraction_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFraction", "(Ljava/lang/String;)Lorg/apache/commons/lang3/math/Fraction;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Org.Apache.Commons.Lang3.Math.Fraction __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFraction_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_getReducedFraction_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='getReducedFraction' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getReducedFraction", "(II)Lorg/apache/commons/lang3/math/Fraction;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Math.Fraction GetReducedFraction (int numerator, int denominator)
		{
			if (id_getReducedFraction_II == IntPtr.Zero)
				id_getReducedFraction_II = JNIEnv.GetStaticMethodID (class_ref, "getReducedFraction", "(II)Lorg/apache/commons/lang3/math/Fraction;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (numerator);
				__args [1] = new JValue (denominator);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getReducedFraction_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_intValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='intValue' and count(parameter)=0]"
		[Register ("intValue", "()I", "")]
		public override unsafe int IntValue ()
		{
			if (id_intValue == IntPtr.Zero)
				id_intValue = JNIEnv.GetMethodID (class_ref, "intValue", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_intValue);
			} finally {
			}
		}

		static IntPtr id_invert;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='invert' and count(parameter)=0]"
		[Register ("invert", "()Lorg/apache/commons/lang3/math/Fraction;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Math.Fraction Invert ()
		{
			if (id_invert == IntPtr.Zero)
				id_invert = JNIEnv.GetMethodID (class_ref, "invert", "()Lorg/apache/commons/lang3/math/Fraction;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invert), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_longValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "")]
		public override unsafe long LongValue ()
		{
			if (id_longValue == IntPtr.Zero)
				id_longValue = JNIEnv.GetMethodID (class_ref, "longValue", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_longValue);
			} finally {
			}
		}

		static IntPtr id_multiplyBy_Lorg_apache_commons_lang3_math_Fraction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='multiplyBy' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.math.Fraction']]"
		[Register ("multiplyBy", "(Lorg/apache/commons/lang3/math/Fraction;)Lorg/apache/commons/lang3/math/Fraction;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Math.Fraction MultiplyBy (global::Org.Apache.Commons.Lang3.Math.Fraction fraction)
		{
			if (id_multiplyBy_Lorg_apache_commons_lang3_math_Fraction_ == IntPtr.Zero)
				id_multiplyBy_Lorg_apache_commons_lang3_math_Fraction_ = JNIEnv.GetMethodID (class_ref, "multiplyBy", "(Lorg/apache/commons/lang3/math/Fraction;)Lorg/apache/commons/lang3/math/Fraction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (fraction);
				global::Org.Apache.Commons.Lang3.Math.Fraction __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_multiplyBy_Lorg_apache_commons_lang3_math_Fraction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_negate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='negate' and count(parameter)=0]"
		[Register ("negate", "()Lorg/apache/commons/lang3/math/Fraction;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Math.Fraction Negate ()
		{
			if (id_negate == IntPtr.Zero)
				id_negate = JNIEnv.GetMethodID (class_ref, "negate", "()Lorg/apache/commons/lang3/math/Fraction;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_negate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_pow_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='pow' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pow", "(I)Lorg/apache/commons/lang3/math/Fraction;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Math.Fraction Pow (int power)
		{
			if (id_pow_I == IntPtr.Zero)
				id_pow_I = JNIEnv.GetMethodID (class_ref, "pow", "(I)Lorg/apache/commons/lang3/math/Fraction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (power);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pow_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_reduce;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='reduce' and count(parameter)=0]"
		[Register ("reduce", "()Lorg/apache/commons/lang3/math/Fraction;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Math.Fraction Reduce ()
		{
			if (id_reduce == IntPtr.Zero)
				id_reduce = JNIEnv.GetMethodID (class_ref, "reduce", "()Lorg/apache/commons/lang3/math/Fraction;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reduce), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_subtract_Lorg_apache_commons_lang3_math_Fraction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.math.Fraction']]"
		[Register ("subtract", "(Lorg/apache/commons/lang3/math/Fraction;)Lorg/apache/commons/lang3/math/Fraction;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Math.Fraction Subtract (global::Org.Apache.Commons.Lang3.Math.Fraction fraction)
		{
			if (id_subtract_Lorg_apache_commons_lang3_math_Fraction_ == IntPtr.Zero)
				id_subtract_Lorg_apache_commons_lang3_math_Fraction_ = JNIEnv.GetMethodID (class_ref, "subtract", "(Lorg/apache/commons/lang3/math/Fraction;)Lorg/apache/commons/lang3/math/Fraction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (fraction);
				global::Org.Apache.Commons.Lang3.Math.Fraction __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Math.Fraction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subtract_Lorg_apache_commons_lang3_math_Fraction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toProperString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='Fraction']/method[@name='toProperString' and count(parameter)=0]"
		[Register ("toProperString", "()Ljava/lang/String;", "")]
		public unsafe string ToProperString ()
		{
			if (id_toProperString == IntPtr.Zero)
				id_toProperString = JNIEnv.GetMethodID (class_ref, "toProperString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toProperString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
