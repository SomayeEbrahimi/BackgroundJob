using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/log/LogUtils", DoNotGenerateAcw=true)]
	public partial class LogUtils : global::Java.Lang.Object {


		static IntPtr logLevel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/field[@name='logLevel']"
		[Register ("logLevel")]
		protected static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel LogLevel {
			get {
				if (logLevel_jfieldId == IntPtr.Zero)
					logLevel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logLevel", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, logLevel_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (logLevel_jfieldId == IntPtr.Zero)
					logLevel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logLevel", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, logLevel_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/field[@name='mContext']"
		[Register ("mContext")]
		protected static global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr tag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/field[@name='tag']"
		[Register ("tag")]
		protected static string Tag {
			get {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "tag", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, tag_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "tag", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, tag_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/log/LogUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogUtils); }
		}

		protected LogUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/constructor[@name='LogUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LogUtils)) {
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

		static IntPtr id_alloWriteToFile_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='alloWriteToFile' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("alloWriteToFile", "(Z)V", "")]
		public static unsafe void AlloWriteToFile (bool writeToFile)
		{
			if (id_alloWriteToFile_Z == IntPtr.Zero)
				id_alloWriteToFile_Z = JNIEnv.GetStaticMethodID (class_ref, "alloWriteToFile", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (writeToFile);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_alloWriteToFile_Z, __args);
			} finally {
			}
		}

		static IntPtr id_closeLog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='closeLog' and count(parameter)=0]"
		[Register ("closeLog", "()V", "")]
		public static unsafe void CloseLog ()
		{
			if (id_closeLog == IntPtr.Zero)
				id_closeLog = JNIEnv.GetStaticMethodID (class_ref, "closeLog", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeLog);
			} finally {
			}
		}

		static IntPtr id_d_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='d' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object...']]"
		[Register ("d", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (bool writeToFile, bool printToLogcat, string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_d_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (writeToFile);
				__args [1] = new JValue (printToLogcat);
				__args [2] = new JValue (native_tag);
				__args [3] = new JValue (t);
				__args [4] = new JValue (native_message);
				__args [5] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_d_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string message, params global::Java.Lang.Object[] args)
		{
			if (id_d_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string tag, string message, params global::Java.Lang.Object[] args)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void D (string tag, global::Java.Lang.Throwable t)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='d' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_d_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void D (global::Java.Lang.Throwable t)
		{
			if (id_d_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_d_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (t);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_doLog_ZZLcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='doLog' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='com.vivalnk.sdk.common.utils.log.LogLevel'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("doLog", "(ZZLcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/String;Ljava/lang/String;)V", "")]
		protected static unsafe void DoLog (bool writeToFile, bool printToLogcat, global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel priority, string tag, string message)
		{
			if (id_doLog_ZZLcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_doLog_ZZLcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "doLog", "(ZZLcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (writeToFile);
				__args [1] = new JValue (printToLogcat);
				__args [2] = new JValue (priority);
				__args [3] = new JValue (native_tag);
				__args [4] = new JValue (native_message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_doLog_ZZLcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_e_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='e' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object...']]"
		[Register ("e", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (bool writeToFile, bool printToLogcat, string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_e_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (writeToFile);
				__args [1] = new JValue (printToLogcat);
				__args [2] = new JValue (native_tag);
				__args [3] = new JValue (t);
				__args [4] = new JValue (native_message);
				__args [5] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_e_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string message, params global::Java.Lang.Object[] args)
		{
			if (id_e_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string tag, string message, params global::Java.Lang.Object[] args)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (string tag, global::Java.Lang.Throwable t)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='e' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_e_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (global::Java.Lang.Throwable t)
		{
			if (id_e_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (t);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='formatMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("formatMessage", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "")]
		protected static unsafe string FormatMessage (string message, global::Java.Lang.Object[] args)
		{
			if (id_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "formatMessage", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (native_args);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_getStackTraceString_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='getStackTraceString' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		protected static unsafe string GetStackTraceString (global::Java.Lang.Throwable t)
		{
			if (id_getStackTraceString_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getStackTraceString_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStackTraceString_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_i_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='i' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object...']]"
		[Register ("i", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (bool writeToFile, bool printToLogcat, string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_i_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (writeToFile);
				__args [1] = new JValue (printToLogcat);
				__args [2] = new JValue (native_tag);
				__args [3] = new JValue (t);
				__args [4] = new JValue (native_message);
				__args [5] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_i_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (string message, params global::Java.Lang.Object[] args)
		{
			if (id_i_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (string tag, string message, params global::Java.Lang.Object[] args)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void I (string tag, global::Java.Lang.Throwable t)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='i' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_i_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void I (global::Java.Lang.Throwable t)
		{
			if (id_i_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_i_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_i_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_i_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (t);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		protected static unsafe void Init (global::Android.Content.Context context)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		protected static unsafe void Init (global::Android.Content.Context context, string logDir)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_logDir = JNIEnv.NewString (logDir);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_logDir);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_logDir);
			}
		}

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		protected static unsafe void Init (global::Android.Content.Context context, string tag, string logDir)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_logDir = JNIEnv.NewString (logDir);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_tag);
				__args [2] = new JValue (native_logDir);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_logDir);
			}
		}

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='init' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;II)V", "")]
		protected static unsafe void Init (global::Android.Content.Context context, string tag, string logDir, int maxFileSize, int maxFileCount)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;II)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_logDir = JNIEnv.NewString (logDir);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_tag);
				__args [2] = new JValue (native_logDir);
				__args [3] = new JValue (maxFileSize);
				__args [4] = new JValue (maxFileCount);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_logDir);
			}
		}

		static IntPtr id_internal_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='internal' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object...']]"
		[Register ("internal", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Internal (bool writeToFile, bool printToLogcat, string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_internal_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_internal_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "internal", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (writeToFile);
				__args [1] = new JValue (printToLogcat);
				__args [2] = new JValue (native_tag);
				__args [3] = new JValue (t);
				__args [4] = new JValue (native_message);
				__args [5] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_internal_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_internal_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='internal' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("internal", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Internal (string message, params global::Java.Lang.Object[] args)
		{
			if (id_internal_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_internal_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "internal", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_internal_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_internal_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='internal' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("internal", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Internal (string tag, string message, params global::Java.Lang.Object[] args)
		{
			if (id_internal_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_internal_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "internal", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_internal_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_internal_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='internal' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("internal", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void Internal (string tag, global::Java.Lang.Throwable t)
		{
			if (id_internal_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_internal_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "internal", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_internal_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_internal_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='internal' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("internal", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Internal (string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_internal_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_internal_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "internal", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_internal_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_internal_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='internal' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("internal", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void Internal (global::Java.Lang.Throwable t)
		{
			if (id_internal_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_internal_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "internal", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_internal_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_internal_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='internal' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("internal", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Internal (global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_internal_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_internal_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "internal", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (t);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_internal_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_isLoggable_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='isLoggable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.utils.log.LogLevel']]"
		[Register ("isLoggable", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;)Z", "")]
		protected static unsafe bool IsLoggable (string tag, global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel priority)
		{
			if (id_isLoggable_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_ == IntPtr.Zero)
				id_isLoggable_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_ = JNIEnv.GetStaticMethodID (class_ref, "isLoggable", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;)Z");
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (priority);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLoggable_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_log_ZZLjava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='log' and count(parameter)=7 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.vivalnk.sdk.common.utils.log.LogLevel'] and parameter[5][@type='java.lang.Throwable'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.Object...']]"
		[Register ("log", "(ZZLjava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Log (bool writeToFile, bool printToLogcat, string tag, global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel priority, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_log_ZZLjava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_log_ZZLjava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(ZZLjava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (writeToFile);
				__args [1] = new JValue (printToLogcat);
				__args [2] = new JValue (native_tag);
				__args [3] = new JValue (priority);
				__args [4] = new JValue (t);
				__args [5] = new JValue (native_message);
				__args [6] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_ZZLjava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='log' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.utils.log.LogLevel'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("log", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Log (string tag, global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel priority, string message, params global::Java.Lang.Object[] args)
		{
			if (id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (priority);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='log' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.utils.log.LogLevel'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/Throwable;)V", "")]
		public static unsafe void Log (string tag, global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel priority, global::Java.Lang.Throwable t)
		{
			if (id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/Throwable;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (priority);
				__args [2] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='log' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.utils.log.LogLevel'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object...']]"
		[Register ("log", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Log (string tag, global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel priority, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (priority);
				__args [2] = new JValue (t);
				__args [3] = new JValue (native_message);
				__args [4] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_openLog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='openLog' and count(parameter)=0]"
		[Register ("openLog", "()V", "")]
		public static unsafe void OpenLog ()
		{
			if (id_openLog == IntPtr.Zero)
				id_openLog = JNIEnv.GetStaticMethodID (class_ref, "openLog", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_openLog);
			} finally {
			}
		}

		static IntPtr id_prepareLog_ZZLjava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='prepareLog' and count(parameter)=7 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.vivalnk.sdk.common.utils.log.LogLevel'] and parameter[5][@type='java.lang.Throwable'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.Object...']]"
		[Register ("prepareLog", "(ZZLjava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		protected static unsafe void PrepareLog (bool writeToFile, bool printToLogcat, string tag, global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel priority, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_prepareLog_ZZLjava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_prepareLog_ZZLjava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "prepareLog", "(ZZLjava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (writeToFile);
				__args [1] = new JValue (printToLogcat);
				__args [2] = new JValue (native_tag);
				__args [3] = new JValue (priority);
				__args [4] = new JValue (t);
				__args [5] = new JValue (native_message);
				__args [6] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_prepareLog_ZZLjava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_prepareLog_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='prepareLog' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.utils.log.LogLevel'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object...']]"
		[Register ("prepareLog", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		protected static unsafe void PrepareLog (string tag, global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel priority, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_prepareLog_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_prepareLog_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "prepareLog", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/utils/log/LogLevel;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (priority);
				__args [2] = new JValue (t);
				__args [3] = new JValue (native_message);
				__args [4] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_prepareLog_Ljava_lang_String_Lcom_vivalnk_sdk_common_utils_log_LogLevel_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_printStacktraceString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='printStacktraceString' and count(parameter)=0]"
		[Register ("printStacktraceString", "()V", "")]
		public static unsafe void PrintStacktraceString ()
		{
			if (id_printStacktraceString == IntPtr.Zero)
				id_printStacktraceString = JNIEnv.GetStaticMethodID (class_ref, "printStacktraceString", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printStacktraceString);
			} finally {
			}
		}

		static IntPtr id_printToLogcat_Lcom_vivalnk_sdk_common_utils_log_LogInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='printToLogcat' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.utils.log.LogInfo']]"
		[Register ("printToLogcat", "(Lcom/vivalnk/sdk/common/utils/log/LogInfo;)V", "")]
		protected static unsafe void PrintToLogcat (global::Com.Vivalnk.Sdk.Common.Utils.Log.LogInfo logMessage)
		{
			if (id_printToLogcat_Lcom_vivalnk_sdk_common_utils_log_LogInfo_ == IntPtr.Zero)
				id_printToLogcat_Lcom_vivalnk_sdk_common_utils_log_LogInfo_ = JNIEnv.GetStaticMethodID (class_ref, "printToLogcat", "(Lcom/vivalnk/sdk/common/utils/log/LogInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (logMessage);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printToLogcat_Lcom_vivalnk_sdk_common_utils_log_LogInfo_, __args);
			} finally {
			}
		}

		static IntPtr id_setLogLevel_Lcom_vivalnk_sdk_common_utils_log_LogLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.utils.log.LogLevel']]"
		[Register ("setLogLevel", "(Lcom/vivalnk/sdk/common/utils/log/LogLevel;)V", "")]
		public static unsafe void SetLogLevel (global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel level)
		{
			if (id_setLogLevel_Lcom_vivalnk_sdk_common_utils_log_LogLevel_ == IntPtr.Zero)
				id_setLogLevel_Lcom_vivalnk_sdk_common_utils_log_LogLevel_ = JNIEnv.GetStaticMethodID (class_ref, "setLogLevel", "(Lcom/vivalnk/sdk/common/utils/log/LogLevel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (level);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogLevel_Lcom_vivalnk_sdk_common_utils_log_LogLevel_, __args);
			} finally {
			}
		}

		static IntPtr id_v_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='v' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object...']]"
		[Register ("v", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (bool writeToFile, bool printToLogcat, string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_v_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_v_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (writeToFile);
				__args [1] = new JValue (printToLogcat);
				__args [2] = new JValue (native_tag);
				__args [3] = new JValue (t);
				__args [4] = new JValue (native_message);
				__args [5] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_v_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (string message, params global::Java.Lang.Object[] args)
		{
			if (id_v_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_v_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (string tag, string message, params global::Java.Lang.Object[] args)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void V (string tag, global::Java.Lang.Throwable t)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='v' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_v_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void V (global::Java.Lang.Throwable t)
		{
			if (id_v_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_v_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_v_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_v_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_v_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (t);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_w_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='w' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object...']]"
		[Register ("w", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (bool writeToFile, bool printToLogcat, string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_w_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (writeToFile);
				__args [1] = new JValue (printToLogcat);
				__args [2] = new JValue (native_tag);
				__args [3] = new JValue (t);
				__args [4] = new JValue (native_message);
				__args [5] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_w_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string message, params global::Java.Lang.Object[] args)
		{
			if (id_w_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string tag, string message, params global::Java.Lang.Object[] args)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void W (string tag, global::Java.Lang.Throwable t)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='w' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_w_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void W (global::Java.Lang.Throwable t)
		{
			if (id_w_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_w_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_w_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_w_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (t);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_writeStackTraceString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='writeStackTraceString' and count(parameter)=0]"
		[Register ("writeStackTraceString", "()V", "")]
		public static unsafe void WriteStackTraceString ()
		{
			if (id_writeStackTraceString == IntPtr.Zero)
				id_writeStackTraceString = JNIEnv.GetStaticMethodID (class_ref, "writeStackTraceString", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeStackTraceString);
			} finally {
			}
		}

		static IntPtr id_writeToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='writeToFile' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.utils.log.LogInfo']]"
		[Register ("writeToFile", "(Lcom/vivalnk/sdk/common/utils/log/LogInfo;)V", "")]
		protected static unsafe void WriteToFile (global::Com.Vivalnk.Sdk.Common.Utils.Log.LogInfo logMessage)
		{
			if (id_writeToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_ == IntPtr.Zero)
				id_writeToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_ = JNIEnv.GetStaticMethodID (class_ref, "writeToFile", "(Lcom/vivalnk/sdk/common/utils/log/LogInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (logMessage);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeToFile_Lcom_vivalnk_sdk_common_utils_log_LogInfo_, __args);
			} finally {
			}
		}

		static IntPtr id_wtf_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='wtf' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object...']]"
		[Register ("wtf", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (bool writeToFile, bool printToLogcat, string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_wtf_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_wtf_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(ZZLjava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (writeToFile);
				__args [1] = new JValue (printToLogcat);
				__args [2] = new JValue (native_tag);
				__args [3] = new JValue (t);
				__args [4] = new JValue (native_message);
				__args [5] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_ZZLjava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_wtf_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='wtf' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("wtf", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (string message, params global::Java.Lang.Object[] args)
		{
			if (id_wtf_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_wtf_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_wtf_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='wtf' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("wtf", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (string tag, string message, params global::Java.Lang.Object[] args)
		{
			if (id_wtf_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_wtf_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_wtf_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='wtf' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("wtf", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void Wtf (string tag, global::Java.Lang.Throwable t)
		{
			if (id_wtf_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_wtf_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_wtf_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='wtf' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("wtf", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (string tag, global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_wtf_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_wtf_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (t);
				__args [2] = new JValue (native_message);
				__args [3] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_wtf_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='wtf' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("wtf", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void Wtf (global::Java.Lang.Throwable t)
		{
			if (id_wtf_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_wtf_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogUtils']/method[@name='wtf' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("wtf", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (global::Java.Lang.Throwable t, string message, params global::Java.Lang.Object[] args)
		{
			if (id_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (t);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

	}
}
