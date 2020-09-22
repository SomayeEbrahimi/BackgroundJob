using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Plugins {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']"
	[global::Android.Runtime.Register ("io/reactivex/plugins/RxJavaPlugins", DoNotGenerateAcw=true)]
	public sealed partial class RxJavaPlugins : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/plugins/RxJavaPlugins", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RxJavaPlugins); }
		}

		internal RxJavaPlugins (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getComputationSchedulerHandler;
		static IntPtr id_setComputationSchedulerHandler_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction ComputationSchedulerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getComputationSchedulerHandler' and count(parameter)=0]"
			[Register ("getComputationSchedulerHandler", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getComputationSchedulerHandler == IntPtr.Zero)
					id_getComputationSchedulerHandler = JNIEnv.GetStaticMethodID (class_ref, "getComputationSchedulerHandler", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getComputationSchedulerHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setComputationSchedulerHandler' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Scheduler, ? extends io.reactivex.Scheduler&gt;']]"
			[Register ("setComputationSchedulerHandler", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setComputationSchedulerHandler_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setComputationSchedulerHandler_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setComputationSchedulerHandler", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setComputationSchedulerHandler_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getErrorHandler;
		static IntPtr id_setErrorHandler_Lio_reactivex_functions_Consumer_;
		public static unsafe global::IO.Reactivex.Functions.IConsumer ErrorHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getErrorHandler' and count(parameter)=0]"
			[Register ("getErrorHandler", "()Lio/reactivex/functions/Consumer;", "")]
			get {
				if (id_getErrorHandler == IntPtr.Zero)
					id_getErrorHandler = JNIEnv.GetStaticMethodID (class_ref, "getErrorHandler", "()Lio/reactivex/functions/Consumer;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setErrorHandler' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
			[Register ("setErrorHandler", "(Lio/reactivex/functions/Consumer;)V", "")]
			set {
				if (id_setErrorHandler_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
					id_setErrorHandler_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "setErrorHandler", "(Lio/reactivex/functions/Consumer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setErrorHandler_Lio_reactivex_functions_Consumer_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isFailOnNonBlockingScheduler;
		static IntPtr id_setFailOnNonBlockingScheduler_Z;
		public static unsafe bool FailOnNonBlockingScheduler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='isFailOnNonBlockingScheduler' and count(parameter)=0]"
			[Register ("isFailOnNonBlockingScheduler", "()Z", "")]
			get {
				if (id_isFailOnNonBlockingScheduler == IntPtr.Zero)
					id_isFailOnNonBlockingScheduler = JNIEnv.GetStaticMethodID (class_ref, "isFailOnNonBlockingScheduler", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFailOnNonBlockingScheduler);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setFailOnNonBlockingScheduler' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFailOnNonBlockingScheduler", "(Z)V", "")]
			set {
				if (id_setFailOnNonBlockingScheduler_Z == IntPtr.Zero)
					id_setFailOnNonBlockingScheduler_Z = JNIEnv.GetStaticMethodID (class_ref, "setFailOnNonBlockingScheduler", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setFailOnNonBlockingScheduler_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getInitComputationSchedulerHandler;
		static IntPtr id_setInitComputationSchedulerHandler_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction InitComputationSchedulerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getInitComputationSchedulerHandler' and count(parameter)=0]"
			[Register ("getInitComputationSchedulerHandler", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getInitComputationSchedulerHandler == IntPtr.Zero)
					id_getInitComputationSchedulerHandler = JNIEnv.GetStaticMethodID (class_ref, "getInitComputationSchedulerHandler", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInitComputationSchedulerHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setInitComputationSchedulerHandler' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.util.concurrent.Callable&lt;io.reactivex.Scheduler&gt;, ? extends io.reactivex.Scheduler&gt;']]"
			[Register ("setInitComputationSchedulerHandler", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setInitComputationSchedulerHandler_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setInitComputationSchedulerHandler_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setInitComputationSchedulerHandler", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setInitComputationSchedulerHandler_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getInitIoSchedulerHandler;
		static IntPtr id_setInitIoSchedulerHandler_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction InitIoSchedulerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getInitIoSchedulerHandler' and count(parameter)=0]"
			[Register ("getInitIoSchedulerHandler", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getInitIoSchedulerHandler == IntPtr.Zero)
					id_getInitIoSchedulerHandler = JNIEnv.GetStaticMethodID (class_ref, "getInitIoSchedulerHandler", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInitIoSchedulerHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setInitIoSchedulerHandler' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.util.concurrent.Callable&lt;io.reactivex.Scheduler&gt;, ? extends io.reactivex.Scheduler&gt;']]"
			[Register ("setInitIoSchedulerHandler", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setInitIoSchedulerHandler_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setInitIoSchedulerHandler_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setInitIoSchedulerHandler", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setInitIoSchedulerHandler_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getInitNewThreadSchedulerHandler;
		static IntPtr id_setInitNewThreadSchedulerHandler_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction InitNewThreadSchedulerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getInitNewThreadSchedulerHandler' and count(parameter)=0]"
			[Register ("getInitNewThreadSchedulerHandler", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getInitNewThreadSchedulerHandler == IntPtr.Zero)
					id_getInitNewThreadSchedulerHandler = JNIEnv.GetStaticMethodID (class_ref, "getInitNewThreadSchedulerHandler", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInitNewThreadSchedulerHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setInitNewThreadSchedulerHandler' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.util.concurrent.Callable&lt;io.reactivex.Scheduler&gt;, ? extends io.reactivex.Scheduler&gt;']]"
			[Register ("setInitNewThreadSchedulerHandler", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setInitNewThreadSchedulerHandler_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setInitNewThreadSchedulerHandler_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setInitNewThreadSchedulerHandler", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setInitNewThreadSchedulerHandler_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getInitSingleSchedulerHandler;
		static IntPtr id_setInitSingleSchedulerHandler_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction InitSingleSchedulerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getInitSingleSchedulerHandler' and count(parameter)=0]"
			[Register ("getInitSingleSchedulerHandler", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getInitSingleSchedulerHandler == IntPtr.Zero)
					id_getInitSingleSchedulerHandler = JNIEnv.GetStaticMethodID (class_ref, "getInitSingleSchedulerHandler", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInitSingleSchedulerHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setInitSingleSchedulerHandler' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.util.concurrent.Callable&lt;io.reactivex.Scheduler&gt;, ? extends io.reactivex.Scheduler&gt;']]"
			[Register ("setInitSingleSchedulerHandler", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setInitSingleSchedulerHandler_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setInitSingleSchedulerHandler_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setInitSingleSchedulerHandler", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setInitSingleSchedulerHandler_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getIoSchedulerHandler;
		static IntPtr id_setIoSchedulerHandler_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction IoSchedulerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getIoSchedulerHandler' and count(parameter)=0]"
			[Register ("getIoSchedulerHandler", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getIoSchedulerHandler == IntPtr.Zero)
					id_getIoSchedulerHandler = JNIEnv.GetStaticMethodID (class_ref, "getIoSchedulerHandler", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIoSchedulerHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setIoSchedulerHandler' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Scheduler, ? extends io.reactivex.Scheduler&gt;']]"
			[Register ("setIoSchedulerHandler", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setIoSchedulerHandler_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setIoSchedulerHandler_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setIoSchedulerHandler", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setIoSchedulerHandler_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isLockdown;
		public static unsafe bool IsLockdown {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='isLockdown' and count(parameter)=0]"
			[Register ("isLockdown", "()Z", "")]
			get {
				if (id_isLockdown == IntPtr.Zero)
					id_isLockdown = JNIEnv.GetStaticMethodID (class_ref, "isLockdown", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLockdown);
				} finally {
				}
			}
		}

		static IntPtr id_getNewThreadSchedulerHandler;
		static IntPtr id_setNewThreadSchedulerHandler_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction NewThreadSchedulerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getNewThreadSchedulerHandler' and count(parameter)=0]"
			[Register ("getNewThreadSchedulerHandler", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getNewThreadSchedulerHandler == IntPtr.Zero)
					id_getNewThreadSchedulerHandler = JNIEnv.GetStaticMethodID (class_ref, "getNewThreadSchedulerHandler", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNewThreadSchedulerHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setNewThreadSchedulerHandler' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Scheduler, ? extends io.reactivex.Scheduler&gt;']]"
			[Register ("setNewThreadSchedulerHandler", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setNewThreadSchedulerHandler_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setNewThreadSchedulerHandler_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setNewThreadSchedulerHandler", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setNewThreadSchedulerHandler_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnBeforeBlocking;
		static IntPtr id_setOnBeforeBlocking_Lio_reactivex_functions_BooleanSupplier_;
		public static unsafe global::IO.Reactivex.Functions.IBooleanSupplier OnBeforeBlocking {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnBeforeBlocking' and count(parameter)=0]"
			[Register ("getOnBeforeBlocking", "()Lio/reactivex/functions/BooleanSupplier;", "")]
			get {
				if (id_getOnBeforeBlocking == IntPtr.Zero)
					id_getOnBeforeBlocking = JNIEnv.GetStaticMethodID (class_ref, "getOnBeforeBlocking", "()Lio/reactivex/functions/BooleanSupplier;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBooleanSupplier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnBeforeBlocking), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnBeforeBlocking' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BooleanSupplier']]"
			[Register ("setOnBeforeBlocking", "(Lio/reactivex/functions/BooleanSupplier;)V", "")]
			set {
				if (id_setOnBeforeBlocking_Lio_reactivex_functions_BooleanSupplier_ == IntPtr.Zero)
					id_setOnBeforeBlocking_Lio_reactivex_functions_BooleanSupplier_ = JNIEnv.GetStaticMethodID (class_ref, "setOnBeforeBlocking", "(Lio/reactivex/functions/BooleanSupplier;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnBeforeBlocking_Lio_reactivex_functions_BooleanSupplier_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnCompletableAssembly;
		static IntPtr id_setOnCompletableAssembly_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction OnCompletableAssembly {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnCompletableAssembly' and count(parameter)=0]"
			[Register ("getOnCompletableAssembly", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getOnCompletableAssembly == IntPtr.Zero)
					id_getOnCompletableAssembly = JNIEnv.GetStaticMethodID (class_ref, "getOnCompletableAssembly", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnCompletableAssembly), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnCompletableAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Completable, ? extends io.reactivex.Completable&gt;']]"
			[Register ("setOnCompletableAssembly", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setOnCompletableAssembly_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setOnCompletableAssembly_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setOnCompletableAssembly", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnCompletableAssembly_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnCompletableSubscribe;
		static IntPtr id_setOnCompletableSubscribe_Lio_reactivex_functions_BiFunction_;
		public static unsafe global::IO.Reactivex.Functions.IBiFunction OnCompletableSubscribe {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnCompletableSubscribe' and count(parameter)=0]"
			[Register ("getOnCompletableSubscribe", "()Lio/reactivex/functions/BiFunction;", "")]
			get {
				if (id_getOnCompletableSubscribe == IntPtr.Zero)
					id_getOnCompletableSubscribe = JNIEnv.GetStaticMethodID (class_ref, "getOnCompletableSubscribe", "()Lio/reactivex/functions/BiFunction;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnCompletableSubscribe), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnCompletableSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiFunction&lt;? super io.reactivex.Completable, ? super io.reactivex.CompletableObserver, ? extends io.reactivex.CompletableObserver&gt;']]"
			[Register ("setOnCompletableSubscribe", "(Lio/reactivex/functions/BiFunction;)V", "")]
			set {
				if (id_setOnCompletableSubscribe_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
					id_setOnCompletableSubscribe_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "setOnCompletableSubscribe", "(Lio/reactivex/functions/BiFunction;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnCompletableSubscribe_Lio_reactivex_functions_BiFunction_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnConnectableObservableAssembly;
		static IntPtr id_setOnConnectableObservableAssembly_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction OnConnectableObservableAssembly {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnConnectableObservableAssembly' and count(parameter)=0]"
			[Register ("getOnConnectableObservableAssembly", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getOnConnectableObservableAssembly == IntPtr.Zero)
					id_getOnConnectableObservableAssembly = JNIEnv.GetStaticMethodID (class_ref, "getOnConnectableObservableAssembly", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnConnectableObservableAssembly), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnConnectableObservableAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.observables.ConnectableObservable, ? extends io.reactivex.observables.ConnectableObservable&gt;']]"
			[Register ("setOnConnectableObservableAssembly", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setOnConnectableObservableAssembly_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setOnConnectableObservableAssembly_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setOnConnectableObservableAssembly", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnConnectableObservableAssembly_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnMaybeAssembly;
		static IntPtr id_setOnMaybeAssembly_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction OnMaybeAssembly {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnMaybeAssembly' and count(parameter)=0]"
			[Register ("getOnMaybeAssembly", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getOnMaybeAssembly == IntPtr.Zero)
					id_getOnMaybeAssembly = JNIEnv.GetStaticMethodID (class_ref, "getOnMaybeAssembly", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnMaybeAssembly), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnMaybeAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Maybe, ? extends io.reactivex.Maybe&gt;']]"
			[Register ("setOnMaybeAssembly", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setOnMaybeAssembly_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setOnMaybeAssembly_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setOnMaybeAssembly", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnMaybeAssembly_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnMaybeSubscribe;
		static IntPtr id_setOnMaybeSubscribe_Lio_reactivex_functions_BiFunction_;
		public static unsafe global::IO.Reactivex.Functions.IBiFunction OnMaybeSubscribe {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnMaybeSubscribe' and count(parameter)=0]"
			[Register ("getOnMaybeSubscribe", "()Lio/reactivex/functions/BiFunction;", "")]
			get {
				if (id_getOnMaybeSubscribe == IntPtr.Zero)
					id_getOnMaybeSubscribe = JNIEnv.GetStaticMethodID (class_ref, "getOnMaybeSubscribe", "()Lio/reactivex/functions/BiFunction;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnMaybeSubscribe), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnMaybeSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiFunction&lt;? super io.reactivex.Maybe, io.reactivex.MaybeObserver, ? extends io.reactivex.MaybeObserver&gt;']]"
			[Register ("setOnMaybeSubscribe", "(Lio/reactivex/functions/BiFunction;)V", "")]
			set {
				if (id_setOnMaybeSubscribe_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
					id_setOnMaybeSubscribe_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "setOnMaybeSubscribe", "(Lio/reactivex/functions/BiFunction;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnMaybeSubscribe_Lio_reactivex_functions_BiFunction_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnObservableAssembly;
		static IntPtr id_setOnObservableAssembly_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction OnObservableAssembly {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnObservableAssembly' and count(parameter)=0]"
			[Register ("getOnObservableAssembly", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getOnObservableAssembly == IntPtr.Zero)
					id_getOnObservableAssembly = JNIEnv.GetStaticMethodID (class_ref, "getOnObservableAssembly", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnObservableAssembly), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnObservableAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable, ? extends io.reactivex.Observable&gt;']]"
			[Register ("setOnObservableAssembly", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setOnObservableAssembly_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setOnObservableAssembly_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setOnObservableAssembly", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnObservableAssembly_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnObservableSubscribe;
		static IntPtr id_setOnObservableSubscribe_Lio_reactivex_functions_BiFunction_;
		public static unsafe global::IO.Reactivex.Functions.IBiFunction OnObservableSubscribe {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnObservableSubscribe' and count(parameter)=0]"
			[Register ("getOnObservableSubscribe", "()Lio/reactivex/functions/BiFunction;", "")]
			get {
				if (id_getOnObservableSubscribe == IntPtr.Zero)
					id_getOnObservableSubscribe = JNIEnv.GetStaticMethodID (class_ref, "getOnObservableSubscribe", "()Lio/reactivex/functions/BiFunction;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnObservableSubscribe), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnObservableSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiFunction&lt;? super io.reactivex.Observable, ? super io.reactivex.Observer, ? extends io.reactivex.Observer&gt;']]"
			[Register ("setOnObservableSubscribe", "(Lio/reactivex/functions/BiFunction;)V", "")]
			set {
				if (id_setOnObservableSubscribe_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
					id_setOnObservableSubscribe_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "setOnObservableSubscribe", "(Lio/reactivex/functions/BiFunction;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnObservableSubscribe_Lio_reactivex_functions_BiFunction_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnParallelAssembly;
		static IntPtr id_setOnParallelAssembly_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction OnParallelAssembly {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnParallelAssembly' and count(parameter)=0]"
			[Register ("getOnParallelAssembly", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getOnParallelAssembly == IntPtr.Zero)
					id_getOnParallelAssembly = JNIEnv.GetStaticMethodID (class_ref, "getOnParallelAssembly", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnParallelAssembly), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnParallelAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.parallel.ParallelFlowable, ? extends io.reactivex.parallel.ParallelFlowable&gt;']]"
			[Register ("setOnParallelAssembly", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setOnParallelAssembly_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setOnParallelAssembly_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setOnParallelAssembly", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnParallelAssembly_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnSingleAssembly;
		static IntPtr id_setOnSingleAssembly_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction OnSingleAssembly {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnSingleAssembly' and count(parameter)=0]"
			[Register ("getOnSingleAssembly", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getOnSingleAssembly == IntPtr.Zero)
					id_getOnSingleAssembly = JNIEnv.GetStaticMethodID (class_ref, "getOnSingleAssembly", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnSingleAssembly), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnSingleAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Single, ? extends io.reactivex.Single&gt;']]"
			[Register ("setOnSingleAssembly", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setOnSingleAssembly_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setOnSingleAssembly_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setOnSingleAssembly", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnSingleAssembly_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOnSingleSubscribe;
		static IntPtr id_setOnSingleSubscribe_Lio_reactivex_functions_BiFunction_;
		public static unsafe global::IO.Reactivex.Functions.IBiFunction OnSingleSubscribe {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getOnSingleSubscribe' and count(parameter)=0]"
			[Register ("getOnSingleSubscribe", "()Lio/reactivex/functions/BiFunction;", "")]
			get {
				if (id_getOnSingleSubscribe == IntPtr.Zero)
					id_getOnSingleSubscribe = JNIEnv.GetStaticMethodID (class_ref, "getOnSingleSubscribe", "()Lio/reactivex/functions/BiFunction;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnSingleSubscribe), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setOnSingleSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiFunction&lt;? super io.reactivex.Single, ? super io.reactivex.SingleObserver, ? extends io.reactivex.SingleObserver&gt;']]"
			[Register ("setOnSingleSubscribe", "(Lio/reactivex/functions/BiFunction;)V", "")]
			set {
				if (id_setOnSingleSubscribe_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
					id_setOnSingleSubscribe_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "setOnSingleSubscribe", "(Lio/reactivex/functions/BiFunction;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnSingleSubscribe_Lio_reactivex_functions_BiFunction_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getScheduleHandler;
		static IntPtr id_setScheduleHandler_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction ScheduleHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getScheduleHandler' and count(parameter)=0]"
			[Register ("getScheduleHandler", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getScheduleHandler == IntPtr.Zero)
					id_getScheduleHandler = JNIEnv.GetStaticMethodID (class_ref, "getScheduleHandler", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScheduleHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setScheduleHandler' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Runnable, ? extends java.lang.Runnable&gt;']]"
			[Register ("setScheduleHandler", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setScheduleHandler_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setScheduleHandler_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setScheduleHandler", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setScheduleHandler_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSingleSchedulerHandler;
		static IntPtr id_setSingleSchedulerHandler_Lio_reactivex_functions_Function_;
		public static unsafe global::IO.Reactivex.Functions.IFunction SingleSchedulerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='getSingleSchedulerHandler' and count(parameter)=0]"
			[Register ("getSingleSchedulerHandler", "()Lio/reactivex/functions/Function;", "")]
			get {
				if (id_getSingleSchedulerHandler == IntPtr.Zero)
					id_getSingleSchedulerHandler = JNIEnv.GetStaticMethodID (class_ref, "getSingleSchedulerHandler", "()Lio/reactivex/functions/Function;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSingleSchedulerHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='setSingleSchedulerHandler' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Scheduler, ? extends io.reactivex.Scheduler&gt;']]"
			[Register ("setSingleSchedulerHandler", "(Lio/reactivex/functions/Function;)V", "")]
			set {
				if (id_setSingleSchedulerHandler_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_setSingleSchedulerHandler_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "setSingleSchedulerHandler", "(Lio/reactivex/functions/Function;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setSingleSchedulerHandler_Lio_reactivex_functions_Function_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_createComputationScheduler_Ljava_util_concurrent_ThreadFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='createComputationScheduler' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
		[Register ("createComputationScheduler", "(Ljava/util/concurrent/ThreadFactory;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler CreateComputationScheduler (global::Java.Util.Concurrent.IThreadFactory threadFactory)
		{
			if (id_createComputationScheduler_Ljava_util_concurrent_ThreadFactory_ == IntPtr.Zero)
				id_createComputationScheduler_Ljava_util_concurrent_ThreadFactory_ = JNIEnv.GetStaticMethodID (class_ref, "createComputationScheduler", "(Ljava/util/concurrent/ThreadFactory;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threadFactory);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createComputationScheduler_Ljava_util_concurrent_ThreadFactory_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createIoScheduler_Ljava_util_concurrent_ThreadFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='createIoScheduler' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
		[Register ("createIoScheduler", "(Ljava/util/concurrent/ThreadFactory;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler CreateIoScheduler (global::Java.Util.Concurrent.IThreadFactory threadFactory)
		{
			if (id_createIoScheduler_Ljava_util_concurrent_ThreadFactory_ == IntPtr.Zero)
				id_createIoScheduler_Ljava_util_concurrent_ThreadFactory_ = JNIEnv.GetStaticMethodID (class_ref, "createIoScheduler", "(Ljava/util/concurrent/ThreadFactory;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threadFactory);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createIoScheduler_Ljava_util_concurrent_ThreadFactory_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createNewThreadScheduler_Ljava_util_concurrent_ThreadFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='createNewThreadScheduler' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
		[Register ("createNewThreadScheduler", "(Ljava/util/concurrent/ThreadFactory;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler CreateNewThreadScheduler (global::Java.Util.Concurrent.IThreadFactory threadFactory)
		{
			if (id_createNewThreadScheduler_Ljava_util_concurrent_ThreadFactory_ == IntPtr.Zero)
				id_createNewThreadScheduler_Ljava_util_concurrent_ThreadFactory_ = JNIEnv.GetStaticMethodID (class_ref, "createNewThreadScheduler", "(Ljava/util/concurrent/ThreadFactory;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threadFactory);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createNewThreadScheduler_Ljava_util_concurrent_ThreadFactory_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createSingleScheduler_Ljava_util_concurrent_ThreadFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='createSingleScheduler' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
		[Register ("createSingleScheduler", "(Ljava/util/concurrent/ThreadFactory;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler CreateSingleScheduler (global::Java.Util.Concurrent.IThreadFactory threadFactory)
		{
			if (id_createSingleScheduler_Ljava_util_concurrent_ThreadFactory_ == IntPtr.Zero)
				id_createSingleScheduler_Ljava_util_concurrent_ThreadFactory_ = JNIEnv.GetStaticMethodID (class_ref, "createSingleScheduler", "(Ljava/util/concurrent/ThreadFactory;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threadFactory);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createSingleScheduler_Ljava_util_concurrent_ThreadFactory_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initComputationScheduler_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='initComputationScheduler' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;io.reactivex.Scheduler&gt;']]"
		[Register ("initComputationScheduler", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler InitComputationScheduler (global::Java.Util.Concurrent.ICallable defaultScheduler)
		{
			if (id_initComputationScheduler_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_initComputationScheduler_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "initComputationScheduler", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultScheduler);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initComputationScheduler_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initIoScheduler_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='initIoScheduler' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;io.reactivex.Scheduler&gt;']]"
		[Register ("initIoScheduler", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler InitIoScheduler (global::Java.Util.Concurrent.ICallable defaultScheduler)
		{
			if (id_initIoScheduler_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_initIoScheduler_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "initIoScheduler", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultScheduler);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initIoScheduler_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initNewThreadScheduler_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='initNewThreadScheduler' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;io.reactivex.Scheduler&gt;']]"
		[Register ("initNewThreadScheduler", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler InitNewThreadScheduler (global::Java.Util.Concurrent.ICallable defaultScheduler)
		{
			if (id_initNewThreadScheduler_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_initNewThreadScheduler_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "initNewThreadScheduler", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultScheduler);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initNewThreadScheduler_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initSingleScheduler_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='initSingleScheduler' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;io.reactivex.Scheduler&gt;']]"
		[Register ("initSingleScheduler", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler InitSingleScheduler (global::Java.Util.Concurrent.ICallable defaultScheduler)
		{
			if (id_initSingleScheduler_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_initSingleScheduler_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "initSingleScheduler", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultScheduler);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initSingleScheduler_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_lockdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='lockdown' and count(parameter)=0]"
		[Register ("lockdown", "()V", "")]
		public static unsafe void Lockdown ()
		{
			if (id_lockdown == IntPtr.Zero)
				id_lockdown = JNIEnv.GetStaticMethodID (class_ref, "lockdown", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_lockdown);
			} finally {
			}
		}

		static IntPtr id_onAssembly_Lio_reactivex_Completable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.Completable']]"
		[Register ("onAssembly", "(Lio/reactivex/Completable;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable OnAssembly (global::IO.Reactivex.Completable source)
		{
			if (id_onAssembly_Lio_reactivex_Completable_ == IntPtr.Zero)
				id_onAssembly_Lio_reactivex_Completable_ = JNIEnv.GetStaticMethodID (class_ref, "onAssembly", "(Lio/reactivex/Completable;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onAssembly_Lio_reactivex_Completable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onAssembly_Lio_reactivex_Maybe_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.Maybe&lt;T&gt;']]"
		[Register ("onAssembly", "(Lio/reactivex/Maybe;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe OnAssembly (global::IO.Reactivex.Maybe source)
		{
			if (id_onAssembly_Lio_reactivex_Maybe_ == IntPtr.Zero)
				id_onAssembly_Lio_reactivex_Maybe_ = JNIEnv.GetStaticMethodID (class_ref, "onAssembly", "(Lio/reactivex/Maybe;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onAssembly_Lio_reactivex_Maybe_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onAssembly_Lio_reactivex_Observable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observable&lt;T&gt;']]"
		[Register ("onAssembly", "(Lio/reactivex/Observable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable OnAssembly (global::IO.Reactivex.Observable source)
		{
			if (id_onAssembly_Lio_reactivex_Observable_ == IntPtr.Zero)
				id_onAssembly_Lio_reactivex_Observable_ = JNIEnv.GetStaticMethodID (class_ref, "onAssembly", "(Lio/reactivex/Observable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onAssembly_Lio_reactivex_Observable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onAssembly_Lio_reactivex_observables_ConnectableObservable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.observables.ConnectableObservable&lt;T&gt;']]"
		[Register ("onAssembly", "(Lio/reactivex/observables/ConnectableObservable;)Lio/reactivex/observables/ConnectableObservable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observables.ConnectableObservable OnAssembly (global::IO.Reactivex.Observables.ConnectableObservable source)
		{
			if (id_onAssembly_Lio_reactivex_observables_ConnectableObservable_ == IntPtr.Zero)
				id_onAssembly_Lio_reactivex_observables_ConnectableObservable_ = JNIEnv.GetStaticMethodID (class_ref, "onAssembly", "(Lio/reactivex/observables/ConnectableObservable;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onAssembly_Lio_reactivex_observables_ConnectableObservable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onAssembly_Lio_reactivex_parallel_ParallelFlowable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.parallel.ParallelFlowable&lt;T&gt;']]"
		[Register ("onAssembly", "(Lio/reactivex/parallel/ParallelFlowable;)Lio/reactivex/parallel/ParallelFlowable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Parallel.ParallelFlowable OnAssembly (global::IO.Reactivex.Parallel.ParallelFlowable source)
		{
			if (id_onAssembly_Lio_reactivex_parallel_ParallelFlowable_ == IntPtr.Zero)
				id_onAssembly_Lio_reactivex_parallel_ParallelFlowable_ = JNIEnv.GetStaticMethodID (class_ref, "onAssembly", "(Lio/reactivex/parallel/ParallelFlowable;)Lio/reactivex/parallel/ParallelFlowable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Parallel.ParallelFlowable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onAssembly_Lio_reactivex_parallel_ParallelFlowable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onAssembly_Lio_reactivex_Single_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onAssembly' and count(parameter)=1 and parameter[1][@type='io.reactivex.Single&lt;T&gt;']]"
		[Register ("onAssembly", "(Lio/reactivex/Single;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single OnAssembly (global::IO.Reactivex.Single source)
		{
			if (id_onAssembly_Lio_reactivex_Single_ == IntPtr.Zero)
				id_onAssembly_Lio_reactivex_Single_ = JNIEnv.GetStaticMethodID (class_ref, "onAssembly", "(Lio/reactivex/Single;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onAssembly_Lio_reactivex_Single_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onBeforeBlocking;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onBeforeBlocking' and count(parameter)=0]"
		[Register ("onBeforeBlocking", "()Z", "")]
		public static unsafe bool InvokeOnBeforeBlocking ()
		{
			if (id_onBeforeBlocking == IntPtr.Zero)
				id_onBeforeBlocking = JNIEnv.GetStaticMethodID (class_ref, "onBeforeBlocking", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_onBeforeBlocking);
			} finally {
			}
		}

		static IntPtr id_onComputationScheduler_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onComputationScheduler' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("onComputationScheduler", "(Lio/reactivex/Scheduler;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler OnComputationScheduler (global::IO.Reactivex.Scheduler defaultScheduler)
		{
			if (id_onComputationScheduler_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_onComputationScheduler_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "onComputationScheduler", "(Lio/reactivex/Scheduler;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultScheduler);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onComputationScheduler_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void OnError (global::Java.Lang.Throwable error)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (error);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onError_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_onIoScheduler_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onIoScheduler' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("onIoScheduler", "(Lio/reactivex/Scheduler;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler OnIoScheduler (global::IO.Reactivex.Scheduler defaultScheduler)
		{
			if (id_onIoScheduler_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_onIoScheduler_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "onIoScheduler", "(Lio/reactivex/Scheduler;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultScheduler);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onIoScheduler_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onNewThreadScheduler_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onNewThreadScheduler' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("onNewThreadScheduler", "(Lio/reactivex/Scheduler;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler OnNewThreadScheduler (global::IO.Reactivex.Scheduler defaultScheduler)
		{
			if (id_onNewThreadScheduler_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_onNewThreadScheduler_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "onNewThreadScheduler", "(Lio/reactivex/Scheduler;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultScheduler);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onNewThreadScheduler_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onSchedule_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onSchedule' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("onSchedule", "(Ljava/lang/Runnable;)Ljava/lang/Runnable;", "")]
		public static unsafe global::Java.Lang.IRunnable OnSchedule (global::Java.Lang.IRunnable run)
		{
			if (id_onSchedule_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_onSchedule_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "onSchedule", "(Ljava/lang/Runnable;)Ljava/lang/Runnable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (run);
				global::Java.Lang.IRunnable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onSchedule_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onSingleScheduler_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onSingleScheduler' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("onSingleScheduler", "(Lio/reactivex/Scheduler;)Lio/reactivex/Scheduler;", "")]
		public static unsafe global::IO.Reactivex.Scheduler OnSingleScheduler (global::IO.Reactivex.Scheduler defaultScheduler)
		{
			if (id_onSingleScheduler_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_onSingleScheduler_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "onSingleScheduler", "(Lio/reactivex/Scheduler;)Lio/reactivex/Scheduler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultScheduler);
				global::IO.Reactivex.Scheduler __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Scheduler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onSingleScheduler_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onSubscribe_Lio_reactivex_Completable_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onSubscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.Completable'] and parameter[2][@type='io.reactivex.CompletableObserver']]"
		[Register ("onSubscribe", "(Lio/reactivex/Completable;Lio/reactivex/CompletableObserver;)Lio/reactivex/CompletableObserver;", "")]
		public static unsafe global::IO.Reactivex.ICompletableObserver OnSubscribe (global::IO.Reactivex.Completable source, global::IO.Reactivex.ICompletableObserver observer)
		{
			if (id_onSubscribe_Lio_reactivex_Completable_Lio_reactivex_CompletableObserver_ == IntPtr.Zero)
				id_onSubscribe_Lio_reactivex_Completable_Lio_reactivex_CompletableObserver_ = JNIEnv.GetStaticMethodID (class_ref, "onSubscribe", "(Lio/reactivex/Completable;Lio/reactivex/CompletableObserver;)Lio/reactivex/CompletableObserver;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (observer);
				global::IO.Reactivex.ICompletableObserver __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ICompletableObserver> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onSubscribe_Lio_reactivex_Completable_Lio_reactivex_CompletableObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onSubscribe_Lio_reactivex_Maybe_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onSubscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.Maybe&lt;T&gt;'] and parameter[2][@type='io.reactivex.MaybeObserver&lt;? super T&gt;']]"
		[Register ("onSubscribe", "(Lio/reactivex/Maybe;Lio/reactivex/MaybeObserver;)Lio/reactivex/MaybeObserver;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.IMaybeObserver OnSubscribe (global::IO.Reactivex.Maybe source, global::IO.Reactivex.IMaybeObserver observer)
		{
			if (id_onSubscribe_Lio_reactivex_Maybe_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_onSubscribe_Lio_reactivex_Maybe_Lio_reactivex_MaybeObserver_ = JNIEnv.GetStaticMethodID (class_ref, "onSubscribe", "(Lio/reactivex/Maybe;Lio/reactivex/MaybeObserver;)Lio/reactivex/MaybeObserver;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (observer);
				global::IO.Reactivex.IMaybeObserver __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeObserver> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onSubscribe_Lio_reactivex_Maybe_Lio_reactivex_MaybeObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onSubscribe_Lio_reactivex_Observable_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onSubscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.Observable&lt;T&gt;'] and parameter[2][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("onSubscribe", "(Lio/reactivex/Observable;Lio/reactivex/Observer;)Lio/reactivex/Observer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.IObserver OnSubscribe (global::IO.Reactivex.Observable source, global::IO.Reactivex.IObserver observer)
		{
			if (id_onSubscribe_Lio_reactivex_Observable_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_onSubscribe_Lio_reactivex_Observable_Lio_reactivex_Observer_ = JNIEnv.GetStaticMethodID (class_ref, "onSubscribe", "(Lio/reactivex/Observable;Lio/reactivex/Observer;)Lio/reactivex/Observer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (observer);
				global::IO.Reactivex.IObserver __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObserver> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onSubscribe_Lio_reactivex_Observable_Lio_reactivex_Observer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onSubscribe_Lio_reactivex_Single_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='onSubscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.Single&lt;T&gt;'] and parameter[2][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
		[Register ("onSubscribe", "(Lio/reactivex/Single;Lio/reactivex/SingleObserver;)Lio/reactivex/SingleObserver;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.ISingleObserver OnSubscribe (global::IO.Reactivex.Single source, global::IO.Reactivex.ISingleObserver observer)
		{
			if (id_onSubscribe_Lio_reactivex_Single_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_onSubscribe_Lio_reactivex_Single_Lio_reactivex_SingleObserver_ = JNIEnv.GetStaticMethodID (class_ref, "onSubscribe", "(Lio/reactivex/Single;Lio/reactivex/SingleObserver;)Lio/reactivex/SingleObserver;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (observer);
				global::IO.Reactivex.ISingleObserver __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleObserver> (JNIEnv.CallStaticObjectMethod  (class_ref, id_onSubscribe_Lio_reactivex_Single_Lio_reactivex_SingleObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.plugins']/class[@name='RxJavaPlugins']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public static unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetStaticMethodID (class_ref, "reset", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reset);
			} finally {
			}
		}

	}
}
