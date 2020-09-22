using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker18']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/BleRuntimeChecker18", DoNotGenerateAcw=true)]
	public partial class BleRuntimeChecker18 : global::Com.Vivalnk.Sdk.Common.Ble.BleRuntimeChecker {


		static IntPtr NO_SDCARD_PERMISSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker18']/field[@name='NO_SDCARD_PERMISSION']"
		[Register ("NO_SDCARD_PERMISSION")]
		public static int NoSdcardPermission {
			get {
				if (NO_SDCARD_PERMISSION_jfieldId == IntPtr.Zero)
					NO_SDCARD_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_SDCARD_PERMISSION", "I");
				return JNIEnv.GetStaticIntField (class_ref, NO_SDCARD_PERMISSION_jfieldId);
			}
			set {
				if (NO_SDCARD_PERMISSION_jfieldId == IntPtr.Zero)
					NO_SDCARD_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_SDCARD_PERMISSION", "I");
				try {
					JNIEnv.SetStaticField (class_ref, NO_SDCARD_PERMISSION_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/BleRuntimeChecker18", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleRuntimeChecker18); }
		}

		protected BleRuntimeChecker18 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker18']/constructor[@name='BleRuntimeChecker18' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BleRuntimeChecker18 (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (BleRuntimeChecker18)) {
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

		static IntPtr id_hasSDCardPermission_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble']/class[@name='BleRuntimeChecker18']/method[@name='hasSDCardPermission' and count(parameter)=1 and parameter[1][@type='int']]"
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

	}
}
