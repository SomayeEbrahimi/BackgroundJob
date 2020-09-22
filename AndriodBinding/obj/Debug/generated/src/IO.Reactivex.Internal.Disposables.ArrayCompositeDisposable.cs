using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Disposables {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='ArrayCompositeDisposable']"
	[global::Android.Runtime.Register ("io/reactivex/internal/disposables/ArrayCompositeDisposable", DoNotGenerateAcw=true)]
	public sealed partial class ArrayCompositeDisposable : global::Java.Util.Concurrent.Atomic.AtomicReferenceArray, global::IO.Reactivex.Disposables.IDisposable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/disposables/ArrayCompositeDisposable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayCompositeDisposable); }
		}

		internal ArrayCompositeDisposable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='ArrayCompositeDisposable']/constructor[@name='ArrayCompositeDisposable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ArrayCompositeDisposable (int capacity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (capacity);
				if (((object) this).GetType () != typeof (ArrayCompositeDisposable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_isDisposed;
		public unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='ArrayCompositeDisposable']/method[@name='isDisposed' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='ArrayCompositeDisposable']/method[@name='dispose' and count(parameter)=0]"
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

		static IntPtr id_replaceResource_ILio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='ArrayCompositeDisposable']/method[@name='replaceResource' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='io.reactivex.disposables.Disposable']]"
		[Register ("replaceResource", "(ILio/reactivex/disposables/Disposable;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable ReplaceResource (int index, global::IO.Reactivex.Disposables.IDisposable resource)
		{
			if (id_replaceResource_ILio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_replaceResource_ILio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "replaceResource", "(ILio/reactivex/disposables/Disposable;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (resource);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replaceResource_ILio_reactivex_disposables_Disposable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setResource_ILio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='ArrayCompositeDisposable']/method[@name='setResource' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='io.reactivex.disposables.Disposable']]"
		[Register ("setResource", "(ILio/reactivex/disposables/Disposable;)Z", "")]
		public unsafe bool SetResource (int index, global::IO.Reactivex.Disposables.IDisposable resource)
		{
			if (id_setResource_ILio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_setResource_ILio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "setResource", "(ILio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (resource);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setResource_ILio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
