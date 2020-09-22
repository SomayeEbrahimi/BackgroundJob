using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='NoSubscriberEvent']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/NoSubscriberEvent", DoNotGenerateAcw=true)]
	public sealed partial class NoSubscriberEvent : global::Java.Lang.Object {


		static IntPtr eventBus_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='NoSubscriberEvent']/field[@name='eventBus']"
		[Register ("eventBus")]
		public global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus EventBus {
			get {
				if (eventBus_jfieldId == IntPtr.Zero)
					eventBus_jfieldId = JNIEnv.GetFieldID (class_ref, "eventBus", "Lcom/vivalnk/sdk/common/eventbus/EventBus;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, eventBus_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (eventBus_jfieldId == IntPtr.Zero)
					eventBus_jfieldId = JNIEnv.GetFieldID (class_ref, "eventBus", "Lcom/vivalnk/sdk/common/eventbus/EventBus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, eventBus_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr originalEvent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='NoSubscriberEvent']/field[@name='originalEvent']"
		[Register ("originalEvent")]
		public global::Java.Lang.Object OriginalEvent {
			get {
				if (originalEvent_jfieldId == IntPtr.Zero)
					originalEvent_jfieldId = JNIEnv.GetFieldID (class_ref, "originalEvent", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, originalEvent_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (originalEvent_jfieldId == IntPtr.Zero)
					originalEvent_jfieldId = JNIEnv.GetFieldID (class_ref, "originalEvent", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, originalEvent_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/NoSubscriberEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NoSubscriberEvent); }
		}

		internal NoSubscriberEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='NoSubscriberEvent']/constructor[@name='NoSubscriberEvent' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.EventBus'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Ljava/lang/Object;)V", "")]
		public unsafe NoSubscriberEvent (global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus eventBus, global::Java.Lang.Object originalEvent)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (eventBus);
				__args [1] = new JValue (originalEvent);
				if (((object) this).GetType () != typeof (NoSubscriberEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Ljava_lang_Object_, __args);
			} finally {
			}
		}

	}
}
