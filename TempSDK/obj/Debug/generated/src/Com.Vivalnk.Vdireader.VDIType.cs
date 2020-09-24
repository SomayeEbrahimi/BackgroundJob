using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Vdireader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType']"
	[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType", DoNotGenerateAcw=true)]
	public partial class VDIType : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ABNORMAL_TEMPERATURE_STATUS']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS", DoNotGenerateAcw=true)]
		public sealed partial class ABNORMAL_TEMPERATURE_STATUS : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ABNORMAL_TEMPERATURE_STATUS']/field[@name='LOW_TEMPERATURE']"
			[Register ("LOW_TEMPERATURE")]
			public static global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS LowTemperature {
				get {
					const string __id = "LOW_TEMPERATURE.Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ABNORMAL_TEMPERATURE_STATUS']/field[@name='LOW_TEMPERATURE_WARMUP']"
			[Register ("LOW_TEMPERATURE_WARMUP")]
			public static global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS LowTemperatureWarmup {
				get {
					const string __id = "LOW_TEMPERATURE_WARMUP.Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS", typeof (ABNORMAL_TEMPERATURE_STATUS));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal ABNORMAL_TEMPERATURE_STATUS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ABNORMAL_TEMPERATURE_STATUS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ABNORMAL_TEMPERATURE_STATUS']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS[] Values ()
			{
				const string __id = "values.()[Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHARGER_BATTERY_STATUS']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS", DoNotGenerateAcw=true)]
		public sealed partial class CHARGER_BATTERY_STATUS : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHARGER_BATTERY_STATUS']/field[@name='LOW']"
			[Register ("LOW")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS Low {
				get {
					const string __id = "LOW.Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHARGER_BATTERY_STATUS']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS Normal {
				get {
					const string __id = "NORMAL.Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS", typeof (CHARGER_BATTERY_STATUS));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal CHARGER_BATTERY_STATUS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHARGER_BATTERY_STATUS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHARGER_BATTERY_STATUS']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS[] Values ()
			{
				const string __id = "values.()[Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class CHECKBLE_STATUS_TYPE : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/field[@name='RESULT_OK']"
			[Register ("RESULT_OK")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE ResultOk {
				get {
					const string __id = "RESULT_OK.Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/field[@name='SYSTEM_BLE_NOT_ENABLED']"
			[Register ("SYSTEM_BLE_NOT_ENABLED")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE SystemBleNotEnabled {
				get {
					const string __id = "SYSTEM_BLE_NOT_ENABLED.Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/field[@name='SYSTEM_LOCATION_NOT_ENABLED']"
			[Register ("SYSTEM_LOCATION_NOT_ENABLED")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE SystemLocationNotEnabled {
				get {
					const string __id = "SYSTEM_LOCATION_NOT_ENABLED.Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/field[@name='SYSTEM_NOT_SUPPORT_BLE']"
			[Register ("SYSTEM_NOT_SUPPORT_BLE")]
			public static global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE SystemNotSupportBle {
				get {
					const string __id = "SYSTEM_NOT_SUPPORT_BLE.Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE", typeof (CHECKBLE_STATUS_TYPE));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal CHECKBLE_STATUS_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.CHECKBLE_STATUS_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE[] Values ()
			{
				const string __id = "values.()[Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.DEVICE_TYPE']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$DEVICE_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class DEVICE_TYPE : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.DEVICE_TYPE']/field[@name='ENCRYPTED']"
			[Register ("ENCRYPTED")]
			public static global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE Encrypted {
				get {
					const string __id = "ENCRYPTED.Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.DEVICE_TYPE']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE Normal {
				get {
					const string __id = "NORMAL.Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireader/VDIType$DEVICE_TYPE", typeof (DEVICE_TYPE));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal DEVICE_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.DEVICE_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.DEVICE_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE[] Values ()
			{
				const string __id = "values.()[Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ENCRYPTED_DEVICE_TYPE']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class ENCRYPTED_DEVICE_TYPE : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ENCRYPTED_DEVICE_TYPE']/field[@name='EIGHT_SECONDS']"
			[Register ("EIGHT_SECONDS")]
			public static global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE EightSeconds {
				get {
					const string __id = "EIGHT_SECONDS.Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ENCRYPTED_DEVICE_TYPE']/field[@name='FOUR_SECONDS']"
			[Register ("FOUR_SECONDS")]
			public static global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE FourSeconds {
				get {
					const string __id = "FOUR_SECONDS.Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE", typeof (ENCRYPTED_DEVICE_TYPE));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal ENCRYPTED_DEVICE_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ENCRYPTED_DEVICE_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.ENCRYPTED_DEVICE_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE[] Values ()
			{
				const string __id = "values.()[Lcom/vivalnk/vdireader/VDIType$ENCRYPTED_DEVICE_TYPE;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.ENCRYPTED_DEVICE_TYPE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.TEMPERATURE_STATUS']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS", DoNotGenerateAcw=true)]
		public sealed partial class TEMPERATURE_STATUS : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.TEMPERATURE_STATUS']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS Normal {
				get {
					const string __id = "NORMAL.Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.TEMPERATURE_STATUS']/field[@name='WARMUP']"
			[Register ("WARMUP")]
			public static global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS Warmup {
				get {
					const string __id = "WARMUP.Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS", typeof (TEMPERATURE_STATUS));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal TEMPERATURE_STATUS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.TEMPERATURE_STATUS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType.TEMPERATURE_STATUS']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;", "")]
			public static unsafe global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS[] Values ()
			{
				const string __id = "values.()[Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireader/VDIType", typeof (VDIType));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected VDIType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireader']/class[@name='VDIType']/constructor[@name='VDIType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VDIType ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
