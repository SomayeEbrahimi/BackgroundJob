using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Meta {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/meta/AbstractSubscriberInfo", DoNotGenerateAcw=true)]
	public abstract partial class AbstractSubscriberInfo : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/meta/AbstractSubscriberInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractSubscriberInfo); }
		}

		protected AbstractSubscriberInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_lang_Class_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/constructor[@name='AbstractSubscriberInfo' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Class&lt;? extends com.vivalnk.sdk.common.eventbus.meta.SubscriberInfo&gt;'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/Class;Z)V", "")]
		protected unsafe AbstractSubscriberInfo (global::Java.Lang.Class subscriberClass, global::Java.Lang.Class superSubscriberInfoClass, bool shouldCheckSuperclass)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (subscriberClass);
				__args [1] = new JValue (superSubscriberInfoClass);
				__args [2] = new JValue (shouldCheckSuperclass);
				if (((object) this).GetType () != typeof (AbstractSubscriberInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;Ljava/lang/Class;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Class;Ljava/lang/Class;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_lang_Class_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_lang_Class_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/lang/Class;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_Z, __args);
			} finally {
			}
		}

		static Delegate cb_getSubscriberClass;
#pragma warning disable 0169
		static Delegate GetGetSubscriberClassHandler ()
		{
			if (cb_getSubscriberClass == null)
				cb_getSubscriberClass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubscriberClass);
			return cb_getSubscriberClass;
		}

		static IntPtr n_GetSubscriberClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.AbstractSubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscriberClass);
		}
#pragma warning restore 0169

		static IntPtr id_getSubscriberClass;
		public virtual unsafe global::Java.Lang.Class SubscriberClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='getSubscriberClass' and count(parameter)=0]"
			[Register ("getSubscriberClass", "()Ljava/lang/Class;", "GetGetSubscriberClassHandler")]
			get {
				if (id_getSubscriberClass == IntPtr.Zero)
					id_getSubscriberClass = JNIEnv.GetMethodID (class_ref, "getSubscriberClass", "()Ljava/lang/Class;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriberClass), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubscriberClass", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSuperSubscriberInfo;
#pragma warning disable 0169
		static Delegate GetGetSuperSubscriberInfoHandler ()
		{
			if (cb_getSuperSubscriberInfo == null)
				cb_getSuperSubscriberInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSuperSubscriberInfo);
			return cb_getSuperSubscriberInfo;
		}

		static IntPtr n_GetSuperSubscriberInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.AbstractSubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SuperSubscriberInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getSuperSubscriberInfo;
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo SuperSubscriberInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='getSuperSubscriberInfo' and count(parameter)=0]"
			[Register ("getSuperSubscriberInfo", "()Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfo;", "GetGetSuperSubscriberInfoHandler")]
			get {
				if (id_getSuperSubscriberInfo == IntPtr.Zero)
					id_getSuperSubscriberInfo = JNIEnv.GetMethodID (class_ref, "getSuperSubscriberInfo", "()Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfo;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSuperSubscriberInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuperSubscriberInfo", "()Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_);
			return cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_CreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_methodName, IntPtr native_eventType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.AbstractSubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var methodName = JNIEnv.GetString (native_methodName, JniHandleOwnership.DoNotTransfer);
			var eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSubscriberMethod (methodName, eventType));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='createSubscriberMethod' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetCreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Handler")]
		protected virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod CreateSubscriberMethod (string methodName, global::Java.Lang.Class eventType)
		{
			if (id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_methodName);
				__args [1] = new JValue (eventType);

				global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static Delegate cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_;
#pragma warning disable 0169
		static Delegate GetCreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_Handler ()
		{
			if (cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_ == null)
				cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_CreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_);
			return cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_;
		}

		static IntPtr n_CreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_methodName, IntPtr native_eventType, IntPtr native_threadMode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.AbstractSubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var methodName = JNIEnv.GetString (native_methodName, JniHandleOwnership.DoNotTransfer);
			var eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			var threadMode = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (native_threadMode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSubscriberMethod (methodName, eventType, threadMode));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='createSubscriberMethod' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.eventbus.ThreadMode']]"
		[Register ("createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetCreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_Handler")]
		protected virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod CreateSubscriberMethod (string methodName, global::Java.Lang.Class eventType, global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode threadMode)
		{
			if (id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_ == IntPtr.Zero)
				id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_ = JNIEnv.GetMethodID (class_ref, "createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_methodName);
				__args [1] = new JValue (eventType);
				__args [2] = new JValue (threadMode);

				global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static Delegate cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ;
#pragma warning disable 0169
		static Delegate GetCreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZHandler ()
		{
			if (cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ == null)
				cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLIZ_L) n_CreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ);
			return cb_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ;
		}

		static IntPtr n_CreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_methodName, IntPtr native_eventType, IntPtr native_threadMode, int priority, bool sticky)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.AbstractSubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var methodName = JNIEnv.GetString (native_methodName, JniHandleOwnership.DoNotTransfer);
			var eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			var threadMode = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (native_threadMode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSubscriberMethod (methodName, eventType, threadMode, priority, sticky));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='createSubscriberMethod' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.eventbus.ThreadMode'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetCreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZHandler")]
		protected virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod CreateSubscriberMethod (string methodName, global::Java.Lang.Class eventType, global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode threadMode, int priority, bool sticky)
		{
			if (id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ == IntPtr.Zero)
				id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ = JNIEnv.GetMethodID (class_ref, "createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_methodName);
				__args [1] = new JValue (eventType);
				__args [2] = new JValue (threadMode);
				__args [3] = new JValue (priority);
				__args [4] = new JValue (sticky);

				global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
			}
		}

		static Delegate cb_shouldCheckSuperclass;
