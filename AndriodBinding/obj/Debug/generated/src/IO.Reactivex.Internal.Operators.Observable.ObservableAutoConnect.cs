using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableAutoConnect']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableAutoConnect", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ObservableAutoConnect : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableAutoConnect", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableAutoConnect); }
		}

		internal ObservableAutoConnect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_observables_ConnectableObservable_ILio_reactivex_functions_Consumer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableAutoConnect']/constructor[@name='ObservableAutoConnect' and count(parameter)=3 and parameter[1][@type='io.reactivex.observables.ConnectableObservable&lt;? extends T&gt;'] and parameter[2][@type='int'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register (".ctor", "(Lio/reactivex/observables/ConnectableObservable;ILio/reactivex/functions/Consumer;)V", "")]
		public unsafe ObservableAutoConnect (global::IO.Reactivex.Observables.ConnectableObservable source, int numberOfObservers, global::IO.Reactivex.Functions.IConsumer connection)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (numberOfObservers);
				__args [2] = new JValue (connection);
				if (((object) this).GetType () != typeof (ObservableAutoConnect)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/observables/ConnectableObservable;ILio/reactivex/functions/Consumer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/observables/ConnectableObservable;ILio/reactivex/functions/Consumer;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_observables_ConnectableObservable_ILio_reactivex_functions_Consumer_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_observables_ConnectableObservable_ILio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/observables/ConnectableObservable;ILio/reactivex/functions/Consumer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_observables_ConnectableObservable_ILio_reactivex_functions_Consumer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_observables_ConnectableObservable_ILio_reactivex_functions_Consumer_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableAutoConnect']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/Observer;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IObserver child)
		{
			if (id_subscribeActual_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (child);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

	}
}
