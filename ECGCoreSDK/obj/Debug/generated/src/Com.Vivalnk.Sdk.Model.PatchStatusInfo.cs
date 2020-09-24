using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/PatchStatusInfo", DoNotGenerateAcw=true)]
	public partial class PatchStatusInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/field[@name='leadOn']"
		[Register ("leadOn")]
		public bool LeadOn {
			get {
				const string __id = "leadOn.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "leadOn.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/field[@name='sampling']"
		[Register ("sampling")]
		public bool Sampling {
			get {
				const string __id = "sampling.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "sampling.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/field[@name='serialVersionUID']"
		[Register ("serialVersionUID")]
		public const long SerialVersionUID = (long) 4509278838897589820;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo.SampleFrequency']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency", DoNotGenerateAcw=true)]
		public sealed partial class SampleFrequency : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo.SampleFrequency']/field[@name='_128']"
			[Register ("_128")]
			public static global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency _128 {
				get {
					const string __id = "_128.Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo.SampleFrequency']/field[@name='_250']"
			[Register ("_250")]
			public static global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency _250 {
				get {
					const string __id = "_250.Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo.SampleFrequency']/field[@name='value']"
			[Register ("value")]
			public int Value {
				get {
					const string __id = "value.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "value.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency", typeof (SampleFrequency));
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

			internal SampleFrequency (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo.SampleFrequency']/constructor[@name='PatchStatusInfo.SampleFrequency' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(III)V", "")]
			public unsafe SampleFrequency (int p0, int p1, int p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(III)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo.SampleFrequency']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("valueOf", "(I)Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;", "")]
			public static unsafe global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency ValueOf (int p0)
			{
				const string __id = "valueOf.(I)Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo.SampleFrequency']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;", "")]
			public static unsafe global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo.SampleFrequency']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;", "")]
			public static unsafe global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency[] Values ()
			{
				const string __id = "values.()[Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/PatchStatusInfo", typeof (PatchStatusInfo));
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

		protected PatchStatusInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/constructor[@name='PatchStatusInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PatchStatusInfo ()
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

		static Delegate cb_getBaseLineAlgoOpen;
#pragma warning disable 0169
		static Delegate GetGetBaseLineAlgoOpenHandler ()
		{
			if (cb_getBaseLineAlgoOpen == null)
				cb_getBaseLineAlgoOpen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBaseLineAlgoOpen);
			return cb_getBaseLineAlgoOpen;
		}

		static IntPtr n_GetBaseLineAlgoOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseLineAlgoOpen);
		}
#pragma warning restore 0169

		static Delegate cb_setBaseLineAlgoOpen_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetBaseLineAlgoOpen_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setBaseLineAlgoOpen_Ljava_lang_Boolean_ == null)
				cb_setBaseLineAlgoOpen_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBaseLineAlgoOpen_Ljava_lang_Boolean_);
			return cb_setBaseLineAlgoOpen_Ljava_lang_Boolean_;
		}

		static void n_SetBaseLineAlgoOpen_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BaseLineAlgoOpen = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean BaseLineAlgoOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='getBaseLineAlgoOpen' and count(parameter)=0]"
			[Register ("getBaseLineAlgoOpen", "()Ljava/lang/Boolean;", "GetGetBaseLineAlgoOpenHandler")]
			get {
				const string __id = "getBaseLineAlgoOpen.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='setBaseLineAlgoOpen' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setBaseLineAlgoOpen", "(Ljava/lang/Boolean;)V", "GetSetBaseLineAlgoOpen_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setBaseLineAlgoOpen.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBatteryInfo;
#pragma warning disable 0169
		static Delegate GetGetBatteryInfoHandler ()
		{
			if (cb_getBatteryInfo == null)
				cb_getBatteryInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBatteryInfo);
			return cb_getBatteryInfo;
		}

		static IntPtr n_GetBatteryInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BatteryInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setBatteryInfo_Lcom_vivalnk_sdk_model_BatteryInfo_;
#pragma warning disable 0169
		static Delegate GetSetBatteryInfo_Lcom_vivalnk_sdk_model_BatteryInfo_Handler ()
		{
			if (cb_setBatteryInfo_Lcom_vivalnk_sdk_model_BatteryInfo_ == null)
				cb_setBatteryInfo_Lcom_vivalnk_sdk_model_BatteryInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBatteryInfo_Lcom_vivalnk_sdk_model_BatteryInfo_);
			return cb_setBatteryInfo_Lcom_vivalnk_sdk_model_BatteryInfo_;
		}

		static void n_SetBatteryInfo_Lcom_vivalnk_sdk_model_BatteryInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BatteryInfo = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Model.BatteryInfo BatteryInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='getBatteryInfo' and count(parameter)=0]"
			[Register ("getBatteryInfo", "()Lcom/vivalnk/sdk/model/BatteryInfo;", "GetGetBatteryInfoHandler")]
			get {
				const string __id = "getBatteryInfo.()Lcom/vivalnk/sdk/model/BatteryInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='setBatteryInfo' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.BatteryInfo']]"
			[Register ("setBatteryInfo", "(Lcom/vivalnk/sdk/model/BatteryInfo;)V", "GetSetBatteryInfo_Lcom_vivalnk_sdk_model_BatteryInfo_Handler")]
			set {
				const string __id = "setBatteryInfo.(Lcom/vivalnk/sdk/model/BatteryInfo;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMode;
#pragma warning disable 0169
		static Delegate GetGetModeHandler ()
		{
			if (cb_getMode == null)
				cb_getMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMode);
			return cb_getMode;
		}

		static IntPtr n_GetMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Mode);
		}
#pragma warning restore 0169

		static Delegate cb_setMode_Lcom_vivalnk_sdk_model_WorkMode_;
#pragma warning disable 0169
		static Delegate GetSetMode_Lcom_vivalnk_sdk_model_WorkMode_Handler ()
		{
			if (cb_setMode_Lcom_vivalnk_sdk_model_WorkMode_ == null)
				cb_setMode_Lcom_vivalnk_sdk_model_WorkMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMode_Lcom_vivalnk_sdk_model_WorkMode_);
			return cb_setMode_Lcom_vivalnk_sdk_model_WorkMode_;
		}

		static void n_SetMode_Lcom_vivalnk_sdk_model_WorkMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.WorkMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Mode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Model.WorkMode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Lcom/vivalnk/sdk/model/WorkMode;", "GetGetModeHandler")]
			get {
				const string __id = "getMode.()Lcom/vivalnk/sdk/model/WorkMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.WorkMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.WorkMode']]"
			[Register ("setMode", "(Lcom/vivalnk/sdk/model/WorkMode;)V", "GetSetMode_Lcom_vivalnk_sdk_model_WorkMode_Handler")]
			set {
				const string __id = "setMode.(Lcom/vivalnk/sdk/model/WorkMode;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRTSDataOpen;
#pragma warning disable 0169
		static Delegate GetGetRTSDataOpenHandler ()
		{
			if (cb_getRTSDataOpen == null)
				cb_getRTSDataOpen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRTSDataOpen);
			return cb_getRTSDataOpen;
		}

		static IntPtr n_GetRTSDataOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RTSDataOpen);
		}
