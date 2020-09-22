using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Observables {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']"
	[global::Android.Runtime.Register ("io/reactivex/observables/ConnectableObservable", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class ConnectableObservable : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/observables/ConnectableObservable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectableObservable); }
		}

		protected ConnectableObservable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/constructor[@name='ConnectableObservable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectableObservable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConnectableObservable)) {
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

		static Delegate cb_autoConnect;
#pragma warning disable 0169
		static Delegate GetAutoConnectHandler ()
		{
			if (cb_autoConnect == null)
				cb_autoConnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AutoConnect);
			return cb_autoConnect;
		}

		static IntPtr n_AutoConnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AutoConnect ());
		}
#pragma warning restore 0169

		static IntPtr id_autoConnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='autoConnect' and count(parameter)=0]"
		[Register ("autoConnect", "()Lio/reactivex/Observable;", "GetAutoConnectHandler")]
		public virtual unsafe global::IO.Reactivex.Observable AutoConnect ()
		{
			if (id_autoConnect == IntPtr.Zero)
				id_autoConnect = JNIEnv.GetMethodID (class_ref, "autoConnect", "()Lio/reactivex/Observable;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_autoConnect), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "autoConnect", "()Lio/reactivex/Observable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_autoConnect_I;
#pragma warning disable 0169
		static Delegate GetAutoConnect_IHandler ()
		{
			if (cb_autoConnect_I == null)
				cb_autoConnect_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_AutoConnect_I);
			return cb_autoConnect_I;
		}

		static IntPtr n_AutoConnect_I (IntPtr jnienv, IntPtr native__this, int numberOfSubscribers)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AutoConnect (numberOfSubscribers));
		}
#pragma warning restore 0169

		static IntPtr id_autoConnect_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='autoConnect' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("autoConnect", "(I)Lio/reactivex/Observable;", "GetAutoConnect_IHandler")]
		public virtual unsafe global::IO.Reactivex.Observable AutoConnect (int numberOfSubscribers)
		{
			if (id_autoConnect_I == IntPtr.Zero)
				id_autoConnect_I = JNIEnv.GetMethodID (class_ref, "autoConnect", "(I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (numberOfSubscribers);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_autoConnect_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "autoConnect", "(I)Lio/reactivex/Observable;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_autoConnect_ILio_reactivex_functions_Consumer_;
#pragma warning disable 0169
		static Delegate GetAutoConnect_ILio_reactivex_functions_Consumer_Handler ()
		{
			if (cb_autoConnect_ILio_reactivex_functions_Consumer_ == null)
				cb_autoConnect_ILio_reactivex_functions_Consumer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_AutoConnect_ILio_reactivex_functions_Consumer_);
			return cb_autoConnect_ILio_reactivex_functions_Consumer_;
		}

		static IntPtr n_AutoConnect_ILio_reactivex_functions_Consumer_ (IntPtr jnienv, IntPtr native__this, int numberOfSubscribers, IntPtr native_connection)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var connection = (global::IO.Reactivex.Functions.IConsumer)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (native_connection, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AutoConnect (numberOfSubscribers, connection));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_autoConnect_ILio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='autoConnect' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register ("autoConnect", "(ILio/reactivex/functions/Consumer;)Lio/reactivex/Observable;", "GetAutoConnect_ILio_reactivex_functions_Consumer_Handler")]
		public virtual unsafe global::IO.Reactivex.Observable AutoConnect (int numberOfSubscribers, global::IO.Reactivex.Functions.IConsumer connection)
		{
			if (id_autoConnect_ILio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_autoConnect_ILio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "autoConnect", "(ILio/reactivex/functions/Consumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (numberOfSubscribers);
				__args [1] = new JValue (connection);

				global::IO.Reactivex.Observable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_autoConnect_ILio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "autoConnect", "(ILio/reactivex/functions/Consumer;)Lio/reactivex/Observable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()Lio/reactivex/disposables/Disposable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_connect_Lio_reactivex_functions_Consumer_;
#pragma warning disable 0169
		static Delegate GetConnect_Lio_reactivex_functions_Consumer_Handler ()
		{
			if (cb_connect_Lio_reactivex_functions_Consumer_ == null)
				cb_connect_Lio_reactivex_functions_Consumer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Connect_Lio_reactivex_functions_Consumer_);
			return cb_connect_Lio_reactivex_functions_Consumer_;
		}

		static void n_Connect_Lio_reactivex_functions_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.Functions.IConsumer)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register ("connect", "(Lio/reactivex/functions/Consumer;)V", "GetConnect_Lio_reactivex_functions_Consumer_Handler")]
		public abstract void Connect (global::IO.Reactivex.Functions.IConsumer p0);

		static Delegate cb_refCount;
#pragma warning disable 0169
		static Delegate GetRefCountHandler ()
		{
			if (cb_refCount == null)
				cb_refCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_RefCount);
			return cb_refCount;
		}

		static IntPtr n_RefCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefCount ());
		}
#pragma warning restore 0169

		static IntPtr id_refCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='refCount' and count(parameter)=0]"
		[Register ("refCount", "()Lio/reactivex/Observable;", "GetRefCountHandler")]
		public virtual unsafe global::IO.Reactivex.Observable RefCount ()
		{
			if (id_refCount == IntPtr.Zero)
				id_refCount = JNIEnv.GetMethodID (class_ref, "refCount", "()Lio/reactivex/Observable;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_refCount), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refCount", "()Lio/reactivex/Observable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_refCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='refCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("refCount", "(I)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable RefCount (int subscriberCount)
		{
			if (id_refCount_I == IntPtr.Zero)
				id_refCount_I = JNIEnv.GetMethodID (class_ref, "refCount", "(I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (subscriberCount);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_refCount_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_refCount_IJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='refCount' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("refCount", "(IJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable RefCount (int subscriberCount, long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_refCount_IJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_refCount_IJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "refCount", "(IJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (subscriberCount);
				__args [1] = new JValue (timeout);
				__args [2] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_refCount_IJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_refCount_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='refCount' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("refCount", "(IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable RefCount (int subscriberCount, long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_refCount_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_refCount_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "refCount", "(IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (subscriberCount);
				__args [1] = new JValue (timeout);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_refCount_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_refCount_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='refCount' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("refCount", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable RefCount (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_refCount_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_refCount_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "refCount", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_refCount_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_refCount_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='refCount' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("refCount", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable RefCount (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_refCount_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_refCount_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "refCount", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_refCount_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/observables/ConnectableObservable", DoNotGenerateAcw=true)]
	internal partial class ConnectableObservableInvoker : ConnectableObservable {

		public ConnectableObservableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectableObservableInvoker); }
		}

		static IntPtr id_connect_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observables']/class[@name='ConnectableObservable']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register ("connect", "(Lio/reactivex/functions/Consumer;)V", "GetConnect_Lio_reactivex_functions_Consumer_Handler")]
		public override unsafe void Connect (global::IO.Reactivex.Functions.IConsumer p0)
		{
			if (id_connect_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_connect_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lio/reactivex/functions/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lio_reactivex_functions_Consumer_, __args);
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
