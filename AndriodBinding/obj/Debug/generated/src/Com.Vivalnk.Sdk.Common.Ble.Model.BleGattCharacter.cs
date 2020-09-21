using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/model/BleGattCharacter", DoNotGenerateAcw=true)]
	public partial class BleGattCharacter : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/model/BleGattCharacter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleGattCharacter); }
		}

		protected BleGattCharacter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/constructor[@name='BleGattCharacter' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothGattCharacteristic;)V", "")]
		public unsafe BleGattCharacter (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (characteristic);
				if (((object) this).GetType () != typeof (BleGattCharacter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/bluetooth/BluetoothGattCharacteristic;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/bluetooth/BluetoothGattCharacteristic;)V", __args);
					return;
				}

				if (id_ctor_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
					id_ctor_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/bluetooth/BluetoothGattCharacteristic;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_bluetooth_BluetoothGattCharacteristic_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/constructor[@name='BleGattCharacter' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe BleGattCharacter (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (BleGattCharacter)) {
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

		static IntPtr id_getDescriptors;
		static IntPtr id_setDescriptors_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor> Descriptors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='getDescriptors' and count(parameter)=0]"
			[Register ("getDescriptors", "()Ljava/util/List;", "GetGetDescriptorsHandler")]
			get {
				if (id_getDescriptors == IntPtr.Zero)
					id_getDescriptors = JNIEnv.GetMethodID (class_ref, "getDescriptors", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescriptors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescriptors", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='setDescriptors' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.vivalnk.sdk.common.ble.model.BleGattDescriptor&gt;']]"
			[Register ("setDescriptors", "(Ljava/util/List;)V", "GetSetDescriptors_Ljava_util_List_Handler")]
			set {
				if (id_setDescriptors_Ljava_util_List_ == IntPtr.Zero)
					id_setDescriptors_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setDescriptors", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattDescriptor>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDescriptors_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescriptors", "(Ljava/util/List;)V"), __args);
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

		static IntPtr id_getPermissions;
		static IntPtr id_setPermissions_I;
		public virtual unsafe int Permissions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='getPermissions' and count(parameter)=0]"
			[Register ("getPermissions", "()I", "GetGetPermissionsHandler")]
			get {
				if (id_getPermissions == IntPtr.Zero)
					id_getPermissions = JNIEnv.GetMethodID (class_ref, "getPermissions", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPermissions);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPermissions", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='setPermissions' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPermissions", "(I)V", "GetSetPermissions_IHandler")]
			set {
				if (id_setPermissions_I == IntPtr.Zero)
					id_setPermissions_I = JNIEnv.GetMethodID (class_ref, "setPermissions", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPermissions_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPermissions", "(I)V"), __args);
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

		static IntPtr id_getProperty;
		static IntPtr id_setProperty_I;
		public virtual unsafe int Property {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='getProperty' and count(parameter)=0]"
			[Register ("getProperty", "()I", "GetGetPropertyHandler")]
			get {
				if (id_getProperty == IntPtr.Zero)
					id_getProperty = JNIEnv.GetMethodID (class_ref, "getProperty", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getProperty);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProperty", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='setProperty' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setProperty", "(I)V", "GetSetProperty_IHandler")]
			set {
				if (id_setProperty_I == IntPtr.Zero)
					id_setProperty_I = JNIEnv.GetMethodID (class_ref, "setProperty", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProperty_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProperty", "(I)V"), __args);
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

		static IntPtr id_getUuid;
		public virtual unsafe global::Java.Util.UUID Uuid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='getUuid' and count(parameter)=0]"
			[Register ("getUuid", "()Ljava/util/UUID;", "GetGetUuidHandler")]
			get {
				if (id_getUuid == IntPtr.Zero)
					id_getUuid = JNIEnv.GetMethodID (class_ref, "getUuid", "()Ljava/util/UUID;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUuid), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUuid", "()Ljava/util/UUID;")), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_getmValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='getmValue' and count(parameter)=0]"
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

		static IntPtr id_setUuid_Landroid_os_ParcelUuid_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='setUuid' and count(parameter)=1 and parameter[1][@type='android.os.ParcelUuid']]"
		[Register ("setUuid", "(Landroid/os/ParcelUuid;)V", "GetSetUuid_Landroid_os_ParcelUuid_Handler")]
		public virtual unsafe void SetUuid (global::Android.OS.ParcelUuid uuid)
		{
			if (id_setUuid_Landroid_os_ParcelUuid_ == IntPtr.Zero)
				id_setUuid_Landroid_os_ParcelUuid_ = JNIEnv.GetMethodID (class_ref, "setUuid", "(Landroid/os/ParcelUuid;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (uuid);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUuid_Landroid_os_ParcelUuid_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUuid", "(Landroid/os/ParcelUuid;)V"), __args);
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

		static IntPtr id_setmValue_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='setmValue' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattCharacter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.model']/class[@name='BleGattCharacter']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
