using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='ObservableOperator']"
	[Register ("io/reactivex/ObservableOperator", "", "IO.Reactivex.IObservableOperatorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Downstream", "Upstream"})]
	public partial interface IObservableOperator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='ObservableOperator']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super Downstream&gt;']]"
		[Register ("apply", "(Lio/reactivex/Observer;)Lio/reactivex/Observer;", "GetApply_Lio_reactivex_Observer_Handler:IO.Reactivex.IObservableOperatorInvoker, AndriodBinding")]
		global::IO.Reactivex.IObserver Apply (global::IO.Reactivex.IObserver p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/ObservableOperator", DoNotGenerateAcw=true)]
	internal partial class IObservableOperatorInvoker : global::Java.Lang.Object, IObservableOperator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/ObservableOperator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IObservableOperatorInvoker); }
		}

		IntPtr class_ref;

		public static IObservableOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObservableOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.ObservableOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObservableOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Lio_reactivex_Observer_;
#pragma warning disable 0169
		static Delegate GetApply_Lio_reactivex_Observer_Handler ()
		{
			if (cb_apply_Lio_reactivex_Observer_ == null)
				cb_apply_Lio_reactivex_Observer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Apply_Lio_reactivex_Observer_);
			return cb_apply_Lio_reactivex_Observer_;
		}

		static IntPtr n_Apply_Lio_reactivex_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObservableOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.IObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Lio_reactivex_Observer_;
		public unsafe global::IO.Reactivex.IObserver Apply (global::IO.Reactivex.IObserver p0)
		{
			if (id_apply_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_apply_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lio/reactivex/Observer;)Lio/reactivex/Observer;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lio_reactivex_Observer_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
