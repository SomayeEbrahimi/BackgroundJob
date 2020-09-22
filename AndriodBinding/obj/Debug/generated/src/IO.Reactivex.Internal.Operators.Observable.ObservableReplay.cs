using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableReplay", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ObservableReplay : global::IO.Reactivex.Observables.ConnectableObservable, global::IO.Reactivex.Internal.Disposables.IResettableConnectable, global::IO.Reactivex.Internal.Fuseable.IHasUpstreamObservableSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableReplay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableReplay); }
		}

		internal ObservableReplay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_connect_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register ("connect", "(Lio/reactivex/functions/Consumer;)V", "")]
		public override unsafe void Connect (global::IO.Reactivex.Functions.IConsumer connection)
		{
			if (id_connect_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_connect_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lio/reactivex/functions/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (connection);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lio_reactivex_functions_Consumer_, __args);
			} finally {
			}
		}

		static IntPtr id_create_Lio_reactivex_ObservableSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']/method[@name='create' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;'] and parameter[2][@type='int']]"
		[Register ("create", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/observables/ConnectableObservable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observables.ConnectableObservable Create (global::IO.Reactivex.IObservableSource source, int bufferSize)
		{
			if (id_create_Lio_reactivex_ObservableSource_I == IntPtr.Zero)
				id_create_Lio_reactivex_ObservableSource_I = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (bufferSize);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lio_reactivex_ObservableSource_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create_Lio_reactivex_ObservableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']/method[@name='create' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("create", "(Lio/reactivex/ObservableSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observables.ConnectableObservable Create (global::IO.Reactivex.IObservableSource source, long maxAge, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_create_Lio_reactivex_ObservableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_create_Lio_reactivex_ObservableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lio/reactivex/ObservableSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source);
				__args [1] = new JValue (maxAge);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lio_reactivex_ObservableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create_Lio_reactivex_ObservableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']/method[@name='create' and count(parameter)=5 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler'] and parameter[5][@type='int']]"
		[Register ("create", "(Lio/reactivex/ObservableSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;I)Lio/reactivex/observables/ConnectableObservable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observables.ConnectableObservable Create (global::IO.Reactivex.IObservableSource source, long maxAge, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, int bufferSize)
		{
			if (id_create_Lio_reactivex_ObservableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I == IntPtr.Zero)
				id_create_Lio_reactivex_ObservableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lio/reactivex/ObservableSource;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;I)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source);
				__args [1] = new JValue (maxAge);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				__args [4] = new JValue (bufferSize);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lio_reactivex_ObservableSource_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createFrom_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']/method[@name='createFrom' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("createFrom", "(Lio/reactivex/ObservableSource;)Lio/reactivex/observables/ConnectableObservable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observables.ConnectableObservable CreateFrom (global::IO.Reactivex.IObservableSource source)
		{
			if (id_createFrom_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_createFrom_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "createFrom", "(Lio/reactivex/ObservableSource;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFrom_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_multicastSelector_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']/method[@name='multicastSelector' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.observables.ConnectableObservable&lt;U&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;U&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;']]"
		[Register ("multicastSelector", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public static unsafe global::IO.Reactivex.Observable MulticastSelector (global::Java.Util.Concurrent.ICallable connectableFactory, global::IO.Reactivex.Functions.IFunction selector)
		{
			if (id_multicastSelector_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_multicastSelector_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "multicastSelector", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (connectableFactory);
				__args [1] = new JValue (selector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_multicastSelector_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_observeOn_Lio_reactivex_observables_ConnectableObservable_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']/method[@name='observeOn' and count(parameter)=2 and parameter[1][@type='io.reactivex.observables.ConnectableObservable&lt;T&gt;'] and parameter[2][@type='io.reactivex.Scheduler']]"
		[Register ("observeOn", "(Lio/reactivex/observables/ConnectableObservable;Lio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observables.ConnectableObservable ObserveOn (global::IO.Reactivex.Observables.ConnectableObservable co, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_observeOn_Lio_reactivex_observables_ConnectableObservable_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_observeOn_Lio_reactivex_observables_ConnectableObservable_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "observeOn", "(Lio/reactivex/observables/ConnectableObservable;Lio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (co);
				__args [1] = new JValue (scheduler);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_observeOn_Lio_reactivex_observables_ConnectableObservable_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_resetIf_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']/method[@name='resetIf' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("resetIf", "(Lio/reactivex/disposables/Disposable;)V", "")]
		public unsafe void ResetIf (global::IO.Reactivex.Disposables.IDisposable connectionObject)
		{
			if (id_resetIf_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_resetIf_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "resetIf", "(Lio/reactivex/disposables/Disposable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (connectionObject);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetIf_Lio_reactivex_disposables_Disposable_, __args);
			} finally {
			}
		}

		static IntPtr id_source;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()Lio/reactivex/ObservableSource;", "")]
		public unsafe global::IO.Reactivex.IObservableSource Source ()
		{
			if (id_source == IntPtr.Zero)
				id_source = JNIEnv.GetMethodID (class_ref, "source", "()Lio/reactivex/ObservableSource;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObservableSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_source), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableReplay']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/Observer;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

	}
}
