using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='MaybeTransformer']"
	[Register ("io/reactivex/MaybeTransformer", "", "IO.Reactivex.IMaybeTransformerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Upstream", "Downstream"})]
	public partial interface IMaybeTransformer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='MaybeTransformer']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='io.reactivex.Maybe&lt;Upstream&gt;']]"
		[Register ("apply", "(Lio/reactivex/Maybe;)Lio/reactivex/MaybeSource;", "GetApply_Lio_reactivex_Maybe_Handler:IO.Reactivex.IMaybeTransformerInvoker, AndriodBinding")]
		global::IO.Reactivex.IMaybeSource Apply (global::IO.Reactivex.Maybe p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/MaybeTransformer", DoNotGenerateAcw=true)]
	internal partial class IMaybeTransformerInvoker : global::Java.Lang.Object, IMaybeTransformer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/MaybeTransformer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMaybeTransformerInvoker); }
		}

		IntPtr class_ref;

		public static IMaybeTransformer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMaybeTransformer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.MaybeTransformer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMaybeTransformerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Lio_reactivex_Maybe_;
		public unsafe global::IO.Reactivex.IMaybeSource Apply (global::IO.Reactivex.Maybe p0)
		{
			if (id_apply_Lio_reactivex_Maybe_ == IntPtr.Zero)
				id_apply_Lio_reactivex_Maybe_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lio/reactivex/Maybe;)Lio/reactivex/MaybeSource;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lio_reactivex_Maybe_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
