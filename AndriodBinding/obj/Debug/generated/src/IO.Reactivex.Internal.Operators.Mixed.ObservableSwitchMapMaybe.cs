using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Mixed {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.mixed']/class[@name='ObservableSwitchMapMaybe']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/mixed/ObservableSwitchMapMaybe", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public sealed partial class ObservableSwitchMapMaybe : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/mixed/ObservableSwitchMapMaybe", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableSwitchMapMaybe); }
		}

		internal ObservableSwitchMapMaybe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_Observable_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.mixed']/class[@name='ObservableSwitchMapMaybe']/constructor[@name='ObservableSwitchMapMaybe' and count(parameter)=3 and parameter[1][@type='io.reactivex.Observable&lt;T&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Lio/reactivex/Observable;Lio/reactivex/functions/Function;Z)V", "")]
		public unsafe ObservableSwitchMapMaybe (global::IO.Reactivex.Observable source, global::IO.Reactivex.Functions.IFunction mapper, bool delayErrors)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (mapper);
				__args [2] = new JValue (delayErrors);
				if (((object) this).GetType () != typeof (ObservableSwitchMapMaybe)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/Observable;Lio/reactivex/functions/Function;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/Observable;Lio/reactivex/functions/Function;Z)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_Observable_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
					id_ctor_Lio_reactivex_Observable_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/Observable;Lio/reactivex/functions/Function;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_Observable_Lio_reactivex_functions_Function_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_Observable_Lio_reactivex_functions_Function_Z, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.mixed']/class[@name='ObservableSwitchMapMaybe']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super R&gt;']]"
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
