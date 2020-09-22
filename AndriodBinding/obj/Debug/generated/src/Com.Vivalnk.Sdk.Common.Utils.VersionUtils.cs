using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='VersionUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/VersionUtils", DoNotGenerateAcw=true)]
	public partial class VersionUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/VersionUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VersionUtils); }
		}

		protected VersionUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='VersionUtils']/constructor[@name='VersionUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VersionUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VersionUtils)) {
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

		static IntPtr id_compareVersion_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='VersionUtils']/method[@name='compareVersion' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("compareVersion", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CompareVersion (string ver1, string ver2)
		{
			if (id_compareVersion_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_compareVersion_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "compareVersion", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_ver1 = JNIEnv.NewString (ver1);
			IntPtr native_ver2 = JNIEnv.NewString (ver2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_ver1);
				__args [1] = new JValue (native_ver2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareVersion_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_ver1);
				JNIEnv.DeleteLocalRef (native_ver2);
			}
		}

	}
}
