using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Android.Support.V18.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']"
	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanSettings", DoNotGenerateAcw=true)]
	public sealed partial class ScanSettings : global::Java.Lang.Object, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='CALLBACK_TYPE_ALL_MATCHES']"
		[Register ("CALLBACK_TYPE_ALL_MATCHES")]
		public const int CallbackTypeAllMatches = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='CALLBACK_TYPE_FIRST_MATCH']"
		[Register ("CALLBACK_TYPE_FIRST_MATCH")]
		public const int CallbackTypeFirstMatch = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='CALLBACK_TYPE_MATCH_LOST']"
		[Register ("CALLBACK_TYPE_MATCH_LOST")]
		public const int CallbackTypeMatchLost = (int) 4;

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='MATCH_LOST_DEVICE_TIMEOUT_DEFAULT']"
		[Register ("MATCH_LOST_DEVICE_TIMEOUT_DEFAULT")]
		public const long MatchLostDeviceTimeoutDefault = (long) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='MATCH_LOST_TASK_INTERVAL_DEFAULT']"
		[Register ("MATCH_LOST_TASK_INTERVAL_DEFAULT")]
		public const long MatchLostTaskIntervalDefault = (long) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='MATCH_MODE_AGGRESSIVE']"
		[Register ("MATCH_MODE_AGGRESSIVE")]
		public const int MatchModeAggressive = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='MATCH_MODE_STICKY']"
		[Register ("MATCH_MODE_STICKY")]
		public const int MatchModeSticky = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='MATCH_NUM_FEW_ADVERTISEMENT']"
		[Register ("MATCH_NUM_FEW_ADVERTISEMENT")]
		public const int MatchNumFewAdvertisement = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='MATCH_NUM_MAX_ADVERTISEMENT']"
		[Register ("MATCH_NUM_MAX_ADVERTISEMENT")]
		public const int MatchNumMaxAdvertisement = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='MATCH_NUM_ONE_ADVERTISEMENT']"
		[Register ("MATCH_NUM_ONE_ADVERTISEMENT")]
		public const int MatchNumOneAdvertisement = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='PHY_LE_ALL_SUPPORTED']"
		[Register ("PHY_LE_ALL_SUPPORTED")]
		public const int PhyLeAllSupported = (int) 255;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='SCAN_MODE_BALANCED']"
		[Register ("SCAN_MODE_BALANCED")]
		public const int ScanModeBalanced = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='SCAN_MODE_LOW_LATENCY']"
		[Register ("SCAN_MODE_LOW_LATENCY")]
		public const int ScanModeLowLatency = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='SCAN_MODE_LOW_POWER']"
		[Register ("SCAN_MODE_LOW_POWER")]
		public const int ScanModeLowPower = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='SCAN_MODE_OPPORTUNISTIC']"
		[Register ("SCAN_MODE_OPPORTUNISTIC")]
		public const int ScanModeOpportunistic = (int) -1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']"
		[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanSettings$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/android/support/v18/scanner/ScanSettings$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/constructor[@name='ScanSettings.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/vivalnk/android/support/v18/scanner/ScanSettings;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/vivalnk/android/support/v18/scanner/ScanSettings;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setCallbackType_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setCallbackType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCallbackType", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetCallbackType (int callbackType)
			{
				if (id_setCallbackType_I == IntPtr.Zero)
					id_setCallbackType_I = JNIEnv.GetMethodID (class_ref, "setCallbackType", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (callbackType);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCallbackType_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setLegacy_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setLegacy' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLegacy", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetLegacy (bool legacy)
			{
				if (id_setLegacy_Z == IntPtr.Zero)
					id_setLegacy_Z = JNIEnv.GetMethodID (class_ref, "setLegacy", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (legacy);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLegacy_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setMatchMode_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setMatchMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMatchMode", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetMatchMode (int matchMode)
			{
				if (id_setMatchMode_I == IntPtr.Zero)
					id_setMatchMode_I = JNIEnv.GetMethodID (class_ref, "setMatchMode", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (matchMode);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMatchMode_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setMatchOptions_JJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setMatchOptions' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("setMatchOptions", "(JJ)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetMatchOptions (long deviceTimeoutMillis, long taskIntervalMillis)
			{
				if (id_setMatchOptions_JJ == IntPtr.Zero)
					id_setMatchOptions_JJ = JNIEnv.GetMethodID (class_ref, "setMatchOptions", "(JJ)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (deviceTimeoutMillis);
					__args [1] = new JValue (taskIntervalMillis);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMatchOptions_JJ, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setNumOfMatches_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setNumOfMatches' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumOfMatches", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetNumOfMatches (int numOfMatches)
			{
				if (id_setNumOfMatches_I == IntPtr.Zero)
					id_setNumOfMatches_I = JNIEnv.GetMethodID (class_ref, "setNumOfMatches", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (numOfMatches);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNumOfMatches_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setPhy_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setPhy' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPhy", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetPhy (int phy)
			{
				if (id_setPhy_I == IntPtr.Zero)
					id_setPhy_I = JNIEnv.GetMethodID (class_ref, "setPhy", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (phy);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPhy_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setPowerSave_JJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setPowerSave' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("setPowerSave", "(JJ)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetPowerSave (long scanInterval, long restInterval)
			{
				if (id_setPowerSave_JJ == IntPtr.Zero)
					id_setPowerSave_JJ = JNIEnv.GetMethodID (class_ref, "setPowerSave", "(JJ)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (scanInterval);
					__args [1] = new JValue (restInterval);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPowerSave_JJ, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setReportDelay_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setReportDelay' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setReportDelay", "(J)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetReportDelay (long reportDelayMillis)
			{
				if (id_setReportDelay_J == IntPtr.Zero)
					id_setReportDelay_J = JNIEnv.GetMethodID (class_ref, "setReportDelay", "(J)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (reportDelayMillis);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReportDelay_J, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setScanMode_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setScanMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScanMode", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetScanMode (int scanMode)
			{
				if (id_setScanMode_I == IntPtr.Zero)
					id_setScanMode_I = JNIEnv.GetMethodID (class_ref, "setScanMode", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (scanMode);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setScanMode_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setScanResultType_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setScanResultType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScanResultType", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetScanResultType (int scanResultType)
			{
				if (id_setScanResultType_I == IntPtr.Zero)
					id_setScanResultType_I = JNIEnv.GetMethodID (class_ref, "setScanResultType", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (scanResultType);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setScanResultType_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setUseHardwareBatchingIfSupported_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setUseHardwareBatchingIfSupported' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseHardwareBatchingIfSupported", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetUseHardwareBatchingIfSupported (bool use)
			{
				if (id_setUseHardwareBatchingIfSupported_Z == IntPtr.Zero)
					id_setUseHardwareBatchingIfSupported_Z = JNIEnv.GetMethodID (class_ref, "setUseHardwareBatchingIfSupported", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (use);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUseHardwareBatchingIfSupported_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setUseHardwareCallbackTypesIfSupported_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setUseHardwareCallbackTypesIfSupported' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseHardwareCallbackTypesIfSupported", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetUseHardwareCallbackTypesIfSupported (bool use)
			{
				if (id_setUseHardwareCallbackTypesIfSupported_Z == IntPtr.Zero)
					id_setUseHardwareCallbackTypesIfSupported_Z = JNIEnv.GetMethodID (class_ref, "setUseHardwareCallbackTypesIfSupported", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (use);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUseHardwareCallbackTypesIfSupported_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setUseHardwareFilteringIfSupported_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setUseHardwareFilteringIfSupported' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseHardwareFilteringIfSupported", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetUseHardwareFilteringIfSupported (bool use)
			{
				if (id_setUseHardwareFilteringIfSupported_Z == IntPtr.Zero)
					id_setUseHardwareFilteringIfSupported_Z = JNIEnv.GetMethodID (class_ref, "setUseHardwareFilteringIfSupported", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (use);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUseHardwareFilteringIfSupported_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/android/support/v18/scanner/ScanSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScanSettings); }
		}

		internal ScanSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCallbackType;
		public unsafe int CallbackType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getCallbackType' and count(parameter)=0]"
			[Register ("getCallbackType", "()I", "")]
			get {
				if (id_getCallbackType == IntPtr.Zero)
					id_getCallbackType = JNIEnv.GetMethodID (class_ref, "getCallbackType", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCallbackType);
				} finally {
				}
			}
		}

		static IntPtr id_hasPowerSaveMode;
		public unsafe bool HasPowerSaveMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='hasPowerSaveMode' and count(parameter)=0]"
			[Register ("hasPowerSaveMode", "()Z", "")]
			get {
				if (id_hasPowerSaveMode == IntPtr.Zero)
					id_hasPowerSaveMode = JNIEnv.GetMethodID (class_ref, "hasPowerSaveMode", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasPowerSaveMode);
				} finally {
				}
			}
		}

		static IntPtr id_getLegacy;
		public unsafe bool Legacy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getLegacy' and count(parameter)=0]"
			[Register ("getLegacy", "()Z", "")]
			get {
				if (id_getLegacy == IntPtr.Zero)
					id_getLegacy = JNIEnv.GetMethodID (class_ref, "getLegacy", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getLegacy);
				} finally {
				}
			}
		}

		static IntPtr id_getMatchLostDeviceTimeout;
		public unsafe long MatchLostDeviceTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getMatchLostDeviceTimeout' and count(parameter)=0]"
			[Register ("getMatchLostDeviceTimeout", "()J", "")]
			get {
				if (id_getMatchLostDeviceTimeout == IntPtr.Zero)
					id_getMatchLostDeviceTimeout = JNIEnv.GetMethodID (class_ref, "getMatchLostDeviceTimeout", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMatchLostDeviceTimeout);
				} finally {
				}
			}
		}

		static IntPtr id_getMatchLostTaskInterval;
		public unsafe long MatchLostTaskInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getMatchLostTaskInterval' and count(parameter)=0]"
			[Register ("getMatchLostTaskInterval", "()J", "")]
			get {
				if (id_getMatchLostTaskInterval == IntPtr.Zero)
					id_getMatchLostTaskInterval = JNIEnv.GetMethodID (class_ref, "getMatchLostTaskInterval", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMatchLostTaskInterval);
				} finally {
				}
			}
		}

		static IntPtr id_getMatchMode;
		public unsafe int MatchMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getMatchMode' and count(parameter)=0]"
			[Register ("getMatchMode", "()I", "")]
			get {
				if (id_getMatchMode == IntPtr.Zero)
					id_getMatchMode = JNIEnv.GetMethodID (class_ref, "getMatchMode", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMatchMode);
				} finally {
				}
			}
		}

		static IntPtr id_getNumOfMatches;
		public unsafe int NumOfMatches {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getNumOfMatches' and count(parameter)=0]"
			[Register ("getNumOfMatches", "()I", "")]
			get {
				if (id_getNumOfMatches == IntPtr.Zero)
					id_getNumOfMatches = JNIEnv.GetMethodID (class_ref, "getNumOfMatches", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumOfMatches);
				} finally {
				}
			}
		}

		static IntPtr id_getPhy;
		public unsafe int Phy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getPhy' and count(parameter)=0]"
			[Register ("getPhy", "()I", "")]
			get {
				if (id_getPhy == IntPtr.Zero)
					id_getPhy = JNIEnv.GetMethodID (class_ref, "getPhy", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPhy);
				} finally {
				}
			}
		}

		static IntPtr id_getPowerSaveRest;
		public unsafe long PowerSaveRest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getPowerSaveRest' and count(parameter)=0]"
			[Register ("getPowerSaveRest", "()J", "")]
			get {
				if (id_getPowerSaveRest == IntPtr.Zero)
					id_getPowerSaveRest = JNIEnv.GetMethodID (class_ref, "getPowerSaveRest", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPowerSaveRest);
				} finally {
				}
			}
		}

		static IntPtr id_getPowerSaveScan;
		public unsafe long PowerSaveScan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getPowerSaveScan' and count(parameter)=0]"
			[Register ("getPowerSaveScan", "()J", "")]
			get {
				if (id_getPowerSaveScan == IntPtr.Zero)
					id_getPowerSaveScan = JNIEnv.GetMethodID (class_ref, "getPowerSaveScan", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPowerSaveScan);
				} finally {
				}
			}
		}

		static IntPtr id_getReportDelayMillis;
		public unsafe long ReportDelayMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getReportDelayMillis' and count(parameter)=0]"
			[Register ("getReportDelayMillis", "()J", "")]
			get {
				if (id_getReportDelayMillis == IntPtr.Zero)
					id_getReportDelayMillis = JNIEnv.GetMethodID (class_ref, "getReportDelayMillis", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getReportDelayMillis);
				} finally {
				}
			}
		}

		static IntPtr id_getScanMode;
		public unsafe int ScanMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getScanMode' and count(parameter)=0]"
			[Register ("getScanMode", "()I", "")]
			get {
				if (id_getScanMode == IntPtr.Zero)
					id_getScanMode = JNIEnv.GetMethodID (class_ref, "getScanMode", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScanMode);
				} finally {
				}
			}
		}

		static IntPtr id_getScanResultType;
		public unsafe int ScanResultType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getScanResultType' and count(parameter)=0]"
			[Register ("getScanResultType", "()I", "")]
			get {
				if (id_getScanResultType == IntPtr.Zero)
					id_getScanResultType = JNIEnv.GetMethodID (class_ref, "getScanResultType", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScanResultType);
				} finally {
				}
			}
		}

		static IntPtr id_getUseHardwareBatchingIfSupported;
		public unsafe bool UseHardwareBatchingIfSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getUseHardwareBatchingIfSupported' and count(parameter)=0]"
			[Register ("getUseHardwareBatchingIfSupported", "()Z", "")]
			get {
				if (id_getUseHardwareBatchingIfSupported == IntPtr.Zero)
					id_getUseHardwareBatchingIfSupported = JNIEnv.GetMethodID (class_ref, "getUseHardwareBatchingIfSupported", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getUseHardwareBatchingIfSupported);
				} finally {
				}
			}
		}

		static IntPtr id_getUseHardwareCallbackTypesIfSupported;
		public unsafe bool UseHardwareCallbackTypesIfSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getUseHardwareCallbackTypesIfSupported' and count(parameter)=0]"
			[Register ("getUseHardwareCallbackTypesIfSupported", "()Z", "")]
			get {
				if (id_getUseHardwareCallbackTypesIfSupported == IntPtr.Zero)
					id_getUseHardwareCallbackTypesIfSupported = JNIEnv.GetMethodID (class_ref, "getUseHardwareCallbackTypesIfSupported", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getUseHardwareCallbackTypesIfSupported);
				} finally {
				}
			}
		}

		static IntPtr id_getUseHardwareFilteringIfSupported;
		public unsafe bool UseHardwareFilteringIfSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getUseHardwareFilteringIfSupported' and count(parameter)=0]"
			[Register ("getUseHardwareFilteringIfSupported", "()Z", "")]
			get {
				if (id_getUseHardwareFilteringIfSupported == IntPtr.Zero)
					id_getUseHardwareFilteringIfSupported = JNIEnv.GetMethodID (class_ref, "getUseHardwareFilteringIfSupported", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getUseHardwareFilteringIfSupported);
				} finally {
				}
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
