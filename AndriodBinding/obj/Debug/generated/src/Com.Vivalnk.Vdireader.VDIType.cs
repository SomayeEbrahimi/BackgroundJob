using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Vdireader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType']"
	[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType", DoNotGenerateAcw=true)]
	public partial class VDIType : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ABNORMAL_TEMPERATURE_STATUS']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS", DoNotGenerateAcw=true)]
		public sealed partial class ABNORMAL_TEMPERATURE_STATUS : global::Java.Lang.Enum {


			static IntPtr LOW_TEMPERATURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ABNORMAL_TEMPERATURE_STATUS']/field[@name='LOW_TEMPERATURE']"
			[Register ("LOW_TEMPERATURE")]
			public static global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS LowTemperature {
				get {
					if (LOW_TEMPERATURE_jfieldId == IntPtr.Zero)
						LOW_TEMPERATURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOW_TEMPERATURE", "Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOW_TEMPERATURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOW_TEMPERATURE_WARMUP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ABNORMAL_TEMPERATURE_STATUS']/field[@name='LOW_TEMPERATURE_WARMUP']"
			[Register ("LOW_TEMPERATURE_WARMUP")]
			public static global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS LowTemperatureWarmup {
				get {
					if (LOW_TEMPERATURE_WARMUP_jfieldId == IntPtr.Zero)
						LOW_TEMPERATURE_WARMUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOW_TEMPERATURE_WARMUP", "Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOW_TEMPERATURE_WARMUP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ABNORMAL_TEMPERATURE_STATUS); }
			}

			internal ABNORMAL_TEMPERATURE_STATUS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ABNORMAL_TEMPERATURE_STATUS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ABNORMAL_TEMPERATURE_STATUS']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;");
				try {
					return (global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHARGER_BATTERY_STATUS']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS", DoNotGenerateAcw=true)]
		public sealed partial class CHARGER_BATTERY_STATUS : global::Java.Lang.Enum {


			static IntPtr LOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHARGER_BATTERY_STATUS']/field[@name='LOW']"
			[Register ("LOW")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS Low {
				get {
					if (LOW_jfieldId == IntPtr.Zero)
						LOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOW", "Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHARGER_BATTERY_STATUS']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS Normal {
				get {
					if (NORMAL_jfieldId == IntPtr.Zero)
						NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CHARGER_BATTERY_STATUS); }
			}

			internal CHARGER_BATTERY_STATUS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHARGER_BATTERY_STATUS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHARGER_BATTERY_STATUS']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;");
				try {
					return (global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class CHECKBLE_STATUS_TYPE : global::Java.Lang.Enum {


			static IntPtr RESULT_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/field[@name='RESULT_OK']"
			[Register ("RESULT_OK")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE ResultOk {
				get {
					if (RESULT_OK_jfieldId == IntPtr.Zero)
						RESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_OK", "Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESULT_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SYSTEM_BLE_NOT_ENABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/field[@name='SYSTEM_BLE_NOT_ENABLED']"
			[Register ("SYSTEM_BLE_NOT_ENABLED")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE SystemBleNotEnabled {
				get {
					if (SYSTEM_BLE_NOT_ENABLED_jfieldId == IntPtr.Zero)
						SYSTEM_BLE_NOT_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYSTEM_BLE_NOT_ENABLED", "Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYSTEM_BLE_NOT_ENABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SYSTEM_LOCATION_NOT_ENABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/field[@name='SYSTEM_LOCATION_NOT_ENABLED']"
			[Register ("SYSTEM_LOCATION_NOT_ENABLED")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE SystemLocationNotEnabled {
				get {
					if (SYSTEM_LOCATION_NOT_ENABLED_jfieldId == IntPtr.Zero)
						SYSTEM_LOCATION_NOT_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYSTEM_LOCATION_NOT_ENABLED", "Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYSTEM_LOCATION_NOT_ENABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SYSTEM_NOT_SUPPORT_BLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/field[@name='SYSTEM_NOT_SUPPORT_BLE']"
			[Register ("SYSTEM_NOT_SUPPORT_BLE")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE SystemNotSupportBle {
				get {
					if (SYSTEM_NOT_SUPPORT_BLE_jfieldId == IntPtr.Zero)
						SYSTEM_NOT_SUPPORT_BLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYSTEM_NOT_SUPPORT_BLE", "Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYSTEM_NOT_SUPPORT_BLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CHECKBLE_STATUS_TYPE); }
			}

			internal CHECKBLE_STATUS_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;");
				try {
					return (global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.DEVICE_TYPE']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$DEVICE_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class DEVICE_TYPE : global::Java.Lang.Enum {


			static IntPtr ENCRYPTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.DEVICE_TYPE']/field[@name='ENCRYPTED']"
			[Register ("ENCRYPTED")]
			public static global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE Encrypted {
				get {
					if (ENCRYPTED_jfieldId == IntPtr.Zero)
						ENCRYPTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENCRYPTED", "Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENCRYPTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.DEVICE_TYPE']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE Normal {
				get {
					if (NORMAL_jfieldId == IntPtr.Zero)
						NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/vdireader/VDIType$DEVICE_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DEVICE_TYPE); }
			}

			internal DEVICE_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.DEVICE_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.DEVICE_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;");
				try {
					return (global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ENCRYPTED_DEVICE_TYPE']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class ENCRYPTED_DEVICE_TYPE : global::Java.Lang.Enum {


			static IntPtr EIGHT_SECONDS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ENCRYPTED_DEVICE_TYPE']/field[@name='EIGHT_SECONDS']"
			[Register ("EIGHT_SECONDS")]
			public static global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE EightSeconds {
				get {
					if (EIGHT_SECONDS_jfieldId == IntPtr.Zero)
						EIGHT_SECONDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIGHT_SECONDS", "Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIGHT_SECONDS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FOUR_SECONDS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ENCRYPTED_DEVICE_TYPE']/field[@name='FOUR_SECONDS']"
			[Register ("FOUR_SECONDS")]
			public static global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE FourSeconds {
				get {
					if (FOUR_SECONDS_jfieldId == IntPtr.Zero)
						FOUR_SECONDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FOUR_SECONDS", "Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FOUR_SECONDS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ENCRYPTED_DEVICE_TYPE); }
			}

			internal ENCRYPTED_DEVICE_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ENCRYPTED_DEVICE_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ENCRYPTED_DEVICE_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;");
				try {
					return (global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.TEMPERATURE_STATUS']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS", DoNotGenerateAcw=true)]
		public sealed partial class TEMPERATURE_STATUS : global::Java.Lang.Enum {


			static IntPtr NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.TEMPERATURE_STATUS']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS Normal {
				get {
					if (NORMAL_jfieldId == IntPtr.Zero)
						NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WARMUP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.TEMPERATURE_STATUS']/field[@name='WARMUP']"
			[Register ("WARMUP")]
			public static global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS Warmup {
				get {
					if (WARMUP_jfieldId == IntPtr.Zero)
						WARMUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARMUP", "Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARMUP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TEMPERATURE_STATUS); }
			}

			internal TEMPERATURE_STATUS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.TEMPERATURE_STATUS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.TEMPERATURE_STATUS']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;");
				try {
					return (global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/vdireader/VDIType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VDIType); }
		}

		protected VDIType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType']/constructor[@name='VDIType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VDIType ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VDIType)) {
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

	}
}
