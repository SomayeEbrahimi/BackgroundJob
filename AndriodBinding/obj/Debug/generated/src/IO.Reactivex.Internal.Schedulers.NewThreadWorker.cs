using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='NewThreadWorker']"
	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/NewThreadWorker", DoNotGenerateAcw=true)]
	public partial class NewThreadWorker : global::IO.Reactivex.Scheduler.Worker, global::IO.Reactivex.Disposables.IDisposable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/schedulers/NewThreadWorker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NewThreadWorker); }
		}

		protected NewThreadWorker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_ThreadFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='NewThreadWorker']/constructor[@name='NewThreadWorker' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
		[Register (".ctor", "(Ljava/util/concurrent/ThreadFactory;)V", "")]
		public unsafe NewThreadWorker (global::Java.Util.Concurrent.IThreadFactory threadFactory)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threadFactory);
				if (((object) this).GetType () != typeof (NewThreadWorker)) {
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.NewThreadWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDisposed;
		}
#pragma warning restore 0169

		static IntPtr id_isDisposed;
		public override unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='NewThreadWorker']/method[@name='isDisposed' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.NewThreadWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='NewThreadWorker']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
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

		static Delegate cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetSchedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == null)
				cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJL_L) n_Schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_);
			return cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action, long delayTime, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.NewThreadWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var action = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_action, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Schedule (action, delayTime, unit));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='NewThreadWorker']/method[@name='schedule' and count(parameter)=3 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;", "GetSchedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler")]
		public override unsafe global::IO.Reactivex.Disposables.IDisposable Schedule (global::Java.Lang.IRunnable action, long delayTime, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (action);
				__args [1] = new JValue (delayTime);
				__args [2] = new JValue (unit);

				global::IO.Reactivex.Disposables.IDisposable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_scheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_;
#pragma warning disable 0169
		static Delegate GetScheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_Handler ()
		{
			if (cb_scheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_ == null)
				cb_scheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJLL_L) n_ScheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_);
			return cb_scheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_;
		}

		static IntPtr n_ScheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_run, long delayTime, IntPtr native_unit, IntPtr native_parent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.NewThreadWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var run = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_run, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			var parent = (global::IO.Reactivex.Internal.Disposables.IDisposableContainer)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Disposables.IDisposableContainer> (native_parent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ScheduleActual (run, delayTime, unit, parent));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_scheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='NewThreadWorker']/method[@name='scheduleActual' and count(parameter)=4 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.internal.disposables.DisposableContainer']]"
		[Register ("scheduleActual", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;Lio/reactivex/internal/disposables/DisposableContainer;)Lio/reactivex/internal/schedulers/ScheduledRunnable;", "GetScheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_Handler")]
		public virtual unsafe global::IO.Reactivex.Internal.Schedulers.ScheduledRunnable ScheduleActual (global::Java.Lang.IRunnable run, long delayTime, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Internal.Disposables.IDisposableContainer parent)
		{
			if (id_scheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_ == IntPtr.Zero)
				id_scheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_ = JNIEnv.GetMethodID (class_ref, "scheduleActual", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;Lio/reactivex/internal/disposables/DisposableContainer;)Lio/reactivex/internal/schedulers/ScheduledRunnable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (run);
				__args [1] = new JValue (delayTime);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (parent);

				global::IO.Reactivex.Internal.Schedulers.ScheduledRunnable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.ScheduledRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scheduleActual_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_internal_disposables_DisposableContainer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.ScheduledRunnable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scheduleActual", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;Lio/reactivex/internal/disposables/DisposableContainer;)Lio/reactivex/internal/schedulers/ScheduledRunnable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetScheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == null)
				cb_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJL_L) n_ScheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_);
			return cb_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_ScheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_run, long delayTime, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.NewThreadWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var run = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_run, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ScheduleDirect (run, delayTime, unit));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='NewThreadWorker']/method[@name='scheduleDirect' and count(parameter)=3 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("scheduleDirect", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;", "GetScheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::IO.Reactivex.Disposables.IDisposable ScheduleDirect (global::Java.Lang.IRunnable run, long delayTime, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "scheduleDirect", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (run);
				__args [1] = new JValue (delayTime);
				__args [2] = new JValue (unit);

				global::IO.Reactivex.Disposables.IDisposable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scheduleDirect", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_schedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetSchedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_schedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == null)
				cb_schedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJL_L) n_SchedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_);
			return cb_schedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_SchedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_run, long initialDelay, long period, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.NewThreadWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var run = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_run, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SchedulePeriodicallyDirect (run, initialDelay, period, unit));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_schedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='NewThreadWorker']/method[@name='schedulePeriodicallyDirect' and count(parameter)=4 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit']]"
		[Register ("schedulePeriodicallyDirect", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;", "GetSchedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::IO.Reactivex.Disposables.IDisposable SchedulePeriodicallyDirect (global::Java.Lang.IRunnable run, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_schedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_schedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "schedulePeriodicallyDirect", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (run);
				__args [1] = new JValue (initialDelay);
				__args [2] = new JValue (period);
				__args [3] = new JValue (unit);

				global::IO.Reactivex.Disposables.IDisposable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_schedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "schedulePeriodicallyDirect", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.NewThreadWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='NewThreadWorker']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutdown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutdown", "()V"));
			} finally {
			}
		}

	}
}
