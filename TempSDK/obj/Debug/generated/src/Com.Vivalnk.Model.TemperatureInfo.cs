using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/model/TemperatureInfo", DoNotGenerateAcw=true)]
	public partial class TemperatureInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/model/TemperatureInfo", typeof (TemperatureInfo));
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

		protected TemperatureInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/constructor[@name='TemperatureInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;FI)V", "")]
		public unsafe TemperatureInfo (string p0, float p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;FI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getFinalTemperature;
#pragma warning disable 0169
		static Delegate GetGetFinalTemperatureHandler ()
		{
			if (cb_getFinalTemperature == null)
				cb_getFinalTemperature = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetFinalTemperature);
			return cb_getFinalTemperature;
		}

		static float n_GetFinalTemperature (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalTemperature;
		}
#pragma warning restore 0169

		static Delegate cb_setFinalTemperature_F;
#pragma warning disable 0169
		static Delegate GetSetFinalTemperature_FHandler ()
		{
			if (cb_setFinalTemperature_F == null)
				cb_setFinalTemperature_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetFinalTemperature_F);
			return cb_setFinalTemperature_F;
		}

		static void n_SetFinalTemperature_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinalTemperature = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float FinalTemperature {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getFinalTemperature' and count(parameter)=0]"
			[Register ("getFinalTemperature", "()F", "GetGetFinalTemperatureHandler")]
			get {
				const string __id = "getFinalTemperature.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setFinalTemperature' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFinalTemperature", "(F)V", "GetSetFinalTemperature_FHandler")]
			set {
				const string __id = "setFinalTemperature.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMacAddress;
#pragma warning disable 0169
		static Delegate GetGetMacAddressHandler ()
		{
			if (cb_getMacAddress == null)
				cb_getMacAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMacAddress);
			return cb_getMacAddress;
		}

		static IntPtr n_GetMacAddress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MacAddress);
		}
#pragma warning restore 0169

		static Delegate cb_setMacAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMacAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setMacAddress_Ljava_lang_String_ == null)
				cb_setMacAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMacAddress_Ljava_lang_String_);
			return cb_setMacAddress_Ljava_lang_String_;
		}

		static void n_SetMacAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MacAddress = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string MacAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getMacAddress' and count(parameter)=0]"
			[Register ("getMacAddress", "()Ljava/lang/String;", "GetGetMacAddressHandler")]
			get {
				const string __id = "getMacAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setMacAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMacAddress", "(Ljava/lang/String;)V", "GetSetMacAddress_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMacAddress.(Ljava/lang/String;)V";
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

		static Delegate cb_getPatchBatteryLevel;
#pragma warning disable 0169
		static Delegate GetGetPatchBatteryLevelHandler ()
		{
			if (cb_getPatchBatteryLevel == null)
				cb_getPatchBatteryLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPatchBatteryLevel);
			return cb_getPatchBatteryLevel;
		}

		static int n_GetPatchBatteryLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PatchBatteryLevel;
		}
#pragma warning restore 0169

		static Delegate cb_setPatchBatteryLevel_I;
#pragma warning disable 0169
		static Delegate GetSetPatchBatteryLevel_IHandler ()
		{
			if (cb_setPatchBatteryLevel_I == null)
				cb_setPatchBatteryLevel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetPatchBatteryLevel_I);
			return cb_setPatchBatteryLevel_I;
		}

		static void n_SetPatchBatteryLevel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PatchBatteryLevel = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int PatchBatteryLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getPatchBatteryLevel' and count(parameter)=0]"
			[Register ("getPatchBatteryLevel", "()I", "GetGetPatchBatteryLevelHandler")]
			get {
				const string __id = "getPatchBatteryLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setPatchBatteryLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPatchBatteryLevel", "(I)V", "GetSetPatchBatteryLevel_IHandler")]
			set {
				const string __id = "setPatchBatteryLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPatchFW;
#pragma warning disable 0169
		static Delegate GetGetPatchFWHandler ()
		{
			if (cb_getPatchFW == null)
				cb_getPatchFW = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPatchFW);
			return cb_getPatchFW;
		}

		static IntPtr n_GetPatchFW (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PatchFW);
		}
