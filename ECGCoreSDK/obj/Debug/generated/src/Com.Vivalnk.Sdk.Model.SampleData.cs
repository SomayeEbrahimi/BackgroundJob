using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/SampleData", DoNotGenerateAcw=true)]
	public partial class SampleData : global::Com.Vivalnk.Sdk.Model.Common.IVitalData, global::Com.Vivalnk.Sdk.Model.Common.IDataSerializer, global::Java.IO.ISerializable {


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/SampleData", typeof (SampleData));
		internal static new IntPtr class_ref {
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

		protected SampleData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/constructor[@name='SampleData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SampleData ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/constructor[@name='SampleData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.data.DataJsonConverter.DataFormated']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;)V", "")]
		public unsafe SampleData (global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormated p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/constructor[@name='SampleData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.common.IVitalData']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/model/common/IVitalData;)V", "")]
		public unsafe SampleData (global::Com.Vivalnk.Sdk.Model.Common.IVitalData p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/model/common/IVitalData;)V";

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

		static Delegate cb_getAverageRr;
#pragma warning disable 0169
		static Delegate GetGetAverageRrHandler ()
		{
			if (cb_getAverageRr == null)
				cb_getAverageRr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAverageRr);
			return cb_getAverageRr;
		}

		static IntPtr n_GetAverageRr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AverageRr);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Float AverageRr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='getAverageRr' and count(parameter)=0]"
			[Register ("getAverageRr", "()Ljava/lang/Float;", "GetGetAverageRrHandler")]
			get {
				const string __id = "getAverageRr.()Ljava/lang/Float;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceID = p0;
		}
#pragma warning restore 0169

		public override unsafe string DeviceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='getDeviceID' and count(parameter)=0]"
			[Register ("getDeviceID", "()Ljava/lang/String;", "GetGetDeviceIDHandler")]
			get {
				const string __id = "getDeviceID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setDeviceID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceModel = p0;
		}
#pragma warning restore 0169

		public override unsafe global::Com.Vivalnk.Sdk.Model.DeviceModel DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Lcom/vivalnk/sdk/model/DeviceModel;", "GetGetDeviceModelHandler")]
			get {
				const string __id = "getDeviceModel.()Lcom/vivalnk/sdk/model/DeviceModel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setDeviceModel' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.DeviceModel']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceName = p0;
		}
#pragma warning restore 0169

		public override unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler")]
			get {
				const string __id = "getDeviceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setDeviceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceSN = p0;
		}
#pragma warning restore 0169

		public override unsafe string DeviceSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='getDeviceSN' and count(parameter)=0]"
			[Register ("getDeviceSN", "()Ljava/lang/String;", "GetGetDeviceSNHandler")]
			get {
				const string __id = "getDeviceSN.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setDeviceSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Extras = p0;
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Extras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='getExtras' and count(parameter)=0]"
			[Register ("getExtras", "()Ljava/util/Map;", "GetGetExtrasHandler")]
			get {
				const string __id = "getExtras.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("setExtras", "(Ljava/util/Map;)V", "GetSetExtras_Ljava_util_Map_Handler")]
			set {
				const string __id = "setExtras.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHr;
#pragma warning disable 0169
		static Delegate GetGetHrHandler ()
		{
			if (cb_getHr == null)
				cb_getHr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHr);
			return cb_getHr;
		}

		static IntPtr n_GetHr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Hr);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer Hr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='getHr' and count(parameter)=0]"
			[Register ("getHr", "()Ljava/lang/Integer;", "GetGetHrHandler")]
			get {
				const string __id = "getHr.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		public override unsafe long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler")]
			get {
				const string __id = "getId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static Delegate cb_getRr;
#pragma warning disable 0169
		static Delegate GetGetRrHandler ()
		{
			if (cb_getRr == null)
				cb_getRr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRr);
			return cb_getRr;
		}

		static IntPtr n_GetRr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rr);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Float Rr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='getRr' and count(parameter)=0]"
			[Register ("getRr", "()Ljava/lang/Float;", "GetGetRrHandler")]
			get {
				const string __id = "getRr.()Ljava/lang/Float;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Time = p0;
		}
