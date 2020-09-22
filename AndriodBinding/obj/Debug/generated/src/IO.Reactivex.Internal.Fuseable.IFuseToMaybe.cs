using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Fuseable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='FuseToMaybe']"
	[Register ("io/reactivex/internal/fuseable/FuseToMaybe", "", "IO.Reactivex.Internal.Fuseable.IFuseToMaybeInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IFuseToMaybe : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='FuseToMaybe']/method[@name='fuseToMaybe' and count(parameter)=0]"
		[Register ("fuseToMaybe", "()Lio/reactivex/Maybe;", "GetFuseToMaybeHandler:IO.Reactivex.Internal.Fuseable.IFuseToMaybeInvoker, AndriodBinding")]
		global::IO.Reactivex.Maybe FuseToMaybe ();

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/fuseable/FuseToMaybe", DoNotGenerateAcw=true)]
	internal partial class IFuseToMaybeInvoker : global::Java.Lang.Object, IFuseToMaybe {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/fuseable/FuseToMaybe");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFuseToMaybeInvoker); }
		}

		IntPtr class_ref;

		public static IFuseToMaybe GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFuseToMaybe> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.fuseable.FuseToMaybe"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFuseToMaybeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_fuseToMaybe;
#pragma warning disable 0169
		static Delegate GetFuseToMaybeHandler ()
		{
			if (cb_fuseToMaybe == null)
				cb_fuseToMaybe = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_FuseToMaybe);
			return cb_fuseToMaybe;
		}

		static IntPtr n_FuseToMaybe (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IFuseToMaybe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FuseToMaybe ());
		}
#pragma warning restore 0169

		IntPtr id_fuseToMaybe;
		public unsafe global::IO.Reactivex.Maybe FuseToMaybe ()
		{
			if (id_fuseToMaybe == IntPtr.Zero)
				id_fuseToMaybe = JNIEnv.GetMethodID (class_ref, "fuseToMaybe", "()Lio/reactivex/Maybe;");
			return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fuseToMaybe), JniHandleOwnership.TransferLocalRef);
		}

	}

}
