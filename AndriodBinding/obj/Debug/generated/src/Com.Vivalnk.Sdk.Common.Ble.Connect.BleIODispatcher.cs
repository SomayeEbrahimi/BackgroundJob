using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/BleIODispatcher", DoNotGenerateAcw=true)]
	public partial class BleIODispatcher : global::Java.Lang.Object, global::Android.OS.Handler.ICallback, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/BleIODispatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleIODispatcher); }
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

		static IntPtr id_checkRuntime;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='checkRuntime' and count(parameter)=0]"
		[Register ("checkRuntime", "()V", "GetCheckRuntimeHandler")]
		public virtual unsafe void CheckRuntime ()
		{
			if (id_checkRuntime == IntPtr.Zero)
				id_checkRuntime = JNIEnv.GetMethodID (class_ref, "checkRuntime", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkRuntime);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkRuntime", "()V"));
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

		static IntPtr id_clearAllRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='clearAllRequest' and count(parameter)=0]"
		[Register ("clearAllRequest", "()V", "GetClearAllRequestHandler")]
		public virtual unsafe void ClearAllRequest ()
		{
			if (id_clearAllRequest == IntPtr.Zero)
				id_clearAllRequest = JNIEnv.GetMethodID (class_ref, "clearAllRequest", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAllRequest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAllRequest", "()V"));
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

		static IntPtr id_excute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='excute' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.base.BaseIORequest']]"
		[Register ("excute", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V", "GetExcute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_Handler")]
		public virtual unsafe void Excute (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest request)
		{
			if (id_excute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ == IntPtr.Zero)
				id_excute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ = JNIEnv.GetMethodID (class_ref, "excute", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (request);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_excute_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "excute", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V"), __args);
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

		static IntPtr id_handleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
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

		static IntPtr id_newInstance_Landroid_content_Context_Landroid_os_Handler_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='java.lang.String']]"
		[Register ("newInstance", "(Landroid/content/Context;Landroid/os/Handler;Ljava/lang/String;)Lcom/vivalnk/sdk/common/ble/connect/BleIODispatcher;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher NewInstance (global::Android.Content.Context context, global::Android.OS.Handler mWorkerHandler, string mac)
		{
			if (id_newInstance_Landroid_content_Context_Landroid_os_Handler_Ljava_lang_String_ == IntPtr.Zero)
				id_newInstance_Landroid_content_Context_Landroid_os_Handler_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Landroid/content/Context;Landroid/os/Handler;Ljava/lang/String;)Lcom/vivalnk/sdk/common/ble/connect/BleIODispatcher;");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (mWorkerHandler);
				__args [2] = new JValue (native_mac);
				global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Landroid_content_Context_Landroid_os_Handler_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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

		static IntPtr id_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='onRequestFinsh' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.base.BaseIORequest']]"
		[Register ("onRequestFinsh", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V", "GetOnRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_Handler")]
		public virtual unsafe void OnRequestFinsh (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest request)
		{
			if (id_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ == IntPtr.Zero)
				id_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ = JNIEnv.GetMethodID (class_ref, "onRequestFinsh", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (request);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestFinsh", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V"), __args);
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

		static IntPtr id_setConnectMaster_Lcom_vivalnk_sdk_common_ble_connect_base_BaseGattIOOperation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleIODispatcher']/method[@name='setConnectMaster' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.base.BaseGattIOOperation']]"
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

	}
}
