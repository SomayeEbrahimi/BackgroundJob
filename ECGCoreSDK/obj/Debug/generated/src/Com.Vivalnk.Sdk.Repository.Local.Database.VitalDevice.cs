using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/VitalDevice", DoNotGenerateAcw=true)]
	public partial class VitalDevice : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/VitalDevice", typeof (VitalDevice));
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

		protected VitalDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/constructor[@name='VitalDevice' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VitalDevice ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/constructor[@name='VitalDevice' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.common.IVitalDevice']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/model/common/IVitalDevice;)V", "")]
		public unsafe VitalDevice (global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/model/common/IVitalDevice;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/constructor[@name='VitalDevice' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Device']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/model/Device;)V", "")]
		public unsafe VitalDevice (global::Com.Vivalnk.Sdk.Model.Device p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/model/Device;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getDeviceID;
#pragma warning disable 0169
		static Delegate GetGetDeviceIDHandler ()
		{
			if (cb_getDeviceID == null)
				cb_getDeviceID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceID);
			return cb_getDeviceID;
		}

		static IntPtr n_GetDeviceID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceID);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceID_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceID_Ljava_lang_String_ == null)
				cb_setDeviceID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceID_Ljava_lang_String_);
			return cb_setDeviceID_Ljava_lang_String_;
		}

		static void n_SetDeviceID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='getDeviceID' and count(parameter)=0]"
			[Register ("getDeviceID", "()Ljava/lang/String;", "GetGetDeviceIDHandler")]
			get {
				const string __id = "getDeviceID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='setDeviceID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceID", "(Ljava/lang/String;)V", "GetSetDeviceID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceID.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceInfo;
#pragma warning disable 0169
		static Delegate GetGetDeviceInfoHandler ()
		{
			if (cb_getDeviceInfo == null)
				cb_getDeviceInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceInfo);
			return cb_getDeviceInfo;
		}

		static IntPtr n_GetDeviceInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceInfo_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceInfo_Ljava_lang_String_ == null)
				cb_setDeviceInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceInfo_Ljava_lang_String_);
			return cb_setDeviceInfo_Ljava_lang_String_;
		}

		static void n_SetDeviceInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceInfo = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='getDeviceInfo' and count(parameter)=0]"
			[Register ("getDeviceInfo", "()Ljava/lang/String;", "GetGetDeviceInfoHandler")]
			get {
				const string __id = "getDeviceInfo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='setDeviceInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceInfo", "(Ljava/lang/String;)V", "GetSetDeviceInfo_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceInfo.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceModel;
#pragma warning disable 0169
		static Delegate GetGetDeviceModelHandler ()
		{
			if (cb_getDeviceModel == null)
				cb_getDeviceModel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceModel);
			return cb_getDeviceModel;
		}

		static IntPtr n_GetDeviceModel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceModel);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_;
