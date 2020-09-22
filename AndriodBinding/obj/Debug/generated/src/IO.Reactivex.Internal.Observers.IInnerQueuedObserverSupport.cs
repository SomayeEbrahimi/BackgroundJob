using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Observers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.observers']/interface[@name='InnerQueuedObserverSupport']"
	[Register ("io/reactivex/internal/observers/InnerQueuedObserverSupport", "", "IO.Reactivex.Internal.Observers.IInnerQueuedObserverSupportInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IInnerQueuedObserverSupport : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/interface[@name='InnerQueuedObserverSupport']/method[@name='drain' and count(parameter)=0]"
		[Register ("drain", "()V", "GetDrainHandler:IO.Reactivex.Internal.Observers.IInnerQueuedObserverSupportInvoker, AndriodBinding")]
		void Drain ();

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/interface[@name='InnerQueuedObserverSupport']/method[@name='innerComplete' and count(parameter)=1 and parameter[1][@type='io.reactivex.internal.observers.InnerQueuedObserver&lt;T&gt;']]"
		[Register ("innerComplete", "(Lio/reactivex/internal/observers/InnerQueuedObserver;)V", "GetInnerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_Handler:IO.Reactivex.Internal.Observers.IInnerQueuedObserverSupportInvoker, AndriodBinding")]
		void InnerComplete (global::IO.Reactivex.Internal.Observers.InnerQueuedObserver p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/interface[@name='InnerQueuedObserverSupport']/method[@name='innerError' and count(parameter)=2 and parameter[1][@type='io.reactivex.internal.observers.InnerQueuedObserver&lt;T&gt;'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("innerError", "(Lio/reactivex/internal/observers/InnerQueuedObserver;Ljava/lang/Throwable;)V", "GetInnerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_Handler:IO.Reactivex.Internal.Observers.IInnerQueuedObserverSupportInvoker, AndriodBinding")]
		void InnerError (global::IO.Reactivex.Internal.Observers.InnerQueuedObserver p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/interface[@name='InnerQueuedObserverSupport']/method[@name='innerNext' and count(parameter)=2 and parameter[1][@type='io.reactivex.internal.observers.InnerQueuedObserver&lt;T&gt;'] and parameter[2][@type='T']]"
		[Register ("innerNext", "(Lio/reactivex/internal/observers/InnerQueuedObserver;Ljava/lang/Object;)V", "GetInnerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_Handler:IO.Reactivex.Internal.Observers.IInnerQueuedObserverSupportInvoker, AndriodBinding")]
		void InnerNext (global::IO.Reactivex.Internal.Observers.InnerQueuedObserver p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/observers/InnerQueuedObserverSupport", DoNotGenerateAcw=true)]
	internal partial class IInnerQueuedObserverSupportInvoker : global::Java.Lang.Object, IInnerQueuedObserverSupport {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/observers/InnerQueuedObserverSupport");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInnerQueuedObserverSupportInvoker); }
		}

		IntPtr class_ref;

		public static IInnerQueuedObserverSupport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInnerQueuedObserverSupport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.observers.InnerQueuedObserverSupport"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInnerQueuedObserverSupportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_drain;
#pragma warning disable 0169
		static Delegate GetDrainHandler ()
		{
			if (cb_drain == null)
				cb_drain = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Drain);
			return cb_drain;
		}

		static void n_Drain (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.IInnerQueuedObserverSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Drain ();
		}
#pragma warning restore 0169

		IntPtr id_drain;
		public unsafe void Drain ()
		{
			if (id_drain == IntPtr.Zero)
				id_drain = JNIEnv.GetMethodID (class_ref, "drain", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drain);
		}

		static Delegate cb_innerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_;
#pragma warning disable 0169
		static Delegate GetInnerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_Handler ()
		{
			if (cb_innerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_ == null)
				cb_innerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InnerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_);
			return cb_innerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_;
		}

		static void n_InnerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.IInnerQueuedObserverSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.InnerQueuedObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InnerComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_innerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_;
		public unsafe void InnerComplete (global::IO.Reactivex.Internal.Observers.InnerQueuedObserver p0)
		{
			if (id_innerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_ == IntPtr.Zero)
				id_innerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_ = JNIEnv.GetMethodID (class_ref, "innerComplete", "(Lio/reactivex/internal/observers/InnerQueuedObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_innerComplete_Lio_reactivex_internal_observers_InnerQueuedObserver_, __args);
		}

		static Delegate cb_innerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetInnerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_Handler ()
		{
			if (cb_innerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_ == null)
				cb_innerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_InnerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_);
			return cb_innerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_;
		}

		static void n_InnerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.IInnerQueuedObserverSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.InnerQueuedObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InnerError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_innerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_;
		public unsafe void InnerError (global::IO.Reactivex.Internal.Observers.InnerQueuedObserver p0, global::Java.Lang.Throwable p1)
		{
			if (id_innerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_innerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "innerError", "(Lio/reactivex/internal/observers/InnerQueuedObserver;Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_innerError_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_innerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInnerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_Handler ()
		{
			if (cb_innerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_ == null)
				cb_innerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_InnerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_);
			return cb_innerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_;
		}

		static void n_InnerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.IInnerQueuedObserverSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.InnerQueuedObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InnerNext (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_innerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_;
		public unsafe void InnerNext (global::IO.Reactivex.Internal.Observers.InnerQueuedObserver p0, global::Java.Lang.Object p1)
		{
			if (id_innerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_ == IntPtr.Zero)
				id_innerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "innerNext", "(Lio/reactivex/internal/observers/InnerQueuedObserver;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_innerNext_Lio_reactivex_internal_observers_InnerQueuedObserver_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
