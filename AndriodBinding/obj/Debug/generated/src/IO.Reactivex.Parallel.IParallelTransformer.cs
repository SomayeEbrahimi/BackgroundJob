using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Parallel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.parallel']/interface[@name='ParallelTransformer']"
	[Register ("io/reactivex/parallel/ParallelTransformer", "", "IO.Reactivex.Parallel.IParallelTransformerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Upstream", "Downstream"})]
	public partial interface IParallelTransformer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/interface[@name='ParallelTransformer']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='io.reactivex.parallel.ParallelFlowable&lt;Upstream&gt;']]"
		[Register ("apply", "(Lio/reactivex/parallel/ParallelFlowable;)Lio/reactivex/parallel/ParallelFlowable;", "GetApply_Lio_reactivex_parallel_ParallelFlowable_Handler:IO.Reactivex.Parallel.IParallelTransformerInvoker, AndriodBinding")]
		global::IO.Reactivex.Parallel.ParallelFlowable Apply (global::IO.Reactivex.Parallel.ParallelFlowable p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/parallel/ParallelTransformer", DoNotGenerateAcw=true)]
	internal partial class IParallelTransformerInvoker : global::Java.Lang.Object, IParallelTransformer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/parallel/ParallelTransformer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IParallelTransformerInvoker); }
		}

		IntPtr class_ref;

		public static IParallelTransformer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParallelTransformer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.parallel.ParallelTransformer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParallelTransformerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Lio_reactivex_parallel_ParallelFlowable_;
#pragma warning disable 0169
		static Delegate GetApply_Lio_reactivex_parallel_ParallelFlowable_Handler ()
		{
			if (cb_apply_Lio_reactivex_parallel_ParallelFlowable_ == null)
				cb_apply_Lio_reactivex_parallel_ParallelFlowable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Apply_Lio_reactivex_parallel_ParallelFlowable_);
			return cb_apply_Lio_reactivex_parallel_ParallelFlowable_;
		}

		static IntPtr n_Apply_Lio_reactivex_parallel_ParallelFlowable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.IParallelTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Lio_reactivex_parallel_ParallelFlowable_;
		public unsafe global::IO.Reactivex.Parallel.ParallelFlowable Apply (global::IO.Reactivex.Parallel.ParallelFlowable p0)
		{
			if (id_apply_Lio_reactivex_parallel_ParallelFlowable_ == IntPtr.Zero)
				id_apply_Lio_reactivex_parallel_ParallelFlowable_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lio/reactivex/parallel/ParallelFlowable;)Lio/reactivex/parallel/ParallelFlowable;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFlowable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lio_reactivex_parallel_ParallelFlowable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
