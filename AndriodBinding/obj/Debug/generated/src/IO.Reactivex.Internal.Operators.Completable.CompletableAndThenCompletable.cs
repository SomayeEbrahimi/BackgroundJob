using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Completable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableAndThenCompletable']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/completable/CompletableAndThenCompletable", DoNotGenerateAcw=true)]
	public sealed partial class CompletableAndThenCompletable : global::IO.Reactivex.Completable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/completable/CompletableAndThenCompletable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompletableAndThenCompletable); }
		}

		internal CompletableAndThenCompletable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableAndThenCompletable']/constructor[@name='CompletableAndThenCompletable' and count(parameter)=2 and parameter[1][@type='io.reactivex.CompletableSource'] and parameter[2][@type='io.reactivex.CompletableSource']]"
		[Register (".ctor", "(Lio/reactivex/CompletableSource;Lio/reactivex/CompletableSource;)V", "")]
		public unsafe CompletableAndThenCompletable (global::IO.Reactivex.ICompletableSource source, global::IO.Reactivex.ICompletableSource next)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (next);
				if (((object) this).GetType () != typeof (CompletableAndThenCompletable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/CompletableSource;Lio/reactivex/CompletableSource;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/CompletableSource;Lio/reactivex/CompletableSource;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/CompletableSource;Lio/reactivex/CompletableSource;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_CompletableSource_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_CompletableSource_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableAndThenCompletable']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
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
