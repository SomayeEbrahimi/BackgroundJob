using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='CallbackCompletableObserver']"
	[global::Android.Runtime.Register ("io/reactivex/internal/observers/CallbackCompletableObserver", DoNotGenerateAcw=true)]
	public sealed partial class CallbackCompletableObserver : global::Java.Util.Concurrent.Atomic.AtomicReference, global::IO.Reactivex.ICompletableObserver, global::IO.Reactivex.Disposables.IDisposable, global::IO.Reactivex.Functions.IConsumer, global::IO.Reactivex.Observers.ILambdaConsumerIntrospection {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/observers/CallbackCompletableObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallbackCompletableObserver); }
		}

		internal CallbackCompletableObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='CallbackCompletableObserver']/constructor[@name='CallbackCompletableObserver' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register (".ctor", "(Lio/reactivex/functions/Action;)V", "")]
		public unsafe CallbackCompletableObserver (global::IO.Reactivex.Functions.IAction onComplete)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onComplete);
				if (((object) this).GetType () != typeof (CallbackCompletableObserver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/functions/Action;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/functions/Action;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_functions_Action_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/functions/Action;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_functions_Action_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_functions_Action_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='CallbackCompletableObserver']/constructor[@name='CallbackCompletableObserver' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;'] and parameter[2][@type='io.reactivex.functions.Action']]"
		[Register (".ctor", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)V", "")]
		public unsafe CallbackCompletableObserver (global::IO.Reactivex.Functions.IConsumer onError, global::IO.Reactivex.Functions.IAction onComplete)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (onError);
				__args [1] = new JValue (onComplete);
				if (((object) this).GetType () != typeof (CallbackCompletableObserver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_, __args);
			} finally {
			}
		}

		static IntPtr id_hasCustomOnError;
		public unsafe bool HasCustomOnError {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='CallbackCompletableObserver']/method[@name='hasCustomOnError' and count(parameter)=0]"
			[Register ("hasCustomOnError", "()Z", "")]
			get {
				if (id_hasCustomOnError == IntPtr.Zero)
					id_hasCustomOnError = JNIEnv.GetMethodID (class_ref, "hasCustomOnError", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasCustomOnError);
				} finally {
				}
			}
		}

		static IntPtr id_isDisposed;
		public unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='CallbackCompletableObserver']/method[@name='isDisposed' and count(parameter)=0]"
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

		static IntPtr id_accept_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='CallbackCompletableObserver']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("accept", "(Ljava/lang/Throwable;)V", "")]
		public unsafe void Accept (global::Java.Lang.Throwable e)
		{
			if (id_accept_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_accept_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='CallbackCompletableObserver']/method[@name='dispose' and count(parameter)=0]"
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

		static IntPtr id_onComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='CallbackCompletableObserver']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "")]
		public unsafe void OnComplete ()
		{
			if (id_onComplete == IntPtr.Zero)
				id_onComplete = JNIEnv.GetMethodID (class_ref, "onComplete", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete);
			} finally {
			}
		}

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='CallbackCompletableObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "")]
		public unsafe void OnError (global::Java.Lang.Throwable e)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_onSubscribe_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='CallbackCompletableObserver']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("onSubscribe", "(Lio/reactivex/disposables/Disposable;)V", "")]
		public unsafe void OnSubscribe (global::IO.Reactivex.Disposables.IDisposable d)
		{
			if (id_onSubscribe_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_onSubscribe_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "onSubscribe", "(Lio/reactivex/disposables/Disposable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (d);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSubscribe_Lio_reactivex_disposables_Disposable_, __args);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated IO.Reactivex.Functions.IConsumer
		void global::IO.Reactivex.Functions.IConsumer.Accept (global::Java.Lang.Object p0)
		{
			Accept (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Throwable>(p0));
		}

	}
}
