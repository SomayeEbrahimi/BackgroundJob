using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleOperator']"
	[Register ("io/reactivex/SingleOperator", "", "IO.Reactivex.ISingleOperatorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Downstream", "Upstream"})]
	public partial interface ISingleOperator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='SingleOperator']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super Downstream&gt;']]"
		[Register ("apply", "(Lio/reactivex/SingleObserver;)Lio/reactivex/SingleObserver;", "GetApply_Lio_reactivex_SingleObserver_Handler:IO.Reactivex.ISingleOperatorInvoker, AndriodBinding")]
		global::IO.Reactivex.ISingleObserver Apply (global::IO.Reactivex.ISingleObserver p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/SingleOperator", DoNotGenerateAcw=true)]
	internal partial class ISingleOperatorInvoker : global::Java.Lang.Object, ISingleOperator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/SingleOperator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISingleOperatorInvoker); }
		}

		IntPtr class_ref;

		public static ISingleOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISingleOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.SingleOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISingleOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Lio_reactivex_SingleObserver_;
#pragma warning disable 0169
		static Delegate GetApply_Lio_reactivex_SingleObserver_Handler ()
		{
			if (cb_apply_Lio_reactivex_SingleObserver_ == null)
				cb_apply_Lio_reactivex_SingleObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Apply_Lio_reactivex_SingleObserver_);
			return cb_apply_Lio_reactivex_SingleObserver_;
		}

		static IntPtr n_Apply_Lio_reactivex_SingleObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.ISingleObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Lio_reactivex_SingleObserver_;
		public unsafe global::IO.Reactivex.ISingleObserver Apply (global::IO.Reactivex.ISingleObserver p0)
		{
			if (id_apply_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_apply_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lio/reactivex/SingleObserver;)Lio/reactivex/SingleObserver;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lio_reactivex_SingleObserver_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
