using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='TestScheduler']"
	[global::Android.Runtime.Register ("io/reactivex/schedulers/TestScheduler", DoNotGenerateAcw=true)]
	public sealed partial class TestScheduler : global::IO.Reactivex.Scheduler {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/schedulers/TestScheduler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TestScheduler); }
		}

		internal TestScheduler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='TestScheduler']/constructor[@name='TestScheduler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestScheduler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TestScheduler)) {
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

		static IntPtr id_ctor_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='TestScheduler']/constructor[@name='TestScheduler' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register (".ctor", "(JLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe TestScheduler (long delayTime, global::Java.Util.Concurrent.TimeUnit unit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delayTime);
				__args [1] = new JValue (unit);
				if (((object) this).GetType () != typeof (TestScheduler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JLjava/util/concurrent/TimeUnit;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JLjava/util/concurrent/TimeUnit;)V", __args);
					return;
				}

				if (id_ctor_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_ctor_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JLjava/util/concurrent/TimeUnit;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JLjava_util_concurrent_TimeUnit_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JLjava_util_concurrent_TimeUnit_, __args);
			} finally {
			}
		}

		static IntPtr id_advanceTimeBy_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='TestScheduler']/method[@name='advanceTimeBy' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("advanceTimeBy", "(JLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe void AdvanceTimeBy (long delayTime, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_advanceTimeBy_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_advanceTimeBy_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "advanceTimeBy", "(JLjava/util/concurrent/TimeUnit;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delayTime);
				__args [1] = new JValue (unit);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_advanceTimeBy_JLjava_util_concurrent_TimeUnit_, __args);
			} finally {
			}
		}

		static IntPtr id_advanceTimeTo_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='TestScheduler']/method[@name='advanceTimeTo' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("advanceTimeTo", "(JLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe void AdvanceTimeTo (long delayTime, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_advanceTimeTo_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_advanceTimeTo_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "advanceTimeTo", "(JLjava/util/concurrent/TimeUnit;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delayTime);
				__args [1] = new JValue (unit);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_advanceTimeTo_JLjava_util_concurrent_TimeUnit_, __args);
			} finally {
			}
		}

		static IntPtr id_createWorker;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='TestScheduler']/method[@name='createWorker' and count(parameter)=0]"
		[Register ("createWorker", "()Lio/reactivex/Scheduler$Worker;", "")]
		public override unsafe global::IO.Reactivex.Scheduler.Worker CreateWorker ()
		{
			if (id_createWorker == IntPtr.Zero)
				id_createWorker = JNIEnv.GetMethodID (class_ref, "createWorker", "()Lio/reactivex/Scheduler$Worker;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createWorker), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_triggerActions;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='TestScheduler']/method[@name='triggerActions' and count(parameter)=0]"
		[Register ("triggerActions", "()V", "")]
		public unsafe void TriggerActions ()
		{
			if (id_triggerActions == IntPtr.Zero)
				id_triggerActions = JNIEnv.GetMethodID (class_ref, "triggerActions", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_triggerActions);
			} finally {
			}
		}

	}
}
