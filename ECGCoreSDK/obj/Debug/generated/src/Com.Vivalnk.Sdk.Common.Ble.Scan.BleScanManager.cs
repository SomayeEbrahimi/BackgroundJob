using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Scan {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/scan/BleScanManager", DoNotGenerateAcw=true)]
	public partial class BleScanManager : global::Java.Lang.Object, global::Android.OS.Handler.ICallback, global::Com.Vivalnk.Sdk.Common.Ble.Scan.IScanOperation {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "BleScanManager";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/scan/BleScanManager$ScanEventPoster", DoNotGenerateAcw=true)]
		public partial class ScanEventPoster : global::Com.Vivalnk.Sdk.Common.Ble.Poster.AbsPoster, global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/scan/BleScanManager$ScanEventPoster", typeof (ScanEventPoster));
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

			protected ScanEventPoster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']/constructor[@name='BleScanManager.ScanEventPoster' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.scan.BleScanManager']]"
			[Register (".ctor", "(Lcom/vivalnk/sdk/common/ble/scan/BleScanManager;)V", "")]
			public unsafe ScanEventPoster (global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager.ScanEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnError (code, msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
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

			static Delegate cb_onScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_;
#pragma warning disable 0169
			static Delegate GetOnScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_Handler ()
			{
				if (cb_onScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_ == null)
					cb_onScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_);
				return cb_onScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_;
			}

			static void n_OnScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager.ScanEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var result = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanResult> (native_result, JniHandleOwnership.DoNotTransfer);
				__this.OnScanResult (result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']/method[@name='onScanResult' and count(parameter)=1 and parameter[1][@type='com.vivalnk.android.support.v18.scanner.ScanResult']]"
			[Register ("onScanResult", "(Lcom/vivalnk/android/support/v18/scanner/ScanResult;)V", "GetOnScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_Handler")]
			public virtual unsafe void OnScanResult (global::Com.Vivalnk.Android.Support.V18.Scanner.ScanResult result)
			{
				const string __id = "onScanResult.(Lcom/vivalnk/android/support/v18/scanner/ScanResult;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager.ScanEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStart ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']/method[@name='onStart' and count(parameter)=0]"
			[Register ("onStart", "()V", "GetOnStartHandler")]
			public virtual unsafe void OnStart ()
			{
				const string __id = "onStart.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_onStop;
#pragma warning disable 0169
			static Delegate GetOnStopHandler ()
			{
				if (cb_onStop == null)
					cb_onStop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStop);
				return cb_onStop;
			}

			static void n_OnStop (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager.ScanEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStop ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']/method[@name='onStop' and count(parameter)=0]"
			[Register ("onStop", "()V", "GetOnStopHandler")]
			public virtual unsafe void OnStop ()
			{
				const string __id = "onStop.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/scan/BleScanManager", typeof (BleScanManager));
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

		protected BleScanManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/constructor[@name='BleScanManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BleScanManager (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (msg);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
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

		static Delegate cb_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_;
#pragma warning disable 0169
		static Delegate GetOnBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_Handler ()
		{
			if (cb_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_ == null)
				cb_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_);
			return cb_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_;
		}

		static void n_OnBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.BluetoothStateEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnBluetoothStateChange (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/method[@name='onBluetoothStateChange' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.event.BluetoothStateEvent']]"
		[Register ("onBluetoothStateChange", "(Lcom/vivalnk/sdk/common/ble/connect/event/BluetoothStateEvent;)V", "GetOnBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_Handler")]
		public virtual unsafe void OnBluetoothStateChange (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.BluetoothStateEvent e)
		{
			const string __id = "onBluetoothStateChange.(Lcom/vivalnk/sdk/common/ble/connect/event/BluetoothStateEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.ScanOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.StartScan (options, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/method[@name='startScan' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.scan.ScanOptions'] and parameter[2][@type='com.vivalnk.sdk.common.ble.scan.BleScanListener']]"
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

		static Delegate cb_stopScanning;
#pragma warning disable 0169
		static Delegate GetStopScanningHandler ()
		{
			if (cb_stopScanning == null)
				cb_stopScanning = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopScanning);
			return cb_stopScanning;
		}

		static void n_StopScanning (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopScanning ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/method[@name='stopScanning' and count(parameter)=0]"
		[Register ("stopScanning", "()V", "GetStopScanningHandler")]
		public virtual unsafe void StopScanning ()
		{
			const string __id = "stopScanning.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
