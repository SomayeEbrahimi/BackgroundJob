using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Maybe {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybePeek']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/maybe/MaybePeek", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class MaybePeek : global::IO.Reactivex.Maybe {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/maybe/MaybePeek", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaybePeek); }
		}

		internal MaybePeek (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybePeek']/constructor[@name='MaybePeek' and count(parameter)=7 and parameter[1][@type='io.reactivex.MaybeSource&lt;T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[4][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;'] and parameter[5][@type='io.reactivex.functions.Action'] and parameter[6][@type='io.reactivex.functions.Action'] and parameter[7][@type='io.reactivex.functions.Action']]"
		[Register (".ctor", "(Lio/reactivex/MaybeSource;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;)V", "")]
		public unsafe MaybePeek (global::IO.Reactivex.IMaybeSource source, global::IO.Reactivex.Functions.IConsumer onSubscribeCall, global::IO.Reactivex.Functions.IConsumer onSuccessCall, global::IO.Reactivex.Functions.IConsumer onErrorCall, global::IO.Reactivex.Functions.IAction onCompleteCall, global::IO.Reactivex.Functions.IAction onAfterTerminate, global::IO.Reactivex.Functions.IAction onDispose)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (source);
				__args [1] = new JValue (onSubscribeCall);
				__args [2] = new JValue (onSuccessCall);
				__args [3] = new JValue (onErrorCall);
				__args [4] = new JValue (onCompleteCall);
				__args [5] = new JValue (onAfterTerminate);
				__args [6] = new JValue (onDispose);
				if (((object) this).GetType () != typeof (MaybePeek)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/MaybeSource;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/MaybeSource;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/MaybeSource;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;Lio/reactivex/functions/Action;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_Lio_reactivex_functions_Action_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybePeek']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/MaybeObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IMaybeObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_MaybeObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/MaybeObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_MaybeObserver_, __args);
			} finally {
			}
		}

		static IntPtr id_source;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='AbstractMaybeWithUpstream']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()Lio/reactivex/MaybeSource;", "")]
		public unsafe global::IO.Reactivex.IMaybeSource Source ()
		{
			if (id_source == IntPtr.Zero)
				id_source = JNIEnv.GetMethodID (class_ref, "source", "()Lio/reactivex/MaybeSource;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_source), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
