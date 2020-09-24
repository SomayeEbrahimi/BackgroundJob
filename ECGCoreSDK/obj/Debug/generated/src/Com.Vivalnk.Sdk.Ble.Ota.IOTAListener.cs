using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Ble.Ota {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/interface[@name='OTAListener']"
	[Register ("com/vivalnk/sdk/ble/ota/OTAListener", "", "Com.Vivalnk.Sdk.Ble.Ota.IOTAListenerInvoker")]
	public partial interface IOTAListener : IJavaObject, IJavaPeerable {

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/ble/ota/OTAListener", DoNotGenerateAcw=true)]
	internal partial class IOTAListenerInvoker : global::Java.Lang.Object, IOTAListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/ble/ota/OTAListener", typeof (IOTAListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOTAListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOTAListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.ble.ota.OTAListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOTAListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/vivalnk/sdk/ble/ota/OTAListenerImplementor")]
	internal sealed partial class IOTAListenerImplementor : global::Java.Lang.Object, IOTAListener {

		public IOTAListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vivalnk/sdk/ble/ota/OTAListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}


		internal static bool __IsEmpty (IOTAListenerImplementor value)
		{
			return true;
		}
	}

}
