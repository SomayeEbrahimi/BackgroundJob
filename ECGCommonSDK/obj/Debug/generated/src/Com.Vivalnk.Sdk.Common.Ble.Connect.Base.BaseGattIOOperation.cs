using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/base/BaseGattIOOperation", DoNotGenerateAcw=true)]
	public partial class BaseGattIOOperation : global::Android.Bluetooth.BluetoothGattCallback, global::Android.OS.Handler.ICallback, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/field[@name='dispatcher']"
		[Register ("dispatcher")]
		protected global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher Dispatcher {
			get {
				const string __id = "dispatcher.Lcom/vivalnk/sdk/common/ble/connect/BleIODispatcher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleIODispatcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dispatcher.Lcom/vivalnk/sdk/common/ble/connect/BleIODispatcher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/field[@name='mContext']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/field[@name='mMainHandler']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/field[@name='mWorkerHandler']"
		[Register ("mWorkerHandler")]
		protected global::Android.OS.Handler MWorkerHandler {
			get {
				const string __id = "mWorkerHandler.Landroid/os/Handler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mWorkerHandler.Landroid/os/Handler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/field[@name='mac']"
		[Register ("mac")]
		protected string Mac {
			get {
				const string __id = "mac.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mac.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/base/BaseGattIOOperation", typeof (BaseGattIOOperation));
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

		protected BaseGattIOOperation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/constructor[@name='BaseGattIOOperation' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe BaseGattIOOperation (global::Android.Content.Context context, string mac)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_mac);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_getCurrentRequest;
#pragma warning disable 0169
		static Delegate GetGetCurrentRequestHandler ()
		{
			if (cb_getCurrentRequest == null)
				cb_getCurrentRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentRequest);
			return cb_getCurrentRequest;
		}

		static IntPtr n_GetCurrentRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentRequest);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentRequest_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
#pragma warning disable 0169
		static Delegate GetSetCurrentRequest_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_Handler ()
		{
			if (cb_setCurrentRequest_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ == null)
				cb_setCurrentRequest_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCurrentRequest_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_);
			return cb_setCurrentRequest_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
		}

		static void n_SetCurrentRequest_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.CurrentRequest = request;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest CurrentRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='getCurrentRequest' and count(parameter)=0]"
			[Register ("getCurrentRequest", "()Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;", "GetGetCurrentRequestHandler")]
			get {
				const string __id = "getCurrentRequest.()Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='setCurrentRequest' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.base.BaseIORequest']]"
			[Register ("setCurrentRequest", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V", "GetSetCurrentRequest_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_Handler")]
			set {
				const string __id = "setCurrentRequest.(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllRequest ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='clearAllRequest' and count(parameter)=0]"
		[Register ("clearAllRequest", "()V", "GetClearAllRequestHandler")]
		public virtual unsafe void ClearAllRequest ()
		{
			const string __id = "clearAllRequest.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_closeIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z;
#pragma warning disable 0169
		static Delegate GetCloseIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_ZHandler ()
		{
			if (cb_closeIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z == null)
				cb_closeIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_CloseIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z);
			return cb_closeIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z;
		}

		static void n_CloseIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_listener, IntPtr native_service, IntPtr native_character, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			__this.CloseIndicate (listener, service, character, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='closeIndicate' and count(parameter)=4 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='boolean']]"
		[Register ("closeIndicate", "(Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Ljava/util/UUID;Ljava/util/UUID;Z)V", "GetCloseIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_ZHandler")]
		public virtual unsafe void CloseIndicate (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener listener, global::Java.Util.UUID service, global::Java.Util.UUID character, bool loggable)
		{
			const string __id = "closeIndicate.(Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Ljava/util/UUID;Ljava/util/UUID;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z;
#pragma warning disable 0169
		static Delegate GetDiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ZHandler ()
		{
			if (cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z == null)
				cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_DiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z);
			return cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z;
		}

		static void n_DiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DiscoverService (listener, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='discoverService' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.request.DiscoverService.DiscoverServiceListener'] and parameter[2][@type='boolean']]"
		[Register ("discoverService", "(Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;Z)V", "GetDiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ZHandler")]
		public virtual unsafe void DiscoverService (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener listener, bool loggable)
		{
			const string __id = "discoverService.(Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue (loggable);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (msg);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
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

		static Delegate cb_notify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
#pragma warning disable 0169
		static Delegate GetNotify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler ()
		{
			if (cb_notify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == null)
				cb_notify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_Notify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z);
			return cb_notify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		}

		static void n_Notify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Notify (service, character, listener, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='notify' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.NotifyRequest.NotifyChangeListener'] and parameter[4][@type='boolean']]"
		[Register ("notify", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V", "GetNotify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler")]
		public virtual unsafe void Notify (global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener listener, bool loggable)
		{
			const string __id = "notify.(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_openIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z;
#pragma warning disable 0169
		static Delegate GetOpenIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_ZHandler ()
		{
			if (cb_openIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z == null)
				cb_openIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_OpenIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z);
			return cb_openIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z;
		}

		static void n_OpenIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_listener, IntPtr native_service, IntPtr native_character, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			__this.OpenIndicate (listener, service, character, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='openIndicate' and count(parameter)=4 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='boolean']]"
		[Register ("openIndicate", "(Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Ljava/util/UUID;Ljava/util/UUID;Z)V", "GetOpenIndicate_Lcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Ljava_util_UUID_Ljava_util_UUID_ZHandler")]
		public virtual unsafe void OpenIndicate (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener listener, global::Java.Util.UUID service, global::Java.Util.UUID character, bool loggable)
		{
			const string __id = "openIndicate.(Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Ljava/util/UUID;Ljava/util/UUID;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [2] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [3] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
#pragma warning disable 0169
		static Delegate GetReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_ZHandler ()
		{
			if (cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z == null)
				cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_ReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z);
			return cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
		}

		static void n_ReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadCharacteristic (service, character, listener, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='readCharacteristic' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterRead.CharacterReadListener'] and parameter[4][@type='boolean']]"
		[Register ("readCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V", "GetReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_ZHandler")]
		public virtual unsafe void ReadCharacteristic (global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener listener, bool loggable)
		{
			const string __id = "readCharacteristic.(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
#pragma warning disable 0169
		static Delegate GetReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_ZHandler ()
		{
			if (cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z == null)
				cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_ReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z);
			return cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
		}

		static void n_ReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_descriptor, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var descriptor = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_descriptor, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadDescriptor (service, character, descriptor, listener, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='readDescriptor' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorRead.DescriptorReadListener'] and parameter[5][@type='boolean']]"
		[Register ("readDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V", "GetReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_ZHandler")]
		public virtual unsafe void ReadDescriptor (global::Java.Util.UUID service, global::Java.Util.UUID character, global::Java.Util.UUID descriptor, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener listener, bool loggable)
		{
			const string __id = "readDescriptor.(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [2] = new JniArgumentValue ((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) descriptor).Handle);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [4] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
#pragma warning disable 0169
		static Delegate GetReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_ZHandler ()
		{
			if (cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z == null)
				cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_ReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z);
			return cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
		}

		static void n_ReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadRemoteRssi (listener, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='readRemoteRssi' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.request.ReadRemoteRssi.ReadRssiListener'] and parameter[2][@type='boolean']]"
		[Register ("readRemoteRssi", "(Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V", "GetReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_ZHandler")]
		public virtual unsafe void ReadRemoteRssi (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener listener, bool loggable)
		{
			const string __id = "readRemoteRssi.(Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_refreshDeviceCache_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_;
#pragma warning disable 0169
		static Delegate GetRefreshDeviceCache_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Handler ()
		{
			if (cb_refreshDeviceCache_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_ == null)
				cb_refreshDeviceCache_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RefreshDeviceCache_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_);
			return cb_refreshDeviceCache_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_;
		}

		static void n_RefreshDeviceCache_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.RefreshCache.IRefreshCacheListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.RefreshCache.IRefreshCacheListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RefreshDeviceCache (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='refreshDeviceCache' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.request.RefreshCache.RefreshCacheListener']]"
		[Register ("refreshDeviceCache", "(Lcom/vivalnk/sdk/common/ble/connect/request/RefreshCache$RefreshCacheListener;)V", "GetRefreshDeviceCache_Lcom_vivalnk_sdk_common_ble_connect_request_RefreshCache_RefreshCacheListener_Handler")]
		public virtual unsafe void RefreshDeviceCache (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.RefreshCache.IRefreshCacheListener listener)
		{
			const string __id = "refreshDeviceCache.(Lcom/vivalnk/sdk/common/ble/connect/request/RefreshCache$RefreshCacheListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
#pragma warning disable 0169
		static Delegate GetRequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_ZHandler ()
		{
			if (cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z == null)
				cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILZ_V) n_RequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z);
			return cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
		}

		static void n_RequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z (IntPtr jnienv, IntPtr native__this, int mtu, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RequestMtu (mtu, listener, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='requestMtu' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.request.MtuRequest.MtuListener'] and parameter[3][@type='boolean']]"
		[Register ("requestMtu", "(ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V", "GetRequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_ZHandler")]
		public virtual unsafe void RequestMtu (int mtu, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener listener, bool loggable)
		{
			const string __id = "requestMtu.(ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (mtu);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [2] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
#pragma warning disable 0169
		static Delegate GetSetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler ()
		{
			if (cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z == null)
				cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZLZ_V) n_SetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z);
			return cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
		}

		static void n_SetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, bool enable, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetCharacteristicIndication (service, character, enable, listener, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='setCharacteristicIndication' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='boolean'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener'] and parameter[5][@type='boolean']]"
		[Register ("setCharacteristicIndication", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V", "GetSetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler")]
		public virtual unsafe void SetCharacteristicIndication (global::Java.Util.UUID service, global::Java.Util.UUID character, bool enable, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener listener, bool loggable)
		{
			const string __id = "setCharacteristicIndication.(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [2] = new JniArgumentValue (enable);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [4] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
#pragma warning disable 0169
		static Delegate GetSetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler ()
		{
			if (cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == null)
				cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZLZ_V) n_SetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z);
			return cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		}

		static void n_SetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, bool enable, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetCharacteristicNotification (service, character, enable, listener, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='setCharacteristicNotification' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='boolean'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.NotifyRequest.NotifyChangeListener'] and parameter[5][@type='boolean']]"
		[Register ("setCharacteristicNotification", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V", "GetSetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler")]
		public virtual unsafe void SetCharacteristicNotification (global::Java.Util.UUID service, global::Java.Util.UUID character, bool enable, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener listener, bool loggable)
		{
			const string __id = "setCharacteristicNotification.(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [2] = new JniArgumentValue (enable);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [4] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unnotify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
#pragma warning disable 0169
		static Delegate GetUnnotify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler ()
		{
			if (cb_unnotify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == null)
				cb_unnotify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_Unnotify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z);
			return cb_unnotify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		}

		static void n_Unnotify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Unnotify (service, character, listener, loggable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='unnotify' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.NotifyRequest.NotifyChangeListener'] and parameter[4][@type='boolean']]"
		[Register ("unnotify", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V", "GetUnnotify_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler")]
		public virtual unsafe void Unnotify (global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener listener, bool loggable)
		{
			const string __id = "unnotify.(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
#pragma warning disable 0169
		static Delegate GetWriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler ()
		{
			if (cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z == null)
				cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_WriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z);
			return cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
		}

		static void n_WriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_value, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.WriteCharacteristic (service, character, value, listener, loggable);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='writeCharacteristic' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWrite.CharacterWriteListener'] and parameter[5][@type='boolean']]"
		[Register ("writeCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V", "GetWriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler")]
		public virtual unsafe void WriteCharacteristic (global::Java.Util.UUID service, global::Java.Util.UUID character, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener listener, bool loggable)
		{
			const string __id = "writeCharacteristic.(Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [2] = new JniArgumentValue (native_value);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [4] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z;
#pragma warning disable 0169
		static Delegate GetWriteDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_ZHandler ()
		{
			if (cb_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z == null)
				cb_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLZ_V) n_WriteDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z);
			return cb_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z;
		}

		static void n_WriteDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_descriptor, IntPtr native_value, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var descriptor = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_descriptor, JniHandleOwnership.DoNotTransfer);
			var value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.WriteDescriptor (service, character, descriptor, value, listener, loggable);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='BaseGattIOOperation']/method[@name='writeDescriptor' and count(parameter)=6 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorWrite.DescriptorWriteListener'] and parameter[6][@type='boolean']]"
		[Register ("writeDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V", "GetWriteDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_ZHandler")]
		public virtual unsafe void WriteDescriptor (global::Java.Util.UUID service, global::Java.Util.UUID character, global::Java.Util.UUID descriptor, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener listener, bool loggable)
		{
			const string __id = "writeDescriptor.(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [2] = new JniArgumentValue ((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) descriptor).Handle);
				__args [3] = new JniArgumentValue (native_value);
				__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [5] = new JniArgumentValue (loggable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
