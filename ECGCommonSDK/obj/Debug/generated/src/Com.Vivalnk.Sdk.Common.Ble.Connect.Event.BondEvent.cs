using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='BondEvent']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/event/BondEvent", DoNotGenerateAcw=true)]
	public partial class BondEvent : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.Base.Event {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/event/BondEvent", typeof (BondEvent));
		internal static new IntPtr class_ref {
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

		protected BondEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='BondEvent']/constructor[@name='BondEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BondEvent ()
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
