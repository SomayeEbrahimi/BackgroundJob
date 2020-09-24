using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/android/support/v18/scanner/ScanSettings$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/constructor[@name='ScanSettings.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/vivalnk/android/support/v18/scanner/ScanSettings;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings Build ()
			{
				const string __id = "build.()Lcom/vivalnk/android/support/v18/scanner/ScanSettings;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setCallbackType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCallbackType", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetCallbackType (int callbackType)
			{
				const string __id = "setCallbackType.(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (callbackType);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setLegacy' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLegacy", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetLegacy (bool legacy)
			{
				const string __id = "setLegacy.(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (legacy);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setMatchMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMatchMode", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetMatchMode (int matchMode)
			{
				const string __id = "setMatchMode.(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (matchMode);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setMatchOptions' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("setMatchOptions", "(JJ)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetMatchOptions (long deviceTimeoutMillis, long taskIntervalMillis)
			{
				const string __id = "setMatchOptions.(JJ)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (deviceTimeoutMillis);
					__args [1] = new JniArgumentValue (taskIntervalMillis);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setNumOfMatches' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumOfMatches", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetNumOfMatches (int numOfMatches)
			{
				const string __id = "setNumOfMatches.(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (numOfMatches);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setPhy' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPhy", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetPhy (int phy)
			{
				const string __id = "setPhy.(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (phy);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setPowerSave' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("setPowerSave", "(JJ)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetPowerSave (long scanInterval, long restInterval)
			{
				const string __id = "setPowerSave.(JJ)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (scanInterval);
					__args [1] = new JniArgumentValue (restInterval);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setReportDelay' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setReportDelay", "(J)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetReportDelay (long reportDelayMillis)
			{
				const string __id = "setReportDelay.(J)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (reportDelayMillis);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setScanMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScanMode", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetScanMode (int scanMode)
			{
				const string __id = "setScanMode.(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (scanMode);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setScanResultType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScanResultType", "(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetScanResultType (int scanResultType)
			{
				const string __id = "setScanResultType.(I)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (scanResultType);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setUseHardwareBatchingIfSupported' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseHardwareBatchingIfSupported", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetUseHardwareBatchingIfSupported (bool use)
			{
				const string __id = "setUseHardwareBatchingIfSupported.(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (use);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setUseHardwareCallbackTypesIfSupported' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseHardwareCallbackTypesIfSupported", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetUseHardwareCallbackTypesIfSupported (bool use)
			{
				const string __id = "setUseHardwareCallbackTypesIfSupported.(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (use);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings.Builder']/method[@name='setUseHardwareFilteringIfSupported' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseHardwareFilteringIfSupported", "(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder SetUseHardwareFilteringIfSupported (bool use)
			{
				const string __id = "setUseHardwareFilteringIfSupported.(Z)Lcom/vivalnk/android/support/v18/scanner/ScanSettings$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (use);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanSettings.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/android/support/v18/scanner/ScanSettings", typeof (ScanSettings));
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

		internal ScanSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int CallbackType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getCallbackType' and count(parameter)=0]"
			[Register ("getCallbackType", "()I", "")]
			get {
				const string __id = "getCallbackType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool HasPowerSaveMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='hasPowerSaveMode' and count(parameter)=0]"
			[Register ("hasPowerSaveMode", "()Z", "")]
			get {
				const string __id = "hasPowerSaveMode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool Legacy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getLegacy' and count(parameter)=0]"
			[Register ("getLegacy", "()Z", "")]
			get {
				const string __id = "getLegacy.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long MatchLostDeviceTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getMatchLostDeviceTimeout' and count(parameter)=0]"
			[Register ("getMatchLostDeviceTimeout", "()J", "")]
			get {
				const string __id = "getMatchLostDeviceTimeout.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long MatchLostTaskInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getMatchLostTaskInterval' and count(parameter)=0]"
			[Register ("getMatchLostTaskInterval", "()J", "")]
			get {
				const string __id = "getMatchLostTaskInterval.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int MatchMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getMatchMode' and count(parameter)=0]"
			[Register ("getMatchMode", "()I", "")]
			get {
				const string __id = "getMatchMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int NumOfMatches {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getNumOfMatches' and count(parameter)=0]"
			[Register ("getNumOfMatches", "()I", "")]
			get {
				const string __id = "getNumOfMatches.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int Phy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getPhy' and count(parameter)=0]"
			[Register ("getPhy", "()I", "")]
			get {
				const string __id = "getPhy.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long PowerSaveRest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getPowerSaveRest' and count(parameter)=0]"
			[Register ("getPowerSaveRest", "()J", "")]
			get {
				const string __id = "getPowerSaveRest.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long PowerSaveScan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getPowerSaveScan' and count(parameter)=0]"
			[Register ("getPowerSaveScan", "()J", "")]
			get {
				const string __id = "getPowerSaveScan.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long ReportDelayMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getReportDelayMillis' and count(parameter)=0]"
			[Register ("getReportDelayMillis", "()J", "")]
			get {
				const string __id = "getReportDelayMillis.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int ScanMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getScanMode' and count(parameter)=0]"
			[Register ("getScanMode", "()I", "")]
			get {
				const string __id = "getScanMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int ScanResultType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getScanResultType' and count(parameter)=0]"
			[Register ("getScanResultType", "()I", "")]
			get {
				const string __id = "getScanResultType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool UseHardwareBatchingIfSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getUseHardwareBatchingIfSupported' and count(parameter)=0]"
			[Register ("getUseHardwareBatchingIfSupported", "()Z", "")]
			get {
				const string __id = "getUseHardwareBatchingIfSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool UseHardwareCallbackTypesIfSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getUseHardwareCallbackTypesIfSupported' and count(parameter)=0]"
			[Register ("getUseHardwareCallbackTypesIfSupported", "()Z", "")]
			get {
				const string __id = "getUseHardwareCallbackTypesIfSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool UseHardwareFilteringIfSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='getUseHardwareFilteringIfSupported' and count(parameter)=0]"
			[Register ("getUseHardwareFilteringIfSupported", "()Z", "")]
			get {
				const string __id = "getUseHardwareFilteringIfSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
