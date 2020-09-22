using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/ClsUtils", DoNotGenerateAcw=true)]
	public partial class ClsUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/ClsUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClsUtils); }
		}

		protected ClsUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/constructor[@name='ClsUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClsUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ClsUtils)) {
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

		static IntPtr id_cancelBondProcess_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='cancelBondProcess' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("cancelBondProcess", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z", "")]
		public static unsafe bool CancelBondProcess (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice device)
		{
			if (id_cancelBondProcess_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_ == IntPtr.Zero)
				id_cancelBondProcess_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_ = JNIEnv.GetStaticMethodID (class_ref, "cancelBondProcess", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (btClass);
				__args [1] = new JValue (device);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_cancelBondProcess_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_cancelPairingUserInput_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='cancelPairingUserInput' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("cancelPairingUserInput", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z", "")]
		public static unsafe bool CancelPairingUserInput (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice device)
		{
			if (id_cancelPairingUserInput_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_ == IntPtr.Zero)
				id_cancelPairingUserInput_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_ = JNIEnv.GetStaticMethodID (class_ref, "cancelPairingUserInput", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (btClass);
				__args [1] = new JValue (device);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_cancelPairingUserInput_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createBond_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='createBond' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("createBond", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z", "")]
		public static unsafe bool CreateBond (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice btDevice)
		{
			if (id_createBond_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_ == IntPtr.Zero)
				id_createBond_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_ = JNIEnv.GetStaticMethodID (class_ref, "createBond", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (btClass);
				__args [1] = new JValue (btDevice);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_createBond_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_printAllInform_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='printAllInform' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("printAllInform", "(Ljava/lang/Class;)V", "")]
		public static unsafe void PrintAllInform (global::Java.Lang.Class clsShow)
		{
			if (id_printAllInform_Ljava_lang_Class_ == IntPtr.Zero)
				id_printAllInform_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "printAllInform", "(Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clsShow);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printAllInform_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static IntPtr id_removeBond_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='removeBond' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("removeBond", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z", "")]
		public static unsafe bool RemoveBond (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice btDevice)
		{
			if (id_removeBond_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_ == IntPtr.Zero)
				id_removeBond_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_ = JNIEnv.GetStaticMethodID (class_ref, "removeBond", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (btClass);
				__args [1] = new JValue (btDevice);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_removeBond_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setPairingConfirmation_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='setPairingConfirmation' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='android.bluetooth.BluetoothDevice'] and parameter[3][@type='boolean']]"
		[Register ("setPairingConfirmation", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;Z)V", "")]
		public static unsafe void SetPairingConfirmation (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice device, bool isConfirm)
		{
			if (id_setPairingConfirmation_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_Z == IntPtr.Zero)
				id_setPairingConfirmation_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_Z = JNIEnv.GetStaticMethodID (class_ref, "setPairingConfirmation", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (btClass);
				__args [1] = new JValue (device);
				__args [2] = new JValue (isConfirm);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPairingConfirmation_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setPin_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ClsUtils']/method[@name='setPin' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;? extends android.bluetooth.BluetoothDevice&gt;'] and parameter[2][@type='android.bluetooth.BluetoothDevice'] and parameter[3][@type='java.lang.String']]"
		[Register ("setPin", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;Ljava/lang/String;)Z", "")]
		public static unsafe bool SetPin (global::Java.Lang.Class btClass, global::Android.Bluetooth.BluetoothDevice btDevice, string str)
		{
			if (id_setPin_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_Ljava_lang_String_ == IntPtr.Zero)
				id_setPin_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setPin", "(Ljava/lang/Class;Landroid/bluetooth/BluetoothDevice;Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (btClass);
				__args [1] = new JValue (btDevice);
				__args [2] = new JValue (native_str);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_setPin_Ljava_lang_Class_Landroid_bluetooth_BluetoothDevice_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

	}
}
