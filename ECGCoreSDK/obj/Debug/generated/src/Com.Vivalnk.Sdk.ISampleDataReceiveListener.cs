using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk']/interface[@name='SampleDataReceiveListener']"
	[Register ("com/vivalnk/sdk/SampleDataReceiveListener", "", "Com.Vivalnk.Sdk.ISampleDataReceiveListenerInvoker")]
	public partial interface ISampleDataReceiveListener : IJavaObject, IJavaPeerable {

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/SampleDataReceiveListener", DoNotGenerateAcw=true)]
	internal partial class ISampleDataReceiveListenerInvoker : global::Java.Lang.Object, ISampleDataReceiveListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/SampleDataReceiveListener", typeof (ISampleDataReceiveListenerInvoker));

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

		public static ISampleDataReceiveListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISampleDataReceiveListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.SampleDataReceiveListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISampleDataReceiveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/vivalnk/sdk/SampleDataReceiveListenerImplementor")]
	internal sealed partial class ISampleDataReceiveListenerImplementor : global::Java.Lang.Object, ISampleDataReceiveListener {

		public ISampleDataReceiveListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vivalnk/sdk/SampleDataReceiveListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}


		internal static bool __IsEmpty (ISampleDataReceiveListenerImplementor value)
		{
			return true;
		}
	}

}
