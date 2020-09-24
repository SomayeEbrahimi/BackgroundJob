using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/EventBusBuilder", DoNotGenerateAcw=true)]
	public partial class EventBusBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/EventBusBuilder", typeof (EventBusBuilder));
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

		protected EventBusBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addIndex_Lcom_vivalnk_sdk_common_eventbus_meta_SubscriberInfoIndex_;
#pragma warning disable 0169
		static Delegate GetAddIndex_Lcom_vivalnk_sdk_common_eventbus_meta_SubscriberInfoIndex_Handler ()
		{
			if (cb_addIndex_Lcom_vivalnk_sdk_common_eventbus_meta_SubscriberInfoIndex_ == null)
				cb_addIndex_Lcom_vivalnk_sdk_common_eventbus_meta_SubscriberInfoIndex_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddIndex_Lcom_vivalnk_sdk_common_eventbus_meta_SubscriberInfoIndex_);
			return cb_addIndex_Lcom_vivalnk_sdk_common_eventbus_meta_SubscriberInfoIndex_;
		}

		static IntPtr n_AddIndex_Lcom_vivalnk_sdk_common_eventbus_meta_SubscriberInfoIndex_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = (global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoIndex)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddIndex (index));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='addIndex' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.meta.SubscriberInfoIndex']]"
		[Register ("addIndex", "(Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfoIndex;)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetAddIndex_Lcom_vivalnk_sdk_common_eventbus_meta_SubscriberInfoIndex_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder AddIndex (global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoIndex index)
		{
			const string __id = "addIndex.(Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfoIndex;)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((index == null) ? IntPtr.Zero : ((global::Java.Lang.Object) index).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/vivalnk/sdk/common/eventbus/EventBus;", "GetBuildHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus Build ()
		{
			const string __id = "build.()Lcom/vivalnk/sdk/common/eventbus/EventBus;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_eventInheritance_Z;
#pragma warning disable 0169
		static Delegate GetEventInheritance_ZHandler ()
		{
			if (cb_eventInheritance_Z == null)
				cb_eventInheritance_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_EventInheritance_Z);
			return cb_eventInheritance_Z;
		}

		static IntPtr n_EventInheritance_Z (IntPtr jnienv, IntPtr native__this, bool eventInheritance)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventInheritance (eventInheritance));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='eventInheritance' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("eventInheritance", "(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetEventInheritance_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder EventInheritance (bool eventInheritance)
		{
			const string __id = "eventInheritance.(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (eventInheritance);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_executorService_Ljava_util_concurrent_ExecutorService_;
#pragma warning disable 0169
		static Delegate GetExecutorService_Ljava_util_concurrent_ExecutorService_Handler ()
		{
			if (cb_executorService_Ljava_util_concurrent_ExecutorService_ == null)
				cb_executorService_Ljava_util_concurrent_ExecutorService_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ExecutorService_Ljava_util_concurrent_ExecutorService_);
			return cb_executorService_Ljava_util_concurrent_ExecutorService_;
		}

		static IntPtr n_ExecutorService_Ljava_util_concurrent_ExecutorService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_executorService)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var executorService = (global::Java.Util.Concurrent.IExecutorService)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (native_executorService, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExecutorService (executorService));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='executorService' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutorService']]"
		[Register ("executorService", "(Ljava/util/concurrent/ExecutorService;)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetExecutorService_Ljava_util_concurrent_ExecutorService_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder ExecutorService (global::Java.Util.Concurrent.IExecutorService executorService)
		{
			const string __id = "executorService.(Ljava/util/concurrent/ExecutorService;)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_ignoreGeneratedIndex_Z;
#pragma warning disable 0169
		static Delegate GetIgnoreGeneratedIndex_ZHandler ()
		{
			if (cb_ignoreGeneratedIndex_Z == null)
				cb_ignoreGeneratedIndex_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_IgnoreGeneratedIndex_Z);
			return cb_ignoreGeneratedIndex_Z;
		}

		static IntPtr n_IgnoreGeneratedIndex_Z (IntPtr jnienv, IntPtr native__this, bool ignoreGeneratedIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IgnoreGeneratedIndex (ignoreGeneratedIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='ignoreGeneratedIndex' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("ignoreGeneratedIndex", "(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetIgnoreGeneratedIndex_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder IgnoreGeneratedIndex (bool ignoreGeneratedIndex)
		{
			const string __id = "ignoreGeneratedIndex.(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ignoreGeneratedIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_installDefaultEventBus;
#pragma warning disable 0169
		static Delegate GetInstallDefaultEventBusHandler ()
		{
			if (cb_installDefaultEventBus == null)
				cb_installDefaultEventBus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_InstallDefaultEventBus);
			return cb_installDefaultEventBus;
		}

		static IntPtr n_InstallDefaultEventBus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InstallDefaultEventBus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='installDefaultEventBus' and count(parameter)=0]"
		[Register ("installDefaultEventBus", "()Lcom/vivalnk/sdk/common/eventbus/EventBus;", "GetInstallDefaultEventBusHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus InstallDefaultEventBus ()
		{
			const string __id = "installDefaultEventBus.()Lcom/vivalnk/sdk/common/eventbus/EventBus;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_logNoSubscriberMessages_Z;
#pragma warning disable 0169
		static Delegate GetLogNoSubscriberMessages_ZHandler ()
		{
			if (cb_logNoSubscriberMessages_Z == null)
				cb_logNoSubscriberMessages_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_LogNoSubscriberMessages_Z);
			return cb_logNoSubscriberMessages_Z;
		}

		static IntPtr n_LogNoSubscriberMessages_Z (IntPtr jnienv, IntPtr native__this, bool logNoSubscriberMessages)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LogNoSubscriberMessages (logNoSubscriberMessages));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='logNoSubscriberMessages' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("logNoSubscriberMessages", "(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetLogNoSubscriberMessages_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder LogNoSubscriberMessages (bool logNoSubscriberMessages)
		{
			const string __id = "logNoSubscriberMessages.(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (logNoSubscriberMessages);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_logSubscriberExceptions_Z;
#pragma warning disable 0169
		static Delegate GetLogSubscriberExceptions_ZHandler ()
		{
			if (cb_logSubscriberExceptions_Z == null)
				cb_logSubscriberExceptions_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_LogSubscriberExceptions_Z);
			return cb_logSubscriberExceptions_Z;
		}

		static IntPtr n_LogSubscriberExceptions_Z (IntPtr jnienv, IntPtr native__this, bool logSubscriberExceptions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LogSubscriberExceptions (logSubscriberExceptions));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='logSubscriberExceptions' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("logSubscriberExceptions", "(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetLogSubscriberExceptions_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder LogSubscriberExceptions (bool logSubscriberExceptions)
		{
			const string __id = "logSubscriberExceptions.(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (logSubscriberExceptions);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_logger_Lcom_vivalnk_sdk_common_eventbus_Logger_;
#pragma warning disable 0169
		static Delegate GetLogger_Lcom_vivalnk_sdk_common_eventbus_Logger_Handler ()
		{
			if (cb_logger_Lcom_vivalnk_sdk_common_eventbus_Logger_ == null)
				cb_logger_Lcom_vivalnk_sdk_common_eventbus_Logger_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Logger_Lcom_vivalnk_sdk_common_eventbus_Logger_);
			return cb_logger_Lcom_vivalnk_sdk_common_eventbus_Logger_;
		}

		static IntPtr n_Logger_Lcom_vivalnk_sdk_common_eventbus_Logger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logger)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var logger = (global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger> (native_logger, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Logger (logger));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='logger' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.Logger']]"
		[Register ("logger", "(Lcom/vivalnk/sdk/common/eventbus/Logger;)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetLogger_Lcom_vivalnk_sdk_common_eventbus_Logger_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder Logger (global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger logger)
		{
			const string __id = "logger.(Lcom/vivalnk/sdk/common/eventbus/Logger;)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logger).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sendNoSubscriberEvent_Z;
#pragma warning disable 0169
		static Delegate GetSendNoSubscriberEvent_ZHandler ()
		{
			if (cb_sendNoSubscriberEvent_Z == null)
				cb_sendNoSubscriberEvent_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SendNoSubscriberEvent_Z);
			return cb_sendNoSubscriberEvent_Z;
		}

		static IntPtr n_SendNoSubscriberEvent_Z (IntPtr jnienv, IntPtr native__this, bool sendNoSubscriberEvent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SendNoSubscriberEvent (sendNoSubscriberEvent));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='sendNoSubscriberEvent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("sendNoSubscriberEvent", "(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetSendNoSubscriberEvent_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder SendNoSubscriberEvent (bool sendNoSubscriberEvent)
		{
			const string __id = "sendNoSubscriberEvent.(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sendNoSubscriberEvent);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sendSubscriberExceptionEvent_Z;
#pragma warning disable 0169
		static Delegate GetSendSubscriberExceptionEvent_ZHandler ()
		{
			if (cb_sendSubscriberExceptionEvent_Z == null)
				cb_sendSubscriberExceptionEvent_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SendSubscriberExceptionEvent_Z);
			return cb_sendSubscriberExceptionEvent_Z;
		}

		static IntPtr n_SendSubscriberExceptionEvent_Z (IntPtr jnienv, IntPtr native__this, bool sendSubscriberExceptionEvent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SendSubscriberExceptionEvent (sendSubscriberExceptionEvent));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='sendSubscriberExceptionEvent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("sendSubscriberExceptionEvent", "(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetSendSubscriberExceptionEvent_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder SendSubscriberExceptionEvent (bool sendSubscriberExceptionEvent)
		{
			const string __id = "sendSubscriberExceptionEvent.(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sendSubscriberExceptionEvent);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skipMethodVerificationFor_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSkipMethodVerificationFor_Ljava_lang_Class_Handler ()
		{
			if (cb_skipMethodVerificationFor_Ljava_lang_Class_ == null)
				cb_skipMethodVerificationFor_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SkipMethodVerificationFor_Ljava_lang_Class_);
			return cb_skipMethodVerificationFor_Ljava_lang_Class_;
		}

		static IntPtr n_SkipMethodVerificationFor_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clazz)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SkipMethodVerificationFor (clazz));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='skipMethodVerificationFor' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("skipMethodVerificationFor", "(Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetSkipMethodVerificationFor_Ljava_lang_Class_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder SkipMethodVerificationFor (global::Java.Lang.Class clazz)
		{
			const string __id = "skipMethodVerificationFor.(Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_strictMethodVerification_Z;
#pragma warning disable 0169
		static Delegate GetStrictMethodVerification_ZHandler ()
		{
			if (cb_strictMethodVerification_Z == null)
				cb_strictMethodVerification_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_StrictMethodVerification_Z);
			return cb_strictMethodVerification_Z;
		}

		static IntPtr n_StrictMethodVerification_Z (IntPtr jnienv, IntPtr native__this, bool strictMethodVerification)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StrictMethodVerification (strictMethodVerification));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='strictMethodVerification' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("strictMethodVerification", "(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetStrictMethodVerification_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder StrictMethodVerification (bool strictMethodVerification)
		{
			const string __id = "strictMethodVerification.(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (strictMethodVerification);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_throwSubscriberException_Z;
#pragma warning disable 0169
		static Delegate GetThrowSubscriberException_ZHandler ()
		{
			if (cb_throwSubscriberException_Z == null)
				cb_throwSubscriberException_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ThrowSubscriberException_Z);
			return cb_throwSubscriberException_Z;
		}

		static IntPtr n_ThrowSubscriberException_Z (IntPtr jnienv, IntPtr native__this, bool throwSubscriberException)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThrowSubscriberException (throwSubscriberException));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBusBuilder']/method[@name='throwSubscriberException' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("throwSubscriberException", "(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "GetThrowSubscriberException_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder ThrowSubscriberException (bool throwSubscriberException)
		{
			const string __id = "throwSubscriberException.(Z)Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (throwSubscriberException);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
