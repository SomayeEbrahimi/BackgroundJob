using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BlockingHelper']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/BlockingHelper", DoNotGenerateAcw=true)]
	public sealed partial class BlockingHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/BlockingHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockingHelper); }
		}

		internal BlockingHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_awaitForComplete_Ljava_util_concurrent_CountDownLatch_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BlockingHelper']/method[@name='awaitForComplete' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.CountDownLatch'] and parameter[2][@type='io.reactivex.disposables.Disposable']]"
		[Register ("awaitForComplete", "(Ljava/util/concurrent/CountDownLatch;Lio/reactivex/disposables/Disposable;)V", "")]
		public static unsafe void AwaitForComplete (global::Java.Util.Concurrent.CountDownLatch latch, global::IO.Reactivex.Disposables.IDisposable subscription)
		{
			if (id_awaitForComplete_Ljava_util_concurrent_CountDownLatch_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_awaitForComplete_Ljava_util_concurrent_CountDownLatch_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetStaticMethodID (class_ref, "awaitForComplete", "(Ljava/util/concurrent/CountDownLatch;Lio/reactivex/disposables/Disposable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (latch);
				__args [1] = new JValue (subscription);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_awaitForComplete_Ljava_util_concurrent_CountDownLatch_Lio_reactivex_disposables_Disposable_, __args);
			} finally {
			}
		}

		static IntPtr id_verifyNonBlocking;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BlockingHelper']/method[@name='verifyNonBlocking' and count(parameter)=0]"
		[Register ("verifyNonBlocking", "()V", "")]
		public static unsafe void VerifyNonBlocking ()
		{
			if (id_verifyNonBlocking == IntPtr.Zero)
				id_verifyNonBlocking = JNIEnv.GetStaticMethodID (class_ref, "verifyNonBlocking", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_verifyNonBlocking);
			} finally {
			}
		}

	}
}
