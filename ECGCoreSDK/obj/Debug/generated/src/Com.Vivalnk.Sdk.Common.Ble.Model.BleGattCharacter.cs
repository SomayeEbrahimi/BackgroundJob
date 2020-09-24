using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/model/BleGattCharacter", DoNotGenerateAcw=true)]
	public partial class BleGattCharacter : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/model/BleGattCharacter", typeof (BleGattCharacter));
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

		protected BleGattCharacter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/constructor[@name='BleGattCharacter' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothGattCharacteristic;)V", "")]
		public unsafe BleGattCharacter (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/bluetooth/BluetoothGattCharacteristic;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/constructor[@name='BleGattCharacter' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe BleGattCharacter (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getDescriptors;
#pragma warning disable 0169
		static Delegate GetGetDescriptorsHandler ()
		{
			if (cb_getDescriptors == null)
				cb_getDescriptors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDescriptors);
			return cb_getDescriptors;
		}

		static IntPtr n_GetDescriptors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor>.ToLocalJniHandle (__this.Descriptors);
		}
#pragma warning restore 0169

		static Delegate cb_setDescriptors_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDescriptors_Ljava_util_List_Handler ()
		{
			if (cb_setDescriptors_Ljava_util_List_ == null)
				cb_setDescriptors_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDescriptors_Ljava_util_List_);
			return cb_setDescriptors_Ljava_util_List_;
		}

		static void n_SetDescriptors_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_descriptors)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var descriptors = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor>.FromJniHandle (native_descriptors, JniHandleOwnership.DoNotTransfer);
			__this.Descriptors = descriptors;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> Descriptors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='getDescriptors' and count(parameter)=0]"
			[Register ("getDescriptors", "()Ljava/util/List;", "GetGetDescriptorsHandler")]
			get {
				const string __id = "getDescriptors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='setDescriptors' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.vivalnk.sdk.common.ble.model.BleGattDescriptor&gt;']]"
			[Register ("setDescriptors", "(Ljava/util/List;)V", "GetSetDescriptors_Ljava_util_List_Handler")]
			set {
				const string __id = "setDescriptors.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPermissions;
#pragma warning disable 0169
		static Delegate GetGetPermissionsHandler ()
		{
			if (cb_getPermissions == null)
				cb_getPermissions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPermissions);
			return cb_getPermissions;
		}

		static int n_GetPermissions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Permissions;
		}
#pragma warning restore 0169

		static Delegate cb_setPermissions_I;
#pragma warning disable 0169
		static Delegate GetSetPermissions_IHandler ()
		{
			if (cb_setPermissions_I == null)
				cb_setPermissions_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetPermissions_I);
			return cb_setPermissions_I;
		}

		static void n_SetPermissions_I (IntPtr jnienv, IntPtr native__this, int permissions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Permissions = permissions;
		}
#pragma warning restore 0169

		public virtual unsafe int Permissions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='getPermissions' and count(parameter)=0]"
			[Register ("getPermissions", "()I", "GetGetPermissionsHandler")]
			get {
				const string __id = "getPermissions.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='setPermissions' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPermissions", "(I)V", "GetSetPermissions_IHandler")]
			set {
				const string __id = "setPermissions.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProperty;
#pragma warning disable 0169
		static Delegate GetGetPropertyHandler ()
		{
			if (cb_getProperty == null)
				cb_getProperty = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetProperty);
			return cb_getProperty;
		}

		static int n_GetProperty (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Property;
		}
#pragma warning restore 0169

		static Delegate cb_setProperty_I;
#pragma warning disable 0169
		static Delegate GetSetProperty_IHandler ()
		{
			if (cb_setProperty_I == null)
				cb_setProperty_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetProperty_I);
			return cb_setProperty_I;
		}

		static void n_SetProperty_I (IntPtr jnienv, IntPtr native__this, int property)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Property = property;
		}
#pragma warning restore 0169

		public virtual unsafe int Property {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='getProperty' and count(parameter)=0]"
			[Register ("getProperty", "()I", "GetGetPropertyHandler")]
			get {
				const string __id = "getProperty.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='setProperty' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setProperty", "(I)V", "GetSetProperty_IHandler")]
			set {
				const string __id = "setProperty.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUuid;
#pragma warning disable 0169
		static Delegate GetGetUuidHandler ()
		{
			if (cb_getUuid == null)
				cb_getUuid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUuid);
			return cb_getUuid;
		}

		static IntPtr n_GetUuid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Uuid);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.UUID Uuid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='getUuid' and count(parameter)=0]"
			[Register ("getUuid", "()Ljava/util/UUID;", "GetGetUuidHandler")]
			get {
				const string __id = "getUuid.()Ljava/util/UUID;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetmValue ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='getmValue' and count(parameter)=0]"
		[Register ("getmValue", "()[B", "GetGetmValueHandler")]
		public virtual unsafe byte[] GetmValue ()
		{
			const string __id = "getmValue.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setUuid_Landroid_os_ParcelUuid_;
#pragma warning disable 0169
		static Delegate GetSetUuid_Landroid_os_ParcelUuid_Handler ()
		{
			if (cb_setUuid_Landroid_os_ParcelUuid_ == null)
				cb_setUuid_Landroid_os_ParcelUuid_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUuid_Landroid_os_ParcelUuid_);
			return cb_setUuid_Landroid_os_ParcelUuid_;
		}

		static void n_SetUuid_Landroid_os_ParcelUuid_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uuid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uuid = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (native_uuid, JniHandleOwnership.DoNotTransfer);
			__this.SetUuid (uuid);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='setUuid' and count(parameter)=1 and parameter[1][@type='android.os.ParcelUuid']]"
		[Register ("setUuid", "(Landroid/os/ParcelUuid;)V", "GetSetUuid_Landroid_os_ParcelUuid_Handler")]
		public virtual unsafe void SetUuid (global::Android.OS.ParcelUuid uuid)
		{
			const string __id = "setUuid.(Landroid/os/ParcelUuid;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mValue = (byte[]) JNIEnv.GetArray (native_mValue, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetmValue (mValue);
			if (mValue != null)
				JNIEnv.CopyArray (mValue, native_mValue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='setmValue' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setmValue", "([B)V", "GetSetmValue_arrayBHandler")]
		public virtual unsafe void SetmValue (byte[] mValue)
		{
			const string __id = "setmValue.([B)V";
			IntPtr native_mValue = JNIEnv.NewArray (mValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mValue);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
