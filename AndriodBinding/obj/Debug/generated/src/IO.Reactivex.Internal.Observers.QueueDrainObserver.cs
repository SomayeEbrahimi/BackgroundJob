using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']"
	[global::Android.Runtime.Register ("io/reactivex/internal/observers/QueueDrainObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U", "V"})]
	public abstract partial class QueueDrainObserver : global::Java.Lang.Object, global::IO.Reactivex.IObserver, global::IO.Reactivex.Internal.Util.IObservableQueueDrain {


		static IntPtr downstream_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/field[@name='downstream']"
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

		static IntPtr queue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/field[@name='queue']"
		[Register ("queue")]
		protected global::IO.Reactivex.Internal.Fuseable.ISimplePlainQueue Queue {
			get {
				if (queue_jfieldId == IntPtr.Zero)
					queue_jfieldId = JNIEnv.GetFieldID (class_ref, "queue", "Lio/reactivex/internal/fuseable/SimplePlainQueue;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, queue_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.ISimplePlainQueue> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (queue_jfieldId == IntPtr.Zero)
					queue_jfieldId = JNIEnv.GetFieldID (class_ref, "queue", "Lio/reactivex/internal/fuseable/SimplePlainQueue;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, queue_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/observers/QueueDrainObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueueDrainObserver); }
		}

		protected QueueDrainObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_Observer_Lio_reactivex_internal_fuseable_SimplePlainQueue_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/constructor[@name='QueueDrainObserver' and count(parameter)=2 and parameter[1][@type='io.reactivex.Observer&lt;? super V&gt;'] and parameter[2][@type='io.reactivex.internal.fuseable.SimplePlainQueue&lt;U&gt;']]"
		[Register (".ctor", "(Lio/reactivex/Observer;Lio/reactivex/internal/fuseable/SimplePlainQueue;)V", "")]
		public unsafe QueueDrainObserver (global::IO.Reactivex.IObserver actual, global::IO.Reactivex.Internal.Fuseable.ISimplePlainQueue queue)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (actual);
				__args [1] = new JValue (queue);
				if (((object) this).GetType () != typeof (QueueDrainObserver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/Observer;Lio/reactivex/internal/fuseable/SimplePlainQueue;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/Observer;Lio/reactivex/internal/fuseable/SimplePlainQueue;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_Observer_Lio_reactivex_internal_fuseable_SimplePlainQueue_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_Observer_Lio_reactivex_internal_fuseable_SimplePlainQueue_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/Observer;Lio/reactivex/internal/fuseable/SimplePlainQueue;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_Observer_Lio_reactivex_internal_fuseable_SimplePlainQueue_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_Observer_Lio_reactivex_internal_fuseable_SimplePlainQueue_, __args);
			} finally {
			}
		}

		static Delegate cb_accept_Lio_reactivex_Observer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAccept_Lio_reactivex_Observer_Ljava_lang_Object_Handler ()
		{
			if (cb_accept_Lio_reactivex_Observer_Ljava_lang_Object_ == null)
				cb_accept_Lio_reactivex_Observer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Accept_Lio_reactivex_Observer_Ljava_lang_Object_);
			return cb_accept_Lio_reactivex_Observer_Ljava_lang_Object_;
		}

		static void n_Accept_Lio_reactivex_Observer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_v)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.QueueDrainObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = (global::IO.Reactivex.IObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObserver> (native_a, JniHandleOwnership.DoNotTransfer);
			var v = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_v, JniHandleOwnership.DoNotTransfer);
			__this.Accept (a, v);
		}
