using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataSerializer']"
	[Register ("com/vivalnk/sdk/model/common/DataSerializer", "", "Com.Vivalnk.Sdk.Model.Common.IDataSerializerInvoker")]
	public partial interface IDataSerializer : IJavaObject, IJavaPeerable {

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/common/DataSerializer", DoNotGenerateAcw=true)]
	internal partial class IDataSerializerInvoker : global::Java.Lang.Object, IDataSerializer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/common/DataSerializer", typeof (IDataSerializerInvoker));

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

		public static IDataSerializer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataSerializer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.model.common.DataSerializer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataSerializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
