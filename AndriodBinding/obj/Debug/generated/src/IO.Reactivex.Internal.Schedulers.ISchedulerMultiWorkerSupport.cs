using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Schedulers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.schedulers']/interface[@name='SchedulerMultiWorkerSupport.WorkerCallback']"
	[Register ("io/reactivex/internal/schedulers/SchedulerMultiWorkerSupport$WorkerCallback", "", "IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupportWorkerCallbackInvoker")]
	public partial interface ISchedulerMultiWorkerSupportWorkerCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/interface[@name='SchedulerMultiWorkerSupport.WorkerCallback']/method[@name='onWorker' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='io.reactivex.Scheduler.Worker']]"
		[Register ("onWorker", "(ILio/reactivex/Scheduler$Worker;)V", "GetOnWorker_ILio_reactivex_Scheduler_Worker_Handler:IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupportWorkerCallbackInvoker, AndriodBinding")]
		void OnWorker (int p0, global::IO.Reactivex.Scheduler.Worker p1);

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/SchedulerMultiWorkerSupport$WorkerCallback", DoNotGenerateAcw=true)]
	internal partial class ISchedulerMultiWorkerSupportWorkerCallbackInvoker : global::Java.Lang.Object, ISchedulerMultiWorkerSupportWorkerCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/schedulers/SchedulerMultiWorkerSupport$WorkerCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISchedulerMultiWorkerSupportWorkerCallbackInvoker); }
		}

		IntPtr class_ref;

		public static ISchedulerMultiWorkerSupportWorkerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISchedulerMultiWorkerSupportWorkerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.schedulers.SchedulerMultiWorkerSupport.WorkerCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISchedulerMultiWorkerSupportWorkerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onWorker_ILio_reactivex_Scheduler_Worker_;
#pragma warning disable 0169
		static Delegate GetOnWorker_ILio_reactivex_Scheduler_Worker_Handler ()
		{
			if (cb_onWorker_ILio_reactivex_Scheduler_Worker_ == null)
				cb_onWorker_ILio_reactivex_Scheduler_Worker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnWorker_ILio_reactivex_Scheduler_Worker_);
			return cb_onWorker_ILio_reactivex_Scheduler_Worker_;
		}

		static void n_OnWorker_ILio_reactivex_Scheduler_Worker_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupportWorkerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWorker (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onWorker_ILio_reactivex_Scheduler_Worker_;
		public unsafe void OnWorker (int p0, global::IO.Reactivex.Scheduler.Worker p1)
		{
			if (id_onWorker_ILio_reactivex_Scheduler_Worker_ == IntPtr.Zero)
				id_onWorker_ILio_reactivex_Scheduler_Worker_ = JNIEnv.GetMethodID (class_ref, "onWorker", "(ILio/reactivex/Scheduler$Worker;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWorker_ILio_reactivex_Scheduler_Worker_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.schedulers']/interface[@name='SchedulerMultiWorkerSupport']"
	[Register ("io/reactivex/internal/schedulers/SchedulerMultiWorkerSupport", "", "IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupportInvoker")]
	public partial interface ISchedulerMultiWorkerSupport : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/interface[@name='SchedulerMultiWorkerSupport']/method[@name='createWorkers' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='io.reactivex.internal.schedulers.SchedulerMultiWorkerSupport.WorkerCallback']]"
		[Register ("createWorkers", "(ILio/reactivex/internal/schedulers/SchedulerMultiWorkerSupport$WorkerCallback;)V", "GetCreateWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_Handler:IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupportInvoker, AndriodBinding")]
		void CreateWorkers (int p0, global::IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupportWorkerCallback p1);

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/SchedulerMultiWorkerSupport", DoNotGenerateAcw=true)]
	internal partial class ISchedulerMultiWorkerSupportInvoker : global::Java.Lang.Object, ISchedulerMultiWorkerSupport {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/schedulers/SchedulerMultiWorkerSupport");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISchedulerMultiWorkerSupportInvoker); }
		}

		IntPtr class_ref;

		public static ISchedulerMultiWorkerSupport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISchedulerMultiWorkerSupport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.schedulers.SchedulerMultiWorkerSupport"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISchedulerMultiWorkerSupportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_;
#pragma warning disable 0169
		static Delegate GetCreateWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_Handler ()
		{
			if (cb_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_ == null)
				cb_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_CreateWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_);
			return cb_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_;
		}

		static void n_CreateWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupportWorkerCallback)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupportWorkerCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CreateWorkers (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_;
		public unsafe void CreateWorkers (int p0, global::IO.Reactivex.Internal.Schedulers.ISchedulerMultiWorkerSupportWorkerCallback p1)
		{
			if (id_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_ == IntPtr.Zero)
				id_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_ = JNIEnv.GetMethodID (class_ref, "createWorkers", "(ILio/reactivex/internal/schedulers/SchedulerMultiWorkerSupport$WorkerCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createWorkers_ILio_reactivex_internal_schedulers_SchedulerMultiWorkerSupport_WorkerCallback_, __args);
		}

	}

}
