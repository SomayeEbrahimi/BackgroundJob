using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='FlowableOperator']"
	[Register ("io/reactivex/FlowableOperator", "", "IO.Reactivex.IFlowableOperatorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Downstream", "Upstream"})]
	public partial interface IFlowableOperator : IJavaObject {

	}

	[global::Android.Runtime.Register ("io/reactivex/FlowableOperator", DoNotGenerateAcw=true)]
	internal partial class IFlowableOperatorInvoker : global::Java.Lang.Object, IFlowableOperator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/FlowableOperator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFlowableOperatorInvoker); }
		}

		IntPtr class_ref;

		public static IFlowableOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFlowableOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.FlowableOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFlowableOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
