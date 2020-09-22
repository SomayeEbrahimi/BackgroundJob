using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableCreate']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableCreate", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ObservableCreate : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableCreate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableCreate); }
		}

		internal ObservableCreate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_ObservableOnSubscribe_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableCreate']/constructor[@name='ObservableCreate' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableOnSubscribe&lt;T&gt;']]"
		[Register (".ctor", "(Lio/reactivex/ObservableOnSubscribe;)V", "")]
		public unsafe ObservableCreate (global::IO.Reactivex.IObservableOnSubscribe source)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				if (((object) this).GetType () != typeof (ObservableCreate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/ObservableOnSubscribe;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/ObservableOnSubscribe;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_ObservableOnSubscribe_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_ObservableOnSubscribe_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/ObservableOnSubscribe;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_ObservableOnSubscribe_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_ObservableOnSubscribe_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableCreate']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
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
