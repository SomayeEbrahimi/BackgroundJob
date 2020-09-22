using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Arith']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/Arith", DoNotGenerateAcw=true)]
	public sealed partial class Arith : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/utils/Arith", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Arith); }
		}

		internal Arith (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_add_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Arith']/method[@name='add' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("add", "(DD)D", "")]
		public static unsafe double Add (double v1, double v2)
		{
			if (id_add_DD == IntPtr.Zero)
				id_add_DD = JNIEnv.GetStaticMethodID (class_ref, "add", "(DD)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (v1);
				__args [1] = new JValue (v2);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_add_DD, __args);
			} finally {
			}
		}

		static IntPtr id_div_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Arith']/method[@name='div' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("div", "(DD)D", "")]
		public static unsafe double Div (double v1, double v2)
		{
			if (id_div_DD == IntPtr.Zero)
				id_div_DD = JNIEnv.GetStaticMethodID (class_ref, "div", "(DD)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (v1);
				__args [1] = new JValue (v2);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_div_DD, __args);
			} finally {
			}
		}

		static IntPtr id_div_DDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Arith']/method[@name='div' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("div", "(DDI)D", "")]
		public static unsafe double Div (double v1, double v2, int scale)
		{
			if (id_div_DDI == IntPtr.Zero)
				id_div_DDI = JNIEnv.GetStaticMethodID (class_ref, "div", "(DDI)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (v1);
				__args [1] = new JValue (v2);
				__args [2] = new JValue (scale);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_div_DDI, __args);
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Arith']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] args)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_mul_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Arith']/method[@name='mul' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("mul", "(DD)D", "")]
		public static unsafe double Mul (double v1, double v2)
		{
			if (id_mul_DD == IntPtr.Zero)
				id_mul_DD = JNIEnv.GetStaticMethodID (class_ref, "mul", "(DD)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (v1);
				__args [1] = new JValue (v2);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_mul_DD, __args);
			} finally {
			}
		}

		static IntPtr id_random_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Arith']/method[@name='random' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("random", "(I)I", "")]
		public static unsafe int Random (int num)
		{
			if (id_random_I == IntPtr.Zero)
				id_random_I = JNIEnv.GetStaticMethodID (class_ref, "random", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (num);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_random_I, __args);
			} finally {
			}
		}

		static IntPtr id_round_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Arith']/method[@name='round' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("round", "(DI)D", "")]
		public static unsafe double Round (double v, int scale)
		{
			if (id_round_DI == IntPtr.Zero)
				id_round_DI = JNIEnv.GetStaticMethodID (class_ref, "round", "(DI)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (v);
				__args [1] = new JValue (scale);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_round_DI, __args);
			} finally {
			}
		}

		static IntPtr id_sub_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Arith']/method[@name='sub' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("sub", "(DD)D", "")]
		public static unsafe double Sub (double v1, double v2)
		{
			if (id_sub_DD == IntPtr.Zero)
				id_sub_DD = JNIEnv.GetStaticMethodID (class_ref, "sub", "(DD)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (v1);
				__args [1] = new JValue (v2);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_sub_DD, __args);
			} finally {
			}
		}

	}
}
