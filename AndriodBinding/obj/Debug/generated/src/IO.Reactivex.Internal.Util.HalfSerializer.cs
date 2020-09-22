using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='HalfSerializer']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/HalfSerializer", DoNotGenerateAcw=true)]
	public sealed partial class HalfSerializer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/HalfSerializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HalfSerializer); }
		}

		internal HalfSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_onComplete_Lio_reactivex_Observer_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='HalfSerializer']/method[@name='onComplete' and count(parameter)=3 and parameter[1][@type='io.reactivex.Observer&lt;?&gt;'] and parameter[2][@type='java.util.concurrent.atomic.AtomicInteger'] and parameter[3][@type='io.reactivex.internal.util.AtomicThrowable']]"
		[Register ("onComplete", "(Lio/reactivex/Observer;Ljava/util/concurrent/atomic/AtomicInteger;Lio/reactivex/internal/util/AtomicThrowable;)V", "")]
		public static unsafe void OnComplete (global::IO.Reactivex.IObserver observer, global::Java.Util.Concurrent.Atomic.AtomicInteger wip, global::IO.Reactivex.Internal.Util.AtomicThrowable error)
		{
			if (id_onComplete_Lio_reactivex_Observer_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_ == IntPtr.Zero)
				id_onComplete_Lio_reactivex_Observer_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_ = JNIEnv.GetStaticMethodID (class_ref, "onComplete", "(Lio/reactivex/Observer;Ljava/util/concurrent/atomic/AtomicInteger;Lio/reactivex/internal/util/AtomicThrowable;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (observer);
				__args [1] = new JValue (wip);
				__args [2] = new JValue (error);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onComplete_Lio_reactivex_Observer_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_, __args);
			} finally {
			}
		}

		static IntPtr id_onError_Lio_reactivex_Observer_Ljava_lang_Throwable_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='HalfSerializer']/method[@name='onError' and count(parameter)=4 and parameter[1][@type='io.reactivex.Observer&lt;?&gt;'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.util.concurrent.atomic.AtomicInteger'] and parameter[4][@type='io.reactivex.internal.util.AtomicThrowable']]"
		[Register ("onError", "(Lio/reactivex/Observer;Ljava/lang/Throwable;Ljava/util/concurrent/atomic/AtomicInteger;Lio/reactivex/internal/util/AtomicThrowable;)V", "")]
		public static unsafe void OnError (global::IO.Reactivex.IObserver observer, global::Java.Lang.Throwable ex, global::Java.Util.Concurrent.Atomic.AtomicInteger wip, global::IO.Reactivex.Internal.Util.AtomicThrowable error)
		{
			if (id_onError_Lio_reactivex_Observer_Ljava_lang_Throwable_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_ == IntPtr.Zero)
				id_onError_Lio_reactivex_Observer_Ljava_lang_Throwable_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_ = JNIEnv.GetStaticMethodID (class_ref, "onError", "(Lio/reactivex/Observer;Ljava/lang/Throwable;Ljava/util/concurrent/atomic/AtomicInteger;Lio/reactivex/internal/util/AtomicThrowable;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (observer);
				__args [1] = new JValue (ex);
				__args [2] = new JValue (wip);
				__args [3] = new JValue (error);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onError_Lio_reactivex_Observer_Ljava_lang_Throwable_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_, __args);
			} finally {
			}
		}

		static IntPtr id_onNext_Lio_reactivex_Observer_Ljava_lang_Object_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='HalfSerializer']/method[@name='onNext' and count(parameter)=4 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;'] and parameter[2][@type='T'] and parameter[3][@type='java.util.concurrent.atomic.AtomicInteger'] and parameter[4][@type='io.reactivex.internal.util.AtomicThrowable']]"
		[Register ("onNext", "(Lio/reactivex/Observer;Ljava/lang/Object;Ljava/util/concurrent/atomic/AtomicInteger;Lio/reactivex/internal/util/AtomicThrowable;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void OnNext (global::IO.Reactivex.IObserver observer, global::Java.Lang.Object value, global::Java.Util.Concurrent.Atomic.AtomicInteger wip, global::IO.Reactivex.Internal.Util.AtomicThrowable error)
		{
			if (id_onNext_Lio_reactivex_Observer_Ljava_lang_Object_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_ == IntPtr.Zero)
				id_onNext_Lio_reactivex_Observer_Ljava_lang_Object_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_ = JNIEnv.GetStaticMethodID (class_ref, "onNext", "(Lio/reactivex/Observer;Ljava/lang/Object;Ljava/util/concurrent/atomic/AtomicInteger;Lio/reactivex/internal/util/AtomicThrowable;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (observer);
				__args [1] = new JValue (native_value);
				__args [2] = new JValue (wip);
				__args [3] = new JValue (error);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onNext_Lio_reactivex_Observer_Ljava_lang_Object_Ljava_util_concurrent_atomic_AtomicInteger_Lio_reactivex_internal_util_AtomicThrowable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
