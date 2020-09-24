using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/Patch", DoNotGenerateAcw=true)]
	public partial class Patch : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/field[@name='MODEL_VV310']"
		[Register ("MODEL_VV310")]
		public static string ModelVv310 {
			get {
				const string __id = "MODEL_VV310.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "MODEL_VV310.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/field[@name='MODEL_VV330']"
		[Register ("MODEL_VV330")]
		public static string ModelVv330 {
			get {
				const string __id = "MODEL_VV330.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "MODEL_VV330.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/Patch", typeof (Patch));
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

		protected Patch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/constructor[@name='Patch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Patch ()
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

		static Delegate cb_getAccSamplingAccuracy;
#pragma warning disable 0169
		static Delegate GetGetAccSamplingAccuracyHandler ()
		{
			if (cb_getAccSamplingAccuracy == null)
				cb_getAccSamplingAccuracy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAccSamplingAccuracy);
			return cb_getAccSamplingAccuracy;
		}

		static int n_GetAccSamplingAccuracy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AccSamplingAccuracy;
		}
#pragma warning restore 0169

		static Delegate cb_setAccSamplingAccuracy_I;
#pragma warning disable 0169
		static Delegate GetSetAccSamplingAccuracy_IHandler ()
		{
			if (cb_setAccSamplingAccuracy_I == null)
				cb_setAccSamplingAccuracy_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAccSamplingAccuracy_I);
			return cb_setAccSamplingAccuracy_I;
		}

		static void n_SetAccSamplingAccuracy_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AccSamplingAccuracy = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int AccSamplingAccuracy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getAccSamplingAccuracy' and count(parameter)=0]"
			[Register ("getAccSamplingAccuracy", "()I", "GetGetAccSamplingAccuracyHandler")]
			get {
				const string __id = "getAccSamplingAccuracy.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setAccSamplingAccuracy' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAccSamplingAccuracy", "(I)V", "GetSetAccSamplingAccuracy_IHandler")]
			set {
				const string __id = "setAccSamplingAccuracy.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAccSamplingFrequency;
#pragma warning disable 0169
		static Delegate GetGetAccSamplingFrequencyHandler ()
		{
			if (cb_getAccSamplingFrequency == null)
				cb_getAccSamplingFrequency = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAccSamplingFrequency);
			return cb_getAccSamplingFrequency;
		}

		static int n_GetAccSamplingFrequency (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AccSamplingFrequency;
		}
#pragma warning restore 0169

		static Delegate cb_setAccSamplingFrequency_I;
#pragma warning disable 0169
		static Delegate GetSetAccSamplingFrequency_IHandler ()
		{
			if (cb_setAccSamplingFrequency_I == null)
				cb_setAccSamplingFrequency_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAccSamplingFrequency_I);
			return cb_setAccSamplingFrequency_I;
		}

		static void n_SetAccSamplingFrequency_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AccSamplingFrequency = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int AccSamplingFrequency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getAccSamplingFrequency' and count(parameter)=0]"
			[Register ("getAccSamplingFrequency", "()I", "GetGetAccSamplingFrequencyHandler")]
			get {
				const string __id = "getAccSamplingFrequency.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setAccSamplingFrequency' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAccSamplingFrequency", "(I)V", "GetSetAccSamplingFrequency_IHandler")]
			set {
				const string __id = "setAccSamplingFrequency.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.DeviceInfo);
		}
