using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Excutors {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/excutors/LooperType", DoNotGenerateAcw=true)]
	public sealed partial class LooperType : global::Java.Lang.Enum {


		static IntPtr COMMAND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/field[@name='COMMAND']"
		[Register ("COMMAND")]
		public static global::Com.Vivalnk.Sdk.Common.Excutors.LooperType Command {
			get {
				if (COMMAND_jfieldId == IntPtr.Zero)
					COMMAND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMMAND", "Lcom/vivalnk/sdk/common/excutors/LooperType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMMAND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Excutors.LooperType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/field[@name='DATA']"
		[Register ("DATA")]
		public static global::Com.Vivalnk.Sdk.Common.Excutors.LooperType Data {
			get {
				if (DATA_jfieldId == IntPtr.Zero)
					DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA", "Lcom/vivalnk/sdk/common/excutors/LooperType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Excutors.LooperType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/field[@name='IO']"
		[Register ("IO")]
		public static global::Com.Vivalnk.Sdk.Common.Excutors.LooperType Io {
			get {
				if (IO_jfieldId == IntPtr.Zero)
					IO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IO", "Lcom/vivalnk/sdk/common/excutors/LooperType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Excutors.LooperType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/field[@name='LOG']"
		[Register ("LOG")]
		public static global::Com.Vivalnk.Sdk.Common.Excutors.LooperType Log {
			get {
				if (LOG_jfieldId == IntPtr.Zero)
					LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG", "Lcom/vivalnk/sdk/common/excutors/LooperType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Excutors.LooperType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/excutors/LooperType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LooperType); }
		}

		internal LooperType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/common/excutors/LooperType;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Excutors.LooperType ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/common/excutors/LooperType;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Vivalnk.Sdk.Common.Excutors.LooperType __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Excutors.LooperType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vivalnk/sdk/common/excutors/LooperType;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Excutors.LooperType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vivalnk/sdk/common/excutors/LooperType;");
			try {
				return (global::Com.Vivalnk.Sdk.Common.Excutors.LooperType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Excutors.LooperType));
			} finally {
			}
		}

	}
}
