using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BleDeviceManager", DoNotGenerateAcw=true)]
	public partial class BleDeviceManager : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Ble.IBleManagerInterface {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/BleDeviceManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleDeviceManager); }
		}

		protected BleDeviceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/constructor[@name='BleDeviceManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BleDeviceManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BleDeviceManager)) {
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

		static IntPtr id_checkBleRuntime_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='checkBleRuntime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("checkBleRuntime", "(Landroid/content/Context;)I", "")]
		public static unsafe int CheckBleRuntime (global::Android.Content.Context context)
		{
			if (id_checkBleRuntime_Landroid_content_Context_ == IntPtr.Zero)
				id_checkBleRuntime_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkBleRuntime", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_checkBleRuntime_Landroid_content_Context_, __args);
				return __ret;
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

		static IntPtr id_clearAllRequest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='clearAllRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearAllRequest", "(Ljava/lang/String;)V", "GetClearAllRequest_Ljava_lang_String_Handler")]
		public virtual unsafe void ClearAllRequest (string mac)
		{
			if (id_clearAllRequest_Ljava_lang_String_ == IntPtr.Zero)
				id_clearAllRequest_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearAllRequest", "(Ljava/lang/String;)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAllRequest_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAllRequest", "(Ljava/lang/String;)V"), __args);
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

		static IntPtr id_closeIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='closeIndicate' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener'] and parameter[5][@type='boolean']]"
		[Register ("closeIndicate", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V", "GetCloseIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler")]
		public virtual unsafe void CloseIndicate (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener response, bool loggable)
		{
			if (id_closeIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z == IntPtr.Zero)
				id_closeIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z = JNIEnv.GetMethodID (class_ref, "closeIndicate", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (service);
				__args [2] = new JValue (character);
				__args [3] = new JValue (response);
				__args [4] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeIndicate", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V"), __args);
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

		static IntPtr id_closeNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='closeNotify' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.NotifyRequest.NotifyChangeListener'] and parameter[5][@type='boolean']]"
		[Register ("closeNotify", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V", "GetCloseNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler")]
		public virtual unsafe void CloseNotify (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener response, bool loggable)
		{
			if (id_closeNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == IntPtr.Zero)
				id_closeNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNIEnv.GetMethodID (class_ref, "closeNotify", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (service);
				__args [2] = new JValue (character);
				__args [3] = new JValue (response);
				__args [4] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeNotify", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V"), __args);
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

		static IntPtr id_connect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.BleConnectOptions'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.BleConnectMaster.BluetoothConnectListener']]"
		[Register ("connect", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V", "GetConnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler")]
		public virtual unsafe void Connect (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions options, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener response)
		{
			if (id_connect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ == IntPtr.Zero)
				id_connect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (options);
				__args [2] = new JValue (response);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V"), __args);
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

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
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

		static IntPtr id_disableBle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='disableBle' and count(parameter)=0]"
		[Register ("disableBle", "()V", "GetDisableBleHandler")]
		public virtual unsafe void DisableBle ()
		{
			if (id_disableBle == IntPtr.Zero)
				id_disableBle = JNIEnv.GetMethodID (class_ref, "disableBle", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableBle);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableBle", "()V"));
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

		static IntPtr id_disconnect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("disconnect", "(Ljava/lang/String;)V", "GetDisconnect_Ljava_lang_String_Handler")]
		public virtual unsafe void Disconnect (string mac)
		{
			if (id_disconnect_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/String;)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(Ljava/lang/String;)V"), __args);
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

		static IntPtr id_disconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='disconnect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.BleConnectMaster.BluetoothConnectListener']]"
		[Register ("disconnect", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V", "GetDisconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler")]
		public virtual unsafe void Disconnect (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener listener)
		{
			if (id_disconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V"), __args);
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

		static IntPtr id_disconnectAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='disconnectAll' and count(parameter)=0]"
		[Register ("disconnectAll", "()V", "GetDisconnectAllHandler")]
		public virtual unsafe void DisconnectAll ()
		{
			if (id_disconnectAll == IntPtr.Zero)
				id_disconnectAll = JNIEnv.GetMethodID (class_ref, "disconnectAll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectAll", "()V"));
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

		static IntPtr id_disconnectQuietly_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='disconnectQuietly' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("disconnectQuietly", "(Ljava/lang/String;)V", "GetDisconnectQuietly_Ljava_lang_String_Handler")]
		public virtual unsafe void DisconnectQuietly (string mac)
		{
			if (id_disconnectQuietly_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnectQuietly_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "disconnectQuietly", "(Ljava/lang/String;)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectQuietly_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectQuietly", "(Ljava/lang/String;)V"), __args);
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

		static IntPtr id_enableBle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='enableBle' and count(parameter)=0]"
		[Register ("enableBle", "()V", "GetEnableBleHandler")]
		public virtual unsafe void EnableBle ()
		{
			if (id_enableBle == IntPtr.Zero)
				id_enableBle = JNIEnv.GetMethodID (class_ref, "enableBle", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableBle);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableBle", "()V"));
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

		static IntPtr id_getBluetoothDevice_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='getBluetoothDevice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBluetoothDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;", "GetGetBluetoothDevice_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Bluetooth.BluetoothDevice GetBluetoothDevice (string mac)
		{
			if (id_getBluetoothDevice_Ljava_lang_String_ == IntPtr.Zero)
				id_getBluetoothDevice_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBluetoothDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);

				global::Android.Bluetooth.BluetoothDevice __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBluetoothDevice_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBluetoothDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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

		static IntPtr id_getConnectStatus_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='getConnectStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConnectStatus", "(Ljava/lang/String;)I", "GetGetConnectStatus_Ljava_lang_String_Handler")]
		public virtual unsafe int GetConnectStatus (string mac)
		{
			if (id_getConnectStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_getConnectStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConnectStatus", "(Ljava/lang/String;)I");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConnectStatus_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectStatus", "(Ljava/lang/String;)I"), __args);
				return __ret;
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

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context context)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;)V"), __args);
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

		static IntPtr id_isConnected_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='isConnected' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isConnected", "(Ljava/lang/String;)Z", "GetIsConnected_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsConnected (string mac)
		{
			if (id_isConnected_Ljava_lang_String_ == IntPtr.Zero)
				id_isConnected_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isConnected", "(Ljava/lang/String;)Z");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "(Ljava/lang/String;)Z"), __args);
				return __ret;
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

		static IntPtr id_isConnecting_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='isConnecting' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isConnecting", "(Ljava/lang/String;)Z", "GetIsConnecting_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsConnecting (string mac)
		{
			if (id_isConnecting_Ljava_lang_String_ == IntPtr.Zero)
				id_isConnecting_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isConnecting", "(Ljava/lang/String;)Z");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnecting_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnecting", "(Ljava/lang/String;)Z"), __args);
				return __ret;
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

		static IntPtr id_openIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='openIndicate' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener'] and parameter[5][@type='boolean']]"
		[Register ("openIndicate", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V", "GetOpenIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler")]
		public virtual unsafe void OpenIndicate (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener response, bool loggable)
		{
			if (id_openIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z == IntPtr.Zero)
				id_openIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z = JNIEnv.GetMethodID (class_ref, "openIndicate", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (service);
				__args [2] = new JValue (character);
				__args [3] = new JValue (response);
				__args [4] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openIndicate_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openIndicate", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V"), __args);
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

		static IntPtr id_openNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='openNotify' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.NotifyRequest.NotifyChangeListener'] and parameter[5][@type='boolean']]"
		[Register ("openNotify", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V", "GetOpenNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler")]
		public virtual unsafe void OpenNotify (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener response, bool loggable)
		{
			if (id_openNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == IntPtr.Zero)
				id_openNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNIEnv.GetMethodID (class_ref, "openNotify", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (service);
				__args [2] = new JValue (character);
				__args [3] = new JValue (response);
				__args [4] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openNotify_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openNotify", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V"), __args);
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

		static IntPtr id_readCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='readCharacter' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterRead.CharacterReadListener'] and parameter[5][@type='boolean']]"
		[Register ("readCharacter", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V", "GetReadCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_ZHandler")]
		public virtual unsafe void ReadCharacter (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener response, bool loggable)
		{
			if (id_readCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z == IntPtr.Zero)
				id_readCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z = JNIEnv.GetMethodID (class_ref, "readCharacter", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (service);
				__args [2] = new JValue (character);
				__args [3] = new JValue (response);
				__args [4] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readCharacter", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V"), __args);
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

		static IntPtr id_readDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='readDescriptor' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='java.util.UUID'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorRead.DescriptorReadListener'] and parameter[6][@type='boolean']]"
		[Register ("readDescriptor", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V", "GetReadDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_ZHandler")]
		public virtual unsafe void ReadDescriptor (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Java.Util.UUID descriptor, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener response, bool loggable)
		{
			if (id_readDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z == IntPtr.Zero)
				id_readDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z = JNIEnv.GetMethodID (class_ref, "readDescriptor", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (service);
				__args [2] = new JValue (character);
				__args [3] = new JValue (descriptor);
				__args [4] = new JValue (response);
				__args [5] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readDescriptor", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V"), __args);
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

		static IntPtr id_readRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='readRemoteRssi' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.request.ReadRemoteRssi.ReadRssiListener'] and parameter[3][@type='boolean']]"
		[Register ("readRemoteRssi", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V", "GetReadRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_ZHandler")]
		public virtual unsafe void ReadRemoteRssi (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener response, bool loggable)
		{
			if (id_readRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z == IntPtr.Zero)
				id_readRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z = JNIEnv.GetMethodID (class_ref, "readRemoteRssi", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (response);
				__args [2] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readRemoteRssi_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readRemoteRssi", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V"), __args);
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

		static IntPtr id_refreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='refreshDeviceCache' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.request.RefreshCache.RefreshCacheListener'] and parameter[3][@type='boolean']]"
		[Register ("refreshDeviceCache", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/RefreshCache$RefreshCacheListener;Z)V", "GetRefreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_ZHandler")]
		public virtual unsafe void RefreshDeviceCache (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.RefreshCache.IRefreshCacheListener listener, bool loggable)
		{
			if (id_refreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Z == IntPtr.Zero)
				id_refreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Z = JNIEnv.GetMethodID (class_ref, "refreshDeviceCache", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/RefreshCache$RefreshCacheListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (listener);
				__args [2] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshDeviceCache_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshDeviceCache", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/request/RefreshCache$RefreshCacheListener;Z)V"), __args);
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

		static IntPtr id_registBluetoothReceiver_Landroid_content_BroadcastReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='registBluetoothReceiver' and count(parameter)=1 and parameter[1][@type='android.content.BroadcastReceiver']]"
		[Register ("registBluetoothReceiver", "(Landroid/content/BroadcastReceiver;)V", "GetRegistBluetoothReceiver_Landroid_content_BroadcastReceiver_Handler")]
		public virtual unsafe void RegistBluetoothReceiver (global::Android.Content.BroadcastReceiver receiver)
		{
			if (id_registBluetoothReceiver_Landroid_content_BroadcastReceiver_ == IntPtr.Zero)
				id_registBluetoothReceiver_Landroid_content_BroadcastReceiver_ = JNIEnv.GetMethodID (class_ref, "registBluetoothReceiver", "(Landroid/content/BroadcastReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (receiver);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registBluetoothReceiver_Landroid_content_BroadcastReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registBluetoothReceiver", "(Landroid/content/BroadcastReceiver;)V"), __args);
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

		static IntPtr id_requestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='requestMtu' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.MtuRequest.MtuListener'] and parameter[4][@type='boolean']]"
		[Register ("requestMtu", "(Ljava/lang/String;ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V", "GetRequestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_ZHandler")]
		public virtual unsafe void RequestMtu (string mac, int mtu, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener response, bool loggable)
		{
			if (id_requestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z == IntPtr.Zero)
				id_requestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z = JNIEnv.GetMethodID (class_ref, "requestMtu", "(Ljava/lang/String;ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (mtu);
				__args [2] = new JValue (response);
				__args [3] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestMtu_Ljava_lang_String_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestMtu", "(Ljava/lang/String;ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V"), __args);
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

		static IntPtr id_setContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='startScan' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.scan.ScanOptions'] and parameter[2][@type='com.vivalnk.sdk.common.ble.scan.BleScanListener']]"
		[Register ("startScan", "(Lcom/vivalnk/sdk/common/ble/scan/ScanOptions;Lcom/vivalnk/sdk/common/ble/scan/BleScanListener;)V", "GetStartScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_Handler")]
		public virtual unsafe void StartScan (global::Com.Vivalnk.Sdk.Common.Ble.Scan.ScanOptions options, global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener listener)
		{
			if (id_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_ == IntPtr.Zero)
				id_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_ = JNIEnv.GetMethodID (class_ref, "startScan", "(Lcom/vivalnk/sdk/common/ble/scan/ScanOptions;Lcom/vivalnk/sdk/common/ble/scan/BleScanListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (options);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startScan", "(Lcom/vivalnk/sdk/common/ble/scan/ScanOptions;Lcom/vivalnk/sdk/common/ble/scan/BleScanListener;)V"), __args);
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

		static IntPtr id_stopScan;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='stopScan' and count(parameter)=0]"
		[Register ("stopScan", "()V", "GetStopScanHandler")]
		public virtual unsafe void StopScan ()
		{
			if (id_stopScan == IntPtr.Zero)
				id_stopScan = JNIEnv.GetMethodID (class_ref, "stopScan", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopScan);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopScan", "()V"));
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

		static IntPtr id_unregistAllReceiver;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='unregistAllReceiver' and count(parameter)=0]"
		[Register ("unregistAllReceiver", "()V", "GetUnregistAllReceiverHandler")]
		public virtual unsafe void UnregistAllReceiver ()
		{
			if (id_unregistAllReceiver == IntPtr.Zero)
				id_unregistAllReceiver = JNIEnv.GetMethodID (class_ref, "unregistAllReceiver", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregistAllReceiver);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregistAllReceiver", "()V"));
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

		static IntPtr id_unregistBluetoothReceiver;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='unregistBluetoothReceiver' and count(parameter)=0]"
		[Register ("unregistBluetoothReceiver", "()V", "GetUnregistBluetoothReceiverHandler")]
		public virtual unsafe void UnregistBluetoothReceiver ()
		{
			if (id_unregistBluetoothReceiver == IntPtr.Zero)
				id_unregistBluetoothReceiver = JNIEnv.GetMethodID (class_ref, "unregistBluetoothReceiver", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregistBluetoothReceiver);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregistBluetoothReceiver", "()V"));
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

		static IntPtr id_writeCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='writeCharacter' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWrite.CharacterWriteListener'] and parameter[6][@type='boolean']]"
		[Register ("writeCharacter", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V", "GetWriteCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler")]
		public virtual unsafe void WriteCharacter (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener response, bool loggable)
		{
			if (id_writeCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z == IntPtr.Zero)
				id_writeCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z = JNIEnv.GetMethodID (class_ref, "writeCharacter", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (service);
				__args [2] = new JValue (character);
				__args [3] = new JValue (native_value);
				__args [4] = new JValue (response);
				__args [5] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeCharacter_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeCharacter", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V"), __args);
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

		static IntPtr id_writeCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='writeCharacterNoRsp' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWrite.CharacterWriteListener'] and parameter[6][@type='boolean']]"
		[Register ("writeCharacterNoRsp", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V", "GetWriteCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler")]
		public virtual unsafe void WriteCharacterNoRsp (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener response, bool loggable)
		{
			if (id_writeCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z == IntPtr.Zero)
				id_writeCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z = JNIEnv.GetMethodID (class_ref, "writeCharacterNoRsp", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (service);
				__args [2] = new JValue (character);
				__args [3] = new JValue (native_value);
				__args [4] = new JValue (response);
				__args [5] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeCharacterNoRsp_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeCharacterNoRsp", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V"), __args);
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

		static IntPtr id_writeCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='writeCharacterReliable' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWriteReliable.CharacterWriteReliableListener'] and parameter[6][@type='boolean']]"
		[Register ("writeCharacterReliable", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWriteReliable$CharacterWriteReliableListener;Z)V", "GetWriteCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_ZHandler")]
		public virtual unsafe void WriteCharacterReliable (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWriteReliable.ICharacterWriteReliableListener listener, bool loggable)
		{
			if (id_writeCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z == IntPtr.Zero)
				id_writeCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z = JNIEnv.GetMethodID (class_ref, "writeCharacterReliable", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWriteReliable$CharacterWriteReliableListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (service);
				__args [2] = new JValue (character);
				__args [3] = new JValue (native_value);
				__args [4] = new JValue (listener);
				__args [5] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeCharacterReliable_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeCharacterReliable", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWriteReliable$CharacterWriteReliableListener;Z)V"), __args);
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

		static IntPtr id_writeDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleDeviceManager']/method[@name='writeDescriptor' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='java.util.UUID'] and parameter[5][@type='byte[]'] and parameter[6][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorWrite.DescriptorWriteListener'] and parameter[7][@type='boolean']]"
		[Register ("writeDescriptor", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V", "GetWriteDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_ZHandler")]
		public virtual unsafe void WriteDescriptor (string mac, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Java.Util.UUID descriptor, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener response, bool loggable)
		{
			if (id_writeDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z == IntPtr.Zero)
				id_writeDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z = JNIEnv.GetMethodID (class_ref, "writeDescriptor", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (service);
				__args [2] = new JValue (character);
				__args [3] = new JValue (descriptor);
				__args [4] = new JValue (native_value);
				__args [5] = new JValue (response);
				__args [6] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeDescriptor_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeDescriptor", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V"), __args);
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
