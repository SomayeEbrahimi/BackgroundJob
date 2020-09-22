using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/log/LogFileManager", DoNotGenerateAcw=true)]
	public partial class LogFileManager : global::Java.Lang.Object, global::Android.OS.Handler.ICallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/log/LogFileManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogFileManager); }
		}

		protected LogFileManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Vivalnk.Sdk.Common.Utils.Log.LogFileManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/vivalnk/sdk/common/utils/log/LogFileManager;", "")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/vivalnk/sdk/common/utils/log/LogFileManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogFileManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (msg);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message msg)
		{
			if (id_handleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_handleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/os/Message;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (msg);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleMessage_Landroid_os_Message_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMessage", "(Landroid/os/Message;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_init_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_init_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Init_Landroid_content_Context_Ljava_lang_String_);
			return cb_init_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_Init_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_logFileDir)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var logFileDir = JNIEnv.GetString (native_logFileDir, JniHandleOwnership.DoNotTransfer);
			__this.Init (context, logFileDir);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;)V", "GetInit_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context context, string logFileDir)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_logFileDir = JNIEnv.NewString (logFileDir);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_logFileDir);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_logFileDir);
			}
		}

		static Delegate cb_init_Landroid_content_Context_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Ljava_lang_String_IIHandler ()
		{
			if (cb_init_Landroid_content_Context_Ljava_lang_String_II == null)
				cb_init_Landroid_content_Context_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_Init_Landroid_content_Context_Ljava_lang_String_II);
			return cb_init_Landroid_content_Context_Ljava_lang_String_II;
		}

		static void n_Init_Landroid_content_Context_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_logFileDir, int maxFileSize, int maxFileCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var logFileDir = JNIEnv.GetString (native_logFileDir, JniHandleOwnership.DoNotTransfer);
			__this.Init (context, logFileDir, maxFileSize, maxFileCount);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='init' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;II)V", "GetInit_Landroid_content_Context_Ljava_lang_String_IIHandler")]
		public virtual unsafe void Init (global::Android.Content.Context context, string logFileDir, int maxFileSize, int maxFileCount)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_II == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;II)V");
			IntPtr native_logFileDir = JNIEnv.NewString (logFileDir);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_logFileDir);
				__args [2] = new JValue (maxFileSize);
				__args [3] = new JValue (maxFileCount);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Ljava_lang_String_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;Ljava/lang/String;II)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_logFileDir);
			}
		}

		static Delegate cb_init_Landroid_content_Context_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Ljava_lang_String_IIIHandler ()
		{
			if (cb_init_Landroid_content_Context_Ljava_lang_String_III == null)
				cb_init_Landroid_content_Context_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIII_V) n_Init_Landroid_content_Context_Ljava_lang_String_III);
			return cb_init_Landroid_content_Context_Ljava_lang_String_III;
		}

		static void n_Init_Landroid_content_Context_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_logFileDir, int maxFileSize, int maxFileCount, int expire)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var logFileDir = JNIEnv.GetString (native_logFileDir, JniHandleOwnership.DoNotTransfer);
			__this.Init (context, logFileDir, maxFileSize, maxFileCount, expire);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='init' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;III)V", "GetInit_Landroid_content_Context_Ljava_lang_String_IIIHandler")]
		public virtual unsafe void Init (global::Android.Content.Context context, string logFileDir, int maxFileSize, int maxFileCount, int expire)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_III == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_III = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;III)V");
			IntPtr native_logFileDir = JNIEnv.NewString (logFileDir);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_logFileDir);
				__args [2] = new JValue (maxFileSize);
				__args [3] = new JValue (maxFileCount);
				__args [4] = new JValue (expire);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Ljava_lang_String_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;Ljava/lang/String;III)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_logFileDir);
			}
		}

		static Delegate cb_writeLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_;
#pragma warning disable 0169
		static Delegate GetWriteLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_Handler ()
		{
			if (cb_writeLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_ == null)
				cb_writeLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_);
			return cb_writeLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_;
		}

		static void n_WriteLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logMessage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var logMessage = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogInfo> (native_logMessage, JniHandleOwnership.DoNotTransfer);
			__this.WriteLogToFile (logMessage);
		}
#pragma warning restore 0169

		static IntPtr id_writeLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='writeLogToFile' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.utils.log.LogInfo']]"
		[Register ("writeLogToFile", "(Lcom/vivalnk/sdk/common/utils/log/LogInfo;)V", "GetWriteLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_Handler")]
		public virtual unsafe void WriteLogToFile (global::Com.Vivalnk.Sdk.Common.Utils.Log.LogInfo logMessage)
		{
			if (id_writeLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_ == IntPtr.Zero)
				id_writeLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_ = JNIEnv.GetMethodID (class_ref, "writeLogToFile", "(Lcom/vivalnk/sdk/common/utils/log/LogInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (logMessage);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeLogToFile", "(Lcom/vivalnk/sdk/common/utils/log/LogInfo;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeLogToFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteLogToFile_Ljava_lang_String_Handler ()
		{
			if (cb_writeLogToFile_Ljava_lang_String_ == null)
				cb_writeLogToFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteLogToFile_Ljava_lang_String_);
			return cb_writeLogToFile_Ljava_lang_String_;
		}

		static void n_WriteLogToFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logMessage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var logMessage = JNIEnv.GetString (native_logMessage, JniHandleOwnership.DoNotTransfer);
			__this.WriteLogToFile (logMessage);
		}
#pragma warning restore 0169

		static IntPtr id_writeLogToFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='writeLogToFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeLogToFile", "(Ljava/lang/String;)V", "GetWriteLogToFile_Ljava_lang_String_Handler")]
		public virtual unsafe void WriteLogToFile (string logMessage)
		{
			if (id_writeLogToFile_Ljava_lang_String_ == IntPtr.Zero)
				id_writeLogToFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeLogToFile", "(Ljava/lang/String;)V");
			IntPtr native_logMessage = JNIEnv.NewString (logMessage);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_logMessage);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeLogToFile_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeLogToFile", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_logMessage);
			}
		}

	}
}
