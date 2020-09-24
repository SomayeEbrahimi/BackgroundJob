using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='CommandFactory']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/base/CommandFactory", DoNotGenerateAcw=true)]
	public partial class CommandFactory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/base/CommandFactory", typeof (CommandFactory));
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

		protected CommandFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='CommandFactory']/constructor[@name='CommandFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommandFactory ()
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

		static Delegate cb_createCommand_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_CommandRequest_Lcom_vivalnk_sdk_Callback_;
#pragma warning disable 0169
		static Delegate GetCreateCommand_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_CommandRequest_Lcom_vivalnk_sdk_Callback_Handler ()
		{
			if (cb_createCommand_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_CommandRequest_Lcom_vivalnk_sdk_Callback_ == null)
				cb_createCommand_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_CommandRequest_Lcom_vivalnk_sdk_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_CreateCommand_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_CommandRequest_Lcom_vivalnk_sdk_Callback_);
			return cb_createCommand_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_CommandRequest_Lcom_vivalnk_sdk_Callback_;
		}

		static IntPtr n_CreateCommand_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_CommandRequest_Lcom_vivalnk_sdk_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.CommandFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Vivalnk.Sdk.ICallback)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.ICallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateCommand (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='CommandFactory']/method[@name='createCommand' and count(parameter)=3 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='com.vivalnk.sdk.CommandRequest'] and parameter[3][@type='com.vivalnk.sdk.Callback']]"
		[Register ("createCommand", "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/CommandRequest;Lcom/vivalnk/sdk/Callback;)Lcom/vivalnk/sdk/base/RealCommand;", "GetCreateCommand_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_CommandRequest_Lcom_vivalnk_sdk_Callback_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Base.RealCommand CreateCommand (global::Com.Vivalnk.Sdk.Model.Device p0, global::Com.Vivalnk.Sdk.CommandRequest p1, global::Com.Vivalnk.Sdk.ICallback p2)
		{
			const string __id = "createCommand.(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/CommandRequest;Lcom/vivalnk/sdk/Callback;)Lcom/vivalnk/sdk/base/RealCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
