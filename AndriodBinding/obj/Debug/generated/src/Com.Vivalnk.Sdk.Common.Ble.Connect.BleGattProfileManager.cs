using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/BleGattProfileManager", DoNotGenerateAcw=true)]
	public partial class BleGattProfileManager : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "BleGattProfileManager";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/BleGattProfileManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleGattProfileManager); }
		}

		protected BleGattProfileManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/constructor[@name='BleGattProfileManager' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.request.DiscoverService.DiscoverServiceListener']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V", "")]
		public unsafe BleGattProfileManager (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (listener);
				if (((object) this).GetType () != typeof (BleGattProfileManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_getBleGattProfile;
#pragma warning disable 0169
		static Delegate GetGetBleGattProfileHandler ()
		{
			if (cb_getBleGattProfile == null)
				cb_getBleGattProfile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBleGattProfile);
			return cb_getBleGattProfile;
		}

		static IntPtr n_GetBleGattProfile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleGattProfileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BleGattProfile);
		}
#pragma warning restore 0169

		static IntPtr id_getBleGattProfile;
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile BleGattProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/method[@name='getBleGattProfile' and count(parameter)=0]"
			[Register ("getBleGattProfile", "()Lcom/vivalnk/sdk/common/ble/model/BleGattProfile;", "GetGetBleGattProfileHandler")]
			get {
				if (id_getBleGattProfile == IntPtr.Zero)
					id_getBleGattProfile = JNIEnv.GetMethodID (class_ref, "getBleGattProfile", "()Lcom/vivalnk/sdk/common/ble/model/BleGattProfile;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBleGattProfile), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBleGattProfile", "()Lcom/vivalnk/sdk/common/ble/model/BleGattProfile;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceProfile;
#pragma warning disable 0169
		static Delegate GetGetDeviceProfileHandler ()
		{
			if (cb_getDeviceProfile == null)
				cb_getDeviceProfile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceProfile);
			return cb_getDeviceProfile;
		}

		static IntPtr n_GetDeviceProfile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleGattProfileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>>.ToLocalJniHandle (__this.DeviceProfile);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceProfile;
		public virtual unsafe global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>> DeviceProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/method[@name='getDeviceProfile' and count(parameter)=0]"
			[Register ("getDeviceProfile", "()Ljava/util/Map;", "GetGetDeviceProfileHandler")]
			get {
				if (id_getDeviceProfile == IntPtr.Zero)
					id_getDeviceProfile = JNIEnv.GetMethodID (class_ref, "getDeviceProfile", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceProfile), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceProfile", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleGattProfileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_getCharacter_Ljava_util_UUID_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetGetCharacter_Ljava_util_UUID_Ljava_util_UUID_Handler ()
		{
			if (cb_getCharacter_Ljava_util_UUID_Ljava_util_UUID_ == null)
				cb_getCharacter_Ljava_util_UUID_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetCharacter_Ljava_util_UUID_Ljava_util_UUID_);
			return cb_getCharacter_Ljava_util_UUID_Ljava_util_UUID_;
		}

		static IntPtr n_GetCharacter_Ljava_util_UUID_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleGattProfileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCharacter (service, character));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCharacter_Ljava_util_UUID_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/method[@name='getCharacter' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID']]"
		[Register ("getCharacter", "(Ljava/util/UUID;Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattCharacteristic;", "GetGetCharacter_Ljava_util_UUID_Ljava_util_UUID_Handler")]
		public virtual unsafe global::Android.Bluetooth.BluetoothGattCharacteristic GetCharacter (global::Java.Util.UUID service, global::Java.Util.UUID character)
		{
			if (id_getCharacter_Ljava_util_UUID_Ljava_util_UUID_ == IntPtr.Zero)
				id_getCharacter_Ljava_util_UUID_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "getCharacter", "(Ljava/util/UUID;Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattCharacteristic;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (service);
				__args [1] = new JValue (character);

				global::Android.Bluetooth.BluetoothGattCharacteristic __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCharacter_Ljava_util_UUID_Ljava_util_UUID_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCharacter", "(Ljava/util/UUID;Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattCharacteristic;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onComplete;
#pragma warning disable 0169
		static Delegate GetOnCompleteHandler ()
		{
			if (cb_onComplete == null)
				cb_onComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnComplete);
			return cb_onComplete;
		}

		static void n_OnComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleGattProfileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete ();
		}
#pragma warning restore 0169

		static IntPtr id_onComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler")]
		public virtual unsafe void OnComplete ()
		{
			if (id_onComplete == IntPtr.Zero)
				id_onComplete = JNIEnv.GetMethodID (class_ref, "onComplete", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onComplete", "()V"));
			} finally {
			}
		}

		static Delegate cb_onError_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnError_ILjava_lang_String_Handler ()
		{
			if (cb_onError_ILjava_lang_String_ == null)
				cb_onError_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnError_ILjava_lang_String_);
			return cb_onError_ILjava_lang_String_;
		}

		static void n_OnError_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleGattProfileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.OnError (code, msg);
		}
