using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/interface[@name='BleManagerInterface']"
	[Register ("com/vivalnk/sdk/common/ble/BleManagerInterface", "", "Com.Vivalnk.Sdk.Common.Ble.IBleManagerInterfaceInvoker")]
	public partial interface IBleManagerInterface : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BleManagerInterface", DoNotGenerateAcw=true)]
	internal partial class IBleManagerInterfaceInvoker : global::Java.Lang.Object, IBleManagerInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/BleManagerInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBleManagerInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static IBleManagerInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBleManagerInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.BleManagerInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBleManagerInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
