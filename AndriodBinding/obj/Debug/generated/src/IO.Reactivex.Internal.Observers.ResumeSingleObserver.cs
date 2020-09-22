using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='ResumeSingleObserver']"
	[global::Android.Runtime.Register ("io/reactivex/internal/observers/ResumeSingleObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ResumeSingleObserver : global::Java.Lang.Object, global::IO.Reactivex.ISingleObserver {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/observers/ResumeSingleObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResumeSingleObserver); }
		}

		internal ResumeSingleObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='ResumeSingleObserver']/constructor[@name='ResumeSingleObserver' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.atomic.AtomicReference&lt;io.reactivex.disposables.Disposable&gt;'] and parameter[2][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
		[Register (".ctor", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/SingleObserver;)V", "")]
		public unsafe ResumeSingleObserver (global::Java.Util.Concurrent.Atomic.AtomicReference parent, global::IO.Reactivex.ISingleObserver downstream)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parent);
				__args [1] = new JValue (downstream);
				if (((object) this).GetType () != typeof (ResumeSingleObserver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/SingleObserver;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/SingleObserver;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/SingleObserver;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_SingleObserver_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='ResumeSingleObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='ResumeSingleObserver']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='ResumeSingleObserver']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
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
