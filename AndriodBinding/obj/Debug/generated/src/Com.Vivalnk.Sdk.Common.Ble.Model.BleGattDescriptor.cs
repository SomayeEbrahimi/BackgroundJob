using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/model/BleGattDescriptor", DoNotGenerateAcw=true)]
	public partial class BleGattDescriptor : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/model/BleGattDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleGattDescriptor); }
		}

		protected BleGattDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_bluetooth_BluetoothGattDescriptor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/constructor[@name='BleGattDescriptor' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattDescriptor']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothGattDescriptor;)V", "")]
		public unsafe BleGattDescriptor (global::Android.Bluetooth.BluetoothGattDescriptor descriptor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (descriptor);
				if (((object) this).GetType () != typeof (BleGattDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/bluetooth/BluetoothGattDescriptor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/bluetooth/BluetoothGattDescriptor;)V", __args);
					return;
				}

				if (id_ctor_Landroid_bluetooth_BluetoothGattDescriptor_ == IntPtr.Zero)
					id_ctor_Landroid_bluetooth_BluetoothGattDescriptor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/bluetooth/BluetoothGattDescriptor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_bluetooth_BluetoothGattDescriptor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_bluetooth_BluetoothGattDescriptor_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/constructor[@name='BleGattDescriptor' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe BleGattDescriptor (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (BleGattDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getmPermissions;
#pragma warning disable 0169
		static Delegate GetGetmPermissionsHandler ()
		{
			if (cb_getmPermissions == null)
				cb_getmPermissions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetmPermissions);
			return cb_getmPermissions;
		}

		static int n_GetmPermissions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmPermissions ();
		}
#pragma warning restore 0169

		static IntPtr id_getmPermissions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='getmPermissions' and count(parameter)=0]"
		[Register ("getmPermissions", "()I", "GetGetmPermissionsHandler")]
		public virtual unsafe int GetmPermissions ()
		{
			if (id_getmPermissions == IntPtr.Zero)
				id_getmPermissions = JNIEnv.GetMethodID (class_ref, "getmPermissions", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getmPermissions);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmPermissions", "()I"));
			} finally {
			}
		}

		static Delegate cb_getmUuid;
#pragma warning disable 0169
		static Delegate GetGetmUuidHandler ()
		{
			if (cb_getmUuid == null)
				cb_getmUuid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetmUuid);
			return cb_getmUuid;
		}

		static IntPtr n_GetmUuid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetmUuid ());
		}
#pragma warning restore 0169

		static IntPtr id_getmUuid;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='getmUuid' and count(parameter)=0]"
		[Register ("getmUuid", "()Landroid/os/ParcelUuid;", "GetGetmUuidHandler")]
		public virtual unsafe global::Android.OS.ParcelUuid GetmUuid ()
		{
			if (id_getmUuid == IntPtr.Zero)
				id_getmUuid = JNIEnv.GetMethodID (class_ref, "getmUuid", "()Landroid/os/ParcelUuid;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getmUuid), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmUuid", "()Landroid/os/ParcelUuid;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getmValue;
#pragma warning disable 0169
		static Delegate GetGetmValueHandler ()
		{
			if (cb_getmValue == null)
				cb_getmValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetmValue);
			return cb_getmValue;
		}

		static IntPtr n_GetmValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetmValue ());
		}
#pragma warning restore 0169

		static IntPtr id_getmValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='getmValue' and count(parameter)=0]"
		[Register ("getmValue", "()[B", "GetGetmValueHandler")]
		public virtual unsafe byte[] GetmValue ()
		{
			if (id_getmValue == IntPtr.Zero)
				id_getmValue = JNIEnv.GetMethodID (class_ref, "getmValue", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getmValue), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmValue", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setmPermissions_I;
#pragma warning disable 0169
		static Delegate GetSetmPermissions_IHandler ()
		{
			if (cb_setmPermissions_I == null)
				cb_setmPermissions_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetmPermissions_I);
			return cb_setmPermissions_I;
		}

		static void n_SetmPermissions_I (IntPtr jnienv, IntPtr native__this, int mPermissions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmPermissions (mPermissions);
		}
#pragma warning restore 0169

		static IntPtr id_setmPermissions_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='setmPermissions' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmPermissions", "(I)V", "GetSetmPermissions_IHandler")]
		public virtual unsafe void SetmPermissions (int mPermissions)
		{
			if (id_setmPermissions_I == IntPtr.Zero)
				id_setmPermissions_I = JNIEnv.GetMethodID (class_ref, "setmPermissions", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mPermissions);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmPermissions_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmPermissions", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmUuid_Landroid_os_ParcelUuid_;
#pragma warning disable 0169
		static Delegate GetSetmUuid_Landroid_os_ParcelUuid_Handler ()
		{
			if (cb_setmUuid_Landroid_os_ParcelUuid_ == null)
				cb_setmUuid_Landroid_os_ParcelUuid_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetmUuid_Landroid_os_ParcelUuid_);
			return cb_setmUuid_Landroid_os_ParcelUuid_;
		}

		static void n_SetmUuid_Landroid_os_ParcelUuid_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mUuid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mUuid = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (native_mUuid, JniHandleOwnership.DoNotTransfer);
			__this.SetmUuid (mUuid);
		}
#pragma warning restore 0169

		static IntPtr id_setmUuid_Landroid_os_ParcelUuid_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='setmUuid' and count(parameter)=1 and parameter[1][@type='android.os.ParcelUuid']]"
		[Register ("setmUuid", "(Landroid/os/ParcelUuid;)V", "GetSetmUuid_Landroid_os_ParcelUuid_Handler")]
		public virtual unsafe void SetmUuid (global::Android.OS.ParcelUuid mUuid)
		{
			if (id_setmUuid_Landroid_os_ParcelUuid_ == IntPtr.Zero)
				id_setmUuid_Landroid_os_ParcelUuid_ = JNIEnv.GetMethodID (class_ref, "setmUuid", "(Landroid/os/ParcelUuid;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mUuid);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmUuid_Landroid_os_ParcelUuid_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmUuid", "(Landroid/os/ParcelUuid;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmValue_arrayB;
#pragma warning disable 0169
		static Delegate GetSetmValue_arrayBHandler ()
		{
			if (cb_setmValue_arrayB == null)
				cb_setmValue_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetmValue_arrayB);
			return cb_setmValue_arrayB;
		}

		static void n_SetmValue_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_mValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mValue = (byte[]) JNIEnv.GetArray (native_mValue, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetmValue (mValue);
			if (mValue != null)
				JNIEnv.CopyArray (mValue, native_mValue);
		}
#pragma warning restore 0169

		static IntPtr id_setmValue_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='setmValue' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setmValue", "([B)V", "GetSetmValue_arrayBHandler")]
		public virtual unsafe void SetmValue (byte[] mValue)
		{
			if (id_setmValue_arrayB == IntPtr.Zero)
				id_setmValue_arrayB = JNIEnv.GetMethodID (class_ref, "setmValue", "([B)V");
			IntPtr native_mValue = JNIEnv.NewArray (mValue);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmValue_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmValue", "([B)V"), __args);
			} finally {
				if (mValue != null) {
					JNIEnv.CopyArray (native_mValue, mValue);
					JNIEnv.DeleteLocalRef (native_mValue);
				}
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
