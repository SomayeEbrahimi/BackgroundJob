using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='TrampolineScheduler']"
	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/TrampolineScheduler", DoNotGenerateAcw=true)]
	public sealed partial class TrampolineScheduler : global::IO.Reactivex.Scheduler {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/schedulers/TrampolineScheduler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrampolineScheduler); }
		}

		internal TrampolineScheduler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createWorker;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='TrampolineScheduler']/method[@name='createWorker' and count(parameter)=0]"
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

		static IntPtr id_instance;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='TrampolineScheduler']/method[@name='instance' and count(parameter)=0]"
		[Register ("instance", "()Lio/reactivex/internal/schedulers/TrampolineScheduler;", "")]
		public static unsafe global::IO.Reactivex.Internal.Schedulers.TrampolineScheduler Instance ()
		{
			if (id_instance == IntPtr.Zero)
				id_instance = JNIEnv.GetStaticMethodID (class_ref, "instance", "()Lio/reactivex/internal/schedulers/TrampolineScheduler;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Schedulers.TrampolineScheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_instance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
