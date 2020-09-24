using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/common/IVitalData", DoNotGenerateAcw=true)]
	public abstract partial class IVitalData : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Model.Common.IDataComparable, global::Java.IO.ISerializable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/common/IVitalData", typeof (IVitalData));
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

		protected IVitalData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/constructor[@name='IVitalData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IVitalData ()
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

		static Delegate cb_getAccAccuracy;
#pragma warning disable 0169
		static Delegate GetGetAccAccuracyHandler ()
		{
			if (cb_getAccAccuracy == null)
				cb_getAccAccuracy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAccAccuracy);
			return cb_getAccAccuracy;
		}

		static int n_GetAccAccuracy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AccAccuracy;
		}
#pragma warning restore 0169

		static Delegate cb_setAccAccuracy_I;
#pragma warning disable 0169
		static Delegate GetSetAccAccuracy_IHandler ()
		{
			if (cb_setAccAccuracy_I == null)
				cb_setAccAccuracy_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAccAccuracy_I);
			return cb_setAccAccuracy_I;
		}

		static void n_SetAccAccuracy_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AccAccuracy = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int AccAccuracy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getAccAccuracy' and count(parameter)=0]"
			[Register ("getAccAccuracy", "()I", "GetGetAccAccuracyHandler")]
			get {
				const string __id = "getAccAccuracy.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setAccAccuracy' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAccAccuracy", "(I)V", "GetSetAccAccuracy_IHandler")]
			set {
				const string __id = "setAccAccuracy.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAverageRR;
#pragma warning disable 0169
		static Delegate GetGetAverageRRHandler ()
		{
			if (cb_getAverageRR == null)
				cb_getAverageRR = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAverageRR);
			return cb_getAverageRR;
		}

		static IntPtr n_GetAverageRR (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AverageRR);
		}
#pragma warning restore 0169

		static Delegate cb_setAverageRR_Ljava_lang_Float_;
#pragma warning disable 0169
		static Delegate GetSetAverageRR_Ljava_lang_Float_Handler ()
		{
			if (cb_setAverageRR_Ljava_lang_Float_ == null)
				cb_setAverageRR_Ljava_lang_Float_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAverageRR_Ljava_lang_Float_);
			return cb_setAverageRR_Ljava_lang_Float_;
		}

		static void n_SetAverageRR_Ljava_lang_Float_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AverageRR = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Float AverageRR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getAverageRR' and count(parameter)=0]"
			[Register ("getAverageRR", "()Ljava/lang/Float;", "GetGetAverageRRHandler")]
			get {
				const string __id = "getAverageRR.()Ljava/lang/Float;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setAverageRR' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
			[Register ("setAverageRR", "(Ljava/lang/Float;)V", "GetSetAverageRR_Ljava_lang_Float_Handler")]
			set {
				const string __id = "setAverageRR.(Ljava/lang/Float;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceID = p0;
		}
#pragma warning restore 0169

		public abstract string DeviceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getDeviceID' and count(parameter)=0]"
			[Register ("getDeviceID", "()Ljava/lang/String;", "GetGetDeviceIDHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setDeviceID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceID", "(Ljava/lang/String;)V", "GetSetDeviceID_Ljava_lang_String_Handler")] set;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceModel = p0;
		}
#pragma warning restore 0169

		public abstract global::Com.Vivalnk.Sdk.Model.DeviceModel DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Lcom/vivalnk/sdk/model/DeviceModel;", "GetGetDeviceModelHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setDeviceModel' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.DeviceModel']]"
			[Register ("setDeviceModel", "(Lcom/vivalnk/sdk/model/DeviceModel;)V", "GetSetDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_Handler")] set;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceName = p0;
		}
#pragma warning restore 0169

		public abstract string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setDeviceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceName", "(Ljava/lang/String;)V", "GetSetDeviceName_Ljava_lang_String_Handler")] set;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceSN = p0;
		}
