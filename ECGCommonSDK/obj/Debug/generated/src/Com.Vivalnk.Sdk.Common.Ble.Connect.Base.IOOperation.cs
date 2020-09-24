using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IOOperation']"
	[Register ("com/vivalnk/sdk/common/ble/connect/base/IOOperation", "", "Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperationInvoker")]
	public partial interface IOOperation : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IOOperation']/method[@name='discoverService' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.request.DiscoverService.DiscoverServiceListener'] and parameter[2][@type='boolean']]"
		[Register ("discoverService", "(Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;Z)V", "GetDiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ZHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperationInvoker, ECGCommonSDK")]
		void DiscoverService (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IOOperation']/method[@name='readCharacteristic' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterRead.CharacterReadListener'] and parameter[4][@type='boolean']]"
		[Register ("readCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V", "GetReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_ZHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperationInvoker, ECGCommonSDK")]
		void ReadCharacteristic (global::Java.Util.UUID p0, global::Java.Util.UUID p1, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IOOperation']/method[@name='readDescriptor' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorRead.DescriptorReadListener'] and parameter[5][@type='boolean']]"
		[Register ("readDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V", "GetReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_ZHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperationInvoker, ECGCommonSDK")]
		void ReadDescriptor (global::Java.Util.UUID p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener p3, bool p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IOOperation']/method[@name='readRemoteRssi' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.request.ReadRemoteRssi.ReadRssiListener'] and parameter[2][@type='boolean']]"
		[Register ("readRemoteRssi", "(Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V", "GetReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_ZHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperationInvoker, ECGCommonSDK")]
		void ReadRemoteRssi (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IOOperation']/method[@name='requestMtu' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.request.MtuRequest.MtuListener'] and parameter[3][@type='boolean']]"
		[Register ("requestMtu", "(ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V", "GetRequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_ZHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperationInvoker, ECGCommonSDK")]
		void RequestMtu (int p0, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IOOperation']/method[@name='setCharacteristicIndication' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='boolean'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener'] and parameter[5][@type='boolean']]"
		[Register ("setCharacteristicIndication", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V", "GetSetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperationInvoker, ECGCommonSDK")]
		void SetCharacteristicIndication (global::Java.Util.UUID p0, global::Java.Util.UUID p1, bool p2, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener p3, bool p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IOOperation']/method[@name='setCharacteristicNotification' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='boolean'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.NotifyRequest.NotifyChangeListener'] and parameter[5][@type='boolean']]"
		[Register ("setCharacteristicNotification", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V", "GetSetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperationInvoker, ECGCommonSDK")]
		void SetCharacteristicNotification (global::Java.Util.UUID p0, global::Java.Util.UUID p1, bool p2, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener p3, bool p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IOOperation']/method[@name='writeCharacteristic' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWrite.CharacterWriteListener'] and parameter[5][@type='boolean']]"
		[Register ("writeCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V", "GetWriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperationInvoker, ECGCommonSDK")]
		void WriteCharacteristic (global::Java.Util.UUID p0, global::Java.Util.UUID p1, byte[] p2, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener p3, bool p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/interface[@name='IOOperation']/method[@name='writeDescriptor' and count(parameter)=6 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorWrite.DescriptorWriteListener'] and parameter[6][@type='boolean']]"
		[Register ("writeDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V", "GetWriteDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_ZHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperationInvoker, ECGCommonSDK")]
		void WriteDescriptor (global::Java.Util.UUID p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2, byte[] p3, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener p4, bool p5);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/base/IOOperation", DoNotGenerateAcw=true)]
	internal partial class IOOperationInvoker : global::Java.Lang.Object, IOOperation {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/base/IOOperation", typeof (IOOperationInvoker));

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

		public static IOOperation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOOperation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.connect.base.IOOperation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOOperationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z;
#pragma warning disable 0169
		static Delegate GetDiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ZHandler ()
		{
			if (cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z == null)
				cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_DiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z);
			return cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z;
		}

		static void n_DiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DiscoverService (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z;
		public unsafe void DiscoverService (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener p0, bool p1)
		{
			if (id_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z == IntPtr.Zero)
				id_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z = JNIEnv.GetMethodID (class_ref, "discoverService", "(Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z, __args);
		}

		static Delegate cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
#pragma warning disable 0169
		static Delegate GetReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_ZHandler ()
		{
			if (cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z == null)
				cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_ReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z);
			return cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
		}

		static void n_ReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ReadCharacteristic (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
		public unsafe void ReadCharacteristic (global::Java.Util.UUID p0, global::Java.Util.UUID p1, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener p2, bool p3)
		{
			if (id_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z == IntPtr.Zero)
				id_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z = JNIEnv.GetMethodID (class_ref, "readCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z, __args);
		}

		static Delegate cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
#pragma warning disable 0169
		static Delegate GetReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_ZHandler ()
		{
			if (cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z == null)
				cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_ReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z);
			return cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
		}

		static void n_ReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, bool p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ReadDescriptor (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
		public unsafe void ReadDescriptor (global::Java.Util.UUID p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener p3, bool p4)
		{
			if (id_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z == IntPtr.Zero)
				id_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z = JNIEnv.GetMethodID (class_ref, "readDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z, __args);
		}

		static Delegate cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
#pragma warning disable 0169
		static Delegate GetReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_ZHandler ()
		{
			if (cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z == null)
				cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_ReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z);
			return cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
		}

		static void n_ReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadRemoteRssi (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
		public unsafe void ReadRemoteRssi (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener p0, bool p1)
		{
			if (id_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z == IntPtr.Zero)
				id_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z = JNIEnv.GetMethodID (class_ref, "readRemoteRssi", "(Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z, __args);
		}

		static Delegate cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
#pragma warning disable 0169
		static Delegate GetRequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_ZHandler ()
		{
			if (cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z == null)
				cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILZ_V) n_RequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z);
			return cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
		}

		static void n_RequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RequestMtu (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
		public unsafe void RequestMtu (int p0, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener p1, bool p2)
		{
			if (id_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z == IntPtr.Zero)
				id_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z = JNIEnv.GetMethodID (class_ref, "requestMtu", "(ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z, __args);
		}

		static Delegate cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
#pragma warning disable 0169
		static Delegate GetSetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler ()
		{
			if (cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z == null)
				cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZLZ_V) n_SetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z);
			return cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
		}

		static void n_SetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, IntPtr native_p3, bool p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetCharacteristicIndication (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
		public unsafe void SetCharacteristicIndication (global::Java.Util.UUID p0, global::Java.Util.UUID p1, bool p2, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener p3, bool p4)
		{
			if (id_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z == IntPtr.Zero)
				id_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z = JNIEnv.GetMethodID (class_ref, "setCharacteristicIndication", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z, __args);
		}

		static Delegate cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
#pragma warning disable 0169
		static Delegate GetSetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler ()
		{
			if (cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == null)
				cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZLZ_V) n_SetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z);
			return cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		}

		static void n_SetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, IntPtr native_p3, bool p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetCharacteristicNotification (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		public unsafe void SetCharacteristicNotification (global::Java.Util.UUID p0, global::Java.Util.UUID p1, bool p2, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener p3, bool p4)
		{
			if (id_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == IntPtr.Zero)
				id_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNIEnv.GetMethodID (class_ref, "setCharacteristicNotification", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z, __args);
		}

		static Delegate cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
#pragma warning disable 0169
		static Delegate GetWriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler ()
		{
			if (cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z == null)
				cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_WriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z);
			return cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
		}

		static void n_WriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, bool p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.WriteCharacteristic (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
		public unsafe void WriteCharacteristic (global::Java.Util.UUID p0, global::Java.Util.UUID p1, byte[] p2, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener p3, bool p4)
		{
			if (id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z == IntPtr.Zero)
				id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z = JNIEnv.GetMethodID (class_ref, "writeCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z;
#pragma warning disable 0169
		static Delegate GetWriteDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_ZHandler ()
		{
			if (cb_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z == null)
				cb_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLZ_V) n_WriteDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z);
			return cb_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z;
		}

		static void n_WriteDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.WriteDescriptor (p0, p1, p2, p3, p4, p5);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z;
		public unsafe void WriteDescriptor (global::Java.Util.UUID p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2, byte[] p3, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener p4, bool p5)
		{
			if (id_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z == IntPtr.Zero)
				id_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z = JNIEnv.GetMethodID (class_ref, "writeDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}

}
