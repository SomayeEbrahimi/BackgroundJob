using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Completable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableDisposeOn']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/completable/CompletableDisposeOn", DoNotGenerateAcw=true)]
	public sealed partial class CompletableDisposeOn : global::IO.Reactivex.Completable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/completable/CompletableDisposeOn", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompletableDisposeOn); }
		}

		internal CompletableDisposeOn (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableDisposeOn']/constructor[@name='CompletableDisposeOn' and count(parameter)=2 and parameter[1][@type='io.reactivex.CompletableSource'] and parameter[2][@type='io.reactivex.Scheduler']]"
		[Register (".ctor", "(Lio/reactivex/CompletableSource;Lio/reactivex/Scheduler;)V", "")]
		public unsafe CompletableDisposeOn (global::IO.Reactivex.ICompletableSource source, global::IO.Reactivex.Scheduler scheduler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (scheduler);
				if (((object) this).GetType () != typeof (CompletableDisposeOn)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/CompletableSource;Lio/reactivex/Scheduler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/CompletableSource;Lio/reactivex/Scheduler;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_Scheduler_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/CompletableSource;Lio/reactivex/Scheduler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_Scheduler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_Scheduler_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableDisposeOn']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
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
