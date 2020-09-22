using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='ConstructorUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/reflect/ConstructorUtils", DoNotGenerateAcw=true)]
	public partial class ConstructorUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/reflect/ConstructorUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConstructorUtils); }
		}

		protected ConstructorUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='ConstructorUtils']/constructor[@name='ConstructorUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConstructorUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConstructorUtils)) {
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

		static IntPtr id_getAccessibleConstructor_Ljava_lang_Class_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='ConstructorUtils']/method[@name='getAccessibleConstructor' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("getAccessibleConstructor", "(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Reflect.Constructor GetAccessibleConstructor (global::Java.Lang.Class cls, params global::Java.Lang.Class[] parameterTypes)
		{
			if (id_getAccessibleConstructor_Ljava_lang_Class_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_getAccessibleConstructor_Ljava_lang_Class_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getAccessibleConstructor", "(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_parameterTypes);
				global::Java.Lang.Reflect.Constructor __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAccessibleConstructor_Ljava_lang_Class_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		static IntPtr id_getAccessibleConstructor_Ljava_lang_reflect_Constructor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='ConstructorUtils']/method[@name='getAccessibleConstructor' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Constructor&lt;T&gt;']]"
		[Register ("getAccessibleConstructor", "(Ljava/lang/reflect/Constructor;)Ljava/lang/reflect/Constructor;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Reflect.Constructor GetAccessibleConstructor (global::Java.Lang.Reflect.Constructor ctor)
		{
			if (id_getAccessibleConstructor_Ljava_lang_reflect_Constructor_ == IntPtr.Zero)
				id_getAccessibleConstructor_Ljava_lang_reflect_Constructor_ = JNIEnv.GetStaticMethodID (class_ref, "getAccessibleConstructor", "(Ljava/lang/reflect/Constructor;)Ljava/lang/reflect/Constructor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ctor);
				global::Java.Lang.Reflect.Constructor __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAccessibleConstructor_Ljava_lang_reflect_Constructor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMatchingAccessibleConstructor_Ljava_lang_Class_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='ConstructorUtils']/method[@name='getMatchingAccessibleConstructor' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("getMatchingAccessibleConstructor", "(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Reflect.Constructor GetMatchingAccessibleConstructor (global::Java.Lang.Class cls, params global::Java.Lang.Class[] parameterTypes)
		{
			if (id_getMatchingAccessibleConstructor_Ljava_lang_Class_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_getMatchingAccessibleConstructor_Ljava_lang_Class_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getMatchingAccessibleConstructor", "(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_parameterTypes);
				global::Java.Lang.Reflect.Constructor __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMatchingAccessibleConstructor_Ljava_lang_Class_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		static IntPtr id_invokeConstructor_Ljava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='ConstructorUtils']/method[@name='invokeConstructor' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("invokeConstructor", "(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InvokeConstructor (global::Java.Lang.Class cls, params global::Java.Lang.Object[] args)
		{
			if (id_invokeConstructor_Ljava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invokeConstructor_Ljava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "invokeConstructor", "(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_args);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeConstructor_Ljava_lang_Class_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_invokeConstructor_Ljava_lang_Class_arrayLjava_lang_Object_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='ConstructorUtils']/method[@name='invokeConstructor' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Object[]'] and parameter[3][@type='java.lang.Class&lt;?&gt;[]']]"
		[Register ("invokeConstructor", "(Ljava/lang/Class;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InvokeConstructor (global::Java.Lang.Class cls, global::Java.Lang.Object[] args, global::Java.Lang.Class[] parameterTypes)
		{
			if (id_invokeConstructor_Ljava_lang_Class_arrayLjava_lang_Object_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_invokeConstructor_Ljava_lang_Class_arrayLjava_lang_Object_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "invokeConstructor", "(Ljava/lang/Class;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_args = JNIEnv.NewArray (args);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_args);
				__args [2] = new JValue (native_parameterTypes);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeConstructor_Ljava_lang_Class_arrayLjava_lang_Object_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		static IntPtr id_invokeExactConstructor_Ljava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='ConstructorUtils']/method[@name='invokeExactConstructor' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("invokeExactConstructor", "(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InvokeExactConstructor (global::Java.Lang.Class cls, params global::Java.Lang.Object[] args)
		{
			if (id_invokeExactConstructor_Ljava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invokeExactConstructor_Ljava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "invokeExactConstructor", "(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_args);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeExactConstructor_Ljava_lang_Class_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_invokeExactConstructor_Ljava_lang_Class_arrayLjava_lang_Object_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='ConstructorUtils']/method[@name='invokeExactConstructor' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Object[]'] and parameter[3][@type='java.lang.Class&lt;?&gt;[]']]"
		[Register ("invokeExactConstructor", "(Ljava/lang/Class;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InvokeExactConstructor (global::Java.Lang.Class cls, global::Java.Lang.Object[] args, global::Java.Lang.Class[] parameterTypes)
		{
			if (id_invokeExactConstructor_Ljava_lang_Class_arrayLjava_lang_Object_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_invokeExactConstructor_Ljava_lang_Class_arrayLjava_lang_Object_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "invokeExactConstructor", "(Ljava/lang/Class;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_args = JNIEnv.NewArray (args);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_args);
				__args [2] = new JValue (native_parameterTypes);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeExactConstructor_Ljava_lang_Class_arrayLjava_lang_Object_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

	}
}