#pragma warning restore 0169

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceInfo = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> DeviceInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getDeviceInfo' and count(parameter)=0]"
			[Register ("getDeviceInfo", "()Ljava/util/Map;", "GetGetDeviceInfoHandler")]
			get {
				const string __id = "getDeviceInfo.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setDeviceInfo' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("setDeviceInfo", "(Ljava/util/Map;)V", "GetSetDeviceInfo_Ljava_util_Map_Handler")]
			set {
				const string __id = "setDeviceInfo.(Ljava/util/Map;)V";
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

		static Delegate cb_getEcgSamplingFrequency;
#pragma warning disable 0169
		static Delegate GetGetEcgSamplingFrequencyHandler ()
		{
			if (cb_getEcgSamplingFrequency == null)
				cb_getEcgSamplingFrequency = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEcgSamplingFrequency);
			return cb_getEcgSamplingFrequency;
		}

		static int n_GetEcgSamplingFrequency (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EcgSamplingFrequency;
		}
#pragma warning restore 0169

		static Delegate cb_setEcgSamplingFrequency_I;
#pragma warning disable 0169
		static Delegate GetSetEcgSamplingFrequency_IHandler ()
		{
			if (cb_setEcgSamplingFrequency_I == null)
				cb_setEcgSamplingFrequency_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetEcgSamplingFrequency_I);
			return cb_setEcgSamplingFrequency_I;
		}

		static void n_SetEcgSamplingFrequency_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EcgSamplingFrequency = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int EcgSamplingFrequency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getEcgSamplingFrequency' and count(parameter)=0]"
			[Register ("getEcgSamplingFrequency", "()I", "GetGetEcgSamplingFrequencyHandler")]
			get {
				const string __id = "getEcgSamplingFrequency.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setEcgSamplingFrequency' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEcgSamplingFrequency", "(I)V", "GetSetEcgSamplingFrequency_IHandler")]
			set {
				const string __id = "setEcgSamplingFrequency.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isEncryption;
#pragma warning disable 0169
		static Delegate GetIsEncryptionHandler ()
		{
			if (cb_isEncryption == null)
				cb_isEncryption = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEncryption);
			return cb_isEncryption;
		}

		static bool n_IsEncryption (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Encryption;
		}
#pragma warning restore 0169

		static Delegate cb_setEncryption_Z;
#pragma warning disable 0169
		static Delegate GetSetEncryption_ZHandler ()
		{
			if (cb_setEncryption_Z == null)
				cb_setEncryption_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEncryption_Z);
			return cb_setEncryption_Z;
		}

		static void n_SetEncryption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Encryption = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool Encryption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='isEncryption' and count(parameter)=0]"
			[Register ("isEncryption", "()Z", "GetIsEncryptionHandler")]
			get {
				const string __id = "isEncryption.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setEncryption' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEncryption", "(Z)V", "GetSetEncryption_ZHandler")]
			set {
				const string __id = "setEncryption.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FwVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string FwVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getFwVersion' and count(parameter)=0]"
			[Register ("getFwVersion", "()Ljava/lang/String;", "GetGetFwVersionHandler")]
			get {
				const string __id = "getFwVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setFwVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_hasHR;
#pragma warning disable 0169
		static Delegate GetHasHRHandler ()
		{
			if (cb_hasHR == null)
				cb_hasHR = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasHR);
			return cb_hasHR;
		}

		static bool n_HasHR (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHR;
		}
#pragma warning restore 0169

		static Delegate cb_setHasHR_Z;
#pragma warning disable 0169
		static Delegate GetSetHasHR_ZHandler ()
		{
			if (cb_setHasHR_Z == null)
				cb_setHasHR_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetHasHR_Z);
			return cb_setHasHR_Z;
		}

		static void n_SetHasHR_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HasHR = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasHR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='hasHR' and count(parameter)=0]"
			[Register ("hasHR", "()Z", "GetHasHRHandler")]
			get {
				const string __id = "hasHR.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setHasHR' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHasHR", "(Z)V", "GetSetHasHR_ZHandler")]
			set {
				const string __id = "setHasHR.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HwVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string HwVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getHwVersion' and count(parameter)=0]"
			[Register ("getHwVersion", "()Ljava/lang/String;", "GetGetHwVersionHandler")]
			get {
				const string __id = "getHwVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setHwVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_isVV200;
#pragma warning disable 0169
		static Delegate GetIsVV200Handler ()
		{
			if (cb_isVV200 == null)
				cb_isVV200 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsVV200);
			return cb_isVV200;
		}

		static bool n_IsVV200 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVV200;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsVV200 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='isVV200' and count(parameter)=0]"
			[Register ("isVV200", "()Z", "GetIsVV200Handler")]
			get {
				const string __id = "isVV200.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isVV310;
#pragma warning disable 0169
		static Delegate GetIsVV310Handler ()
		{
			if (cb_isVV310 == null)
				cb_isVV310 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsVV310);
			return cb_isVV310;
		}

		static bool n_IsVV310 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVV310;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsVV310 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='isVV310' and count(parameter)=0]"
			[Register ("isVV310", "()Z", "GetIsVV310Handler")]
			get {
				const string __id = "isVV310.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isVV330;
#pragma warning disable 0169
		static Delegate GetIsVV330Handler ()
		{
			if (cb_isVV330 == null)
				cb_isVV330 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsVV330);
			return cb_isVV330;
		}

		static bool n_IsVV330 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVV330;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsVV330 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='isVV330' and count(parameter)=0]"
			[Register ("isVV330", "()Z", "GetIsVV330Handler")]
			get {
				const string __id = "isVV330.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isVV340;
#pragma warning disable 0169
		static Delegate GetIsVV340Handler ()
		{
			if (cb_isVV340 == null)
				cb_isVV340 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsVV340);
			return cb_isVV340;
		}

		static bool n_IsVV340 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVV340;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsVV340 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='isVV340' and count(parameter)=0]"
			[Register ("isVV340", "()Z", "GetIsVV340Handler")]
			get {
				const string __id = "isVV340.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isVVBP;
#pragma warning disable 0169
		static Delegate GetIsVVBPHandler ()
		{
			if (cb_isVVBP == null)
				cb_isVVBP = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsVVBP);
			return cb_isVVBP;
		}

		static bool n_IsVVBP (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVVBP;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsVVBP {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='isVVBP' and count(parameter)=0]"
			[Register ("isVVBP", "()Z", "GetIsVVBPHandler")]
			get {
				const string __id = "isVVBP.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Magnification = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Magnification {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getMagnification' and count(parameter)=0]"
			[Register ("getMagnification", "()I", "GetGetMagnificationHandler")]
			get {
				const string __id = "getMagnification.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setMagnification' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getManufacturer;
#pragma warning disable 0169
		static Delegate GetGetManufacturerHandler ()
		{
			if (cb_getManufacturer == null)
				cb_getManufacturer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetManufacturer);
			return cb_getManufacturer;
		}

		static IntPtr n_GetManufacturer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Manufacturer);
		}