#pragma warning restore 0169

		public abstract string DeviceSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getDeviceSN' and count(parameter)=0]"
			[Register ("getDeviceSN", "()Ljava/lang/String;", "GetGetDeviceSNHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setDeviceSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceSN", "(Ljava/lang/String;)V", "GetSetDeviceSN_Ljava_lang_String_Handler")] set;
		}

		static Delegate cb_getExtras;
#pragma warning disable 0169
		static Delegate GetGetExtrasHandler ()
		{
			if (cb_getExtras == null)
				cb_getExtras = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExtras);
			return cb_getExtras;
		}

		static IntPtr n_GetExtras (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Extras);
		}
#pragma warning restore 0169

		static Delegate cb_setExtras_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetExtras_Ljava_util_Map_Handler ()
		{
			if (cb_setExtras_Ljava_util_Map_ == null)
				cb_setExtras_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExtras_Ljava_util_Map_);
			return cb_setExtras_Ljava_util_Map_;
		}

		static void n_SetExtras_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Extras = p0;
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Extras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getExtras' and count(parameter)=0]"
			[Register ("getExtras", "()Ljava/util/Map;", "GetGetExtrasHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("setExtras", "(Ljava/util/Map;)V", "GetSetExtras_Ljava_util_Map_Handler")] set;
		}

		static Delegate cb_getHR;
#pragma warning disable 0169
		static Delegate GetGetHRHandler ()
		{
			if (cb_getHR == null)
				cb_getHR = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHR);
			return cb_getHR;
		}

		static IntPtr n_GetHR (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HR);
		}
#pragma warning restore 0169

		static Delegate cb_setHR_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetHR_Ljava_lang_Integer_Handler ()
		{
			if (cb_setHR_Ljava_lang_Integer_ == null)
				cb_setHR_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHR_Ljava_lang_Integer_);
			return cb_setHR_Ljava_lang_Integer_;
		}

		static void n_SetHR_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HR = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer HR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getHR' and count(parameter)=0]"
			[Register ("getHR", "()Ljava/lang/Integer;", "GetGetHRHandler")]
			get {
				const string __id = "getHR.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setHR' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setHR", "(Ljava/lang/Integer;)V", "GetSetHR_Ljava_lang_Integer_Handler")]
			set {
				const string __id = "setHR.(Ljava/lang/Integer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		public abstract long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setId", "(J)V", "GetSetId_JHandler")] set;
		}

		static Delegate cb_getMagnification;
#pragma warning disable 0169
		static Delegate GetGetMagnificationHandler ()
		{
			if (cb_getMagnification == null)
				cb_getMagnification = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMagnification);
			return cb_getMagnification;
		}

		static int n_GetMagnification (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Magnification;
		}
#pragma warning restore 0169

		static Delegate cb_setMagnification_I;
#pragma warning disable 0169
		static Delegate GetSetMagnification_IHandler ()
		{
			if (cb_setMagnification_I == null)
				cb_setMagnification_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMagnification_I);
			return cb_setMagnification_I;
		}

		static void n_SetMagnification_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Magnification = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Magnification {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getMagnification' and count(parameter)=0]"
			[Register ("getMagnification", "()I", "GetGetMagnificationHandler")]
			get {
				const string __id = "getMagnification.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setMagnification' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMagnification", "(I)V", "GetSetMagnification_IHandler")]
			set {
				const string __id = "setMagnification.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRR;
#pragma warning disable 0169
		static Delegate GetGetRRHandler ()
		{
			if (cb_getRR == null)
				cb_getRR = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRR);
			return cb_getRR;
		}

		static IntPtr n_GetRR (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RR);
		}
#pragma warning restore 0169

		static Delegate cb_setRR_Ljava_lang_Float_;