#pragma warning restore 0169

		static IntPtr id_accept_Lio_reactivex_Observer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='io.reactivex.Observer&lt;? super V&gt;'] and parameter[2][@type='U']]"
		[Register ("accept", "(Lio/reactivex/Observer;Ljava/lang/Object;)V", "GetAccept_Lio_reactivex_Observer_Ljava_lang_Object_Handler")]
		public virtual unsafe void Accept (global::IO.Reactivex.IObserver a, global::Java.Lang.Object v)
		{
			if (id_accept_Lio_reactivex_Observer_Ljava_lang_Object_ == IntPtr.Zero)
				id_accept_Lio_reactivex_Observer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "accept", "(Lio/reactivex/Observer;Ljava/lang/Object;)V");
			IntPtr native_v = JNIEnv.ToLocalJniHandle (v);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (a);
				__args [1] = new JValue (native_v);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Lio_reactivex_Observer_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(Lio/reactivex/Observer;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_v);
			}
		}

		static IntPtr id_cancelled;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/method[@name='cancelled' and count(parameter)=0]"
		[Register ("cancelled", "()Z", "")]
		public unsafe bool Cancelled ()
		{
			if (id_cancelled == IntPtr.Zero)
				id_cancelled = JNIEnv.GetMethodID (class_ref, "cancelled", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cancelled);
			} finally {
			}
		}

		static IntPtr id_done;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/method[@name='done' and count(parameter)=0]"
		[Register ("done", "()Z", "")]
		public unsafe bool Done ()
		{
			if (id_done == IntPtr.Zero)
				id_done = JNIEnv.GetMethodID (class_ref, "done", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_done);
			} finally {
			}
		}

		static IntPtr id_enter;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/method[@name='enter' and count(parameter)=0]"
		[Register ("enter", "()Z", "")]
		public unsafe bool Enter ()
		{
			if (id_enter == IntPtr.Zero)
				id_enter = JNIEnv.GetMethodID (class_ref, "enter", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_enter);
			} finally {
			}
		}

		static IntPtr id_error;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/method[@name='error' and count(parameter)=0]"
		[Register ("error", "()Ljava/lang/Throwable;", "")]
		public unsafe global::Java.Lang.Throwable Error ()
		{
			if (id_error == IntPtr.Zero)
				id_error = JNIEnv.GetMethodID (class_ref, "error", "()Ljava/lang/Throwable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_error), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fastEnter;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/method[@name='fastEnter' and count(parameter)=0]"
		[Register ("fastEnter", "()Z", "")]
		public unsafe bool FastEnter ()
		{
			if (id_fastEnter == IntPtr.Zero)
				id_fastEnter = JNIEnv.GetMethodID (class_ref, "fastEnter", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_fastEnter);
			} finally {
			}
		}

		static IntPtr id_fastPathEmit_Ljava_lang_Object_ZLio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/method[@name='fastPathEmit' and count(parameter)=3 and parameter[1][@type='U'] and parameter[2][@type='boolean'] and parameter[3][@type='io.reactivex.disposables.Disposable']]"
		[Register ("fastPathEmit", "(Ljava/lang/Object;ZLio/reactivex/disposables/Disposable;)V", "")]
		protected unsafe void FastPathEmit (global::Java.Lang.Object value, bool delayError, global::IO.Reactivex.Disposables.IDisposable dispose)
		{
			if (id_fastPathEmit_Ljava_lang_Object_ZLio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_fastPathEmit_Ljava_lang_Object_ZLio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "fastPathEmit", "(Ljava/lang/Object;ZLio/reactivex/disposables/Disposable;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_value);
				__args [1] = new JValue (delayError);
				__args [2] = new JValue (dispose);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fastPathEmit_Ljava_lang_Object_ZLio_reactivex_disposables_Disposable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_fastPathOrderedEmit_Ljava_lang_Object_ZLio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/method[@name='fastPathOrderedEmit' and count(parameter)=3 and parameter[1][@type='U'] and parameter[2][@type='boolean'] and parameter[3][@type='io.reactivex.disposables.Disposable']]"
		[Register ("fastPathOrderedEmit", "(Ljava/lang/Object;ZLio/reactivex/disposables/Disposable;)V", "")]
		protected unsafe void FastPathOrderedEmit (global::Java.Lang.Object value, bool delayError, global::IO.Reactivex.Disposables.IDisposable disposable)
		{
			if (id_fastPathOrderedEmit_Ljava_lang_Object_ZLio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_fastPathOrderedEmit_Ljava_lang_Object_ZLio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "fastPathOrderedEmit", "(Ljava/lang/Object;ZLio/reactivex/disposables/Disposable;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_value);
				__args [1] = new JValue (delayError);
				__args [2] = new JValue (disposable);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fastPathOrderedEmit_Ljava_lang_Object_ZLio_reactivex_disposables_Disposable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_leave_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='QueueDrainObserver']/method[@name='leave' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("leave", "(I)I", "")]
		public unsafe int Leave (int m)
		{
			if (id_leave_I == IntPtr.Zero)
				id_leave_I = JNIEnv.GetMethodID (class_ref, "leave", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (m);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_leave_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.QueueDrainObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.QueueDrainObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.QueueDrainObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.Disposables.IDisposable)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscribe (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='Observer']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("onSubscribe", "(Lio/reactivex/disposables/Disposable;)V", "GetOnSubscribe_Lio_reactivex_disposables_Disposable_Handler")]
		public abstract void OnSubscribe (global::IO.Reactivex.Disposables.IDisposable p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/observers/QueueDrainObserver", DoNotGenerateAcw=true)]
	internal partial class QueueDrainObserverInvoker : QueueDrainObserver, global::IO.Reactivex.IObserver, global::IO.Reactivex.Internal.Util.IObservableQueueDrain {

		public QueueDrainObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueueDrainObserverInvoker); }
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

	}

}
