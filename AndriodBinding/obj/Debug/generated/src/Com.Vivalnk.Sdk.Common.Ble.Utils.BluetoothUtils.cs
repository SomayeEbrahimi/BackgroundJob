using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/utils/BluetoothUtils", DoNotGenerateAcw=true)]
	public partial class BluetoothUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/utils/BluetoothUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BluetoothUtils); }
		}

		protected BluetoothUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/constructor[@name='BluetoothUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BluetoothUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BluetoothUtils)) {
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

		static IntPtr id_getBluetoothAdapter;
		public static unsafe global::Android.Bluetooth.BluetoothAdapter BluetoothAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getBluetoothAdapter' and count(parameter)=0]"
			[Register ("getBluetoothAdapter", "()Landroid/bluetooth/BluetoothAdapter;", "")]
			get {
				if (id_getBluetoothAdapter == IntPtr.Zero)
					id_getBluetoothAdapter = JNIEnv.GetStaticMethodID (class_ref, "getBluetoothAdapter", "()Landroid/bluetooth/BluetoothAdapter;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothAdapter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBluetoothAdapter), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getBluetoothState;
		public static unsafe int BluetoothState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getBluetoothState' and count(parameter)=0]"
			[Register ("getBluetoothState", "()I", "")]
			get {
				if (id_getBluetoothState == IntPtr.Zero)
					id_getBluetoothState = JNIEnv.GetStaticMethodID (class_ref, "getBluetoothState", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getBluetoothState);
				} finally {
				}
			}
		}

		static IntPtr id_getBondedBluetoothClassicDevices;
		public static unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> BondedBluetoothClassicDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getBondedBluetoothClassicDevices' and count(parameter)=0]"
			[Register ("getBondedBluetoothClassicDevices", "()Ljava/util/List;", "")]
			get {
				if (id_getBondedBluetoothClassicDevices == IntPtr.Zero)
					id_getBondedBluetoothClassicDevices = JNIEnv.GetStaticMethodID (class_ref, "getBondedBluetoothClassicDevices", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBondedBluetoothClassicDevices), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getContext;
		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetStaticMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isBluetoothEnabled;
		public static unsafe bool IsBluetoothEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isBluetoothEnabled' and count(parameter)=0]"
			[Register ("isBluetoothEnabled", "()Z", "")]
			get {
				if (id_isBluetoothEnabled == IntPtr.Zero)
					id_isBluetoothEnabled = JNIEnv.GetStaticMethodID (class_ref, "isBluetoothEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBluetoothEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_checkMainThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='checkMainThread' and count(parameter)=0]"
		[Register ("checkMainThread", "()Z", "")]
		public static unsafe bool CheckMainThread ()
		{
			if (id_checkMainThread == IntPtr.Zero)
				id_checkMainThread = JNIEnv.GetStaticMethodID (class_ref, "checkMainThread", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkMainThread);
			} finally {
			}
		}

		static IntPtr id_closeBluetooth;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='closeBluetooth' and count(parameter)=0]"
		[Register ("closeBluetooth", "()Z", "")]
		public static unsafe bool CloseBluetooth ()
		{
			if (id_closeBluetooth == IntPtr.Zero)
				id_closeBluetooth = JNIEnv.GetStaticMethodID (class_ref, "closeBluetooth", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_closeBluetooth);
			} finally {
			}
		}

		static IntPtr id_creatBond_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='creatBond' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("creatBond", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool CreatBond (string mac)
		{
			if (id_creatBond_Ljava_lang_String_ == IntPtr.Zero)
				id_creatBond_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "creatBond", "(Ljava/lang/String;)Z");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_creatBond_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static IntPtr id_getBluetoothManager_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getBluetoothManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getBluetoothManager", "(Landroid/content/Context;)Landroid/bluetooth/BluetoothManager;", "")]
		public static unsafe global::Android.Bluetooth.BluetoothManager GetBluetoothManager (global::Android.Content.Context context)
		{
			if (id_getBluetoothManager_Landroid_content_Context_ == IntPtr.Zero)
				id_getBluetoothManager_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getBluetoothManager", "(Landroid/content/Context;)Landroid/bluetooth/BluetoothManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				global::Android.Bluetooth.BluetoothManager __ret = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBluetoothManager_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBondState_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getBondState' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBondState", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetBondState (global::Android.Content.Context context, string mac)
		{
			if (id_getBondState_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getBondState_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBondState", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_mac);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getBondState_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static IntPtr id_getConnectStatus_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getConnectStatus' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getConnectStatus", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetConnectStatus (global::Android.Content.Context context, string mac)
		{
			if (id_getConnectStatus_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getConnectStatus_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getConnectStatus", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_mac);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getConnectStatus_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static IntPtr id_getConnectedBluetoothLeDevices_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getConnectedBluetoothLeDevices' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getConnectedBluetoothLeDevices", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> GetConnectedBluetoothLeDevices (global::Android.Content.Context context)
		{
			if (id_getConnectedBluetoothLeDevices_Landroid_content_Context_ == IntPtr.Zero)
				id_getConnectedBluetoothLeDevices_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getConnectedBluetoothLeDevices", "(Landroid/content/Context;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> __ret = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConnectedBluetoothLeDevices_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDeviceConnectState_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getDeviceConnectState' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDeviceConnectState", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetDeviceConnectState (global::Android.Content.Context context, string mac)
		{
			if (id_getDeviceConnectState_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getDeviceConnectState_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceConnectState", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_mac);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getDeviceConnectState_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static IntPtr id_getRemoteDevice_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='getRemoteDevice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRemoteDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;", "")]
		public static unsafe global::Android.Bluetooth.BluetoothDevice GetRemoteDevice (string mac)
		{
			if (id_getRemoteDevice_Ljava_lang_String_ == IntPtr.Zero)
				id_getRemoteDevice_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRemoteDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);
				global::Android.Bluetooth.BluetoothDevice __ret = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRemoteDevice_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context context)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_isBleSupported_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isBleSupported' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isBleSupported", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsBleSupported (global::Android.Content.Context context)
		{
			if (id_isBleSupported_Landroid_content_Context_ == IntPtr.Zero)
				id_isBleSupported_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isBleSupported", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBleSupported_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isCharacteristicIndicatable_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isCharacteristicIndicatable' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("isCharacteristicIndicatable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool IsCharacteristicIndicatable (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
		{
			if (id_isCharacteristicIndicatable_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
				id_isCharacteristicIndicatable_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetStaticMethodID (class_ref, "isCharacteristicIndicatable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (characteristic);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCharacteristicIndicatable_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isCharacteristicNoRspWritable_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isCharacteristicNoRspWritable' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("isCharacteristicNoRspWritable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool IsCharacteristicNoRspWritable (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
		{
			if (id_isCharacteristicNoRspWritable_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
				id_isCharacteristicNoRspWritable_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetStaticMethodID (class_ref, "isCharacteristicNoRspWritable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (characteristic);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCharacteristicNoRspWritable_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isCharacteristicNotifyable_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isCharacteristicNotifyable' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("isCharacteristicNotifyable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool IsCharacteristicNotifyable (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
		{
			if (id_isCharacteristicNotifyable_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
				id_isCharacteristicNotifyable_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetStaticMethodID (class_ref, "isCharacteristicNotifyable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (characteristic);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCharacteristicNotifyable_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isCharacteristicReadable_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isCharacteristicReadable' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("isCharacteristicReadable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool IsCharacteristicReadable (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
		{
			if (id_isCharacteristicReadable_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
				id_isCharacteristicReadable_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetStaticMethodID (class_ref, "isCharacteristicReadable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (characteristic);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCharacteristicReadable_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isCharacteristicWritable_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isCharacteristicWritable' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("isCharacteristicWritable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool IsCharacteristicWritable (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
		{
			if (id_isCharacteristicWritable_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
				id_isCharacteristicWritable_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetStaticMethodID (class_ref, "isCharacteristicWritable", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (characteristic);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCharacteristicWritable_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isDeviceBonded_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isDeviceBonded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isDeviceBonded", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsDeviceBonded (string mac)
		{
			if (id_isDeviceBonded_Ljava_lang_String_ == IntPtr.Zero)
				id_isDeviceBonded_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isDeviceBonded", "(Ljava/lang/String;)Z");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDeviceBonded_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static IntPtr id_isDeviceConnected_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='isDeviceConnected' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("isDeviceConnected", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsDeviceConnected (global::Android.Content.Context context, string mac)
		{
			if (id_isDeviceConnected_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_isDeviceConnected_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isDeviceConnected", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_mac);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDeviceConnected_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static IntPtr id_openBluetooth;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='openBluetooth' and count(parameter)=0]"
		[Register ("openBluetooth", "()Z", "")]
		public static unsafe bool OpenBluetooth ()
		{
			if (id_openBluetooth == IntPtr.Zero)
				id_openBluetooth = JNIEnv.GetStaticMethodID (class_ref, "openBluetooth", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_openBluetooth);
			} finally {
			}
		}

		static IntPtr id_refreshGattCache_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='refreshGattCache' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("refreshGattCache", "(Landroid/bluetooth/BluetoothGatt;)Z", "")]
		public static unsafe bool RefreshGattCache (global::Android.Bluetooth.BluetoothGatt gatt)
		{
			if (id_refreshGattCache_Landroid_bluetooth_BluetoothGatt_ == IntPtr.Zero)
				id_refreshGattCache_Landroid_bluetooth_BluetoothGatt_ = JNIEnv.GetStaticMethodID (class_ref, "refreshGattCache", "(Landroid/bluetooth/BluetoothGatt;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (gatt);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_refreshGattCache_Landroid_bluetooth_BluetoothGatt_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_registerReceiver_Landroid_content_Context_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='registerReceiver' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.BroadcastReceiver'] and parameter[3][@type='android.content.IntentFilter']]"
		[Register ("registerReceiver", "(Landroid/content/Context;Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)V", "")]
		public static unsafe void RegisterReceiver (global::Android.Content.Context context, global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter)
		{
			if (id_registerReceiver_Landroid_content_Context_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ == IntPtr.Zero)
				id_registerReceiver_Landroid_content_Context_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ = JNIEnv.GetStaticMethodID (class_ref, "registerReceiver", "(Landroid/content/Context;Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (receiver);
				__args [2] = new JValue (filter);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerReceiver_Landroid_content_Context_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_, __args);
			} finally {
			}
		}

		static IntPtr id_removeBond_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='removeBond' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeBond", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveBond (string mac)
		{
			if (id_removeBond_Ljava_lang_String_ == IntPtr.Zero)
				id_removeBond_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeBond", "(Ljava/lang/String;)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeBond_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static IntPtr id_sendBroadcast_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='sendBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("sendBroadcast", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void SendBroadcast (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			if (id_sendBroadcast_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_sendBroadcast_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "sendBroadcast", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (intent);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendBroadcast_Landroid_content_Context_Landroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='sendBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendBroadcast", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SendBroadcast (global::Android.Content.Context context, string action)
		{
			if (id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendBroadcast", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_action = JNIEnv.NewString (action);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_action);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_action);
			}
		}

		static IntPtr id_unregisterReceiver_Landroid_content_Context_Landroid_content_BroadcastReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothUtils']/method[@name='unregisterReceiver' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.BroadcastReceiver']]"
		[Register ("unregisterReceiver", "(Landroid/content/Context;Landroid/content/BroadcastReceiver;)V", "")]
		public static unsafe void UnregisterReceiver (global::Android.Content.Context context, global::Android.Content.BroadcastReceiver receiver)
		{
			if (id_unregisterReceiver_Landroid_content_Context_Landroid_content_BroadcastReceiver_ == IntPtr.Zero)
				id_unregisterReceiver_Landroid_content_Context_Landroid_content_BroadcastReceiver_ = JNIEnv.GetStaticMethodID (class_ref, "unregisterReceiver", "(Landroid/content/Context;Landroid/content/BroadcastReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (receiver);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregisterReceiver_Landroid_content_Context_Landroid_content_BroadcastReceiver_, __args);
			} finally {
			}
		}

	}
}
