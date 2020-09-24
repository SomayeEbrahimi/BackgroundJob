using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Android.Support.V18.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']"
	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanCallback", DoNotGenerateAcw=true)]
	public abstract partial class ScanCallback : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']/field[@name='SCAN_FAILED_ALREADY_STARTED']"
		[Register ("SCAN_FAILED_ALREADY_STARTED")]
		public const int ScanFailedAlreadyStarted = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']/field[@name='SCAN_FAILED_APPLICATION_REGISTRATION_FAILED']"
		[Register ("SCAN_FAILED_APPLICATION_REGISTRATION_FAILED")]
		public const int ScanFailedApplicationRegistrationFailed = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']/field[@name='SCAN_FAILED_FEATURE_UNSUPPORTED']"
		[Register ("SCAN_FAILED_FEATURE_UNSUPPORTED")]
		public const int ScanFailedFeatureUnsupported = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']/field[@name='SCAN_FAILED_INTERNAL_ERROR']"
		[Register ("SCAN_FAILED_INTERNAL_ERROR")]
		public const int ScanFailedInternalError = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']/field[@name='SCAN_FAILED_OUT_OF_HARDWARE_RESOURCES']"
		[Register ("SCAN_FAILED_OUT_OF_HARDWARE_RESOURCES")]
		public const int ScanFailedOutOfHardwareResources = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']/field[@name='SCAN_FAILED_SCANNING_TOO_FREQUENTLY']"
		[Register ("SCAN_FAILED_SCANNING_TOO_FREQUENTLY")]
		public const int ScanFailedScanningTooFrequently = (int) 6;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/android/support/v18/scanner/ScanCallback", typeof (ScanCallback));
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

		protected ScanCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']/constructor[@name='ScanCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScanCallback ()
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

		static Delegate cb_onBatchScanResults_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnBatchScanResults_Ljava_util_List_Handler ()
		{
			if (cb_onBatchScanResults_Ljava_util_List_ == null)
				cb_onBatchScanResults_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnBatchScanResults_Ljava_util_List_);
			return cb_onBatchScanResults_Ljava_util_List_;
		}

		static void n_OnBatchScanResults_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_results)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var results = global::Android.Runtime.JavaList<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanResult>.FromJniHandle (native_results, JniHandleOwnership.DoNotTransfer);
			__this.OnBatchScanResults (results);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']/method[@name='onBatchScanResults' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.vivalnk.android.support.v18.scanner.ScanResult&gt;']]"
		[Register ("onBatchScanResults", "(Ljava/util/List;)V", "GetOnBatchScanResults_Ljava_util_List_Handler")]
		public virtual unsafe void OnBatchScanResults (global::System.Collections.Generic.IList<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanResult> results)
		{
			const string __id = "onBatchScanResults.(Ljava/util/List;)V";
			IntPtr native_results = global::Android.Runtime.JavaList<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanResult>.ToLocalJniHandle (results);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_results);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_results);
			}
		}

		static Delegate cb_onScanFailed_I;
#pragma warning disable 0169
		static Delegate GetOnScanFailed_IHandler ()
		{
			if (cb_onScanFailed_I == null)
				cb_onScanFailed_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnScanFailed_I);
			return cb_onScanFailed_I;
		}

		static void n_OnScanFailed_I (IntPtr jnienv, IntPtr native__this, int errorCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScanFailed (errorCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']/method[@name='onScanFailed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onScanFailed", "(I)V", "GetOnScanFailed_IHandler")]
		public virtual unsafe void OnScanFailed (int errorCode)
		{
			const string __id = "onScanFailed.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (errorCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onScanResult_ILcom_vivalnk_android_support_v18_scanner_ScanResult_;
#pragma warning disable 0169
		static Delegate GetOnScanResult_ILcom_vivalnk_android_support_v18_scanner_ScanResult_Handler ()
		{
			if (cb_onScanResult_ILcom_vivalnk_android_support_v18_scanner_ScanResult_ == null)
				cb_onScanResult_ILcom_vivalnk_android_support_v18_scanner_ScanResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnScanResult_ILcom_vivalnk_android_support_v18_scanner_ScanResult_);
			return cb_onScanResult_ILcom_vivalnk_android_support_v18_scanner_ScanResult_;
		}

		static void n_OnScanResult_ILcom_vivalnk_android_support_v18_scanner_ScanResult_ (IntPtr jnienv, IntPtr native__this, int callbackType, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var result = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnScanResult (callbackType, result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanCallback']/method[@name='onScanResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vivalnk.android.support.v18.scanner.ScanResult']]"
		[Register ("onScanResult", "(ILcom/vivalnk/android/support/v18/scanner/ScanResult;)V", "GetOnScanResult_ILcom_vivalnk_android_support_v18_scanner_ScanResult_Handler")]
		public virtual unsafe void OnScanResult (int callbackType, global::Com.Vivalnk.Android.Support.V18.Scanner.ScanResult result)
		{
			const string __id = "onScanResult.(ILcom/vivalnk/android/support/v18/scanner/ScanResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (callbackType);
				__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanCallback", DoNotGenerateAcw=true)]
	internal partial class ScanCallbackInvoker : ScanCallback {

		public ScanCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/android/support/v18/scanner/ScanCallback", typeof (ScanCallbackInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
