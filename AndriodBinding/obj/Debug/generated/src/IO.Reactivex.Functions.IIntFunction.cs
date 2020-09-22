using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Functions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='IntFunction']"
	[Register ("io/reactivex/functions/IntFunction", "", "IO.Reactivex.Functions.IIntFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IIntFunction : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='IntFunction']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("apply", "(I)Ljava/lang/Object;", "GetApply_IHandler:IO.Reactivex.Functions.IIntFunctionInvoker, AndriodBinding")]
		global::Java.Lang.Object Apply (int p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/functions/IntFunction", DoNotGenerateAcw=true)]
	internal partial class IIntFunctionInvoker : global::Java.Lang.Object, IIntFunction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/functions/IntFunction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IIntFunctionInvoker); }
		}

		IntPtr class_ref;

		public static IIntFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIntFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.functions.IntFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIntFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_I;
#pragma warning disable 0169
		static Delegate GetApply_IHandler ()
		{
			if (cb_apply_I == null)
				cb_apply_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Apply_I);
			return cb_apply_I;
		}

		static IntPtr n_Apply_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IIntFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Apply (p0));
		}
#pragma warning restore 0169

		IntPtr id_apply_I;
		public unsafe global::Java.Lang.Object Apply (int p0)
		{
			if (id_apply_I == IntPtr.Zero)
				id_apply_I = JNIEnv.GetMethodID (class_ref, "apply", "(I)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_I, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
