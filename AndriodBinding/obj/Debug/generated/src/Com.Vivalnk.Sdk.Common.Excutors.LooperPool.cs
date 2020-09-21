using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Excutors {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/excutors/LooperPool", DoNotGenerateAcw=true)]
	public partial class LooperPool : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/excutors/LooperPool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LooperPool); }
		}

		protected LooperPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getMainHandler;
		public static unsafe global::Android.OS.Handler MainHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='getMainHandler' and count(parameter)=0]"
			[Register ("getMainHandler", "()Landroid/os/Handler;", "")]
			get {
				if (id_getMainHandler == IntPtr.Zero)
					id_getMainHandler = JNIEnv.GetStaticMethodID (class_ref, "getMainHandler", "()Landroid/os/Handler;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMainHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMainLooper;
		public static unsafe global::Android.OS.Looper MainLooper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='getMainLooper' and count(parameter)=0]"
			[Register ("getMainLooper", "()Landroid/os/Looper;", "")]
			get {
				if (id_getMainLooper == IntPtr.Zero)
					id_getMainLooper = JNIEnv.GetStaticMethodID (class_ref, "getMainLooper", "()Landroid/os/Looper;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMainLooper), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_createHandler_Lcom_vivalnk_sdk_common_excutors_LooperType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='createHandler' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.excutors.LooperType']]"
		[Register ("createHandler", "(Lcom/vivalnk/sdk/common/excutors/LooperType;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler CreateHandler (global::Com.Vivalnk.Sdk.Common.Excutors.LooperType type)
		{
			if (id_createHandler_Lcom_vivalnk_sdk_common_excutors_LooperType_ == IntPtr.Zero)
				id_createHandler_Lcom_vivalnk_sdk_common_excutors_LooperType_ = JNIEnv.GetStaticMethodID (class_ref, "createHandler", "(Lcom/vivalnk/sdk/common/excutors/LooperType;)Landroid/os/Handler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::Android.OS.Handler __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createHandler_Lcom_vivalnk_sdk_common_excutors_LooperType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createHandler_Lcom_vivalnk_sdk_common_excutors_LooperType_Landroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='createHandler' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.excutors.LooperType'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("createHandler", "(Lcom/vivalnk/sdk/common/excutors/LooperType;Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler CreateHandler (global::Com.Vivalnk.Sdk.Common.Excutors.LooperType type, global::Android.OS.Handler.ICallback @callback)
		{
			if (id_createHandler_Lcom_vivalnk_sdk_common_excutors_LooperType_Landroid_os_Handler_Callback_ == IntPtr.Zero)
				id_createHandler_Lcom_vivalnk_sdk_common_excutors_LooperType_Landroid_os_Handler_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "createHandler", "(Lcom/vivalnk/sdk/common/excutors/LooperType;Landroid/os/Handler$Callback;)Landroid/os/Handler;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (type);
				__args [1] = new JValue (@callback);
				global::Android.OS.Handler __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createHandler_Lcom_vivalnk_sdk_common_excutors_LooperType_Landroid_os_Handler_Callback_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLooper_Lcom_vivalnk_sdk_common_excutors_LooperType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='getLooper' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.excutors.LooperType']]"
		[Register ("getLooper", "(Lcom/vivalnk/sdk/common/excutors/LooperType;)Landroid/os/Looper;", "")]
		public static unsafe global::Android.OS.Looper GetLooper (global::Com.Vivalnk.Sdk.Common.Excutors.LooperType type)
		{
			if (id_getLooper_Lcom_vivalnk_sdk_common_excutors_LooperType_ == IntPtr.Zero)
				id_getLooper_Lcom_vivalnk_sdk_common_excutors_LooperType_ = JNIEnv.GetStaticMethodID (class_ref, "getLooper", "(Lcom/vivalnk/sdk/common/excutors/LooperType;)Landroid/os/Looper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::Android.OS.Looper __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLooper_Lcom_vivalnk_sdk_common_excutors_LooperType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMainHandler_Landroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='getMainHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler.Callback']]"
		[Register ("getMainHandler", "(Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler GetMainHandler (global::Android.OS.Handler.ICallback @callback)
		{
			if (id_getMainHandler_Landroid_os_Handler_Callback_ == IntPtr.Zero)
				id_getMainHandler_Landroid_os_Handler_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "getMainHandler", "(Landroid/os/Handler$Callback;)Landroid/os/Handler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);
				global::Android.OS.Handler __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMainHandler_Landroid_os_Handler_Callback_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
