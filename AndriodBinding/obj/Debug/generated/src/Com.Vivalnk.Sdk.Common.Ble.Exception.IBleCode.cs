using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Exception {

	[Register ("com/vivalnk/sdk/common/ble/exception/BleCode", DoNotGenerateAcw=true)]
	public abstract class BleCode : Java.Lang.Object {

		internal BleCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='BLUETOOTH_CANNOT_CANNOT_WRITE']"
		[Register ("BLUETOOTH_CANNOT_CANNOT_WRITE")]
		public const int BluetoothCannotCannotWrite = (int) 3104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='BLUETOOTH_CANNOT_GET_GATT_SERVICE']"
		[Register ("BLUETOOTH_CANNOT_GET_GATT_SERVICE")]
		public const int BluetoothCannotGetGattService = (int) 3102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='BLUETOOTH_CANNOT_GET_INFO_SERVICE']"
		[Register ("BLUETOOTH_CANNOT_GET_INFO_SERVICE")]
		public const int BluetoothCannotGetInfoService = (int) 3103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='BLUETOOTH_CANNOT_OPEN_GATT']"
		[Register ("BLUETOOTH_CANNOT_OPEN_GATT")]
		public const int BluetoothCannotOpenGatt = (int) 3101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='BLUETOOTH_CANNOT_START_SCAN']"
		[Register ("BLUETOOTH_CANNOT_START_SCAN")]
		public const int BluetoothCannotStartScan = (int) 3001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='BLUETOOTH_CONNECT_ERROR']"
		[Register ("BLUETOOTH_CONNECT_ERROR")]
		public const int BluetoothConnectError = (int) 3106;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='BLUETOOTH_CONNECT_TIMEOUT']"
		[Register ("BLUETOOTH_CONNECT_TIMEOUT")]
		public const int BluetoothConnectTimeout = (int) 3105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='BLUETOOTH_CONNECT_USER_CANCEL_BOND']"
		[Register ("BLUETOOTH_CONNECT_USER_CANCEL_BOND")]
		public const int BluetoothConnectUserCancelBond = (int) 3107;

		static IntPtr BLUETOOTH_NOT_AVAILABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='BLUETOOTH_NOT_AVAILABLE']"
		[Register ("BLUETOOTH_NOT_AVAILABLE")]
		public static int BluetoothNotAvailable {
			get {
				if (BLUETOOTH_NOT_AVAILABLE_jfieldId == IntPtr.Zero)
					BLUETOOTH_NOT_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLUETOOTH_NOT_AVAILABLE", "I");
				return JNIEnv.GetStaticIntField (class_ref, BLUETOOTH_NOT_AVAILABLE_jfieldId);
			}
		}

		static IntPtr BLUETOOTH_NOT_ENABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='BLUETOOTH_NOT_ENABLED']"
		[Register ("BLUETOOTH_NOT_ENABLED")]
		public static int BluetoothNotEnabled {
			get {
				if (BLUETOOTH_NOT_ENABLED_jfieldId == IntPtr.Zero)
					BLUETOOTH_NOT_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLUETOOTH_NOT_ENABLED", "I");
				return JNIEnv.GetStaticIntField (class_ref, BLUETOOTH_NOT_ENABLED_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='CHARACTERISTIC_WRITE_EXCEPTION']"
		[Register ("CHARACTERISTIC_WRITE_EXCEPTION")]
		public const int CharacteristicWriteException = (int) 3208;

		static IntPtr LOCATION_NOT_ENABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='LOCATION_NOT_ENABLED']"
		[Register ("LOCATION_NOT_ENABLED")]
		public static int LocationNotEnabled {
			get {
				if (LOCATION_NOT_ENABLED_jfieldId == IntPtr.Zero)
					LOCATION_NOT_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_NOT_ENABLED", "I");
				return JNIEnv.GetStaticIntField (class_ref, LOCATION_NOT_ENABLED_jfieldId);
			}
		}

		static IntPtr NOT_SUPPORT_BLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='NOT_SUPPORT_BLE']"
		[Register ("NOT_SUPPORT_BLE")]
		public static int NotSupportBle {
			get {
				if (NOT_SUPPORT_BLE_jfieldId == IntPtr.Zero)
					NOT_SUPPORT_BLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SUPPORT_BLE", "I");
				return JNIEnv.GetStaticIntField (class_ref, NOT_SUPPORT_BLE_jfieldId);
			}
		}

		static IntPtr NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='NO_BLUETOOTH_ADMIN_PERMISSION']"
		[Register ("NO_BLUETOOTH_ADMIN_PERMISSION")]
		public static int NoBluetoothAdminPermission {
			get {
				if (NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId == IntPtr.Zero)
					NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_BLUETOOTH_ADMIN_PERMISSION", "I");
				return JNIEnv.GetStaticIntField (class_ref, NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId);
			}
		}

		static IntPtr NO_BLUETOOTH_PERMISSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='NO_BLUETOOTH_PERMISSION']"
		[Register ("NO_BLUETOOTH_PERMISSION")]
		public static int NoBluetoothPermission {
			get {
				if (NO_BLUETOOTH_PERMISSION_jfieldId == IntPtr.Zero)
					NO_BLUETOOTH_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_BLUETOOTH_PERMISSION", "I");
				return JNIEnv.GetStaticIntField (class_ref, NO_BLUETOOTH_PERMISSION_jfieldId);
			}
		}

		static IntPtr NO_LOCATION_PERMISSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='NO_LOCATION_PERMISSION']"
		[Register ("NO_LOCATION_PERMISSION")]
		public static int NoLocationPermission {
			get {
				if (NO_LOCATION_PERMISSION_jfieldId == IntPtr.Zero)
					NO_LOCATION_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_LOCATION_PERMISSION", "I");
				return JNIEnv.GetStaticIntField (class_ref, NO_LOCATION_PERMISSION_jfieldId);
			}
		}

		static IntPtr NO_SDCARD_PERMISSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='NO_SDCARD_PERMISSION']"
		[Register ("NO_SDCARD_PERMISSION")]
		public static int NoSdcardPermission {
			get {
				if (NO_SDCARD_PERMISSION_jfieldId == IntPtr.Zero)
					NO_SDCARD_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_SDCARD_PERMISSION", "I");
				return JNIEnv.GetStaticIntField (class_ref, NO_SDCARD_PERMISSION_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='REQUEST_CANCELED']"
		[Register ("REQUEST_CANCELED")]
		public const int RequestCanceled = (int) 3201;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='REQUEST_EXCEPTION']"
		[Register ("REQUEST_EXCEPTION")]
		public const int RequestException = (int) 3200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='REQUEST_FAILED']"
		[Register ("REQUEST_FAILED")]
		public const int RequestFailed = (int) 3204;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='REQUEST_FAILED_ALREADY_CONNECTED']"
		[Register ("REQUEST_FAILED_ALREADY_CONNECTED")]
		public const int RequestFailedAlreadyConnected = (int) 3207;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='REQUEST_FAILED_DISCONNECTED']"
		[Register ("REQUEST_FAILED_DISCONNECTED")]
		public const int RequestFailedDisconnected = (int) 3206;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='REQUEST_MTU_LOWAPI_EXCEPTION']"
		[Register ("REQUEST_MTU_LOWAPI_EXCEPTION")]
		public const int RequestMtuLowapiException = (int) 3209;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='REQUEST_OVERFLOW']"
		[Register ("REQUEST_OVERFLOW")]
		public const int RequestOverflow = (int) 3203;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='REQUEST_SUCCESS']"
		[Register ("REQUEST_SUCCESS")]
		public const int RequestSuccess = (int) 3205;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='REQUEST_TIMEDOUT']"
		[Register ("REQUEST_TIMEDOUT")]
		public const int RequestTimedout = (int) 3202;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='RESULT_OK']"
		[Register ("RESULT_OK")]
		public const int ResultOk = (int) 0;

		static IntPtr SDCARD_NOT_AVAILABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.exception']/interface[@name='BleCode']/field[@name='SDCARD_NOT_AVAILABLE']"
		[Register ("SDCARD_NOT_AVAILABLE")]
		public static int SdcardNotAvailable {
			get {
				if (SDCARD_NOT_AVAILABLE_jfieldId == IntPtr.Zero)
					SDCARD_NOT_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SDCARD_NOT_AVAILABLE", "I");
				return JNIEnv.GetStaticIntField (class_ref, SDCARD_NOT_AVAILABLE_jfieldId);
			}
		}

		new static IntPtr class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/exception/BleCode");
	}

	[Register ("com/vivalnk/sdk/common/ble/exception/BleCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BleCode' type. This type will be removed in a future release.", error: true)]
	public abstract class BleCodeConsts : BleCode {

		private BleCodeConsts ()
		{
		}
	}

}
