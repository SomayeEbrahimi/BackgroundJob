using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='HandlerPoster']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/HandlerPoster", DoNotGenerateAcw=true)]
	public partial class HandlerPoster : global::Android.OS.Handler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/HandlerPoster", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HandlerPoster); }
		}

		protected HandlerPoster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Landroid_os_Looper_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='HandlerPoster']/constructor[@name='HandlerPoster' and count(parameter)=3 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.EventBus'] and parameter[2][@type='android.os.Looper'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Landroid/os/Looper;I)V", "")]
		protected unsafe HandlerPoster (global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus eventBus, global::Android.OS.Looper looper, int maxMillisInsideHandleMessage)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (eventBus);
				__args [1] = new JValue (looper);
				__args [2] = new JValue (maxMillisInsideHandleMessage);
				if (((object) this).GetType () != typeof (HandlerPoster)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Landroid/os/Looper;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Landroid/os/Looper;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Landroid_os_Looper_I == IntPtr.Zero)
					id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Landroid_os_Looper_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Landroid/os/Looper;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Landroid_os_Looper_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Landroid_os_Looper_I, __args);
			} finally {
			}
		}

	}
}