#pragma warning restore 0169

		static IntPtr id_onError_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onError", "(ILjava/lang/String;)V", "GetOnError_ILjava_lang_String_Handler")]
		public virtual unsafe void OnError (int code, string msg)
		{
			if (id_onError_ILjava_lang_String_ == IntPtr.Zero)
				id_onError_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(ILjava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (code);
				__args [1] = new JValue (native_msg);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleGattProfileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_setBluetoothGatt_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetSetBluetoothGatt_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_setBluetoothGatt_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_setBluetoothGatt_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBluetoothGatt_Landroid_bluetooth_BluetoothGatt_);
			return cb_setBluetoothGatt_Landroid_bluetooth_BluetoothGatt_;
		}

		static void n_SetBluetoothGatt_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bluetoothGatt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleGattProfileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bluetoothGatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_bluetoothGatt, JniHandleOwnership.DoNotTransfer);
			__this.SetBluetoothGatt (bluetoothGatt);
		}
#pragma warning restore 0169

		static IntPtr id_setBluetoothGatt_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/method[@name='setBluetoothGatt' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("setBluetoothGatt", "(Landroid/bluetooth/BluetoothGatt;)V", "GetSetBluetoothGatt_Landroid_bluetooth_BluetoothGatt_Handler")]
		public virtual unsafe void SetBluetoothGatt (global::Android.Bluetooth.BluetoothGatt bluetoothGatt)
		{
			if (id_setBluetoothGatt_Landroid_bluetooth_BluetoothGatt_ == IntPtr.Zero)
				id_setBluetoothGatt_Landroid_bluetooth_BluetoothGatt_ = JNIEnv.GetMethodID (class_ref, "setBluetoothGatt", "(Landroid/bluetooth/BluetoothGatt;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bluetoothGatt);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBluetoothGatt_Landroid_bluetooth_BluetoothGatt_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBluetoothGatt", "(Landroid/bluetooth/BluetoothGatt;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_;
#pragma warning disable 0169
		static Delegate GetSetDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Handler ()
		{
			if (cb_setDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ == null)
				cb_setDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_);
			return cb_setDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_;
		}

		static void n_SetDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleGattProfileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetDiscoverListener (listener);
		}
#pragma warning restore 0169

		static IntPtr id_setDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleGattProfileManager']/method[@name='setDiscoverListener' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.request.DiscoverService.DiscoverServiceListener']]"
		[Register ("setDiscoverListener", "(Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V", "GetSetDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Handler")]
		public virtual unsafe void SetDiscoverListener (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener listener)
		{
			if (id_setDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ == IntPtr.Zero)
				id_setDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ = JNIEnv.GetMethodID (class_ref, "setDiscoverListener", "(Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDiscoverListener_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDiscoverListener", "(Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V"), __args);
			} finally {
			}
		}

	}
}
