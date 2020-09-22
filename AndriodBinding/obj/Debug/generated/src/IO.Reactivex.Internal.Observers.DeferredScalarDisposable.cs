using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']"
	[global::Android.Runtime.Register ("io/reactivex/internal/observers/DeferredScalarDisposable", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class DeferredScalarDisposable : global::IO.Reactivex.Internal.Observers.BasicIntQueueDisposable {


		static IntPtr downstream_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/field[@name='downstream']"
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

		static IntPtr value_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/field[@name='value']"
		[Register ("value")]
		protected global::Java.Lang.Object Value {
			get {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/observers/DeferredScalarDisposable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeferredScalarDisposable); }
		}

		protected DeferredScalarDisposable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_Observer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/constructor[@name='DeferredScalarDisposable' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register (".ctor", "(Lio/reactivex/Observer;)V", "")]
		public unsafe DeferredScalarDisposable (global::IO.Reactivex.IObserver downstream)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (downstream);
				if (((object) this).GetType () != typeof (DeferredScalarDisposable)) {
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

		static IntPtr id_isDisposed;
		public override unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/method[@name='isDisposed' and count(parameter)=0]"
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

		static IntPtr id_isEmpty;
		public override unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
				} finally {
				}
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public override sealed unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_complete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/method[@name='complete' and count(parameter)=0]"
		[Register ("complete", "()V", "")]
		public unsafe void Complete ()
		{
			if (id_complete == IntPtr.Zero)
				id_complete = JNIEnv.GetMethodID (class_ref, "complete", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_complete);
			} finally {
			}
		}

		static IntPtr id_complete_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/method[@name='complete' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("complete", "(Ljava/lang/Object;)V", "")]
		public unsafe void Complete (global::Java.Lang.Object value)
		{
			if (id_complete_Ljava_lang_Object_ == IntPtr.Zero)
				id_complete_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "complete", "(Ljava/lang/Object;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_complete_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Observers.DeferredScalarDisposable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
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

		static IntPtr id_error_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/Throwable;)V", "")]
		public unsafe void Error (global::Java.Lang.Throwable t)
		{
			if (id_error_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_poll;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/method[@name='poll' and count(parameter)=0]"
		[Register ("poll", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Poll ()
		{
			if (id_poll == IntPtr.Zero)
				id_poll = JNIEnv.GetMethodID (class_ref, "poll", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_poll), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_requestFusion_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/method[@name='requestFusion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestFusion", "(I)I", "")]
		public override sealed unsafe int RequestFusion (int mode)
		{
			if (id_requestFusion_I == IntPtr.Zero)
				id_requestFusion_I = JNIEnv.GetMethodID (class_ref, "requestFusion", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mode);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_requestFusion_I, __args);
			} finally {
			}
		}

		static IntPtr id_tryDispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='DeferredScalarDisposable']/method[@name='tryDispose' and count(parameter)=0]"
		[Register ("tryDispose", "()Z", "")]
		public unsafe bool TryDispose ()
		{
			if (id_tryDispose == IntPtr.Zero)
				id_tryDispose = JNIEnv.GetMethodID (class_ref, "tryDispose", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_tryDispose);
			} finally {
			}
		}

	}
}
