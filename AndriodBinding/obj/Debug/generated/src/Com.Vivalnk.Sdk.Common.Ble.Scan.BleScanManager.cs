using System;
using System.Collections.Generic;
using Android.Runtime;

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

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/scan/BleScanManager$ScanEventPoster", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScanEventPoster); }
			}

			protected ScanEventPoster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_vivalnk_sdk_common_ble_scan_BleScanManager_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']/constructor[@name='BleScanManager.ScanEventPoster' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.scan.BleScanManager']]"
			[Register (".ctor", "(Lcom/vivalnk/sdk/common/ble/scan/BleScanManager;)V", "")]
			public unsafe ScanEventPoster (global::Com.Vivalnk.Sdk.Common.Ble.Scan.BleScanManager __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (ScanEventPoster)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_vivalnk_sdk_common_ble_scan_BleScanManager_ == IntPtr.Zero)
						id_ctor_Lcom_vivalnk_sdk_common_ble_scan_BleScanManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vivalnk/sdk/common/ble/scan/BleScanManager;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vivalnk_sdk_common_ble_scan_BleScanManager_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vivalnk_sdk_common_ble_scan_BleScanManager_, __args);
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

			static IntPtr id_onError_ILjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
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

			static IntPtr id_onScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']/method[@name='onScanResult' and count(parameter)=1 and parameter[1][@type='com.vivalnk.android.support.v18.scanner.ScanResult']]"
			[Register ("onScanResult", "(Lcom/vivalnk/android/support/v18/scanner/ScanResult;)V", "GetOnScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_Handler")]
			public virtual unsafe void OnScanResult (global::Com.Vivalnk.Android.Support.V18.Scanner.ScanResult result)
			{
				if (id_onScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_ == IntPtr.Zero)
					id_onScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_ = JNIEnv.GetMethodID (class_ref, "onScanResult", "(Lcom/vivalnk/android/support/v18/scanner/ScanResult;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (result);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScanResult_Lcom_vivalnk_android_support_v18_scanner_ScanResult_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScanResult", "(Lcom/vivalnk/android/support/v18/scanner/ScanResult;)V"), __args);
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

			static IntPtr id_onStart;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']/method[@name='onStart' and count(parameter)=0]"
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

			static IntPtr id_onStop;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager.ScanEventPoster']/method[@name='onStop' and count(parameter)=0]"
			[Register ("onStop", "()V", "GetOnStopHandler")]
			public virtual unsafe void OnStop ()
			{
				if (id_onStop == IntPtr.Zero)
					id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStop);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStop", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/scan/BleScanManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleScanManager); }
		}

		protected BleScanManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/constructor[@name='BleScanManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BleScanManager (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (BleScanManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
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

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/method[@name='destroy' and count(parameter)=0]"
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

		static IntPtr id_handleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
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

		static IntPtr id_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/method[@name='onBluetoothStateChange' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.event.BluetoothStateEvent']]"
		[Register ("onBluetoothStateChange", "(Lcom/vivalnk/sdk/common/ble/connect/event/BluetoothStateEvent;)V", "GetOnBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_Handler")]
		public virtual unsafe void OnBluetoothStateChange (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.BluetoothStateEvent e)
		{
			if (id_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_ == IntPtr.Zero)
				id_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_ = JNIEnv.GetMethodID (class_ref, "onBluetoothStateChange", "(Lcom/vivalnk/sdk/common/ble/connect/event/BluetoothStateEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBluetoothStateChange", "(Lcom/vivalnk/sdk/common/ble/connect/event/BluetoothStateEvent;)V"), __args);
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

		static IntPtr id_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/method[@name='startScan' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.scan.ScanOptions'] and parameter[2][@type='com.vivalnk.sdk.common.ble.scan.BleScanListener']]"
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

		static IntPtr id_stopScanning;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/class[@name='BleScanManager']/method[@name='stopScanning' and count(parameter)=0]"
		[Register ("stopScanning", "()V", "GetStopScanningHandler")]
		public virtual unsafe void StopScanning ()
		{
			if (id_stopScanning == IntPtr.Zero)
				id_stopScanning = JNIEnv.GetMethodID (class_ref, "stopScanning", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopScanning);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopScanning", "()V"));
			} finally {
			}
		}

	}
}
