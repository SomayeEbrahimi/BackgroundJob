using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='CharacteristicChangedEvent']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/event/CharacteristicChangedEvent", DoNotGenerateAcw=true)]
	public partial class CharacteristicChangedEvent : global::Java.Lang.Object {


		static IntPtr characteristic_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='CharacteristicChangedEvent']/field[@name='characteristic']"
		[Register ("characteristic")]
		public global::Android.Bluetooth.BluetoothGattCharacteristic Characteristic {
			get {
				if (characteristic_jfieldId == IntPtr.Zero)
					characteristic_jfieldId = JNIEnv.GetFieldID (class_ref, "characteristic", "Landroid/bluetooth/BluetoothGattCharacteristic;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, characteristic_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (characteristic_jfieldId == IntPtr.Zero)
					characteristic_jfieldId = JNIEnv.GetFieldID (class_ref, "characteristic", "Landroid/bluetooth/BluetoothGattCharacteristic;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, characteristic_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='CharacteristicChangedEvent']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr device_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='CharacteristicChangedEvent']/field[@name='device']"
		[Register ("device")]
		public global::Android.Bluetooth.BluetoothDevice Device {
			get {
				if (device_jfieldId == IntPtr.Zero)
					device_jfieldId = JNIEnv.GetFieldID (class_ref, "device", "Landroid/bluetooth/BluetoothDevice;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, device_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (device_jfieldId == IntPtr.Zero)
					device_jfieldId = JNIEnv.GetFieldID (class_ref, "device", "Landroid/bluetooth/BluetoothDevice;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, device_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/event/CharacteristicChangedEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharacteristicChangedEvent); }
		}

		protected CharacteristicChangedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='CharacteristicChangedEvent']/constructor[@name='CharacteristicChangedEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CharacteristicChangedEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CharacteristicChangedEvent)) {
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

	}
}
