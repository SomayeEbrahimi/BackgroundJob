using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleEmitter']"
	[Register ("io/reactivex/SingleEmitter", "", "IO.Reactivex.ISingleEmitterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ISingleEmitter : IJavaObject {

		bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleEmitter']/method[@name='isDisposed' and count(parameter)=0]"
			[Register ("isDisposed", "()Z", "GetIsDisposedHandler:IO.Reactivex.ISingleEmitterInvoker, AndriodBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleEmitter']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:IO.Reactivex.ISingleEmitterInvoker, AndriodBinding")]
		void OnError (global::Java.Lang.Throwable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleEmitter']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:IO.Reactivex.ISingleEmitterInvoker, AndriodBinding")]
		void OnSuccess (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleEmitter']/method[@name='setCancellable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Cancellable']]"
		[Register ("setCancellable", "(Lio/reactivex/functions/Cancellable;)V", "GetSetCancellable_Lio_reactivex_functions_Cancellable_Handler:IO.Reactivex.ISingleEmitterInvoker, AndriodBinding")]
		void SetCancellable (global::IO.Reactivex.Functions.ICancellable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleEmitter']/method[@name='setDisposable' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("setDisposable", "(Lio/reactivex/disposables/Disposable;)V", "GetSetDisposable_Lio_reactivex_disposables_Disposable_Handler:IO.Reactivex.ISingleEmitterInvoker, AndriodBinding")]
		void SetDisposable (global::IO.Reactivex.Disposables.IDisposable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleEmitter']/method[@name='tryOnError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("tryOnError", "(Ljava/lang/Throwable;)Z", "GetTryOnError_Ljava_lang_Throwable_Handler:IO.Reactivex.ISingleEmitterInvoker, AndriodBinding")]
		bool TryOnError (global::Java.Lang.Throwable p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/SingleEmitter", DoNotGenerateAcw=true)]
	internal partial class ISingleEmitterInvoker : global::Java.Lang.Object, ISingleEmitter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/SingleEmitter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISingleEmitterInvoker); }
		}

		IntPtr class_ref;

		public static ISingleEmitter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISingleEmitter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.SingleEmitter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISingleEmitterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isDisposed;
#pragma warning disable 0169
		static Delegate GetIsDisposedHandler ()
		{
			if (cb_isDisposed == null)
				cb_isDisposed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDisposed);
			return cb_isDisposed;
		}

		static bool n_IsDisposed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDisposed;
		}
#pragma warning restore 0169

		IntPtr id_isDisposed;
		public unsafe bool IsDisposed {
			get {
				if (id_isDisposed == IntPtr.Zero)
					id_isDisposed = JNIEnv.GetMethodID (class_ref, "isDisposed", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisposed);
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

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_lang_Object_);
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_;
		public unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setCancellable_Lio_reactivex_functions_Cancellable_;
#pragma warning disable 0169
		static Delegate GetSetCancellable_Lio_reactivex_functions_Cancellable_Handler ()
		{
			if (cb_setCancellable_Lio_reactivex_functions_Cancellable_ == null)
				cb_setCancellable_Lio_reactivex_functions_Cancellable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCancellable_Lio_reactivex_functions_Cancellable_);
			return cb_setCancellable_Lio_reactivex_functions_Cancellable_;
		}

		static void n_SetCancellable_Lio_reactivex_functions_Cancellable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.Functions.ICancellable)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.ICancellable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCancellable (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCancellable_Lio_reactivex_functions_Cancellable_;
		public unsafe void SetCancellable (global::IO.Reactivex.Functions.ICancellable p0)
		{
			if (id_setCancellable_Lio_reactivex_functions_Cancellable_ == IntPtr.Zero)
				id_setCancellable_Lio_reactivex_functions_Cancellable_ = JNIEnv.GetMethodID (class_ref, "setCancellable", "(Lio/reactivex/functions/Cancellable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCancellable_Lio_reactivex_functions_Cancellable_, __args);
		}

		static Delegate cb_setDisposable_Lio_reactivex_disposables_Disposable_;
#pragma warning disable 0169
		static Delegate GetSetDisposable_Lio_reactivex_disposables_Disposable_Handler ()
		{
			if (cb_setDisposable_Lio_reactivex_disposables_Disposable_ == null)
				cb_setDisposable_Lio_reactivex_disposables_Disposable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDisposable_Lio_reactivex_disposables_Disposable_);
			return cb_setDisposable_Lio_reactivex_disposables_Disposable_;
		}

		static void n_SetDisposable_Lio_reactivex_disposables_Disposable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.Disposables.IDisposable)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDisposable (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDisposable_Lio_reactivex_disposables_Disposable_;
		public unsafe void SetDisposable (global::IO.Reactivex.Disposables.IDisposable p0)
		{
			if (id_setDisposable_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_setDisposable_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "setDisposable", "(Lio/reactivex/disposables/Disposable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisposable_Lio_reactivex_disposables_Disposable_, __args);
		}

		static Delegate cb_tryOnError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetTryOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_tryOnError_Ljava_lang_Throwable_ == null)
				cb_tryOnError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_TryOnError_Ljava_lang_Throwable_);
			return cb_tryOnError_Ljava_lang_Throwable_;
		}

		static bool n_TryOnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TryOnError (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_tryOnError_Ljava_lang_Throwable_;
		public unsafe bool TryOnError (global::Java.Lang.Throwable p0)
		{
			if (id_tryOnError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_tryOnError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "tryOnError", "(Ljava/lang/Throwable;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_tryOnError_Ljava_lang_Throwable_, __args);
			return __ret;
		}

	}

}
