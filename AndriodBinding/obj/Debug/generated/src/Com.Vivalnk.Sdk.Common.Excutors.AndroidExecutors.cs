using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Excutors {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='AndroidExecutors']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/excutors/AndroidExecutors", DoNotGenerateAcw=true)]
	public sealed partial class AndroidExecutors : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/excutors/AndroidExecutors", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidExecutors); }
		}

		internal AndroidExecutors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_allowCoreThreadTimeout_Ljava_util_concurrent_ThreadPoolExecutor_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='AndroidExecutors']/method[@name='allowCoreThreadTimeout' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.ThreadPoolExecutor'] and parameter[2][@type='boolean']]"
		[Register ("allowCoreThreadTimeout", "(Ljava/util/concurrent/ThreadPoolExecutor;Z)V", "")]
		public static unsafe void AllowCoreThreadTimeout (global::Java.Util.Concurrent.ThreadPoolExecutor executor, bool value)
		{
			if (id_allowCoreThreadTimeout_Ljava_util_concurrent_ThreadPoolExecutor_Z == IntPtr.Zero)
				id_allowCoreThreadTimeout_Ljava_util_concurrent_ThreadPoolExecutor_Z = JNIEnv.GetStaticMethodID (class_ref, "allowCoreThreadTimeout", "(Ljava/util/concurrent/ThreadPoolExecutor;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (executor);
				__args [1] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_allowCoreThreadTimeout_Ljava_util_concurrent_ThreadPoolExecutor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_newCachedThreadPool;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='AndroidExecutors']/method[@name='newCachedThreadPool' and count(parameter)=0]"
		[Register ("newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutorService NewCachedThreadPool ()
		{
			if (id_newCachedThreadPool == IntPtr.Zero)
				id_newCachedThreadPool = JNIEnv.GetStaticMethodID (class_ref, "newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newCachedThreadPool), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newCachedThreadPool_Ljava_util_concurrent_ThreadFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='AndroidExecutors']/method[@name='newCachedThreadPool' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
		[Register ("newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutorService NewCachedThreadPool (global::Java.Util.Concurrent.IThreadFactory threadFactory)
		{
			if (id_newCachedThreadPool_Ljava_util_concurrent_ThreadFactory_ == IntPtr.Zero)
				id_newCachedThreadPool_Ljava_util_concurrent_ThreadFactory_ = JNIEnv.GetStaticMethodID (class_ref, "newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threadFactory);
				global::Java.Util.Concurrent.IExecutorService __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newCachedThreadPool_Ljava_util_concurrent_ThreadFactory_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_uiThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='AndroidExecutors']/method[@name='uiThread' and count(parameter)=0]"
		[Register ("uiThread", "()Ljava/util/concurrent/Executor;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutor UiThread ()
		{
			if (id_uiThread == IntPtr.Zero)
				id_uiThread = JNIEnv.GetStaticMethodID (class_ref, "uiThread", "()Ljava/util/concurrent/Executor;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_uiThread), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
