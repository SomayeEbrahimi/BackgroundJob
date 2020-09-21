using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Hook.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='HookUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/hook/utils/HookUtils", DoNotGenerateAcw=true)]
	public partial class HookUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/hook/utils/HookUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HookUtils); }
		}

		protected HookUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='HookUtils']/constructor[@name='HookUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HookUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HookUtils)) {
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

		static IntPtr id_getClass_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='HookUtils']/method[@name='getClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClass", "(Ljava/lang/String;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class GetClass (string name)
		{
			if (id_getClass_Ljava_lang_String_ == IntPtr.Zero)
				id_getClass_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClass_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_getField_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='HookUtils']/method[@name='getField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field GetField (global::Java.Lang.Class clazz, string name)
		{
			if (id_getField_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_getField_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (clazz);
				__args [1] = new JValue (native_name);
				global::Java.Lang.Reflect.Field __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getField_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_getMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='HookUtils']/method[@name='getMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("getMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method GetMethod (global::Java.Lang.Class clazz, string name, params global::Java.Lang.Class[] parameterTypes)
		{
			if (id_getMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_getMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (clazz);
				__args [1] = new JValue (native_name);
				__args [2] = new JValue (native_parameterTypes);
				global::Java.Lang.Reflect.Method __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		static IntPtr id_getValue_Ljava_lang_reflect_Field_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='HookUtils']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("getValue", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetValue (global::Java.Lang.Reflect.Field field)
		{
			if (id_getValue_Ljava_lang_reflect_Field_ == IntPtr.Zero)
				id_getValue_Ljava_lang_reflect_Field_ = JNIEnv.GetStaticMethodID (class_ref, "getValue", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (field);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getValue_Ljava_lang_reflect_Field_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getValue_Ljava_lang_reflect_Field_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='HookUtils']/method[@name='getValue' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getValue", "(Ljava/lang/reflect/Field;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetValue (global::Java.Lang.Reflect.Field field, global::Java.Lang.Object @object)
		{
			if (id_getValue_Ljava_lang_reflect_Field_Ljava_lang_Object_ == IntPtr.Zero)
				id_getValue_Ljava_lang_reflect_Field_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getValue", "(Ljava/lang/reflect/Field;Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (field);
				__args [1] = new JValue (@object);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getValue_Ljava_lang_reflect_Field_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_invoke_Ljava_lang_reflect_Method_Ljava_lang_Object_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='HookUtils']/method[@name='invoke' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("invoke", "(Ljava/lang/reflect/Method;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Invoke (global::Java.Lang.Reflect.Method method, global::Java.Lang.Object @object, params global::Java.Lang.Object[] parameters)
		{
			if (id_invoke_Ljava_lang_reflect_Method_Ljava_lang_Object_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invoke_Ljava_lang_reflect_Method_Ljava_lang_Object_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "invoke", "(Ljava/lang/reflect/Method;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_parameters = JNIEnv.NewArray (parameters);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (method);
				__args [1] = new JValue (@object);
				__args [2] = new JValue (native_parameters);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_invoke_Ljava_lang_reflect_Method_Ljava_lang_Object_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (parameters != null) {
					JNIEnv.CopyArray (native_parameters, parameters);
					JNIEnv.DeleteLocalRef (native_parameters);
				}
			}
		}

	}
}
