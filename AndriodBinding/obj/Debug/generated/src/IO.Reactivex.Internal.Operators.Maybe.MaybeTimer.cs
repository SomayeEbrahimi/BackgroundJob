using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Maybe {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeTimer']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/maybe/MaybeTimer", DoNotGenerateAcw=true)]
	public sealed partial class MaybeTimer : global::IO.Reactivex.Maybe {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/maybe/MaybeTimer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaybeTimer); }
		}

		internal MaybeTimer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeTimer']/constructor[@name='MaybeTimer' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register (".ctor", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V", "")]
		public unsafe MaybeTimer (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				if (((object) this).GetType () != typeof (MaybeTimer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V", __args);
					return;
				}

				if (id_ctor_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
					id_ctor_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeTimer']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super java.lang.Long&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/MaybeObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IMaybeObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_MaybeObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/MaybeObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_MaybeObserver_, __args);
			} finally {
			}
		}

	}
}
