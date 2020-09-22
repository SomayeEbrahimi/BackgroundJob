using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Single {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleTimeout']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/single/SingleTimeout", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class SingleTimeout : global::IO.Reactivex.Single {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/single/SingleTimeout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleTimeout); }
		}

		internal SingleTimeout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_SingleSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleTimeout']/constructor[@name='SingleTimeout' and count(parameter)=5 and parameter[1][@type='io.reactivex.SingleSource&lt;T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler'] and parameter[5][@type='io.reactivex.SingleSource&lt;? extends T&gt;']]"
		[Register (".ctor", "(Lio/reactivex/SingleSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/SingleSource;)V", "")]
		public unsafe SingleTimeout (global::IO.Reactivex.ISingleSource source, long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, global::IO.Reactivex.ISingleSource other)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source);
				__args [1] = new JValue (timeout);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				__args [4] = new JValue (other);
				if (((object) this).GetType () != typeof (SingleTimeout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/SingleSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/SingleSource;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/SingleSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/SingleSource;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_SingleSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_SingleSource_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_SingleSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/SingleSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/SingleSource;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_SingleSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_SingleSource_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_SingleSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_SingleSource_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleTimeout']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/SingleObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ISingleObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/SingleObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

	}
}
