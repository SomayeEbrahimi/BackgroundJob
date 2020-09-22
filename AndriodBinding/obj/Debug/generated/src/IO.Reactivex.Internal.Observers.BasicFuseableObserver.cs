using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']"
	[global::Android.Runtime.Register ("io/reactivex/internal/observers/BasicFuseableObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public abstract partial class BasicFuseableObserver : global::Java.Lang.Object, global::IO.Reactivex.IObserver, global::IO.Reactivex.Internal.Fuseable.IQueueDisposable {


		static IntPtr done_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/field[@name='done']"
		[Register ("done")]
		protected bool Done {
			get {
				if (done_jfieldId == IntPtr.Zero)
					done_jfieldId = JNIEnv.GetFieldID (class_ref, "done", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, done_jfieldId);
			}
			set {
				if (done_jfieldId == IntPtr.Zero)
					done_jfieldId = JNIEnv.GetFieldID (class_ref, "done", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, done_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr downstream_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/field[@name='downstream']"
		[Register ("downstream")]
		protected global::IO.Reactivex.IObserver Downstream {
			get {
				if (downstream_jfieldId == IntPtr.Zero)
					downstream_jfieldId = JNIEnv.GetFieldID (class_ref, "downstream", "Lio/reactivex/Observer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, downstream_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObserver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (downstream_jfieldId == IntPtr.Zero)
					downstream_jfieldId = JNIEnv.GetFieldID (class_ref, "downstream", "Lio/reactivex/Observer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, downstream_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr qd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/field[@name='qd']"
		[Register ("qd")]
		protected global::IO.Reactivex.Internal.Fuseable.IQueueDisposable Qd {
			get {
				if (qd_jfieldId == IntPtr.Zero)
					qd_jfieldId = JNIEnv.GetFieldID (class_ref, "qd", "Lio/reactivex/internal/fuseable/QueueDisposable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, qd_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IQueueDisposable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (qd_jfieldId == IntPtr.Zero)
					qd_jfieldId = JNIEnv.GetFieldID (class_ref, "qd", "Lio/reactivex/internal/fuseable/QueueDisposable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, qd_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sourceMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/field[@name='sourceMode']"
		[Register ("sourceMode")]
		protected int SourceMode {
			get {
				if (sourceMode_jfieldId == IntPtr.Zero)
					sourceMode_jfieldId = JNIEnv.GetFieldID (class_ref, "sourceMode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sourceMode_jfieldId);
			}
			set {
				if (sourceMode_jfieldId == IntPtr.Zero)
					sourceMode_jfieldId = JNIEnv.GetFieldID (class_ref, "sourceMode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sourceMode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr upstream_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/field[@name='upstream']"
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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/observers/BasicFuseableObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicFuseableObserver); }
		}

		protected BasicFuseableObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_Observer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/constructor[@name='BasicFuseableObserver' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super R&gt;']]"
		[Register (".ctor", "(Lio/reactivex/Observer;)V", "")]
		public unsafe BasicFuseableObserver (global::IO.Reactivex.IObserver downstream)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (downstream);
				if (((object) this).GetType () != typeof (BasicFuseableObserver)) {
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.BasicFuseableObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDisposed;
		}
#pragma warning restore 0169

		static IntPtr id_isDisposed;
		public virtual unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='isDisposed' and count(parameter)=0]"
			[Register ("isDisposed", "()Z", "GetIsDisposedHandler")]
			get {
				if (id_isDisposed == IntPtr.Zero)
					id_isDisposed = JNIEnv.GetMethodID (class_ref, "isDisposed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisposed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDisposed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.BasicFuseableObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_afterDownstream;
#pragma warning disable 0169
		static Delegate GetAfterDownstreamHandler ()
		{
			if (cb_afterDownstream == null)
				cb_afterDownstream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_AfterDownstream);
			return cb_afterDownstream;
		}

		static void n_AfterDownstream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.BasicFuseableObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AfterDownstream ();
		}
#pragma warning restore 0169

		static IntPtr id_afterDownstream;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='afterDownstream' and count(parameter)=0]"
		[Register ("afterDownstream", "()V", "GetAfterDownstreamHandler")]
		protected virtual unsafe void AfterDownstream ()
		{
			if (id_afterDownstream == IntPtr.Zero)
				id_afterDownstream = JNIEnv.GetMethodID (class_ref, "afterDownstream", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_afterDownstream);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "afterDownstream", "()V"));
			} finally {
			}
		}

		static Delegate cb_beforeDownstream;
#pragma warning disable 0169
		static Delegate GetBeforeDownstreamHandler ()
		{
			if (cb_beforeDownstream == null)
				cb_beforeDownstream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_BeforeDownstream);
			return cb_beforeDownstream;
		}

		static bool n_BeforeDownstream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.BasicFuseableObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BeforeDownstream ();
		}
#pragma warning restore 0169

		static IntPtr id_beforeDownstream;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='beforeDownstream' and count(parameter)=0]"
		[Register ("beforeDownstream", "()Z", "GetBeforeDownstreamHandler")]
		protected virtual unsafe bool BeforeDownstream ()
		{
			if (id_beforeDownstream == IntPtr.Zero)
				id_beforeDownstream = JNIEnv.GetMethodID (class_ref, "beforeDownstream", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_beforeDownstream);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beforeDownstream", "()Z"));
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.BasicFuseableObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.BasicFuseableObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

		static IntPtr id_fail_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='fail' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("fail", "(Ljava/lang/Throwable;)V", "")]
		protected unsafe void Fail (global::Java.Lang.Throwable t)
		{
			if (id_fail_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_fail_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "fail", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fail_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_offer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='offer' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("offer", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Offer (global::Java.Lang.Object e)
		{
			if (id_offer_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;)Z");
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_e);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static IntPtr id_offer_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='offer' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='R']]"
		[Register ("offer", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public unsafe bool Offer (global::Java.Lang.Object v1, global::Java.Lang.Object v2)
		{
			if (id_offer_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			IntPtr native_v1 = JNIEnv.ToLocalJniHandle (v1);
			IntPtr native_v2 = JNIEnv.ToLocalJniHandle (v2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_v1);
				__args [1] = new JValue (native_v2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_v1);
				JNIEnv.DeleteLocalRef (native_v2);
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.BasicFuseableObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete ();
		}
#pragma warning restore 0169

		static IntPtr id_onComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='onComplete' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.BasicFuseableObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.OnError (t);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
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

		static IntPtr id_onSubscribe_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
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

		static IntPtr id_transitiveBoundaryFusion_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BasicFuseableObserver']/method[@name='transitiveBoundaryFusion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("transitiveBoundaryFusion", "(I)I", "")]
		protected unsafe int TransitiveBoundaryFusion (int mode)
		{
			if (id_transitiveBoundaryFusion_I == IntPtr.Zero)
				id_transitiveBoundaryFusion_I = JNIEnv.GetMethodID (class_ref, "transitiveBoundaryFusion", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mode);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_transitiveBoundaryFusion_I, __args);
			} finally {
			}
		}

		static Delegate cb_requestFusion_I;
#pragma warning disable 0169
		static Delegate GetRequestFusion_IHandler ()
		{
			if (cb_requestFusion_I == null)
				cb_requestFusion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_RequestFusion_I);
			return cb_requestFusion_I;
		}

		static int n_RequestFusion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.BasicFuseableObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestFusion (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='QueueFuseable']/method[@name='requestFusion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestFusion", "(I)I", "GetRequestFusion_IHandler")]
		public abstract int RequestFusion (int p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/observers/BasicFuseableObserver", DoNotGenerateAcw=true)]
	internal partial class BasicFuseableObserverInvoker : BasicFuseableObserver, global::IO.Reactivex.IObserver, global::IO.Reactivex.Internal.Fuseable.IQueueDisposable, global::IO.Reactivex.Internal.Fuseable.IQueueFuseable, global::IO.Reactivex.Internal.Fuseable.ISimpleQueue {

		public BasicFuseableObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicFuseableObserverInvoker); }
		}

		static IntPtr id_requestFusion_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='QueueFuseable']/method[@name='requestFusion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestFusion", "(I)I", "GetRequestFusion_IHandler")]
		public override unsafe int RequestFusion (int p0)
		{
			if (id_requestFusion_I == IntPtr.Zero)
				id_requestFusion_I = JNIEnv.GetMethodID (class_ref, "requestFusion", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_requestFusion_I, __args);
			} finally {
			}
		}

	}

}
