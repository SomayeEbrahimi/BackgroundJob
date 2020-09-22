using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/log/VitalLog", DoNotGenerateAcw=true)]
	public partial class VitalLog : global::Com.Vivalnk.Sdk.Common.Utils.Log.LogUtils {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/log/VitalLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VitalLog); }
		}

		protected VitalLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/constructor[@name='VitalLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VitalLog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VitalLog)) {
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

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context context)
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

		static IntPtr id_printD_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='printD' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("printD", "(Ljava/lang/String;)V", "")]
		public static unsafe void PrintD (string msg)
		{
			if (id_printD_Ljava_lang_String_ == IntPtr.Zero)
				id_printD_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "printD", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printD_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_printE_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='printE' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("printE", "(Ljava/lang/String;)V", "")]
		public static unsafe void PrintE (string msg)
		{
			if (id_printE_Ljava_lang_String_ == IntPtr.Zero)
				id_printE_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "printE", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printE_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_printI_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='printI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("printI", "(Ljava/lang/String;)V", "")]
		public static unsafe void PrintI (string msg)
		{
			if (id_printI_Ljava_lang_String_ == IntPtr.Zero)
				id_printI_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "printI", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printI_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_printV_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='printV' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("printV", "(Ljava/lang/String;)V", "")]
		public static unsafe void PrintV (string msg)
		{
			if (id_printV_Ljava_lang_String_ == IntPtr.Zero)
				id_printV_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "printV", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printV_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_printW_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='printW' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("printW", "(Ljava/lang/String;)V", "")]
		public static unsafe void PrintW (string msg)
		{
			if (id_printW_Ljava_lang_String_ == IntPtr.Zero)
				id_printW_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "printW", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printW_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_printWTF_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='printWTF' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("printWTF", "(Ljava/lang/String;)V", "")]
		public static unsafe void PrintWTF (string msg)
		{
			if (id_printWTF_Ljava_lang_String_ == IntPtr.Zero)
				id_printWTF_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "printWTF", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printWTF_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_writeD_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='writeD' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeD", "(Ljava/lang/String;)V", "")]
		public static unsafe void WriteD (string msg)
		{
			if (id_writeD_Ljava_lang_String_ == IntPtr.Zero)
				id_writeD_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeD", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeD_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_writeE_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='writeE' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeE", "(Ljava/lang/String;)V", "")]
		public static unsafe void WriteE (string msg)
		{
			if (id_writeE_Ljava_lang_String_ == IntPtr.Zero)
				id_writeE_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeE", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeE_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_writeI_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='writeI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeI", "(Ljava/lang/String;)V", "")]
		public static unsafe void WriteI (string msg)
		{
			if (id_writeI_Ljava_lang_String_ == IntPtr.Zero)
				id_writeI_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeI", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeI_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_writeV_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='writeV' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeV", "(Ljava/lang/String;)V", "")]
		public static unsafe void WriteV (string msg)
		{
			if (id_writeV_Ljava_lang_String_ == IntPtr.Zero)
				id_writeV_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeV", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeV_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_writeW_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='writeW' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeW", "(Ljava/lang/String;)V", "")]
		public static unsafe void WriteW (string msg)
		{
			if (id_writeW_Ljava_lang_String_ == IntPtr.Zero)
				id_writeW_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeW", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeW_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_writeWTF_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='VitalLog']/method[@name='writeWTF' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeWTF", "(Ljava/lang/String;)V", "")]
		public static unsafe void WriteWTF (string msg)
		{
			if (id_writeWTF_Ljava_lang_String_ == IntPtr.Zero)
				id_writeWTF_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeWTF", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeWTF_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
