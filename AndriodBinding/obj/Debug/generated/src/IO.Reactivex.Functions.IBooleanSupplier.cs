using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Functions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='BooleanSupplier']"
	[Register ("io/reactivex/functions/BooleanSupplier", "", "IO.Reactivex.Functions.IBooleanSupplierInvoker")]
	public partial interface IBooleanSupplier : IJavaObject {

		bool AsBoolean {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='BooleanSupplier']/method[@name='getAsBoolean' and count(parameter)=0]"
			[Register ("getAsBoolean", "()Z", "GetGetAsBooleanHandler:IO.Reactivex.Functions.IBooleanSupplierInvoker, AndriodBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/functions/BooleanSupplier", DoNotGenerateAcw=true)]
	internal partial class IBooleanSupplierInvoker : global::Java.Lang.Object, IBooleanSupplier {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/functions/BooleanSupplier");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBooleanSupplierInvoker); }
		}

		IntPtr class_ref;

		public static IBooleanSupplier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBooleanSupplier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.functions.BooleanSupplier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBooleanSupplierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAsBoolean;
#pragma warning disable 0169
		static Delegate GetGetAsBooleanHandler ()
		{
			if (cb_getAsBoolean == null)
				cb_getAsBoolean = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetAsBoolean);
			return cb_getAsBoolean;
		}

		static bool n_GetAsBoolean (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBooleanSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsBoolean;
		}
#pragma warning restore 0169

		IntPtr id_getAsBoolean;
		public unsafe bool AsBoolean {
			get {
				if (id_getAsBoolean == IntPtr.Zero)
					id_getAsBoolean = JNIEnv.GetMethodID (class_ref, "getAsBoolean", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAsBoolean);
			}
		}

	}

}
