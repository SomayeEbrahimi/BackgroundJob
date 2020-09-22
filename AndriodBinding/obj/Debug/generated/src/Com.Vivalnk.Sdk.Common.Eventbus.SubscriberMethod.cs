using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='SubscriberMethod']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/SubscriberMethod", DoNotGenerateAcw=true)]
	public partial class SubscriberMethod : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/SubscriberMethod", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubscriberMethod); }
		}

		protected SubscriberMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_reflect_Method_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='SubscriberMethod']/constructor[@name='SubscriberMethod' and count(parameter)=5 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.eventbus.ThreadMode'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/reflect/Method;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)V", "")]
		public unsafe SubscriberMethod (global::Java.Lang.Reflect.Method method, global::Java.Lang.Class eventType, global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode threadMode, int priority, bool sticky)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (method);
				__args [1] = new JValue (eventType);
				__args [2] = new JValue (threadMode);
				__args [3] = new JValue (priority);
				__args [4] = new JValue (sticky);
				if (((object) this).GetType () != typeof (SubscriberMethod)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/reflect/Method;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/reflect/Method;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_reflect_Method_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ == IntPtr.Zero)
					id_ctor_Ljava_lang_reflect_Method_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_reflect_Method_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_reflect_Method_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ, __args);
			} finally {
			}
		}

	}
}
