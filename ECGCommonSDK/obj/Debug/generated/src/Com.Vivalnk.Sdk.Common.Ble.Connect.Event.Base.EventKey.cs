using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Event.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event.base']/class[@name='EventKey']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/event/base/EventKey", DoNotGenerateAcw=true)]
	public partial class EventKey : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event.base']/class[@name='EventKey']/field[@name='EVENT_BT_STATE']"
		[Register ("EVENT_BT_STATE")]
		public const string EventBtState = (string) "EventKey_EVENT_BT_STATE_CHANGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event.base']/class[@name='EventKey']/field[@name='EVENT_DEVICE_BOND']"
		[Register ("EVENT_DEVICE_BOND")]
		public const string EventDeviceBond = (string) "EventKey_EVENT_DEVICE_BOND_SATE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event.base']/class[@name='EventKey']/field[@name='EVENT_DEVICE_CONNECT']"
		[Register ("EVENT_DEVICE_CONNECT")]
		public const string EventDeviceConnect = (string) "EventKey_EVENT_DEVICE_CONNECT_STATE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event.base']/class[@name='EventKey']/field[@name='EVENT_DEVICE_REQUEST_PAIR']"
		[Register ("EVENT_DEVICE_REQUEST_PAIR")]
		public const string EventDeviceRequestPair = (string) "EventKey_EVENT_DEVICE_REQUEST_PAIR";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/event/base/EventKey", typeof (EventKey));
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

		protected EventKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event.base']/class[@name='EventKey']/constructor[@name='EventKey' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventKey ()
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
