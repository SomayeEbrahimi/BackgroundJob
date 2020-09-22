using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Math {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/math/IEEE754rUtils", DoNotGenerateAcw=true)]
	public partial class IEEE754rUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/math/IEEE754rUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEEE754rUtils); }
		}

		protected IEEE754rUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/constructor[@name='IEEE754rUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IEEE754rUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IEEE754rUtils)) {
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

		static IntPtr id_max_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='max' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("max", "(DD)D", "")]
		public static unsafe double Max (double a, double b)
		{
			if (id_max_DD == IntPtr.Zero)
				id_max_DD = JNIEnv.GetStaticMethodID (class_ref, "max", "(DD)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_max_DD, __args);
			} finally {
			}
		}

		static IntPtr id_max_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='max' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='max' and count(parameter)=1 and parameter[1][@type='double...']]"
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

		static IntPtr id_max_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='max' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("max", "(FF)F", "")]
		public static unsafe float Max (float a, float b)
		{
			if (id_max_FF == IntPtr.Zero)
				id_max_FF = JNIEnv.GetStaticMethodID (class_ref, "max", "(FF)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_max_FF, __args);
			} finally {
			}
		}

		static IntPtr id_max_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='max' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='max' and count(parameter)=1 and parameter[1][@type='float...']]"
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

		static IntPtr id_min_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='min' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("min", "(DD)D", "")]
		public static unsafe double Min (double a, double b)
		{
			if (id_min_DD == IntPtr.Zero)
				id_min_DD = JNIEnv.GetStaticMethodID (class_ref, "min", "(DD)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_min_DD, __args);
			} finally {
			}
		}

		static IntPtr id_min_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='min' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='min' and count(parameter)=1 and parameter[1][@type='double...']]"
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

		static IntPtr id_min_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='min' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("min", "(FF)F", "")]
		public static unsafe float Min (float a, float b)
		{
			if (id_min_FF == IntPtr.Zero)
				id_min_FF = JNIEnv.GetStaticMethodID (class_ref, "min", "(FF)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_min_FF, __args);
			} finally {
			}
		}

		static IntPtr id_min_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='min' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.math']/class[@name='IEEE754rUtils']/method[@name='min' and count(parameter)=1 and parameter[1][@type='float...']]"
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

	}
}
