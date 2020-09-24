using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Constant {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/constant/VitalConstant", DoNotGenerateAcw=true)]
	public partial class VitalConstant : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingMode']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/constant/VitalConstant$SamplingMode", DoNotGenerateAcw=true)]
		public partial class SamplingMode : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingMode']/field[@name='VV310']"
			[Register ("VV310")]
			public const string Vv310 = (string) "VV310";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingMode']/field[@name='VV330_128HZ']"
			[Register ("VV330_128HZ")]
			public const string Vv330128hz = (string) "VV330_128HZ";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingMode']/field[@name='VV330_250HZ']"
			[Register ("VV330_250HZ")]
			public const string Vv330250hz = (string) "VV330_250HZ";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingMode']/field[@name='VVBP']"
			[Register ("VVBP")]
			public const string Vvbp = (string) "VVBP";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingMode']/field[@name='VVBP_old']"
			[Register ("VVBP_old")]
			public const string VVBPOld = (string) "VVBP_old";
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/constant/VitalConstant$SamplingMode", typeof (SamplingMode));
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

			protected SamplingMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingMode']/constructor[@name='VitalConstant.SamplingMode' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SamplingMode ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingMode']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("contains", "(Ljava/lang/String;)Z", "")]
			public static unsafe bool Contains (string p0)
			{
				const string __id = "contains.(Ljava/lang/String;)Z";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingMode']/method[@name='getModeArray' and count(parameter)=0]"
			[Register ("getModeArray", "()[Ljava/lang/String;", "")]
			public static unsafe string[] GetModeArray ()
			{
				const string __id = "getModeArray.()[Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingType']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/constant/VitalConstant$SamplingType", DoNotGenerateAcw=true)]
		public partial class SamplingType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingType']/field[@name='TYPE_ACC']"
			[Register ("TYPE_ACC")]
			public const int TypeAcc = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingType']/field[@name='TYPE_ECG']"
			[Register ("TYPE_ECG")]
			public const int TypeEcg = (int) 0;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/constant/VitalConstant$SamplingType", typeof (SamplingType));
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

			protected SamplingType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant.SamplingType']/constructor[@name='VitalConstant.SamplingType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SamplingType ()
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/constant/VitalConstant", typeof (VitalConstant));
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

		protected VitalConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant']/constructor[@name='VitalConstant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VitalConstant ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.constant']/class[@name='VitalConstant']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			const string __id = "main.([Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
