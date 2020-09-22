using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ComputationScheduler']"
	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/ComputationScheduler", DoNotGenerateAcw=true)]
	public sealed partial class ComputationScheduler : global::IO.Reactivex.Scheduler, global::IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupport {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/schedulers/ComputationScheduler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ComputationScheduler); }
		}

		internal ComputationScheduler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ComputationScheduler']/constructor[@name='ComputationScheduler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ComputationScheduler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ComputationScheduler)) {
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

		static IntPtr id_ctor_Ljava_util_concurrent_ThreadFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ComputationScheduler']/constructor[@name='ComputationScheduler' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
		[Register (".ctor", "(Ljava/util/concurrent/ThreadFactory;)V", "")]
		public unsafe ComputationScheduler (global::Java.Util.Concurrent.IThreadFactory threadFactory)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threadFactory);
				if (((object) this).GetType () != typeof (ComputationScheduler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/ThreadFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/ThreadFactory;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_ThreadFactory_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_ThreadFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ThreadFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ThreadFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_ThreadFactory_, __args);
			} finally {
			}
		}

		static IntPtr id_createWorker;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ComputationScheduler']/method[@name='createWorker' and count(parameter)=0]"
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

		static IntPtr id_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ComputationScheduler']/method[@name='createWorkers' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='io.reactivex.internal.schedulers.SchedulerMultiWorkerSupport.WorkerCallback']]"
		[Register ("createWorkers", "(ILio/reactivex/internal/schedulers/SchedulerMultiWorkerSupport$WorkerCallback;)V", "")]
		public unsafe void CreateWorkers (int number, global::IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupportWorkerCallback @callback)
		{
			if (id_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_ == IntPtr.Zero)
				id_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_ = JNIEnv.GetMethodID (class_ref, "createWorkers", "(ILio/reactivex/internal/schedulers/SchedulerMultiWorkerSupport$WorkerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (number);
				__args [1] = new JValue (@callback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_, __args);
			} finally {
			}
		}

	}
}
