using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/ObjectUtils", DoNotGenerateAcw=true)]
	public partial class ObjectUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils.Null']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/ObjectUtils$Null", DoNotGenerateAcw=true)]
		public partial class Null : global::Java.Lang.Object, global::Java.IO.ISerializable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/ObjectUtils$Null", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Null); }
			}

			protected Null (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/ObjectUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectUtils); }
		}

		protected ObjectUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/constructor[@name='ObjectUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ObjectUtils)) {
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

		static IntPtr id_CONST_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("CONST", "(Z)Z", "")]
		public static unsafe bool CONST (bool v)
		{
			if (id_CONST_Z == IntPtr.Zero)
				id_CONST_Z = JNIEnv.GetStaticMethodID (class_ref, "CONST", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (v);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_CONST_Z, __args);
			} finally {
			}
		}

		static IntPtr id_CONST_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("CONST", "(B)B", "")]
		public static unsafe sbyte CONST (sbyte v)
		{
			if (id_CONST_B == IntPtr.Zero)
				id_CONST_B = JNIEnv.GetStaticMethodID (class_ref, "CONST", "(B)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (v);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_CONST_B, __args);
			} finally {
			}
		}

		static IntPtr id_CONST_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("CONST", "(C)C", "")]
		public static unsafe char CONST (char v)
		{
			if (id_CONST_C == IntPtr.Zero)
				id_CONST_C = JNIEnv.GetStaticMethodID (class_ref, "CONST", "(C)C");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (v);
				return JNIEnv.CallStaticCharMethod  (class_ref, id_CONST_C, __args);
			} finally {
			}
		}

		static IntPtr id_CONST_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("CONST", "(D)D", "")]
		public static unsafe double CONST (double v)
		{
			if (id_CONST_D == IntPtr.Zero)
				id_CONST_D = JNIEnv.GetStaticMethodID (class_ref, "CONST", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (v);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_CONST_D, __args);
			} finally {
			}
		}

		static IntPtr id_CONST_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("CONST", "(F)F", "")]
		public static unsafe float CONST (float v)
		{
			if (id_CONST_F == IntPtr.Zero)
				id_CONST_F = JNIEnv.GetStaticMethodID (class_ref, "CONST", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (v);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_CONST_F, __args);
			} finally {
			}
		}

		static IntPtr id_CONST_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("CONST", "(I)I", "")]
		public static unsafe int CONST (int v)
		{
			if (id_CONST_I == IntPtr.Zero)
				id_CONST_I = JNIEnv.GetStaticMethodID (class_ref, "CONST", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (v);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_CONST_I, __args);
			} finally {
			}
		}

		static IntPtr id_CONST_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("CONST", "(J)J", "")]
		public static unsafe long CONST (long v)
		{
			if (id_CONST_J == IntPtr.Zero)
				id_CONST_J = JNIEnv.GetStaticMethodID (class_ref, "CONST", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (v);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_CONST_J, __args);
			} finally {
			}
		}

		static IntPtr id_CONST_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("CONST", "(S)S", "")]
		public static unsafe short CONST (short v)
		{
			if (id_CONST_S == IntPtr.Zero)
				id_CONST_S = JNIEnv.GetStaticMethodID (class_ref, "CONST", "(S)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (v);
				return JNIEnv.CallStaticShortMethod  (class_ref, id_CONST_S, __args);
			} finally {
			}
		}

		static IntPtr id_CONST_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("CONST", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CONST (global::Java.Lang.Object v)
		{
			if (id_CONST_Ljava_lang_Object_ == IntPtr.Zero)
				id_CONST_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "CONST", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_v = JNIEnv.ToLocalJniHandle (v);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_v);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_CONST_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_v);
			}
		}

		static IntPtr id_CONST_BYTE_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST_BYTE' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("CONST_BYTE", "(I)B", "")]
		public static unsafe sbyte CONST_BYTE (int v)
		{
			if (id_CONST_BYTE_I == IntPtr.Zero)
				id_CONST_BYTE_I = JNIEnv.GetStaticMethodID (class_ref, "CONST_BYTE", "(I)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (v);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_CONST_BYTE_I, __args);
			} finally {
			}
		}

		static IntPtr id_CONST_SHORT_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='CONST_SHORT' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("CONST_SHORT", "(I)S", "")]
		public static unsafe short CONST_SHORT (int v)
		{
			if (id_CONST_SHORT_I == IntPtr.Zero)
				id_CONST_SHORT_I = JNIEnv.GetStaticMethodID (class_ref, "CONST_SHORT", "(I)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (v);
				return JNIEnv.CallStaticShortMethod  (class_ref, id_CONST_SHORT_I, __args);
			} finally {
			}
		}

		static IntPtr id_allNotNull_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='allNotNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("allNotNull", "([Ljava/lang/Object;)Z", "")]
		public static unsafe bool AllNotNull (params global::Java.Lang.Object[] values)
		{
			if (id_allNotNull_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_allNotNull_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "allNotNull", "([Ljava/lang/Object;)Z");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_allNotNull_arrayLjava_lang_Object_, __args);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_anyNotNull_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='anyNotNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("anyNotNull", "([Ljava/lang/Object;)Z", "")]
		public static unsafe bool AnyNotNull (params global::Java.Lang.Object[] values)
		{
			if (id_anyNotNull_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_anyNotNull_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "anyNotNull", "([Ljava/lang/Object;)Z");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_anyNotNull_arrayLjava_lang_Object_, __args);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_clone_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("clone", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Clone (global::Java.Lang.Object obj)
		{
			if (id_clone_Ljava_lang_Object_ == IntPtr.Zero)
				id_clone_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "clone", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_obj);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		static IntPtr id_cloneIfPossible_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='cloneIfPossible' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("cloneIfPossible", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CloneIfPossible (global::Java.Lang.Object obj)
		{
			if (id_cloneIfPossible_Ljava_lang_Object_ == IntPtr.Zero)
				id_cloneIfPossible_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "cloneIfPossible", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_obj);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_cloneIfPossible_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		static IntPtr id_compare_Ljava_lang_Comparable_Ljava_lang_Comparable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("compare", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)I", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<? super T>"})]
		public static unsafe int Compare (global::Java.Lang.Object c1, global::Java.Lang.Object c2)
		{
			if (id_compare_Ljava_lang_Comparable_Ljava_lang_Comparable_ == IntPtr.Zero)
				id_compare_Ljava_lang_Comparable_Ljava_lang_Comparable_ = JNIEnv.GetStaticMethodID (class_ref, "compare", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)I");
			IntPtr native_c1 = JNIEnv.ToLocalJniHandle (c1);
			IntPtr native_c2 = JNIEnv.ToLocalJniHandle (c2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_c1);
				__args [1] = new JValue (native_c2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compare_Ljava_lang_Comparable_Ljava_lang_Comparable_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_c1);
				JNIEnv.DeleteLocalRef (native_c2);
			}
		}

		static IntPtr id_compare_Ljava_lang_Comparable_Ljava_lang_Comparable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='compare' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='boolean']]"
		[Register ("compare", "(Ljava/lang/Comparable;Ljava/lang/Comparable;Z)I", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<? super T>"})]
		public static unsafe int Compare (global::Java.Lang.Object c1, global::Java.Lang.Object c2, bool nullGreater)
		{
			if (id_compare_Ljava_lang_Comparable_Ljava_lang_Comparable_Z == IntPtr.Zero)
				id_compare_Ljava_lang_Comparable_Ljava_lang_Comparable_Z = JNIEnv.GetStaticMethodID (class_ref, "compare", "(Ljava/lang/Comparable;Ljava/lang/Comparable;Z)I");
			IntPtr native_c1 = JNIEnv.ToLocalJniHandle (c1);
			IntPtr native_c2 = JNIEnv.ToLocalJniHandle (c2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_c1);
				__args [1] = new JValue (native_c2);
				__args [2] = new JValue (nullGreater);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compare_Ljava_lang_Comparable_Ljava_lang_Comparable_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_c1);
				JNIEnv.DeleteLocalRef (native_c2);
			}
		}

		static IntPtr id_defaultIfNull_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='defaultIfNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("defaultIfNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object DefaultIfNull (global::Java.Lang.Object @object, global::Java.Lang.Object defaultValue)
		{
			if (id_defaultIfNull_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_defaultIfNull_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "defaultIfNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__object);
				__args [1] = new JValue (native_defaultValue);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultIfNull_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool Equals (global::Java.Lang.Object object1, global::Java.Lang.Object object2)
		{
			if (id_equals_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (object1);
				__args [1] = new JValue (object2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_firstNonNull_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='firstNonNull' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("firstNonNull", "([Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object FirstNonNull (params global::Java.Lang.Object[] values)
		{
			if (id_firstNonNull_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_firstNonNull_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "firstNonNull", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_firstNonNull_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_hashCode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("hashCode", "(Ljava/lang/Object;)I", "")]
		public static unsafe int HashCode (global::Java.Lang.Object obj)
		{
			if (id_hashCode_Ljava_lang_Object_ == IntPtr.Zero)
				id_hashCode_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hashCodeMulti_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='hashCodeMulti' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Obsolete (@"deprecated")]
		[Register ("hashCodeMulti", "([Ljava/lang/Object;)I", "")]
		public static unsafe int HashCodeMulti (params global::Java.Lang.Object[] objects)
		{
			if (id_hashCodeMulti_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_hashCodeMulti_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "hashCodeMulti", "([Ljava/lang/Object;)I");
			IntPtr native_objects = JNIEnv.NewArray (objects);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_objects);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCodeMulti_arrayLjava_lang_Object_, __args);
				return __ret;
			} finally {
				if (objects != null) {
					JNIEnv.CopyArray (native_objects, objects);
					JNIEnv.DeleteLocalRef (native_objects);
				}
			}
		}

		static IntPtr id_identityToString_Ljava_lang_Appendable_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='identityToString' and count(parameter)=2 and parameter[1][@type='java.lang.Appendable'] and parameter[2][@type='java.lang.Object']]"
		[Register ("identityToString", "(Ljava/lang/Appendable;Ljava/lang/Object;)V", "")]
		public static unsafe void IdentityToString (global::Java.Lang.IAppendable appendable, global::Java.Lang.Object @object)
		{
			if (id_identityToString_Ljava_lang_Appendable_Ljava_lang_Object_ == IntPtr.Zero)
				id_identityToString_Ljava_lang_Appendable_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "identityToString", "(Ljava/lang/Appendable;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (appendable);
				__args [1] = new JValue (@object);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_identityToString_Ljava_lang_Appendable_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_identityToString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='identityToString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("identityToString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string IdentityToString (global::Java.Lang.Object @object)
		{
			if (id_identityToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_identityToString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "identityToString", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_identityToString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_identityToString_Ljava_lang_StringBuffer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='identityToString' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.Object']]"
		[Register ("identityToString", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V", "")]
		public static unsafe void IdentityToString (global::Java.Lang.StringBuffer buffer, global::Java.Lang.Object @object)
		{
			if (id_identityToString_Ljava_lang_StringBuffer_Ljava_lang_Object_ == IntPtr.Zero)
				id_identityToString_Ljava_lang_StringBuffer_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "identityToString", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (@object);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_identityToString_Ljava_lang_StringBuffer_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_identityToString_Ljava_lang_StringBuilder_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='identityToString' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='java.lang.Object']]"
		[Register ("identityToString", "(Ljava/lang/StringBuilder;Ljava/lang/Object;)V", "")]
		public static unsafe void IdentityToString (global::Java.Lang.StringBuilder builder, global::Java.Lang.Object @object)
		{
			if (id_identityToString_Ljava_lang_StringBuilder_Ljava_lang_Object_ == IntPtr.Zero)
				id_identityToString_Ljava_lang_StringBuilder_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "identityToString", "(Ljava/lang/StringBuilder;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (builder);
				__args [1] = new JValue (@object);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_identityToString_Ljava_lang_StringBuilder_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_identityToString_Lorg_apache_commons_lang3_text_StrBuilder_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='identityToString' and count(parameter)=2 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder'] and parameter[2][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("identityToString", "(Lorg/apache/commons/lang3/text/StrBuilder;Ljava/lang/Object;)V", "")]
		public static unsafe void IdentityToString (global::Org.Apache.Commons.Lang3.Text.StrBuilder builder, global::Java.Lang.Object @object)
		{
			if (id_identityToString_Lorg_apache_commons_lang3_text_StrBuilder_Ljava_lang_Object_ == IntPtr.Zero)
				id_identityToString_Lorg_apache_commons_lang3_text_StrBuilder_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "identityToString", "(Lorg/apache/commons/lang3/text/StrBuilder;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (builder);
				__args [1] = new JValue (@object);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_identityToString_Lorg_apache_commons_lang3_text_StrBuilder_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_max_arrayLjava_lang_Comparable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='max' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("max", "([Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<? super T>"})]
		public static unsafe global::Java.Lang.Object Max (params global::Java.Lang.Object[] values)
		{
			if (id_max_arrayLjava_lang_Comparable_ == IntPtr.Zero)
				id_max_arrayLjava_lang_Comparable_ = JNIEnv.GetStaticMethodID (class_ref, "max", "([Ljava/lang/Comparable;)Ljava/lang/Comparable;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_max_arrayLjava_lang_Comparable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_median_Ljava_util_Comparator_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='median' and count(parameter)=2 and parameter[1][@type='java.util.Comparator&lt;T&gt;'] and parameter[2][@type='T...']]"
		[Register ("median", "(Ljava/util/Comparator;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Median (global::Java.Util.IComparator comparator, params global::Java.Lang.Object[] items)
		{
			if (id_median_Ljava_util_Comparator_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_median_Ljava_util_Comparator_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "median", "(Ljava/util/Comparator;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (comparator);
				__args [1] = new JValue (native_items);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_median_Ljava_util_Comparator_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (items != null) {
					JNIEnv.CopyArray (native_items, items);
					JNIEnv.DeleteLocalRef (native_items);
				}
			}
		}

		static IntPtr id_median_arrayLjava_lang_Comparable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='median' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("median", "([Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<? super T>"})]
		public static unsafe global::Java.Lang.Object Median (params global::Java.Lang.Object[] items)
		{
			if (id_median_arrayLjava_lang_Comparable_ == IntPtr.Zero)
				id_median_arrayLjava_lang_Comparable_ = JNIEnv.GetStaticMethodID (class_ref, "median", "([Ljava/lang/Comparable;)Ljava/lang/Comparable;");
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_items);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_median_arrayLjava_lang_Comparable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (items != null) {
					JNIEnv.CopyArray (native_items, items);
					JNIEnv.DeleteLocalRef (native_items);
				}
			}
		}

		static IntPtr id_min_arrayLjava_lang_Comparable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='min' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("min", "([Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<? super T>"})]
		public static unsafe global::Java.Lang.Object Min (params global::Java.Lang.Object[] values)
		{
			if (id_min_arrayLjava_lang_Comparable_ == IntPtr.Zero)
				id_min_arrayLjava_lang_Comparable_ = JNIEnv.GetStaticMethodID (class_ref, "min", "([Ljava/lang/Comparable;)Ljava/lang/Comparable;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_min_arrayLjava_lang_Comparable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_mode_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='mode' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("mode", "([Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Mode (params global::Java.Lang.Object[] items)
		{
			if (id_mode_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_mode_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "mode", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_items);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mode_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (items != null) {
					JNIEnv.CopyArray (native_items, items);
					JNIEnv.DeleteLocalRef (native_items);
				}
			}
		}

		static IntPtr id_notEqual_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='notEqual' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("notEqual", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool NotEqual (global::Java.Lang.Object object1, global::Java.Lang.Object object2)
		{
			if (id_notEqual_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_notEqual_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "notEqual", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (object1);
				__args [1] = new JValue (object2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_notEqual_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("toString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Object obj)
		{
			if (id_toString_Ljava_lang_Object_ == IntPtr.Zero)
				id_toString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ObjectUtils']/method[@name='toString' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("toString", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Object obj, string nullStr)
		{
			if (id_toString_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_toString_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_nullStr = JNIEnv.NewString (nullStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (native_nullStr);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_nullStr);
			}
		}

	}
}
