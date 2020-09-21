using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/log/LogLevel", DoNotGenerateAcw=true)]
	public sealed partial class LogLevel : global::Java.Lang.Enum {


		static IntPtr ALL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='ALL']"
		[Register ("ALL")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel All {
			get {
				if (ALL_jfieldId == IntPtr.Zero)
					ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ASSERT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='ASSERT']"
		[Register ("ASSERT")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Assert {
			get {
				if (ASSERT_jfieldId == IntPtr.Zero)
					ASSERT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASSERT", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASSERT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEBUG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INFO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='INFO']"
		[Register ("INFO")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Info {
			get {
				if (INFO_jfieldId == IntPtr.Zero)
					INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INFO", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INFO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTERNAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='INTERNAL']"
		[Register ("INTERNAL")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Internal {
			get {
				if (INTERNAL_jfieldId == IntPtr.Zero)
					INTERNAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NOTHING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='NOTHING']"
		[Register ("NOTHING")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Nothing {
			get {
				if (NOTHING_jfieldId == IntPtr.Zero)
					NOTHING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOTHING", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOTHING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VERBOSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='VERBOSE']"
		[Register ("VERBOSE")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Verbose {
			get {
				if (VERBOSE_jfieldId == IntPtr.Zero)
					VERBOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERBOSE", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERBOSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WARN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='WARN']"
		[Register ("WARN")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Warn {
			get {
				if (WARN_jfieldId == IntPtr.Zero)
					WARN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARN", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/log/LogLevel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogLevel); }
		}

		internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_value;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()I", "")]
		public unsafe int Value ()
		{
			if (id_value == IntPtr.Zero)
				id_value = JNIEnv.GetMethodID (class_ref, "value", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_value);
			} finally {
			}
		}

		static IntPtr id_valueOf_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/vivalnk/sdk/common/utils/log/LogLevel;", "")]
		public unsafe global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel ValueOf (int level)
		{
			if (id_valueOf_I == IntPtr.Zero)
				id_valueOf_I = JNIEnv.GetMethodID (class_ref, "valueOf", "(I)Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (level);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/common/utils/log/LogLevel;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vivalnk/sdk/common/utils/log/LogLevel;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
			try {
				return (global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel));
			} finally {
			}
		}

	}
}