#pragma warning restore 0169

		public override unsafe global::Java.Lang.Long Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()Ljava/lang/Long;", "GetGetTimeHandler")]
			get {
				const string __id = "getTime.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setTime", "(Ljava/lang/Long;)V", "GetSetTime_Ljava_lang_Long_Handler")]
			set {
				const string __id = "setTime.(Ljava/lang/Long;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/vivalnk/sdk/model/SampleData;", "GetCloneHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Model.SampleData Clone ()
		{
			const string __id = "clone.()Lcom/vivalnk/sdk/model/SampleData;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAcc_arrayLcom_vivalnk_sdk_model_Motion_;
#pragma warning disable 0169
		static Delegate GetSetAcc_arrayLcom_vivalnk_sdk_model_Motion_Handler ()
		{
			if (cb_setAcc_arrayLcom_vivalnk_sdk_model_Motion_ == null)
				cb_setAcc_arrayLcom_vivalnk_sdk_model_Motion_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAcc_arrayLcom_vivalnk_sdk_model_Motion_);
			return cb_setAcc_arrayLcom_vivalnk_sdk_model_Motion_;
		}

		static void n_SetAcc_arrayLcom_vivalnk_sdk_model_Motion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Model.Motion[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Model.Motion));
			__this.SetAcc (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setAcc' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Motion[]']]"
		[Register ("setAcc", "([Lcom/vivalnk/sdk/model/Motion;)V", "GetSetAcc_arrayLcom_vivalnk_sdk_model_Motion_Handler")]
		public virtual unsafe void SetAcc (global::Com.Vivalnk.Sdk.Model.Motion[] p0)
		{
			const string __id = "setAcc.([Lcom/vivalnk/sdk/model/Motion;)V";
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

		static Delegate cb_setEcg_arrayI;
#pragma warning disable 0169
		static Delegate GetSetEcg_arrayIHandler ()
		{
			if (cb_setEcg_arrayI == null)
				cb_setEcg_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEcg_arrayI);
			return cb_setEcg_arrayI;
		}

		static void n_SetEcg_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetEcg (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setEcg' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setEcg", "([I)V", "GetSetEcg_arrayIHandler")]
		public virtual unsafe void SetEcg (int[] p0)
		{
			const string __id = "setEcg.([I)V";
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

		static Delegate cb_setRri_arrayI;
#pragma warning disable 0169
		static Delegate GetSetRri_arrayIHandler ()
		{
			if (cb_setRri_arrayI == null)
				cb_setRri_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRri_arrayI);
			return cb_setRri_arrayI;
		}

		static void n_SetRri_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetRri (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setRri' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setRri", "([I)V", "GetSetRri_arrayIHandler")]
		public virtual unsafe void SetRri (int[] p0)
		{
			const string __id = "setRri.([I)V";
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

		static Delegate cb_setRwl_arrayI;
#pragma warning disable 0169
		static Delegate GetSetRwl_arrayIHandler ()
		{
			if (cb_setRwl_arrayI == null)
				cb_setRwl_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRwl_arrayI);
			return cb_setRwl_arrayI;
		}

		static void n_SetRwl_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetRwl (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='setRwl' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setRwl", "([I)V", "GetSetRwl_arrayIHandler")]
		public virtual unsafe void SetRwl (int[] p0)
		{
			const string __id = "setRwl.([I)V";
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

		static Delegate cb_toFileString;
#pragma warning disable 0169
		static Delegate GetToFileStringHandler ()
		{
			if (cb_toFileString == null)
				cb_toFileString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToFileString);
			return cb_toFileString;
		}

		static IntPtr n_ToFileString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToFileString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='SampleData']/method[@name='toFileString' and count(parameter)=0]"
		[Register ("toFileString", "()Ljava/lang/String;", "GetToFileStringHandler")]
		public virtual unsafe string ToFileString ()
		{
			const string __id = "toFileString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}