using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Report {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/report/ReportModel", DoNotGenerateAcw=true)]
	public partial class ReportModel : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='AFBurden']"
		[Register ("AFBurden")]
		public float AFBurden {
			get {
				const string __id = "AFBurden.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "AFBurden.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='HRDuringLongestAFEpisode']"
		[Register ("HRDuringLongestAFEpisode")]
		public long HRDuringLongestAFEpisode {
			get {
				const string __id = "HRDuringLongestAFEpisode.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "HRDuringLongestAFEpisode.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='HRRangeModels']"
		[Register ("HRRangeModels")]
		public IList<Com.Vivalnk.Sdk.Report.HRRangeModel> HRRangeModels {
			get {
				const string __id = "HRRangeModels.[Lcom/vivalnk/sdk/report/HRRangeModel;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Report.HRRangeModel>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "HRRangeModels.[Lcom/vivalnk/sdk/report/HRRangeModel;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Report.HRRangeModel>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='averageHR']"
		[Register ("averageHR")]
		public int AverageHR {
			get {
				const string __id = "averageHR.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "averageHR.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='longestAFDuration']"
		[Register ("longestAFDuration")]
		public long LongestAFDuration {
			get {
				const string __id = "longestAFDuration.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "longestAFDuration.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='longestPauseDuration']"
		[Register ("longestPauseDuration")]
		public long LongestPauseDuration {
			get {
				const string __id = "longestPauseDuration.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "longestPauseDuration.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='recordingDuration']"
		[Register ("recordingDuration")]
		public long RecordingDuration {
			get {
				const string __id = "recordingDuration.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "recordingDuration.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='recordingEndTime']"
		[Register ("recordingEndTime")]
		public long RecordingEndTime {
			get {
				const string __id = "recordingEndTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "recordingEndTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='recordingStartTime']"
		[Register ("recordingStartTime")]
		public long RecordingStartTime {
			get {
				const string __id = "recordingStartTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "recordingStartTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='totalAF']"
		[Register ("totalAF")]
		public int TotalAF {
			get {
				const string __id = "totalAF.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "totalAF.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/field[@name='totalPause']"
		[Register ("totalPause")]
		public long TotalPause {
			get {
				const string __id = "totalPause.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "totalPause.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/report/ReportModel", typeof (ReportModel));
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

		protected ReportModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/constructor[@name='ReportModel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReportModel ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='ReportModel']/method[@name='getHRRangeIndex' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getHRRangeIndex", "(D)I", "")]
		public static unsafe int GetHRRangeIndex (double p0)
		{
			const string __id = "getHRRangeIndex.(D)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
