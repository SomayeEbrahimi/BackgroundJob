using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='SchedulerPoolFactory']"
	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/SchedulerPoolFactory", DoNotGenerateAcw=true)]
	public sealed partial class SchedulerPoolFactory : global::Java.Lang.Object {


		static IntPtr PURGE_ENABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='SchedulerPoolFactory']/field[@name='PURGE_ENABLED']"
		[Register ("PURGE_ENABLED")]
		public static bool PurgeEnabled {
			get {
				if (PURGE_ENABLED_jfieldId == IntPtr.Zero)
					PURGE_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PURGE_ENABLED", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, PURGE_ENABLED_jfieldId);
			}
		}

		static IntPtr PURGE_PERIOD_SECONDS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='SchedulerPoolFactory']/field[@name='PURGE_PERIOD_SECONDS']"
		[Register ("PURGE_PERIOD_SECONDS")]
		public static int PurgePeriodSeconds {
			get {
				if (PURGE_PERIOD_SECONDS_jfieldId == IntPtr.Zero)
					PURGE_PERIOD_SECONDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PURGE_PERIOD_SECONDS", "I");
				return JNIEnv.GetStaticIntField (class_ref, PURGE_PERIOD_SECONDS_jfieldId);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/schedulers/SchedulerPoolFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SchedulerPoolFactory); }
		}

		internal SchedulerPoolFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_create_Ljava_util_concurrent_ThreadFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='SchedulerPoolFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
		[Register ("create", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IScheduledExecutorService Create (global::Java.Util.Concurrent.IThreadFactory factory)
		{
			if (id_create_Ljava_util_concurrent_ThreadFactory_ == IntPtr.Zero)
				id_create_Ljava_util_concurrent_ThreadFactory_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (factory);
				global::Java.Util.Concurrent.IScheduledExecutorService __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledExecutorService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_util_concurrent_ThreadFactory_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='SchedulerPoolFactory']/method[@name='shutdown' and count(parameter)=0]"
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

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='SchedulerPoolFactory']/method[@name='start' and count(parameter)=0]"
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

	}
}
