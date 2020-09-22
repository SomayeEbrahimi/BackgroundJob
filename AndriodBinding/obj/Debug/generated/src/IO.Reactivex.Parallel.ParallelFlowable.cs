using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Parallel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']"
	[global::Android.Runtime.Register ("io/reactivex/parallel/ParallelFlowable", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class ParallelFlowable : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/parallel/ParallelFlowable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParallelFlowable); }
		}

		protected ParallelFlowable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/constructor[@name='ParallelFlowable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ParallelFlowable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ParallelFlowable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_as_Lio_reactivex_parallel_ParallelFlowableConverter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='as' and count(parameter)=1 and parameter[1][@type='io.reactivex.parallel.ParallelFlowableConverter&lt;T, R&gt;']]"
		[Register ("as", "(Lio/reactivex/parallel/ParallelFlowableConverter;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Java.Lang.Object As (global::IO.Reactivex.Parallel.IParallelFlowableConverter converter)
		{
			if (id_as_Lio_reactivex_parallel_ParallelFlowableConverter_ == IntPtr.Zero)
				id_as_Lio_reactivex_parallel_ParallelFlowableConverter_ = JNIEnv.GetMethodID (class_ref, "as", "(Lio/reactivex/parallel/ParallelFlowableConverter;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (converter);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_as_Lio_reactivex_parallel_ParallelFlowableConverter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_collect_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='collect' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends C&gt;'] and parameter[2][@type='io.reactivex.functions.BiConsumer&lt;? super C, ? super T&gt;']]"
		[Register ("collect", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiConsumer;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"C"})]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable Collect (global::Java.Util.Concurrent.ICallable collectionSupplier, global::IO.Reactivex.Functions.IBiConsumer collector)
		{
			if (id_collect_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_ == IntPtr.Zero)
				id_collect_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_ = JNIEnv.GetMethodID (class_ref, "collect", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiConsumer;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (collectionSupplier);
				__args [1] = new JValue (collector);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_collect_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_compose_Lio_reactivex_parallel_ParallelTransformer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='compose' and count(parameter)=1 and parameter[1][@type='io.reactivex.parallel.ParallelTransformer&lt;T, U&gt;']]"
		[Register ("compose", "(Lio/reactivex/parallel/ParallelTransformer;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable Compose (global::IO.Reactivex.Parallel.IParallelTransformer composer)
		{
			if (id_compose_Lio_reactivex_parallel_ParallelTransformer_ == IntPtr.Zero)
				id_compose_Lio_reactivex_parallel_ParallelTransformer_ = JNIEnv.GetMethodID (class_ref, "compose", "(Lio/reactivex/parallel/ParallelTransformer;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (composer);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compose_Lio_reactivex_parallel_ParallelTransformer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doAfterNext_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='doAfterNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("doAfterNext", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable DoAfterNext (global::IO.Reactivex.Functions.IConsumer onAfterNext)
		{
			if (id_doAfterNext_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doAfterNext_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doAfterNext", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onAfterNext);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doAfterNext_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doAfterTerminated_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='doAfterTerminated' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doAfterTerminated", "(Lio/reactivex/functions/Action;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable DoAfterTerminated (global::IO.Reactivex.Functions.IAction onAfterTerminate)
		{
			if (id_doAfterTerminated_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doAfterTerminated_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doAfterTerminated", "(Lio/reactivex/functions/Action;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onAfterTerminate);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doAfterTerminated_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnCancel_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='doOnCancel' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnCancel", "(Lio/reactivex/functions/Action;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable DoOnCancel (global::IO.Reactivex.Functions.IAction onCancel)
		{
			if (id_doOnCancel_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnCancel_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnCancel", "(Lio/reactivex/functions/Action;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onCancel);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnCancel_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnComplete_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='doOnComplete' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnComplete", "(Lio/reactivex/functions/Action;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable DoOnComplete (global::IO.Reactivex.Functions.IAction onComplete)
		{
			if (id_doOnComplete_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnComplete_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnComplete", "(Lio/reactivex/functions/Action;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onComplete);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnComplete_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnError_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='doOnError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;java.lang.Throwable&gt;']]"
		[Register ("doOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable DoOnError (global::IO.Reactivex.Functions.IConsumer onError)
		{
			if (id_doOnError_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnError_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onError);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnError_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnNext_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='doOnNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("doOnNext", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable DoOnNext (global::IO.Reactivex.Functions.IConsumer onNext)
		{
			if (id_doOnNext_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnNext_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnNext", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNext);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnNext_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnNext_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='doOnNext' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super java.lang.Long, ? super java.lang.Throwable, io.reactivex.parallel.ParallelFailureHandling&gt;']]"
		[Register ("doOnNext", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/BiFunction;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable DoOnNext (global::IO.Reactivex.Functions.IConsumer onNext, global::IO.Reactivex.Functions.IBiFunction errorHandler)
		{
			if (id_doOnNext_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_doOnNext_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "doOnNext", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/BiFunction;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (onNext);
				__args [1] = new JValue (errorHandler);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnNext_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnNext_Lio_reactivex_functions_Consumer_Lio_reactivex_parallel_ParallelFailureHandling_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='doOnNext' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.parallel.ParallelFailureHandling']]"
		[Register ("doOnNext", "(Lio/reactivex/functions/Consumer;Lio/reactivex/parallel/ParallelFailureHandling;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable DoOnNext (global::IO.Reactivex.Functions.IConsumer onNext, global::IO.Reactivex.Parallel.ParallelFailureHandling errorHandler)
		{
			if (id_doOnNext_Lio_reactivex_functions_Consumer_Lio_reactivex_parallel_ParallelFailureHandling_ == IntPtr.Zero)
				id_doOnNext_Lio_reactivex_functions_Consumer_Lio_reactivex_parallel_ParallelFailureHandling_ = JNIEnv.GetMethodID (class_ref, "doOnNext", "(Lio/reactivex/functions/Consumer;Lio/reactivex/parallel/ParallelFailureHandling;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (onNext);
				__args [1] = new JValue (errorHandler);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnNext_Lio_reactivex_functions_Consumer_Lio_reactivex_parallel_ParallelFailureHandling_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnRequest_Lio_reactivex_functions_LongConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='doOnRequest' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.LongConsumer']]"
		[Register ("doOnRequest", "(Lio/reactivex/functions/LongConsumer;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable DoOnRequest (global::IO.Reactivex.Functions.ILongConsumer onRequest)
		{
			if (id_doOnRequest_Lio_reactivex_functions_LongConsumer_ == IntPtr.Zero)
				id_doOnRequest_Lio_reactivex_functions_LongConsumer_ = JNIEnv.GetMethodID (class_ref, "doOnRequest", "(Lio/reactivex/functions/LongConsumer;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onRequest);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnRequest_Lio_reactivex_functions_LongConsumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_filter_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
		[Register ("filter", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable Filter (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_filter_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_filter_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "filter", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_filter_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_filter_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='filter' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super java.lang.Long, ? super java.lang.Throwable, io.reactivex.parallel.ParallelFailureHandling&gt;']]"
		[Register ("filter", "(Lio/reactivex/functions/Predicate;Lio/reactivex/functions/BiFunction;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable Filter (global::IO.Reactivex.Functions.IPredicate predicate, global::IO.Reactivex.Functions.IBiFunction errorHandler)
		{
			if (id_filter_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_filter_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "filter", "(Lio/reactivex/functions/Predicate;Lio/reactivex/functions/BiFunction;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (predicate);
				__args [1] = new JValue (errorHandler);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_filter_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_filter_Lio_reactivex_functions_Predicate_Lio_reactivex_parallel_ParallelFailureHandling_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='filter' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.parallel.ParallelFailureHandling']]"
		[Register ("filter", "(Lio/reactivex/functions/Predicate;Lio/reactivex/parallel/ParallelFailureHandling;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable Filter (global::IO.Reactivex.Functions.IPredicate predicate, global::IO.Reactivex.Parallel.ParallelFailureHandling errorHandler)
		{
			if (id_filter_Lio_reactivex_functions_Predicate_Lio_reactivex_parallel_ParallelFailureHandling_ == IntPtr.Zero)
				id_filter_Lio_reactivex_functions_Predicate_Lio_reactivex_parallel_ParallelFailureHandling_ = JNIEnv.GetMethodID (class_ref, "filter", "(Lio/reactivex/functions/Predicate;Lio/reactivex/parallel/ParallelFailureHandling;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (predicate);
				__args [1] = new JValue (errorHandler);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_filter_Lio_reactivex_functions_Predicate_Lio_reactivex_parallel_ParallelFailureHandling_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_map_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='map' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends R&gt;']]"
		[Register ("map", "(Lio/reactivex/functions/Function;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable Map (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_map_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_map_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "map", "(Lio/reactivex/functions/Function;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_map_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='map' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends R&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super java.lang.Long, ? super java.lang.Throwable, io.reactivex.parallel.ParallelFailureHandling&gt;']]"
		[Register ("map", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable Map (global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Functions.IBiFunction errorHandler)
		{
			if (id_map_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_map_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "map", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (errorHandler);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_map_Lio_reactivex_functions_Function_Lio_reactivex_parallel_ParallelFailureHandling_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='map' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends R&gt;'] and parameter[2][@type='io.reactivex.parallel.ParallelFailureHandling']]"
		[Register ("map", "(Lio/reactivex/functions/Function;Lio/reactivex/parallel/ParallelFailureHandling;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable Map (global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Parallel.ParallelFailureHandling errorHandler)
		{
			if (id_map_Lio_reactivex_functions_Function_Lio_reactivex_parallel_ParallelFailureHandling_ == IntPtr.Zero)
				id_map_Lio_reactivex_functions_Function_Lio_reactivex_parallel_ParallelFailureHandling_ = JNIEnv.GetMethodID (class_ref, "map", "(Lio/reactivex/functions/Function;Lio/reactivex/parallel/ParallelFailureHandling;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (errorHandler);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Lio_reactivex_functions_Function_Lio_reactivex_parallel_ParallelFailureHandling_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_parallelism;
#pragma warning disable 0169
		static Delegate GetParallelismHandler ()
		{
			if (cb_parallelism == null)
				cb_parallelism = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Parallelism);
			return cb_parallelism;
		}

		static int n_Parallelism (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Parallelism ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='parallelism' and count(parameter)=0]"
		[Register ("parallelism", "()I", "GetParallelismHandler")]
		public abstract int Parallelism ();

		static IntPtr id_reduce_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='reduce' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;R&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;R, ? super T, R&gt;']]"
		[Register ("reduce", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable Reduce (global::Java.Util.Concurrent.ICallable initialSupplier, global::IO.Reactivex.Functions.IBiFunction reducer)
		{
			if (id_reduce_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_reduce_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "reduce", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (initialSupplier);
				__args [1] = new JValue (reducer);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reduce_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_runOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='runOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("runOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable RunOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_runOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_runOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "runOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_runOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_runOn_Lio_reactivex_Scheduler_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='runOn' and count(parameter)=2 and parameter[1][@type='io.reactivex.Scheduler'] and parameter[2][@type='int']]"
		[Register ("runOn", "(Lio/reactivex/Scheduler;I)Lio/reactivex/parallel/ParallelFlowable;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable RunOn (global::IO.Reactivex.Scheduler scheduler, int prefetch)
		{
			if (id_runOn_Lio_reactivex_Scheduler_I == IntPtr.Zero)
				id_runOn_Lio_reactivex_Scheduler_I = JNIEnv.GetMethodID (class_ref, "runOn", "(Lio/reactivex/Scheduler;I)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (scheduler);
				__args [1] = new JValue (prefetch);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_runOn_Lio_reactivex_Scheduler_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_to_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='to' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.parallel.ParallelFlowable&lt;T&gt;, U&gt;']]"
		[Register ("to", "(Lio/reactivex/functions/Function;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::Java.Lang.Object To (global::IO.Reactivex.Functions.IFunction converter)
		{
			if (id_to_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_to_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "to", "(Lio/reactivex/functions/Function;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (converter);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_to_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/parallel/ParallelFlowable", DoNotGenerateAcw=true)]
	internal partial class ParallelFlowableInvoker : ParallelFlowable {

		public ParallelFlowableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParallelFlowableInvoker); }
		}

		static IntPtr id_parallelism;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFlowable']/method[@name='parallelism' and count(parameter)=0]"
		[Register ("parallelism", "()I", "GetParallelismHandler")]
		public override unsafe int Parallelism ()
		{
			if (id_parallelism == IntPtr.Zero)
				id_parallelism = JNIEnv.GetMethodID (class_ref, "parallelism", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_parallelism);
			} finally {
			}
		}

	}

}