#pragma warning disable 0169
		static Delegate GetShouldCheckSuperclassHandler ()
		{
			if (cb_shouldCheckSuperclass == null)
				cb_shouldCheckSuperclass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ShouldCheckSuperclass);
			return cb_shouldCheckSuperclass;
		}

		static bool n_ShouldCheckSuperclass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.AbstractSubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldCheckSuperclass ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldCheckSuperclass;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='shouldCheckSuperclass' and count(parameter)=0]"
		[Register ("shouldCheckSuperclass", "()Z", "GetShouldCheckSuperclassHandler")]
		public virtual unsafe bool ShouldCheckSuperclass ()
		{
			if (id_shouldCheckSuperclass == IntPtr.Zero)
				id_shouldCheckSuperclass = JNIEnv.GetMethodID (class_ref, "shouldCheckSuperclass", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldCheckSuperclass);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldCheckSuperclass", "()Z"));
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.AbstractSubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSubscriberMethods ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/interface[@name='SubscriberInfo']/method[@name='getSubscriberMethods' and count(parameter)=0]"
		[Register ("getSubscriberMethods", "()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetGetSubscriberMethodsHandler")]
		public abstract global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[] GetSubscriberMethods ();

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/meta/AbstractSubscriberInfo", DoNotGenerateAcw=true)]
	internal partial class AbstractSubscriberInfoInvoker : AbstractSubscriberInfo {

		public AbstractSubscriberInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractSubscriberInfoInvoker); }
		}

		static IntPtr id_getSubscriberMethods;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/interface[@name='SubscriberInfo']/method[@name='getSubscriberMethods' and count(parameter)=0]"
		[Register ("getSubscriberMethods", "()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetGetSubscriberMethodsHandler")]
		public override unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[] GetSubscriberMethods ()
		{
			if (id_getSubscriberMethods == IntPtr.Zero)
				id_getSubscriberMethods = JNIEnv.GetMethodID (class_ref, "getSubscriberMethods", "()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;");
			try {
				return (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriberMethods), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod));
			} finally {
			}
		}

	}

}
