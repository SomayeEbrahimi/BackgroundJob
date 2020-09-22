using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Android.Support.V18.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']"
	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanResult", DoNotGenerateAcw=true)]
	public sealed partial class ScanResult : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/field[@name='DATA_COMPLETE']"
		[Register ("DATA_COMPLETE")]
		public const int DataComplete = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/field[@name='DATA_TRUNCATED']"
		[Register ("DATA_TRUNCATED")]
		public const int DataTruncated = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/field[@name='PERIODIC_INTERVAL_NOT_PRESENT']"
		[Register ("PERIODIC_INTERVAL_NOT_PRESENT")]
		public const int PeriodicIntervalNotPresent = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/field[@name='PHY_UNUSED']"
		[Register ("PHY_UNUSED")]
		public const int PhyUnused = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/field[@name='SID_NOT_PRESENT']"
		[Register ("SID_NOT_PRESENT")]
		public const int SidNotPresent = (int) 255;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/field[@name='TX_POWER_NOT_PRESENT']"
		[Register ("TX_POWER_NOT_PRESENT")]
		public const int TxPowerNotPresent = (int) 127;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/android/support/v18/scanner/ScanResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScanResult); }
		}

		internal ScanResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_bluetooth_BluetoothDevice_Lcom_vivalnk_android_support_v18_scanner_ScanRecord_IJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/constructor[@name='ScanResult' and count(parameter)=4 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='com.vivalnk.android.support.v18.scanner.ScanRecord'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothDevice;Lcom/vivalnk/android/support/v18/scanner/ScanRecord;IJ)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe ScanResult (global::Android.Bluetooth.BluetoothDevice device, global::Com.Vivalnk.Android.Support.V18.Scanner.ScanRecord scanRecord, int rssi, long timestampNanos)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (device);
				__args [1] = new JValue (scanRecord);
				__args [2] = new JValue (rssi);
				__args [3] = new JValue (timestampNanos);
				if (((object) this).GetType () != typeof (ScanResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/bluetooth/BluetoothDevice;Lcom/vivalnk/android/support/v18/scanner/ScanRecord;IJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/bluetooth/BluetoothDevice;Lcom/vivalnk/android/support/v18/scanner/ScanRecord;IJ)V", __args);
					return;
				}

				if (id_ctor_Landroid_bluetooth_BluetoothDevice_Lcom_vivalnk_android_support_v18_scanner_ScanRecord_IJ == IntPtr.Zero)
					id_ctor_Landroid_bluetooth_BluetoothDevice_Lcom_vivalnk_android_support_v18_scanner_ScanRecord_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/bluetooth/BluetoothDevice;Lcom/vivalnk/android/support/v18/scanner/ScanRecord;IJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_bluetooth_BluetoothDevice_Lcom_vivalnk_android_support_v18_scanner_ScanRecord_IJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_bluetooth_BluetoothDevice_Lcom_vivalnk_android_support_v18_scanner_ScanRecord_IJ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_bluetooth_BluetoothDevice_IIIIIIILcom_vivalnk_android_support_v18_scanner_ScanRecord_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/constructor[@name='ScanResult' and count(parameter)=10 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='com.vivalnk.android.support.v18.scanner.ScanRecord'] and parameter[10][@type='long']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothDevice;IIIIIIILcom/vivalnk/android/support/v18/scanner/ScanRecord;J)V", "")]
		public unsafe ScanResult (global::Android.Bluetooth.BluetoothDevice device, int eventType, int primaryPhy, int secondaryPhy, int advertisingSid, int txPower, int rssi, int periodicAdvertisingInterval, global::Com.Vivalnk.Android.Support.V18.Scanner.ScanRecord scanRecord, long timestampNanos)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (device);
				__args [1] = new JValue (eventType);
				__args [2] = new JValue (primaryPhy);
				__args [3] = new JValue (secondaryPhy);
				__args [4] = new JValue (advertisingSid);
				__args [5] = new JValue (txPower);
				__args [6] = new JValue (rssi);
				__args [7] = new JValue (periodicAdvertisingInterval);
				__args [8] = new JValue (scanRecord);
				__args [9] = new JValue (timestampNanos);
				if (((object) this).GetType () != typeof (ScanResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/bluetooth/BluetoothDevice;IIIIIIILcom/vivalnk/android/support/v18/scanner/ScanRecord;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/bluetooth/BluetoothDevice;IIIIIIILcom/vivalnk/android/support/v18/scanner/ScanRecord;J)V", __args);
					return;
				}

				if (id_ctor_Landroid_bluetooth_BluetoothDevice_IIIIIIILcom_vivalnk_android_support_v18_scanner_ScanRecord_J == IntPtr.Zero)
					id_ctor_Landroid_bluetooth_BluetoothDevice_IIIIIIILcom_vivalnk_android_support_v18_scanner_ScanRecord_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/bluetooth/BluetoothDevice;IIIIIIILcom/vivalnk/android/support/v18/scanner/ScanRecord;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_bluetooth_BluetoothDevice_IIIIIIILcom_vivalnk_android_support_v18_scanner_ScanRecord_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_bluetooth_BluetoothDevice_IIIIIIILcom_vivalnk_android_support_v18_scanner_ScanRecord_J, __args);
			} finally {
			}
		}

		static IntPtr id_getAdvertisingSid;
		public unsafe int AdvertisingSid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getAdvertisingSid' and count(parameter)=0]"
			[Register ("getAdvertisingSid", "()I", "")]
			get {
				if (id_getAdvertisingSid == IntPtr.Zero)
					id_getAdvertisingSid = JNIEnv.GetMethodID (class_ref, "getAdvertisingSid", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdvertisingSid);
				} finally {
				}
			}
		}

		static IntPtr id_getDataStatus;
		public unsafe int DataStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getDataStatus' and count(parameter)=0]"
			[Register ("getDataStatus", "()I", "")]
			get {
				if (id_getDataStatus == IntPtr.Zero)
					id_getDataStatus = JNIEnv.GetMethodID (class_ref, "getDataStatus", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDataStatus);
				} finally {
				}
			}
		}

		static IntPtr id_getDevice;
		public unsafe global::Android.Bluetooth.BluetoothDevice Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Landroid/bluetooth/BluetoothDevice;", "")]
			get {
				if (id_getDevice == IntPtr.Zero)
					id_getDevice = JNIEnv.GetMethodID (class_ref, "getDevice", "()Landroid/bluetooth/BluetoothDevice;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDevice), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isConnectable;
		public unsafe bool IsConnectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='isConnectable' and count(parameter)=0]"
			[Register ("isConnectable", "()Z", "")]
			get {
				if (id_isConnectable == IntPtr.Zero)
					id_isConnectable = JNIEnv.GetMethodID (class_ref, "isConnectable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnectable);
				} finally {
				}
			}
		}

		static IntPtr id_isLegacy;
		public unsafe bool IsLegacy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='isLegacy' and count(parameter)=0]"
			[Register ("isLegacy", "()Z", "")]
			get {
				if (id_isLegacy == IntPtr.Zero)
					id_isLegacy = JNIEnv.GetMethodID (class_ref, "isLegacy", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLegacy);
				} finally {
				}
			}
		}

		static IntPtr id_getPeriodicAdvertisingInterval;
		public unsafe int PeriodicAdvertisingInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getPeriodicAdvertisingInterval' and count(parameter)=0]"
			[Register ("getPeriodicAdvertisingInterval", "()I", "")]
			get {
				if (id_getPeriodicAdvertisingInterval == IntPtr.Zero)
					id_getPeriodicAdvertisingInterval = JNIEnv.GetMethodID (class_ref, "getPeriodicAdvertisingInterval", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPeriodicAdvertisingInterval);
				} finally {
				}
			}
		}

		static IntPtr id_getPrimaryPhy;
		public unsafe int PrimaryPhy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getPrimaryPhy' and count(parameter)=0]"
			[Register ("getPrimaryPhy", "()I", "")]
			get {
				if (id_getPrimaryPhy == IntPtr.Zero)
					id_getPrimaryPhy = JNIEnv.GetMethodID (class_ref, "getPrimaryPhy", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPrimaryPhy);
				} finally {
				}
			}
		}

		static IntPtr id_getRssi;
		public unsafe int Rssi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getRssi' and count(parameter)=0]"
			[Register ("getRssi", "()I", "")]
			get {
				if (id_getRssi == IntPtr.Zero)
					id_getRssi = JNIEnv.GetMethodID (class_ref, "getRssi", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRssi);
				} finally {
				}
			}
		}

		static IntPtr id_getScanRecord;
		public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanRecord ScanRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getScanRecord' and count(parameter)=0]"
			[Register ("getScanRecord", "()Lcom/vivalnk/android/support/v18/scanner/ScanRecord;", "")]
			get {
				if (id_getScanRecord == IntPtr.Zero)
					id_getScanRecord = JNIEnv.GetMethodID (class_ref, "getScanRecord", "()Lcom/vivalnk/android/support/v18/scanner/ScanRecord;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanRecord> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScanRecord), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSecondaryPhy;
		public unsafe int SecondaryPhy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getSecondaryPhy' and count(parameter)=0]"
			[Register ("getSecondaryPhy", "()I", "")]
			get {
				if (id_getSecondaryPhy == IntPtr.Zero)
					id_getSecondaryPhy = JNIEnv.GetMethodID (class_ref, "getSecondaryPhy", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSecondaryPhy);
				} finally {
				}
			}
		}

		static IntPtr id_getTimestampNanos;
		public unsafe long TimestampNanos {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getTimestampNanos' and count(parameter)=0]"
			[Register ("getTimestampNanos", "()J", "")]
			get {
				if (id_getTimestampNanos == IntPtr.Zero)
					id_getTimestampNanos = JNIEnv.GetMethodID (class_ref, "getTimestampNanos", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimestampNanos);
				} finally {
				}
			}
		}

		static IntPtr id_getTxPower;
		public unsafe int TxPower {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getTxPower' and count(parameter)=0]"
			[Register ("getTxPower", "()I", "")]
			get {
				if (id_getTxPower == IntPtr.Zero)
					id_getTxPower = JNIEnv.GetMethodID (class_ref, "getTxPower", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTxPower);
				} finally {
				}
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
