using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableRefCount']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableRefCount", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ObservableRefCount : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableRefCount", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableRefCount); }
		}

		internal ObservableRefCount (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_observables_ConnectableObservable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableRefCount']/constructor[@name='ObservableRefCount' and count(parameter)=1 and parameter[1][@type='io.reactivex.observables.ConnectableObservable&lt;T&gt;']]"
		[Register (".ctor", "(Lio/reactivex/observables/ConnectableObservable;)V", "")]
		public unsafe ObservableRefCount (global::IO.Reactivex.Observables.ConnectableObservable source)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				if (((object) this).GetType () != typeof (ObservableRefCount)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/observables/ConnectableObservable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/observables/ConnectableObservable;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_observables_ConnectableObservable_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_observables_ConnectableObservable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/observables/ConnectableObservable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_observables_ConnectableObservable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_observables_ConnectableObservable_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lio_reactivex_observables_ConnectableObservable_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableRefCount']/constructor[@name='ObservableRefCount' and count(parameter)=5 and parameter[1][@type='io.reactivex.observables.ConnectableObservable&lt;T&gt;'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit'] and parameter[5][@type='io.reactivex.Scheduler']]"
		[Register (".ctor", "(Lio/reactivex/observables/ConnectableObservable;IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V", "")]
		public unsafe ObservableRefCount (global::IO.Reactivex.Observables.ConnectableObservable source, int n, long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source);
				__args [1] = new JValue (n);
				__args [2] = new JValue (timeout);
				__args [3] = new JValue (unit);
				__args [4] = new JValue (scheduler);
				if (((object) this).GetType () != typeof (ObservableRefCount)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/observables/ConnectableObservable;IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/observables/ConnectableObservable;IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_observables_ConnectableObservable_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_observables_ConnectableObservable_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/observables/ConnectableObservable;IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_observables_ConnectableObservable_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_observables_ConnectableObservable_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableRefCount']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
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
