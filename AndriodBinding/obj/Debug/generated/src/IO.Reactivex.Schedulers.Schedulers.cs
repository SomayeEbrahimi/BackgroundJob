using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Schedulers']"
	[global::Android.Runtime.Register ("io/reactivex/schedulers/Schedulers", DoNotGenerateAcw=true)]
	public sealed partial class Schedulers : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/schedulers/Schedulers", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Schedulers); }
		}

		internal Schedulers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_computation;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Schedulers']/method[@name='computation' and count(parameter)=0]"
		[Register ("computation", "()Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler Computation ()
		{
			if (id_computation == IntPtr.Zero)
				id_computation = JNIEnv.GetStaticMethodID (class_ref, "computation", "()Lio/reactivex/Scheduler;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_computation), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_from_Ljava_util_concurrent_Executor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Schedulers']/method[@name='from' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
		[Register ("from", "(Ljava/util/concurrent/Executor;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler From (global::Java.Util.Concurrent.IExecutor executor)
		{
			if (id_from_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
				id_from_Ljava_util_concurrent_Executor_ = JNIEnv.GetStaticMethodID (class_ref, "from", "(Ljava/util/concurrent/Executor;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (executor);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_from_Ljava_util_concurrent_Executor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_from_Ljava_util_concurrent_Executor_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Schedulers']/method[@name='from' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='boolean']]"
		[Register ("from", "(Ljava/util/concurrent/Executor;Z)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler From (global::Java.Util.Concurrent.IExecutor executor, bool interruptibleWorker)
		{
			if (id_from_Ljava_util_concurrent_Executor_Z == IntPtr.Zero)
				id_from_Ljava_util_concurrent_Executor_Z = JNIEnv.GetStaticMethodID (class_ref, "from", "(Ljava/util/concurrent/Executor;Z)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (executor);
				__args [1] = new JValue (interruptibleWorker);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_from_Ljava_util_concurrent_Executor_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_io;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Schedulers']/method[@name='io' and count(parameter)=0]"
		[Register ("io", "()Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler Io ()
		{
			if (id_io == IntPtr.Zero)
				id_io = JNIEnv.GetStaticMethodID (class_ref, "io", "()Lio/reactivex/Scheduler;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_io), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Schedulers']/method[@name='newThread' and count(parameter)=0]"
		[Register ("newThread", "()Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler NewThread ()
		{
			if (id_newThread == IntPtr.Zero)
				id_newThread = JNIEnv.GetStaticMethodID (class_ref, "newThread", "()Lio/reactivex/Scheduler;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newThread), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Schedulers']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "")]
		public static unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetStaticMethodID (class_ref, "shutdown", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shutdown);
			} finally {
			}
		}

		static IntPtr id_single;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Schedulers']/method[@name='single' and count(parameter)=0]"
		[Register ("single", "()Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler Single ()
		{
			if (id_single == IntPtr.Zero)
				id_single = JNIEnv.GetStaticMethodID (class_ref, "single", "()Lio/reactivex/Scheduler;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_single), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Schedulers']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public static unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetStaticMethodID (class_ref, "start", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start);
			} finally {
			}
		}

		static IntPtr id_trampoline;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Schedulers']/method[@name='trampoline' and count(parameter)=0]"
		[Register ("trampoline", "()Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler Trampoline ()
		{
			if (id_trampoline == IntPtr.Zero)
				id_trampoline = JNIEnv.GetStaticMethodID (class_ref, "trampoline", "()Lio/reactivex/Scheduler;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_trampoline), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
