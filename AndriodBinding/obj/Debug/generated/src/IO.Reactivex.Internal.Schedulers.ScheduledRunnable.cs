using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledRunnable']"
	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/ScheduledRunnable", DoNotGenerateAcw=true)]
	public sealed partial class ScheduledRunnable : global::Java.Util.Concurrent.Atomic.AtomicReferenceArray, global::IO.Reactivex.Disposables.IDisposable, global::Java.Lang.IRunnable, global::Java.Util.Concurrent.ICallable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/schedulers/ScheduledRunnable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScheduledRunnable); }
		}

		internal ScheduledRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Runnable_Lio_reactivex_internal_disposables_DisposableContainer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledRunnable']/constructor[@name='ScheduledRunnable' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='io.reactivex.internal.disposables.DisposableContainer']]"
		[Register (".ctor", "(Ljava/lang/Runnable;Lio/reactivex/internal/disposables/DisposableContainer;)V", "")]
		public unsafe ScheduledRunnable (global::Java.Lang.IRunnable actual, global::IO.Reactivex.Internal.Disposables.IDisposableContainer parent)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (actual);
				__args [1] = new JValue (parent);
				if (((object) this).GetType () != typeof (ScheduledRunnable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Runnable;Lio/reactivex/internal/disposables/DisposableContainer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Runnable;Lio/reactivex/internal/disposables/DisposableContainer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Runnable_Lio_reactivex_internal_disposables_DisposableContainer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Runnable_Lio_reactivex_internal_disposables_DisposableContainer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Runnable;Lio/reactivex/internal/disposables/DisposableContainer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Runnable_Lio_reactivex_internal_disposables_DisposableContainer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Runnable_Lio_reactivex_internal_disposables_DisposableContainer_, __args);
			} finally {
			}
		}

		static IntPtr id_isDisposed;
		public unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledRunnable']/method[@name='isDisposed' and count(parameter)=0]"
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

		static IntPtr id_call;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledRunnable']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Call ()
		{
			if (id_call == IntPtr.Zero)
				id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledRunnable']/method[@name='dispose' and count(parameter)=0]"
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

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledRunnable']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "")]
		public unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
			} finally {
			}
		}

		static IntPtr id_setFuture_Ljava_util_concurrent_Future_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.schedulers']/class[@name='ScheduledRunnable']/method[@name='setFuture' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Future&lt;?&gt;']]"
		[Register ("setFuture", "(Ljava/util/concurrent/Future;)V", "")]
		public unsafe void SetFuture (global::Java.Util.Concurrent.IFuture f)
		{
			if (id_setFuture_Ljava_util_concurrent_Future_ == IntPtr.Zero)
				id_setFuture_Ljava_util_concurrent_Future_ = JNIEnv.GetMethodID (class_ref, "setFuture", "(Ljava/util/concurrent/Future;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFuture_Ljava_util_concurrent_Future_, __args);
			} finally {
			}
		}

	}
}
