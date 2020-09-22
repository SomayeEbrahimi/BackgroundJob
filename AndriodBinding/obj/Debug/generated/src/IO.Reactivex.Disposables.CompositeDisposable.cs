using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Disposables {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']"
	[global::Android.Runtime.Register ("io/reactivex/disposables/CompositeDisposable", DoNotGenerateAcw=true)]
	public sealed partial class CompositeDisposable : global::Java.Lang.Object, global::IO.Reactivex.Disposables.IDisposable, global::IO.Reactivex.Internal.Disposables.IDisposableContainer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/disposables/CompositeDisposable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompositeDisposable); }
		}

		internal CompositeDisposable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/constructor[@name='CompositeDisposable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CompositeDisposable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CompositeDisposable)) {
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

		static IntPtr id_ctor_arrayLio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/constructor[@name='CompositeDisposable' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable...']]"
		[Register (".ctor", "([Lio/reactivex/disposables/Disposable;)V", "")]
		public unsafe CompositeDisposable (params global::IO.Reactivex.Disposables.IDisposable[] disposables)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_disposables = JNIEnv.NewArray (disposables);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_disposables);
				if (((object) this).GetType () != typeof (CompositeDisposable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lio/reactivex/disposables/Disposable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lio/reactivex/disposables/Disposable;)V", __args);
					return;
				}

				if (id_ctor_arrayLio_reactivex_disposables_Disposable_ == IntPtr.Zero)
					id_ctor_arrayLio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lio/reactivex/disposables/Disposable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLio_reactivex_disposables_Disposable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLio_reactivex_disposables_Disposable_, __args);
			} finally {
				if (disposables != null) {
					JNIEnv.CopyArray (native_disposables, disposables);
					JNIEnv.DeleteLocalRef (native_disposables);
				}
			}
		}

		static IntPtr id_ctor_Ljava_lang_Iterable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/constructor[@name='CompositeDisposable' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.disposables.Disposable&gt;']]"
		[Register (".ctor", "(Ljava/lang/Iterable;)V", "")]
		public unsafe CompositeDisposable (global::Java.Lang.IIterable disposables)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (disposables);
				if (((object) this).GetType () != typeof (CompositeDisposable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Iterable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Iterable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Iterable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Iterable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Iterable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Iterable_, __args);
			} finally {
			}
		}

		static IntPtr id_isDisposed;
		public unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/method[@name='isDisposed' and count(parameter)=0]"
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

		static IntPtr id_add_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/method[@name='add' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("add", "(Lio/reactivex/disposables/Disposable;)Z", "")]
		public unsafe bool Add (global::IO.Reactivex.Disposables.IDisposable disposable)
		{
			if (id_add_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_add_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "add", "(Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (disposable);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_add_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addAll_arrayLio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable...']]"
		[Register ("addAll", "([Lio/reactivex/disposables/Disposable;)Z", "")]
		public unsafe bool AddAll (params global::IO.Reactivex.Disposables.IDisposable[] disposables)
		{
			if (id_addAll_arrayLio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_addAll_arrayLio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "addAll", "([Lio/reactivex/disposables/Disposable;)Z");
			IntPtr native_disposables = JNIEnv.NewArray (disposables);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_disposables);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addAll_arrayLio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
				if (disposables != null) {
					JNIEnv.CopyArray (native_disposables, disposables);
					JNIEnv.DeleteLocalRef (native_disposables);
				}
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_delete_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("delete", "(Lio/reactivex/disposables/Disposable;)Z", "")]
		public unsafe bool Delete (global::IO.Reactivex.Disposables.IDisposable disposable)
		{
			if (id_delete_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_delete_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (disposable);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_delete_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/method[@name='dispose' and count(parameter)=0]"
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

		static IntPtr id_remove_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("remove", "(Lio/reactivex/disposables/Disposable;)Z", "")]
		public unsafe bool Remove (global::IO.Reactivex.Disposables.IDisposable disposable)
		{
			if (id_remove_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_remove_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (disposable);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='CompositeDisposable']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
			} finally {
			}
		}

	}
}
