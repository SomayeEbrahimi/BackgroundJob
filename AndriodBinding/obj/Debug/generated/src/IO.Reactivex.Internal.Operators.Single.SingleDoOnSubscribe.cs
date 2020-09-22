using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Single {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleDoOnSubscribe']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/single/SingleDoOnSubscribe", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class SingleDoOnSubscribe : global::IO.Reactivex.Single {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/single/SingleDoOnSubscribe", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleDoOnSubscribe); }
		}

		internal SingleDoOnSubscribe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleDoOnSubscribe']/constructor[@name='SingleDoOnSubscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.SingleSource&lt;T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register (".ctor", "(Lio/reactivex/SingleSource;Lio/reactivex/functions/Consumer;)V", "")]
		public unsafe SingleDoOnSubscribe (global::IO.Reactivex.ISingleSource source, global::IO.Reactivex.Functions.IConsumer onSubscribe)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (onSubscribe);
				if (((object) this).GetType () != typeof (SingleDoOnSubscribe)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/SingleSource;Lio/reactivex/functions/Consumer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/SingleSource;Lio/reactivex/functions/Consumer;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/SingleSource;Lio/reactivex/functions/Consumer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_functions_Consumer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_functions_Consumer_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleDoOnSubscribe']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
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

	}
}
