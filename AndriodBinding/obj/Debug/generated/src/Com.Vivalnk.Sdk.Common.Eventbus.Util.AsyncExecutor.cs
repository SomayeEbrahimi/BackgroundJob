using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='AsyncExecutor']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/AsyncExecutor", DoNotGenerateAcw=true)]
	public partial class AsyncExecutor : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='AsyncExecutor.Builder']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='AsyncExecutor.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor;", "GetBuildHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_buildForScope_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetBuildForScope_Ljava_lang_Object_Handler ()
			{
				if (cb_buildForScope_Ljava_lang_Object_ == null)
					cb_buildForScope_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_BuildForScope_Ljava_lang_Object_);
				return cb_buildForScope_Ljava_lang_Object_;
			}

			static IntPtr n_BuildForScope_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_executionContext)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var executionContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_executionContext, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildForScope (executionContext));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_buildForScope_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='AsyncExecutor.Builder']/method[@name='buildForScope' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("buildForScope", "(Ljava/lang/Object;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor;", "GetBuildForScope_Ljava_lang_Object_Handler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor BuildForScope (global::Java.Lang.Object executionContext)
			{
				if (id_buildForScope_Ljava_lang_Object_ == IntPtr.Zero)
					id_buildForScope_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "buildForScope", "(Ljava/lang/Object;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (executionContext);

					global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildForScope_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildForScope", "(Ljava/lang/Object;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_eventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
#pragma warning disable 0169
			static Delegate GetEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_Handler ()
			{
				if (cb_eventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_ == null)
					cb_eventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_EventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_);
				return cb_eventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
			}

			static IntPtr n_EventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventBus)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var eventBus = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (native_eventBus, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EventBus (eventBus));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_eventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='AsyncExecutor.Builder']/method[@name='eventBus' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.EventBus']]"
			[Register ("eventBus", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;", "GetEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_Handler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder EventBus (global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus eventBus)
			{
				if (id_eventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_ == IntPtr.Zero)
					id_eventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_ = JNIEnv.GetMethodID (class_ref, "eventBus", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (eventBus);

					global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_eventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "eventBus", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_failureEventType_Ljava_lang_Class_;
#pragma warning disable 0169
			static Delegate GetFailureEventType_Ljava_lang_Class_Handler ()
			{
				if (cb_failureEventType_Ljava_lang_Class_ == null)
					cb_failureEventType_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FailureEventType_Ljava_lang_Class_);
				return cb_failureEventType_Ljava_lang_Class_;
			}

			static IntPtr n_FailureEventType_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_failureEventType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var failureEventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_failureEventType, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FailureEventType (failureEventType));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_failureEventType_Ljava_lang_Class_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='AsyncExecutor.Builder']/method[@name='failureEventType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
			[Register ("failureEventType", "(Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;", "GetFailureEventType_Ljava_lang_Class_Handler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder FailureEventType (global::Java.Lang.Class failureEventType)
			{
				if (id_failureEventType_Ljava_lang_Class_ == IntPtr.Zero)
					id_failureEventType_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "failureEventType", "(Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (failureEventType);

					global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_failureEventType_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "failureEventType", "(Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_threadPool_Ljava_util_concurrent_Executor_;
#pragma warning disable 0169
			static Delegate GetThreadPool_Ljava_util_concurrent_Executor_Handler ()
			{
				if (cb_threadPool_Ljava_util_concurrent_Executor_ == null)
					cb_threadPool_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ThreadPool_Ljava_util_concurrent_Executor_);
				return cb_threadPool_Ljava_util_concurrent_Executor_;
			}

			static IntPtr n_ThreadPool_Ljava_util_concurrent_Executor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_threadPool)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var threadPool = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_threadPool, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ThreadPool (threadPool));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_threadPool_Ljava_util_concurrent_Executor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='AsyncExecutor.Builder']/method[@name='threadPool' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
			[Register ("threadPool", "(Ljava/util/concurrent/Executor;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;", "GetThreadPool_Ljava_util_concurrent_Executor_Handler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder ThreadPool (global::Java.Util.Concurrent.IExecutor threadPool)
			{
				if (id_threadPool_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
					id_threadPool_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID (class_ref, "threadPool", "(Ljava/util/concurrent/Executor;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (threadPool);

					global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_threadPool_Ljava_util_concurrent_Executor_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "threadPool", "(Ljava/util/concurrent/Executor;)Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/interface[@name='AsyncExecutor.RunnableEx']"
		[Register ("com/vivalnk/sdk/common/eventbus/util/AsyncExecutor$RunnableEx", "", "Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor/IRunnableExInvoker")]
		public partial interface IRunnableEx : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/interface[@name='AsyncExecutor.RunnableEx']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler:Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor/IRunnableExInvoker, AndriodBinding")]
			void Run ();

		}

		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/AsyncExecutor$RunnableEx", DoNotGenerateAcw=true)]
		internal partial class IRunnableExInvoker : global::Java.Lang.Object, IRunnableEx {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/AsyncExecutor$RunnableEx");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRunnableExInvoker); }
			}

			IntPtr class_ref;

			public static IRunnableEx GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRunnableEx> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.eventbus.util.AsyncExecutor.RunnableEx"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRunnableExInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.IRunnableEx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			IntPtr id_run;
			public unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/AsyncExecutor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncExecutor); }
		}

		protected AsyncExecutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_builder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='AsyncExecutor']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder InvokeBuilder ()
		{
			if (id_builder == IntPtr.Zero)
				id_builder = JNIEnv.GetStaticMethodID (class_ref, "builder", "()Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$Builder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='AsyncExecutor']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_execute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_Handler ()
		{
			if (cb_execute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_ == null)
				cb_execute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Execute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_);
			return cb_execute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_;
		}

		static void n_Execute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runnable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var runnable = (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.IRunnableEx)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.IRunnableEx> (native_runnable, JniHandleOwnership.DoNotTransfer);
			__this.Execute (runnable);
		}
#pragma warning restore 0169

		static IntPtr id_execute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='AsyncExecutor']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.AsyncExecutor.RunnableEx']]"
		[Register ("execute", "(Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$RunnableEx;)V", "GetExecute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_Handler")]
		public virtual unsafe void Execute (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.AsyncExecutor.IRunnableEx runnable)
		{
			if (id_execute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_ == IntPtr.Zero)
				id_execute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$RunnableEx;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (runnable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute_Lcom_vivalnk_sdk_common_eventbus_util_AsyncExecutor_RunnableEx_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Lcom/vivalnk/sdk/common/eventbus/util/AsyncExecutor$RunnableEx;)V"), __args);
			} finally {
			}
		}

	}
}
