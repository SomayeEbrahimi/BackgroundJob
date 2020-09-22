using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.observers']/class[@name='ResourceObserver']"
	[global::Android.Runtime.Register ("io/reactivex/observers/ResourceObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class ResourceObserver : global::Java.Lang.Object, global::IO.Reactivex.IObserver, global::IO.Reactivex.Disposables.IDisposable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/observers/ResourceObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceObserver); }
		}

		protected ResourceObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.observers']/class[@name='ResourceObserver']/constructor[@name='ResourceObserver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResourceObserver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ResourceObserver)) {
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

		static IntPtr id_isDisposed;
		public unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='ResourceObserver']/method[@name='isDisposed' and count(parameter)=0]"
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

		static IntPtr id_add_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='ResourceObserver']/method[@name='add' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("add", "(Lio/reactivex/disposables/Disposable;)V", "")]
		public unsafe void Add (global::IO.Reactivex.Disposables.IDisposable resource)
		{
			if (id_add_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_add_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "add", "(Lio/reactivex/disposables/Disposable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resource);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lio_reactivex_disposables_Disposable_, __args);
			} finally {
			}
		}

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='ResourceObserver']/method[@name='dispose' and count(parameter)=0]"
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

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.ResourceObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='ResourceObserver']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		protected virtual unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "()V"));
			} finally {
			}
		}

		static IntPtr id_onSubscribe_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='ResourceObserver']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.ResourceObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='Observer']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler")]
		public abstract void OnComplete ();

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.ResourceObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='Observer']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler")]
		public abstract void OnError (global::Java.Lang.Throwable p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/observers/ResourceObserver", DoNotGenerateAcw=true)]
	internal partial class ResourceObserverInvoker : ResourceObserver, global::IO.Reactivex.IObserver {

		public ResourceObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceObserverInvoker); }
		}

		static IntPtr id_onComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='Observer']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler")]
		public override unsafe void OnComplete ()
		{
			if (id_onComplete == IntPtr.Zero)
				id_onComplete = JNIEnv.GetMethodID (class_ref, "onComplete", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete);
			} finally {
			}
		}

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='Observer']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler")]
		public override unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

	}

}
