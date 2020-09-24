using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BaseUUID']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BaseUUID", DoNotGenerateAcw=true)]
	public partial class BaseUUID : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/BaseUUID", typeof (BaseUUID));
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

		protected BaseUUID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BaseUUID']/constructor[@name='BaseUUID' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseUUID ()
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