#pragma warning restore 0169

		static Delegate cb_setManufacturer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetManufacturer_Ljava_lang_String_Handler ()
		{
			if (cb_setManufacturer_Ljava_lang_String_ == null)
				cb_setManufacturer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetManufacturer_Ljava_lang_String_);
			return cb_setManufacturer_Ljava_lang_String_;
		}

		static void n_SetManufacturer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Manufacturer = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Manufacturer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getManufacturer' and count(parameter)=0]"
			[Register ("getManufacturer", "()Ljava/lang/String;", "GetGetManufacturerHandler")]
			get {
				const string __id = "getManufacturer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setManufacturer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setManufacturer", "(Ljava/lang/String;)V", "GetSetManufacturer_Ljava_lang_String_Handler")]
			set {
				const string __id = "setManufacturer.(Ljava/lang/String;)V";
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

		static Delegate cb_getModel;
#pragma warning disable 0169
		static Delegate GetGetModelHandler ()
		{
			if (cb_getModel == null)
				cb_getModel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetModel);
			return cb_getModel;
		}

		static IntPtr n_GetModel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Model);
		}
#pragma warning restore 0169

		static Delegate cb_setModel_Lcom_vivalnk_sdk_model_DeviceModel_;
#pragma warning disable 0169
		static Delegate GetSetModel_Lcom_vivalnk_sdk_model_DeviceModel_Handler ()
		{
			if (cb_setModel_Lcom_vivalnk_sdk_model_DeviceModel_ == null)
				cb_setModel_Lcom_vivalnk_sdk_model_DeviceModel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetModel_Lcom_vivalnk_sdk_model_DeviceModel_);
			return cb_setModel_Lcom_vivalnk_sdk_model_DeviceModel_;
		}

		static void n_SetModel_Lcom_vivalnk_sdk_model_DeviceModel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Model = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Model.DeviceModel Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Lcom/vivalnk/sdk/model/DeviceModel;", "GetGetModelHandler")]
			get {
				const string __id = "getModel.()Lcom/vivalnk/sdk/model/DeviceModel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setModel' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.DeviceModel']]"
			[Register ("setModel", "(Lcom/vivalnk/sdk/model/DeviceModel;)V", "GetSetModel_Lcom_vivalnk_sdk_model_DeviceModel_Handler")]
			set {
				const string __id = "setModel.(Lcom/vivalnk/sdk/model/DeviceModel;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSamplingFrequency;
#pragma warning disable 0169
		static Delegate GetGetSamplingFrequencyHandler ()
		{
			if (cb_getSamplingFrequency == null)
				cb_getSamplingFrequency = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSamplingFrequency);
			return cb_getSamplingFrequency;
		}

		static int n_GetSamplingFrequency (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SamplingFrequency;
		}
#pragma warning restore 0169

		static Delegate cb_setSamplingFrequency_I;
#pragma warning disable 0169
		static Delegate GetSetSamplingFrequency_IHandler ()
		{
			if (cb_setSamplingFrequency_I == null)
				cb_setSamplingFrequency_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSamplingFrequency_I);
			return cb_setSamplingFrequency_I;
		}

		static void n_SetSamplingFrequency_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SamplingFrequency = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int SamplingFrequency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getSamplingFrequency' and count(parameter)=0]"
			[Register ("getSamplingFrequency", "()I", "GetGetSamplingFrequencyHandler")]
			get {
				const string __id = "getSamplingFrequency.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setSamplingFrequency' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSamplingFrequency", "(I)V", "GetSetSamplingFrequency_IHandler")]
			set {
				const string __id = "setSamplingFrequency.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSn;
#pragma warning disable 0169
		static Delegate GetGetSnHandler ()
		{
			if (cb_getSn == null)
				cb_getSn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSn);
			return cb_getSn;
		}

		static IntPtr n_GetSn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sn);
		}
