using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='CompletableConverter']"
	[Register ("io/reactivex/CompletableConverter", "", "IO.Reactivex.ICompletableConverterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface ICompletableConverter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='CompletableConverter']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='io.reactivex.Completable']]"
		[Register ("apply", "(Lio/reactivex/Completable;)Ljava/lang/Object;", "GetApply_Lio_reactivex_Completable_Handler:IO.Reactivex.ICompletableConverterInvoker, AndriodBinding")]
		global::Java.Lang.Object Apply (global::IO.Reactivex.Completable p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/CompletableConverter", DoNotGenerateAcw=true)]
	internal partial class ICompletableConverterInvoker : global::Java.Lang.Object, ICompletableConverter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/CompletableConverter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICompletableConverterInvoker); }
		}

		IntPtr class_ref;

		public static ICompletableConverter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICompletableConverter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.CompletableConverter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICompletableConverterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Lio_reactivex_Completable_;
#pragma warning disable 0169
		static Delegate GetApply_Lio_reactivex_Completable_Handler ()
		{
			if (cb_apply_Lio_reactivex_Completable_ == null)
				cb_apply_Lio_reactivex_Completable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Apply_Lio_reactivex_Completable_);
			return cb_apply_Lio_reactivex_Completable_;
		}

		static IntPtr n_Apply_Lio_reactivex_Completable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ICompletableConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Lio_reactivex_Completable_;
		public unsafe global::Java.Lang.Object Apply (global::IO.Reactivex.Completable p0)
		{
			if (id_apply_Lio_reactivex_Completable_ == IntPtr.Zero)
				id_apply_Lio_reactivex_Completable_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lio/reactivex/Completable;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lio_reactivex_Completable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
