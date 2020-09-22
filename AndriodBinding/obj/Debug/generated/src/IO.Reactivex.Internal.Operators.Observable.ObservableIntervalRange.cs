using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableIntervalRange']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableIntervalRange", DoNotGenerateAcw=true)]
	public sealed partial class ObservableIntervalRange : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableIntervalRange", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableIntervalRange); }
		}

		internal ObservableIntervalRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JJJJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableIntervalRange']/constructor[@name='ObservableIntervalRange' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.util.concurrent.TimeUnit'] and parameter[6][@type='io.reactivex.Scheduler']]"
		[Register (".ctor", "(JJJJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V", "")]
		public unsafe ObservableIntervalRange (long start, long end, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (start);
				__args [1] = new JValue (end);
				__args [2] = new JValue (initialDelay);
				__args [3] = new JValue (period);
				__args [4] = new JValue (unit);
				__args [5] = new JValue (scheduler);
				if (((object) this).GetType () != typeof (ObservableIntervalRange)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JJJJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JJJJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V", __args);
					return;
				}

				if (id_ctor_JJJJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
					id_ctor_JJJJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJJJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJJJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JJJJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableIntervalRange']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super java.lang.Long&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/Observer;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

	}
}
