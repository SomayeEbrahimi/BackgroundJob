using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Single {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleError']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/single/SingleError", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class SingleError : global::IO.Reactivex.Single {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/single/SingleError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleError); }
		}

		internal SingleError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleError']/constructor[@name='SingleError' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends java.lang.Throwable&gt;']]"
		[Register (".ctor", "(Ljava/util/concurrent/Callable;)V", "")]
		public unsafe SingleError (global::Java.Util.Concurrent.ICallable errorSupplier)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorSupplier);
				if (((object) this).GetType () != typeof (SingleError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/Callable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/Callable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/Callable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_Callable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_Callable_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleError']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
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
