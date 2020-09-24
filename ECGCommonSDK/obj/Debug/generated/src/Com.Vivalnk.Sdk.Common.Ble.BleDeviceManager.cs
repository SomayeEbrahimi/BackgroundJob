using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BleDeviceManager", DoNotGenerateAcw=true)]
	public partial class BleDeviceManager : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Ble.IBleManagerInterface {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/BleDeviceManager", typeof (BleDeviceManager));
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

		protected BleDeviceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/constructor[@name='BleDeviceManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BleDeviceManager ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='checkBleRuntime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("checkBleRuntime", "(Landroid/content/Context;)I", "")]
		public static unsafe int CheckBleRuntime (global::Android.Content.Context context)
		{
			const string __id = "checkBleRuntime.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_clearAllRequest_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearAllRequest_Ljava_lang_String_Handler ()
		{
			if (cb_clearAllRequest_Ljava_lang_String_ == null)
				cb_clearAllRequest_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearAllRequest_Ljava_lang_String_);
			return cb_clearAllRequest_Ljava_lang_String_;
		}

		static void n_ClearAllRequest_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllRequest (mac);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='clearAllRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearAllRequest", "(Ljava/lang/String;)V", "GetClearAllRequest_Ljava_lang_String_Handler")]
		public virtual unsafe void ClearAllRequest (string mac)
		{
			const string __id = "clearAllRequest.(Ljava/lang/String;)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_closeIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
#pragma warning disable 0169
		static Delegate GetCloseIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler ()
		{
			if (cb_closeIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z == null)
				cb_closeIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_CloseIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z);
			return cb_closeIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
		}

		static void n_CloseIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_service, IntPtr native_character, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.CloseIndicate (mac, service, character, response, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='closeIndicate' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener'] and parameter[5][@type='boolean']]"
		[Register ("closeIndicate", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V", "GetCloseIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler")]
		public virtual unsafe void CloseIndicate (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener response, bool loggable)
		{
			const string __id = "closeIndicate.(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [4] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_closeNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
#pragma warning disable 0169
		static Delegate GetCloseNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler ()
		{
			if (cb_closeNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == null)
				cb_closeNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_CloseNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z);
			return cb_closeNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		}

		static void n_CloseNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_service, IntPtr native_character, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.CloseNotify (mac, service, character, response, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='closeNotify' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.NotifyRequest.NotifyChangeListener'] and parameter[5][@type='boolean']]"
		[Register ("closeNotify", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V", "GetCloseNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler")]
		public virtual unsafe void CloseNotify (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener response, bool loggable)
		{
			const string __id = "closeNotify.(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [4] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_connect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler ()
		{
			if (cb_connect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ == null)
				cb_connect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Connect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_);
			return cb_connect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
		}

		static void n_Connect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_options, IntPtr native_response)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.Connect (mac, options, response);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.BleConnectOptions'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.BleConnectMaster.BluetoothConnectListener']]"
		[Register ("connect", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V", "GetConnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler")]
		public virtual unsafe void Connect (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions options, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener response)
		{
			const string __id = "connect.(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disableBle;
#pragma warning disable 0169
		static Delegate GetDisableBleHandler ()
		{
			if (cb_disableBle == null)
				cb_disableBle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DisableBle);
			return cb_disableBle;
		}

		static void n_DisableBle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableBle ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='disableBle' and count(parameter)=0]"
		[Register ("disableBle", "()V", "GetDisableBleHandler")]
		public virtual unsafe void DisableBle ()
		{
			const string __id = "disableBle.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disconnect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_String_Handler ()
		{
			if (cb_disconnect_Ljava_lang_String_ == null)
				cb_disconnect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Disconnect_Ljava_lang_String_);
			return cb_disconnect_Ljava_lang_String_;
		}

		static void n_Disconnect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (mac);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("disconnect", "(Ljava/lang/String;)V", "GetDisconnect_Ljava_lang_String_Handler")]
		public virtual unsafe void Disconnect (string mac)
		{
			const string __id = "disconnect.(Ljava/lang/String;)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_disconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler ()
		{
			if (cb_disconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ == null)
				cb_disconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Disconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_);
			return cb_disconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
		}

		static void n_Disconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (mac, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='disconnect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.BleConnectMaster.BluetoothConnectListener']]"
		[Register ("disconnect", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V", "GetDisconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler")]
		public virtual unsafe void Disconnect (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener listener)
		{
			const string __id = "disconnect.(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_disconnectAll;
#pragma warning disable 0169
		static Delegate GetDisconnectAllHandler ()
		{
			if (cb_disconnectAll == null)
				cb_disconnectAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DisconnectAll);
			return cb_disconnectAll;
		}

		static void n_DisconnectAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='disconnectAll' and count(parameter)=0]"
		[Register ("disconnectAll", "()V", "GetDisconnectAllHandler")]
		public virtual unsafe void DisconnectAll ()
		{
			const string __id = "disconnectAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disconnectQuietly_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisconnectQuietly_Ljava_lang_String_Handler ()
		{
			if (cb_disconnectQuietly_Ljava_lang_String_ == null)
				cb_disconnectQuietly_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DisconnectQuietly_Ljava_lang_String_);
			return cb_disconnectQuietly_Ljava_lang_String_;
		}

		static void n_DisconnectQuietly_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectQuietly (mac);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='disconnectQuietly' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("disconnectQuietly", "(Ljava/lang/String;)V", "GetDisconnectQuietly_Ljava_lang_String_Handler")]
		public virtual unsafe void DisconnectQuietly (string mac)
		{
			const string __id = "disconnectQuietly.(Ljava/lang/String;)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_enableBle;
#pragma warning disable 0169
		static Delegate GetEnableBleHandler ()
		{
			if (cb_enableBle == null)
				cb_enableBle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EnableBle);
			return cb_enableBle;
		}

		static void n_EnableBle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableBle ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='enableBle' and count(parameter)=0]"
		[Register ("enableBle", "()V", "GetEnableBleHandler")]
		public virtual unsafe void EnableBle ()
		{
			const string __id = "enableBle.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBluetoothDevice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBluetoothDevice_Ljava_lang_String_Handler ()
		{
			if (cb_getBluetoothDevice_Ljava_lang_String_ == null)
				cb_getBluetoothDevice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetBluetoothDevice_Ljava_lang_String_);
			return cb_getBluetoothDevice_Ljava_lang_String_;
		}

		static IntPtr n_GetBluetoothDevice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBluetoothDevice (mac));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='getBluetoothDevice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBluetoothDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;", "GetGetBluetoothDevice_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Bluetooth.BluetoothDevice GetBluetoothDevice (string mac)
		{
			const string __id = "getBluetoothDevice.(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_getConnectStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConnectStatus_Ljava_lang_String_Handler ()
		{
			if (cb_getConnectStatus_Ljava_lang_String_ == null)
				cb_getConnectStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetConnectStatus_Ljava_lang_String_);
			return cb_getConnectStatus_Ljava_lang_String_;
		}

		static int n_GetConnectStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetConnectStatus (mac);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='getConnectStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConnectStatus", "(Ljava/lang/String;)I", "GetGetConnectStatus_Ljava_lang_String_Handler")]
		public virtual unsafe int GetConnectStatus (string mac)
		{
			const string __id = "getConnectStatus.(Ljava/lang/String;)I";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Init (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context context)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isConnected_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsConnected_Ljava_lang_String_Handler ()
		{
			if (cb_isConnected_Ljava_lang_String_ == null)
				cb_isConnected_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsConnected_Ljava_lang_String_);
			return cb_isConnected_Ljava_lang_String_;
		}

		static bool n_IsConnected_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConnected (mac);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='isConnected' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isConnected", "(Ljava/lang/String;)Z", "GetIsConnected_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsConnected (string mac)
		{
			const string __id = "isConnected.(Ljava/lang/String;)Z";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_isConnecting_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsConnecting_Ljava_lang_String_Handler ()
		{
			if (cb_isConnecting_Ljava_lang_String_ == null)
				cb_isConnecting_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsConnecting_Ljava_lang_String_);
			return cb_isConnecting_Ljava_lang_String_;
		}

		static bool n_IsConnecting_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConnecting (mac);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='isConnecting' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isConnecting", "(Ljava/lang/String;)Z", "GetIsConnecting_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsConnecting (string mac)
		{
			const string __id = "isConnecting.(Ljava/lang/String;)Z";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_openIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
#pragma warning disable 0169
		static Delegate GetOpenIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler ()
		{
			if (cb_openIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z == null)
				cb_openIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_OpenIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z);
			return cb_openIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
		}

		static void n_OpenIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_service, IntPtr native_character, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.OpenIndicate (mac, service, character, response, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='openIndicate' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener'] and parameter[5][@type='boolean']]"
		[Register ("openIndicate", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V", "GetOpenIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler")]
		public virtual unsafe void OpenIndicate (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener response, bool loggable)
		{
			const string __id = "openIndicate.(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [4] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_openNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
#pragma warning disable 0169
		static Delegate GetOpenNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler ()
		{
			if (cb_openNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == null)
				cb_openNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_OpenNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z);
			return cb_openNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		}

		static void n_OpenNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_service, IntPtr native_character, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.OpenNotify (mac, service, character, response, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='openNotify' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.NotifyRequest.NotifyChangeListener'] and parameter[5][@type='boolean']]"
		[Register ("openNotify", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V", "GetOpenNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler")]
		public virtual unsafe void OpenNotify (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener response, bool loggable)
		{
			const string __id = "openNotify.(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [4] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_readCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
#pragma warning disable 0169
		static Delegate GetReadCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_ZHandler ()
		{
			if (cb_readCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z == null)
				cb_readCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_ReadCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z);
			return cb_readCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
		}

		static void n_ReadCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_service, IntPtr native_character, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.ReadCharacter (mac, service, character, response, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='readCharacter' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterRead.CharacterReadListener'] and parameter[5][@type='boolean']]"
		[Register ("readCharacter", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V", "GetReadCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_ZHandler")]
		public virtual unsafe void ReadCharacter (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener response, bool loggable)
		{
			const string __id = "readCharacter.(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [4] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_readDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
#pragma warning disable 0169
		static Delegate GetReadDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_ZHandler ()
		{
			if (cb_readDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z == null)
				cb_readDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLZ_V) n_ReadDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z);
			return cb_readDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
		}

		static void n_ReadDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_service, IntPtr native_character, IntPtr native_descriptor, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var descriptor = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_descriptor, JniHandleOwnership.DoNotTransfer);
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.ReadDescriptor (mac, service, character, descriptor, response, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='readDescriptor' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='java.util.UUID'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorRead.DescriptorReadListener'] and parameter[6][@type='boolean']]"
		[Register ("readDescriptor", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V", "GetReadDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_ZHandler")]
		public virtual unsafe void ReadDescriptor (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Java.Util.UUID descriptor, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener response, bool loggable)
		{
			const string __id = "readDescriptor.(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue ((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) descriptor).Handle);
				__args [4] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [5] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_readRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
#pragma warning disable 0169
		static Delegate GetReadRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_ZHandler ()
		{
			if (cb_readRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z == null)
				cb_readRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_ReadRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z);
			return cb_readRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
		}

		static void n_ReadRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.ReadRemoteRssi (mac, response, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='readRemoteRssi' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.request.ReadRemoteRssi.ReadRssiListener'] and parameter[3][@type='boolean']]"
		[Register ("readRemoteRssi", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V", "GetReadRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_ZHandler")]
		public virtual unsafe void ReadRemoteRssi (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener response, bool loggable)
		{
			const string __id = "readRemoteRssi.(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [2] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_refreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Z;
#pragma warning disable 0169
		static Delegate GetRefreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_ZHandler ()
		{
			if (cb_refreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Z == null)
				cb_refreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_RefreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Z);
			return cb_refreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Z;
		}

		static void n_RefreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.RefreshCache.IRefreshCacheListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.RefreshCache.IRefreshCacheListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RefreshDeviceCache (mac, listener, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='refreshDeviceCache' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.request.RefreshCache.RefreshCacheListener'] and parameter[3][@type='boolean']]"
		[Register ("refreshDeviceCache", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/RefreshCache$RefreshCacheListener;Z)V", "GetRefreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_ZHandler")]
		public virtual unsafe void RefreshDeviceCache (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.RefreshCache.IRefreshCacheListener listener, bool loggable)
		{
			const string __id = "refreshDeviceCache.(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/RefreshCache$RefreshCacheListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [2] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_registBluetoothReceiver_Landroid_content_BroadcastReceiver_;
#pragma warning disable 0169
		static Delegate GetRegistBluetoothReceiver_Landroid_content_BroadcastReceiver_Handler ()
		{
			if (cb_registBluetoothReceiver_Landroid_content_BroadcastReceiver_ == null)
				cb_registBluetoothReceiver_Landroid_content_BroadcastReceiver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegistBluetoothReceiver_Landroid_content_BroadcastReceiver_);
			return cb_registBluetoothReceiver_Landroid_content_BroadcastReceiver_;
		}

		static void n_RegistBluetoothReceiver_Landroid_content_BroadcastReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var receiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_receiver, JniHandleOwnership.DoNotTransfer);
			__this.RegistBluetoothReceiver (receiver);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='registBluetoothReceiver' and count(parameter)=1 and parameter[1][@type='android.content.BroadcastReceiver']]"
		[Register ("registBluetoothReceiver", "(Landroid/content/BroadcastReceiver;)V", "GetRegistBluetoothReceiver_Landroid_content_BroadcastReceiver_Handler")]
		public virtual unsafe void RegistBluetoothReceiver (global::Android.Content.BroadcastReceiver receiver)
		{
			const string __id = "registBluetoothReceiver.(Landroid/content/BroadcastReceiver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_requestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
#pragma warning disable 0169
		static Delegate GetRequestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_ZHandler ()
		{
			if (cb_requestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z == null)
				cb_requestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILZ_V) n_RequestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z);
			return cb_requestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
		}

		static void n_RequestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, int mtu, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.RequestMtu (mac, mtu, response, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='requestMtu' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.MtuRequest.MtuListener'] and parameter[4][@type='boolean']]"
		[Register ("requestMtu", "(Ljava/lang/String;ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V", "GetRequestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_ZHandler")]
		public virtual unsafe void RequestMtu (string mac, int mtu, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener response, bool loggable)
		{
			const string __id = "requestMtu.(Ljava/lang/String;ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue (mtu);
				__args [2] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [3] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static Delegate cb_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_;
#pragma warning disable 0169
		static Delegate GetStartScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_Handler ()
		{
			if (cb_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_ == null)
				cb_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_);
			return cb_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_;
		}

		static void n_StartScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.ScanOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.StartScan (options, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='startScan' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.scan.ScanOptions'] and parameter[2][@type='com.vivalnk.sdk.common.ble.scan.BleScanListener']]"
		[Register ("startScan", "(Lcom/vivalnk/sdk/common/ble/scan/ScanOptions;Lcom/vivalnk/sdk/common/ble/scan/BleScanListener;)V", "GetStartScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_Handler")]
		public virtual unsafe void StartScan (global::Com.Vivalnk.Sdk.Common.Ble.Scan.ScanOptions options, global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener listener)
		{
			const string __id = "startScan.(Lcom/vivalnk/sdk/common/ble/scan/ScanOptions;Lcom/vivalnk/sdk/common/ble/scan/BleScanListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopScan;
#pragma warning disable 0169
		static Delegate GetStopScanHandler ()
		{
			if (cb_stopScan == null)
				cb_stopScan = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopScan);
			return cb_stopScan;
		}

		static void n_StopScan (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopScan ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='stopScan' and count(parameter)=0]"
		[Register ("stopScan", "()V", "GetStopScanHandler")]
		public virtual unsafe void StopScan ()
		{
			const string __id = "stopScan.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unregistAllReceiver;
#pragma warning disable 0169
		static Delegate GetUnregistAllReceiverHandler ()
		{
			if (cb_unregistAllReceiver == null)
				cb_unregistAllReceiver = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UnregistAllReceiver);
			return cb_unregistAllReceiver;
		}

		static void n_UnregistAllReceiver (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregistAllReceiver ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='unregistAllReceiver' and count(parameter)=0]"
		[Register ("unregistAllReceiver", "()V", "GetUnregistAllReceiverHandler")]
		public virtual unsafe void UnregistAllReceiver ()
		{
			const string __id = "unregistAllReceiver.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unregistBluetoothReceiver;
#pragma warning disable 0169
		static Delegate GetUnregistBluetoothReceiverHandler ()
		{
			if (cb_unregistBluetoothReceiver == null)
				cb_unregistBluetoothReceiver = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UnregistBluetoothReceiver);
			return cb_unregistBluetoothReceiver;
		}

		static void n_UnregistBluetoothReceiver (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregistBluetoothReceiver ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='unregistBluetoothReceiver' and count(parameter)=0]"
		[Register ("unregistBluetoothReceiver", "()V", "GetUnregistBluetoothReceiverHandler")]
		public virtual unsafe void UnregistBluetoothReceiver ()
		{
			const string __id = "unregistBluetoothReceiver.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
#pragma warning disable 0169
		static Delegate GetWriteCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler ()
		{
			if (cb_writeCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z == null)
				cb_writeCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLZ_V) n_WriteCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z);
			return cb_writeCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
		}

		static void n_WriteCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_service, IntPtr native_character, IntPtr native_value, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.WriteCharacter (mac, service, character, value, response, loggable);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='writeCharacter' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWrite.CharacterWriteListener'] and parameter[6][@type='boolean']]"
		[Register ("writeCharacter", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V", "GetWriteCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler")]
		public virtual unsafe void WriteCharacter (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener response, bool loggable)
		{
			const string __id = "writeCharacter.(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue (native_value);
				__args [4] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [5] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_writeCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
#pragma warning disable 0169
		static Delegate GetWriteCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler ()
		{
			if (cb_writeCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z == null)
				cb_writeCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLZ_V) n_WriteCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z);
			return cb_writeCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
		}

		static void n_WriteCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_service, IntPtr native_character, IntPtr native_value, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.WriteCharacterNoRsp (mac, service, character, value, response, loggable);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='writeCharacterNoRsp' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWrite.CharacterWriteListener'] and parameter[6][@type='boolean']]"
		[Register ("writeCharacterNoRsp", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V", "GetWriteCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler")]
		public virtual unsafe void WriteCharacterNoRsp (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener response, bool loggable)
		{
			const string __id = "writeCharacterNoRsp.(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue (native_value);
				__args [4] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [5] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_writeCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z;
#pragma warning disable 0169
		static Delegate GetWriteCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_ZHandler ()
		{
			if (cb_writeCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z == null)
				cb_writeCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLZ_V) n_WriteCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z);
			return cb_writeCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z;
		}

		static void n_WriteCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_service, IntPtr native_character, IntPtr native_value, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWriteReliable.ICharacterWriteReliableListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWriteReliable.ICharacterWriteReliableListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.WriteCharacterReliable (mac, service, character, value, listener, loggable);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='writeCharacterReliable' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWriteReliable.CharacterWriteReliableListener'] and parameter[6][@type='boolean']]"
		[Register ("writeCharacterReliable", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWriteReliable$CharacterWriteReliableListener;Z)V", "GetWriteCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_ZHandler")]
		public virtual unsafe void WriteCharacterReliable (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWriteReliable.ICharacterWriteReliableListener listener, bool loggable)
		{
			const string __id = "writeCharacterReliable.(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWriteReliable$CharacterWriteReliableListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue (native_value);
				__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [5] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_writeDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z;
#pragma warning disable 0169
		static Delegate GetWriteDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_ZHandler ()
		{
			if (cb_writeDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z == null)
				cb_writeDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLLZ_V) n_WriteDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z);
			return cb_writeDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z;
		}

		static void n_WriteDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, IntPtr native_service, IntPtr native_character, IntPtr native_descriptor, IntPtr native_value, IntPtr native_response, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var descriptor = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_descriptor, JniHandleOwnership.DoNotTransfer);
			var value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var response = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.WriteDescriptor (mac, service, character, descriptor, value, response, loggable);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='writeDescriptor' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='java.util.UUID'] and parameter[5][@type='byte[]'] and parameter[6][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorWrite.DescriptorWriteListener'] and parameter[7][@type='boolean']]"
		[Register ("writeDescriptor", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V", "GetWriteDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_ZHandler")]
		public virtual unsafe void WriteDescriptor (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Java.Util.UUID descriptor, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener response, bool loggable)
		{
			const string __id = "writeDescriptor.(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue ((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) descriptor).Handle);
				__args [4] = new JniArgumentValue (native_value);
				__args [5] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [6] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
