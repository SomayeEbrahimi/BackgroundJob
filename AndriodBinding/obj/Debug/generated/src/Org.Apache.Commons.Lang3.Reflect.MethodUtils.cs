using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/reflect/MethodUtils", DoNotGenerateAcw=true)]
	public partial class MethodUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/reflect/MethodUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MethodUtils); }
		}

		protected MethodUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/constructor[@name='MethodUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MethodUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MethodUtils)) {
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

		static IntPtr id_getAccessibleMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='getAccessibleMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("getAccessibleMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method GetAccessibleMethod (global::Java.Lang.Class cls, string methodName, params global::Java.Lang.Class[] parameterTypes)
		{
			if (id_getAccessibleMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_getAccessibleMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getAccessibleMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_parameterTypes);
				global::Java.Lang.Reflect.Method __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAccessibleMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		static IntPtr id_getAccessibleMethod_Ljava_lang_reflect_Method_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='getAccessibleMethod' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Method']]"
		[Register ("getAccessibleMethod", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method GetAccessibleMethod (global::Java.Lang.Reflect.Method method)
		{
			if (id_getAccessibleMethod_Ljava_lang_reflect_Method_ == IntPtr.Zero)
				id_getAccessibleMethod_Ljava_lang_reflect_Method_ = JNIEnv.GetStaticMethodID (class_ref, "getAccessibleMethod", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (method);
				global::Java.Lang.Reflect.Method __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAccessibleMethod_Ljava_lang_reflect_Method_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAnnotation_Ljava_lang_reflect_Method_Ljava_lang_Class_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='getAnnotation' and count(parameter)=4 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='java.lang.Class&lt;A&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("getAnnotation", "(Ljava/lang/reflect/Method;Ljava/lang/Class;ZZ)Ljava/lang/annotation/Annotation;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"A extends java.lang.annotation.Annotation"})]
		public static unsafe global::Java.Lang.Object GetAnnotation (global::Java.Lang.Reflect.Method method, global::Java.Lang.Class annotationCls, bool searchSupers, bool ignoreAccess)
		{
			if (id_getAnnotation_Ljava_lang_reflect_Method_Ljava_lang_Class_ZZ == IntPtr.Zero)
				id_getAnnotation_Ljava_lang_reflect_Method_Ljava_lang_Class_ZZ = JNIEnv.GetStaticMethodID (class_ref, "getAnnotation", "(Ljava/lang/reflect/Method;Ljava/lang/Class;ZZ)Ljava/lang/annotation/Annotation;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (method);
				__args [1] = new JValue (annotationCls);
				__args [2] = new JValue (searchSupers);
				__args [3] = new JValue (ignoreAccess);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAnnotation_Ljava_lang_reflect_Method_Ljava_lang_Class_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMatchingAccessibleMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='getMatchingAccessibleMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("getMatchingAccessibleMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method GetMatchingAccessibleMethod (global::Java.Lang.Class cls, string methodName, params global::Java.Lang.Class[] parameterTypes)
		{
			if (id_getMatchingAccessibleMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_getMatchingAccessibleMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getMatchingAccessibleMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_parameterTypes);
				global::Java.Lang.Reflect.Method __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMatchingAccessibleMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		static IntPtr id_getMatchingMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='getMatchingMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("getMatchingMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method GetMatchingMethod (global::Java.Lang.Class cls, string methodName, params global::Java.Lang.Class[] parameterTypes)
		{
			if (id_getMatchingMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_getMatchingMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getMatchingMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_parameterTypes);
				global::Java.Lang.Reflect.Method __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMatchingMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		static IntPtr id_getMethodsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='getMethodsListWithAnnotation' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;? extends java.lang.annotation.Annotation&gt;']]"
		[Register ("getMethodsListWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Method> GetMethodsListWithAnnotation (global::Java.Lang.Class cls, global::Java.Lang.Class annotationCls)
		{
			if (id_getMethodsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_getMethodsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getMethodsListWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (annotationCls);
				global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Method> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Reflect.Method>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMethodsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMethodsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='getMethodsListWithAnnotation' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;? extends java.lang.annotation.Annotation&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("getMethodsListWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;ZZ)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Method> GetMethodsListWithAnnotation (global::Java.Lang.Class cls, global::Java.Lang.Class annotationCls, bool searchSupers, bool ignoreAccess)
		{
			if (id_getMethodsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ZZ == IntPtr.Zero)
				id_getMethodsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ZZ = JNIEnv.GetStaticMethodID (class_ref, "getMethodsListWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;ZZ)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (annotationCls);
				__args [2] = new JValue (searchSupers);
				__args [3] = new JValue (ignoreAccess);
				global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Method> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Reflect.Method>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMethodsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMethodsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='getMethodsWithAnnotation' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;? extends java.lang.annotation.Annotation&gt;']]"
		[Register ("getMethodsWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;)[Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method[] GetMethodsWithAnnotation (global::Java.Lang.Class cls, global::Java.Lang.Class annotationCls)
		{
			if (id_getMethodsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_getMethodsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getMethodsWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;)[Ljava/lang/reflect/Method;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (annotationCls);
				global::Java.Lang.Reflect.Method[] __ret = (global::Java.Lang.Reflect.Method[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMethodsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Method));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMethodsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='getMethodsWithAnnotation' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;? extends java.lang.annotation.Annotation&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("getMethodsWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;ZZ)[Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method[] GetMethodsWithAnnotation (global::Java.Lang.Class cls, global::Java.Lang.Class annotationCls, bool searchSupers, bool ignoreAccess)
		{
			if (id_getMethodsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ZZ == IntPtr.Zero)
				id_getMethodsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ZZ = JNIEnv.GetStaticMethodID (class_ref, "getMethodsWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;ZZ)[Ljava/lang/reflect/Method;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (annotationCls);
				__args [2] = new JValue (searchSupers);
				__args [3] = new JValue (ignoreAccess);
				global::Java.Lang.Reflect.Method[] __ret = (global::Java.Lang.Reflect.Method[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMethodsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ZZ, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Method));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getOverrideHierarchy_Ljava_lang_reflect_Method_Lorg_apache_commons_lang3_ClassUtils_Interfaces_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='getOverrideHierarchy' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='org.apache.commons.lang3.ClassUtils.Interfaces']]"
		[Register ("getOverrideHierarchy", "(Ljava/lang/reflect/Method;Lorg/apache/commons/lang3/ClassUtils$Interfaces;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Reflect.Method> GetOverrideHierarchy (global::Java.Lang.Reflect.Method method, global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces interfacesBehavior)
		{
			if (id_getOverrideHierarchy_Ljava_lang_reflect_Method_Lorg_apache_commons_lang3_ClassUtils_Interfaces_ == IntPtr.Zero)
				id_getOverrideHierarchy_Ljava_lang_reflect_Method_Lorg_apache_commons_lang3_ClassUtils_Interfaces_ = JNIEnv.GetStaticMethodID (class_ref, "getOverrideHierarchy", "(Ljava/lang/reflect/Method;Lorg/apache/commons/lang3/ClassUtils$Interfaces;)Ljava/util/Set;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (method);
				__args [1] = new JValue (interfacesBehavior);
				global::System.Collections.Generic.ICollection<global::Java.Lang.Reflect.Method> __ret = global::Android.Runtime.JavaSet<global::Java.Lang.Reflect.Method>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOverrideHierarchy_Ljava_lang_reflect_Method_Lorg_apache_commons_lang3_ClassUtils_Interfaces_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeExactMethod' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("invokeExactMethod", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeExactMethod (global::Java.Lang.Object @object, string methodName)
		{
			if (id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "invokeExactMethod", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_methodName);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static IntPtr id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeExactMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("invokeExactMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeExactMethod (global::Java.Lang.Object @object, string methodName, params global::Java.Lang.Object[] args)
		{
			if (id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "invokeExactMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_args);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeExactMethod' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]'] and parameter[4][@type='java.lang.Class&lt;?&gt;[]']]"
		[Register ("invokeExactMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeExactMethod (global::Java.Lang.Object @object, string methodName, global::Java.Lang.Object[] args, global::Java.Lang.Class[] parameterTypes)
		{
			if (id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "invokeExactMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_args);
				__args [3] = new JValue (native_parameterTypes);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeExactMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
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

		static IntPtr id_invokeExactStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeExactStaticMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("invokeExactStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeExactStaticMethod (global::Java.Lang.Class cls, string methodName, params global::Java.Lang.Object[] args)
		{
			if (id_invokeExactStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invokeExactStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "invokeExactStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_args);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeExactStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_invokeExactStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeExactStaticMethod' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]'] and parameter[4][@type='java.lang.Class&lt;?&gt;[]']]"
		[Register ("invokeExactStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeExactStaticMethod (global::Java.Lang.Class cls, string methodName, global::Java.Lang.Object[] args, global::Java.Lang.Class[] parameterTypes)
		{
			if (id_invokeExactStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_invokeExactStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "invokeExactStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_args);
				__args [3] = new JValue (native_parameterTypes);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeExactStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
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

		static IntPtr id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String']]"
		[Register ("invokeMethod", "(Ljava/lang/Object;ZLjava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeMethod (global::Java.Lang.Object @object, bool forceAccess, string methodName)
		{
			if (id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_ == IntPtr.Zero)
				id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "invokeMethod", "(Ljava/lang/Object;ZLjava/lang/String;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (forceAccess);
				__args [2] = new JValue (native_methodName);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static IntPtr id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeMethod' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("invokeMethod", "(Ljava/lang/Object;ZLjava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeMethod (global::Java.Lang.Object @object, bool forceAccess, string methodName, params global::Java.Lang.Object[] args)
		{
			if (id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "invokeMethod", "(Ljava/lang/Object;ZLjava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (forceAccess);
				__args [2] = new JValue (native_methodName);
				__args [3] = new JValue (native_args);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeMethod' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Class&lt;?&gt;[]']]"
		[Register ("invokeMethod", "(Ljava/lang/Object;ZLjava/lang/String;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeMethod (global::Java.Lang.Object @object, bool forceAccess, string methodName, global::Java.Lang.Object[] args, global::Java.Lang.Class[] parameterTypes)
		{
			if (id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "invokeMethod", "(Ljava/lang/Object;ZLjava/lang/String;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (forceAccess);
				__args [2] = new JValue (native_methodName);
				__args [3] = new JValue (native_args);
				__args [4] = new JValue (native_parameterTypes);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeMethod_Ljava_lang_Object_ZLjava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
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

		static IntPtr id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeMethod' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeMethod (global::Java.Lang.Object @object, string methodName)
		{
			if (id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_methodName);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static IntPtr id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeMethod (global::Java.Lang.Object @object, string methodName, params global::Java.Lang.Object[] args)
		{
			if (id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_args);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeMethod' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]'] and parameter[4][@type='java.lang.Class&lt;?&gt;[]']]"
		[Register ("invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeMethod (global::Java.Lang.Object @object, string methodName, global::Java.Lang.Object[] args, global::Java.Lang.Class[] parameterTypes)
		{
			if (id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_args);
				__args [3] = new JValue (native_parameterTypes);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
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

		static IntPtr id_invokeStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeStaticMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("invokeStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeStaticMethod (global::Java.Lang.Class cls, string methodName, params global::Java.Lang.Object[] args)
		{
			if (id_invokeStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invokeStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "invokeStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_args);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_invokeStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='MethodUtils']/method[@name='invokeStaticMethod' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]'] and parameter[4][@type='java.lang.Class&lt;?&gt;[]']]"
		[Register ("invokeStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InvokeStaticMethod (global::Java.Lang.Class cls, string methodName, global::Java.Lang.Object[] args, global::Java.Lang.Class[] parameterTypes)
		{
			if (id_invokeStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_invokeStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "invokeStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_args);
				__args [3] = new JValue (native_parameterTypes);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invokeStaticMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
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
