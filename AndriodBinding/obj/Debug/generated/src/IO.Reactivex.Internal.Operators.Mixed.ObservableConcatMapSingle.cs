using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Mixed {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.mixed']/class[@name='ObservableConcatMapSingle']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/mixed/ObservableConcatMapSingle", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public sealed partial class ObservableConcatMapSingle : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/mixed/ObservableConcatMapSingle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableConcatMapSingle); }
		}

		internal ObservableConcatMapSingle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_Observable_Lio_reactivex_functions_Function_Lio_reactivex_internal_util_ErrorMode_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.mixed']/class[@name='ObservableConcatMapSingle']/constructor[@name='ObservableConcatMapSingle' and count(parameter)=4 and parameter[1][@type='io.reactivex.Observable&lt;T&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;'] and parameter[3][@type='io.reactivex.internal.util.ErrorMode'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lio/reactivex/Observable;Lio/reactivex/functions/Function;Lio/reactivex/internal/util/ErrorMode;I)V", "")]
		public unsafe ObservableConcatMapSingle (global::IO.Reactivex.Observable source, global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Internal.Util.ErrorMode errorMode, int prefetch)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source);
				__args [1] = new JValue (mapper);
				__args [2] = new JValue (errorMode);
				__args [3] = new JValue (prefetch);
				if (((object) this).GetType () != typeof (ObservableConcatMapSingle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/Observable;Lio/reactivex/functions/Function;Lio/reactivex/internal/util/ErrorMode;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/Observable;Lio/reactivex/functions/Function;Lio/reactivex/internal/util/ErrorMode;I)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_Observable_Lio_reactivex_functions_Function_Lio_reactivex_internal_util_ErrorMode_I == IntPtr.Zero)
					id_ctor_Lio_reactivex_Observable_Lio_reactivex_functions_Function_Lio_reactivex_internal_util_ErrorMode_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/Observable;Lio/reactivex/functions/Function;Lio/reactivex/internal/util/ErrorMode;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_Observable_Lio_reactivex_functions_Function_Lio_reactivex_internal_util_ErrorMode_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_Observable_Lio_reactivex_functions_Function_Lio_reactivex_internal_util_ErrorMode_I, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.mixed']/class[@name='ObservableConcatMapSingle']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super R&gt;']]"
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
