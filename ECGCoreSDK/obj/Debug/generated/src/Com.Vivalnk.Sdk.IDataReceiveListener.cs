using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk']/interface[@name='DataReceiveListener']"
	[Register ("com/vivalnk/sdk/DataReceiveListener", "", "Com.Vivalnk.Sdk.IDataReceiveListenerInvoker")]
	public partial interface IDataReceiveListener : IJavaObject, IJavaPeerable {

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/DataReceiveListener", DoNotGenerateAcw=true)]
	internal partial class IDataReceiveListenerInvoker : global::Java.Lang.Object, IDataReceiveListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/DataReceiveListener", typeof (IDataReceiveListenerInvoker));

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

		public static IDataReceiveListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataReceiveListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.DataReceiveListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataReceiveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/vivalnk/sdk/DataReceiveListenerImplementor")]
	internal sealed partial class IDataReceiveListenerImplementor : global::Java.Lang.Object, IDataReceiveListener {

		public IDataReceiveListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vivalnk/sdk/DataReceiveListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}


		internal static bool __IsEmpty (IDataReceiveListenerImplementor value)
		{
			return true;
		}
	}

}
