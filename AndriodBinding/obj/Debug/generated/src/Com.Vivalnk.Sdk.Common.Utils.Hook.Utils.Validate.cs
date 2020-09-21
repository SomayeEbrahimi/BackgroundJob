using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Hook.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='Validate']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/hook/utils/Validate", DoNotGenerateAcw=true)]
	public partial class Validate : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/hook/utils/Validate", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='Validate']/constructor[@name='Validate' and count(parameter)=0]"
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

		static IntPtr id_isTrue_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='Validate']/method[@name='isTrue' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
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

	}
}
