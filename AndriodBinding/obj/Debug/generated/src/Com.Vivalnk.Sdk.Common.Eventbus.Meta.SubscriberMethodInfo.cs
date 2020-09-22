using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Meta {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='SubscriberMethodInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/meta/SubscriberMethodInfo", DoNotGenerateAcw=true)]
	public partial class SubscriberMethodInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/meta/SubscriberMethodInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubscriberMethodInfo); }
		}

		protected SubscriberMethodInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='SubscriberMethodInfo']/constructor[@name='SubscriberMethodInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public unsafe SubscriberMethodInfo (string methodName, global::Java.Lang.Class eventType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_methodName);
				__args [1] = new JValue (eventType);
				if (((object) this).GetType () != typeof (SubscriberMethodInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Class_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='SubscriberMethodInfo']/constructor[@name='SubscriberMethodInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.eventbus.ThreadMode']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;)V", "")]
		public unsafe SubscriberMethodInfo (string methodName, global::Java.Lang.Class eventType, global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode threadMode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_methodName);
				__args [1] = new JValue (eventType);
				__args [2] = new JValue (threadMode);
				if (((object) this).GetType () != typeof (SubscriberMethodInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='SubscriberMethodInfo']/constructor[@name='SubscriberMethodInfo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.eventbus.ThreadMode'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)V", "")]
		public unsafe SubscriberMethodInfo (string methodName, global::Java.Lang.Class eventType, global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode threadMode, int priority, bool sticky)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_methodName);
				__args [1] = new JValue (eventType);
				__args [2] = new JValue (threadMode);
				__args [3] = new JValue (priority);
				__args [4] = new JValue (sticky);
				if (((object) this).GetType () != typeof (SubscriberMethodInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

	}
}
