using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Completable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletablePeek']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/completable/CompletablePeek", DoNotGenerateAcw=true)]
	public sealed partial class CompletablePeek : global::IO.Reactivex.Completable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/completable/CompletablePeek", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompletablePeek); }
		}

		internal CompletablePeek (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletablePeek']/constructor[@name='CompletablePeek' and count(parameter)=7 and parameter[1][@type='io.reactivex.CompletableSource'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;'] and parameter[4][@type='io.reactivex.functions.Action'] and parameter[5][@type='io.reactivex.functions.Action'] and parameter[6][@type='io.reactivex.functions.Action'] and parameter[7][@type='io.reactivex.functions.Action']]"
		[Register (".ctor", "(Lio/reactivex/CompletableSource;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;)V", "")]
		public unsafe CompletablePeek (global::IO.Reactivex.ICompletableSource source, global::IO.Reactivex.Functions.IConsumer onSubscribe, global::IO.Reactivex.Functions.IConsumer onError, global::IO.Reactivex.Functions.IAction onComplete, global::IO.Reactivex.Functions.IAction onTerminate, global::IO.Reactivex.Functions.IAction onAfterTerminate, global::IO.Reactivex.Functions.IAction onDispose)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (source);
				__args [1] = new JValue (onSubscribe);
				__args [2] = new JValue (onError);
				__args [3] = new JValue (onComplete);
				__args [4] = new JValue (onTerminate);
				__args [5] = new JValue (onAfterTerminate);
				__args [6] = new JValue (onDispose);
				if (((object) this).GetType () != typeof (CompletablePeek)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/CompletableSource;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/CompletableSource;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/CompletableSource;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_CompletableSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.completable']/class[@name='CompletablePeek']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
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
