using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/base/BaseIORequest", DoNotGenerateAcw=true)]
	public abstract partial class BaseIORequest : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest, global::Android.OS.Handler.ICallback, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleRequest, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IDispatchCallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='MSG_REQUEST_TIMEOUT']"
		[Register ("MSG_REQUEST_TIMEOUT")]
		protected const int MsgRequestTimeout = (int) 32;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='callback']"
		[Register ("callback")]
		protected global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback Callback {
			get {
				const string __id = "callback.Lcom/vivalnk/sdk/common/ble/connect/base/RequestCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "callback.Lcom/vivalnk/sdk/common/ble/connect/base/RequestCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='connectMaster']"
		[Register ("connectMaster")]
		protected global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster ConnectMaster {
			get {
				const string __id = "connectMaster.Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "connectMaster.Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='dispatcher']"
		[Register ("dispatcher")]
		protected global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher Dispatcher {
			get {
				const string __id = "dispatcher.Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dispatcher.Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				const string __id = "mContext.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='mMainHandler']"
		[Register ("mMainHandler")]
		protected global::Android.OS.Handler MMainHandler {
			get {
				const string __id = "mMainHandler.Landroid/os/Handler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMainHandler.Landroid/os/Handler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/field[@name='requestOptions']"
		[Register ("requestOptions")]
		protected global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions RequestOptions {
			get {
				const string __id = "requestOptions.Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "requestOptions.Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/base/BaseIORequest", typeof (BaseIORequest));
		internal static new IntPtr class_ref {
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

		protected BaseIORequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/constructor[@name='BaseIORequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.base.RequestCallback'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.base.IORequestOptions']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/RequestCallback;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;)V", "")]
		public unsafe BaseIORequest (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback @callback, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions requestOptions)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/RequestCallback;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [2] = new JniArgumentValue ((requestOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestOptions).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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

		protected virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile BleGattProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getBleGattProfile' and count(parameter)=0]"
			[Register ("getBleGattProfile", "()Lcom/vivalnk/sdk/common/ble/model/BleGattProfile;", "GetGetBleGattProfileHandler")]
			get {
				const string __id = "getBleGattProfile.()Lcom/vivalnk/sdk/common/ble/model/BleGattProfile;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		protected virtual unsafe global::Android.Bluetooth.BluetoothDevice BluetoothDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getBluetoothDevice' and count(parameter)=0]"
			[Register ("getBluetoothDevice", "()Landroid/bluetooth/BluetoothDevice;", "GetGetBluetoothDeviceHandler")]
			get {
				const string __id = "getBluetoothDevice.()Landroid/bluetooth/BluetoothDevice;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		protected virtual unsafe global::Android.Bluetooth.BluetoothGatt BluetoothGatt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getBluetoothGatt' and count(parameter)=0]"
			[Register ("getBluetoothGatt", "()Landroid/bluetooth/BluetoothGatt;", "GetGetBluetoothGattHandler")]
			get {
				const string __id = "getBluetoothGatt.()Landroid/bluetooth/BluetoothGatt;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		public virtual unsafe int CurrentStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getCurrentStatus' and count(parameter)=0]"
			[Register ("getCurrentStatus", "()I", "GetGetCurrentStatusHandler")]
			get {
				const string __id = "getCurrentStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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

		protected virtual unsafe global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>> DeviceProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getDeviceProfile' and count(parameter)=0]"
			[Register ("getDeviceProfile", "()Ljava/util/Map;", "GetGetDeviceProfileHandler")]
			get {
				const string __id = "getDeviceProfile.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		public virtual unsafe string Mac {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getMac' and count(parameter)=0]"
			[Register ("getMac", "()Ljava/lang/String;", "GetGetMacHandler")]
			get {
				const string __id = "getMac.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		protected virtual unsafe long RequestTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getRequestTimeout' and count(parameter)=0]"
			[Register ("getRequestTimeout", "()J", "GetGetRequestTimeoutHandler")]
			get {
				const string __id = "getRequestTimeout.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='finishRequest' and count(parameter)=0]"
		[Register ("finishRequest", "()V", "GetFinishRequestHandler")]
		public virtual unsafe void FinishRequest ()
		{
			const string __id = "finishRequest.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getCharacter' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID']]"
		[Register ("getCharacter", "(Ljava/util/UUID;Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattCharacteristic;", "GetGetCharacter_Ljava_util_UUID_Ljava_util_UUID_Handler")]
		public virtual unsafe global::Android.Bluetooth.BluetoothGattCharacteristic GetCharacter (global::Java.Util.UUID service, global::Java.Util.UUID character)
		{
			const string __id = "getCharacter.(Ljava/util/UUID;Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattCharacteristic;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message msg)
		{
			const string __id = "handleMessage.(Landroid/os/Message;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='onBluetoothStateChange' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("onBluetoothStateChange", "(Ljava/lang/Integer;)V", "GetOnBluetoothStateChange_Ljava_lang_Integer_Handler")]
		public virtual unsafe void OnBluetoothStateChange (global::Java.Lang.Integer state)
		{
			const string __id = "onBluetoothStateChange.(Ljava/lang/Integer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((state == null) ? IntPtr.Zero : ((global::Java.Lang.Object) state).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onError", "(ILjava/lang/String;)V", "GetOnError_ILjava_lang_String_Handler")]
		public virtual unsafe void OnError (int code, string msg)
		{
			const string __id = "onError.(ILjava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			const string __id = "onStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='process' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.listener.IBleDispatcher']]"
		[Register ("process", "(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V", "GetProcess_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_Handler")]
		public virtual unsafe void Process (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher dispatcher)
		{
			const string __id = "process.(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dispatcher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dispatcher).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='processRequest' and count(parameter)=0]"
		[Register ("processRequest", "()V", "GetProcessRequestHandler")]
		protected virtual unsafe void ProcessRequest ()
		{
			const string __id = "processRequest.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='setConnectMaster' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.base.BaseGattIOOperation']]"
		[Register ("setConnectMaster", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseGattIOOperation;)V", "GetSetConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_Handler")]
		public virtual unsafe void SetConnectMaster (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation connectMaster)
		{
			const string __id = "setConnectMaster.(Lcom/vivalnk/sdk/common/ble/connect/base/BaseGattIOOperation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((connectMaster == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectMaster).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
		public virtual unsafe void SetContext (global::Android.Content.Context context)
		{
			const string __id = "setContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='setDispatcher' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.listener.IBleDispatcher']]"
		[Register ("setDispatcher", "(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V", "GetSetDispatcher_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_Handler")]
		public virtual unsafe void SetDispatcher (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher dispatcher)
		{
			const string __id = "setDispatcher.(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dispatcher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dispatcher).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='startRequestTiming' and count(parameter)=0]"
		[Register ("startRequestTiming", "()V", "GetStartRequestTimingHandler")]
		protected virtual unsafe void StartRequestTiming ()
		{
			const string __id = "startRequestTiming.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='stopRequestTiming' and count(parameter)=0]"
		[Register ("stopRequestTiming", "()V", "GetStopRequestTimingHandler")]
		protected virtual unsafe void StopRequestTiming ()
		{
			const string __id = "stopRequestTiming.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/base/BaseIORequest", DoNotGenerateAcw=true)]
	internal partial class BaseIORequestInvoker : BaseIORequest {

		public BaseIORequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/base/BaseIORequest", typeof (BaseIORequestInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")]
			get {
				const string __id = "getRequestName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseIORequest']/method[@name='process' and count(parameter)=0]"
		[Register ("process", "()V", "GetProcessHandler")]
		protected override unsafe void Process ()
		{
			const string __id = "process.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
