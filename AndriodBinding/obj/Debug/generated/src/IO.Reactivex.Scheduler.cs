using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']"
	[global::Android.Runtime.Register ("io/reactivex/Scheduler", DoNotGenerateAcw=true)]
	public abstract partial class Scheduler : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker']"
		[global::Android.Runtime.Register ("io/reactivex/Scheduler$Worker", DoNotGenerateAcw=true)]
		public abstract partial class Worker : global::Java.Lang.Object, global::IO.Reactivex.Disposables.IDisposable {

			// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker.PeriodicTask']"
			[global::Android.Runtime.Register ("io/reactivex/Scheduler$Worker$PeriodicTask", DoNotGenerateAcw=true)]
			public sealed partial class PeriodicTask : global::Java.Lang.Object, global::IO.Reactivex.Schedulers.ISchedulerRunnableIntrospection, global::Java.Lang.IRunnable {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("io/reactivex/Scheduler$Worker$PeriodicTask", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (PeriodicTask); }
				}

				internal PeriodicTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getWrappedRunnable;
				public unsafe global::Java.Lang.IRunnable WrappedRunnable {
					// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker.PeriodicTask']/method[@name='getWrappedRunnable' and count(parameter)=0]"
					[Register ("getWrappedRunnable", "()Ljava/lang/Runnable;", "")]
					get {
						if (id_getWrappedRunnable == IntPtr.Zero)
							id_getWrappedRunnable = JNIEnv.GetMethodID (class_ref, "getWrappedRunnable", "()Ljava/lang/Runnable;");
						try {
							return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWrappedRunnable), JniHandleOwnership.TransferLocalRef);
						} finally {
						}
					}
				}

				static IntPtr id_run;
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker.PeriodicTask']/method[@name='run' and count(parameter)=0]"
				[Register ("run", "()V", "")]
				public unsafe void Run ()
				{
					if (id_run == IntPtr.Zero)
						id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
					try {
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/reactivex/Scheduler$Worker", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Worker); }
			}

			protected Worker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker']/constructor[@name='Scheduler.Worker' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Worker ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Worker)) {
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

			static Delegate cb_now_Ljava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
			static Delegate GetNow_Ljava_util_concurrent_TimeUnit_Handler ()
			{
				if (cb_now_Ljava_util_concurrent_TimeUnit_ == null)
					cb_now_Ljava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_Now_Ljava_util_concurrent_TimeUnit_);
				return cb_now_Ljava_util_concurrent_TimeUnit_;
			}

			static long n_Now_Ljava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unit)
			{
				var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
				long __ret = __this.Now (unit);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_now_Ljava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker']/method[@name='now' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.TimeUnit']]"
			[Register ("now", "(Ljava/util/concurrent/TimeUnit;)J", "GetNow_Ljava_util_concurrent_TimeUnit_Handler")]
			public virtual unsafe long Now (global::Java.Util.Concurrent.TimeUnit unit)
			{
				if (id_now_Ljava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_now_Ljava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "now", "(Ljava/util/concurrent/TimeUnit;)J");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (unit);

					long __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_now_Ljava_util_concurrent_TimeUnit_, __args);
					else
						__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "now", "(Ljava/util/concurrent/TimeUnit;)J"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_schedule_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetSchedule_Ljava_lang_Runnable_Handler ()
			{
				if (cb_schedule_Ljava_lang_Runnable_ == null)
					cb_schedule_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Schedule_Ljava_lang_Runnable_);
				return cb_schedule_Ljava_lang_Runnable_;
			}

			static IntPtr n_Schedule_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_run)
			{
				var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var run = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_run, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Schedule (run));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_schedule_Ljava_lang_Runnable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker']/method[@name='schedule' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("schedule", "(Ljava/lang/Runnable;)Lio/reactivex/disposables/Disposable;", "GetSchedule_Ljava_lang_Runnable_Handler")]
			public virtual unsafe global::IO.Reactivex.Disposables.IDisposable Schedule (global::Java.Lang.IRunnable run)
			{
				if (id_schedule_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_schedule_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "schedule", "(Ljava/lang/Runnable;)Lio/reactivex/disposables/Disposable;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (run);

					global::IO.Reactivex.Disposables.IDisposable __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_schedule_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "schedule", "(Ljava/lang/Runnable;)Lio/reactivex/disposables/Disposable;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
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

			static IntPtr n_Schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Schedule (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker']/method[@name='schedule' and count(parameter)=3 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
			[Register ("schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;", "GetSchedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler")]
			public abstract global::IO.Reactivex.Disposables.IDisposable Schedule (global::Java.Lang.IRunnable p0, long p1, global::Java.Util.Concurrent.TimeUnit p2);

			static Delegate cb_schedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
			static Delegate GetSchedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler ()
			{
				if (cb_schedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == null)
					cb_schedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJL_L) n_SchedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_);
				return cb_schedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
			}

			static IntPtr n_SchedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_run, long initialDelay, long period, IntPtr native_unit)
			{
				var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var run = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_run, JniHandleOwnership.DoNotTransfer);
				var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SchedulePeriodically (run, initialDelay, period, unit));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_schedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker']/method[@name='schedulePeriodically' and count(parameter)=4 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit']]"
			[Register ("schedulePeriodically", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;", "GetSchedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler")]
			public virtual unsafe global::IO.Reactivex.Disposables.IDisposable SchedulePeriodically (global::Java.Lang.IRunnable run, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit)
			{
				if (id_schedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_schedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "schedulePeriodically", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (run);
					__args [1] = new JValue (initialDelay);
					__args [2] = new JValue (period);
					__args [3] = new JValue (unit);

					global::IO.Reactivex.Disposables.IDisposable __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_schedulePeriodically_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "schedulePeriodically", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
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
				var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Dispose ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/interface[@name='Disposable']/method[@name='dispose' and count(parameter)=0]"
			[Register ("dispose", "()V", "GetDisposeHandler")]
			public abstract void Dispose ();

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
				var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsDisposed;
			}
#pragma warning restore 0169

			public abstract bool IsDisposed {
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker']/method[@name='isDisposed' and count(parameter)=0]"
				[Register ("isDisposed", "()Z", "GetIsDisposedHandler")] get;
			}

		}

		[global::Android.Runtime.Register ("io/reactivex/Scheduler$Worker", DoNotGenerateAcw=true)]
		internal partial class WorkerInvoker : Worker {

			public WorkerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (WorkerInvoker); }
			}

			static IntPtr id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker']/method[@name='schedule' and count(parameter)=3 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
			[Register ("schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;", "GetSchedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler")]
			public override unsafe global::IO.Reactivex.Disposables.IDisposable Schedule (global::Java.Lang.IRunnable p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
			{
				if (id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_isDisposed;
			public override unsafe bool IsDisposed {
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler.Worker']/method[@name='isDisposed' and count(parameter)=0]"
				[Register ("isDisposed", "()Z", "GetIsDisposedHandler")]
				get {
					if (id_isDisposed == IntPtr.Zero)
						id_isDisposed = JNIEnv.GetMethodID (class_ref, "isDisposed", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisposed);
					} finally {
					}
				}
			}

			static IntPtr id_dispose;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/interface[@name='Disposable']/method[@name='dispose' and count(parameter)=0]"
			[Register ("dispose", "()V", "GetDisposeHandler")]
			public override unsafe void Dispose ()
			{
				if (id_dispose == IntPtr.Zero)
					id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
				} finally {
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/Scheduler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Scheduler); }
		}

		protected Scheduler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']/constructor[@name='Scheduler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Scheduler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Scheduler)) {
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

		static IntPtr id_clockDriftTolerance;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']/method[@name='clockDriftTolerance' and count(parameter)=0]"
		[Register ("clockDriftTolerance", "()J", "")]
		public static unsafe long ClockDriftTolerance ()
		{
			if (id_clockDriftTolerance == IntPtr.Zero)
				id_clockDriftTolerance = JNIEnv.GetStaticMethodID (class_ref, "clockDriftTolerance", "()J");
			try {
				return JNIEnv.CallStaticLongMethod  (class_ref, id_clockDriftTolerance);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateWorker ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']/method[@name='createWorker' and count(parameter)=0]"
		[Register ("createWorker", "()Lio/reactivex/Scheduler$Worker;", "GetCreateWorkerHandler")]
		public abstract global::IO.Reactivex.Scheduler.Worker CreateWorker ();

		static Delegate cb_now_Ljava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetNow_Ljava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_now_Ljava_util_concurrent_TimeUnit_ == null)
				cb_now_Ljava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_Now_Ljava_util_concurrent_TimeUnit_);
			return cb_now_Ljava_util_concurrent_TimeUnit_;
		}

		static long n_Now_Ljava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Now (unit);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_now_Ljava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']/method[@name='now' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.TimeUnit']]"
		[Register ("now", "(Ljava/util/concurrent/TimeUnit;)J", "GetNow_Ljava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe long Now (global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_now_Ljava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_now_Ljava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "now", "(Ljava/util/concurrent/TimeUnit;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (unit);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_now_Ljava_util_concurrent_TimeUnit_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "now", "(Ljava/util/concurrent/TimeUnit;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_scheduleDirect_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetScheduleDirect_Ljava_lang_Runnable_Handler ()
		{
			if (cb_scheduleDirect_Ljava_lang_Runnable_ == null)
				cb_scheduleDirect_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ScheduleDirect_Ljava_lang_Runnable_);
			return cb_scheduleDirect_Ljava_lang_Runnable_;
		}

		static IntPtr n_ScheduleDirect_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_run)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var run = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_run, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ScheduleDirect (run));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_scheduleDirect_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']/method[@name='scheduleDirect' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("scheduleDirect", "(Ljava/lang/Runnable;)Lio/reactivex/disposables/Disposable;", "GetScheduleDirect_Ljava_lang_Runnable_Handler")]
		public virtual unsafe global::IO.Reactivex.Disposables.IDisposable ScheduleDirect (global::Java.Lang.IRunnable run)
		{
			if (id_scheduleDirect_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_scheduleDirect_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "scheduleDirect", "(Ljava/lang/Runnable;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (run);

				global::IO.Reactivex.Disposables.IDisposable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scheduleDirect_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scheduleDirect", "(Ljava/lang/Runnable;)Lio/reactivex/disposables/Disposable;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_ScheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_run, long delay, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var run = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_run, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ScheduleDirect (run, delay, unit));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']/method[@name='scheduleDirect' and count(parameter)=3 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("scheduleDirect", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;", "GetScheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::IO.Reactivex.Disposables.IDisposable ScheduleDirect (global::Java.Lang.IRunnable run, long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_scheduleDirect_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "scheduleDirect", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (run);
				__args [1] = new JValue (delay);
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var run = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_run, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SchedulePeriodicallyDirect (run, initialDelay, period, unit));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_schedulePeriodicallyDirect_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']/method[@name='schedulePeriodicallyDirect' and count(parameter)=4 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']/method[@name='shutdown' and count(parameter)=0]"
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

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/Scheduler", DoNotGenerateAcw=true)]
	internal partial class SchedulerInvoker : Scheduler {

		public SchedulerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SchedulerInvoker); }
		}

		static IntPtr id_createWorker;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Scheduler']/method[@name='createWorker' and count(parameter)=0]"
		[Register ("createWorker", "()Lio/reactivex/Scheduler$Worker;", "GetCreateWorkerHandler")]
		public override unsafe global::IO.Reactivex.Scheduler.Worker CreateWorker ()
		{
			if (id_createWorker == IntPtr.Zero)
				id_createWorker = JNIEnv.GetMethodID (class_ref, "createWorker", "()Lio/reactivex/Scheduler$Worker;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler.Worker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createWorker), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
