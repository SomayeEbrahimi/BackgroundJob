using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BleRuntimeChecker", DoNotGenerateAcw=true)]
	public partial class BleRuntimeChecker : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='BLUETOOTH_NOT_AVAILABLE']"
		[Register ("BLUETOOTH_NOT_AVAILABLE")]
		public static int BluetoothNotAvailable {
			get {
				const string __id = "BLUETOOTH_NOT_AVAILABLE.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "BLUETOOTH_NOT_AVAILABLE.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='BLUETOOTH_NOT_ENABLED']"
		[Register ("BLUETOOTH_NOT_ENABLED")]
		public static int BluetoothNotEnabled {
			get {
				const string __id = "BLUETOOTH_NOT_ENABLED.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "BLUETOOTH_NOT_ENABLED.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='CHECK_RESULT_OK']"
		[Register ("CHECK_RESULT_OK")]
		public static int CheckResultOk {
			get {
				const string __id = "CHECK_RESULT_OK.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "CHECK_RESULT_OK.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='NOT_SUPPORT_BLE']"
		[Register ("NOT_SUPPORT_BLE")]
		public static int NotSupportBle {
			get {
				const string __id = "NOT_SUPPORT_BLE.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "NOT_SUPPORT_BLE.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='NO_BLUETOOTH_ADMIN_PERMISSION']"
		[Register ("NO_BLUETOOTH_ADMIN_PERMISSION")]
		public static int NoBluetoothAdminPermission {
			get {
				const string __id = "NO_BLUETOOTH_ADMIN_PERMISSION.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "NO_BLUETOOTH_ADMIN_PERMISSION.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='NO_BLUETOOTH_PERMISSION']"
		[Register ("NO_BLUETOOTH_PERMISSION")]
		public static int NoBluetoothPermission {
			get {
				const string __id = "NO_BLUETOOTH_PERMISSION.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "NO_BLUETOOTH_PERMISSION.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='SDCARD_NOT_AVAILABLE']"
		[Register ("SDCARD_NOT_AVAILABLE")]
		public static int SdcardNotAvailable {
			get {
				const string __id = "SDCARD_NOT_AVAILABLE.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "SDCARD_NOT_AVAILABLE.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/BleRuntimeChecker", typeof (BleRuntimeChecker));
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

		protected BleRuntimeChecker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/constructor[@name='BleRuntimeChecker' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BleRuntimeChecker (global::Android.Content.Context context)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='checkBleRuntime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkBleRuntime", "(Landroid/content/Context;)I", "")]
		public static unsafe int CheckBleRuntime (global::Android.Content.Context context)
		{
			const string __id = "checkBleRuntime.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkRuntime_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCheckRuntime_Landroid_content_Context_Handler ()
		{
			if (cb_checkRuntime_Landroid_content_Context_ == null)
				cb_checkRuntime_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CheckRuntime_Landroid_content_Context_);
			return cb_checkRuntime_Landroid_content_Context_;
		}

		static int n_CheckRuntime_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mContext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleRuntimeChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_mContext, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckRuntime (mContext);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='checkRuntime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkRuntime", "(Landroid/content/Context;)I", "GetCheckRuntime_Landroid_content_Context_Handler")]
		public virtual unsafe int CheckRuntime (global::Android.Content.Context mContext)
		{
			const string __id = "checkRuntime.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mContext).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='hasBluetoothAdminPermission' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasBluetoothAdminPermission", "(I)Z", "")]
		public static unsafe bool HasBluetoothAdminPermission (int code)
		{
			const string __id = "hasBluetoothAdminPermission.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='hasBluetoothPermission' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasBluetoothPermission", "(I)Z", "")]
		public static unsafe bool HasBluetoothPermission (int code)
		{
			const string __id = "hasBluetoothPermission.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='isBluetoothAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isBluetoothAvailable", "(I)Z", "")]
		public static unsafe bool IsBluetoothAvailable (int code)
		{
			const string __id = "isBluetoothAvailable.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='isBluetoothEnable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isBluetoothEnable", "(I)Z", "")]
		public static unsafe bool IsBluetoothEnable (int code)
		{
			const string __id = "isBluetoothEnable.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='isSDCardAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSDCardAvailable", "(I)Z", "")]
		public static unsafe bool IsSDCardAvailable (int code)
		{
			const string __id = "isSDCardAvailable.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='isSupportBLE' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSupportBLE", "(I)Z", "")]
		public static unsafe bool IsSupportBLE (int code)
		{
			const string __id = "isSupportBLE.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
