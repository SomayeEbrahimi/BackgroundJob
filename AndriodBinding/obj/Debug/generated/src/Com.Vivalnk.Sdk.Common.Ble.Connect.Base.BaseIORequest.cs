using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/base/BaseIORequest", DoNotGenerateAcw=true)]
	public abstract partial class BaseIORequest : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest, global::Android.OS.Handler.ICallback, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleRequest, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IDispatchCallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='MSG_REQUEST_TIMEOUT']"
		[Register ("MSG_REQUEST_TIMEOUT")]
		protected const int MsgRequestTimeout = (int) 32;

		static IntPtr callback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='callback']"
		[Register ("callback")]
		protected global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback Callback {
			get {
				if (callback_jfieldId == IntPtr.Zero)
					callback_jfieldId = JNIEnv.GetFieldID (class_ref, "callback", "Lcom/vivalnk/sdk/common/ble/connect/base/RequestCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, callback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (callback_jfieldId == IntPtr.Zero)
					callback_jfieldId = JNIEnv.GetFieldID (class_ref, "callback", "Lcom/vivalnk/sdk/common/ble/connect/base/RequestCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, callback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr connectMaster_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='connectMaster']"
		[Register ("connectMaster")]
		protected global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster ConnectMaster {
			get {
				if (connectMaster_jfieldId == IntPtr.Zero)
					connectMaster_jfieldId = JNIEnv.GetFieldID (class_ref, "connectMaster", "Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, connectMaster_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (connectMaster_jfieldId == IntPtr.Zero)
					connectMaster_jfieldId = JNIEnv.GetFieldID (class_ref, "connectMaster", "Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connectMaster_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr dispatcher_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='dispatcher']"
		[Register ("dispatcher")]
		protected global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher Dispatcher {
			get {
				if (dispatcher_jfieldId == IntPtr.Zero)
					dispatcher_jfieldId = JNIEnv.GetFieldID (class_ref, "dispatcher", "Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, dispatcher_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dispatcher_jfieldId == IntPtr.Zero)
					dispatcher_jfieldId = JNIEnv.GetFieldID (class_ref, "dispatcher", "Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dispatcher_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMainHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='mMainHandler']"
		[Register ("mMainHandler")]
		protected global::Android.OS.Handler MMainHandler {
			get {
				if (mMainHandler_jfieldId == IntPtr.Zero)
					mMainHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mMainHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMainHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMainHandler_jfieldId == IntPtr.Zero)
					mMainHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mMainHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMainHandler_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr requestOptions_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='requestOptions']"
		[Register ("requestOptions")]
		protected global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions RequestOptions {
			get {
				if (requestOptions_jfieldId == IntPtr.Zero)
					requestOptions_jfieldId = JNIEnv.GetFieldID (class_ref, "requestOptions", "Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, requestOptions_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (requestOptions_jfieldId == IntPtr.Zero)
					requestOptions_jfieldId = JNIEnv.GetFieldID (class_ref, "requestOptions", "Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestOptions_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/base/BaseIORequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseIORequest); }
		}

		protected BaseIORequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_RequestCallback_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/constructor[@name='BaseIORequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.base.RequestCallback'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.base.IORequestOptions']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/RequestCallback;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;)V", "")]
		public unsafe BaseIORequest (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback @callback, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions requestOptions)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (@callback);
				__args [2] = new JValue (requestOptions);
				if (((object) this).GetType () != typeof (BaseIORequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/RequestCallback;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/RequestCallback;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_RequestCallback_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_RequestCallback_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/RequestCallback;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_RequestCallback_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_RequestCallback_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BleGattProfile);
		}
#pragma warning restore 0169

		static IntPtr id_getBleGattProfile;
		protected virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile BleGattProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getBleGattProfile' and count(parameter)=0]"
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

		static Delegate cb_getBluetoothDevice;
#pragma warning disable 0169
		static Delegate GetGetBluetoothDeviceHandler ()
		{
			if (cb_getBluetoothDevice == null)
				cb_getBluetoothDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBluetoothDevice);
			return cb_getBluetoothDevice;
		}

		static IntPtr n_GetBluetoothDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BluetoothDevice);
		}
#pragma warning restore 0169

		static IntPtr id_getBluetoothDevice;
		protected virtual unsafe global::Android.Bluetooth.BluetoothDevice BluetoothDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getBluetoothDevice' and count(parameter)=0]"
			[Register ("getBluetoothDevice", "()Landroid/bluetooth/BluetoothDevice;", "GetGetBluetoothDeviceHandler")]
			get {
				if (id_getBluetoothDevice == IntPtr.Zero)
					id_getBluetoothDevice = JNIEnv.GetMethodID (class_ref, "getBluetoothDevice", "()Landroid/bluetooth/BluetoothDevice;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBluetoothDevice), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBluetoothDevice", "()Landroid/bluetooth/BluetoothDevice;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBluetoothGatt;
#pragma warning disable 0169
		static Delegate GetGetBluetoothGattHandler ()
		{
			if (cb_getBluetoothGatt == null)
				cb_getBluetoothGatt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBluetoothGatt);
			return cb_getBluetoothGatt;
		}

		static IntPtr n_GetBluetoothGatt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BluetoothGatt);
		}
#pragma warning restore 0169

		static IntPtr id_getBluetoothGatt;
		protected virtual unsafe global::Android.Bluetooth.BluetoothGatt BluetoothGatt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getBluetoothGatt' and count(parameter)=0]"
			[Register ("getBluetoothGatt", "()Landroid/bluetooth/BluetoothGatt;", "GetGetBluetoothGattHandler")]
			get {
				if (id_getBluetoothGatt == IntPtr.Zero)
					id_getBluetoothGatt = JNIEnv.GetMethodID (class_ref, "getBluetoothGatt", "()Landroid/bluetooth/BluetoothGatt;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBluetoothGatt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBluetoothGatt", "()Landroid/bluetooth/BluetoothGatt;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentStatus;
#pragma warning disable 0169
		static Delegate GetGetCurrentStatusHandler ()
		{
			if (cb_getCurrentStatus == null)
				cb_getCurrentStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentStatus);
			return cb_getCurrentStatus;
		}

		static int n_GetCurrentStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentStatus;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentStatus;
		public virtual unsafe int CurrentStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getCurrentStatus' and count(parameter)=0]"
			[Register ("getCurrentStatus", "()I", "GetGetCurrentStatusHandler")]
			get {
				if (id_getCurrentStatus == IntPtr.Zero)
					id_getCurrentStatus = JNIEnv.GetMethodID (class_ref, "getCurrentStatus", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentStatus);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentStatus", "()I"));
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>>.ToLocalJniHandle (__this.DeviceProfile);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceProfile;
		protected virtual unsafe global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>> DeviceProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getDeviceProfile' and count(parameter)=0]"
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

		static Delegate cb_getMac;
#pragma warning disable 0169
		static Delegate GetGetMacHandler ()
		{
			if (cb_getMac == null)
				cb_getMac = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMac);
			return cb_getMac;
		}

		static IntPtr n_GetMac (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Mac);
		}
#pragma warning restore 0169

		static IntPtr id_getMac;
		public virtual unsafe string Mac {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getMac' and count(parameter)=0]"
			[Register ("getMac", "()Ljava/lang/String;", "GetGetMacHandler")]
			get {
				if (id_getMac == IntPtr.Zero)
					id_getMac = JNIEnv.GetMethodID (class_ref, "getMac", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMac), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMac", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestName;
#pragma warning disable 0169
		static Delegate GetGetRequestNameHandler ()
		{
			if (cb_getRequestName == null)
				cb_getRequestName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestName);
			return cb_getRequestName;
		}

		static IntPtr n_GetRequestName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		protected abstract string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")] get;
		}

		static Delegate cb_getRequestTimeout;
#pragma warning disable 0169
		static Delegate GetGetRequestTimeoutHandler ()
		{
			if (cb_getRequestTimeout == null)
				cb_getRequestTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetRequestTimeout);
			return cb_getRequestTimeout;
		}

		static long n_GetRequestTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestTimeout;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestTimeout;
		protected virtual unsafe long RequestTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getRequestTimeout' and count(parameter)=0]"
			[Register ("getRequestTimeout", "()J", "GetGetRequestTimeoutHandler")]
			get {
				if (id_getRequestTimeout == IntPtr.Zero)
					id_getRequestTimeout = JNIEnv.GetMethodID (class_ref, "getRequestTimeout", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRequestTimeout);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestTimeout", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_finishRequest;
#pragma warning disable 0169
		static Delegate GetFinishRequestHandler ()
		{
			if (cb_finishRequest == null)
				cb_finishRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FinishRequest);
			return cb_finishRequest;
		}

		static void n_FinishRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_finishRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='finishRequest' and count(parameter)=0]"
		[Register ("finishRequest", "()V", "GetFinishRequestHandler")]
		public virtual unsafe void FinishRequest ()
		{
			if (id_finishRequest == IntPtr.Zero)
				id_finishRequest = JNIEnv.GetMethodID (class_ref, "finishRequest", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishRequest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishRequest", "()V"));
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCharacter (service, character));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCharacter_Ljava_util_UUID_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getCharacter' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID']]"
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

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (msg);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message msg)
		{
			if (id_handleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_handleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/os/Message;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (msg);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleMessage_Landroid_os_Message_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMessage", "(Landroid/os/Message;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onBluetoothStateChange_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetOnBluetoothStateChange_Ljava_lang_Integer_Handler ()
		{
			if (cb_onBluetoothStateChange_Ljava_lang_Integer_ == null)
				cb_onBluetoothStateChange_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnBluetoothStateChange_Ljava_lang_Integer_);
			return cb_onBluetoothStateChange_Ljava_lang_Integer_;
		}

		static void n_OnBluetoothStateChange_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var state = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_state, JniHandleOwnership.DoNotTransfer);
			__this.OnBluetoothStateChange (state);
		}
#pragma warning restore 0169

		static IntPtr id_onBluetoothStateChange_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='onBluetoothStateChange' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("onBluetoothStateChange", "(Ljava/lang/Integer;)V", "GetOnBluetoothStateChange_Ljava_lang_Integer_Handler")]
		public virtual unsafe void OnBluetoothStateChange (global::Java.Lang.Integer state)
		{
			if (id_onBluetoothStateChange_Ljava_lang_Integer_ == IntPtr.Zero)
				id_onBluetoothStateChange_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "onBluetoothStateChange", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (state);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBluetoothStateChange_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBluetoothStateChange", "(Ljava/lang/Integer;)V"), __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.OnError (code, msg);
		}
#pragma warning restore 0169

		static IntPtr id_onError_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='onStart' and count(parameter)=0]"
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

		static Delegate cb_process;
#pragma warning disable 0169
		static Delegate GetProcessHandler ()
		{
			if (cb_process == null)
				cb_process = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Process);
			return cb_process;
		}

		static void n_Process (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Process ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='process' and count(parameter)=0]"
		[Register ("process", "()V", "GetProcessHandler")]
		protected abstract void Process ();

		static Delegate cb_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_;
#pragma warning disable 0169
		static Delegate GetProcess_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_Handler ()
		{
			if (cb_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ == null)
				cb_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_);
			return cb_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_;
		}

		static void n_Process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dispatcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dispatcher = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher> (native_dispatcher, JniHandleOwnership.DoNotTransfer);
			__this.Process (dispatcher);
		}
#pragma warning restore 0169

		static IntPtr id_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='process' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.listener.IBleDispatcher']]"
		[Register ("process", "(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V", "GetProcess_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_Handler")]
		public virtual unsafe void Process (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher dispatcher)
		{
			if (id_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ == IntPtr.Zero)
				id_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ = JNIEnv.GetMethodID (class_ref, "process", "(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dispatcher);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processRequest;
#pragma warning disable 0169
		static Delegate GetProcessRequestHandler ()
		{
			if (cb_processRequest == null)
				cb_processRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ProcessRequest);
			return cb_processRequest;
		}

		static void n_ProcessRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_processRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='processRequest' and count(parameter)=0]"
		[Register ("processRequest", "()V", "GetProcessRequestHandler")]
		protected virtual unsafe void ProcessRequest ()
		{
			if (id_processRequest == IntPtr.Zero)
				id_processRequest = JNIEnv.GetMethodID (class_ref, "processRequest", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processRequest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processRequest", "()V"));
			} finally {
			}
		}

		static Delegate cb_setConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_;
#pragma warning disable 0169
		static Delegate GetSetConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_Handler ()
		{
			if (cb_setConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_ == null)
				cb_setConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_);
			return cb_setConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_;
		}

		static void n_SetConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connectMaster)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var connectMaster = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (native_connectMaster, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectMaster (connectMaster);
		}
#pragma warning restore 0169

		static IntPtr id_setConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='setConnectMaster' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.base.BaseGattIOOperation']]"
		[Register ("setConnectMaster", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseGattIOOperation;)V", "GetSetConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_Handler")]
		public virtual unsafe void SetConnectMaster (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation connectMaster)
		{
			if (id_setConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_ == IntPtr.Zero)
				id_setConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_ = JNIEnv.GetMethodID (class_ref, "setConnectMaster", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseGattIOOperation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (connectMaster);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectMaster", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseGattIOOperation;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static void n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (context);
		}
#pragma warning restore 0169

		static IntPtr id_setContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
		public virtual unsafe void SetContext (global::Android.Content.Context context)
		{
			if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContext_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContext", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_;
#pragma warning disable 0169
		static Delegate GetSetDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_Handler ()
		{
			if (cb_setDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ == null)
				cb_setDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_);
			return cb_setDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_;
		}

		static void n_SetDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dispatcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dispatcher = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher> (native_dispatcher, JniHandleOwnership.DoNotTransfer);
			__this.SetDispatcher (dispatcher);
		}
#pragma warning restore 0169

		static IntPtr id_setDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='setDispatcher' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.listener.IBleDispatcher']]"
		[Register ("setDispatcher", "(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V", "GetSetDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_Handler")]
		public virtual unsafe void SetDispatcher (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher dispatcher)
		{
			if (id_setDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ == IntPtr.Zero)
				id_setDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ = JNIEnv.GetMethodID (class_ref, "setDispatcher", "(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dispatcher);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDispatcher", "(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startRequestTiming;
#pragma warning disable 0169
		static Delegate GetStartRequestTimingHandler ()
		{
			if (cb_startRequestTiming == null)
				cb_startRequestTiming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartRequestTiming);
			return cb_startRequestTiming;
		}

		static void n_StartRequestTiming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartRequestTiming ();
		}
#pragma warning restore 0169

		static IntPtr id_startRequestTiming;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='startRequestTiming' and count(parameter)=0]"
		[Register ("startRequestTiming", "()V", "GetStartRequestTimingHandler")]
		protected virtual unsafe void StartRequestTiming ()
		{
			if (id_startRequestTiming == IntPtr.Zero)
				id_startRequestTiming = JNIEnv.GetMethodID (class_ref, "startRequestTiming", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startRequestTiming);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startRequestTiming", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopRequestTiming;
#pragma warning disable 0169
		static Delegate GetStopRequestTimingHandler ()
		{
			if (cb_stopRequestTiming == null)
				cb_stopRequestTiming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopRequestTiming);
			return cb_stopRequestTiming;
		}

		static void n_StopRequestTiming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRequestTiming ();
		}
#pragma warning restore 0169

		static IntPtr id_stopRequestTiming;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='stopRequestTiming' and count(parameter)=0]"
		[Register ("stopRequestTiming", "()V", "GetStopRequestTimingHandler")]
		protected virtual unsafe void StopRequestTiming ()
		{
			if (id_stopRequestTiming == IntPtr.Zero)
				id_stopRequestTiming = JNIEnv.GetMethodID (class_ref, "stopRequestTiming", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopRequestTiming);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopRequestTiming", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/base/BaseIORequest", DoNotGenerateAcw=true)]
	internal partial class BaseIORequestInvoker : BaseIORequest {

		public BaseIORequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseIORequestInvoker); }
		}

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")]
			get {
				if (id_getRequestName == IntPtr.Zero)
					id_getRequestName = JNIEnv.GetMethodID (class_ref, "getRequestName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_process;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='process' and count(parameter)=0]"
		[Register ("process", "()V", "GetProcessHandler")]
		protected override unsafe void Process ()
		{
			if (id_process == IntPtr.Zero)
				id_process = JNIEnv.GetMethodID (class_ref, "process", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process);
			} finally {
			}
		}

	}

}
