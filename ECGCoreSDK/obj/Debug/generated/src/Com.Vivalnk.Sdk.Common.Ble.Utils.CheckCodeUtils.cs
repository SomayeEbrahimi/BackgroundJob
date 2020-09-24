using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/utils/CheckCodeUtils", DoNotGenerateAcw=true)]
	public partial class CheckCodeUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/utils/CheckCodeUtils", typeof (CheckCodeUtils));
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

		protected CheckCodeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/constructor[@name='CheckCodeUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CheckCodeUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='hasBluetoothAdminPermission' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='hasBluetoothPermission' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='hasLocationPermission' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasLocationPermission", "(I)Z", "")]
		public static unsafe bool HasLocationPermission (int code)
		{
			const string __id = "hasLocationPermission.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='hasSDCardPermission' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasSDCardPermission", "(I)Z", "")]
		public static unsafe bool HasSDCardPermission (int code)
		{
			const string __id = "hasSDCardPermission.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='isBluetoothAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='isBluetoothEnable' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='isLocationEnable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLocationEnable", "(I)Z", "")]
		public static unsafe bool IsLocationEnable (int code)
		{
			const string __id = "isLocationEnable.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='isSDCardAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='isSupportBLE' and count(parameter)=1 and parameter[1][@type='int']]"
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
