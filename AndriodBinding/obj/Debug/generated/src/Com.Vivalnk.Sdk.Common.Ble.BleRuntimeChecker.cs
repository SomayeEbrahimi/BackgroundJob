using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BleRuntimeChecker", DoNotGenerateAcw=true)]
	public partial class BleRuntimeChecker : global::Java.Lang.Object {


		static IntPtr BLUETOOTH_NOT_AVAILABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='BLUETOOTH_NOT_AVAILABLE']"
		[Register ("BLUETOOTH_NOT_AVAILABLE")]
		public static int BluetoothNotAvailable {
			get {
				if (BLUETOOTH_NOT_AVAILABLE_jfieldId == IntPtr.Zero)
					BLUETOOTH_NOT_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLUETOOTH_NOT_AVAILABLE", "I");
				return JNIEnv.GetStaticIntField (class_ref, BLUETOOTH_NOT_AVAILABLE_jfieldId);
			}
			set {
				if (BLUETOOTH_NOT_AVAILABLE_jfieldId == IntPtr.Zero)
					BLUETOOTH_NOT_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLUETOOTH_NOT_AVAILABLE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, BLUETOOTH_NOT_AVAILABLE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr BLUETOOTH_NOT_ENABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='BLUETOOTH_NOT_ENABLED']"
		[Register ("BLUETOOTH_NOT_ENABLED")]
		public static int BluetoothNotEnabled {
			get {
				if (BLUETOOTH_NOT_ENABLED_jfieldId == IntPtr.Zero)
					BLUETOOTH_NOT_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLUETOOTH_NOT_ENABLED", "I");
				return JNIEnv.GetStaticIntField (class_ref, BLUETOOTH_NOT_ENABLED_jfieldId);
			}
			set {
				if (BLUETOOTH_NOT_ENABLED_jfieldId == IntPtr.Zero)
					BLUETOOTH_NOT_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLUETOOTH_NOT_ENABLED", "I");
				try {
					JNIEnv.SetStaticField (class_ref, BLUETOOTH_NOT_ENABLED_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr CHECK_RESULT_OK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='CHECK_RESULT_OK']"
		[Register ("CHECK_RESULT_OK")]
		public static int CheckResultOk {
			get {
				if (CHECK_RESULT_OK_jfieldId == IntPtr.Zero)
					CHECK_RESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHECK_RESULT_OK", "I");
				return JNIEnv.GetStaticIntField (class_ref, CHECK_RESULT_OK_jfieldId);
			}
			set {
				if (CHECK_RESULT_OK_jfieldId == IntPtr.Zero)
					CHECK_RESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHECK_RESULT_OK", "I");
				try {
					JNIEnv.SetStaticField (class_ref, CHECK_RESULT_OK_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr NOT_SUPPORT_BLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='NOT_SUPPORT_BLE']"
		[Register ("NOT_SUPPORT_BLE")]
		public static int NotSupportBle {
			get {
				if (NOT_SUPPORT_BLE_jfieldId == IntPtr.Zero)
					NOT_SUPPORT_BLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SUPPORT_BLE", "I");
				return JNIEnv.GetStaticIntField (class_ref, NOT_SUPPORT_BLE_jfieldId);
			}
			set {
				if (NOT_SUPPORT_BLE_jfieldId == IntPtr.Zero)
					NOT_SUPPORT_BLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SUPPORT_BLE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, NOT_SUPPORT_BLE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='NO_BLUETOOTH_ADMIN_PERMISSION']"
		[Register ("NO_BLUETOOTH_ADMIN_PERMISSION")]
		public static int NoBluetoothAdminPermission {
			get {
				if (NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId == IntPtr.Zero)
					NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_BLUETOOTH_ADMIN_PERMISSION", "I");
				return JNIEnv.GetStaticIntField (class_ref, NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId);
			}
			set {
				if (NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId == IntPtr.Zero)
					NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_BLUETOOTH_ADMIN_PERMISSION", "I");
				try {
					JNIEnv.SetStaticField (class_ref, NO_BLUETOOTH_ADMIN_PERMISSION_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr NO_BLUETOOTH_PERMISSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='NO_BLUETOOTH_PERMISSION']"
		[Register ("NO_BLUETOOTH_PERMISSION")]
		public static int NoBluetoothPermission {
			get {
				if (NO_BLUETOOTH_PERMISSION_jfieldId == IntPtr.Zero)
					NO_BLUETOOTH_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_BLUETOOTH_PERMISSION", "I");
				return JNIEnv.GetStaticIntField (class_ref, NO_BLUETOOTH_PERMISSION_jfieldId);
			}
			set {
				if (NO_BLUETOOTH_PERMISSION_jfieldId == IntPtr.Zero)
					NO_BLUETOOTH_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_BLUETOOTH_PERMISSION", "I");
				try {
					JNIEnv.SetStaticField (class_ref, NO_BLUETOOTH_PERMISSION_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr SDCARD_NOT_AVAILABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/field[@name='SDCARD_NOT_AVAILABLE']"
		[Register ("SDCARD_NOT_AVAILABLE")]
		public static int SdcardNotAvailable {
			get {
				if (SDCARD_NOT_AVAILABLE_jfieldId == IntPtr.Zero)
					SDCARD_NOT_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SDCARD_NOT_AVAILABLE", "I");
				return JNIEnv.GetStaticIntField (class_ref, SDCARD_NOT_AVAILABLE_jfieldId);
			}
			set {
				if (SDCARD_NOT_AVAILABLE_jfieldId == IntPtr.Zero)
					SDCARD_NOT_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SDCARD_NOT_AVAILABLE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, SDCARD_NOT_AVAILABLE_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/BleRuntimeChecker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleRuntimeChecker); }
		}

		protected BleRuntimeChecker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/constructor[@name='BleRuntimeChecker' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BleRuntimeChecker (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (BleRuntimeChecker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_checkBleRuntime_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='checkBleRuntime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkBleRuntime", "(Landroid/content/Context;)I", "")]
		public static unsafe int CheckBleRuntime (global::Android.Content.Context context)
		{
			if (id_checkBleRuntime_Landroid_content_Context_ == IntPtr.Zero)
				id_checkBleRuntime_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkBleRuntime", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_checkBleRuntime_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_checkRuntime_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCheckRuntime_Landroid_content_Context_Handler ()
		{
			if (cb_checkRuntime_Landroid_content_Context_ == null)
				cb_checkRuntime_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CheckRuntime_Landroid_content_Context_);
			return cb_checkRuntime_Landroid_content_Context_;
		}

		static int n_CheckRuntime_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mContext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.BleRuntimeChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_mContext, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckRuntime (mContext);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_checkRuntime_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='checkRuntime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkRuntime", "(Landroid/content/Context;)I", "GetCheckRuntime_Landroid_content_Context_Handler")]
		public virtual unsafe int CheckRuntime (global::Android.Content.Context mContext)
		{
			if (id_checkRuntime_Landroid_content_Context_ == IntPtr.Zero)
				id_checkRuntime_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "checkRuntime", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mContext);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkRuntime_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkRuntime", "(Landroid/content/Context;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hasBluetoothAdminPermission_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='hasBluetoothAdminPermission' and count(parameter)=1 and parameter[1][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='hasBluetoothPermission' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_isBluetoothAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='isBluetoothAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='isBluetoothEnable' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_isSDCardAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='isSDCardAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker']/method[@name='isSupportBLE' and count(parameter)=1 and parameter[1][@type='int']]"
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
