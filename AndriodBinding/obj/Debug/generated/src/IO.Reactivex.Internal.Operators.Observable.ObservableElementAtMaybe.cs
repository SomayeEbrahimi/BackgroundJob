using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableElementAtMaybe']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableElementAtMaybe", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ObservableElementAtMaybe : global::IO.Reactivex.Maybe, global::IO.Reactivex.Internal.Fuseable.IFuseToObservable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableElementAtMaybe", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableElementAtMaybe); }
		}

		internal ObservableElementAtMaybe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_ObservableSource_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableElementAtMaybe']/constructor[@name='ObservableElementAtMaybe' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Lio/reactivex/ObservableSource;J)V", "")]
		public unsafe ObservableElementAtMaybe (global::IO.Reactivex.IObservableSource source, long index)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (index);
				if (((object) this).GetType () != typeof (ObservableElementAtMaybe)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/ObservableSource;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/ObservableSource;J)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_ObservableSource_J == IntPtr.Zero)
					id_ctor_Lio_reactivex_ObservableSource_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/ObservableSource;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_ObservableSource_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_ObservableSource_J, __args);
			} finally {
			}
		}

		static IntPtr id_fuseToObservable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableElementAtMaybe']/method[@name='fuseToObservable' and count(parameter)=0]"
		[Register ("fuseToObservable", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable FuseToObservable ()
		{
			if (id_fuseToObservable == IntPtr.Zero)
				id_fuseToObservable = JNIEnv.GetMethodID (class_ref, "fuseToObservable", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fuseToObservable), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableElementAtMaybe']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/MaybeObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IMaybeObserver t)
		{
			if (id_subscribeActual_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_MaybeObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/MaybeObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_MaybeObserver_, __args);
			} finally {
			}
		}

	}
}
