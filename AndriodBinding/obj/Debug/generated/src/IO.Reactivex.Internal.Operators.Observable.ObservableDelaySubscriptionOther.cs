using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableDelaySubscriptionOther']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableDelaySubscriptionOther", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
	public sealed partial class ObservableDelaySubscriptionOther : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableDelaySubscriptionOther", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableDelaySubscriptionOther); }
		}

		internal ObservableDelaySubscriptionOther (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableDelaySubscriptionOther']/constructor[@name='ObservableDelaySubscriptionOther' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;U&gt;']]"
		[Register (".ctor", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)V", "")]
		public unsafe ObservableDelaySubscriptionOther (global::IO.Reactivex.IObservableSource main, global::IO.Reactivex.IObservableSource other)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (main);
				__args [1] = new JValue (other);
				if (((object) this).GetType () != typeof (ObservableDelaySubscriptionOther)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableDelaySubscriptionOther']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
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
