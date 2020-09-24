using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Dataparser.Battery {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/dataparser/battery/Battery", DoNotGenerateAcw=true)]
	public partial class Battery : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='BAT_VOL_MILL_V0']"
		[Register ("BAT_VOL_MILL_V0")]
		public const int BatVolMillV0 = (int) 3100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='BAT_VOL_MILL_V1']"
		[Register ("BAT_VOL_MILL_V1")]
		public const int BatVolMillV1 = (int) 3400;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='BAT_VOL_MILL_V2']"
		[Register ("BAT_VOL_MILL_V2")]
		public const int BatVolMillV2 = (int) 3600;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='BAT_VOL_MILL_V3']"
		[Register ("BAT_VOL_MILL_V3")]
		public const int BatVolMillV3 = (int) 3690;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='VL_1']"
		[Register ("VL_1")]
		public const int Vl1 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='VL_2']"
		[Register ("VL_2")]
		public const int Vl2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='VL_3']"
		[Register ("VL_3")]
		public const int Vl3 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='VL_4']"
		[Register ("VL_4")]
		public const int Vl4 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='VL_5']"
		[Register ("VL_5")]
		public const int Vl5 = (int) 5;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='VOLTAGE_MAX']"
		[Register ("VOLTAGE_MAX")]
		public static double VoltageMax {
			get {
				const string __id = "VOLTAGE_MAX.D";

				var __v = _members.StaticFields.GetDoubleValue (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='VOLTAGE_MIN']"
		[Register ("VOLTAGE_MIN")]
		public static double VoltageMin {
			get {
				const string __id = "VOLTAGE_MIN.D";

				var __v = _members.StaticFields.GetDoubleValue (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='timeUnitTable']"
		[Register ("timeUnitTable")]
		public static IList<double> TimeUnitTable {
			get {
				const string __id = "timeUnitTable.[D";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<double>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/field[@name='voltageTable']"
		[Register ("voltageTable")]
		public static IList<double> VoltageTable {
			get {
				const string __id = "voltageTable.[D";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<double>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/dataparser/battery/Battery", typeof (Battery));
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

		protected Battery (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/constructor[@name='Battery' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Battery ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.battery']/class[@name='Battery']/method[@name='getPercent' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getPercent", "(D)D", "")]
		public static unsafe double GetPercent (double p0)
		{
			const string __id = "getPercent.(D)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
