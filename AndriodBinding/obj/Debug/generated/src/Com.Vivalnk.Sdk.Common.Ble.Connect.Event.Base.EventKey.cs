using System;
using System.Collections.Generic;
using Android.Runtime;

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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/event/base/EventKey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventKey); }
		}

		protected EventKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event.base']/class[@name='EventKey']/constructor[@name='EventKey' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventKey ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EventKey)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
