using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']"
	[global::Android.Runtime.Register ("io/reactivex/internal/observers/BlockingMultiObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class BlockingMultiObserver : global::Java.Util.Concurrent.CountDownLatch, global::IO.Reactivex.ICompletableObserver, global::IO.Reactivex.IMaybeObserver, global::IO.Reactivex.ISingleObserver {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/observers/BlockingMultiObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockingMultiObserver); }
		}

		internal BlockingMultiObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']/constructor[@name='BlockingMultiObserver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlockingMultiObserver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BlockingMultiObserver)) {
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

		static IntPtr id_blockingAwait_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']/method[@name='blockingAwait' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("blockingAwait", "(JLjava/util/concurrent/TimeUnit;)Z", "")]
		public unsafe bool BlockingAwait (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_blockingAwait_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_blockingAwait_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "blockingAwait", "(JLjava/util/concurrent/TimeUnit;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_blockingAwait_JLjava_util_concurrent_TimeUnit_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_blockingGet;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']/method[@name='blockingGet' and count(parameter)=0]"
		[Register ("blockingGet", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object BlockingGet ()
		{
			if (id_blockingGet == IntPtr.Zero)
				id_blockingGet = JNIEnv.GetMethodID (class_ref, "blockingGet", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingGet), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockingGet_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']/method[@name='blockingGet' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("blockingGet", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object BlockingGet (global::Java.Lang.Object defaultValue)
		{
			if (id_blockingGet_Ljava_lang_Object_ == IntPtr.Zero)
				id_blockingGet_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "blockingGet", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultValue);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingGet_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static IntPtr id_blockingGetError;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']/method[@name='blockingGetError' and count(parameter)=0]"
		[Register ("blockingGetError", "()Ljava/lang/Throwable;", "")]
		public unsafe global::Java.Lang.Throwable BlockingGetError ()
		{
			if (id_blockingGetError == IntPtr.Zero)
				id_blockingGetError = JNIEnv.GetMethodID (class_ref, "blockingGetError", "()Ljava/lang/Throwable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingGetError), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockingGetError_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']/method[@name='blockingGetError' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("blockingGetError", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Throwable;", "")]
		public unsafe global::Java.Lang.Throwable BlockingGetError (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_blockingGetError_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_blockingGetError_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "blockingGetError", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Throwable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::Java.Lang.Throwable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingGetError_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']/method[@name='onComplete' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
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

		static IntPtr id_onSuccess_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingMultiObserver']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "")]
		public unsafe void OnSuccess (global::Java.Lang.Object value)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
