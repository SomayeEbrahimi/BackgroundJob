using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothLog']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/utils/BluetoothLog", DoNotGenerateAcw=true)]
	public partial class BluetoothLog : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/utils/BluetoothLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BluetoothLog); }
		}

		protected BluetoothLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothLog']/constructor[@name='BluetoothLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BluetoothLog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BluetoothLog)) {
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

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothLog']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "")]
		public static unsafe void D (string msg)
		{
			if (id_d_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothLog']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "")]
		public static unsafe void E (string msg)
		{
			if (id_e_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_e_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothLog']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (global::Java.Lang.Throwable e)
		{
			if (id_e_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_i_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothLog']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "")]
		public static unsafe void I (string msg)
		{
			if (id_i_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_v_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothLog']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;)V", "")]
		public static unsafe void V (string msg)
		{
			if (id_v_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_w_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothLog']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)V", "")]
		public static unsafe void W (string msg)
		{
			if (id_w_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_w_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='BluetoothLog']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void W (global::Java.Lang.Throwable e)
		{
			if (id_w_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_w_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

	}
}
