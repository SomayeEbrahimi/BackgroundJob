using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Completable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableUsing']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/completable/CompletableUsing", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public sealed partial class CompletableUsing : global::IO.Reactivex.Completable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/completable/CompletableUsing", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompletableUsing); }
		}

		internal CompletableUsing (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableUsing']/constructor[@name='CompletableUsing' and count(parameter)=4 and parameter[1][@type='java.util.concurrent.Callable&lt;R&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super R, ? extends io.reactivex.CompletableSource&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super R&gt;'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)V", "")]
		public unsafe CompletableUsing (global::Java.Util.Concurrent.ICallable resourceSupplier, global::IO.Reactivex.Functions.IFunction completableFunction, global::IO.Reactivex.Functions.IConsumer disposer, bool eager)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (resourceSupplier);
				__args [1] = new JValue (completableFunction);
				__args [2] = new JValue (disposer);
				__args [3] = new JValue (eager);
				if (((object) this).GetType () != typeof (CompletableUsing)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletableUsing']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
		[Register ("subscribeActual", "(Lio/reactivex/CompletableObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ICompletableObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_CompletableObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_CompletableObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/CompletableObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_CompletableObserver_, __args);
			} finally {
			}
		}

	}
}
