using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BleConstants", DoNotGenerateAcw=true)]
	public partial class BleConstants : global::Java.Lang.Object {


		static IntPtr CLIENT_CHARACTERISTIC_CONFIG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/field[@name='CLIENT_CHARACTERISTIC_CONFIG']"
		[Register ("CLIENT_CHARACTERISTIC_CONFIG")]
		public static global::Java.Util.UUID ClientCharacteristicConfig {
			get {
				if (CLIENT_CHARACTERISTIC_CONFIG_jfieldId == IntPtr.Zero)
					CLIENT_CHARACTERISTIC_CONFIG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_CHARACTERISTIC_CONFIG", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_CHARACTERISTIC_CONFIG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/BleConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleConstants); }
		}

		protected BleConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/constructor[@name='BleConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BleConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BleConstants)) {
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

		static IntPtr id_getStatusText_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleConstants']/method[@name='getStatusText' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStatusText", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetStatusText (int status)
		{
			if (id_getStatusText_I == IntPtr.Zero)
				id_getStatusText_I = JNIEnv.GetStaticMethodID (class_ref, "getStatusText", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (status);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStatusText_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
