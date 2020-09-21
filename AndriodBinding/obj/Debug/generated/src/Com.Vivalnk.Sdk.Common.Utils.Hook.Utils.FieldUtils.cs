using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Hook.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='FieldUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/hook/utils/FieldUtils", DoNotGenerateAcw=true)]
	public partial class FieldUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/hook/utils/FieldUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FieldUtils); }
		}

		protected FieldUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='FieldUtils']/constructor[@name='FieldUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FieldUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FieldUtils)) {
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

		static IntPtr id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='FieldUtils']/method[@name='getDeclaredField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getDeclaredField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field GetDeclaredField (global::Java.Lang.Class cls, string fieldName, bool forceAccess)
		{
			if (id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_Z == IntPtr.Zero)
				id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getDeclaredField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/reflect/Field;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (forceAccess);
				global::Java.Lang.Reflect.Field __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

	}
}
