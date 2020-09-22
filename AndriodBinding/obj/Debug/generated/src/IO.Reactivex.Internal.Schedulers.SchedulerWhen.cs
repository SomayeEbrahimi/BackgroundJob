using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='SchedulerWhen']"
	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/SchedulerWhen", DoNotGenerateAcw=true)]
	public partial class SchedulerWhen : global::IO.Reactivex.Scheduler, global::IO.Reactivex.Disposables.IDisposable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/schedulers/SchedulerWhen", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SchedulerWhen); }
		}

		protected SchedulerWhen (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isDisposed;
#pragma warning disable 0169
		static Delegate GetIsDisposedHandler ()
		{
			if (cb_isDisposed == null)
				cb_isDisposed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDisposed);
			return cb_isDisposed;
		}

		static bool n_IsDisposed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.SchedulerWhen> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDisposed;
		}
#pragma warning restore 0169

		static IntPtr id_isDisposed;
		public virtual unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='SchedulerWhen']/method[@name='isDisposed' and count(parameter)=0]"
			[Register ("isDisposed", "()Z", "GetIsDisposedHandler")]
			get {
				if (id_isDisposed == IntPtr.Zero)
					id_isDisposed = JNIEnv.GetMethodID (class_ref, "isDisposed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisposed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDisposed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_createWorker;
#pragma warning disable 0169
		static Delegate GetCreateWorkerHandler ()
		{
			if (cb_createWorker == null)
				cb_createWorker = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateWorker);
			return cb_createWorker;
		}

		static IntPtr n_CreateWorker (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.SchedulerWhen> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateWorker ());
		}
#pragma warning restore 0169

		static IntPtr id_createWorker;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='SchedulerWhen']/method[@name='createWorker' and count(parameter)=0]"
		[Register ("createWorker", "()Lio/reactivex/Scheduler$Worker;", "GetCreateWorkerHandler")]
		public override unsafe global::IO.Reactivex.Scheduler.Worker CreateWorker ()
		{
			if (id_createWorker == IntPtr.Zero)
				id_createWorker = JNIEnv.GetMethodID (class_ref, "createWorker", "()Lio/reactivex/Scheduler$Worker;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createWorker), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createWorker", "()Lio/reactivex/Scheduler$Worker;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.SchedulerWhen> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='SchedulerWhen']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

	}
}
