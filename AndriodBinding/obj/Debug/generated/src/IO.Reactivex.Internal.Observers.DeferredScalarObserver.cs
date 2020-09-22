using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarObserver']"
	[global::Android.Runtime.Register ("io/reactivex/internal/observers/DeferredScalarObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public abstract partial class DeferredScalarObserver : global::IO.Reactivex.Internal.Observers.DeferredScalarDisposable, global::IO.Reactivex.IObserver {


		static IntPtr upstream_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarObserver']/field[@name='upstream']"
		[Register ("upstream")]
		protected global::IO.Reactivex.Disposables.IDisposable Upstream {
			get {
				if (upstream_jfieldId == IntPtr.Zero)
					upstream_jfieldId = JNIEnv.GetFieldID (class_ref, "upstream", "Lio/reactivex/disposables/Disposable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, upstream_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (upstream_jfieldId == IntPtr.Zero)
					upstream_jfieldId = JNIEnv.GetFieldID (class_ref, "upstream", "Lio/reactivex/disposables/Disposable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, upstream_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/observers/DeferredScalarObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeferredScalarObserver); }
		}

		protected DeferredScalarObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_Observer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarObserver']/constructor[@name='DeferredScalarObserver' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super R&gt;']]"
		[Register (".ctor", "(Lio/reactivex/Observer;)V", "")]
		public unsafe DeferredScalarObserver (global::IO.Reactivex.IObserver downstream)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (downstream);
				if (((object) this).GetType () != typeof (DeferredScalarObserver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/Observer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/Observer;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_Observer_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/Observer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_Observer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

		static Delegate cb_onComplete;
#pragma warning disable 0169
		static Delegate GetOnCompleteHandler ()
		{
			if (cb_onComplete == null)
				cb_onComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnComplete);
			return cb_onComplete;
		}

		static void n_OnComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.DeferredScalarObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete ();
		}
#pragma warning restore 0169

		static IntPtr id_onComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarObserver']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler")]
		public virtual unsafe void OnComplete ()
		{
			if (id_onComplete == IntPtr.Zero)
				id_onComplete = JNIEnv.GetMethodID (class_ref, "onComplete", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onComplete", "()V"));
			} finally {
			}
		}

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.DeferredScalarObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.OnError (t);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void OnError (global::Java.Lang.Throwable t)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSubscribe_Lio_reactivex_disposables_Disposable_;
#pragma warning disable 0169
		static Delegate GetOnSubscribe_Lio_reactivex_disposables_Disposable_Handler ()
		{
			if (cb_onSubscribe_Lio_reactivex_disposables_Disposable_ == null)
				cb_onSubscribe_Lio_reactivex_disposables_Disposable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSubscribe_Lio_reactivex_disposables_Disposable_);
			return cb_onSubscribe_Lio_reactivex_disposables_Disposable_;
		}

		static void n_OnSubscribe_Lio_reactivex_disposables_Disposable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.DeferredScalarObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var d = (global::IO.Reactivex.Disposables.IDisposable)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (native_d, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscribe (d);
		}
#pragma warning restore 0169

		static IntPtr id_onSubscribe_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarObserver']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("onSubscribe", "(Lio/reactivex/disposables/Disposable;)V", "GetOnSubscribe_Lio_reactivex_disposables_Disposable_Handler")]
		public virtual unsafe void OnSubscribe (global::IO.Reactivex.Disposables.IDisposable d)
		{
			if (id_onSubscribe_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_onSubscribe_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "onSubscribe", "(Lio/reactivex/disposables/Disposable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (d);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSubscribe_Lio_reactivex_disposables_Disposable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSubscribe", "(Lio/reactivex/disposables/Disposable;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/observers/DeferredScalarObserver", DoNotGenerateAcw=true)]
	internal partial class DeferredScalarObserverInvoker : DeferredScalarObserver, global::IO.Reactivex.IObserver {

		public DeferredScalarObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeferredScalarObserverInvoker); }
		}

	}

}
