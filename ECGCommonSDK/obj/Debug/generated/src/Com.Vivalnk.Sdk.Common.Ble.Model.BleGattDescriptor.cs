using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/model/BleGattDescriptor", DoNotGenerateAcw=true)]
	public partial class BleGattDescriptor : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/model/BleGattDescriptor", typeof (BleGattDescriptor));
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

		protected BleGattDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/constructor[@name='BleGattDescriptor' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattDescriptor']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothGattDescriptor;)V", "")]
		public unsafe BleGattDescriptor (global::Android.Bluetooth.BluetoothGattDescriptor descriptor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/bluetooth/BluetoothGattDescriptor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) descriptor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/constructor[@name='BleGattDescriptor' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe BleGattDescriptor (global::Android.OS.Parcel @in)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='describeContents' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='getmPermissions' and count(parameter)=0]"
		[Register ("getmPermissions", "()I", "GetGetmPermissionsHandler")]
		public virtual unsafe int GetmPermissions ()
		{
			const string __id = "getmPermissions.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='getmUuid' and count(parameter)=0]"
		[Register ("getmUuid", "()Landroid/os/ParcelUuid;", "GetGetmUuidHandler")]
		public virtual unsafe global::Android.OS.ParcelUuid GetmUuid ()
		{
			const string __id = "getmUuid.()Landroid/os/ParcelUuid;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='getmValue' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='setmPermissions' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmPermissions", "(I)V", "GetSetmPermissions_IHandler")]
		public virtual unsafe void SetmPermissions (int mPermissions)
		{
			const string __id = "setmPermissions.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mPermissions);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='setmUuid' and count(parameter)=1 and parameter[1][@type='android.os.ParcelUuid']]"
		[Register ("setmUuid", "(Landroid/os/ParcelUuid;)V", "GetSetmUuid_Landroid_os_ParcelUuid_Handler")]
		public virtual unsafe void SetmUuid (global::Android.OS.ParcelUuid mUuid)
		{
			const string __id = "setmUuid.(Landroid/os/ParcelUuid;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mUuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mUuid).Handle);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mValue = (byte[]) JNIEnv.GetArray (native_mValue, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetmValue (mValue);
			if (mValue != null)
				JNIEnv.CopyArray (mValue, native_mValue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='setmValue' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattDescriptor']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
