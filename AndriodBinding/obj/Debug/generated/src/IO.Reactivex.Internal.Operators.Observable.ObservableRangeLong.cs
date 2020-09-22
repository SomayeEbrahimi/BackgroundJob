using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableRangeLong']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableRangeLong", DoNotGenerateAcw=true)]
	public sealed partial class ObservableRangeLong : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableRangeLong", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableRangeLong); }
		}

		internal ObservableRangeLong (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableRangeLong']/constructor[@name='ObservableRangeLong' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register (".ctor", "(JJ)V", "")]
		public unsafe ObservableRangeLong (long start, long count)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (start);
				__args [1] = new JValue (count);
				if (((object) this).GetType () != typeof (ObservableRangeLong)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JJ)V", __args);
					return;
				}

				if (id_ctor_JJ == IntPtr.Zero)
					id_ctor_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableRangeLong']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super java.lang.Long&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/Observer;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IObserver o)
		{
			if (id_subscribeActual_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

	}
}
