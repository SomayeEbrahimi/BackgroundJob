using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='Computable']"
	[Register ("org/apache/commons/lang3/concurrent/Computable", "", "Org.Apache.Commons.Lang3.Concurrent.IComputableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"I", "O"})]
	public partial interface IComputable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='Computable']/method[@name='compute' and count(parameter)=1 and parameter[1][@type='I']]"
		[Register ("compute", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetCompute_Ljava_lang_Object_Handler:Org.Apache.Commons.Lang3.Concurrent.IComputableInvoker, AndriodBinding")]
		global::Java.Lang.Object Compute (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/Computable", DoNotGenerateAcw=true)]
	internal partial class IComputableInvoker : global::Java.Lang.Object, IComputable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/Computable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IComputableInvoker); }
		}

		IntPtr class_ref;

		public static IComputable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IComputable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.concurrent.Computable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IComputableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_compute_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompute_Ljava_lang_Object_Handler ()
		{
			if (cb_compute_Ljava_lang_Object_ == null)
				cb_compute_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Compute_Ljava_lang_Object_);
			return cb_compute_Ljava_lang_Object_;
		}

		static IntPtr n_Compute_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.IComputable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Compute (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_compute_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Compute (global::Java.Lang.Object p0)
		{
			if (id_compute_Ljava_lang_Object_ == IntPtr.Zero)
				id_compute_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compute", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compute_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
