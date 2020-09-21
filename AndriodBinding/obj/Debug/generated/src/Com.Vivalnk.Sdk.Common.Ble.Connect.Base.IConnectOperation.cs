using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IConnectOperation']"
	[Register ("com/vivalnk/sdk/common/ble/connect/base/IConnectOperation", "", "Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IConnectOperationInvoker")]
	public partial interface IConnectOperation : IJavaObject {

		bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IConnectOperation']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IConnectOperationInvoker, AndriodBinding")] get;
		}

		bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IConnectOperation']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IConnectOperationInvoker, AndriodBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IConnectOperation']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.BleConnectOptions'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.BleConnectMaster.BluetoothConnectListener']]"
		[Register ("connect", "(Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V", "GetConnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IConnectOperationInvoker, AndriodBinding")]
		void Connect (global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions p0, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener p1);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/base/IConnectOperation", DoNotGenerateAcw=true)]
	internal partial class IConnectOperationInvoker : global::Java.Lang.Object, IConnectOperation {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/base/IConnectOperation");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConnectOperationInvoker); }
		}

		IntPtr class_ref;

		public static IConnectOperation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectOperation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.connect.base.IConnectOperation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectOperationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IConnectOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		IntPtr id_isConnected;
		public unsafe bool IsConnected {
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected);
			}
		}

		static Delegate cb_isConnecting;
#pragma warning disable 0169
		static Delegate GetIsConnectingHandler ()
		{
			if (cb_isConnecting == null)
				cb_isConnecting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnecting);
			return cb_isConnecting;
		}

		static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IConnectOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		IntPtr id_isConnecting;
		public unsafe bool IsConnecting {
			get {
				if (id_isConnecting == IntPtr.Zero)
					id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnecting);
			}
		}

		static Delegate cb_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler ()
		{
			if (cb_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ == null)
				cb_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_);
			return cb_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
		}

		static void n_Connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IConnectOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
		public unsafe void Connect (global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions p0, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener p1)
		{
			if (id_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ == IntPtr.Zero)
				id_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_, __args);
		}

	}

}
