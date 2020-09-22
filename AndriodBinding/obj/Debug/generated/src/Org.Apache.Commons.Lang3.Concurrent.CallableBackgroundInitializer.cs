using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='CallableBackgroundInitializer']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/CallableBackgroundInitializer", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class CallableBackgroundInitializer : global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/CallableBackgroundInitializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallableBackgroundInitializer); }
		}

		protected CallableBackgroundInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='CallableBackgroundInitializer']/constructor[@name='CallableBackgroundInitializer' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;T&gt;']]"
		[Register (".ctor", "(Ljava/util/concurrent/Callable;)V", "")]
		public unsafe CallableBackgroundInitializer (global::Java.Util.Concurrent.ICallable call)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (call);
				if (((object) this).GetType () != typeof (CallableBackgroundInitializer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/Callable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/Callable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/Callable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_Callable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_Callable_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_util_concurrent_Callable_Ljava_util_concurrent_ExecutorService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='CallableBackgroundInitializer']/constructor[@name='CallableBackgroundInitializer' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;T&gt;'] and parameter[2][@type='java.util.concurrent.ExecutorService']]"
		[Register (".ctor", "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/ExecutorService;)V", "")]
		public unsafe CallableBackgroundInitializer (global::Java.Util.Concurrent.ICallable call, global::Java.Util.Concurrent.IExecutorService exec)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (call);
				__args [1] = new JValue (exec);
				if (((object) this).GetType () != typeof (CallableBackgroundInitializer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/ExecutorService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/ExecutorService;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_Callable_Ljava_util_concurrent_ExecutorService_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_Callable_Ljava_util_concurrent_ExecutorService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/ExecutorService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_Callable_Ljava_util_concurrent_ExecutorService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_Callable_Ljava_util_concurrent_ExecutorService_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.CallableBackgroundInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Initialize ());
		}
#pragma warning restore 0169

		static IntPtr id_initialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='CallableBackgroundInitializer']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()Ljava/lang/Object;", "GetInitializeHandler")]
		protected override unsafe global::Java.Lang.Object Initialize ()
		{
			if (id_initialize == IntPtr.Zero)
				id_initialize = JNIEnv.GetMethodID (class_ref, "initialize", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initialize), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
