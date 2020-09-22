using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler']"
	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/ExecutorScheduler", DoNotGenerateAcw=true)]
	public sealed partial class ExecutorScheduler : global::IO.Reactivex.Scheduler {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker']"
		[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/ExecutorScheduler$ExecutorWorker", DoNotGenerateAcw=true)]
		public sealed partial class ExecutorWorker : global::IO.Reactivex.Scheduler.Worker, global::Java.Lang.IRunnable {

			// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker.BooleanRunnable']"
			[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/ExecutorScheduler$ExecutorWorker$BooleanRunnable", DoNotGenerateAcw=true)]
			public sealed partial class BooleanRunnable : global::Java.Util.Concurrent.Atomic.AtomicBoolean, global::IO.Reactivex.Disposables.IDisposable, global::Java.Lang.IRunnable {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("io/reactivex/internal/schedulers/ExecutorScheduler$ExecutorWorker$BooleanRunnable", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (BooleanRunnable); }
				}

				internal BooleanRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_isDisposed;
				public unsafe bool IsDisposed {
					// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker.BooleanRunnable']/method[@name='isDisposed' and count(parameter)=0]"
					[Register ("isDisposed", "()Z", "")]
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
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker.BooleanRunnable']/method[@name='dispose' and count(parameter)=0]"
				[Register ("dispose", "()V", "")]
				public unsafe void Dispose ()
				{
					if (id_dispose == IntPtr.Zero)
						id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
					try {
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
					} finally {
					}
				}

				static IntPtr id_run;
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker.BooleanRunnable']/method[@name='run' and count(parameter)=0]"
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

			// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker.InterruptibleRunnable']"
			[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/ExecutorScheduler$ExecutorWorker$InterruptibleRunnable", DoNotGenerateAcw=true)]
			public sealed partial class InterruptibleRunnable : global::Java.Util.Concurrent.Atomic.AtomicInteger, global::IO.Reactivex.Disposables.IDisposable, global::Java.Lang.IRunnable {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("io/reactivex/internal/schedulers/ExecutorScheduler$ExecutorWorker$InterruptibleRunnable", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (InterruptibleRunnable); }
				}

				internal InterruptibleRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_isDisposed;
				public unsafe bool IsDisposed {
					// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker.InterruptibleRunnable']/method[@name='isDisposed' and count(parameter)=0]"
					[Register ("isDisposed", "()Z", "")]
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
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker.InterruptibleRunnable']/method[@name='dispose' and count(parameter)=0]"
				[Register ("dispose", "()V", "")]
				public unsafe void Dispose ()
				{
					if (id_dispose == IntPtr.Zero)
						id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
					try {
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
					} finally {
					}
				}

				static IntPtr id_run;
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker.InterruptibleRunnable']/method[@name='run' and count(parameter)=0]"
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

			// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker.SequentialDispose']"
			[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/ExecutorScheduler$ExecutorWorker$SequentialDispose", DoNotGenerateAcw=true)]
			public sealed partial class SequentialDispose : global::Java.Lang.Object, global::Java.Lang.IRunnable {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("io/reactivex/internal/schedulers/ExecutorScheduler$ExecutorWorker$SequentialDispose", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (SequentialDispose); }
				}

				internal SequentialDispose (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_run;
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker.SequentialDispose']/method[@name='run' and count(parameter)=0]"
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

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/reactivex/internal/schedulers/ExecutorScheduler$ExecutorWorker", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExecutorWorker); }
			}

			internal ExecutorWorker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_concurrent_Executor_Z;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker']/constructor[@name='ExecutorScheduler.ExecutorWorker' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Ljava/util/concurrent/Executor;Z)V", "")]
			public unsafe ExecutorWorker (global::Java.Util.Concurrent.IExecutor executor, bool interruptibleWorker)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (executor);
					__args [1] = new JValue (interruptibleWorker);
					if (((object) this).GetType () != typeof (ExecutorWorker)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/Executor;Z)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/Executor;Z)V", __args);
						return;
					}

					if (id_ctor_Ljava_util_concurrent_Executor_Z == IntPtr.Zero)
						id_ctor_Ljava_util_concurrent_Executor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/Executor;Z)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_Executor_Z, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_Executor_Z, __args);
				} finally {
				}
			}

			static IntPtr id_isDisposed;
			public override unsafe bool IsDisposed {
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker']/method[@name='isDisposed' and count(parameter)=0]"
				[Register ("isDisposed", "()Z", "")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker']/method[@name='dispose' and count(parameter)=0]"
			[Register ("dispose", "()V", "")]
			public override unsafe void Dispose ()
			{
				if (id_dispose == IntPtr.Zero)
					id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
				} finally {
				}
			}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker']/method[@name='run' and count(parameter)=0]"
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

			static IntPtr id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler.ExecutorWorker']/method[@name='schedule' and count(parameter)=3 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
			[Register ("schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;", "")]
			public override unsafe global::IO.Reactivex.Disposables.IDisposable Schedule (global::Java.Lang.IRunnable run, long delay, global::Java.Util.Concurrent.TimeUnit unit)
			{
				if (id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/disposables/Disposable;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (run);
					__args [1] = new JValue (delay);
					__args [2] = new JValue (unit);
					global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/schedulers/ExecutorScheduler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExecutorScheduler); }
		}

		internal ExecutorScheduler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_Executor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler']/constructor[@name='ExecutorScheduler' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/util/concurrent/Executor;Z)V", "")]
		public unsafe ExecutorScheduler (global::Java.Util.Concurrent.IExecutor executor, bool interruptibleWorker)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (executor);
				__args [1] = new JValue (interruptibleWorker);
				if (((object) this).GetType () != typeof (ExecutorScheduler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/Executor;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/Executor;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_Executor_Z == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_Executor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/Executor;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_Executor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_Executor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_createWorker;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ExecutorScheduler']/method[@name='createWorker' and count(parameter)=0]"
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

	}
}
