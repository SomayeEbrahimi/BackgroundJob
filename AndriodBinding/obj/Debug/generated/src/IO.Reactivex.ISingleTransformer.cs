using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleTransformer']"
	[Register ("io/reactivex/SingleTransformer", "", "IO.Reactivex.ISingleTransformerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Upstream", "Downstream"})]
	public partial interface ISingleTransformer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleTransformer']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='io.reactivex.Single&lt;Upstream&gt;']]"
		[Register ("apply", "(Lio/reactivex/Single;)Lio/reactivex/SingleSource;", "GetApply_Lio_reactivex_Single_Handler:IO.Reactivex.ISingleTransformerInvoker, AndriodBinding")]
		global::IO.Reactivex.ISingleSource Apply (global::IO.Reactivex.Single p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/SingleTransformer", DoNotGenerateAcw=true)]
	internal partial class ISingleTransformerInvoker : global::Java.Lang.Object, ISingleTransformer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/SingleTransformer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISingleTransformerInvoker); }
		}

		IntPtr class_ref;

		public static ISingleTransformer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISingleTransformer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.SingleTransformer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISingleTransformerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Lio_reactivex_Single_;
#pragma warning disable 0169
		static Delegate GetApply_Lio_reactivex_Single_Handler ()
		{
			if (cb_apply_Lio_reactivex_Single_ == null)
				cb_apply_Lio_reactivex_Single_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Apply_Lio_reactivex_Single_);
			return cb_apply_Lio_reactivex_Single_;
		}

		static IntPtr n_Apply_Lio_reactivex_Single_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Lio_reactivex_Single_;
		public unsafe global::IO.Reactivex.ISingleSource Apply (global::IO.Reactivex.Single p0)
		{
			if (id_apply_Lio_reactivex_Single_ == IntPtr.Zero)
				id_apply_Lio_reactivex_Single_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lio/reactivex/Single;)Lio/reactivex/SingleSource;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lio_reactivex_Single_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
