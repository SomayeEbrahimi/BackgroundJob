using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/model/BleGattProfile", DoNotGenerateAcw=true)]
	public partial class BleGattProfile : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/model/BleGattProfile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleGattProfile); }
		}

		protected BleGattProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/constructor[@name='BleGattProfile' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe BleGattProfile (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (BleGattProfile)) {
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

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/constructor[@name='BleGattProfile' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.util.UUID, java.util.Map&lt;java.util.UUID, android.bluetooth.BluetoothGattCharacteristic&gt;&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe BleGattProfile (global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>> map)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_map = global::Android.Runtime.JavaDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>>.ToLocalJniHandle (map);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_map);
				if (((object) this).GetType () != typeof (BleGattProfile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Map_, __args);
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

		static IntPtr id_getServices;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService> Services {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='getServices' and count(parameter)=0]"
			[Register ("getServices", "()Ljava/util/List;", "GetGetServicesHandler")]
			get {
				if (id_getServices == IntPtr.Zero)
					id_getServices = JNIEnv.GetMethodID (class_ref, "getServices", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServices), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServices", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_addServices_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='addServices' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.vivalnk.sdk.common.ble.model.BleGattService&gt;']]"
		[Register ("addServices", "(Ljava/util/List;)V", "GetAddServices_Ljava_util_List_Handler")]
		public virtual unsafe void AddServices (global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService> services)
		{
			if (id_addServices_Ljava_util_List_ == IntPtr.Zero)
				id_addServices_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addServices", "(Ljava/util/List;)V");
			IntPtr native_services = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService>.ToLocalJniHandle (services);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_services);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addServices_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addServices", "(Ljava/util/List;)V"), __args);
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

		static IntPtr id_containsCharacter_Ljava_util_UUID_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='containsCharacter' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID']]"
		[Register ("containsCharacter", "(Ljava/util/UUID;Ljava/util/UUID;)Z", "GetContainsCharacter_Ljava_util_UUID_Ljava_util_UUID_Handler")]
		public virtual unsafe bool ContainsCharacter (global::Java.Util.UUID serviceId, global::Java.Util.UUID characterId)
		{
			if (id_containsCharacter_Ljava_util_UUID_Ljava_util_UUID_ == IntPtr.Zero)
				id_containsCharacter_Ljava_util_UUID_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "containsCharacter", "(Ljava/util/UUID;Ljava/util/UUID;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (serviceId);
				__args [1] = new JValue (characterId);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsCharacter_Ljava_util_UUID_Ljava_util_UUID_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsCharacter", "(Ljava/util/UUID;Ljava/util/UUID;)Z"), __args);
				return __ret;
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

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_getService_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='getService' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("getService", "(Ljava/util/UUID;)Lcom/vivalnk/sdk/common/ble/model/BleGattService;", "GetGetService_Ljava_util_UUID_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService GetService (global::Java.Util.UUID serviceId)
		{
			if (id_getService_Ljava_util_UUID_ == IntPtr.Zero)
				id_getService_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "getService", "(Ljava/util/UUID;)Lcom/vivalnk/sdk/common/ble/model/BleGattService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (serviceId);

				global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getService_Ljava_util_UUID_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattService> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getService", "(Ljava/util/UUID;)Lcom/vivalnk/sdk/common/ble/model/BleGattService;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattProfile']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
