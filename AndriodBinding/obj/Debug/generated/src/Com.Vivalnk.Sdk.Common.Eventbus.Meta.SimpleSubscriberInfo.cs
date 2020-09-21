using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Meta {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='SimpleSubscriberInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/meta/SimpleSubscriberInfo", DoNotGenerateAcw=true)]
	public partial class SimpleSubscriberInfo : global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.AbstractSubscriberInfo {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/meta/SimpleSubscriberInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleSubscriberInfo); }
		}

		protected SimpleSubscriberInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_ZarrayLcom_vivalnk_sdk_common_eventbus_meta_SubscriberMethodInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='SimpleSubscriberInfo']/constructor[@name='SimpleSubscriberInfo' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='boolean'] and parameter[3][@type='com.vivalnk.sdk.common.eventbus.meta.SubscriberMethodInfo[]']]"
		[Register (".ctor", "(Ljava/lang/Class;Z[Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberMethodInfo;)V", "")]
		public unsafe SimpleSubscriberInfo (global::Java.Lang.Class subscriberClass, bool shouldCheckSuperclass, global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.SubscriberMethodInfo[] methodInfos)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_methodInfos = JNIEnv.NewArray (methodInfos);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (subscriberClass);
				__args [1] = new JValue (shouldCheckSuperclass);
				__args [2] = new JValue (native_methodInfos);
				if (((object) this).GetType () != typeof (SimpleSubscriberInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;Z[Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberMethodInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Class;Z[Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberMethodInfo;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_ZarrayLcom_vivalnk_sdk_common_eventbus_meta_SubscriberMethodInfo_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_ZarrayLcom_vivalnk_sdk_common_eventbus_meta_SubscriberMethodInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Z[Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberMethodInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_ZarrayLcom_vivalnk_sdk_common_eventbus_meta_SubscriberMethodInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Class_ZarrayLcom_vivalnk_sdk_common_eventbus_meta_SubscriberMethodInfo_, __args);
			} finally {
				if (methodInfos != null) {
					JNIEnv.CopyArray (native_methodInfos, methodInfos);
					JNIEnv.DeleteLocalRef (native_methodInfos);
				}
			}
		}

		static Delegate cb_getSubscriberMethods;
#pragma warning disable 0169
		static Delegate GetGetSubscriberMethodsHandler ()
		{
			if (cb_getSubscriberMethods == null)
				cb_getSubscriberMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubscriberMethods);
			return cb_getSubscriberMethods;
		}

		static IntPtr n_GetSubscriberMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.SimpleSubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSubscriberMethods ());
		}
#pragma warning restore 0169

		static IntPtr id_getSubscriberMethods;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='SimpleSubscriberInfo']/method[@name='getSubscriberMethods' and count(parameter)=0]"
		[Register ("getSubscriberMethods", "()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetGetSubscriberMethodsHandler")]
		public override unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[] GetSubscriberMethods ()
		{
			if (id_getSubscriberMethods == IntPtr.Zero)
				id_getSubscriberMethods = JNIEnv.GetMethodID (class_ref, "getSubscriberMethods", "()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriberMethods), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod));
				else
					return (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubscriberMethods", "()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod));
			} finally {
			}
		}

	}
}
