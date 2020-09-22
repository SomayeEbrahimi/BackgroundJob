using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Maybe {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeFromFuture']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/maybe/MaybeFromFuture", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class MaybeFromFuture : global::IO.Reactivex.Maybe {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/maybe/MaybeFromFuture", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaybeFromFuture); }
		}

		internal MaybeFromFuture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeFromFuture']/constructor[@name='MaybeFromFuture' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register (".ctor", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe MaybeFromFuture (global::Java.Util.Concurrent.IFuture future, long timeout, global::Java.Util.Concurrent.TimeUnit unit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (future);
				__args [1] = new JValue (timeout);
				__args [2] = new JValue (unit);
				if (((object) this).GetType () != typeof (MaybeFromFuture)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeFromFuture']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super T&gt;']]"
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

	}
}
