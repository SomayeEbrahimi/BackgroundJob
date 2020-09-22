using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='LambdaObserver']"
	[global::Android.Runtime.Register ("io/reactivex/internal/observers/LambdaObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class LambdaObserver : global::Java.Util.Concurrent.Atomic.AtomicReference, global::IO.Reactivex.IObserver, global::IO.Reactivex.Disposables.IDisposable, global::IO.Reactivex.Observers.ILambdaConsumerIntrospection {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/observers/LambdaObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LambdaObserver); }
		}

		internal LambdaObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='LambdaObserver']/constructor[@name='LambdaObserver' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;'] and parameter[3][@type='io.reactivex.functions.Action'] and parameter[4][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register (".ctor", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Consumer;)V", "")]
		public unsafe LambdaObserver (global::IO.Reactivex.Functions.IConsumer onNext, global::IO.Reactivex.Functions.IConsumer onError, global::IO.Reactivex.Functions.IAction onComplete, global::IO.Reactivex.Functions.IConsumer onSubscribe)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (onNext);
				__args [1] = new JValue (onError);
				__args [2] = new JValue (onComplete);
				__args [3] = new JValue (onSubscribe);
				if (((object) this).GetType () != typeof (LambdaObserver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Consumer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Consumer;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Consumer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_, __args);
			} finally {
			}
		}

		static IntPtr id_hasCustomOnError;
		public unsafe bool HasCustomOnError {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='LambdaObserver']/method[@name='hasCustomOnError' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='LambdaObserver']/method[@name='isDisposed' and count(parameter)=0]"
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

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='LambdaObserver']/method[@name='dispose' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='LambdaObserver']/method[@name='onComplete' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='LambdaObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "")]
		public unsafe void OnError (global::Java.Lang.Throwable t)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_onNext_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='LambdaObserver']/method[@name='onNext' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onNext", "(Ljava/lang/Object;)V", "")]
		public unsafe void OnNext (global::Java.Lang.Object t)
		{
			if (id_onNext_Ljava_lang_Object_ == IntPtr.Zero)
				id_onNext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onNext", "(Ljava/lang/Object;)V");
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNext_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_t);
			}
		}

		static IntPtr id_onSubscribe_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='LambdaObserver']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
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

	}
}