#pragma warning restore 0169

		static Delegate cb_setSn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSn_Ljava_lang_String_Handler ()
		{
			if (cb_setSn_Ljava_lang_String_ == null)
				cb_setSn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSn_Ljava_lang_String_);
			return cb_setSn_Ljava_lang_String_;
		}

		static void n_SetSn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Sn = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Sn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getSn' and count(parameter)=0]"
			[Register ("getSn", "()Ljava/lang/String;", "GetGetSnHandler")]
			get {
				const string __id = "getSn.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setSn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSn", "(Ljava/lang/String;)V", "GetSetSn_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSn.(Ljava/lang/String;)V";
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

		static Delegate cb_getStatusInfo;
#pragma warning disable 0169
		static Delegate GetGetStatusInfoHandler ()
		{
			if (cb_getStatusInfo == null)
				cb_getStatusInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatusInfo);
			return cb_getStatusInfo;
		}

		static IntPtr n_GetStatusInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.StatusInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setStatusInfo_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetStatusInfo_Ljava_util_Map_Handler ()
		{
			if (cb_setStatusInfo_Ljava_util_Map_ == null)
				cb_setStatusInfo_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetStatusInfo_Ljava_util_Map_);
			return cb_setStatusInfo_Ljava_util_Map_;
		}

		static void n_SetStatusInfo_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StatusInfo = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> StatusInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='getStatusInfo' and count(parameter)=0]"
			[Register ("getStatusInfo", "()Ljava/util/Map;", "GetGetStatusInfoHandler")]
			get {
				const string __id = "getStatusInfo.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setStatusInfo' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("setStatusInfo", "(Ljava/util/Map;)V", "GetSetStatusInfo_Ljava_util_Map_Handler")]
			set {
				const string __id = "setStatusInfo.(Ljava/util/Map;)V";
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

		static Delegate cb_setModel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetModel_Ljava_lang_String_Handler ()
		{
			if (cb_setModel_Ljava_lang_String_ == null)
				cb_setModel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetModel_Ljava_lang_String_);
			return cb_setModel_Ljava_lang_String_;
		}

		static void n_SetModel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetModel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Patch']/method[@name='setModel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setModel", "(Ljava/lang/String;)V", "GetSetModel_Ljava_lang_String_Handler")]
		public virtual unsafe void SetModel (string p0)
		{
			const string __id = "setModel.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
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