#pragma warning disable 0169
		static Delegate GetSetRR_Ljava_lang_Float_Handler ()
		{
			if (cb_setRR_Ljava_lang_Float_ == null)
				cb_setRR_Ljava_lang_Float_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRR_Ljava_lang_Float_);
			return cb_setRR_Ljava_lang_Float_;
		}

		static void n_SetRR_Ljava_lang_Float_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RR = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Float RR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getRR' and count(parameter)=0]"
			[Register ("getRR", "()Ljava/lang/Float;", "GetGetRRHandler")]
			get {
				const string __id = "getRR.()Ljava/lang/Float;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setRR' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
			[Register ("setRR", "(Ljava/lang/Float;)V", "GetSetRR_Ljava_lang_Float_Handler")]
			set {
				const string __id = "setRR.(Ljava/lang/Float;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTemperature;
#pragma warning disable 0169
		static Delegate GetGetTemperatureHandler ()
		{
			if (cb_getTemperature == null)
				cb_getTemperature = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTemperature);
			return cb_getTemperature;
		}

		static IntPtr n_GetTemperature (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Temperature);
		}
#pragma warning restore 0169

		static Delegate cb_setTemperature_Ljava_lang_Float_;
#pragma warning disable 0169
		static Delegate GetSetTemperature_Ljava_lang_Float_Handler ()
		{
			if (cb_setTemperature_Ljava_lang_Float_ == null)
				cb_setTemperature_Ljava_lang_Float_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTemperature_Ljava_lang_Float_);
			return cb_setTemperature_Ljava_lang_Float_;
		}

		static void n_SetTemperature_Ljava_lang_Float_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Temperature = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Float Temperature {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getTemperature' and count(parameter)=0]"
			[Register ("getTemperature", "()Ljava/lang/Float;", "GetGetTemperatureHandler")]
			get {
				const string __id = "getTemperature.()Ljava/lang/Float;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setTemperature' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
			[Register ("setTemperature", "(Ljava/lang/Float;)V", "GetSetTemperature_Ljava_lang_Float_Handler")]
			set {
				const string __id = "setTemperature.(Ljava/lang/Float;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTime;
#pragma warning disable 0169
		static Delegate GetGetTimeHandler ()
		{
			if (cb_getTime == null)
				cb_getTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTime);
			return cb_getTime;
		}

		static IntPtr n_GetTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Time);
		}
#pragma warning restore 0169

		static Delegate cb_setTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setTime_Ljava_lang_Long_ == null)
				cb_setTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTime_Ljava_lang_Long_);
			return cb_setTime_Ljava_lang_Long_;
		}

		static void n_SetTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Time = p0;
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Long Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()Ljava/lang/Long;", "GetGetTimeHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setTime", "(Ljava/lang/Long;)V", "GetSetTime_Ljava_lang_Long_Handler")] set;
		}

		static Delegate cb_addACC_arrayLcom_vivalnk_sdk_model_Motion_;
