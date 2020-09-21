using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='OTAEvent']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/event/OTAEvent", DoNotGenerateAcw=true)]
	public partial class OTAEvent : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='OTAEvent']/field[@name='OTA_CANCEL']"
		[Register ("OTA_CANCEL")]
		public const string OtaCancel = (string) "OTA_CANCEL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='OTAEvent']/field[@name='OTA_COMPLETE']"
		[Register ("OTA_COMPLETE")]
		public const string OtaComplete = (string) "OTA_COMPLETE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='OTAEvent']/field[@name='OTA_ERROR']"
		[Register ("OTA_ERROR")]
		public const string OtaError = (string) "OTA_ERROR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='OTAEvent']/field[@name='OTA_START']"
		[Register ("OTA_START")]
		public const string OtaStart = (string) "OTA_START";

		static IntPtr event_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='OTAEvent']/field[@name='event']"
		[Register ("event")]
		public string Event {
			get {
				if (event_jfieldId == IntPtr.Zero)
					event_jfieldId = JNIEnv.GetFieldID (class_ref, "event", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, event_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (event_jfieldId == IntPtr.Zero)
					event_jfieldId = JNIEnv.GetFieldID (class_ref, "event", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, event_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mac_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='OTAEvent']/field[@name='mac']"
		[Register ("mac")]
		public string Mac {
			get {
				if (mac_jfieldId == IntPtr.Zero)
					mac_jfieldId = JNIEnv.GetFieldID (class_ref, "mac", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mac_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mac_jfieldId == IntPtr.Zero)
					mac_jfieldId = JNIEnv.GetFieldID (class_ref, "mac", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mac_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr time_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='OTAEvent']/field[@name='time']"
		[Register ("time")]
		public long Time {
			get {
				if (time_jfieldId == IntPtr.Zero)
					time_jfieldId = JNIEnv.GetFieldID (class_ref, "time", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, time_jfieldId);
			}
			set {
				if (time_jfieldId == IntPtr.Zero)
					time_jfieldId = JNIEnv.GetFieldID (class_ref, "time", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, time_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/event/OTAEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OTAEvent); }
		}

		protected OTAEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='OTAEvent']/constructor[@name='OTAEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OTAEvent (string mac, string e)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_e = JNIEnv.NewString (e);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (native_e);
				if (((object) this).GetType () != typeof (OTAEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

	}
}
