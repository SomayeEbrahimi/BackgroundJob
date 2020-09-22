using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Completable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableDelay']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/completable/CompletableDelay", DoNotGenerateAcw=true)]
	public sealed partial class CompletableDelay : global::IO.Reactivex.Completable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/completable/CompletableDelay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompletableDelay); }
		}

		internal CompletableDelay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_CompletableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableDelay']/constructor[@name='CompletableDelay' and count(parameter)=5 and parameter[1][@type='io.reactivex.CompletableSource'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Lio/reactivex/CompletableSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)V", "")]
		public unsafe CompletableDelay (global::IO.Reactivex.ICompletableSource source, long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool delayError)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source);
				__args [1] = new JValue (delay);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				__args [4] = new JValue (delayError);
				if (((object) this).GetType () != typeof (CompletableDelay)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/CompletableSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/CompletableSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_CompletableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z == IntPtr.Zero)
					id_ctor_Lio_reactivex_CompletableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/CompletableSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_CompletableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_CompletableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableDelay']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
		[Register ("subscribeActual", "(Lio/reactivex/CompletableObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ICompletableObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_CompletableObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_CompletableObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/CompletableObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_CompletableObserver_, __args);
			} finally {
			}
		}

	}
}
