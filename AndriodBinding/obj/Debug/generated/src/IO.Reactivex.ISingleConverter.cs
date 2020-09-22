using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleConverter']"
	[Register ("io/reactivex/SingleConverter", "", "IO.Reactivex.ISingleConverterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public partial interface ISingleConverter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleConverter']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='io.reactivex.Single&lt;T&gt;']]"
		[Register ("apply", "(Lio/reactivex/Single;)Ljava/lang/Object;", "GetApply_Lio_reactivex_Single_Handler:IO.Reactivex.ISingleConverterInvoker, AndriodBinding")]
		global::Java.Lang.Object Apply (global::IO.Reactivex.Single p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/SingleConverter", DoNotGenerateAcw=true)]
	internal partial class ISingleConverterInvoker : global::Java.Lang.Object, ISingleConverter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/SingleConverter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISingleConverterInvoker); }
		}

		IntPtr class_ref;

		public static ISingleConverter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISingleConverter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.SingleConverter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISingleConverterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Lio_reactivex_Single_;
		public unsafe global::Java.Lang.Object Apply (global::IO.Reactivex.Single p0)
		{
			if (id_apply_Lio_reactivex_Single_ == IntPtr.Zero)
				id_apply_Lio_reactivex_Single_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lio/reactivex/Single;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lio_reactivex_Single_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
