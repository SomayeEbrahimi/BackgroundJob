using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']"
	[Register ("com/vivalnk/sdk/model/common/IVitalDevice", "", "Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker")]
	public partial interface IVitalDevice : IJavaObject, IJavaPeerable {

		string DeviceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='getDeviceID' and count(parameter)=0]"
			[Register ("getDeviceID", "()Ljava/lang/String;", "GetGetDeviceIDHandler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='setDeviceID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceID", "(Ljava/lang/String;)V", "GetSetDeviceID_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] set;
		}

		string DeviceInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='getDeviceInfo' and count(parameter)=0]"
			[Register ("getDeviceInfo", "()Ljava/lang/String;", "GetGetDeviceInfoHandler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='setDeviceInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceInfo", "(Ljava/lang/String;)V", "GetSetDeviceInfo_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] set;
		}

		global::Com.Vivalnk.Sdk.Model.DeviceModel DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Lcom/vivalnk/sdk/model/DeviceModel;", "GetGetDeviceModelHandler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='setDeviceModel' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.DeviceModel']]"
			[Register ("setDeviceModel", "(Lcom/vivalnk/sdk/model/DeviceModel;)V", "GetSetDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_Handler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] set;
		}

		string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='setDeviceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceName", "(Ljava/lang/String;)V", "GetSetDeviceName_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] set;
		}

		string DeviceSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='getDeviceSN' and count(parameter)=0]"
			[Register ("getDeviceSN", "()Ljava/lang/String;", "GetGetDeviceSNHandler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='setDeviceSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceSN", "(Ljava/lang/String;)V", "GetSetDeviceSN_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] set;
		}

		string FwVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='getFwVersion' and count(parameter)=0]"
			[Register ("getFwVersion", "()Ljava/lang/String;", "GetGetFwVersionHandler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='setFwVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFwVersion", "(Ljava/lang/String;)V", "GetSetFwVersion_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] set;
		}

		string HwVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='getHwVersion' and count(parameter)=0]"
			[Register ("getHwVersion", "()Ljava/lang/String;", "GetGetHwVersionHandler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='setHwVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHwVersion", "(Ljava/lang/String;)V", "GetSetHwVersion_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] set;
		}

		long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='IVitalDevice']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setId", "(J)V", "GetSetId_JHandler:Com.Vivalnk.Sdk.Model.Common.IVitalDeviceInvoker, ECGCoreSDK")] set;
		}

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/common/IVitalDevice", DoNotGenerateAcw=true)]
	internal partial class IVitalDeviceInvoker : global::Java.Lang.Object, IVitalDevice {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/common/IVitalDevice", typeof (IVitalDeviceInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IVitalDevice GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVitalDevice> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.model.common.IVitalDevice"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVitalDeviceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceID = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDeviceID;
		IntPtr id_setDeviceID_Ljava_lang_String_;
		public unsafe string DeviceID {
			get {
				if (id_getDeviceID == IntPtr.Zero)
					id_getDeviceID = JNIEnv.GetMethodID (class_ref, "getDeviceID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceID), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDeviceID_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceID_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceInfo = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDeviceInfo;
		IntPtr id_setDeviceInfo_Ljava_lang_String_;
		public unsafe string DeviceInfo {
			get {
				if (id_getDeviceInfo == IntPtr.Zero)
					id_getDeviceInfo = JNIEnv.GetMethodID (class_ref, "getDeviceInfo", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceInfo), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDeviceInfo_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceInfo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceInfo", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceInfo_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceModel = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDeviceModel;
		IntPtr id_setDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_;
		public unsafe global::Com.Vivalnk.Sdk.Model.DeviceModel DeviceModel {
			get {
				if (id_getDeviceModel == IntPtr.Zero)
					id_getDeviceModel = JNIEnv.GetMethodID (class_ref, "getDeviceModel", "()Lcom/vivalnk/sdk/model/DeviceModel;");
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceModel), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_ == IntPtr.Zero)
					id_setDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_ = JNIEnv.GetMethodID (class_ref, "setDeviceModel", "(Lcom/vivalnk/sdk/model/DeviceModel;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceName = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDeviceName;
		IntPtr id_setDeviceName_Ljava_lang_String_;
		public unsafe string DeviceName {
			get {
				if (id_getDeviceName == IntPtr.Zero)
					id_getDeviceName = JNIEnv.GetMethodID (class_ref, "getDeviceName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceName), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDeviceName_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceName_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceSN = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDeviceSN;
		IntPtr id_setDeviceSN_Ljava_lang_String_;
		public unsafe string DeviceSN {
			get {
				if (id_getDeviceSN == IntPtr.Zero)
					id_getDeviceSN = JNIEnv.GetMethodID (class_ref, "getDeviceSN", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceSN), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDeviceSN_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceSN_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceSN", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceSN_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FwVersion = p0;
		}
#pragma warning restore 0169

		IntPtr id_getFwVersion;
		IntPtr id_setFwVersion_Ljava_lang_String_;
		public unsafe string FwVersion {
			get {
				if (id_getFwVersion == IntPtr.Zero)
					id_getFwVersion = JNIEnv.GetMethodID (class_ref, "getFwVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFwVersion), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setFwVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setFwVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFwVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFwVersion_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HwVersion = p0;
		}
#pragma warning restore 0169

		IntPtr id_getHwVersion;
		IntPtr id_setHwVersion_Ljava_lang_String_;
		public unsafe string HwVersion {
			get {
				if (id_getHwVersion == IntPtr.Zero)
					id_getHwVersion = JNIEnv.GetMethodID (class_ref, "getHwVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHwVersion), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setHwVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setHwVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHwVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHwVersion_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		IntPtr id_getId;
		IntPtr id_setId_J;
		public unsafe long Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getId);
			}
			set {
				if (id_setId_J == IntPtr.Zero)
					id_setId_J = JNIEnv.GetMethodID (class_ref, "setId", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setId_J, __args);
			}
		}

	}

}