#pragma warning disable 0169
		static Delegate GetSetDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_Handler ()
		{
			if (cb_setDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_ == null)
				cb_setDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_);
			return cb_setDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_;
		}

		static void n_SetDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceModel = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Model.DeviceModel DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Lcom/vivalnk/sdk/model/DeviceModel;", "GetGetDeviceModelHandler")]
			get {
				const string __id = "getDeviceModel.()Lcom/vivalnk/sdk/model/DeviceModel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='setDeviceModel' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.DeviceModel']]"
			[Register ("setDeviceModel", "(Lcom/vivalnk/sdk/model/DeviceModel;)V", "GetSetDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_Handler")]
			set {
				const string __id = "setDeviceModel.(Lcom/vivalnk/sdk/model/DeviceModel;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceName;
#pragma warning disable 0169
		static Delegate GetGetDeviceNameHandler ()
		{
			if (cb_getDeviceName == null)
				cb_getDeviceName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceName);
			return cb_getDeviceName;
		}

		static IntPtr n_GetDeviceName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceName);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceName_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceName_Ljava_lang_String_ == null)
				cb_setDeviceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceName_Ljava_lang_String_);
			return cb_setDeviceName_Ljava_lang_String_;
		}

		static void n_SetDeviceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler")]
			get {
				const string __id = "getDeviceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='setDeviceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceName", "(Ljava/lang/String;)V", "GetSetDeviceName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceSN;
#pragma warning disable 0169
		static Delegate GetGetDeviceSNHandler ()
		{
			if (cb_getDeviceSN == null)
				cb_getDeviceSN = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceSN);
			return cb_getDeviceSN;
		}

		static IntPtr n_GetDeviceSN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceSN);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceSN_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceSN_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceSN_Ljava_lang_String_ == null)
				cb_setDeviceSN_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceSN_Ljava_lang_String_);
			return cb_setDeviceSN_Ljava_lang_String_;
		}

		static void n_SetDeviceSN_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceSN = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='getDeviceSN' and count(parameter)=0]"
			[Register ("getDeviceSN", "()Ljava/lang/String;", "GetGetDeviceSNHandler")]
			get {
				const string __id = "getDeviceSN.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='setDeviceSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceSN", "(Ljava/lang/String;)V", "GetSetDeviceSN_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceSN.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFwVersion;
#pragma warning disable 0169
		static Delegate GetGetFwVersionHandler ()
		{
			if (cb_getFwVersion == null)
				cb_getFwVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFwVersion);
			return cb_getFwVersion;
		}

		static IntPtr n_GetFwVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FwVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setFwVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFwVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setFwVersion_Ljava_lang_String_ == null)
				cb_setFwVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFwVersion_Ljava_lang_String_);
			return cb_setFwVersion_Ljava_lang_String_;
		}

		static void n_SetFwVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FwVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string FwVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='getFwVersion' and count(parameter)=0]"
			[Register ("getFwVersion", "()Ljava/lang/String;", "GetGetFwVersionHandler")]
			get {
				const string __id = "getFwVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='setFwVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFwVersion", "(Ljava/lang/String;)V", "GetSetFwVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFwVersion.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHwVersion;
#pragma warning disable 0169
		static Delegate GetGetHwVersionHandler ()
		{
			if (cb_getHwVersion == null)
				cb_getHwVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHwVersion);
			return cb_getHwVersion;
		}

		static IntPtr n_GetHwVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HwVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setHwVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHwVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setHwVersion_Ljava_lang_String_ == null)
				cb_setHwVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHwVersion_Ljava_lang_String_);
			return cb_setHwVersion_Ljava_lang_String_;
		}

		static void n_SetHwVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HwVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string HwVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='getHwVersion' and count(parameter)=0]"
			[Register ("getHwVersion", "()Ljava/lang/String;", "GetGetHwVersionHandler")]
			get {
				const string __id = "getHwVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='setHwVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHwVersion", "(Ljava/lang/String;)V", "GetSetHwVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setHwVersion.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetId);
			return cb_getId;
		}

		static long n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static Delegate cb_setId_J;
#pragma warning disable 0169
		static Delegate GetSetId_JHandler ()
		{
			if (cb_setId_J == null)
				cb_setId_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetId_J);
			return cb_setId_J;
		}

		static void n_SetId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler")]
			get {
				const string __id = "getId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setId", "(J)V", "GetSetId_JHandler")]
			set {
				const string __id = "setId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setDeviceInfo_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetDeviceInfo_Ljava_util_Map_Handler ()
		{
			if (cb_setDeviceInfo_Ljava_util_Map_ == null)
				cb_setDeviceInfo_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceInfo_Ljava_util_Map_);
			return cb_setDeviceInfo_Ljava_util_Map_;
		}

		static void n_SetDeviceInfo_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceInfo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='VitalDevice']/method[@name='setDeviceInfo' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setDeviceInfo", "(Ljava/util/Map;)V", "GetSetDeviceInfo_Ljava_util_Map_Handler")]
		public virtual unsafe void SetDeviceInfo (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "setDeviceInfo.(Ljava/util/Map;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
