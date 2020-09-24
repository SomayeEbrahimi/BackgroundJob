using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/BleIODispatcher", DoNotGenerateAcw=true)]
	public partial class BleIODispatcher : global::Java.Lang.Object, global::Android.OS.Handler.ICallback, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/BleIODispatcher", typeof (BleIODispatcher));
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

		protected BleIODispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_checkRuntime;
#pragma warning disable 0169
		static Delegate GetCheckRuntimeHandler ()
		{
			if (cb_checkRuntime == null)
				cb_checkRuntime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CheckRuntime);
			return cb_checkRuntime;
		}

		static void n_CheckRuntime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckRuntime ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='checkRuntime' and count(parameter)=0]"
		[Register ("checkRuntime", "()V", "GetCheckRuntimeHandler")]
		public virtual unsafe void CheckRuntime ()
		{
			const string __id = "checkRuntime.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearAllRequest;
#pragma warning disable 0169
		static Delegate GetClearAllRequestHandler ()
		{
			if (cb_clearAllRequest == null)
				cb_clearAllRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearAllRequest);
			return cb_clearAllRequest;
		}

		static void n_ClearAllRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllRequest ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='clearAllRequest' and count(parameter)=0]"
		[Register ("clearAllRequest", "()V", "GetClearAllRequestHandler")]
		public virtual unsafe void ClearAllRequest ()
		{
			const string __id = "clearAllRequest.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_excute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
#pragma warning disable 0169
		static Delegate GetExcute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_Handler ()
		{
			if (cb_excute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ == null)
				cb_excute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Excute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_);
			return cb_excute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
		}

		static void n_Excute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.Excute (request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='excute' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.base.BaseIORequest']]"
		[Register ("excute", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V", "GetExcute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_Handler")]
		public virtual unsafe void Excute (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest request)
		{
			const string __id = "excute.(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (msg);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='java.lang.String']]"
		[Register ("newInstance", "(Landroid/content/Context;Landroid/os/Handler;Ljava/lang/String;)Lcom/vivalnk/sdk/common/ble/connect/BleIODispatcher;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher NewInstance (global::Android.Content.Context context, global::Android.OS.Handler mWorkerHandler, string mac)
		{
			const string __id = "newInstance.(Landroid/content/Context;Landroid/os/Handler;Ljava/lang/String;)Lcom/vivalnk/sdk/common/ble/connect/BleIODispatcher;";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mWorkerHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mWorkerHandler).Handle);
				__args [2] = new JniArgumentValue (native_mac);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
#pragma warning disable 0169
		static Delegate GetOnRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_Handler ()
		{
			if (cb_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ == null)
				cb_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_);
			return cb_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
		}

		static void n_OnRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestFinsh (request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='onRequestFinsh' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.base.BaseIORequest']]"
		[Register ("onRequestFinsh", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V", "GetOnRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_Handler")]
		public virtual unsafe void OnRequestFinsh (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest request)
		{
			const string __id = "onRequestFinsh.(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var connectMaster = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (native_connectMaster, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectMaster (connectMaster);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='setConnectMaster' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.base.BaseGattIOOperation']]"
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

	}
}
