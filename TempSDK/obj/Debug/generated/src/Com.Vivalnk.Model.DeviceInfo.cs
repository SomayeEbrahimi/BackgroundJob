using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.model']/class[@name='DeviceInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/model/DeviceInfo", DoNotGenerateAcw=true)]
	public partial class DeviceInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/model/DeviceInfo", typeof (DeviceInfo));
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

		protected DeviceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.model']/class[@name='DeviceInfo']/constructor[@name='DeviceInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe DeviceInfo (string p0, string p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getDeviceType;
#pragma warning disable 0169
		static Delegate GetGetDeviceTypeHandler ()
		{
			if (cb_getDeviceType == null)
				cb_getDeviceType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceType);
			return cb_getDeviceType;
		}

		static IntPtr n_GetDeviceType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceType);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceType_Lcom_vivalnk_vdireader_VDIType_DEVICE_TYPE_;
#pragma warning disable 0169
		static Delegate GetSetDeviceType_Lcom_vivalnk_vdireader_VDIType_DEVICE_TYPE_Handler ()
		{
			if (cb_setDeviceType_Lcom_vivalnk_vdireader_VDIType_DEVICE_TYPE_ == null)
				cb_setDeviceType_Lcom_vivalnk_vdireader_VDIType_DEVICE_TYPE_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceType_Lcom_vivalnk_vdireader_VDIType_DEVICE_TYPE_);
			return cb_setDeviceType_Lcom_vivalnk_vdireader_VDIType_DEVICE_TYPE_;
		}

		static void n_SetDeviceType_Lcom_vivalnk_vdireader_VDIType_DEVICE_TYPE_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='DeviceInfo']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;", "GetGetDeviceTypeHandler")]
			get {
				const string __id = "getDeviceType.()Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.DEVICE_TYPE> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='DeviceInfo']/method[@name='setDeviceType' and count(parameter)=1 and parameter[1][@type='com.vivalnk.vdireader.VDIType.DEVICE_TYPE']]"
			[Register ("setDeviceType", "(Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;)V", "GetSetDeviceType_Lcom_vivalnk_vdireader_VDIType_DEVICE_TYPE_Handler")]
			set {
				const string __id = "setDeviceType.(Lcom/vivalnk/vdireader/VDIType$DEVICE_TYPE;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MacAddress = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string MacAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='DeviceInfo']/method[@name='getMacAddress' and count(parameter)=0]"
			[Register ("getMacAddress", "()Ljava/lang/String;", "GetGetMacAddressHandler")]
			get {
				const string __id = "getMacAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='DeviceInfo']/method[@name='setMacAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RSSI = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int RSSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='DeviceInfo']/method[@name='getRSSI' and count(parameter)=0]"
			[Register ("getRSSI", "()I", "GetGetRSSIHandler")]
			get {
				const string __id = "getRSSI.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='DeviceInfo']/method[@name='setRSSI' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SN = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='DeviceInfo']/method[@name='getSN' and count(parameter)=0]"
			[Register ("getSN", "()Ljava/lang/String;", "GetGetSNHandler")]
			get {
				const string __id = "getSN.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='DeviceInfo']/method[@name='setSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
