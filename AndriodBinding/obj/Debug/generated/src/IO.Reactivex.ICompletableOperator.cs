using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='CompletableOperator']"
	[Register ("io/reactivex/CompletableOperator", "", "IO.Reactivex.ICompletableOperatorInvoker")]
	public partial interface ICompletableOperator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='CompletableOperator']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
		[Register ("apply", "(Lio/reactivex/CompletableObserver;)Lio/reactivex/CompletableObserver;", "GetApply_Lio_reactivex_CompletableObserver_Handler:IO.Reactivex.ICompletableOperatorInvoker, AndriodBinding")]
		global::IO.Reactivex.ICompletableObserver Apply (global::IO.Reactivex.ICompletableObserver p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/CompletableOperator", DoNotGenerateAcw=true)]
	internal partial class ICompletableOperatorInvoker : global::Java.Lang.Object, ICompletableOperator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/CompletableOperator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICompletableOperatorInvoker); }
		}

		IntPtr class_ref;

		public static ICompletableOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICompletableOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.CompletableOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICompletableOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Lio_reactivex_CompletableObserver_;
#pragma warning disable 0169
		static Delegate GetApply_Lio_reactivex_CompletableObserver_Handler ()
		{
			if (cb_apply_Lio_reactivex_CompletableObserver_ == null)
				cb_apply_Lio_reactivex_CompletableObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Apply_Lio_reactivex_CompletableObserver_);
			return cb_apply_Lio_reactivex_CompletableObserver_;
		}

		static IntPtr n_Apply_Lio_reactivex_CompletableObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ICompletableOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.ICompletableObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.ICompletableObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Lio_reactivex_CompletableObserver_;
		public unsafe global::IO.Reactivex.ICompletableObserver Apply (global::IO.Reactivex.ICompletableObserver p0)
		{
			if (id_apply_Lio_reactivex_CompletableObserver_ == IntPtr.Zero)
				id_apply_Lio_reactivex_CompletableObserver_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lio/reactivex/CompletableObserver;)Lio/reactivex/CompletableObserver;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ICompletableObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lio_reactivex_CompletableObserver_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
