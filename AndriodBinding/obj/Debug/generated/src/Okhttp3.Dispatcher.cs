using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']"
	[global::Android.Runtime.Register ("okhttp3/Dispatcher", DoNotGenerateAcw=true)]
	public sealed partial class Dispatcher : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Dispatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Dispatcher); }
		}

		internal Dispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/constructor[@name='Dispatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Dispatcher ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Dispatcher)) {
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

		static IntPtr id_ctor_Ljava_util_concurrent_ExecutorService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/constructor[@name='Dispatcher' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutorService']]"
		[Register (".ctor", "(Ljava/util/concurrent/ExecutorService;)V", "")]
		public unsafe Dispatcher (global::Java.Util.Concurrent.IExecutorService executorService)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (executorService);
				if (((object) this).GetType () != typeof (Dispatcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/ExecutorService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/ExecutorService;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_ExecutorService_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_ExecutorService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ExecutorService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ExecutorService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_ExecutorService_, __args);
			} finally {
			}
		}

		static IntPtr id_getMaxRequests;
		static IntPtr id_setMaxRequests_I;
		public unsafe int MaxRequests {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='getMaxRequests' and count(parameter)=0]"
			[Register ("getMaxRequests", "()I", "")]
			get {
				if (id_getMaxRequests == IntPtr.Zero)
					id_getMaxRequests = JNIEnv.GetMethodID (class_ref, "getMaxRequests", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxRequests);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='setMaxRequests' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxRequests", "(I)V", "")]
			set {
				if (id_setMaxRequests_I == IntPtr.Zero)
					id_setMaxRequests_I = JNIEnv.GetMethodID (class_ref, "setMaxRequests", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxRequests_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxRequestsPerHost;
		static IntPtr id_setMaxRequestsPerHost_I;
		public unsafe int MaxRequestsPerHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='getMaxRequestsPerHost' and count(parameter)=0]"
			[Register ("getMaxRequestsPerHost", "()I", "")]
			get {
				if (id_getMaxRequestsPerHost == IntPtr.Zero)
					id_getMaxRequestsPerHost = JNIEnv.GetMethodID (class_ref, "getMaxRequestsPerHost", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxRequestsPerHost);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='setMaxRequestsPerHost' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxRequestsPerHost", "(I)V", "")]
			set {
				if (id_setMaxRequestsPerHost_I == IntPtr.Zero)
					id_setMaxRequestsPerHost_I = JNIEnv.GetMethodID (class_ref, "setMaxRequestsPerHost", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxRequestsPerHost_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_cancelAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='cancelAll' and count(parameter)=0]"
		[Register ("cancelAll", "()V", "")]
		public unsafe void CancelAll ()
		{
			if (id_cancelAll == IntPtr.Zero)
				id_cancelAll = JNIEnv.GetMethodID (class_ref, "cancelAll", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelAll);
			} finally {
			}
		}

		static IntPtr id_executorService;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='executorService' and count(parameter)=0]"
		[Register ("executorService", "()Ljava/util/concurrent/ExecutorService;", "")]
		public unsafe global::Java.Util.Concurrent.IExecutorService ExecutorService ()
		{
			if (id_executorService == IntPtr.Zero)
				id_executorService = JNIEnv.GetMethodID (class_ref, "executorService", "()Ljava/util/concurrent/ExecutorService;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_executorService), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_queuedCalls;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='queuedCalls' and count(parameter)=0]"
		[Register ("queuedCalls", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.ICall> QueuedCalls ()
		{
			if (id_queuedCalls == IntPtr.Zero)
				id_queuedCalls = JNIEnv.GetMethodID (class_ref, "queuedCalls", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Okhttp3.ICall>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queuedCalls), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_queuedCallsCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='queuedCallsCount' and count(parameter)=0]"
		[Register ("queuedCallsCount", "()I", "")]
		public unsafe int QueuedCallsCount ()
		{
			if (id_queuedCallsCount == IntPtr.Zero)
				id_queuedCallsCount = JNIEnv.GetMethodID (class_ref, "queuedCallsCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_queuedCallsCount);
			} finally {
			}
		}

		static IntPtr id_runningCalls;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='runningCalls' and count(parameter)=0]"
		[Register ("runningCalls", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.ICall> RunningCalls ()
		{
			if (id_runningCalls == IntPtr.Zero)
				id_runningCalls = JNIEnv.GetMethodID (class_ref, "runningCalls", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Okhttp3.ICall>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_runningCalls), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_runningCallsCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='runningCallsCount' and count(parameter)=0]"
		[Register ("runningCallsCount", "()I", "")]
		public unsafe int RunningCallsCount ()
		{
			if (id_runningCallsCount == IntPtr.Zero)
				id_runningCallsCount = JNIEnv.GetMethodID (class_ref, "runningCallsCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_runningCallsCount);
			} finally {
			}
		}

		static IntPtr id_setIdleCallback_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Dispatcher']/method[@name='setIdleCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setIdleCallback", "(Ljava/lang/Runnable;)V", "")]
		public unsafe void SetIdleCallback (global::Java.Lang.IRunnable idleCallback)
		{
			if (id_setIdleCallback_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setIdleCallback_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setIdleCallback", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (idleCallback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIdleCallback_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

	}
}
