using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='SubscriberExceptionEvent']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/SubscriberExceptionEvent", DoNotGenerateAcw=true)]
	public sealed partial class SubscriberExceptionEvent : global::Java.Lang.Object {


		static IntPtr causingEvent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='SubscriberExceptionEvent']/field[@name='causingEvent']"
		[Register ("causingEvent")]
		public global::Java.Lang.Object CausingEvent {
			get {
				if (causingEvent_jfieldId == IntPtr.Zero)
					causingEvent_jfieldId = JNIEnv.GetFieldID (class_ref, "causingEvent", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, causingEvent_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (causingEvent_jfieldId == IntPtr.Zero)
					causingEvent_jfieldId = JNIEnv.GetFieldID (class_ref, "causingEvent", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, causingEvent_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr causingSubscriber_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='SubscriberExceptionEvent']/field[@name='causingSubscriber']"
		[Register ("causingSubscriber")]
		public global::Java.Lang.Object CausingSubscriber {
			get {
				if (causingSubscriber_jfieldId == IntPtr.Zero)
					causingSubscriber_jfieldId = JNIEnv.GetFieldID (class_ref, "causingSubscriber", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, causingSubscriber_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (causingSubscriber_jfieldId == IntPtr.Zero)
					causingSubscriber_jfieldId = JNIEnv.GetFieldID (class_ref, "causingSubscriber", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, causingSubscriber_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr eventBus_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='SubscriberExceptionEvent']/field[@name='eventBus']"
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

		static IntPtr throwable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='SubscriberExceptionEvent']/field[@name='throwable']"
		[Register ("throwable")]
		public global::Java.Lang.Throwable Throwable {
			get {
				if (throwable_jfieldId == IntPtr.Zero)
					throwable_jfieldId = JNIEnv.GetFieldID (class_ref, "throwable", "Ljava/lang/Throwable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, throwable_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (throwable_jfieldId == IntPtr.Zero)
					throwable_jfieldId = JNIEnv.GetFieldID (class_ref, "throwable", "Ljava/lang/Throwable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, throwable_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/SubscriberExceptionEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubscriberExceptionEvent); }
		}

		internal SubscriberExceptionEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Ljava_lang_Throwable_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='SubscriberExceptionEvent']/constructor[@name='SubscriberExceptionEvent' and count(parameter)=4 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.EventBus'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Ljava/lang/Throwable;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe SubscriberExceptionEvent (global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus eventBus, global::Java.Lang.Throwable throwable, global::Java.Lang.Object causingEvent, global::Java.Lang.Object causingSubscriber)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (eventBus);
				__args [1] = new JValue (throwable);
				__args [2] = new JValue (causingEvent);
				__args [3] = new JValue (causingSubscriber);
				if (((object) this).GetType () != typeof (SubscriberExceptionEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Ljava/lang/Throwable;Ljava/lang/Object;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Ljava/lang/Throwable;Ljava/lang/Object;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Ljava_lang_Throwable_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Ljava_lang_Throwable_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Ljava/lang/Throwable;Ljava/lang/Object;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Ljava_lang_Throwable_Ljava_lang_Object_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vivalnk_sdk_common_eventbus_EventBus_Ljava_lang_Throwable_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
			}
		}

	}
}
