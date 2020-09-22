using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/ThreadMode", DoNotGenerateAcw=true)]
	public sealed partial class ThreadMode : global::Java.Lang.Enum {


		static IntPtr ASYNC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/field[@name='ASYNC']"
		[Register ("ASYNC")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode Async {
			get {
				if (ASYNC_jfieldId == IntPtr.Zero)
					ASYNC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASYNC", "Lcom/vivalnk/sdk/common/eventbus/ThreadMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASYNC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BACKGROUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/field[@name='BACKGROUND']"
		[Register ("BACKGROUND")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode Background {
			get {
				if (BACKGROUND_jfieldId == IntPtr.Zero)
					BACKGROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKGROUND", "Lcom/vivalnk/sdk/common/eventbus/ThreadMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BACKGROUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MAIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/field[@name='MAIN']"
		[Register ("MAIN")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode Main {
			get {
				if (MAIN_jfieldId == IntPtr.Zero)
					MAIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAIN", "Lcom/vivalnk/sdk/common/eventbus/ThreadMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MAIN_ORDERED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/field[@name='MAIN_ORDERED']"
		[Register ("MAIN_ORDERED")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode MainOrdered {
			get {
				if (MAIN_ORDERED_jfieldId == IntPtr.Zero)
					MAIN_ORDERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAIN_ORDERED", "Lcom/vivalnk/sdk/common/eventbus/ThreadMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAIN_ORDERED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr POSTING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/field[@name='POSTING']"
		[Register ("POSTING")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode Posting {
			get {
				if (POSTING_jfieldId == IntPtr.Zero)
					POSTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POSTING", "Lcom/vivalnk/sdk/common/eventbus/ThreadMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POSTING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/ThreadMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadMode); }
		}

		internal ThreadMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/common/eventbus/ThreadMode;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/common/eventbus/ThreadMode;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vivalnk/sdk/common/eventbus/ThreadMode;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vivalnk/sdk/common/eventbus/ThreadMode;");
			try {
				return (global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode));
			} finally {
			}
		}

	}
}
