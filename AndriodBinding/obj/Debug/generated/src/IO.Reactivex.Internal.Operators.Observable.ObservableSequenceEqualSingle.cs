using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableSequenceEqualSingle']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableSequenceEqualSingle", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ObservableSequenceEqualSingle : global::IO.Reactivex.Single, global::IO.Reactivex.Internal.Fuseable.IFuseToObservable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableSequenceEqualSingle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableSequenceEqualSingle); }
		}

		internal ObservableSequenceEqualSingle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableSequenceEqualSingle']/constructor[@name='ObservableSequenceEqualSingle' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.functions.BiPredicate&lt;? super T, ? super T&gt;'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiPredicate;I)V", "")]
		public unsafe ObservableSequenceEqualSingle (global::IO.Reactivex.IObservableSource first, global::IO.Reactivex.IObservableSource second, global::IO.Reactivex.Functions.IBiPredicate comparer, int bufferSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (first);
				__args [1] = new JValue (second);
				__args [2] = new JValue (comparer);
				__args [3] = new JValue (bufferSize);
				if (((object) this).GetType () != typeof (ObservableSequenceEqualSingle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiPredicate;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiPredicate;I)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_I == IntPtr.Zero)
					id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiPredicate;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_I, __args);
			} finally {
			}
		}

		static IntPtr id_fuseToObservable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableSequenceEqualSingle']/method[@name='fuseToObservable' and count(parameter)=0]"
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

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableSequenceEqualSingle']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super java.lang.Boolean&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/SingleObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ISingleObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/SingleObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated IO.Reactivex.Internal.Fuseable.IFuseToObservable
		global::IO.Reactivex.Observable global::IO.Reactivex.Internal.Fuseable.IFuseToObservable.FuseToObservable ()
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<IO.Reactivex.Observable>(FuseToObservable ());
		}

	}
}
