using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Android.Support.V18.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='BluetoothLeScannerCompat']"
	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/BluetoothLeScannerCompat", DoNotGenerateAcw=true)]
	public abstract partial class BluetoothLeScannerCompat : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/android/support/v18/scanner/BluetoothLeScannerCompat", typeof (BluetoothLeScannerCompat));
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

		protected BluetoothLeScannerCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.BluetoothLeScannerCompat Scanner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='BluetoothLeScannerCompat']/method[@name='getScanner' and count(parameter)=0]"
			[Register ("getScanner", "()Lcom/vivalnk/android/support/v18/scanner/BluetoothLeScannerCompat;", "")]
			get {
				const string __id = "getScanner.()Lcom/vivalnk/android/support/v18/scanner/BluetoothLeScannerCompat;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.BluetoothLeScannerCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_flushPendingScanResults_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_;
#pragma warning disable 0169
		static Delegate GetFlushPendingScanResults_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_Handler ()
		{
			if (cb_flushPendingScanResults_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ == null)
				cb_flushPendingScanResults_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FlushPendingScanResults_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_);
			return cb_flushPendingScanResults_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_;
		}

		static void n_FlushPendingScanResults_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.BluetoothLeScannerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FlushPendingScanResults (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='BluetoothLeScannerCompat']/method[@name='flushPendingScanResults' and count(parameter)=1 and parameter[1][@type='com.vivalnk.android.support.v18.scanner.ScanCallback']]"
		[Register ("flushPendingScanResults", "(Lcom/vivalnk/android/support/v18/scanner/ScanCallback;)V", "GetFlushPendingScanResults_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_Handler")]
		public abstract void FlushPendingScanResults (global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback p0);

		static Delegate cb_startScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_;
#pragma warning disable 0169
		static Delegate GetStartScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_Handler ()
		{
			if (cb_startScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ == null)
				cb_startScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StartScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_);
			return cb_startScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_;
		}

		static void n_StartScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.BluetoothLeScannerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.StartScan (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='BluetoothLeScannerCompat']/method[@name='startScan' and count(parameter)=1 and parameter[1][@type='com.vivalnk.android.support.v18.scanner.ScanCallback']]"
		[Register ("startScan", "(Lcom/vivalnk/android/support/v18/scanner/ScanCallback;)V", "GetStartScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_Handler")]
		public virtual unsafe void StartScan (global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback @callback)
		{
			const string __id = "startScan.(Lcom/vivalnk/android/support/v18/scanner/ScanCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startScan_Ljava_util_List_Lcom_vivalnk_android_support_v18_scanner_ScanSettings_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_;
#pragma warning disable 0169
		static Delegate GetStartScan_Ljava_util_List_Lcom_vivalnk_android_support_v18_scanner_ScanSettings_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_Handler ()
		{
			if (cb_startScan_Ljava_util_List_Lcom_vivalnk_android_support_v18_scanner_ScanSettings_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ == null)
				cb_startScan_Ljava_util_List_Lcom_vivalnk_android_support_v18_scanner_ScanSettings_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_StartScan_Ljava_util_List_Lcom_vivalnk_android_support_v18_scanner_ScanSettings_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_);
			return cb_startScan_Ljava_util_List_Lcom_vivalnk_android_support_v18_scanner_ScanSettings_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_;
		}

		static void n_StartScan_Ljava_util_List_Lcom_vivalnk_android_support_v18_scanner_ScanSettings_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filters, IntPtr native_settings, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.BluetoothLeScannerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filters = global::Android.Runtime.JavaList<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter>.FromJniHandle (native_filters, JniHandleOwnership.DoNotTransfer);
			var settings = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings> (native_settings, JniHandleOwnership.DoNotTransfer);
			var @callback = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.StartScan (filters, settings, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='BluetoothLeScannerCompat']/method[@name='startScan' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;com.vivalnk.android.support.v18.scanner.ScanFilter&gt;'] and parameter[2][@type='com.vivalnk.android.support.v18.scanner.ScanSettings'] and parameter[3][@type='com.vivalnk.android.support.v18.scanner.ScanCallback']]"
		[Register ("startScan", "(Ljava/util/List;Lcom/vivalnk/android/support/v18/scanner/ScanSettings;Lcom/vivalnk/android/support/v18/scanner/ScanCallback;)V", "GetStartScan_Ljava_util_List_Lcom_vivalnk_android_support_v18_scanner_ScanSettings_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_Handler")]
		public virtual unsafe void StartScan (global::System.Collections.Generic.IList<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter> filters, global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings settings, global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback @callback)
		{
			const string __id = "startScan.(Ljava/util/List;Lcom/vivalnk/android/support/v18/scanner/ScanSettings;Lcom/vivalnk/android/support/v18/scanner/ScanCallback;)V";
			IntPtr native_filters = global::Android.Runtime.JavaList<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter>.ToLocalJniHandle (filters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_filters);
				__args [1] = new JniArgumentValue ((settings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) settings).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filters);
			}
		}

		static Delegate cb_stopScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_;
#pragma warning disable 0169
		static Delegate GetStopScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_Handler ()
		{
			if (cb_stopScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ == null)
				cb_stopScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_);
			return cb_stopScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_;
		}

		static void n_StopScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.BluetoothLeScannerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopScan (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='BluetoothLeScannerCompat']/method[@name='stopScan' and count(parameter)=1 and parameter[1][@type='com.vivalnk.android.support.v18.scanner.ScanCallback']]"
		[Register ("stopScan", "(Lcom/vivalnk/android/support/v18/scanner/ScanCallback;)V", "GetStopScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_Handler")]
		public abstract void StopScan (global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/BluetoothLeScannerCompat", DoNotGenerateAcw=true)]
	internal partial class BluetoothLeScannerCompatInvoker : BluetoothLeScannerCompat {

		public BluetoothLeScannerCompatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/android/support/v18/scanner/BluetoothLeScannerCompat", typeof (BluetoothLeScannerCompatInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='BluetoothLeScannerCompat']/method[@name='flushPendingScanResults' and count(parameter)=1 and parameter[1][@type='com.vivalnk.android.support.v18.scanner.ScanCallback']]"
		[Register ("flushPendingScanResults", "(Lcom/vivalnk/android/support/v18/scanner/ScanCallback;)V", "GetFlushPendingScanResults_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_Handler")]
		public override unsafe void FlushPendingScanResults (global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback p0)
		{
			const string __id = "flushPendingScanResults.(Lcom/vivalnk/android/support/v18/scanner/ScanCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='BluetoothLeScannerCompat']/method[@name='stopScan' and count(parameter)=1 and parameter[1][@type='com.vivalnk.android.support.v18.scanner.ScanCallback']]"
		[Register ("stopScan", "(Lcom/vivalnk/android/support/v18/scanner/ScanCallback;)V", "GetStopScan_Lcom_vivalnk_android_support_v18_scanner_ScanCallback_Handler")]
		public override unsafe void StopScan (global::Com.Vivalnk.Android.Support.V18.Scanner.ScanCallback p0)
		{
			const string __id = "stopScan.(Lcom/vivalnk/android/support/v18/scanner/ScanCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
