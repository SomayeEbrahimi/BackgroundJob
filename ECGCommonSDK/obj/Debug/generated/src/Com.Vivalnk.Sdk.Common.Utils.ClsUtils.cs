using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/ClsUtils", DoNotGenerateAcw=true)]
	public partial class ClsUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/ClsUtils", typeof (ClsUtils));
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

		protected ClsUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/constructor[@name='ClsUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClsUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='cancelBondProcess' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("cancelBondProcess", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z", "")]
		public static unsafe bool CancelBondProcess (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice device)
		{
			const string __id = "cancelBondProcess.(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((btClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) btClass).Handle);
				__args [1] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='cancelPairingUserInput' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("cancelPairingUserInput", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z", "")]
		public static unsafe bool CancelPairingUserInput (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice device)
		{
			const string __id = "cancelPairingUserInput.(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((btClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) btClass).Handle);
				__args [1] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='createBond' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("createBond", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z", "")]
		public static unsafe bool CreateBond (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice btDevice)
		{
			const string __id = "createBond.(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((btClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) btClass).Handle);
				__args [1] = new JniArgumentValue ((btDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) btDevice).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='printAllInform' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("printAllInform", "(Ljava/lang/Class;)V", "")]
		public static unsafe void PrintAllInform (global::Java.Lang.Class clsShow)
		{
			const string __id = "printAllInform.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clsShow == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clsShow).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='removeBond' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("removeBond", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z", "")]
		public static unsafe bool RemoveBond (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice btDevice)
		{
			const string __id = "removeBond.(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((btClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) btClass).Handle);
				__args [1] = new JniArgumentValue ((btDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) btDevice).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='setPairingConfirmation' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='android.bluetooth.BluetoothDevice'] and parameter[3][@type='boolean']]"
		[Register ("setPairingConfirmation", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;Z)V", "")]
		public static unsafe void SetPairingConfirmation (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice device, bool isConfirm)
		{
			const string __id = "setPairingConfirmation.(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((btClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) btClass).Handle);
				__args [1] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [2] = new JniArgumentValue (isConfirm);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='setPin' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;? extends android.bluetooth.BluetoothDevice&gt;'] and parameter[2][@type='android.bluetooth.BluetoothDevice'] and parameter[3][@type='java.lang.String']]"
		[Register ("setPin", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;Ljava/lang/String;)Z", "")]
		public static unsafe bool SetPin (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice btDevice, string str)
		{
			const string __id = "setPin.(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;Ljava/lang/String;)Z";
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((btClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) btClass).Handle);
				__args [1] = new JniArgumentValue ((btDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) btDevice).Handle);
				__args [2] = new JniArgumentValue (native_str);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

	}
}
