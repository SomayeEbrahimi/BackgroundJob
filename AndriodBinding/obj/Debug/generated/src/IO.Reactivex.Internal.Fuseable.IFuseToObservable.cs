using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Fuseable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='FuseToObservable']"
	[Register ("io/reactivex/internal/fuseable/FuseToObservable", "", "IO.Reactivex.Internal.Fuseable.IFuseToObservableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IFuseToObservable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='FuseToObservable']/method[@name='fuseToObservable' and count(parameter)=0]"
		[Register ("fuseToObservable", "()Lio/reactivex/Observable;", "GetFuseToObservableHandler:IO.Reactivex.Internal.Fuseable.IFuseToObservableInvoker, AndriodBinding")]
		global::IO.Reactivex.Observable FuseToObservable ();

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/fuseable/FuseToObservable", DoNotGenerateAcw=true)]
	internal partial class IFuseToObservableInvoker : global::Java.Lang.Object, IFuseToObservable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/fuseable/FuseToObservable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFuseToObservableInvoker); }
		}

		IntPtr class_ref;

		public static IFuseToObservable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFuseToObservable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.fuseable.FuseToObservable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFuseToObservableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_fuseToObservable;
#pragma warning disable 0169
		static Delegate GetFuseToObservableHandler ()
		{
			if (cb_fuseToObservable == null)
				cb_fuseToObservable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_FuseToObservable);
			return cb_fuseToObservable;
		}

		static IntPtr n_FuseToObservable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IFuseToObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FuseToObservable ());
		}
#pragma warning restore 0169

		IntPtr id_fuseToObservable;
		public unsafe global::IO.Reactivex.Observable FuseToObservable ()
		{
			if (id_fuseToObservable == IntPtr.Zero)
				id_fuseToObservable = JNIEnv.GetMethodID (class_ref, "fuseToObservable", "()Lio/reactivex/Observable;");
			return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fuseToObservable), JniHandleOwnership.TransferLocalRef);
		}

	}

}
