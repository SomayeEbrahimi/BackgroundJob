using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Scan {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/interface[@name='IScanOperation']"
	[Register ("com/vivalnk/sdk/common/ble/scan/IScanOperation", "", "Com.Vivalnk.Sdk.Common.Ble.Scan.IScanOperationInvoker")]
	public partial interface IScanOperation : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/interface[@name='IScanOperation']/method[@name='startScan' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.scan.ScanOptions'] and parameter[2][@type='com.vivalnk.sdk.common.ble.scan.BleScanListener']]"
		[Register ("startScan", "(Lcom/vivalnk/sdk/common/ble/scan/ScanOptions;Lcom/vivalnk/sdk/common/ble/scan/BleScanListener;)V", "GetStartScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_Handler:Com.Vivalnk.Sdk.Common.Ble.Scan.IScanOperationInvoker, AndriodBinding")]
		void StartScan (global::Com.Vivalnk.Sdk.Common.Ble.Scan.ScanOptions p0, global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.scan']/interface[@name='IScanOperation']/method[@name='stopScanning' and count(parameter)=0]"
		[Register ("stopScanning", "()V", "GetStopScanningHandler:Com.Vivalnk.Sdk.Common.Ble.Scan.IScanOperationInvoker, AndriodBinding")]
		void StopScanning ();

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/scan/IScanOperation", DoNotGenerateAcw=true)]
	internal partial class IScanOperationInvoker : global::Java.Lang.Object, IScanOperation {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/scan/IScanOperation");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IScanOperationInvoker); }
		}

		IntPtr class_ref;

		public static IScanOperation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScanOperation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.scan.IScanOperation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScanOperationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_;
#pragma warning disable 0169
		static Delegate GetStartScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_Handler ()
		{
			if (cb_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_ == null)
				cb_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_);
			return cb_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_;
		}

		static void n_StartScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.IScanOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.ScanOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartScan (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_;
		public unsafe void StartScan (global::Com.Vivalnk.Sdk.Common.Ble.Scan.ScanOptions p0, global::Com.Vivalnk.Sdk.Common.Ble.Scan.IBleScanListener p1)
		{
			if (id_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_ == IntPtr.Zero)
				id_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_ = JNIEnv.GetMethodID (class_ref, "startScan", "(Lcom/vivalnk/sdk/common/ble/scan/ScanOptions;Lcom/vivalnk/sdk/common/ble/scan/BleScanListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startScan_Lcom_vivalnk_sdk_common_ble_scan_ScanOptions_Lcom_vivalnk_sdk_common_ble_scan_BleScanListener_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Scan.IScanOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopScanning ();
		}
#pragma warning restore 0169

		IntPtr id_stopScanning;
		public unsafe void StopScanning ()
		{
			if (id_stopScanning == IntPtr.Zero)
				id_stopScanning = JNIEnv.GetMethodID (class_ref, "stopScanning", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopScanning);
		}

	}

}
