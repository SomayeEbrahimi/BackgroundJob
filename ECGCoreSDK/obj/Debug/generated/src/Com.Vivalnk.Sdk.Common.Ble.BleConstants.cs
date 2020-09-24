using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BleConstants", DoNotGenerateAcw=true)]
	public partial class BleConstants : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='CLIENT_CHARACTERISTIC_CONFIG']"
		[Register ("CLIENT_CHARACTERISTIC_CONFIG")]
		public static global::Java.Util.UUID ClientCharacteristicConfig {
			get {
				const string __id = "CLIENT_CHARACTERISTIC_CONFIG.Ljava/util/UUID;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_BOND_BONDED']"
		[Register ("STATUS_DEVICE_BOND_BONDED")]
		public const int StatusDeviceBondBonded = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_BOND_BONDING']"
		[Register ("STATUS_DEVICE_BOND_BONDING")]
		public const int StatusDeviceBondBonding = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_BOND_NONE']"
		[Register ("STATUS_DEVICE_BOND_NONE")]
		public const int StatusDeviceBondNone = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_CONNECTED']"
		[Register ("STATUS_DEVICE_CONNECTED")]
		public const int StatusDeviceConnected = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_CONNECTING']"
		[Register ("STATUS_DEVICE_CONNECTING")]
		public const int StatusDeviceConnecting = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_DISABLE_NOTIFY']"
		[Register ("STATUS_DEVICE_DISABLE_NOTIFY")]
		public const int StatusDeviceDisableNotify = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_DISCONNECTED']"
		[Register ("STATUS_DEVICE_DISCONNECTED")]
		public const int StatusDeviceDisconnected = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_DISCONNECTING']"
		[Register ("STATUS_DEVICE_DISCONNECTING")]
		public const int StatusDeviceDisconnecting = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_DISWATCHED']"
		[Register ("STATUS_DEVICE_DISWATCHED")]
		public const int StatusDeviceDiswatched = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_ENABLE_NOTIFY']"
		[Register ("STATUS_DEVICE_ENABLE_NOTIFY")]
		public const int StatusDeviceEnableNotify = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_SERVICE_READY']"
		[Register ("STATUS_DEVICE_SERVICE_READY")]
		public const int StatusDeviceServiceReady = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_DEVICE_WATCHED']"
		[Register ("STATUS_DEVICE_WATCHED")]
		public const int StatusDeviceWatched = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='STATUS_UNKNOWN']"
		[Register ("STATUS_UNKNOWN")]
		public const int StatusUnknown = (int) -1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/BleConstants", typeof (BleConstants));
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

		protected BleConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/constructor[@name='BleConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BleConstants ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/method[@name='getStatusText' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStatusText", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetStatusText (int status)
		{
			const string __id = "getStatusText.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (status);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
