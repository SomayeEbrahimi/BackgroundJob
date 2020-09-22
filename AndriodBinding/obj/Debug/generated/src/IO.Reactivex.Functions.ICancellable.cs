using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Functions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='Cancellable']"
	[Register ("io/reactivex/functions/Cancellable", "", "IO.Reactivex.Functions.ICancellableInvoker")]
	public partial interface ICancellable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='Cancellable']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:IO.Reactivex.Functions.ICancellableInvoker, AndriodBinding")]
		void Cancel ();

	}

	[global::Android.Runtime.Register ("io/reactivex/functions/Cancellable", DoNotGenerateAcw=true)]
	internal partial class ICancellableInvoker : global::Java.Lang.Object, ICancellable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/functions/Cancellable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICancellableInvoker); }
		}

		IntPtr class_ref;

		public static ICancellable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICancellable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.functions.Cancellable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICancellableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.ICancellable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

	}

}
