using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Report {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='DailyAnalysis']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/report/DailyAnalysis", DoNotGenerateAcw=true)]
	public partial class DailyAnalysis : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/report/DailyAnalysis", typeof (DailyAnalysis));
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

		protected DailyAnalysis (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='DailyAnalysis']/constructor[@name='DailyAnalysis' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DailyAnalysis ()
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

		static Delegate cb_doAnalysis_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDoAnalysis_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_doAnalysis_Ljava_util_List_Ljava_util_List_ == null)
				cb_doAnalysis_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_DoAnalysis_Ljava_util_List_Ljava_util_List_);
			return cb_doAnalysis_Ljava_util_List_Ljava_util_List_;
		}

		static IntPtr n_DoAnalysis_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Report.DailyAnalysis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.Event>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoAnalysis (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.report']/class[@name='DailyAnalysis']/method[@name='doAnalysis' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.vivalnk.sdk.model.SampleData&gt;'] and parameter[2][@type='java.util.List&lt;com.vivalnk.sdk.model.Event&gt;']]"
		[Register ("doAnalysis", "(Ljava/util/List;Ljava/util/List;)Lcom/vivalnk/sdk/report/ReportModel;", "GetDoAnalysis_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Report.ReportModel DoAnalysis (global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.SampleData> p0, global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.Event> p1)
		{
			const string __id = "doAnalysis.(Ljava/util/List;Ljava/util/List;)Lcom/vivalnk/sdk/report/ReportModel;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.Event>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Report.ReportModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
