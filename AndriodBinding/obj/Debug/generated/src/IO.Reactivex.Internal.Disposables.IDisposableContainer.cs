using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Disposables {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.disposables']/interface[@name='DisposableContainer']"
	[Register ("io/reactivex/internal/disposables/DisposableContainer", "", "IO.Reactivex.Internal.Disposables.IDisposableContainerInvoker")]
	public partial interface IDisposableContainer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/interface[@name='DisposableContainer']/method[@name='add' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("add", "(Lio/reactivex/disposables/Disposable;)Z", "GetAdd_Lio_reactivex_disposables_Disposable_Handler:IO.Reactivex.Internal.Disposables.IDisposableContainerInvoker, AndriodBinding")]
		bool Add (global::IO.Reactivex.Disposables.IDisposable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/interface[@name='DisposableContainer']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("delete", "(Lio/reactivex/disposables/Disposable;)Z", "GetDelete_Lio_reactivex_disposables_Disposable_Handler:IO.Reactivex.Internal.Disposables.IDisposableContainerInvoker, AndriodBinding")]
		bool Delete (global::IO.Reactivex.Disposables.IDisposable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/interface[@name='DisposableContainer']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("remove", "(Lio/reactivex/disposables/Disposable;)Z", "GetRemove_Lio_reactivex_disposables_Disposable_Handler:IO.Reactivex.Internal.Disposables.IDisposableContainerInvoker, AndriodBinding")]
		bool Remove (global::IO.Reactivex.Disposables.IDisposable p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/disposables/DisposableContainer", DoNotGenerateAcw=true)]
	internal partial class IDisposableContainerInvoker : global::Java.Lang.Object, IDisposableContainer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/disposables/DisposableContainer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDisposableContainerInvoker); }
		}

		IntPtr class_ref;

		public static IDisposableContainer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDisposableContainer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.disposables.DisposableContainer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDisposableContainerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_add_Lio_reactivex_disposables_Disposable_;
#pragma warning disable 0169
		static Delegate GetAdd_Lio_reactivex_disposables_Disposable_Handler ()
		{
			if (cb_add_Lio_reactivex_disposables_Disposable_ == null)
				cb_add_Lio_reactivex_disposables_Disposable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Add_Lio_reactivex_disposables_Disposable_);
			return cb_add_Lio_reactivex_disposables_Disposable_;
		}

		static bool n_Add_Lio_reactivex_disposables_Disposable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Disposables.IDisposableContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.Disposables.IDisposable)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_add_Lio_reactivex_disposables_Disposable_;
		public unsafe bool Add (global::IO.Reactivex.Disposables.IDisposable p0)
		{
			if (id_add_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_add_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "add", "(Lio/reactivex/disposables/Disposable;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_add_Lio_reactivex_disposables_Disposable_, __args);
			return __ret;
		}

		static Delegate cb_delete_Lio_reactivex_disposables_Disposable_;
#pragma warning disable 0169
		static Delegate GetDelete_Lio_reactivex_disposables_Disposable_Handler ()
		{
			if (cb_delete_Lio_reactivex_disposables_Disposable_ == null)
				cb_delete_Lio_reactivex_disposables_Disposable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Delete_Lio_reactivex_disposables_Disposable_);
			return cb_delete_Lio_reactivex_disposables_Disposable_;
		}

		static bool n_Delete_Lio_reactivex_disposables_Disposable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Disposables.IDisposableContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.Disposables.IDisposable)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Delete (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_delete_Lio_reactivex_disposables_Disposable_;
		public unsafe bool Delete (global::IO.Reactivex.Disposables.IDisposable p0)
		{
			if (id_delete_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_delete_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lio/reactivex/disposables/Disposable;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_delete_Lio_reactivex_disposables_Disposable_, __args);
			return __ret;
		}

		static Delegate cb_remove_Lio_reactivex_disposables_Disposable_;
#pragma warning disable 0169
		static Delegate GetRemove_Lio_reactivex_disposables_Disposable_Handler ()
		{
			if (cb_remove_Lio_reactivex_disposables_Disposable_ == null)
				cb_remove_Lio_reactivex_disposables_Disposable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Remove_Lio_reactivex_disposables_Disposable_);
			return cb_remove_Lio_reactivex_disposables_Disposable_;
		}

		static bool n_Remove_Lio_reactivex_disposables_Disposable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Disposables.IDisposableContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.Disposables.IDisposable)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_Lio_reactivex_disposables_Disposable_;
		public unsafe bool Remove (global::IO.Reactivex.Disposables.IDisposable p0)
		{
			if (id_remove_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_remove_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lio/reactivex/disposables/Disposable;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lio_reactivex_disposables_Disposable_, __args);
			return __ret;
		}

	}

}
