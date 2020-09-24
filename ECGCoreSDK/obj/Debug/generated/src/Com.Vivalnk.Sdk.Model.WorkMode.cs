using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='WorkMode']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/WorkMode", DoNotGenerateAcw=true)]
	public sealed partial class WorkMode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='WorkMode']/field[@name='ONE_RRIACC']"
		[Register ("ONE_RRIACC")]
		public static global::Com.Vivalnk.Sdk.Model.WorkMode OneRriacc {
			get {
				const string __id = "ONE_RRIACC.Lcom/vivalnk/sdk/model/WorkMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.WorkMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='WorkMode']/field[@name='THREE_RRI']"
		[Register ("THREE_RRI")]
		public static global::Com.Vivalnk.Sdk.Model.WorkMode ThreeRri {
			get {
				const string __id = "THREE_RRI.Lcom/vivalnk/sdk/model/WorkMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.WorkMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='WorkMode']/field[@name='TWO_RRIECG']"
		[Register ("TWO_RRIECG")]
		public static global::Com.Vivalnk.Sdk.Model.WorkMode TwoRriecg {
			get {
				const string __id = "TWO_RRIECG.Lcom/vivalnk/sdk/model/WorkMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.WorkMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='WorkMode']/field[@name='ZERO_ECGACC']"
		[Register ("ZERO_ECGACC")]
		public static global::Com.Vivalnk.Sdk.Model.WorkMode ZeroEcgacc {
			get {
				const string __id = "ZERO_ECGACC.Lcom/vivalnk/sdk/model/WorkMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.WorkMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/WorkMode", typeof (WorkMode));
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

		internal WorkMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='WorkMode']/constructor[@name='WorkMode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe WorkMode (string p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='WorkMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/vivalnk/sdk/model/WorkMode;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Model.WorkMode ValueOf (int p0)
		{
			const string __id = "valueOf.(I)Lcom/vivalnk/sdk/model/WorkMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.WorkMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='WorkMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/model/WorkMode;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Model.WorkMode ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/sdk/model/WorkMode;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.WorkMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='WorkMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vivalnk/sdk/model/WorkMode;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Model.WorkMode[] Values ()
		{
			const string __id = "values.()[Lcom/vivalnk/sdk/model/WorkMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Vivalnk.Sdk.Model.WorkMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Model.WorkMode));
			} finally {
			}
		}

	}
}