#pragma warning restore 0169

		static Delegate cb_setPatchFW_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPatchFW_Ljava_lang_String_Handler ()
		{
			if (cb_setPatchFW_Ljava_lang_String_ == null)
				cb_setPatchFW_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPatchFW_Ljava_lang_String_);
			return cb_setPatchFW_Ljava_lang_String_;
		}

		static void n_SetPatchFW_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PatchFW = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PatchFW {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getPatchFW' and count(parameter)=0]"
			[Register ("getPatchFW", "()Ljava/lang/String;", "GetGetPatchFWHandler")]
			get {
				const string __id = "getPatchFW.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setPatchFW' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPatchFW", "(Ljava/lang/String;)V", "GetSetPatchFW_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPatchFW.(Ljava/lang/String;)V";
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

		static Delegate cb_getRSSI;
#pragma warning disable 0169
		static Delegate GetGetRSSIHandler ()
		{
			if (cb_getRSSI == null)
				cb_getRSSI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRSSI);
			return cb_getRSSI;
		}

		static int n_GetRSSI (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RSSI;
		}
#pragma warning restore 0169

		static Delegate cb_setRSSI_I;
#pragma warning disable 0169
		static Delegate GetSetRSSI_IHandler ()
		{
			if (cb_setRSSI_I == null)
				cb_setRSSI_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRSSI_I);
			return cb_setRSSI_I;
		}

		static void n_SetRSSI_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RSSI = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int RSSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getRSSI' and count(parameter)=0]"
			[Register ("getRSSI", "()I", "GetGetRSSIHandler")]
			get {
				const string __id = "getRSSI.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setRSSI' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRSSI", "(I)V", "GetSetRSSI_IHandler")]
			set {
				const string __id = "setRSSI.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRawTemperature;
#pragma warning disable 0169
		static Delegate GetGetRawTemperatureHandler ()
		{
			if (cb_getRawTemperature == null)
				cb_getRawTemperature = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetRawTemperature);
			return cb_getRawTemperature;
		}

		static float n_GetRawTemperature (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RawTemperature;
		}
#pragma warning restore 0169

		static Delegate cb_setRawTemperature_F;
#pragma warning disable 0169
		static Delegate GetSetRawTemperature_FHandler ()
		{
			if (cb_setRawTemperature_F == null)
				cb_setRawTemperature_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetRawTemperature_F);
			return cb_setRawTemperature_F;
		}

		static void n_SetRawTemperature_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RawTemperature = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float RawTemperature {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getRawTemperature' and count(parameter)=0]"
			[Register ("getRawTemperature", "()F", "GetGetRawTemperatureHandler")]
			get {
				const string __id = "getRawTemperature.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setRawTemperature' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRawTemperature", "(F)V", "GetSetRawTemperature_FHandler")]
			set {
				const string __id = "setRawTemperature.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSN;
#pragma warning disable 0169
		static Delegate GetGetSNHandler ()
		{
			if (cb_getSN == null)
				cb_getSN = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSN);
			return cb_getSN;
		}

		static IntPtr n_GetSN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SN);
		}
#pragma warning restore 0169

		static Delegate cb_setSN_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSN_Ljava_lang_String_Handler ()
		{
			if (cb_setSN_Ljava_lang_String_ == null)
				cb_setSN_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSN_Ljava_lang_String_);
			return cb_setSN_Ljava_lang_String_;
		}

		static void n_SetSN_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SN = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getSN' and count(parameter)=0]"
			[Register ("getSN", "()Ljava/lang/String;", "GetGetSNHandler")]
			get {
				const string __id = "getSN.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSN", "(Ljava/lang/String;)V", "GetSetSN_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSN.(Ljava/lang/String;)V";
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

		static Delegate cb_getTemperatureStatus;
#pragma warning disable 0169
		static Delegate GetGetTemperatureStatusHandler ()
		{
			if (cb_getTemperatureStatus == null)
				cb_getTemperatureStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTemperatureStatus);
			return cb_getTemperatureStatus;
		}

		static IntPtr n_GetTemperatureStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TemperatureStatus);
		}
#pragma warning restore 0169

		static Delegate cb_setTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_;
#pragma warning disable 0169
		static Delegate GetSetTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_Handler ()
		{
			if (cb_setTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_ == null)
				cb_setTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_);
			return cb_setTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_;
		}

		static void n_SetTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TemperatureStatus = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS TemperatureStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getTemperatureStatus' and count(parameter)=0]"
			[Register ("getTemperatureStatus", "()Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;", "GetGetTemperatureStatusHandler")]
			get {
				const string __id = "getTemperatureStatus.()Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setTemperatureStatus' and count(parameter)=1 and parameter[1][@type='com.vivalnk.vdireader.VDIType.TEMPERATURE_STATUS']]"
			[Register ("setTemperatureStatus", "(Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;)V", "GetSetTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_Handler")]
			set {
				const string __id = "setTemperatureStatus.(Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
