using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Hook.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='MethodUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/hook/utils/MethodUtils", DoNotGenerateAcw=true)]
	public partial class MethodUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/hook/utils/MethodUtils", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='MethodUtils']/constructor[@name='MethodUtils' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='MethodUtils']/method[@name='getAccessibleMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='MethodUtils']/method[@name='getAccessibleMethod' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Method']]"
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

	}
}
