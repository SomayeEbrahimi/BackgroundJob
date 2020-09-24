using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database.Convert {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.convert']/class[@name='BaseDeviceModelConverter']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/convert/BaseDeviceModelConverter", DoNotGenerateAcw=true)]
	public partial class BaseDeviceModelConverter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/convert/BaseDeviceModelConverter", typeof (BaseDeviceModelConverter));
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

		protected BaseDeviceModelConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.convert']/class[@name='BaseDeviceModelConverter']/constructor[@name='BaseDeviceModelConverter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseDeviceModelConverter ()
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

		static Delegate cb_convertToDatabaseValue_Lcom_vivalnk_sdk_model_DeviceModel_;
#pragma warning disable 0169
		static Delegate GetConvertToDatabaseValue_Lcom_vivalnk_sdk_model_DeviceModel_Handler ()
		{
			if (cb_convertToDatabaseValue_Lcom_vivalnk_sdk_model_DeviceModel_ == null)
				cb_convertToDatabaseValue_Lcom_vivalnk_sdk_model_DeviceModel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ConvertToDatabaseValue_Lcom_vivalnk_sdk_model_DeviceModel_);
			return cb_convertToDatabaseValue_Lcom_vivalnk_sdk_model_DeviceModel_;
		}

		static IntPtr n_ConvertToDatabaseValue_Lcom_vivalnk_sdk_model_DeviceModel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Convert.BaseDeviceModelConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertToDatabaseValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.convert']/class[@name='BaseDeviceModelConverter']/method[@name='convertToDatabaseValue' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.DeviceModel']]"
		[Register ("convertToDatabaseValue", "(Lcom/vivalnk/sdk/model/DeviceModel;)Ljava/lang/Integer;", "GetConvertToDatabaseValue_Lcom_vivalnk_sdk_model_DeviceModel_Handler")]
		public virtual unsafe global::Java.Lang.Integer ConvertToDatabaseValue (global::Com.Vivalnk.Sdk.Model.DeviceModel p0)
		{
			const string __id = "convertToDatabaseValue.(Lcom/vivalnk/sdk/model/DeviceModel;)Ljava/lang/Integer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_convertToEntityProperty_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetConvertToEntityProperty_Ljava_lang_Integer_Handler ()
		{
			if (cb_convertToEntityProperty_Ljava_lang_Integer_ == null)
				cb_convertToEntityProperty_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ConvertToEntityProperty_Ljava_lang_Integer_);
			return cb_convertToEntityProperty_Ljava_lang_Integer_;
		}

		static IntPtr n_ConvertToEntityProperty_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Convert.BaseDeviceModelConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertToEntityProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.convert']/class[@name='BaseDeviceModelConverter']/method[@name='convertToEntityProperty' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("convertToEntityProperty", "(Ljava/lang/Integer;)Lcom/vivalnk/sdk/model/DeviceModel;", "GetConvertToEntityProperty_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Model.DeviceModel ConvertToEntityProperty (global::Java.Lang.Integer p0)
		{
			const string __id = "convertToEntityProperty.(Ljava/lang/Integer;)Lcom/vivalnk/sdk/model/DeviceModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
