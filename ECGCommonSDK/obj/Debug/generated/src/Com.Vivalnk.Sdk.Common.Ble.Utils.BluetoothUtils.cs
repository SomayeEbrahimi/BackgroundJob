using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/utils/BluetoothUtils", DoNotGenerateAcw=true)]
	public partial class BluetoothUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/utils/BluetoothUtils", typeof (BluetoothUtils));
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

		protected BluetoothUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/constructor[@name='BluetoothUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BluetoothUtils ()
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

		public static unsafe global::Android.Bluetooth.BluetoothAdapter BluetoothAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getBluetoothAdapter' and count(parameter)=0]"
			[Register ("getBluetoothAdapter", "()Landroid/bluetooth/BluetoothAdapter;", "")]
			get {
				const string __id = "getBluetoothAdapter.()Landroid/bluetooth/BluetoothAdapter;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int BluetoothState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getBluetoothState' and count(parameter)=0]"
			[Register ("getBluetoothState", "()I", "")]
			get {
				const string __id = "getBluetoothState.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> BondedBluetoothClassicDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getBondedBluetoothClassicDevices' and count(parameter)=0]"
			[Register ("getBondedBluetoothClassicDevices", "()Ljava/util/List;", "")]
			get {
				const string __id = "getBondedBluetoothClassicDevices.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool IsBluetoothEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isBluetoothEnabled' and count(parameter)=0]"
			[Register ("isBluetoothEnabled", "()Z", "")]
			get {
				const string __id = "isBluetoothEnabled.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='checkMainThread' and count(parameter)=0]"
		[Register ("checkMainThread", "()Z", "")]
		public static unsafe bool CheckMainThread ()
		{
			const string __id = "checkMainThread.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='closeBluetooth' and count(parameter)=0]"
		[Register ("closeBluetooth", "()Z", "")]
		public static unsafe bool CloseBluetooth ()
		{
			const string __id = "closeBluetooth.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='creatBond' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("creatBond", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool CreatBond (string mac)
		{
			const string __id = "creatBond.(Ljava/lang/String;)Z";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getBluetoothManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getBluetoothManager", "(Landroid/content/Context;)Landroid/bluetooth/BluetoothManager;", "")]
		public static unsafe global::Android.Bluetooth.BluetoothManager GetBluetoothManager (global::Android.Content.Context context)
		{
			const string __id = "getBluetoothManager.(Landroid/content/Context;)Landroid/bluetooth/BluetoothManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getBondState' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBondState", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetBondState (global::Android.Content.Context context, string mac)
		{
			const string __id = "getBondState.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_mac);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getConnectStatus' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getConnectStatus", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetConnectStatus (global::Android.Content.Context context, string mac)
		{
			const string __id = "getConnectStatus.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_mac);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getConnectedBluetoothLeDevices' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getConnectedBluetoothLeDevices", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> GetConnectedBluetoothLeDevices (global::Android.Content.Context context)
		{
			const string __id = "getConnectedBluetoothLeDevices.(Landroid/content/Context;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getDeviceConnectState' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDeviceConnectState", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetDeviceConnectState (global::Android.Content.Context context, string mac)
		{
			const string __id = "getDeviceConnectState.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_mac);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getRemoteDevice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRemoteDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;", "")]
		public static unsafe global::Android.Bluetooth.BluetoothDevice GetRemoteDevice (string mac)
		{
			const string __id = "getRemoteDevice.(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context context)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isBleSupported' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isBleSupported", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsBleSupported (global::Android.Content.Context context)
		{
			const string __id = "isBleSupported.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isCharacteristicIndicatable' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("isCharacteristicIndicatable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool IsCharacteristicIndicatable (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
		{
			const string __id = "isCharacteristicIndicatable.(Landroid/bluetooth/BluetoothGattCharacteristic;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isCharacteristicNoRspWritable' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("isCharacteristicNoRspWritable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool IsCharacteristicNoRspWritable (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
		{
			const string __id = "isCharacteristicNoRspWritable.(Landroid/bluetooth/BluetoothGattCharacteristic;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isCharacteristicNotifyable' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("isCharacteristicNotifyable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool IsCharacteristicNotifyable (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
		{
			const string __id = "isCharacteristicNotifyable.(Landroid/bluetooth/BluetoothGattCharacteristic;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isCharacteristicReadable' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("isCharacteristicReadable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool IsCharacteristicReadable (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
		{
			const string __id = "isCharacteristicReadable.(Landroid/bluetooth/BluetoothGattCharacteristic;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isCharacteristicWritable' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("isCharacteristicWritable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool IsCharacteristicWritable (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
		{
			const string __id = "isCharacteristicWritable.(Landroid/bluetooth/BluetoothGattCharacteristic;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isDeviceBonded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isDeviceBonded", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsDeviceBonded (string mac)
		{
			const string __id = "isDeviceBonded.(Ljava/lang/String;)Z";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isDeviceConnected' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("isDeviceConnected", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsDeviceConnected (global::Android.Content.Context context, string mac)
		{
			const string __id = "isDeviceConnected.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_mac);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='openBluetooth' and count(parameter)=0]"
		[Register ("openBluetooth", "()Z", "")]
		public static unsafe bool OpenBluetooth ()
		{
			const string __id = "openBluetooth.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='refreshGattCache' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("refreshGattCache", "(Landroid/bluetooth/BluetoothGatt;)Z", "")]
		public static unsafe bool RefreshGattCache (global::Android.Bluetooth.BluetoothGatt gatt)
		{
			const string __id = "refreshGattCache.(Landroid/bluetooth/BluetoothGatt;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='registerReceiver' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.BroadcastReceiver'] and parameter[3][@type='android.content.IntentFilter']]"
		[Register ("registerReceiver", "(Landroid/content/Context;Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)V", "")]
		public static unsafe void RegisterReceiver (global::Android.Content.Context context, global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter)
		{
			const string __id = "registerReceiver.(Landroid/content/Context;Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				__args [2] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='removeBond' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeBond", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveBond (string mac)
		{
			const string __id = "removeBond.(Ljava/lang/String;)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='sendBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("sendBroadcast", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void SendBroadcast (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			const string __id = "sendBroadcast.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='sendBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendBroadcast", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SendBroadcast (global::Android.Content.Context context, string action)
		{
			const string __id = "sendBroadcast.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_action = JNIEnv.NewString (action);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_action);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_action);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='unregisterReceiver' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.BroadcastReceiver']]"
		[Register ("unregisterReceiver", "(Landroid/content/Context;Landroid/content/BroadcastReceiver;)V", "")]
		public static unsafe void UnregisterReceiver (global::Android.Content.Context context, global::Android.Content.BroadcastReceiver receiver)
		{
			const string __id = "unregisterReceiver.(Landroid/content/Context;Landroid/content/BroadcastReceiver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
