using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Model.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDeviceStatus']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/model/event/WellnessDeviceStatus", DoNotGenerateAcw=true)]
	public partial class WellnessDeviceStatus : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/model/event/WellnessDeviceStatus", typeof (WellnessDeviceStatus));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected WellnessDeviceStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDeviceStatus']/constructor[@name='WellnessDeviceStatus' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WellnessDeviceStatus ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}