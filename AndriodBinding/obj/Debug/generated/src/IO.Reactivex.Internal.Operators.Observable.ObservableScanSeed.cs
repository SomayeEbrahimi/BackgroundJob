using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScanSeed']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableScanSeed", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public sealed partial class ObservableScanSeed : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableScanSeed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableScanSeed); }
		}

		internal ObservableScanSeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_ObservableSource_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScanSeed']/constructor[@name='ObservableScanSeed' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;'] and parameter[2][@type='java.util.concurrent.Callable&lt;R&gt;'] and parameter[3][@type='io.reactivex.functions.BiFunction&lt;R, ? super T, R&gt;']]"
		[Register (".ctor", "(Lio/reactivex/ObservableSource;Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)V", "")]
		public unsafe ObservableScanSeed (global::IO.Reactivex.IObservableSource source, global::Java.Util.Concurrent.ICallable seedSupplier, global::IO.Reactivex.Functions.IBiFunction accumulator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (seedSupplier);
				__args [2] = new JValue (accumulator);
				if (((object) this).GetType () != typeof (ObservableScanSeed)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/ObservableSource;Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/ObservableSource;Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_ObservableSource_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_ObservableSource_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/ObservableSource;Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_ObservableSource_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_ObservableSource_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScanSeed']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super R&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/Observer;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IObserver t)
		{
			if (id_subscribeActual_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

		static IntPtr id_source;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='AbstractObservableWithUpstream']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()Lio/reactivex/ObservableSource;", "")]
		public unsafe global::IO.Reactivex.IObservableSource Source ()
		{
			if (id_source == IntPtr.Zero)
				id_source = JNIEnv.GetMethodID (class_ref, "source", "()Lio/reactivex/ObservableSource;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObservableSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_source), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
