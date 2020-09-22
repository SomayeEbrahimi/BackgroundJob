using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='SystemUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/utils/SystemUtils", DoNotGenerateAcw=true)]
	public partial class SystemUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/utils/SystemUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SystemUtils); }
		}

		protected SystemUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='SystemUtils']/constructor[@name='SystemUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SystemUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SystemUtils)) {
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

		static IntPtr id_getDeviceBrand;
		public static unsafe string DeviceBrand {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='SystemUtils']/method[@name='getDeviceBrand' and count(parameter)=0]"
			[Register ("getDeviceBrand", "()Ljava/lang/String;", "")]
			get {
				if (id_getDeviceBrand == IntPtr.Zero)
					id_getDeviceBrand = JNIEnv.GetStaticMethodID (class_ref, "getDeviceBrand", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceBrand), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSystemLanguage;
		public static unsafe string SystemLanguage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='SystemUtils']/method[@name='getSystemLanguage' and count(parameter)=0]"
			[Register ("getSystemLanguage", "()Ljava/lang/String;", "")]
			get {
				if (id_getSystemLanguage == IntPtr.Zero)
					id_getSystemLanguage = JNIEnv.GetStaticMethodID (class_ref, "getSystemLanguage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSystemLanguage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSystemModel;
		public static unsafe string SystemModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='SystemUtils']/method[@name='getSystemModel' and count(parameter)=0]"
			[Register ("getSystemModel", "()Ljava/lang/String;", "")]
			get {
				if (id_getSystemModel == IntPtr.Zero)
					id_getSystemModel = JNIEnv.GetStaticMethodID (class_ref, "getSystemModel", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSystemModel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSystemVersion;
		public static unsafe string SystemVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='SystemUtils']/method[@name='getSystemVersion' and count(parameter)=0]"
			[Register ("getSystemVersion", "()Ljava/lang/String;", "")]
			get {
				if (id_getSystemVersion == IntPtr.Zero)
					id_getSystemVersion = JNIEnv.GetStaticMethodID (class_ref, "getSystemVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSystemVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSystemLanguageList;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.utils']/class[@name='SystemUtils']/method[@name='getSystemLanguageList' and count(parameter)=0]"
		[Register ("getSystemLanguageList", "()[Ljava/util/Locale;", "")]
		public static unsafe global::Java.Util.Locale[] GetSystemLanguageList ()
		{
			if (id_getSystemLanguageList == IntPtr.Zero)
				id_getSystemLanguageList = JNIEnv.GetStaticMethodID (class_ref, "getSystemLanguageList", "()[Ljava/util/Locale;");
			try {
				return (global::Java.Util.Locale[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSystemLanguageList), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Util.Locale));
			} finally {
			}
		}

	}
}
