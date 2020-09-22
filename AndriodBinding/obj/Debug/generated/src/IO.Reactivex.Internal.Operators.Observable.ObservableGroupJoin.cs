using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupJoin']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableGroupJoin", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"TLeft", "TRight", "TLeftEnd", "TRightEnd", "R"})]
	public sealed partial class ObservableGroupJoin : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableGroupJoin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableGroupJoin); }
		}

		internal ObservableGroupJoin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupJoin']/constructor[@name='ObservableGroupJoin' and count(parameter)=5 and parameter[1][@type='io.reactivex.ObservableSource&lt;TLeft&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends TRight&gt;'] and parameter[3][@type='io.reactivex.functions.Function&lt;? super TLeft, ? extends io.reactivex.ObservableSource&lt;TLeftEnd&gt;&gt;'] and parameter[4][@type='io.reactivex.functions.Function&lt;? super TRight, ? extends io.reactivex.ObservableSource&lt;TRightEnd&gt;&gt;'] and parameter[5][@type='io.reactivex.functions.BiFunction&lt;? super TLeft, ? super io.reactivex.Observable&lt;TRight&gt;, ? extends R&gt;']]"
		[Register (".ctor", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)V", "")]
		public unsafe ObservableGroupJoin (global::IO.Reactivex.IObservableSource source, global::IO.Reactivex.IObservableSource other, global::IO.Reactivex.Functions.IFunction leftEnd, global::IO.Reactivex.Functions.IFunction rightEnd, global::IO.Reactivex.Functions.IBiFunction resultSelector)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source);
				__args [1] = new JValue (other);
				__args [2] = new JValue (leftEnd);
				__args [3] = new JValue (rightEnd);
				__args [4] = new JValue (resultSelector);
				if (((object) this).GetType () != typeof (ObservableGroupJoin)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupJoin']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super R&gt;']]"
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
