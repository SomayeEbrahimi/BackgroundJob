using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/base/AbsDefaulRequest", DoNotGenerateAcw=true)]
	public partial class AbsDefaulRequest : global::Android.Bluetooth.BluetoothGattCallback, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IOOperation {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/base/AbsDefaulRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbsDefaulRequest); }
		}

		protected AbsDefaulRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/constructor[@name='AbsDefaulRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbsDefaulRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AbsDefaulRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z;
#pragma warning disable 0169
		static Delegate GetDiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ZHandler ()
		{
			if (cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z == null)
				cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_DiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z);
			return cb_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z;
		}

		static void n_DiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DiscoverService (listener, loggable);
		}
#pragma warning restore 0169

		static IntPtr id_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/method[@name='discoverService' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.request.DiscoverService.DiscoverServiceListener'] and parameter[2][@type='boolean']]"
		[Register ("discoverService", "(Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;Z)V", "GetDiscoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ZHandler")]
		public virtual unsafe void DiscoverService (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener listener, bool loggable)
		{
			if (id_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z == IntPtr.Zero)
				id_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z = JNIEnv.GetMethodID (class_ref, "discoverService", "(Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (listener);
				__args [1] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_discoverService_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "discoverService", "(Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
#pragma warning disable 0169
		static Delegate GetReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_ZHandler ()
		{
			if (cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z == null)
				cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_ReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z);
			return cb_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
		}

		static void n_ReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadCharacteristic (service, character, listener, loggable);
		}
#pragma warning restore 0169

		static IntPtr id_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/method[@name='readCharacteristic' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterRead.CharacterReadListener'] and parameter[4][@type='boolean']]"
		[Register ("readCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V", "GetReadCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_ZHandler")]
		public virtual unsafe void ReadCharacteristic (global::Java.Util.UUID service, global::Java.Util.UUID character, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterRead.ICharacterReadListener listener, bool loggable)
		{
			if (id_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z == IntPtr.Zero)
				id_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z = JNIEnv.GetMethodID (class_ref, "readCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (service);
				__args [1] = new JValue (character);
				__args [2] = new JValue (listener);
				__args [3] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readCharacteristic_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterRead_CharacterReadListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterRead$CharacterReadListener;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
#pragma warning disable 0169
		static Delegate GetReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_ZHandler ()
		{
			if (cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z == null)
				cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_ReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z);
			return cb_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
		}

		static void n_ReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_descriptor, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var descriptor = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_descriptor, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadDescriptor (service, character, descriptor, listener, loggable);
		}
#pragma warning restore 0169

		static IntPtr id_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/method[@name='readDescriptor' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorRead.DescriptorReadListener'] and parameter[5][@type='boolean']]"
		[Register ("readDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V", "GetReadDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_ZHandler")]
		public virtual unsafe void ReadDescriptor (global::Java.Util.UUID service, global::Java.Util.UUID character, global::Java.Util.UUID descriptor, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorRead.IDescriptorReadListener listener, bool loggable)
		{
			if (id_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z == IntPtr.Zero)
				id_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z = JNIEnv.GetMethodID (class_ref, "readDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (service);
				__args [1] = new JValue (character);
				__args [2] = new JValue (descriptor);
				__args [3] = new JValue (listener);
				__args [4] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_Lcom_vivalnk_sdk_common_ble_connect_request_DescriptorRead_DescriptorReadListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;Lcom/vivalnk/sdk/common/ble/connect/request/DescriptorRead$DescriptorReadListener;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
#pragma warning disable 0169
		static Delegate GetReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_ZHandler ()
		{
			if (cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z == null)
				cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_ReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z);
			return cb_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
		}

		static void n_ReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mReadRssiListener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mReadRssiListener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener> (native_mReadRssiListener, JniHandleOwnership.DoNotTransfer);
			__this.ReadRemoteRssi (mReadRssiListener, loggable);
		}
#pragma warning restore 0169

		static IntPtr id_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/method[@name='readRemoteRssi' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.request.ReadRemoteRssi.ReadRssiListener'] and parameter[2][@type='boolean']]"
		[Register ("readRemoteRssi", "(Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V", "GetReadRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_ZHandler")]
		public virtual unsafe void ReadRemoteRssi (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.ReadRemoteRssi.IReadRssiListener mReadRssiListener, bool loggable)
		{
			if (id_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z == IntPtr.Zero)
				id_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z = JNIEnv.GetMethodID (class_ref, "readRemoteRssi", "(Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mReadRssiListener);
				__args [1] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readRemoteRssi_Lcom_vivalnk_sdk_common_ble_connect_request_ReadRemoteRssi_ReadRssiListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readRemoteRssi", "(Lcom/vivalnk/sdk/common/ble/connect/request/ReadRemoteRssi$ReadRssiListener;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
#pragma warning disable 0169
		static Delegate GetRequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_ZHandler ()
		{
			if (cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z == null)
				cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILZ_V) n_RequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z);
			return cb_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
		}

		static void n_RequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z (IntPtr jnienv, IntPtr native__this, int mtu, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RequestMtu (mtu, listener, loggable);
		}
#pragma warning restore 0169

		static IntPtr id_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/method[@name='requestMtu' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.request.MtuRequest.MtuListener'] and parameter[3][@type='boolean']]"
		[Register ("requestMtu", "(ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V", "GetRequestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_ZHandler")]
		public virtual unsafe void RequestMtu (int mtu, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener listener, bool loggable)
		{
			if (id_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z == IntPtr.Zero)
				id_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z = JNIEnv.GetMethodID (class_ref, "requestMtu", "(ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (mtu);
				__args [1] = new JValue (listener);
				__args [2] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestMtu_ILcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestMtu", "(ILcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
#pragma warning disable 0169
		static Delegate GetSetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler ()
		{
			if (cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z == null)
				cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZLZ_V) n_SetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z);
			return cb_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
		}

		static void n_SetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, bool enable, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetCharacteristicIndication (service, character, enable, listener, loggable);
		}
#pragma warning restore 0169

		static IntPtr id_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/method[@name='setCharacteristicIndication' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='boolean'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener'] and parameter[5][@type='boolean']]"
		[Register ("setCharacteristicIndication", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V", "GetSetCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_ZHandler")]
		public virtual unsafe void SetCharacteristicIndication (global::Java.Util.UUID service, global::Java.Util.UUID character, bool enable, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener listener, bool loggable)
		{
			if (id_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z == IntPtr.Zero)
				id_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z = JNIEnv.GetMethodID (class_ref, "setCharacteristicIndication", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (service);
				__args [1] = new JValue (character);
				__args [2] = new JValue (enable);
				__args [3] = new JValue (listener);
				__args [4] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCharacteristicIndication_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_IndicateRequest_IndicateListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCharacteristicIndication", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
#pragma warning disable 0169
		static Delegate GetSetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler ()
		{
			if (cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == null)
				cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZLZ_V) n_SetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z);
			return cb_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		}

		static void n_SetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, bool enable, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetCharacteristicNotification (service, character, enable, listener, loggable);
		}
#pragma warning restore 0169

		static IntPtr id_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/method[@name='setCharacteristicNotification' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='boolean'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.NotifyRequest.NotifyChangeListener'] and parameter[5][@type='boolean']]"
		[Register ("setCharacteristicNotification", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V", "GetSetCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_ZHandler")]
		public virtual unsafe void SetCharacteristicNotification (global::Java.Util.UUID service, global::Java.Util.UUID character, bool enable, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.NotifyRequest.INotifyChangeListener listener, bool loggable)
		{
			if (id_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z == IntPtr.Zero)
				id_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z = JNIEnv.GetMethodID (class_ref, "setCharacteristicNotification", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (service);
				__args [1] = new JValue (character);
				__args [2] = new JValue (enable);
				__args [3] = new JValue (listener);
				__args [4] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCharacteristicNotification_Ljava_util_UUID_Ljava_util_UUID_ZLcom_vivalnk_sdk_common_ble_connect_request_NotifyRequest_NotifyChangeListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCharacteristicNotification", "(Ljava/util/UUID;Ljava/util/UUID;ZLcom/vivalnk/sdk/common/ble/connect/request/NotifyRequest$NotifyChangeListener;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
#pragma warning disable 0169
		static Delegate GetWriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler ()
		{
			if (cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z == null)
				cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_WriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z);
			return cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
		}

		static void n_WriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_value, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.WriteCharacteristic (service, character, value, listener, loggable);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/method[@name='writeCharacteristic' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWrite.CharacterWriteListener'] and parameter[5][@type='boolean']]"
		[Register ("writeCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V", "GetWriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_ZHandler")]
		public virtual unsafe void WriteCharacteristic (global::Java.Util.UUID service, global::Java.Util.UUID character, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener listener, bool loggable)
		{
			if (id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z == IntPtr.Zero)
				id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z = JNIEnv.GetMethodID (class_ref, "writeCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (service);
				__args [1] = new JValue (character);
				__args [2] = new JValue (native_value);
				__args [3] = new JValue (listener);
				__args [4] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Z)V"), __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_writeCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z;
#pragma warning disable 0169
		static Delegate GetWriteCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_ZHandler ()
		{
			if (cb_writeCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z == null)
				cb_writeCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZ_V) n_WriteCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z);
			return cb_writeCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z;
		}

		static void n_WriteCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_value, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWriteReliable.ICharacterWriteReliableListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWriteReliable.ICharacterWriteReliableListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.WriteCharacteristicReliable (service, character, value, listener, loggable);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_writeCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/method[@name='writeCharacteristicReliable' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWriteReliable.CharacterWriteReliableListener'] and parameter[5][@type='boolean']]"
		[Register ("writeCharacteristicReliable", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWriteReliable$CharacterWriteReliableListener;Z)V", "GetWriteCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_ZHandler")]
		public virtual unsafe void WriteCharacteristicReliable (global::Java.Util.UUID service, global::Java.Util.UUID character, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWriteReliable.ICharacterWriteReliableListener listener, bool loggable)
		{
			if (id_writeCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z == IntPtr.Zero)
				id_writeCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z = JNIEnv.GetMethodID (class_ref, "writeCharacteristicReliable", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWriteReliable$CharacterWriteReliableListener;Z)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (service);
				__args [1] = new JValue (character);
				__args [2] = new JValue (native_value);
				__args [3] = new JValue (listener);
				__args [4] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeCharacteristicReliable_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_CharacterWriteReliable_CharacterWriteReliableListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeCharacteristicReliable", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/CharacterWriteReliable$CharacterWriteReliableListener;Z)V"), __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
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

		static void n_WriteDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character, IntPtr native_descriptor, IntPtr native_value, IntPtr native_listener, bool loggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.AbsDefaulRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			var descriptor = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_descriptor, JniHandleOwnership.DoNotTransfer);
			var value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.WriteDescriptor (service, character, descriptor, value, listener, loggable);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='AbsDefaulRequest']/method[@name='writeDescriptor' and count(parameter)=6 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.vivalnk.sdk.common.ble.connect.request.DescriptorWrite.DescriptorWriteListener'] and parameter[6][@type='boolean']]"
		[Register ("writeDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V", "GetWriteDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_ZHandler")]
		public virtual unsafe void WriteDescriptor (global::Java.Util.UUID service, global::Java.Util.UUID character, global::Java.Util.UUID descriptor, byte[] value, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DescriptorWrite.IDescriptorWriteListener listener, bool loggable)
		{
			if (id_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z == IntPtr.Zero)
				id_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z = JNIEnv.GetMethodID (class_ref, "writeDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (service);
				__args [1] = new JValue (character);
				__args [2] = new JValue (descriptor);
				__args [3] = new JValue (native_value);
				__args [4] = new JValue (listener);
				__args [5] = new JValue (loggable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeDescriptor_Ljava_util_UUID_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_vivalnk_sdk_common_ble_connect_request_DescriptorWrite_DescriptorWriteListener_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeDescriptor", "(Ljava/util/UUID;Ljava/util/UUID;Ljava/util/UUID;[BLcom/vivalnk/sdk/common/ble/connect/request/DescriptorWrite$DescriptorWriteListener;Z)V"), __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
