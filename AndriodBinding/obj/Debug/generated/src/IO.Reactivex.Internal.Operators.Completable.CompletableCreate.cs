using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Completable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableCreate']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/completable/CompletableCreate", DoNotGenerateAcw=true)]
	public sealed partial class CompletableCreate : global::IO.Reactivex.Completable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/completable/CompletableCreate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompletableCreate); }
		}

		internal CompletableCreate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_CompletableOnSubscribe_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableCreate']/constructor[@name='CompletableCreate' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableOnSubscribe']]"
		[Register (".ctor", "(Lio/reactivex/CompletableOnSubscribe;)V", "")]
		public unsafe CompletableCreate (global::IO.Reactivex.ICompletableOnSubscribe source)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				if (((object) this).GetType () != typeof (CompletableCreate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/CompletableOnSubscribe;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/CompletableOnSubscribe;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_CompletableOnSubscribe_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_CompletableOnSubscribe_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/CompletableOnSubscribe;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_CompletableOnSubscribe_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_CompletableOnSubscribe_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableCreate']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
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
