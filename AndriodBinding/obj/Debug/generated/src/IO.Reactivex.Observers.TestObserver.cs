using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']"
	[global::Android.Runtime.Register ("io/reactivex/observers/TestObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class TestObserver : global::IO.Reactivex.Observers.BaseTestConsumer, global::IO.Reactivex.ICompletableObserver, global::IO.Reactivex.IMaybeObserver, global::IO.Reactivex.IObserver, global::IO.Reactivex.ISingleObserver, global::IO.Reactivex.Disposables.IDisposable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/observers/TestObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TestObserver); }
		}

		protected TestObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/constructor[@name='TestObserver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestObserver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TestObserver)) {
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

		static IntPtr id_ctor_Lio_reactivex_Observer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/constructor[@name='TestObserver' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register (".ctor", "(Lio/reactivex/Observer;)V", "")]
		public unsafe TestObserver (global::IO.Reactivex.IObserver downstream)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (downstream);
				if (((object) this).GetType () != typeof (TestObserver)) {
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

		static IntPtr id_hasSubscription;
		public unsafe bool HasSubscription {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='hasSubscription' and count(parameter)=0]"
			[Register ("hasSubscription", "()Z", "")]
			get {
				if (id_hasSubscription == IntPtr.Zero)
					id_hasSubscription = JNIEnv.GetMethodID (class_ref, "hasSubscription", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasSubscription);
				} finally {
				}
			}
		}

		static IntPtr id_isCancelled;
		public unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "")]
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCancelled);
				} finally {
				}
			}
		}

		static IntPtr id_isDisposed;
		public override unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='isDisposed' and count(parameter)=0]"
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

		static IntPtr id_assertNotSubscribed;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='assertNotSubscribed' and count(parameter)=0]"
		[Register ("assertNotSubscribed", "()Lio/reactivex/observers/TestObserver;", "")]
		public unsafe global::IO.Reactivex.Observers.TestObserver AssertNotSubscribed ()
		{
			if (id_assertNotSubscribed == IntPtr.Zero)
				id_assertNotSubscribed = JNIEnv.GetMethodID (class_ref, "assertNotSubscribed", "()Lio/reactivex/observers/TestObserver;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertNotSubscribed), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertOf_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='assertOf' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.observers.TestObserver&lt;T&gt;&gt;']]"
		[Register ("assertOf", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/observers/TestObserver;", "")]
		public unsafe global::IO.Reactivex.Observers.TestObserver AssertOf (global::IO.Reactivex.Functions.IConsumer check)
		{
			if (id_assertOf_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_assertOf_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "assertOf", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/observers/TestObserver;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (check);
				global::IO.Reactivex.Observers.TestObserver __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertOf_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_assertSubscribed;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='assertSubscribed' and count(parameter)=0]"
		[Register ("assertSubscribed", "()Lio/reactivex/observers/TestObserver;", "")]
		public unsafe global::IO.Reactivex.Observers.TestObserver AssertSubscribed ()
		{
			if (id_assertSubscribed == IntPtr.Zero)
				id_assertSubscribed = JNIEnv.GetMethodID (class_ref, "assertSubscribed", "()Lio/reactivex/observers/TestObserver;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertSubscribed), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
			} finally {
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lio/reactivex/observers/TestObserver;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observers.TestObserver Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lio/reactivex/observers/TestObserver;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='create' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("create", "(Lio/reactivex/Observer;)Lio/reactivex/observers/TestObserver;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observers.TestObserver Create (global::IO.Reactivex.IObserver @delegate)
		{
			if (id_create_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_create_Lio_reactivex_Observer_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lio/reactivex/Observer;)Lio/reactivex/observers/TestObserver;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@delegate);
				global::IO.Reactivex.Observers.TestObserver __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lio_reactivex_Observer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public override sealed unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete ();
		}
#pragma warning restore 0169

		static IntPtr id_onComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='onComplete' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.OnError (t);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
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

		static Delegate cb_onNext_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnNext_Ljava_lang_Object_Handler ()
		{
			if (cb_onNext_Ljava_lang_Object_ == null)
				cb_onNext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnNext_Ljava_lang_Object_);
			return cb_onNext_Ljava_lang_Object_;
		}

		static void n_OnNext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.OnNext (t);
		}
#pragma warning restore 0169

		static IntPtr id_onNext_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='onNext' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onNext", "(Ljava/lang/Object;)V", "GetOnNext_Ljava_lang_Object_Handler")]
		public virtual unsafe void OnNext (global::Java.Lang.Object t)
		{
			if (id_onNext_Ljava_lang_Object_ == IntPtr.Zero)
				id_onNext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onNext", "(Ljava/lang/Object;)V");
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_t);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNext_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNext", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_t);
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var d = (global::IO.Reactivex.Disposables.IDisposable)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (native_d, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscribe (d);
		}
#pragma warning restore 0169

		static IntPtr id_onSubscribe_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
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

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_lang_Object_);
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (value);
		}
#pragma warning restore 0169

		static IntPtr id_onSuccess_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='TestObserver']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler")]
		public virtual unsafe void OnSuccess (global::Java.Lang.Object value)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSuccess", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
