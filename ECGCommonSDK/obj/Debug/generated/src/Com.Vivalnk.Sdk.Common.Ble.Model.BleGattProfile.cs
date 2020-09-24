using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/model/BleGattProfile", DoNotGenerateAcw=true)]
	public partial class BleGattProfile : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/model/BleGattProfile", typeof (BleGattProfile));
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

		protected BleGattProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/constructor[@name='BleGattProfile' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe BleGattProfile (global::Android.OS.Parcel @in)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/constructor[@name='BleGattProfile' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.util.UUID, java.util.Map&lt;java.util.UUID, android.bluetooth.BluetoothGattCharacteristic&gt;&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe BleGattProfile (global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>> map)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_map = global::Android.Runtime.JavaDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>>.ToLocalJniHandle (map);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_map);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		static Delegate cb_getServices;
#pragma warning disable 0169
		static Delegate GetGetServicesHandler ()
		{
			if (cb_getServices == null)
				cb_getServices = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServices);
			return cb_getServices;
		}

		static IntPtr n_GetServices (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService>.ToLocalJniHandle (__this.Services);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService> Services {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='getServices' and count(parameter)=0]"
			[Register ("getServices", "()Ljava/util/List;", "GetGetServicesHandler")]
			get {
				const string __id = "getServices.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addServices_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddServices_Ljava_util_List_Handler ()
		{
			if (cb_addServices_Ljava_util_List_ == null)
				cb_addServices_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddServices_Ljava_util_List_);
			return cb_addServices_Ljava_util_List_;
		}

		static void n_AddServices_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_services)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var services = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService>.FromJniHandle (native_services, JniHandleOwnership.DoNotTransfer);
			__this.AddServices (services);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='addServices' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.vivalnk.sdk.common.ble.model.BleGattService&gt;']]"
		[Register ("addServices", "(Ljava/util/List;)V", "GetAddServices_Ljava_util_List_Handler")]
		public virtual unsafe void AddServices (global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService> services)
		{
			const string __id = "addServices.(Ljava/util/List;)V";
			IntPtr native_services = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService>.ToLocalJniHandle (services);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_services);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_services);
			}
		}

		static Delegate cb_containsCharacter_Ljava_util_UUID_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetContainsCharacter_Ljava_util_UUID_Ljava_util_UUID_Handler ()
		{
			if (cb_containsCharacter_Ljava_util_UUID_Ljava_util_UUID_ == null)
				cb_containsCharacter_Ljava_util_UUID_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_ContainsCharacter_Ljava_util_UUID_Ljava_util_UUID_);
			return cb_containsCharacter_Ljava_util_UUID_Ljava_util_UUID_;
		}

		static bool n_ContainsCharacter_Ljava_util_UUID_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serviceId, IntPtr native_characterId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serviceId = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_serviceId, JniHandleOwnership.DoNotTransfer);
			var characterId = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_characterId, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsCharacter (serviceId, characterId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='containsCharacter' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID']]"
		[Register ("containsCharacter", "(Ljava/util/UUID;Ljava/util/UUID;)Z", "GetContainsCharacter_Ljava_util_UUID_Ljava_util_UUID_Handler")]
		public virtual unsafe bool ContainsCharacter (global::Java.Util.UUID serviceId, global::Java.Util.UUID characterId)
		{
			const string __id = "containsCharacter.(Ljava/util/UUID;Ljava/util/UUID;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((serviceId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceId).Handle);
				__args [1] = new JniArgumentValue ((characterId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characterId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getService_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetGetService_Ljava_util_UUID_Handler ()
		{
			if (cb_getService_Ljava_util_UUID_ == null)
				cb_getService_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetService_Ljava_util_UUID_);
			return cb_getService_Ljava_util_UUID_;
		}

		static IntPtr n_GetService_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serviceId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serviceId = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_serviceId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetService (serviceId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='getService' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("getService", "(Ljava/util/UUID;)Lcom/vivalnk/sdk/common/ble/model/BleGattService;", "GetGetService_Ljava_util_UUID_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService GetService (global::Java.Util.UUID serviceId)
		{
			const string __id = "getService.(Ljava/util/UUID;)Lcom/vivalnk/sdk/common/ble/model/BleGattService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((serviceId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
