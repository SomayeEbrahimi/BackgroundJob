using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/BackgroundInitializer", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class BackgroundInitializer : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/BackgroundInitializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackgroundInitializer); }
		}

		protected BackgroundInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/constructor[@name='BackgroundInitializer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe BackgroundInitializer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BackgroundInitializer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_util_concurrent_ExecutorService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/constructor[@name='BackgroundInitializer' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutorService']]"
		[Register (".ctor", "(Ljava/util/concurrent/ExecutorService;)V", "")]
		protected unsafe BackgroundInitializer (global::Java.Util.Concurrent.IExecutorService exec)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (exec);
				if (((object) this).GetType () != typeof (BackgroundInitializer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/ExecutorService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/ExecutorService;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_ExecutorService_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_ExecutorService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ExecutorService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ExecutorService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_ExecutorService_, __args);
			} finally {
			}
		}

		static IntPtr id_getActiveExecutor;
		protected unsafe global::Java.Util.Concurrent.IExecutorService ActiveExecutor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/method[@name='getActiveExecutor' and count(parameter)=0]"
			[Register ("getActiveExecutor", "()Ljava/util/concurrent/ExecutorService;", "")]
			get {
				if (id_getActiveExecutor == IntPtr.Zero)
					id_getActiveExecutor = JNIEnv.GetMethodID (class_ref, "getActiveExecutor", "()Ljava/util/concurrent/ExecutorService;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActiveExecutor), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getExternalExecutor;
		static IntPtr id_setExternalExecutor_Ljava_util_concurrent_ExecutorService_;
		public unsafe global::Java.Util.Concurrent.IExecutorService ExternalExecutor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/method[@name='getExternalExecutor' and count(parameter)=0]"
			[Register ("getExternalExecutor", "()Ljava/util/concurrent/ExecutorService;", "")]
			get {
				if (id_getExternalExecutor == IntPtr.Zero)
					id_getExternalExecutor = JNIEnv.GetMethodID (class_ref, "getExternalExecutor", "()Ljava/util/concurrent/ExecutorService;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExternalExecutor), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/method[@name='setExternalExecutor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutorService']]"
			[Register ("setExternalExecutor", "(Ljava/util/concurrent/ExecutorService;)V", "")]
			set {
				if (id_setExternalExecutor_Ljava_util_concurrent_ExecutorService_ == IntPtr.Zero)
					id_setExternalExecutor_Ljava_util_concurrent_ExecutorService_ = JNIEnv.GetMethodID (class_ref, "setExternalExecutor", "(Ljava/util/concurrent/ExecutorService;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExternalExecutor_Ljava_util_concurrent_ExecutorService_, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFuture;
#pragma warning disable 0169
		static Delegate GetGetFutureHandler ()
		{
			if (cb_getFuture == null)
				cb_getFuture = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFuture);
			return cb_getFuture;
		}

		static IntPtr n_GetFuture (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Future);
		}
#pragma warning restore 0169

		static IntPtr id_getFuture;
		public virtual unsafe global::Java.Util.Concurrent.IFuture Future {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/method[@name='getFuture' and count(parameter)=0]"
			[Register ("getFuture", "()Ljava/util/concurrent/Future;", "GetGetFutureHandler")]
			get {
				if (id_getFuture == IntPtr.Zero)
					id_getFuture = JNIEnv.GetMethodID (class_ref, "getFuture", "()Ljava/util/concurrent/Future;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFuture), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFuture", "()Ljava/util/concurrent/Future;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isStarted;
#pragma warning disable 0169
		static Delegate GetIsStartedHandler ()
		{
			if (cb_isStarted == null)
				cb_isStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStarted);
			return cb_isStarted;
		}

		static bool n_IsStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		static IntPtr id_isStarted;
		public virtual unsafe bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "GetIsStartedHandler")]
			get {
				if (id_isStarted == IntPtr.Zero)
					id_isStarted = JNIEnv.GetMethodID (class_ref, "isStarted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStarted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStarted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getTaskCount;
#pragma warning disable 0169
		static Delegate GetGetTaskCountHandler ()
		{
			if (cb_getTaskCount == null)
				cb_getTaskCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTaskCount);
			return cb_getTaskCount;
		}

		static int n_GetTaskCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TaskCount;
		}
#pragma warning restore 0169

		static IntPtr id_getTaskCount;
		protected virtual unsafe int TaskCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/method[@name='getTaskCount' and count(parameter)=0]"
			[Register ("getTaskCount", "()I", "GetGetTaskCountHandler")]
			get {
				if (id_getTaskCount == IntPtr.Zero)
					id_getTaskCount = JNIEnv.GetMethodID (class_ref, "getTaskCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTaskCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaskCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public virtual unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Initialize);
			return cb_initialize;
		}

		static IntPtr n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Initialize ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()Ljava/lang/Object;", "GetInitializeHandler")]
		protected abstract global::Java.Lang.Object Initialize ();

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Start);
			return cb_start;
		}

		static bool n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()Z", "GetStartHandler")]
		public virtual unsafe bool Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()Z"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/BackgroundInitializer", DoNotGenerateAcw=true)]
	internal partial class BackgroundInitializerInvoker : BackgroundInitializer, global::Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializer {

		public BackgroundInitializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackgroundInitializerInvoker); }
		}

		static IntPtr id_initialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BackgroundInitializer']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()Ljava/lang/Object;", "GetInitializeHandler")]
		protected override unsafe global::Java.Lang.Object Initialize ()
		{
			if (id_initialize == IntPtr.Zero)
				id_initialize = JNIEnv.GetMethodID (class_ref, "initialize", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initialize), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
