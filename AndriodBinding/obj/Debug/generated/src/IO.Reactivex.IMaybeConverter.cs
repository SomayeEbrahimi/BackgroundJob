using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='MaybeConverter']"
	[Register ("io/reactivex/MaybeConverter", "", "IO.Reactivex.IMaybeConverterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public partial interface IMaybeConverter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='MaybeConverter']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='io.reactivex.Maybe&lt;T&gt;']]"
		[Register ("apply", "(Lio/reactivex/Maybe;)Ljava/lang/Object;", "GetApply_Lio_reactivex_Maybe_Handler:IO.Reactivex.IMaybeConverterInvoker, AndriodBinding")]
		global::Java.Lang.Object Apply (global::IO.Reactivex.Maybe p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/MaybeConverter", DoNotGenerateAcw=true)]
	internal partial class IMaybeConverterInvoker : global::Java.Lang.Object, IMaybeConverter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/MaybeConverter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMaybeConverterInvoker); }
		}

		IntPtr class_ref;

		public static IMaybeConverter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMaybeConverter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.MaybeConverter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMaybeConverterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Lio_reactivex_Maybe_;
#pragma warning disable 0169
		static Delegate GetApply_Lio_reactivex_Maybe_Handler ()
		{
			if (cb_apply_Lio_reactivex_Maybe_ == null)
				cb_apply_Lio_reactivex_Maybe_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Apply_Lio_reactivex_Maybe_);
			return cb_apply_Lio_reactivex_Maybe_;
		}

		static IntPtr n_Apply_Lio_reactivex_Maybe_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Lio_reactivex_Maybe_;
		public unsafe global::Java.Lang.Object Apply (global::IO.Reactivex.Maybe p0)
		{
			if (id_apply_Lio_reactivex_Maybe_ == IntPtr.Zero)
				id_apply_Lio_reactivex_Maybe_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lio/reactivex/Maybe;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lio_reactivex_Maybe_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
