using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='CharUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/CharUtils", DoNotGenerateAcw=true)]
	public partial class CharUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/CharUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharUtils); }
		}

		protected CharUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='CharUtils']/constructor[@name='CharUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CharUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CharUtils)) {
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

		static IntPtr id_isASCII_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='CharUtils']/method[@name='isASCII' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("isASCII", "(C)Z", "")]
		public static unsafe bool IsASCII (char c)
		{
			if (id_isASCII_C == IntPtr.Zero)
				id_isASCII_C = JNIEnv.GetStaticMethodID (class_ref, "isASCII", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (c);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isASCII_C, __args);
			} finally {
			}
		}

		static IntPtr id_isASCIIString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='CharUtils']/method[@name='isASCIIString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isASCIIString", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsASCIIString (string str)
		{
			if (id_isASCIIString_Ljava_lang_String_ == IntPtr.Zero)
				id_isASCIIString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isASCIIString", "(Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isASCIIString_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

	}
}
