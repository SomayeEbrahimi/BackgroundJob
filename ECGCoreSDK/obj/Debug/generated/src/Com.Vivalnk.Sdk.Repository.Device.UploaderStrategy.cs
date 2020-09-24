using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.device']/class[@name='UploaderStrategy']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/device/UploaderStrategy", DoNotGenerateAcw=true)]
	public partial class UploaderStrategy : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.device']/class[@name='UploaderStrategy']/field[@name='save']"
		[Register ("save")]
		public bool Save {
			get {
				const string __id = "save.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "save.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.device']/class[@name='UploaderStrategy']/field[@name='upload']"
		[Register ("upload")]
		public bool Upload {
			get {
				const string __id = "upload.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "upload.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/device/UploaderStrategy", typeof (UploaderStrategy));
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

		protected UploaderStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.device']/class[@name='UploaderStrategy']/constructor[@name='UploaderStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UploaderStrategy ()
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

		static Delegate cb_setSave_Z;
#pragma warning disable 0169
		static Delegate GetSetSave_ZHandler ()
		{
			if (cb_setSave_Z == null)
				cb_setSave_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetSave_Z);
			return cb_setSave_Z;
		}

		static IntPtr n_SetSave_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Device.UploaderStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSave (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.device']/class[@name='UploaderStrategy']/method[@name='setSave' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSave", "(Z)Lcom/vivalnk/sdk/repository/device/UploaderStrategy;", "GetSetSave_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Repository.Device.UploaderStrategy SetSave (bool p0)
		{
			const string __id = "setSave.(Z)Lcom/vivalnk/sdk/repository/device/UploaderStrategy;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Device.UploaderStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUpload_Z;
#pragma warning disable 0169
		static Delegate GetSetUpload_ZHandler ()
		{
			if (cb_setUpload_Z == null)
				cb_setUpload_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetUpload_Z);
			return cb_setUpload_Z;
		}

		static IntPtr n_SetUpload_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Device.UploaderStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetUpload (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.device']/class[@name='UploaderStrategy']/method[@name='setUpload' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUpload", "(Z)Lcom/vivalnk/sdk/repository/device/UploaderStrategy;", "GetSetUpload_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Repository.Device.UploaderStrategy SetUpload (bool p0)
		{
			const string __id = "setUpload.(Z)Lcom/vivalnk/sdk/repository/device/UploaderStrategy;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Device.UploaderStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
