using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='MD5Utils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/MD5Utils", DoNotGenerateAcw=true)]
	public partial class MD5Utils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/MD5Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MD5Utils); }
		}

		protected MD5Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='MD5Utils']/constructor[@name='MD5Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MD5Utils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MD5Utils)) {
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

		static IntPtr id_MD5_12_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='MD5Utils']/method[@name='MD5_12' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("MD5_12", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] MD5_12 (string text)
		{
			if (id_MD5_12_Ljava_lang_String_ == IntPtr.Zero)
				id_MD5_12_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "MD5_12", "(Ljava/lang/String;)[B");
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_text);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_MD5_12_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

	}
}
