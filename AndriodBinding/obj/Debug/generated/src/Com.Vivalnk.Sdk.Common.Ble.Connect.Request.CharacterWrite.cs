using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='CharacterWrite']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/request/CharacterWrite", DoNotGenerateAcw=true)]
	public partial class CharacterWrite : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/interface[@name='CharacterWrite.CharacterWriteListener']"
		[Register ("com/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener", "", "Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite/ICharacterWriteListenerInvoker")]
		public partial interface ICharacterWriteListener : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/interface[@name='CharacterWrite.CharacterWriteListener']/method[@name='onComplete' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("onComplete", "(Landroid/bluetooth/BluetoothGattCharacteristic;I[B)V", "GetOnComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayBHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite/ICharacterWriteListenerInvoker, AndriodBinding")]
			void OnComplete (global::Android.Bluetooth.BluetoothGattCharacteristic p0, int p1, byte[] p2);

		}

		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener", DoNotGenerateAcw=true)]
		internal partial class ICharacterWriteListenerInvoker : global::Java.Lang.Object, ICharacterWriteListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICharacterWriteListenerInvoker); }
			}

			IntPtr class_ref;

			public static ICharacterWriteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICharacterWriteListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.connect.request.CharacterWrite.CharacterWriteListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICharacterWriteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayB;
#pragma warning disable 0169
			static Delegate GetOnComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayBHandler ()
			{
				if (cb_onComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayB == null)
					cb_onComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayB);
				return cb_onComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayB;
			}

			static void n_OnComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnComplete (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayB;
			public unsafe void OnComplete (global::Android.Bluetooth.BluetoothGattCharacteristic p0, int p1, byte[] p2)
			{
				if (id_onComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayB == IntPtr.Zero)
					id_onComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayB = JNIEnv.GetMethodID (class_ref, "onComplete", "(Landroid/bluetooth/BluetoothGattCharacteristic;I[B)V");
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Landroid_bluetooth_BluetoothGattCharacteristic_IarrayB, __args);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/request/CharacterWrite", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharacterWrite); }
		}

		protected CharacterWrite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Ljava_util_UUID_Ljava_util_UUID_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='CharacterWrite']/constructor[@name='CharacterWrite' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.base.IORequestOptions'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.CharacterWrite.CharacterWriteListener'] and parameter[4][@type='java.util.UUID'] and parameter[5][@type='java.util.UUID'] and parameter[6][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Ljava/util/UUID;Ljava/util/UUID;[B)V", "")]
		public unsafe CharacterWrite (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions requestOptions, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite.ICharacterWriteListener listener, global::Java.Util.UUID service, global::Java.Util.UUID character, byte[] value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (requestOptions);
				__args [2] = new JValue (listener);
				__args [3] = new JValue (service);
				__args [4] = new JValue (character);
				__args [5] = new JValue (native_value);
				if (((object) this).GetType () != typeof (CharacterWrite)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Ljava/util/UUID;Ljava/util/UUID;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Ljava/util/UUID;Ljava/util/UUID;[B)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Ljava_util_UUID_Ljava_util_UUID_arrayB == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Ljava_util_UUID_Ljava_util_UUID_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/CharacterWrite$CharacterWriteListener;Ljava/util/UUID;Ljava/util/UUID;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Ljava_util_UUID_Ljava_util_UUID_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_CharacterWrite_CharacterWriteListener_Ljava_util_UUID_Ljava_util_UUID_arrayB, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='CharacterWrite']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")]
			get {
				if (id_getRequestName == IntPtr.Zero)
					id_getRequestName = JNIEnv.GetMethodID (class_ref, "getRequestName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.CharacterWrite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Process ();
		}
#pragma warning restore 0169

		static IntPtr id_process;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='CharacterWrite']/method[@name='process' and count(parameter)=0]"
		[Register ("process", "()V", "GetProcessHandler")]
		public override unsafe void Process ()
		{
			if (id_process == IntPtr.Zero)
				id_process = JNIEnv.GetMethodID (class_ref, "process", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "()V"));
			} finally {
			}
		}

	}
}
