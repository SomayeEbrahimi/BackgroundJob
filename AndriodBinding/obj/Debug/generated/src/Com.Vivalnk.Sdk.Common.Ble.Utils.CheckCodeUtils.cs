using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/utils/CheckCodeUtils", DoNotGenerateAcw=true)]
	public partial class CheckCodeUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/utils/CheckCodeUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CheckCodeUtils); }
		}

		protected CheckCodeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/constructor[@name='CheckCodeUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CheckCodeUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CheckCodeUtils)) {
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

		static IntPtr id_hasBluetoothAdminPermission_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='hasBluetoothAdminPermission' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasBluetoothAdminPermission", "(I)Z", "")]
		public static unsafe bool HasBluetoothAdminPermission (int code)
		{
			if (id_hasBluetoothAdminPermission_I == IntPtr.Zero)
				id_hasBluetoothAdminPermission_I = JNIEnv.GetStaticMethodID (class_ref, "hasBluetoothAdminPermission", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasBluetoothAdminPermission_I, __args);
			} finally {
			}
		}

		static IntPtr id_hasBluetoothPermission_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='hasBluetoothPermission' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasBluetoothPermission", "(I)Z", "")]
		public static unsafe bool HasBluetoothPermission (int code)
		{
			if (id_hasBluetoothPermission_I == IntPtr.Zero)
				id_hasBluetoothPermission_I = JNIEnv.GetStaticMethodID (class_ref, "hasBluetoothPermission", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasBluetoothPermission_I, __args);
			} finally {
			}
		}

		static IntPtr id_hasLocationPermission_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='hasLocationPermission' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasLocationPermission", "(I)Z", "")]
		public static unsafe bool HasLocationPermission (int code)
		{
			if (id_hasLocationPermission_I == IntPtr.Zero)
				id_hasLocationPermission_I = JNIEnv.GetStaticMethodID (class_ref, "hasLocationPermission", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasLocationPermission_I, __args);
			} finally {
			}
		}

		static IntPtr id_hasSDCardPermission_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='hasSDCardPermission' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasSDCardPermission", "(I)Z", "")]
		public static unsafe bool HasSDCardPermission (int code)
		{
			if (id_hasSDCardPermission_I == IntPtr.Zero)
				id_hasSDCardPermission_I = JNIEnv.GetStaticMethodID (class_ref, "hasSDCardPermission", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasSDCardPermission_I, __args);
			} finally {
			}
		}

		static IntPtr id_isBluetoothAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='isBluetoothAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isBluetoothAvailable", "(I)Z", "")]
		public static unsafe bool IsBluetoothAvailable (int code)
		{
			if (id_isBluetoothAvailable_I == IntPtr.Zero)
				id_isBluetoothAvailable_I = JNIEnv.GetStaticMethodID (class_ref, "isBluetoothAvailable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBluetoothAvailable_I, __args);
			} finally {
			}
		}

		static IntPtr id_isBluetoothEnable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='isBluetoothEnable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isBluetoothEnable", "(I)Z", "")]
		public static unsafe bool IsBluetoothEnable (int code)
		{
			if (id_isBluetoothEnable_I == IntPtr.Zero)
				id_isBluetoothEnable_I = JNIEnv.GetStaticMethodID (class_ref, "isBluetoothEnable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBluetoothEnable_I, __args);
			} finally {
			}
		}

		static IntPtr id_isLocationEnable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='isLocationEnable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLocationEnable", "(I)Z", "")]
		public static unsafe bool IsLocationEnable (int code)
		{
			if (id_isLocationEnable_I == IntPtr.Zero)
				id_isLocationEnable_I = JNIEnv.GetStaticMethodID (class_ref, "isLocationEnable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLocationEnable_I, __args);
			} finally {
			}
		}

		static IntPtr id_isSDCardAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='isSDCardAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSDCardAvailable", "(I)Z", "")]
		public static unsafe bool IsSDCardAvailable (int code)
		{
			if (id_isSDCardAvailable_I == IntPtr.Zero)
				id_isSDCardAvailable_I = JNIEnv.GetStaticMethodID (class_ref, "isSDCardAvailable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSDCardAvailable_I, __args);
			} finally {
			}
		}

		static IntPtr id_isSupportBLE_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='CheckCodeUtils']/method[@name='isSupportBLE' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSupportBLE", "(I)Z", "")]
		public static unsafe bool IsSupportBLE (int code)
		{
			if (id_isSupportBLE_I == IntPtr.Zero)
				id_isSupportBLE_I = JNIEnv.GetStaticMethodID (class_ref, "isSupportBLE", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSupportBLE_I, __args);
			} finally {
			}
		}

	}
}
