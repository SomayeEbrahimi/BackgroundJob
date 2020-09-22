using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Disposables {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.disposables']/interface[@name='ResettableConnectable']"
	[Register ("io/reactivex/internal/disposables/ResettableConnectable", "", "IO.Reactivex.Internal.Disposables.IResettableConnectableInvoker")]
	public partial interface IResettableConnectable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/interface[@name='ResettableConnectable']/method[@name='resetIf' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("resetIf", "(Lio/reactivex/disposables/Disposable;)V", "GetResetIf_Lio_reactivex_disposables_Disposable_Handler:IO.Reactivex.Internal.Disposables.IResettableConnectableInvoker, AndriodBinding")]
		void ResetIf (global::IO.Reactivex.Disposables.IDisposable p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/disposables/ResettableConnectable", DoNotGenerateAcw=true)]
	internal partial class IResettableConnectableInvoker : global::Java.Lang.Object, IResettableConnectable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/disposables/ResettableConnectable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResettableConnectableInvoker); }
		}

		IntPtr class_ref;

		public static IResettableConnectable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResettableConnectable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.disposables.ResettableConnectable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResettableConnectableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_resetIf_Lio_reactivex_disposables_Disposable_;
#pragma warning disable 0169
		static Delegate GetResetIf_Lio_reactivex_disposables_Disposable_Handler ()
		{
			if (cb_resetIf_Lio_reactivex_disposables_Disposable_ == null)
				cb_resetIf_Lio_reactivex_disposables_Disposable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ResetIf_Lio_reactivex_disposables_Disposable_);
			return cb_resetIf_Lio_reactivex_disposables_Disposable_;
		}

		static void n_ResetIf_Lio_reactivex_disposables_Disposable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Disposables.IResettableConnectable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.Disposables.IDisposable)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResetIf (p0);
		}
#pragma warning restore 0169

		IntPtr id_resetIf_Lio_reactivex_disposables_Disposable_;
		public unsafe void ResetIf (global::IO.Reactivex.Disposables.IDisposable p0)
		{
			if (id_resetIf_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_resetIf_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "resetIf", "(Lio/reactivex/disposables/Disposable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetIf_Lio_reactivex_disposables_Disposable_, __args);
		}

	}

}
