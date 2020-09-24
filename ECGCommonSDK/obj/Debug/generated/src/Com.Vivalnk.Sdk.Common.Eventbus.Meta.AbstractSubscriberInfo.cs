using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Meta {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/meta/AbstractSubscriberInfo", DoNotGenerateAcw=true)]
	public abstract partial class AbstractSubscriberInfo : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/meta/AbstractSubscriberInfo", typeof (AbstractSubscriberInfo));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected AbstractSubscriberInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/constructor[@name='AbstractSubscriberInfo' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Class&lt;? extends com.vivalnk.sdk.common.eventbus.meta.SubscriberInfo&gt;'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/Class;Z)V", "")]
		protected unsafe AbstractSubscriberInfo (global::Java.Lang.Class subscriberClass, global::Java.Lang.Class superSubscriberInfoClass, bool shouldCheckSuperclass)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;Ljava/lang/Class;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((subscriberClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriberClass).Handle);
				__args [1] = new JniArgumentValue ((superSubscriberInfoClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) superSubscriberInfoClass).Handle);
				__args [2] = new JniArgumentValue (shouldCheckSuperclass);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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

		public virtual unsafe global::Java.Lang.Class SubscriberClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='getSubscriberClass' and count(parameter)=0]"
			[Register ("getSubscriberClass", "()Ljava/lang/Class;", "GetGetSubscriberClassHandler")]
			get {
				const string __id = "getSubscriberClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo SuperSubscriberInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='getSuperSubscriberInfo' and count(parameter)=0]"
			[Register ("getSuperSubscriberInfo", "()Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfo;", "GetGetSuperSubscriberInfoHandler")]
			get {
				const string __id = "getSuperSubscriberInfo.()Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='createSubscriberMethod' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetCreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Handler")]
		protected virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod CreateSubscriberMethod (string methodName, global::Java.Lang.Class eventType)
		{
			const string __id = "createSubscriberMethod.(Ljava/lang/String;Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_methodName);
				__args [1] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='createSubscriberMethod' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.eventbus.ThreadMode']]"
		[Register ("createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetCreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_Handler")]
		protected virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod CreateSubscriberMethod (string methodName, global::Java.Lang.Class eventType, global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode threadMode)
		{
			const string __id = "createSubscriberMethod.(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_methodName);
				__args [1] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				__args [2] = new JniArgumentValue ((threadMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) threadMode).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='createSubscriberMethod' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.eventbus.ThreadMode'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("createSubscriberMethod", "(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetCreateSubscriberMethod_Ljava_lang_String_Ljava_lang_Class_Lcom_vivalnk_sdk_common_eventbus_ThreadMode_IZHandler")]
		protected virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod CreateSubscriberMethod (string methodName, global::Java.Lang.Class eventType, global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode threadMode, int priority, bool sticky)
		{
			const string __id = "createSubscriberMethod.(Ljava/lang/String;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_methodName);
				__args [1] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				__args [2] = new JniArgumentValue ((threadMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) threadMode).Handle);
				__args [3] = new JniArgumentValue (priority);
				__args [4] = new JniArgumentValue (sticky);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='AbstractSubscriberInfo']/method[@name='shouldCheckSuperclass' and count(parameter)=0]"
		[Register ("shouldCheckSuperclass", "()Z", "GetShouldCheckSuperclassHandler")]
		public virtual unsafe bool ShouldCheckSuperclass ()
		{
			const string __id = "shouldCheckSuperclass.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/meta/AbstractSubscriberInfo", typeof (AbstractSubscriberInfoInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/interface[@name='SubscriberInfo']/method[@name='getSubscriberMethods' and count(parameter)=0]"
		[Register ("getSubscriberMethods", "()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetGetSubscriberMethodsHandler")]
		public override unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[] GetSubscriberMethods ()
		{
			const string __id = "getSubscriberMethods.()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod));
			} finally {
			}
		}

	}

}
