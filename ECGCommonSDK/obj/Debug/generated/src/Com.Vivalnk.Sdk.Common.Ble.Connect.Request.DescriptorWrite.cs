using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='DescriptorWrite']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/request/DescriptorWrite", DoNotGenerateAcw=true)]
	public partial class DescriptorWrite : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/interface[@name='DescriptorWrite.DescriptorWriteListener']"
		[Register ("com/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener", "", "Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite/IDescriptorWriteListenerInvoker")]
		public partial interface IDescriptorWriteListener : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/interface[@name='DescriptorWrite.DescriptorWriteListener']/method[@name='onComplete' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGattDescriptor'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("onComplete", "(Landroid/bluetooth/BluetoothGattDescriptor;I[B)V", "GetOnComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayBHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite/IDescriptorWriteListenerInvoker, ECGCommonSDK")]
			void OnComplete (global::Android.Bluetooth.BluetoothGattDescriptor p0, int p1, byte[] p2);

		}

		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener", DoNotGenerateAcw=true)]
		internal partial class IDescriptorWriteListenerInvoker : global::Java.Lang.Object, IDescriptorWriteListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener", typeof (IDescriptorWriteListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IDescriptorWriteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDescriptorWriteListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.connect.request.DescriptorWrite.DescriptorWriteListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDescriptorWriteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayB;
#pragma warning disable 0169
			static Delegate GetOnComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayBHandler ()
			{
				if (cb_onComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayB == null)
					cb_onComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayB);
				return cb_onComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayB;
			}

			static void n_OnComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnComplete (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayB;
			public unsafe void OnComplete (global::Android.Bluetooth.BluetoothGattDescriptor p0, int p1, byte[] p2)
			{
				if (id_onComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayB == IntPtr.Zero)
					id_onComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayB = JNIEnv.GetMethodID (class_ref, "onComplete", "(Landroid/bluetooth/BluetoothGattDescriptor;I[B)V");
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Landroid_bluetooth_BluetoothGattDescriptor_IarrayB, __args);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/request/DescriptorWrite", typeof (DescriptorWrite));
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

		protected DescriptorWrite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='DescriptorWrite']/constructor[@name='DescriptorWrite' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.base.IORequestOptions'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorWrite.DescriptorWriteListener'] and parameter[4][@type='java.util.UUID'] and parameter[5][@type='java.util.UUID'] and parameter[6][@type='java.util.UUID'] and parameter[7][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[B)V", "")]
		public unsafe DescriptorWrite (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions requestOptions, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener listener, global::Java.Util.UUID service, global::Java.Util.UUID character, global::Java.Util.UUID descriptor, byte[] value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((requestOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestOptions).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [4] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [5] = new JniArgumentValue ((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) descriptor).Handle);
				__args [6] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRequestName;
#pragma warning disable 0169
		static Delegate GetGetRequestNameHandler ()
		{
			if (cb_getRequestName == null)
				cb_getRequestName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestName);
			return cb_getRequestName;
		}

		static IntPtr n_GetRequestName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='DescriptorWrite']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")]
			get {
				const string __id = "getRequestName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_process;
#pragma warning disable 0169
		static Delegate GetProcessHandler ()
		{
			if (cb_process == null)
				cb_process = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Process);
			return cb_process;
		}

		static void n_Process (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Process ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='DescriptorWrite']/method[@name='process' and count(parameter)=0]"
		[Register ("process", "()V", "GetProcessHandler")]
		protected override unsafe void Process ()
		{
			const string __id = "process.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