#pragma warning restore 0169

		static Delegate cb_setRTSDataOpen_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetRTSDataOpen_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setRTSDataOpen_Ljava_lang_Boolean_ == null)
				cb_setRTSDataOpen_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRTSDataOpen_Ljava_lang_Boolean_);
			return cb_setRTSDataOpen_Ljava_lang_Boolean_;
		}

		static void n_SetRTSDataOpen_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RTSDataOpen = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean RTSDataOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='getRTSDataOpen' and count(parameter)=0]"
			[Register ("getRTSDataOpen", "()Ljava/lang/Boolean;", "GetGetRTSDataOpenHandler")]
			get {
				const string __id = "getRTSDataOpen.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='setRTSDataOpen' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setRTSDataOpen", "(Ljava/lang/Boolean;)V", "GetSetRTSDataOpen_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setRTSDataOpen.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRTSFlashSave;
#pragma warning disable 0169
		static Delegate GetGetRTSFlashSaveHandler ()
		{
			if (cb_getRTSFlashSave == null)
				cb_getRTSFlashSave = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRTSFlashSave);
			return cb_getRTSFlashSave;
		}

		static IntPtr n_GetRTSFlashSave (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RTSFlashSave);
		}
#pragma warning restore 0169

		static Delegate cb_setRTSFlashSave_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetRTSFlashSave_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setRTSFlashSave_Ljava_lang_Boolean_ == null)
				cb_setRTSFlashSave_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRTSFlashSave_Ljava_lang_Boolean_);
			return cb_setRTSFlashSave_Ljava_lang_Boolean_;
		}

		static void n_SetRTSFlashSave_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RTSFlashSave = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean RTSFlashSave {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='getRTSFlashSave' and count(parameter)=0]"
			[Register ("getRTSFlashSave", "()Ljava/lang/Boolean;", "GetGetRTSFlashSaveHandler")]
			get {
				const string __id = "getRTSFlashSave.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='setRTSFlashSave' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setRTSFlashSave", "(Ljava/lang/Boolean;)V", "GetSetRTSFlashSave_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setRTSFlashSave.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUploading;
#pragma warning disable 0169
		static Delegate GetGetUploadingHandler ()
		{
			if (cb_getUploading == null)
				cb_getUploading = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUploading);
			return cb_getUploading;
		}

		static IntPtr n_GetUploading (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Uploading);
		}
