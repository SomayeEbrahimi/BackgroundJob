using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledDirectTask']"
	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/ScheduledDirectTask", DoNotGenerateAcw=true)]
	public sealed partial class ScheduledDirectTask : global::Java.Util.Concurrent.Atomic.AtomicReference, global::Java.Util.Concurrent.ICallable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/schedulers/ScheduledDirectTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScheduledDirectTask); }
		}

		internal ScheduledDirectTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Runnable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledDirectTask']/constructor[@name='ScheduledDirectTask' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register (".ctor", "(Ljava/lang/Runnable;)V", "")]
		public unsafe ScheduledDirectTask (global::Java.Lang.IRunnable runnable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (runnable);
				if (((object) this).GetType () != typeof (ScheduledDirectTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Runnable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Runnable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Runnable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Runnable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_isDisposed;
		public unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledDirectTask']/method[@name='isDisposed' and count(parameter)=0]"
			[Register ("isDisposed", "()Z", "")]
			get {
				if (id_isDisposed == IntPtr.Zero)
					id_isDisposed = JNIEnv.GetMethodID (class_ref, "isDisposed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisposed);
				} finally {
				}
			}
		}

		static IntPtr id_getWrappedRunnable;
		public unsafe global::Java.Lang.IRunnable WrappedRunnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledDirectTask']/method[@name='getWrappedRunnable' and count(parameter)=0]"
			[Register ("getWrappedRunnable", "()Ljava/lang/Runnable;", "")]
			get {
				if (id_getWrappedRunnable == IntPtr.Zero)
					id_getWrappedRunnable = JNIEnv.GetMethodID (class_ref, "getWrappedRunnable", "()Ljava/lang/Runnable;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWrappedRunnable), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_call;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledDirectTask']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/lang/Void;", "")]
		public unsafe global::Java.Lang.Void Call ()
		{
			if (id_call == IntPtr.Zero)
				id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Void;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='AbstractDirectTask']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
			} finally {
			}
		}

		static IntPtr id_setFuture_Ljava_util_concurrent_Future_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='AbstractDirectTask']/method[@name='setFuture' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Future&lt;?&gt;']]"
		[Register ("setFuture", "(Ljava/util/concurrent/Future;)V", "")]
		public unsafe void SetFuture (global::Java.Util.Concurrent.IFuture future)
		{
			if (id_setFuture_Ljava_util_concurrent_Future_ == IntPtr.Zero)
				id_setFuture_Ljava_util_concurrent_Future_ = JNIEnv.GetMethodID (class_ref, "setFuture", "(Ljava/util/concurrent/Future;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (future);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFuture_Ljava_util_concurrent_Future_, __args);
			} finally {
			}
		}

	}
}