#pragma warning disable 0169
		static Delegate GetAddACC_arrayLcom_vivalnk_sdk_model_Motion_Handler ()
		{
			if (cb_addACC_arrayLcom_vivalnk_sdk_model_Motion_ == null)
				cb_addACC_arrayLcom_vivalnk_sdk_model_Motion_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddACC_arrayLcom_vivalnk_sdk_model_Motion_);
			return cb_addACC_arrayLcom_vivalnk_sdk_model_Motion_;
		}

		static void n_AddACC_arrayLcom_vivalnk_sdk_model_Motion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Model.Motion[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Model.Motion));
			__this.AddACC (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='addACC' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Motion...']]"
		[Register ("addACC", "([Lcom/vivalnk/sdk/model/Motion;)V", "GetAddACC_arrayLcom_vivalnk_sdk_model_Motion_Handler")]
		public virtual unsafe void AddACC (params global::Com.Vivalnk.Sdk.Model.Motion[] p0)
		{
			const string __id = "addACC.([Lcom/vivalnk/sdk/model/Motion;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addECG_arrayI;
#pragma warning disable 0169
		static Delegate GetAddECG_arrayIHandler ()
		{
			if (cb_addECG_arrayI == null)
				cb_addECG_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddECG_arrayI);
			return cb_addECG_arrayI;
		}

		static void n_AddECG_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AddECG (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='addECG' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addECG", "([I)V", "GetAddECG_arrayIHandler")]
		public virtual unsafe void AddECG (params int[] p0)
		{
			const string __id = "addECG.([I)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addRRI_arrayI;
#pragma warning disable 0169
		static Delegate GetAddRRI_arrayIHandler ()
		{
			if (cb_addRRI_arrayI == null)
				cb_addRRI_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddRRI_arrayI);
			return cb_addRRI_arrayI;
		}

		static void n_AddRRI_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AddRRI (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='addRRI' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addRRI", "([I)V", "GetAddRRI_arrayIHandler")]
		public virtual unsafe void AddRRI (params int[] p0)
		{
			const string __id = "addRRI.([I)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addRWL_arrayI;
#pragma warning disable 0169
		static Delegate GetAddRWL_arrayIHandler ()
		{
			if (cb_addRWL_arrayI == null)
				cb_addRWL_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddRWL_arrayI);
			return cb_addRWL_arrayI;
		}

		static void n_AddRWL_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AddRWL (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='addRWL' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addRWL", "([I)V", "GetAddRWL_arrayIHandler")]
		public virtual unsafe void AddRWL (params int[] p0)
		{
			const string __id = "addRWL.([I)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_format;
#pragma warning disable 0169
		static Delegate GetFormatHandler ()
		{
			if (cb_format == null)
				cb_format = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Format);
			return cb_format;
		}

		static IntPtr n_Format (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Format ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='format' and count(parameter)=0]"
		[Register ("format", "()Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;", "GetFormatHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormated Format ()
		{
			const string __id = "format.()Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormated> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getACC;
#pragma warning disable 0169
		static Delegate GetGetACCHandler ()
		{
			if (cb_getACC == null)
				cb_getACC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetACC);
			return cb_getACC;
		}

		static IntPtr n_GetACC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetACC ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getACC' and count(parameter)=0]"
		[Register ("getACC", "()[Lcom/vivalnk/sdk/model/Motion;", "GetGetACCHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Model.Motion[] GetACC ()
		{
			const string __id = "getACC.()[Lcom/vivalnk/sdk/model/Motion;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Com.Vivalnk.Sdk.Model.Motion[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Model.Motion));
			} finally {
			}
		}

		static Delegate cb_getData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetData_Ljava_lang_String_Handler ()
		{
			if (cb_getData_Ljava_lang_String_ == null)
				cb_getData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetData_Ljava_lang_String_);
			return cb_getData_Ljava_lang_String_;
		}

		static IntPtr n_GetData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetData (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getData", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetData_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object GetData (string p0)
		{
			const string __id = "getData.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getECG;
#pragma warning disable 0169
		static Delegate GetGetECGHandler ()
		{
			if (cb_getECG == null)
				cb_getECG = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetECG);
			return cb_getECG;
		}

		static IntPtr n_GetECG (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetECG ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getECG' and count(parameter)=0]"
		[Register ("getECG", "()[I", "GetGetECGHandler")]
		public virtual unsafe int[] GetECG ()
		{
			const string __id = "getECG.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getRRI;
#pragma warning disable 0169
		static Delegate GetGetRRIHandler ()
		{
			if (cb_getRRI == null)
				cb_getRRI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRRI);
			return cb_getRRI;
		}

		static IntPtr n_GetRRI (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRRI ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getRRI' and count(parameter)=0]"
		[Register ("getRRI", "()[I", "GetGetRRIHandler")]
		public virtual unsafe int[] GetRRI ()
		{
			const string __id = "getRRI.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getRWL;
#pragma warning disable 0169
		static Delegate GetGetRWLHandler ()
		{
			if (cb_getRWL == null)
				cb_getRWL = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRWL);
			return cb_getRWL;
		}

		static IntPtr n_GetRWL (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRWL ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getRWL' and count(parameter)=0]"
		[Register ("getRWL", "()[I", "GetGetRWLHandler")]
		public virtual unsafe int[] GetRWL ()
		{
			const string __id = "getRWL.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getRealEcgValue;
#pragma warning disable 0169
		static Delegate GetGetRealEcgValueHandler ()
		{
			if (cb_getRealEcgValue == null)
				cb_getRealEcgValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRealEcgValue);
			return cb_getRealEcgValue;
		}

		static IntPtr n_GetRealEcgValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRealEcgValue ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getRealEcgValue' and count(parameter)=0]"
		[Register ("getRealEcgValue", "()[F", "GetGetRealEcgValueHandler")]
		public virtual unsafe float[] GetRealEcgValue ()
		{
			const string __id = "getRealEcgValue.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_initWithFormated_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormated_;
#pragma warning disable 0169
		static Delegate GetInitWithFormated_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormated_Handler ()
		{
			if (cb_initWithFormated_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormated_ == null)
				cb_initWithFormated_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormated_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InitWithFormated_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormated_);
			return cb_initWithFormated_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormated_;
		}

		static void n_InitWithFormated_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormated_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormated> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitWithFormated (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='initWithFormated' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.data.DataJsonConverter.DataFormated']]"
		[Register ("initWithFormated", "(Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;)V", "GetInitWithFormated_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormated_Handler")]
		public virtual unsafe void InitWithFormated (global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormated p0)
		{
			const string __id = "initWithFormated.(Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isActivity;
#pragma warning disable 0169
		static Delegate GetIsActivityHandler ()
		{
			if (cb_isActivity == null)
				cb_isActivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsActivity);
			return cb_isActivity;
		}

		static IntPtr n_IsActivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsActivity ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='isActivity' and count(parameter)=0]"
		[Register ("isActivity", "()Ljava/lang/Boolean;", "GetIsActivityHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsActivity ()
		{
			const string __id = "isActivity.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isFlash;
#pragma warning disable 0169
		static Delegate GetIsFlashHandler ()
		{
			if (cb_isFlash == null)
				cb_isFlash = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsFlash);
			return cb_isFlash;
		}

		static IntPtr n_IsFlash (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsFlash ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='isFlash' and count(parameter)=0]"
		[Register ("isFlash", "()Ljava/lang/Boolean;", "GetIsFlashHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsFlash ()
		{
			const string __id = "isFlash.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isFromSameDevice_Lcom_vivalnk_sdk_model_common_IVitalData_;
#pragma warning disable 0169
		static Delegate GetIsFromSameDevice_Lcom_vivalnk_sdk_model_common_IVitalData_Handler ()
		{
			if (cb_isFromSameDevice_Lcom_vivalnk_sdk_model_common_IVitalData_ == null)
				cb_isFromSameDevice_Lcom_vivalnk_sdk_model_common_IVitalData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsFromSameDevice_Lcom_vivalnk_sdk_model_common_IVitalData_);
			return cb_isFromSameDevice_Lcom_vivalnk_sdk_model_common_IVitalData_;
		}

		static bool n_IsFromSameDevice_Lcom_vivalnk_sdk_model_common_IVitalData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsFromSameDevice (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='isFromSameDevice' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.common.IVitalData']]"
		[Register ("isFromSameDevice", "(Lcom/vivalnk/sdk/model/common/IVitalData;)Z", "GetIsFromSameDevice_Lcom_vivalnk_sdk_model_common_IVitalData_Handler")]
		public virtual unsafe bool IsFromSameDevice (global::Com.Vivalnk.Sdk.Model.Common.IVitalData p0)
		{
			const string __id = "isFromSameDevice.(Lcom/vivalnk/sdk/model/common/IVitalData;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isLeadOn;
#pragma warning disable 0169
		static Delegate GetIsLeadOnHandler ()
		{
			if (cb_isLeadOn == null)
				cb_isLeadOn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsLeadOn);
			return cb_isLeadOn;
		}

		static IntPtr n_IsLeadOn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsLeadOn ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='isLeadOn' and count(parameter)=0]"
		[Register ("isLeadOn", "()Ljava/lang/Boolean;", "GetIsLeadOnHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsLeadOn ()
		{
			const string __id = "isLeadOn.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_putData_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPutData_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_putData_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_putData_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PutData_Ljava_lang_String_Ljava_lang_Object_);
			return cb_putData_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_PutData_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutData (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='putData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("putData", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetPutData_Ljava_lang_String_Ljava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe void PutData (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "putData.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveData_Ljava_lang_String_Handler ()
		{
			if (cb_removeData_Ljava_lang_String_ == null)
				cb_removeData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveData_Ljava_lang_String_);
			return cb_removeData_Ljava_lang_String_;
		}

		static void n_RemoveData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveData (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='removeData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeData", "(Ljava/lang/String;)V", "GetRemoveData_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe void RemoveData (string p0)
		{
			const string __id = "removeData.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setACC_arrayLcom_vivalnk_sdk_model_Motion_;
#pragma warning disable 0169
		static Delegate GetSetACC_arrayLcom_vivalnk_sdk_model_Motion_Handler ()
		{
			if (cb_setACC_arrayLcom_vivalnk_sdk_model_Motion_ == null)
				cb_setACC_arrayLcom_vivalnk_sdk_model_Motion_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetACC_arrayLcom_vivalnk_sdk_model_Motion_);
			return cb_setACC_arrayLcom_vivalnk_sdk_model_Motion_;
		}

		static void n_SetACC_arrayLcom_vivalnk_sdk_model_Motion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Model.Motion[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Model.Motion));
			__this.SetACC (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setACC' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Motion[]']]"
		[Register ("setACC", "([Lcom/vivalnk/sdk/model/Motion;)V", "GetSetACC_arrayLcom_vivalnk_sdk_model_Motion_Handler")]
		public virtual unsafe void SetACC (global::Com.Vivalnk.Sdk.Model.Motion[] p0)
		{
			const string __id = "setACC.([Lcom/vivalnk/sdk/model/Motion;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setActivity_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetActivity_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setActivity_Ljava_lang_Boolean_ == null)
				cb_setActivity_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetActivity_Ljava_lang_Boolean_);
			return cb_setActivity_Ljava_lang_Boolean_;
		}

		static void n_SetActivity_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActivity (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setActivity' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setActivity", "(Ljava/lang/Boolean;)V", "GetSetActivity_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetActivity (global::Java.Lang.Boolean p0)
		{
			const string __id = "setActivity.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setECG_arrayI;
#pragma warning disable 0169
		static Delegate GetSetECG_arrayIHandler ()
		{
			if (cb_setECG_arrayI == null)
				cb_setECG_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetECG_arrayI);
			return cb_setECG_arrayI;
		}

		static void n_SetECG_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetECG (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setECG' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setECG", "([I)V", "GetSetECG_arrayIHandler")]
		public virtual unsafe void SetECG (int[] p0)
		{
			const string __id = "setECG.([I)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setFlash_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetFlash_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setFlash_Ljava_lang_Boolean_ == null)
				cb_setFlash_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFlash_Ljava_lang_Boolean_);
			return cb_setFlash_Ljava_lang_Boolean_;
		}

		static void n_SetFlash_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFlash (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setFlash' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setFlash", "(Ljava/lang/Boolean;)V", "GetSetFlash_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetFlash (global::Java.Lang.Boolean p0)
		{
			const string __id = "setFlash.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLeadOn_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetLeadOn_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setLeadOn_Ljava_lang_Boolean_ == null)
				cb_setLeadOn_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLeadOn_Ljava_lang_Boolean_);
			return cb_setLeadOn_Ljava_lang_Boolean_;
		}

		static void n_SetLeadOn_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLeadOn (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setLeadOn' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setLeadOn", "(Ljava/lang/Boolean;)V", "GetSetLeadOn_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetLeadOn (global::Java.Lang.Boolean p0)
		{
			const string __id = "setLeadOn.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRRI_arrayI;
#pragma warning disable 0169
		static Delegate GetSetRRI_arrayIHandler ()
		{
			if (cb_setRRI_arrayI == null)
				cb_setRRI_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRRI_arrayI);
			return cb_setRRI_arrayI;
		}

		static void n_SetRRI_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetRRI (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setRRI' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setRRI", "([I)V", "GetSetRRI_arrayIHandler")]
		public virtual unsafe void SetRRI (int[] p0)
		{
			const string __id = "setRRI.([I)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setRWL_arrayI;
#pragma warning disable 0169
		static Delegate GetSetRWL_arrayIHandler ()
		{
			if (cb_setRWL_arrayI == null)
				cb_setRWL_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRWL_arrayI);
			return cb_setRWL_arrayI;
		}

		static void n_SetRWL_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetRWL (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setRWL' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setRWL", "([I)V", "GetSetRWL_arrayIHandler")]
		public virtual unsafe void SetRWL (int[] p0)
		{
			const string __id = "setRWL.([I)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_toFullString;
#pragma warning disable 0169
		static Delegate GetToFullStringHandler ()
		{
			if (cb_toFullString == null)
				cb_toFullString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToFullString);
			return cb_toFullString;
		}

		static IntPtr n_ToFullString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToFullString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='toFullString' and count(parameter)=0]"
		[Register ("toFullString", "()Ljava/lang/String;", "GetToFullStringHandler")]
		public virtual unsafe string ToFullString ()
		{
			const string __id = "toFullString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toSimpleString;
#pragma warning disable 0169
		static Delegate GetToSimpleStringHandler ()
		{
			if (cb_toSimpleString == null)
				cb_toSimpleString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToSimpleString);
			return cb_toSimpleString;
		}

		static IntPtr n_ToSimpleString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Common.IVitalData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToSimpleString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='toSimpleString' and count(parameter)=0]"
		[Register ("toSimpleString", "()Ljava/lang/String;", "GetToSimpleStringHandler")]
		public virtual unsafe string ToSimpleString ()
		{
			const string __id = "toSimpleString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/common/IVitalData", DoNotGenerateAcw=true)]
	internal partial class IVitalDataInvoker : IVitalData {

		public IVitalDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/common/IVitalData", typeof (IVitalDataInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe string DeviceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getDeviceID' and count(parameter)=0]"
			[Register ("getDeviceID", "()Ljava/lang/String;", "GetGetDeviceIDHandler")]
			get {
				const string __id = "getDeviceID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setDeviceID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceID", "(Ljava/lang/String;)V", "GetSetDeviceID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceID.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public override unsafe global::Com.Vivalnk.Sdk.Model.DeviceModel DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Lcom/vivalnk/sdk/model/DeviceModel;", "GetGetDeviceModelHandler")]
			get {
				const string __id = "getDeviceModel.()Lcom/vivalnk/sdk/model/DeviceModel;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setDeviceModel' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.DeviceModel']]"
			[Register ("setDeviceModel", "(Lcom/vivalnk/sdk/model/DeviceModel;)V", "GetSetDeviceModel_Lcom_vivalnk_sdk_model_DeviceModel_Handler")]
			set {
				const string __id = "setDeviceModel.(Lcom/vivalnk/sdk/model/DeviceModel;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler")]
			get {
				const string __id = "getDeviceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setDeviceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceName", "(Ljava/lang/String;)V", "GetSetDeviceName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public override unsafe string DeviceSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getDeviceSN' and count(parameter)=0]"
			[Register ("getDeviceSN", "()Ljava/lang/String;", "GetGetDeviceSNHandler")]
			get {
				const string __id = "getDeviceSN.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setDeviceSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceSN", "(Ljava/lang/String;)V", "GetSetDeviceSN_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceSN.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Extras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getExtras' and count(parameter)=0]"
			[Register ("getExtras", "()Ljava/util/Map;", "GetGetExtrasHandler")]
			get {
				const string __id = "getExtras.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("setExtras", "(Ljava/util/Map;)V", "GetSetExtras_Ljava_util_Map_Handler")]
			set {
				const string __id = "setExtras.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public override unsafe long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler")]
			get {
				const string __id = "getId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setId", "(J)V", "GetSetId_JHandler")]
			set {
				const string __id = "setId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe global::Java.Lang.Long Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()Ljava/lang/Long;", "GetGetTimeHandler")]
			get {
				const string __id = "getTime.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='IVitalData']/method[@name='setTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setTime", "(Ljava/lang/Long;)V", "GetSetTime_Ljava_lang_Long_Handler")]
			set {
				const string __id = "setTime.(Ljava/lang/Long;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}

}
