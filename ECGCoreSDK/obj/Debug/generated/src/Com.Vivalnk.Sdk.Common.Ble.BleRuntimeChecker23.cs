using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BleRuntimeChecker23", DoNotGenerateAcw=true)]
	public partial class BleRuntimeChecker23 : global::Com.Vivalnk.Sdk.Common.Ble.BleRuntimeChecker {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']/field[@name='LOCATION_NOT_ENABLED']"
		[Register ("LOCATION_NOT_ENABLED")]
		public static int LocationNotEnabled {
			get {
				const string __id = "LOCATION_NOT_ENABLED.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "LOCATION_NOT_ENABLED.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']/field[@name='NO_LOCATION_PERMISSION']"
		[Register ("NO_LOCATION_PERMISSION")]
		public static int NoLocationPermission {
			get {
				const string __id = "NO_LOCATION_PERMISSION.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "NO_LOCATION_PERMISSION.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/BleRuntimeChecker23", typeof (BleRuntimeChecker23));
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

		protected BleRuntimeChecker23 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']/constructor[@name='BleRuntimeChecker23' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BleRuntimeChecker23 (global::Android.Content.Context context)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']/method[@name='hasLocationPermission' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']/method[@name='isLocationEnable' and count(parameter)=1 and parameter[1][@type='int']]"
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

	}
}