#pragma warning restore 0169

		static Delegate cb_setUploading_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetUploading_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setUploading_Ljava_lang_Boolean_ == null)
				cb_setUploading_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUploading_Ljava_lang_Boolean_);
			return cb_setUploading_Ljava_lang_Boolean_;
		}

		static void n_SetUploading_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Uploading = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean Uploading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='getUploading' and count(parameter)=0]"
			[Register ("getUploading", "()Ljava/lang/Boolean;", "GetGetUploadingHandler")]
			get {
				const string __id = "getUploading.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='setUploading' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setUploading", "(Ljava/lang/Boolean;)V", "GetSetUploading_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setUploading.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSampleFrequency;
#pragma warning disable 0169
		static Delegate GetGetSampleFrequencyHandler ()
		{
			if (cb_getSampleFrequency == null)
				cb_getSampleFrequency = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSampleFrequency);
			return cb_getSampleFrequency;
		}

		static IntPtr n_GetSampleFrequency (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSampleFrequency ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='getSampleFrequency' and count(parameter)=0]"
		[Register ("getSampleFrequency", "()Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;", "GetGetSampleFrequencyHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency GetSampleFrequency ()
		{
			const string __id = "getSampleFrequency.()Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsLeadOn ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='isLeadOn' and count(parameter)=0]"
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

		static Delegate cb_isSampling;
#pragma warning disable 0169
		static Delegate GetIsSamplingHandler ()
		{
			if (cb_isSampling == null)
				cb_isSampling = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsSampling);
			return cb_isSampling;
		}

		static IntPtr n_IsSampling (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsSampling ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='isSampling' and count(parameter)=0]"
		[Register ("isSampling", "()Ljava/lang/Boolean;", "GetIsSamplingHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsSampling ()
		{
			const string __id = "isSampling.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLeadOn (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='setLeadOn' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
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

		static Delegate cb_setSampleFrequency_Lcom_vivalnk_sdk_model_PatchStatusInfo_SampleFrequency_;
#pragma warning disable 0169
		static Delegate GetSetSampleFrequency_Lcom_vivalnk_sdk_model_PatchStatusInfo_SampleFrequency_Handler ()
		{
			if (cb_setSampleFrequency_Lcom_vivalnk_sdk_model_PatchStatusInfo_SampleFrequency_ == null)
				cb_setSampleFrequency_Lcom_vivalnk_sdk_model_PatchStatusInfo_SampleFrequency_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSampleFrequency_Lcom_vivalnk_sdk_model_PatchStatusInfo_SampleFrequency_);
			return cb_setSampleFrequency_Lcom_vivalnk_sdk_model_PatchStatusInfo_SampleFrequency_;
		}

		static void n_SetSampleFrequency_Lcom_vivalnk_sdk_model_PatchStatusInfo_SampleFrequency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSampleFrequency (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='setSampleFrequency' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.PatchStatusInfo.SampleFrequency']]"
		[Register ("setSampleFrequency", "(Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;)V", "GetSetSampleFrequency_Lcom_vivalnk_sdk_model_PatchStatusInfo_SampleFrequency_Handler")]
		public virtual unsafe void SetSampleFrequency (global::Com.Vivalnk.Sdk.Model.PatchStatusInfo.SampleFrequency p0)
		{
			const string __id = "setSampleFrequency.(Lcom/vivalnk/sdk/model/PatchStatusInfo$SampleFrequency;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSampling_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetSampling_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setSampling_Ljava_lang_Boolean_ == null)
				cb_setSampling_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSampling_Ljava_lang_Boolean_);
			return cb_setSampling_Ljava_lang_Boolean_;
		}

		static void n_SetSampling_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.PatchStatusInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSampling (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='PatchStatusInfo']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setSampling", "(Ljava/lang/Boolean;)V", "GetSetSampling_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetSampling (global::Java.Lang.Boolean p0)
		{
			const string __id = "setSampling.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
