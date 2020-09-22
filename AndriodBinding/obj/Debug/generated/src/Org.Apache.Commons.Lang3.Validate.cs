using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/Validate", DoNotGenerateAcw=true)]
	public partial class Validate : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/Validate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Validate); }
		}

		protected Validate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/constructor[@name='Validate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Validate ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Validate)) {
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

		static IntPtr id_exclusiveBetween_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='exclusiveBetween' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("exclusiveBetween", "(DDD)V", "")]
		public static unsafe void ExclusiveBetween (double start, double end, double value)
		{
			if (id_exclusiveBetween_DDD == IntPtr.Zero)
				id_exclusiveBetween_DDD = JNIEnv.GetStaticMethodID (class_ref, "exclusiveBetween", "(DDD)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (start);
				__args [1] = new JValue (end);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_exclusiveBetween_DDD, __args);
			} finally {
			}
		}

		static IntPtr id_exclusiveBetween_DDDLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='exclusiveBetween' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='java.lang.String']]"
		[Register ("exclusiveBetween", "(DDDLjava/lang/String;)V", "")]
		public static unsafe void ExclusiveBetween (double start, double end, double value, string message)
		{
			if (id_exclusiveBetween_DDDLjava_lang_String_ == IntPtr.Zero)
				id_exclusiveBetween_DDDLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "exclusiveBetween", "(DDDLjava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (start);
				__args [1] = new JValue (end);
				__args [2] = new JValue (value);
				__args [3] = new JValue (native_message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_exclusiveBetween_DDDLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_exclusiveBetween_JJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='exclusiveBetween' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("exclusiveBetween", "(JJJ)V", "")]
		public static unsafe void ExclusiveBetween (long start, long end, long value)
		{
			if (id_exclusiveBetween_JJJ == IntPtr.Zero)
				id_exclusiveBetween_JJJ = JNIEnv.GetStaticMethodID (class_ref, "exclusiveBetween", "(JJJ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (start);
				__args [1] = new JValue (end);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_exclusiveBetween_JJJ, __args);
			} finally {
			}
		}

		static IntPtr id_exclusiveBetween_JJJLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='exclusiveBetween' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("exclusiveBetween", "(JJJLjava/lang/String;)V", "")]
		public static unsafe void ExclusiveBetween (long start, long end, long value, string message)
		{
			if (id_exclusiveBetween_JJJLjava_lang_String_ == IntPtr.Zero)
				id_exclusiveBetween_JJJLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "exclusiveBetween", "(JJJLjava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (start);
				__args [1] = new JValue (end);
				__args [2] = new JValue (value);
				__args [3] = new JValue (native_message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_exclusiveBetween_JJJLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_exclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='exclusiveBetween' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='java.lang.Comparable&lt;T&gt;']]"
		[Register ("exclusiveBetween", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Comparable;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void ExclusiveBetween (global::Java.Lang.Object start, global::Java.Lang.Object end, global::Java.Lang.IComparable value)
		{
			if (id_exclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_ == IntPtr.Zero)
				id_exclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_ = JNIEnv.GetStaticMethodID (class_ref, "exclusiveBetween", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Comparable;)V");
			IntPtr native_start = JNIEnv.ToLocalJniHandle (start);
			IntPtr native_end = JNIEnv.ToLocalJniHandle (end);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_start);
				__args [1] = new JValue (native_end);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_exclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_start);
				JNIEnv.DeleteLocalRef (native_end);
			}
		}

		static IntPtr id_exclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='exclusiveBetween' and count(parameter)=5 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='java.lang.Comparable&lt;T&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object...']]"
		[Register ("exclusiveBetween", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Comparable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void ExclusiveBetween (global::Java.Lang.Object start, global::Java.Lang.Object end, global::Java.Lang.IComparable value, string message, params global::Java.Lang.Object[] values)
		{
			if (id_exclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_exclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "exclusiveBetween", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Comparable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_start = JNIEnv.ToLocalJniHandle (start);
			IntPtr native_end = JNIEnv.ToLocalJniHandle (end);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_start);
				__args [1] = new JValue (native_end);
				__args [2] = new JValue (value);
				__args [3] = new JValue (native_message);
				__args [4] = new JValue (native_values);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_exclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_start);
				JNIEnv.DeleteLocalRef (native_end);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_finite_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='finite' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("finite", "(D)V", "")]
		public static unsafe void Finite (double value)
		{
			if (id_finite_D == IntPtr.Zero)
				id_finite_D = JNIEnv.GetStaticMethodID (class_ref, "finite", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_finite_D, __args);
			} finally {
			}
		}

		static IntPtr id_finite_DLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='finite' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("finite", "(DLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Finite (double value, string message, params global::Java.Lang.Object[] values)
		{
			if (id_finite_DLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_finite_DLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "finite", "(DLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (value);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_finite_DLjava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_inclusiveBetween_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='inclusiveBetween' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("inclusiveBetween", "(DDD)V", "")]
		public static unsafe void InclusiveBetween (double start, double end, double value)
		{
			if (id_inclusiveBetween_DDD == IntPtr.Zero)
				id_inclusiveBetween_DDD = JNIEnv.GetStaticMethodID (class_ref, "inclusiveBetween", "(DDD)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (start);
				__args [1] = new JValue (end);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_inclusiveBetween_DDD, __args);
			} finally {
			}
		}

		static IntPtr id_inclusiveBetween_DDDLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='inclusiveBetween' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='java.lang.String']]"
		[Register ("inclusiveBetween", "(DDDLjava/lang/String;)V", "")]
		public static unsafe void InclusiveBetween (double start, double end, double value, string message)
		{
			if (id_inclusiveBetween_DDDLjava_lang_String_ == IntPtr.Zero)
				id_inclusiveBetween_DDDLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "inclusiveBetween", "(DDDLjava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (start);
				__args [1] = new JValue (end);
				__args [2] = new JValue (value);
				__args [3] = new JValue (native_message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_inclusiveBetween_DDDLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_inclusiveBetween_JJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='inclusiveBetween' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("inclusiveBetween", "(JJJ)V", "")]
		public static unsafe void InclusiveBetween (long start, long end, long value)
		{
			if (id_inclusiveBetween_JJJ == IntPtr.Zero)
				id_inclusiveBetween_JJJ = JNIEnv.GetStaticMethodID (class_ref, "inclusiveBetween", "(JJJ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (start);
				__args [1] = new JValue (end);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_inclusiveBetween_JJJ, __args);
			} finally {
			}
		}

		static IntPtr id_inclusiveBetween_JJJLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='inclusiveBetween' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("inclusiveBetween", "(JJJLjava/lang/String;)V", "")]
		public static unsafe void InclusiveBetween (long start, long end, long value, string message)
		{
			if (id_inclusiveBetween_JJJLjava_lang_String_ == IntPtr.Zero)
				id_inclusiveBetween_JJJLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "inclusiveBetween", "(JJJLjava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (start);
				__args [1] = new JValue (end);
				__args [2] = new JValue (value);
				__args [3] = new JValue (native_message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_inclusiveBetween_JJJLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_inclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='inclusiveBetween' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='java.lang.Comparable&lt;T&gt;']]"
		[Register ("inclusiveBetween", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Comparable;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void InclusiveBetween (global::Java.Lang.Object start, global::Java.Lang.Object end, global::Java.Lang.IComparable value)
		{
			if (id_inclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_ == IntPtr.Zero)
				id_inclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_ = JNIEnv.GetStaticMethodID (class_ref, "inclusiveBetween", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Comparable;)V");
			IntPtr native_start = JNIEnv.ToLocalJniHandle (start);
			IntPtr native_end = JNIEnv.ToLocalJniHandle (end);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_start);
				__args [1] = new JValue (native_end);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_inclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_start);
				JNIEnv.DeleteLocalRef (native_end);
			}
		}

		static IntPtr id_inclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='inclusiveBetween' and count(parameter)=5 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='java.lang.Comparable&lt;T&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object...']]"
		[Register ("inclusiveBetween", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Comparable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void InclusiveBetween (global::Java.Lang.Object start, global::Java.Lang.Object end, global::Java.Lang.IComparable value, string message, params global::Java.Lang.Object[] values)
		{
			if (id_inclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_inclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "inclusiveBetween", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Comparable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_start = JNIEnv.ToLocalJniHandle (start);
			IntPtr native_end = JNIEnv.ToLocalJniHandle (end);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_start);
				__args [1] = new JValue (native_end);
				__args [2] = new JValue (value);
				__args [3] = new JValue (native_message);
				__args [4] = new JValue (native_values);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_inclusiveBetween_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Comparable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_start);
				JNIEnv.DeleteLocalRef (native_end);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_isAssignableFrom_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='isAssignableFrom' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("isAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Class;)V", "")]
		public static unsafe void IsAssignableFrom (global::Java.Lang.Class superType, global::Java.Lang.Class type)
		{
			if (id_isAssignableFrom_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_isAssignableFrom_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "isAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (superType);
				__args [1] = new JValue (type);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_isAssignableFrom_Ljava_lang_Class_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static IntPtr id_isAssignableFrom_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='isAssignableFrom' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("isAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void IsAssignableFrom (global::Java.Lang.Class superType, global::Java.Lang.Class type, string message, params global::Java.Lang.Object[] values)
		{
			if (id_isAssignableFrom_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_isAssignableFrom_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (superType);
				__args [1] = new JValue (type);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_values);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_isAssignableFrom_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_isInstanceOf_Ljava_lang_Class_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='isInstanceOf' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("isInstanceOf", "(Ljava/lang/Class;Ljava/lang/Object;)V", "")]
		public static unsafe void IsInstanceOf (global::Java.Lang.Class type, global::Java.Lang.Object obj)
		{
			if (id_isInstanceOf_Ljava_lang_Class_Ljava_lang_Object_ == IntPtr.Zero)
				id_isInstanceOf_Ljava_lang_Class_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isInstanceOf", "(Ljava/lang/Class;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (type);
				__args [1] = new JValue (obj);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_isInstanceOf_Ljava_lang_Class_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_isInstanceOf_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='isInstanceOf' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("isInstanceOf", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void IsInstanceOf (global::Java.Lang.Class type, global::Java.Lang.Object obj, string message, params global::Java.Lang.Object[] values)
		{
			if (id_isInstanceOf_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_isInstanceOf_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isInstanceOf", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (type);
				__args [1] = new JValue (obj);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_values);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_isInstanceOf_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_isTrue_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='isTrue' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isTrue", "(Z)V", "")]
		public static unsafe void IsTrue (bool expression)
		{
			if (id_isTrue_Z == IntPtr.Zero)
				id_isTrue_Z = JNIEnv.GetStaticMethodID (class_ref, "isTrue", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (expression);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_isTrue_Z, __args);
			} finally {
			}
		}

		static IntPtr id_isTrue_ZLjava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='isTrue' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("isTrue", "(ZLjava/lang/String;D)V", "")]
		public static unsafe void IsTrue (bool expression, string message, double value)
		{
			if (id_isTrue_ZLjava_lang_String_D == IntPtr.Zero)
				id_isTrue_ZLjava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "isTrue", "(ZLjava/lang/String;D)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (expression);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_isTrue_ZLjava_lang_String_D, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_isTrue_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='isTrue' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("isTrue", "(ZLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void IsTrue (bool expression, string message, params global::Java.Lang.Object[] values)
		{
			if (id_isTrue_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_isTrue_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isTrue", "(ZLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (expression);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_isTrue_ZLjava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_isTrue_ZLjava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='isTrue' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("isTrue", "(ZLjava/lang/String;J)V", "")]
		public static unsafe void IsTrue (bool expression, string message, long value)
		{
			if (id_isTrue_ZLjava_lang_String_J == IntPtr.Zero)
				id_isTrue_ZLjava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "isTrue", "(ZLjava/lang/String;J)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (expression);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_isTrue_ZLjava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_matchesPattern_Ljava_lang_CharSequence_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='matchesPattern' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.String']]"
		[Register ("matchesPattern", "(Ljava/lang/CharSequence;Ljava/lang/String;)V", "")]
		public static unsafe void MatchesPattern (global::Java.Lang.ICharSequence input, string pattern)
		{
			if (id_matchesPattern_Ljava_lang_CharSequence_Ljava_lang_String_ == IntPtr.Zero)
				id_matchesPattern_Ljava_lang_CharSequence_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "matchesPattern", "(Ljava/lang/CharSequence;Ljava/lang/String;)V");
			IntPtr native_input = CharSequence.ToLocalJniHandle (input);
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (native_pattern);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_matchesPattern_Ljava_lang_CharSequence_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		public static void MatchesPattern (string input, string pattern)
		{
			var jls_input = input == null ? null : new global::Java.Lang.String (input);
			MatchesPattern (jls_input, pattern);
			jls_input?.Dispose ();
		}

		static IntPtr id_matchesPattern_Ljava_lang_CharSequence_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='matchesPattern' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("matchesPattern", "(Ljava/lang/CharSequence;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void MatchesPattern (global::Java.Lang.ICharSequence input, string pattern, string message, params global::Java.Lang.Object[] values)
		{
			if (id_matchesPattern_Ljava_lang_CharSequence_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_matchesPattern_Ljava_lang_CharSequence_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "matchesPattern", "(Ljava/lang/CharSequence;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_input = CharSequence.ToLocalJniHandle (input);
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (native_pattern);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_values);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_matchesPattern_Ljava_lang_CharSequence_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_pattern);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		public static void MatchesPattern (string input, string pattern, string message, params global::Java.Lang.Object[] values)
		{
			var jls_input = input == null ? null : new global::Java.Lang.String (input);
			MatchesPattern (jls_input, pattern, message, values);
			jls_input?.Dispose ();
		}

		static IntPtr id_noNullElements_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='noNullElements' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("noNullElements", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Iterable<?>"})]
		public static unsafe global::Java.Lang.Object NoNullElements (global::Java.Lang.Object iterable)
		{
			if (id_noNullElements_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_noNullElements_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "noNullElements", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;");
			IntPtr native_iterable = JNIEnv.ToLocalJniHandle (iterable);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_iterable);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_noNullElements_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_iterable);
			}
		}

		static IntPtr id_noNullElements_Ljava_lang_Iterable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='noNullElements' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("noNullElements", "(Ljava/lang/Iterable;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Iterable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Iterable<?>"})]
		public static unsafe global::Java.Lang.Object NoNullElements (global::Java.Lang.Object iterable, string message, params global::Java.Lang.Object[] values)
		{
			if (id_noNullElements_Ljava_lang_Iterable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_noNullElements_Ljava_lang_Iterable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "noNullElements", "(Ljava/lang/Iterable;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Iterable;");
			IntPtr native_iterable = JNIEnv.ToLocalJniHandle (iterable);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_iterable);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_noNullElements_Ljava_lang_Iterable_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_iterable);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_noNullElements_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='noNullElements' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register ("noNullElements", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] NoNullElements (global::Java.Lang.Object[] array)
		{
			if (id_noNullElements_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_noNullElements_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "noNullElements", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_noNullElements_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_noNullElements_arrayLjava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='noNullElements' and count(parameter)=3 and parameter[1][@type='T[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("noNullElements", "([Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] NoNullElements (global::Java.Lang.Object[] array, string message, params global::Java.Lang.Object[] values)
		{
			if (id_noNullElements_arrayLjava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_noNullElements_arrayLjava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "noNullElements", "([Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_noNullElements_arrayLjava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_notBlank_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notBlank' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("notBlank", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.CharSequence"})]
		public static unsafe global::Java.Lang.Object NotBlank (global::Java.Lang.Object chars)
		{
			if (id_notBlank_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_notBlank_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "notBlank", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			IntPtr native_chars = JNIEnv.ToLocalJniHandle (chars);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_chars);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notBlank_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_chars);
			}
		}

		public static global::Java.Lang.Object NotBlank (global::Java.Lang.Object chars)
		{
			global::Java.Lang.Object __result = NotBlank (chars);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_notBlank_Ljava_lang_CharSequence_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notBlank' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("notBlank", "(Ljava/lang/CharSequence;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/CharSequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.CharSequence"})]
		public static unsafe global::Java.Lang.Object NotBlank (global::Java.Lang.Object chars, string message, params global::Java.Lang.Object[] values)
		{
			if (id_notBlank_Ljava_lang_CharSequence_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_notBlank_Ljava_lang_CharSequence_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "notBlank", "(Ljava/lang/CharSequence;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/CharSequence;");
			IntPtr native_chars = JNIEnv.ToLocalJniHandle (chars);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_chars);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notBlank_Ljava_lang_CharSequence_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_chars);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		public static global::Java.Lang.Object NotBlank (global::Java.Lang.Object chars, string message, params global::Java.Lang.Object[] values)
		{
			global::Java.Lang.Object __result = NotBlank (chars, message, values);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_notEmpty_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notEmpty' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("notEmpty", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.CharSequence"})]
		public static unsafe global::Java.Lang.Object NotEmpty (global::Java.Lang.Object chars)
		{
			if (id_notEmpty_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_notEmpty_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "notEmpty", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			IntPtr native_chars = JNIEnv.ToLocalJniHandle (chars);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_chars);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notEmpty_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_chars);
			}
		}

		static IntPtr id_notEmpty_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notEmpty' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("notEmpty", "(Ljava/util/Collection;)Ljava/util/Collection;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.util.Collection<?>"})]
		public static unsafe global::Java.Lang.Object NotEmpty (global::Java.Lang.Object collection)
		{
			if (id_notEmpty_Ljava_util_Collection_ == IntPtr.Zero)
				id_notEmpty_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "notEmpty", "(Ljava/util/Collection;)Ljava/util/Collection;");
			IntPtr native_collection = JNIEnv.ToLocalJniHandle (collection);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_collection);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notEmpty_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_collection);
			}
		}

		static IntPtr id_notEmpty_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notEmpty' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("notEmpty", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.util.Map<?, ?>"})]
		public static unsafe global::Java.Lang.Object NotEmpty (global::Java.Lang.Object map)
		{
			if (id_notEmpty_Ljava_util_Map_ == IntPtr.Zero)
				id_notEmpty_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "notEmpty", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_map = JNIEnv.ToLocalJniHandle (map);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_map);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notEmpty_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		static IntPtr id_notEmpty_Ljava_lang_CharSequence_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notEmpty' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("notEmpty", "(Ljava/lang/CharSequence;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/CharSequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.CharSequence"})]
		public static unsafe global::Java.Lang.Object NotEmpty (global::Java.Lang.Object chars, string message, params global::Java.Lang.Object[] values)
		{
			if (id_notEmpty_Ljava_lang_CharSequence_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_notEmpty_Ljava_lang_CharSequence_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "notEmpty", "(Ljava/lang/CharSequence;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/CharSequence;");
			IntPtr native_chars = JNIEnv.ToLocalJniHandle (chars);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_chars);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notEmpty_Ljava_lang_CharSequence_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_chars);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		public static global::Java.Lang.Object NotEmpty (global::Java.Lang.Object chars, string message, params global::Java.Lang.Object[] values)
		{
			global::Java.Lang.Object __result = NotEmpty (chars, message, values);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_notEmpty_Ljava_util_Collection_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notEmpty' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("notEmpty", "(Ljava/util/Collection;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Collection;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.util.Collection<?>"})]
		public static unsafe global::Java.Lang.Object NotEmpty (global::Java.Lang.Object collection, string message, params global::Java.Lang.Object[] values)
		{
			if (id_notEmpty_Ljava_util_Collection_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_notEmpty_Ljava_util_Collection_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "notEmpty", "(Ljava/util/Collection;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Collection;");
			IntPtr native_collection = JNIEnv.ToLocalJniHandle (collection);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_collection);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notEmpty_Ljava_util_Collection_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_collection);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_notEmpty_Ljava_util_Map_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notEmpty' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("notEmpty", "(Ljava/util/Map;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Map;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.util.Map<?, ?>"})]
		public static unsafe global::Java.Lang.Object NotEmpty (global::Java.Lang.Object map, string message, params global::Java.Lang.Object[] values)
		{
			if (id_notEmpty_Ljava_util_Map_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_notEmpty_Ljava_util_Map_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "notEmpty", "(Ljava/util/Map;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Map;");
			IntPtr native_map = JNIEnv.ToLocalJniHandle (map);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_map);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notEmpty_Ljava_util_Map_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_notEmpty_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notEmpty' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register ("notEmpty", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] NotEmpty (global::Java.Lang.Object[] array)
		{
			if (id_notEmpty_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_notEmpty_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "notEmpty", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_notEmpty_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_notEmpty_arrayLjava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notEmpty' and count(parameter)=3 and parameter[1][@type='T[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("notEmpty", "([Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] NotEmpty (global::Java.Lang.Object[] array, string message, params global::Java.Lang.Object[] values)
		{
			if (id_notEmpty_arrayLjava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_notEmpty_arrayLjava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "notEmpty", "([Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_notEmpty_arrayLjava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_notNaN_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notNaN' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("notNaN", "(D)V", "")]
		public static unsafe void NotNaN (double value)
		{
			if (id_notNaN_D == IntPtr.Zero)
				id_notNaN_D = JNIEnv.GetStaticMethodID (class_ref, "notNaN", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notNaN_D, __args);
			} finally {
			}
		}

		static IntPtr id_notNaN_DLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notNaN' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("notNaN", "(DLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void NotNaN (double value, string message, params global::Java.Lang.Object[] values)
		{
			if (id_notNaN_DLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_notNaN_DLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "notNaN", "(DLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (value);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notNaN_DLjava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_notNull_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("notNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object NotNull (global::Java.Lang.Object @object)
		{
			if (id_notNull_Ljava_lang_Object_ == IntPtr.Zero)
				id_notNull_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "notNull", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__object);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notNull_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
			}
		}

		static IntPtr id_notNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notNull' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("notNull", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object NotNull (global::Java.Lang.Object @object, string message, params global::Java.Lang.Object[] values)
		{
			if (id_notNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_notNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "notNull", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native__object);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_validIndex_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='validIndex' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='int']]"
		[Register ("validIndex", "(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.CharSequence"})]
		public static unsafe global::Java.Lang.Object ValidIndex (global::Java.Lang.Object chars, int index)
		{
			if (id_validIndex_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_validIndex_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "validIndex", "(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;");
			IntPtr native_chars = JNIEnv.ToLocalJniHandle (chars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_chars);
				__args [1] = new JValue (index);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_validIndex_Ljava_lang_CharSequence_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_chars);
			}
		}

		static IntPtr id_validIndex_Ljava_util_Collection_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='validIndex' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='int']]"
		[Register ("validIndex", "(Ljava/util/Collection;I)Ljava/util/Collection;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.util.Collection<?>"})]
		public static unsafe global::Java.Lang.Object ValidIndex (global::Java.Lang.Object collection, int index)
		{
			if (id_validIndex_Ljava_util_Collection_I == IntPtr.Zero)
				id_validIndex_Ljava_util_Collection_I = JNIEnv.GetStaticMethodID (class_ref, "validIndex", "(Ljava/util/Collection;I)Ljava/util/Collection;");
			IntPtr native_collection = JNIEnv.ToLocalJniHandle (collection);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_collection);
				__args [1] = new JValue (index);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_validIndex_Ljava_util_Collection_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_collection);
			}
		}

		static IntPtr id_validIndex_Ljava_lang_CharSequence_ILjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='validIndex' and count(parameter)=4 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("validIndex", "(Ljava/lang/CharSequence;ILjava/lang/String;[Ljava/lang/Object;)Ljava/lang/CharSequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.CharSequence"})]
		public static unsafe global::Java.Lang.Object ValidIndex (global::Java.Lang.Object chars, int index, string message, params global::Java.Lang.Object[] values)
		{
			if (id_validIndex_Ljava_lang_CharSequence_ILjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_validIndex_Ljava_lang_CharSequence_ILjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "validIndex", "(Ljava/lang/CharSequence;ILjava/lang/String;[Ljava/lang/Object;)Ljava/lang/CharSequence;");
			IntPtr native_chars = JNIEnv.ToLocalJniHandle (chars);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_chars);
				__args [1] = new JValue (index);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_validIndex_Ljava_lang_CharSequence_ILjava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_chars);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		public static global::Java.Lang.Object ValidIndex (global::Java.Lang.Object chars, int index, string message, params global::Java.Lang.Object[] values)
		{
			global::Java.Lang.Object __result = ValidIndex (chars, index, message, values);
			var __rsval = __result;
			return __rsval;
		}

		static IntPtr id_validIndex_Ljava_util_Collection_ILjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='validIndex' and count(parameter)=4 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("validIndex", "(Ljava/util/Collection;ILjava/lang/String;[Ljava/lang/Object;)Ljava/util/Collection;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.util.Collection<?>"})]
		public static unsafe global::Java.Lang.Object ValidIndex (global::Java.Lang.Object collection, int index, string message, params global::Java.Lang.Object[] values)
		{
			if (id_validIndex_Ljava_util_Collection_ILjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_validIndex_Ljava_util_Collection_ILjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "validIndex", "(Ljava/util/Collection;ILjava/lang/String;[Ljava/lang/Object;)Ljava/util/Collection;");
			IntPtr native_collection = JNIEnv.ToLocalJniHandle (collection);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_collection);
				__args [1] = new JValue (index);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_validIndex_Ljava_util_Collection_ILjava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_collection);
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_validIndex_arrayLjava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='validIndex' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='int']]"
		[Register ("validIndex", "([Ljava/lang/Object;I)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] ValidIndex (global::Java.Lang.Object[] array, int index)
		{
			if (id_validIndex_arrayLjava_lang_Object_I == IntPtr.Zero)
				id_validIndex_arrayLjava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "validIndex", "([Ljava/lang/Object;I)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_validIndex_arrayLjava_lang_Object_I, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_validIndex_arrayLjava_lang_Object_ILjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='validIndex' and count(parameter)=4 and parameter[1][@type='T[]'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("validIndex", "([Ljava/lang/Object;ILjava/lang/String;[Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] ValidIndex (global::Java.Lang.Object[] array, int index, string message, params global::Java.Lang.Object[] values)
		{
			if (id_validIndex_arrayLjava_lang_Object_ILjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_validIndex_arrayLjava_lang_Object_ILjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "validIndex", "([Ljava/lang/Object;ILjava/lang/String;[Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_values);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_validIndex_arrayLjava_lang_Object_ILjava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_validState_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='validState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("validState", "(Z)V", "")]
		public static unsafe void ValidState (bool expression)
		{
			if (id_validState_Z == IntPtr.Zero)
				id_validState_Z = JNIEnv.GetStaticMethodID (class_ref, "validState", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (expression);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_validState_Z, __args);
			} finally {
			}
		}

		static IntPtr id_validState_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='validState' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("validState", "(ZLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void ValidState (bool expression, string message, params global::Java.Lang.Object[] values)
		{
			if (id_validState_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_validState_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "validState", "(ZLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (expression);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_validState_ZLjava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

	}
}
