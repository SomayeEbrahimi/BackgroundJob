using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Subjects {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']"
	[global::Android.Runtime.Register ("io/reactivex/subjects/Subject", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class Subject : global::IO.Reactivex.Observable, global::IO.Reactivex.IObserver {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/subjects/Subject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Subject); }
		}

		protected Subject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']/constructor[@name='Subject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Subject ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Subject)) {
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

		static Delegate cb_hasComplete;
#pragma warning disable 0169
		static Delegate GetHasCompleteHandler ()
		{
			if (cb_hasComplete == null)
				cb_hasComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasComplete);
			return cb_hasComplete;
		}

		static bool n_HasComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.Subject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasComplete;
		}
#pragma warning restore 0169

		public abstract bool HasComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']/method[@name='hasComplete' and count(parameter)=0]"
			[Register ("hasComplete", "()Z", "GetHasCompleteHandler")] get;
		}

		static Delegate cb_hasObservers;
#pragma warning disable 0169
		static Delegate GetHasObserversHandler ()
		{
			if (cb_hasObservers == null)
				cb_hasObservers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasObservers);
			return cb_hasObservers;
		}

		static bool n_HasObservers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.Subject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasObservers;
		}
#pragma warning restore 0169

		public abstract bool HasObservers {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']/method[@name='hasObservers' and count(parameter)=0]"
			[Register ("hasObservers", "()Z", "GetHasObserversHandler")] get;
		}

		static Delegate cb_hasThrowable;
#pragma warning disable 0169
		static Delegate GetHasThrowableHandler ()
		{
			if (cb_hasThrowable == null)
				cb_hasThrowable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasThrowable);
			return cb_hasThrowable;
		}

		static bool n_HasThrowable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.Subject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasThrowable;
		}
#pragma warning restore 0169

		public abstract bool HasThrowable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']/method[@name='hasThrowable' and count(parameter)=0]"
			[Register ("hasThrowable", "()Z", "GetHasThrowableHandler")] get;
		}

		static Delegate cb_getThrowable;
#pragma warning disable 0169
		static Delegate GetGetThrowableHandler ()
		{
			if (cb_getThrowable == null)
				cb_getThrowable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThrowable);
			return cb_getThrowable;
		}

		static IntPtr n_GetThrowable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.Subject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Throwable);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']/method[@name='getThrowable' and count(parameter)=0]"
			[Register ("getThrowable", "()Ljava/lang/Throwable;", "GetGetThrowableHandler")] get;
		}

		static IntPtr id_toSerialized;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']/method[@name='toSerialized' and count(parameter)=0]"
		[Register ("toSerialized", "()Lio/reactivex/subjects/Subject;", "")]
		public unsafe global::IO.Reactivex.Subjects.Subject ToSerialized ()
		{
			if (id_toSerialized == IntPtr.Zero)
				id_toSerialized = JNIEnv.GetMethodID (class_ref, "toSerialized", "()Lio/reactivex/subjects/Subject;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.Subject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toSerialized), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.Subject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.Subject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='Observer']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler")]
		public abstract void OnError (global::Java.Lang.Throwable p0);

		static Delegate cb_onSubscribe_Lio_reactivex_disposables_Disposable_;
#pragma warning disable 0169
		static Delegate GetOnSubscribe_Lio_reactivex_disposables_Disposable_Handler ()
		{
			if (cb_onSubscribe_Lio_reactivex_disposables_Disposable_ == null)
				cb_onSubscribe_Lio_reactivex_disposables_Disposable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSubscribe_Lio_reactivex_disposables_Disposable_);
			return cb_onSubscribe_Lio_reactivex_disposables_Disposable_;
		}

		static void n_OnSubscribe_Lio_reactivex_disposables_Disposable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.Subject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.Disposables.IDisposable)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscribe (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='Observer']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("onSubscribe", "(Lio/reactivex/disposables/Disposable;)V", "GetOnSubscribe_Lio_reactivex_disposables_Disposable_Handler")]
		public abstract void OnSubscribe (global::IO.Reactivex.Disposables.IDisposable p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/subjects/Subject", DoNotGenerateAcw=true)]
	internal partial class SubjectInvoker : Subject, global::IO.Reactivex.IObserver {

		public SubjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubjectInvoker); }
		}

		static IntPtr id_hasComplete;
		public override unsafe bool HasComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']/method[@name='hasComplete' and count(parameter)=0]"
			[Register ("hasComplete", "()Z", "GetHasCompleteHandler")]
			get {
				if (id_hasComplete == IntPtr.Zero)
					id_hasComplete = JNIEnv.GetMethodID (class_ref, "hasComplete", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasComplete);
				} finally {
				}
			}
		}

		static IntPtr id_hasObservers;
		public override unsafe bool HasObservers {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']/method[@name='hasObservers' and count(parameter)=0]"
			[Register ("hasObservers", "()Z", "GetHasObserversHandler")]
			get {
				if (id_hasObservers == IntPtr.Zero)
					id_hasObservers = JNIEnv.GetMethodID (class_ref, "hasObservers", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasObservers);
				} finally {
				}
			}
		}

		static IntPtr id_hasThrowable;
		public override unsafe bool HasThrowable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']/method[@name='hasThrowable' and count(parameter)=0]"
			[Register ("hasThrowable", "()Z", "GetHasThrowableHandler")]
			get {
				if (id_hasThrowable == IntPtr.Zero)
					id_hasThrowable = JNIEnv.GetMethodID (class_ref, "hasThrowable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasThrowable);
				} finally {
				}
			}
		}

		static IntPtr id_getThrowable;
		public override unsafe global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='Subject']/method[@name='getThrowable' and count(parameter)=0]"
			[Register ("getThrowable", "()Ljava/lang/Throwable;", "GetGetThrowableHandler")]
			get {
				if (id_getThrowable == IntPtr.Zero)
					id_getThrowable = JNIEnv.GetMethodID (class_ref, "getThrowable", "()Ljava/lang/Throwable;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThrowable), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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

		static IntPtr id_onSubscribe_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='Observer']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("onSubscribe", "(Lio/reactivex/disposables/Disposable;)V", "GetOnSubscribe_Lio_reactivex_disposables_Disposable_Handler")]
		public override unsafe void OnSubscribe (global::IO.Reactivex.Disposables.IDisposable p0)
		{
			if (id_onSubscribe_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_onSubscribe_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "onSubscribe", "(Lio/reactivex/disposables/Disposable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSubscribe_Lio_reactivex_disposables_Disposable_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/Observer;)V", "GetSubscribeActual_Lio_reactivex_Observer_Handler")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IObserver p0)
		{
			if (id_subscribeActual_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

	}

}
