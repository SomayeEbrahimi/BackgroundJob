using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='QueueDrainHelper']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/QueueDrainHelper", DoNotGenerateAcw=true)]
	public sealed partial class QueueDrainHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/QueueDrainHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueueDrainHelper); }
		}

		internal QueueDrainHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkTerminated_ZZLio_reactivex_Observer_ZLio_reactivex_internal_fuseable_SimpleQueue_Lio_reactivex_disposables_Disposable_Lio_reactivex_internal_util_ObservableQueueDrain_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='QueueDrainHelper']/method[@name='checkTerminated' and count(parameter)=7 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='io.reactivex.Observer&lt;?&gt;'] and parameter[4][@type='boolean'] and parameter[5][@type='io.reactivex.internal.fuseable.SimpleQueue&lt;?&gt;'] and parameter[6][@type='io.reactivex.disposables.Disposable'] and parameter[7][@type='io.reactivex.internal.util.ObservableQueueDrain&lt;T, U&gt;']]"
		[Register ("checkTerminated", "(ZZLio/reactivex/Observer;ZLio/reactivex/internal/fuseable/SimpleQueue;Lio/reactivex/disposables/Disposable;Lio/reactivex/internal/util/ObservableQueueDrain;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe bool CheckTerminated (bool d, bool empty, global::IO.Reactivex.IObserver observer, bool delayError, global::IO.Reactivex.Internal.Fuseable.ISimpleQueue q, global::IO.Reactivex.Disposables.IDisposable disposable, global::IO.Reactivex.Internal.Util.IObservableQueueDrain qd)
		{
			if (id_checkTerminated_ZZLio_reactivex_Observer_ZLio_reactivex_internal_fuseable_SimpleQueue_Lio_reactivex_disposables_Disposable_Lio_reactivex_internal_util_ObservableQueueDrain_ == IntPtr.Zero)
				id_checkTerminated_ZZLio_reactivex_Observer_ZLio_reactivex_internal_fuseable_SimpleQueue_Lio_reactivex_disposables_Disposable_Lio_reactivex_internal_util_ObservableQueueDrain_ = JNIEnv.GetStaticMethodID (class_ref, "checkTerminated", "(ZZLio/reactivex/Observer;ZLio/reactivex/internal/fuseable/SimpleQueue;Lio/reactivex/disposables/Disposable;Lio/reactivex/internal/util/ObservableQueueDrain;)Z");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (d);
				__args [1] = new JValue (empty);
				__args [2] = new JValue (observer);
				__args [3] = new JValue (delayError);
				__args [4] = new JValue (q);
				__args [5] = new JValue (disposable);
				__args [6] = new JValue (qd);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkTerminated_ZZLio_reactivex_Observer_ZLio_reactivex_internal_fuseable_SimpleQueue_Lio_reactivex_disposables_Disposable_Lio_reactivex_internal_util_ObservableQueueDrain_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createQueue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='QueueDrainHelper']/method[@name='createQueue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createQueue", "(I)Lio/reactivex/internal/fuseable/SimpleQueue;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Internal.Fuseable.ISimpleQueue CreateQueue (int capacityHint)
		{
			if (id_createQueue_I == IntPtr.Zero)
				id_createQueue_I = JNIEnv.GetStaticMethodID (class_ref, "createQueue", "(I)Lio/reactivex/internal/fuseable/SimpleQueue;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (capacityHint);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.ISimpleQueue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createQueue_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_drainLoop_Lio_reactivex_internal_fuseable_SimplePlainQueue_Lio_reactivex_Observer_ZLio_reactivex_disposables_Disposable_Lio_reactivex_internal_util_ObservableQueueDrain_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='QueueDrainHelper']/method[@name='drainLoop' and count(parameter)=5 and parameter[1][@type='io.reactivex.internal.fuseable.SimplePlainQueue&lt;T&gt;'] and parameter[2][@type='io.reactivex.Observer&lt;? super U&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='io.reactivex.disposables.Disposable'] and parameter[5][@type='io.reactivex.internal.util.ObservableQueueDrain&lt;T, U&gt;']]"
		[Register ("drainLoop", "(Lio/reactivex/internal/fuseable/SimplePlainQueue;Lio/reactivex/Observer;ZLio/reactivex/disposables/Disposable;Lio/reactivex/internal/util/ObservableQueueDrain;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe void DrainLoop (global::IO.Reactivex.Internal.Fuseable.ISimplePlainQueue q, global::IO.Reactivex.IObserver a, bool delayError, global::IO.Reactivex.Disposables.IDisposable dispose, global::IO.Reactivex.Internal.Util.IObservableQueueDrain qd)
		{
			if (id_drainLoop_Lio_reactivex_internal_fuseable_SimplePlainQueue_Lio_reactivex_Observer_ZLio_reactivex_disposables_Disposable_Lio_reactivex_internal_util_ObservableQueueDrain_ == IntPtr.Zero)
				id_drainLoop_Lio_reactivex_internal_fuseable_SimplePlainQueue_Lio_reactivex_Observer_ZLio_reactivex_disposables_Disposable_Lio_reactivex_internal_util_ObservableQueueDrain_ = JNIEnv.GetStaticMethodID (class_ref, "drainLoop", "(Lio/reactivex/internal/fuseable/SimplePlainQueue;Lio/reactivex/Observer;ZLio/reactivex/disposables/Disposable;Lio/reactivex/internal/util/ObservableQueueDrain;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (q);
				__args [1] = new JValue (a);
				__args [2] = new JValue (delayError);
				__args [3] = new JValue (dispose);
				__args [4] = new JValue (qd);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drainLoop_Lio_reactivex_internal_fuseable_SimplePlainQueue_Lio_reactivex_Observer_ZLio_reactivex_disposables_Disposable_Lio_reactivex_internal_util_ObservableQueueDrain_, __args);
			} finally {
			}
		}

	}
}
