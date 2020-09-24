using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Android.Support.V18.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']"
	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanResult", DoNotGenerateAcw=true)]
	public sealed partial class ScanResult : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
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
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/android/support/v18/scanner/ScanResult", typeof (ScanResult));
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

		internal ScanResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/constructor[@name='ScanResult' and count(parameter)=4 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='com.vivalnk.android.support.v18.scanner.ScanRecord'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothDevice;Lcom/vivalnk/android/support/v18/scanner/ScanRecord;IJ)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe ScanResult (global::Android.Bluetooth.BluetoothDevice device, global::Com.Vivalnk.Android.Support.V18.Scanner.ScanRecord scanRecord, int rssi, long timestampNanos)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/bluetooth/BluetoothDevice;Lcom/vivalnk/android/support/v18/scanner/ScanRecord;IJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((scanRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scanRecord).Handle);
				__args [2] = new JniArgumentValue (rssi);
				__args [3] = new JniArgumentValue (timestampNanos);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/constructor[@name='ScanResult' and count(parameter)=10 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='com.vivalnk.android.support.v18.scanner.ScanRecord'] and parameter[10][@type='long']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothDevice;IIIIIIILcom/vivalnk/android/support/v18/scanner/ScanRecord;J)V", "")]
		public unsafe ScanResult (global::Android.Bluetooth.BluetoothDevice device, int eventType, int primaryPhy, int secondaryPhy, int advertisingSid, int txPower, int rssi, int periodicAdvertisingInterval, global::Com.Vivalnk.Android.Support.V18.Scanner.ScanRecord scanRecord, long timestampNanos)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/bluetooth/BluetoothDevice;IIIIIIILcom/vivalnk/android/support/v18/scanner/ScanRecord;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue (eventType);
				__args [2] = new JniArgumentValue (primaryPhy);
				__args [3] = new JniArgumentValue (secondaryPhy);
				__args [4] = new JniArgumentValue (advertisingSid);
				__args [5] = new JniArgumentValue (txPower);
				__args [6] = new JniArgumentValue (rssi);
				__args [7] = new JniArgumentValue (periodicAdvertisingInterval);
				__args [8] = new JniArgumentValue ((scanRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scanRecord).Handle);
				__args [9] = new JniArgumentValue (timestampNanos);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int AdvertisingSid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getAdvertisingSid' and count(parameter)=0]"
			[Register ("getAdvertisingSid", "()I", "")]
			get {
				const string __id = "getAdvertisingSid.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int DataStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getDataStatus' and count(parameter)=0]"
			[Register ("getDataStatus", "()I", "")]
			get {
				const string __id = "getDataStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Bluetooth.BluetoothDevice Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Landroid/bluetooth/BluetoothDevice;", "")]
			get {
				const string __id = "getDevice.()Landroid/bluetooth/BluetoothDevice;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsConnectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='isConnectable' and count(parameter)=0]"
			[Register ("isConnectable", "()Z", "")]
			get {
				const string __id = "isConnectable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsLegacy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='isLegacy' and count(parameter)=0]"
			[Register ("isLegacy", "()Z", "")]
			get {
				const string __id = "isLegacy.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int PeriodicAdvertisingInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getPeriodicAdvertisingInterval' and count(parameter)=0]"
			[Register ("getPeriodicAdvertisingInterval", "()I", "")]
			get {
				const string __id = "getPeriodicAdvertisingInterval.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int PrimaryPhy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getPrimaryPhy' and count(parameter)=0]"
			[Register ("getPrimaryPhy", "()I", "")]
			get {
				const string __id = "getPrimaryPhy.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int Rssi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getRssi' and count(parameter)=0]"
			[Register ("getRssi", "()I", "")]
			get {
				const string __id = "getRssi.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanRecord ScanRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getScanRecord' and count(parameter)=0]"
			[Register ("getScanRecord", "()Lcom/vivalnk/android/support/v18/scanner/ScanRecord;", "")]
			get {
				const string __id = "getScanRecord.()Lcom/vivalnk/android/support/v18/scanner/ScanRecord;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanRecord> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int SecondaryPhy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getSecondaryPhy' and count(parameter)=0]"
			[Register ("getSecondaryPhy", "()I", "")]
			get {
				const string __id = "getSecondaryPhy.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long TimestampNanos {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getTimestampNanos' and count(parameter)=0]"
			[Register ("getTimestampNanos", "()J", "")]
			get {
				const string __id = "getTimestampNanos.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int TxPower {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='getTxPower' and count(parameter)=0]"
			[Register ("getTxPower", "()I", "")]
			get {
				const string __id = "getTxPower.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanResult']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
