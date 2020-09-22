using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableInternalHelper", DoNotGenerateAcw=true)]
	public sealed partial class ObservableInternalHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableInternalHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableInternalHelper); }
		}

		internal ObservableInternalHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_flatMapIntoIterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='flatMapIntoIterable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends java.lang.Iterable&lt;? extends U&gt;&gt;']]"
		[Register ("flatMapIntoIterable", "(Lio/reactivex/functions/Function;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction FlatMapIntoIterable (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMapIntoIterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMapIntoIterable_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "flatMapIntoIterable", "(Lio/reactivex/functions/Function;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_flatMapIntoIterable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapWithCombiner_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='flatMapWithCombiner' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends U&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;']]"
		[Register ("flatMapWithCombiner", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction FlatMapWithCombiner (global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Functions.IBiFunction combiner)
		{
			if (id_flatMapWithCombiner_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_flatMapWithCombiner_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "flatMapWithCombiner", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (combiner);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_flatMapWithCombiner_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_itemDelay_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='itemDelay' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;U&gt;&gt;']]"
		[Register ("itemDelay", "(Lio/reactivex/functions/Function;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ItemDelay (global::IO.Reactivex.Functions.IFunction itemDelay)
		{
			if (id_itemDelay_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_itemDelay_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "itemDelay", "(Lio/reactivex/functions/Function;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (itemDelay);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_itemDelay_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_observerOnComplete_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='observerOnComplete' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;T&gt;']]"
		[Register ("observerOnComplete", "(Lio/reactivex/Observer;)Lio/reactivex/functions/Action;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IAction ObserverOnComplete (global::IO.Reactivex.IObserver observer)
		{
			if (id_observerOnComplete_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_observerOnComplete_Lio_reactivex_Observer_ = JNIEnv.GetStaticMethodID (class_ref, "observerOnComplete", "(Lio/reactivex/Observer;)Lio/reactivex/functions/Action;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				global::IO.Reactivex.Functions.IAction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IAction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_observerOnComplete_Lio_reactivex_Observer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_observerOnError_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='observerOnError' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;T&gt;']]"
		[Register ("observerOnError", "(Lio/reactivex/Observer;)Lio/reactivex/functions/Consumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IConsumer ObserverOnError (global::IO.Reactivex.IObserver observer)
		{
			if (id_observerOnError_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_observerOnError_Lio_reactivex_Observer_ = JNIEnv.GetStaticMethodID (class_ref, "observerOnError", "(Lio/reactivex/Observer;)Lio/reactivex/functions/Consumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				global::IO.Reactivex.Functions.IConsumer __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_observerOnError_Lio_reactivex_Observer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_observerOnNext_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='observerOnNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;T&gt;']]"
		[Register ("observerOnNext", "(Lio/reactivex/Observer;)Lio/reactivex/functions/Consumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IConsumer ObserverOnNext (global::IO.Reactivex.IObserver observer)
		{
			if (id_observerOnNext_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_observerOnNext_Lio_reactivex_Observer_ = JNIEnv.GetStaticMethodID (class_ref, "observerOnNext", "(Lio/reactivex/Observer;)Lio/reactivex/functions/Consumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				global::IO.Reactivex.Functions.IConsumer __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_observerOnNext_Lio_reactivex_Observer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replayCallable_Lio_reactivex_Observable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='replayCallable' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observable&lt;T&gt;']]"
		[Register ("replayCallable", "(Lio/reactivex/Observable;)Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.ICallable ReplayCallable (global::IO.Reactivex.Observable parent)
		{
			if (id_replayCallable_Lio_reactivex_Observable_ == IntPtr.Zero)
				id_replayCallable_Lio_reactivex_Observable_ = JNIEnv.GetStaticMethodID (class_ref, "replayCallable", "(Lio/reactivex/Observable;)Ljava/util/concurrent/Callable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (parent);
				global::Java.Util.Concurrent.ICallable __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_replayCallable_Lio_reactivex_Observable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replayCallable_Lio_reactivex_Observable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='replayCallable' and count(parameter)=2 and parameter[1][@type='io.reactivex.Observable&lt;T&gt;'] and parameter[2][@type='int']]"
		[Register ("replayCallable", "(Lio/reactivex/Observable;I)Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.ICallable ReplayCallable (global::IO.Reactivex.Observable parent, int bufferSize)
		{
			if (id_replayCallable_Lio_reactivex_Observable_I == IntPtr.Zero)
				id_replayCallable_Lio_reactivex_Observable_I = JNIEnv.GetStaticMethodID (class_ref, "replayCallable", "(Lio/reactivex/Observable;I)Ljava/util/concurrent/Callable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parent);
				__args [1] = new JValue (bufferSize);
				global::Java.Util.Concurrent.ICallable __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_replayCallable_Lio_reactivex_Observable_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replayCallable_Lio_reactivex_Observable_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='replayCallable' and count(parameter)=5 and parameter[1][@type='io.reactivex.Observable&lt;T&gt;'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit'] and parameter[5][@type='io.reactivex.Scheduler']]"
		[Register ("replayCallable", "(Lio/reactivex/Observable;IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.ICallable ReplayCallable (global::IO.Reactivex.Observable parent, int bufferSize, long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replayCallable_Lio_reactivex_Observable_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replayCallable_Lio_reactivex_Observable_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "replayCallable", "(Lio/reactivex/Observable;IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Ljava/util/concurrent/Callable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (parent);
				__args [1] = new JValue (bufferSize);
				__args [2] = new JValue (time);
				__args [3] = new JValue (unit);
				__args [4] = new JValue (scheduler);
				global::Java.Util.Concurrent.ICallable __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_replayCallable_Lio_reactivex_Observable_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replayCallable_Lio_reactivex_Observable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='replayCallable' and count(parameter)=4 and parameter[1][@type='io.reactivex.Observable&lt;T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("replayCallable", "(Lio/reactivex/Observable;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.ICallable ReplayCallable (global::IO.Reactivex.Observable parent, long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replayCallable_Lio_reactivex_Observable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replayCallable_Lio_reactivex_Observable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "replayCallable", "(Lio/reactivex/Observable;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Ljava/util/concurrent/Callable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (parent);
				__args [1] = new JValue (time);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::Java.Util.Concurrent.ICallable __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_replayCallable_Lio_reactivex_Observable_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replayFunction_Lio_reactivex_functions_Function_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='replayFunction' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;'] and parameter[2][@type='io.reactivex.Scheduler']]"
		[Register ("replayFunction", "(Lio/reactivex/functions/Function;Lio/reactivex/Scheduler;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ReplayFunction (global::IO.Reactivex.Functions.IFunction selector, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replayFunction_Lio_reactivex_functions_Function_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replayFunction_Lio_reactivex_functions_Function_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "replayFunction", "(Lio/reactivex/functions/Function;Lio/reactivex/Scheduler;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (selector);
				__args [1] = new JValue (scheduler);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_replayFunction_Lio_reactivex_functions_Function_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_simpleBiGenerator_Lio_reactivex_functions_BiConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='simpleBiGenerator' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiConsumer&lt;S, io.reactivex.Emitter&lt;T&gt;&gt;']]"
		[Register ("simpleBiGenerator", "(Lio/reactivex/functions/BiConsumer;)Lio/reactivex/functions/BiFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "S"})]
		public static unsafe global::IO.Reactivex.Functions.IBiFunction SimpleBiGenerator (global::IO.Reactivex.Functions.IBiConsumer consumer)
		{
			if (id_simpleBiGenerator_Lio_reactivex_functions_BiConsumer_ == IntPtr.Zero)
				id_simpleBiGenerator_Lio_reactivex_functions_BiConsumer_ = JNIEnv.GetStaticMethodID (class_ref, "simpleBiGenerator", "(Lio/reactivex/functions/BiConsumer;)Lio/reactivex/functions/BiFunction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (consumer);
				global::IO.Reactivex.Functions.IBiFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_simpleBiGenerator_Lio_reactivex_functions_BiConsumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_simpleGenerator_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='simpleGenerator' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;io.reactivex.Emitter&lt;T&gt;&gt;']]"
		[Register ("simpleGenerator", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/functions/BiFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "S"})]
		public static unsafe global::IO.Reactivex.Functions.IBiFunction SimpleGenerator (global::IO.Reactivex.Functions.IConsumer consumer)
		{
			if (id_simpleGenerator_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_simpleGenerator_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "simpleGenerator", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/functions/BiFunction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (consumer);
				global::IO.Reactivex.Functions.IBiFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_simpleGenerator_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zipIterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableInternalHelper']/method[@name='zipIterable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register ("zipIterable", "(Lio/reactivex/functions/Function;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ZipIterable (global::IO.Reactivex.Functions.IFunction zipper)
		{
			if (id_zipIterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_zipIterable_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "zipIterable", "(Lio/reactivex/functions/Function;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (zipper);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zipIterable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
