using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BleRuntimeChecker23", DoNotGenerateAcw=true)]
	public partial class BleRuntimeChecker23 : global::Com.Vivalnk.Sdk.Common.Ble.BleRuntimeChecker {


		static IntPtr LOCATION_NOT_ENABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']/field[@name='LOCATION_NOT_ENABLED']"
		[Register ("LOCATION_NOT_ENABLED")]
		public static int LocationNotEnabled {
			get {
				if (LOCATION_NOT_ENABLED_jfieldId == IntPtr.Zero)
					LOCATION_NOT_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_NOT_ENABLED", "I");
				return JNIEnv.GetStaticIntField (class_ref, LOCATION_NOT_ENABLED_jfieldId);
			}
			set {
				if (LOCATION_NOT_ENABLED_jfieldId == IntPtr.Zero)
					LOCATION_NOT_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_NOT_ENABLED", "I");
				try {
					JNIEnv.SetStaticField (class_ref, LOCATION_NOT_ENABLED_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr NO_LOCATION_PERMISSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']/field[@name='NO_LOCATION_PERMISSION']"
		[Register ("NO_LOCATION_PERMISSION")]
		public static int NoLocationPermission {
			get {
				if (NO_LOCATION_PERMISSION_jfieldId == IntPtr.Zero)
					NO_LOCATION_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_LOCATION_PERMISSION", "I");
				return JNIEnv.GetStaticIntField (class_ref, NO_LOCATION_PERMISSION_jfieldId);
			}
			set {
				if (NO_LOCATION_PERMISSION_jfieldId == IntPtr.Zero)
					NO_LOCATION_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_LOCATION_PERMISSION", "I");
				try {
					JNIEnv.SetStaticField (class_ref, NO_LOCATION_PERMISSION_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/BleRuntimeChecker23", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleRuntimeChecker23); }
		}

		protected BleRuntimeChecker23 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']/constructor[@name='BleRuntimeChecker23' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BleRuntimeChecker23 (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (BleRuntimeChecker23)) {
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

		static IntPtr id_hasLocationPermission_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']/method[@name='hasLocationPermission' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_isLocationEnable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker23']/method[@name='isLocationEnable' and count(parameter)=1 and parameter[1][@type='int']]"
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

	}
}
