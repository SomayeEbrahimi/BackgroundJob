using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.listener']/interface[@name='BleListener']"
	[Register ("com/vivalnk/sdk/common/ble/listener/BleListener", "", "Com.Vivalnk.Sdk.Common.Ble.Listener.IBleListenerInvoker")]
	public partial interface IBleListener : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/listener/BleListener", DoNotGenerateAcw=true)]
	internal partial class IBleListenerInvoker : global::Java.Lang.Object, IBleListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/listener/BleListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBleListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBleListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.listener.BleListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/vivalnk/sdk/common/ble/listener/BleListenerImplementor")]
	internal sealed partial class IBleListenerImplementor : global::Java.Lang.Object, IBleListener {

		public IBleListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vivalnk/sdk/common/ble/listener/BleListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}


		internal static bool __IsEmpty (IBleListenerImplementor value)
		{
			return true;
		}
	}

}
