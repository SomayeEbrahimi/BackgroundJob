using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/log/LogFileManager", DoNotGenerateAcw=true)]
	public partial class LogFileManager : global::Java.Lang.Object, global::Android.OS.Handler.ICallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/log/LogFileManager", typeof (LogFileManager));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected LogFileManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Vivalnk.Sdk.Common.Utils.Log.LogFileManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/vivalnk/sdk/common/utils/log/LogFileManager;", "")]
			get {
				const string __id = "getInstance.()Lcom/vivalnk/sdk/common/utils/log/LogFileManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogFileManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message msg)
		{
			const string __id = "handleMessage.(Landroid/os/Message;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;)V", "GetInit_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context context, string logFileDir)
		{
			const string __id = "init.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_logFileDir = JNIEnv.NewString (logFileDir);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_logFileDir);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='init' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;II)V", "GetInit_Landroid_content_Context_Ljava_lang_String_IIHandler")]
		public virtual unsafe void Init (global::Android.Content.Context context, string logFileDir, int maxFileSize, int maxFileCount)
		{
			const string __id = "init.(Landroid/content/Context;Ljava/lang/String;II)V";
			IntPtr native_logFileDir = JNIEnv.NewString (logFileDir);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_logFileDir);
				__args [2] = new JniArgumentValue (maxFileSize);
				__args [3] = new JniArgumentValue (maxFileCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='init' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;III)V", "GetInit_Landroid_content_Context_Ljava_lang_String_IIIHandler")]
		public virtual unsafe void Init (global::Android.Content.Context context, string logFileDir, int maxFileSize, int maxFileCount, int expire)
		{
			const string __id = "init.(Landroid/content/Context;Ljava/lang/String;III)V";
			IntPtr native_logFileDir = JNIEnv.NewString (logFileDir);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_logFileDir);
				__args [2] = new JniArgumentValue (maxFileSize);
				__args [3] = new JniArgumentValue (maxFileCount);
				__args [4] = new JniArgumentValue (expire);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='writeLogToFile' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.utils.log.LogInfo']]"
		[Register ("writeLogToFile", "(Lcom/vivalnk/sdk/common/utils/log/LogInfo;)V", "GetWriteLogToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_Handler")]
		public virtual unsafe void WriteLogToFile (global::Com.Vivalnk.Sdk.Common.Utils.Log.LogInfo logMessage)
		{
			const string __id = "writeLogToFile.(Lcom/vivalnk/sdk/common/utils/log/LogInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logMessage).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogFileManager']/method[@name='writeLogToFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeLogToFile", "(Ljava/lang/String;)V", "GetWriteLogToFile_Ljava_lang_String_Handler")]
		public virtual unsafe void WriteLogToFile (string logMessage)
		{
			const string __id = "writeLogToFile.(Ljava/lang/String;)V";
			IntPtr native_logMessage = JNIEnv.NewString (logMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_logMessage);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_logMessage);
			}
		}

	}
}
