using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Disposables {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='SequentialDisposable']"
	[global::Android.Runtime.Register ("io/reactivex/internal/disposables/SequentialDisposable", DoNotGenerateAcw=true)]
	public sealed partial class SequentialDisposable : global::Java.Util.Concurrent.Atomic.AtomicReference, global::IO.Reactivex.Disposables.IDisposable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/disposables/SequentialDisposable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SequentialDisposable); }
		}

		internal SequentialDisposable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='SequentialDisposable']/constructor[@name='SequentialDisposable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SequentialDisposable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SequentialDisposable)) {
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

		static IntPtr id_ctor_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='SequentialDisposable']/constructor[@name='SequentialDisposable' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register (".ctor", "(Lio/reactivex/disposables/Disposable;)V", "")]
		public unsafe SequentialDisposable (global::IO.Reactivex.Disposables.IDisposable initial)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (initial);
				if (((object) this).GetType () != typeof (SequentialDisposable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/disposables/Disposable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/disposables/Disposable;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/disposables/Disposable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_disposables_Disposable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_disposables_Disposable_, __args);
			} finally {
			}
		}

		static IntPtr id_isDisposed;
		public unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='SequentialDisposable']/method[@name='isDisposed' and count(parameter)=0]"
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

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='SequentialDisposable']/method[@name='dispose' and count(parameter)=0]"
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

		static IntPtr id_replace_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='SequentialDisposable']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("replace", "(Lio/reactivex/disposables/Disposable;)Z", "")]
		public unsafe bool Replace (global::IO.Reactivex.Disposables.IDisposable next)
		{
			if (id_replace_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_replace_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "replace", "(Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (next);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_replace_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_update_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='SequentialDisposable']/method[@name='update' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("update", "(Lio/reactivex/disposables/Disposable;)Z", "")]
		public unsafe bool Update (global::IO.Reactivex.Disposables.IDisposable next)
		{
			if (id_update_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_update_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "update", "(Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (next);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_update_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
