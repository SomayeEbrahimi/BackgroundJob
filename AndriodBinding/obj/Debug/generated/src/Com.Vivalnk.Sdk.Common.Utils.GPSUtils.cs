using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='GPSUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/GPSUtils", DoNotGenerateAcw=true)]
	public partial class GPSUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/GPSUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPSUtils); }
		}

		protected GPSUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='GPSUtils']/constructor[@name='GPSUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPSUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPSUtils)) {
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

		static IntPtr id_isGPSEnable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='GPSUtils']/method[@name='isGPSEnable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("isGPSEnable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsGPSEnable (global::Android.Content.Context context)
		{
			if (id_isGPSEnable_Landroid_content_Context_ == IntPtr.Zero)
				id_isGPSEnable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isGPSEnable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isGPSEnable_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isLocationEnabled_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='GPSUtils']/method[@name='isLocationEnabled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isLocationEnabled", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsLocationEnabled (global::Android.Content.Context context)
		{
			if (id_isLocationEnabled_Landroid_content_Context_ == IntPtr.Zero)
				id_isLocationEnabled_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isLocationEnabled", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLocationEnabled_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
