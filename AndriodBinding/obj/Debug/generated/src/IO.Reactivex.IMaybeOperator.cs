using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='MaybeOperator']"
	[Register ("io/reactivex/MaybeOperator", "", "IO.Reactivex.IMaybeOperatorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Downstream", "Upstream"})]
	public partial interface IMaybeOperator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='MaybeOperator']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super Downstream&gt;']]"
		[Register ("apply", "(Lio/reactivex/MaybeObserver;)Lio/reactivex/MaybeObserver;", "GetApply_Lio_reactivex_MaybeObserver_Handler:IO.Reactivex.IMaybeOperatorInvoker, AndriodBinding")]
		global::IO.Reactivex.IMaybeObserver Apply (global::IO.Reactivex.IMaybeObserver p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/MaybeOperator", DoNotGenerateAcw=true)]
	internal partial class IMaybeOperatorInvoker : global::Java.Lang.Object, IMaybeOperator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/MaybeOperator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMaybeOperatorInvoker); }
		}

		IntPtr class_ref;

		public static IMaybeOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMaybeOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.MaybeOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMaybeOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Lio_reactivex_MaybeObserver_;
#pragma warning disable 0169
		static Delegate GetApply_Lio_reactivex_MaybeObserver_Handler ()
		{
			if (cb_apply_Lio_reactivex_MaybeObserver_ == null)
				cb_apply_Lio_reactivex_MaybeObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Apply_Lio_reactivex_MaybeObserver_);
			return cb_apply_Lio_reactivex_MaybeObserver_;
		}

		static IntPtr n_Apply_Lio_reactivex_MaybeObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.IMaybeObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Lio_reactivex_MaybeObserver_;
		public unsafe global::IO.Reactivex.IMaybeObserver Apply (global::IO.Reactivex.IMaybeObserver p0)
		{
			if (id_apply_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_apply_Lio_reactivex_MaybeObserver_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lio/reactivex/MaybeObserver;)Lio/reactivex/MaybeObserver;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lio_reactivex_MaybeObserver_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
