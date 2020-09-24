using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/BatteryInfo", DoNotGenerateAcw=true)]
	public partial class BatteryInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/field[@name='rawVoltage']"
		[Register ("rawVoltage")]
		public int RawVoltage {
			get {
				const string __id = "rawVoltage.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "rawVoltage.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/field[@name='serialVersionUID']"
		[Register ("serialVersionUID")]
		public const long SerialVersionUID = (long) 2856538838259227820;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo.ChargeStatus']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/model/BatteryInfo$ChargeStatus", DoNotGenerateAcw=true)]
		public sealed partial class ChargeStatus : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo.ChargeStatus']/field[@name='INCHARGING_COMPLETE']"
			[Register ("INCHARGING_COMPLETE")]
			public static global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus InchargingComplete {
				get {
					const string __id = "INCHARGING_COMPLETE.Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo.ChargeStatus']/field[@name='INCHARGING_NOT_COMPLETE']"
			[Register ("INCHARGING_NOT_COMPLETE")]
			public static global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus InchargingNotComplete {
				get {
					const string __id = "INCHARGING_NOT_COMPLETE.Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo.ChargeStatus']/field[@name='NOT_INCHARGING']"
			[Register ("NOT_INCHARGING")]
			public static global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus NotIncharging {
				get {
					const string __id = "NOT_INCHARGING.Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo.ChargeStatus']/field[@name='UNKNOW']"
			[Register ("UNKNOW")]
			public static global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus Unknow {
				get {
					const string __id = "UNKNOW.Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/BatteryInfo$ChargeStatus", typeof (ChargeStatus));
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

			internal ChargeStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo.ChargeStatus']/constructor[@name='BatteryInfo.ChargeStatus' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;I)V", "")]
			public unsafe ChargeStatus (string p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo.ChargeStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;", "")]
			public static unsafe global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo.ChargeStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;", "")]
			public static unsafe global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus[] Values ()
			{
				const string __id = "values.()[Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/BatteryInfo", typeof (BatteryInfo));
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

		protected BatteryInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/constructor[@name='BatteryInfo' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(BB[B)V", "")]
		public unsafe BatteryInfo (sbyte p0, sbyte p1, byte[] p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(BB[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getLevel;
#pragma warning disable 0169
		static Delegate GetGetLevelHandler ()
		{
			if (cb_getLevel == null)
				cb_getLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLevel);
			return cb_getLevel;
		}

		static int n_GetLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Level;
		}
#pragma warning restore 0169

		static Delegate cb_setLevel_I;
#pragma warning disable 0169
		static Delegate GetSetLevel_IHandler ()
		{
			if (cb_setLevel_I == null)
				cb_setLevel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLevel_I);
			return cb_setLevel_I;
		}

		static void n_SetLevel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Level = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()I", "GetGetLevelHandler")]
			get {
				const string __id = "getLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='setLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLevel", "(I)V", "GetSetLevel_IHandler")]
			set {
				const string __id = "setLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNotifyStr;
#pragma warning disable 0169
		static Delegate GetGetNotifyStrHandler ()
		{
			if (cb_getNotifyStr == null)
				cb_getNotifyStr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNotifyStr);
			return cb_getNotifyStr;
		}

		static IntPtr n_GetNotifyStr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NotifyStr);
		}
#pragma warning restore 0169

		static Delegate cb_setNotifyStr_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotifyStr_Ljava_lang_String_Handler ()
		{
			if (cb_setNotifyStr_Ljava_lang_String_ == null)
				cb_setNotifyStr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNotifyStr_Ljava_lang_String_);
			return cb_setNotifyStr_Ljava_lang_String_;
		}

		static void n_SetNotifyStr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyStr = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string NotifyStr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='getNotifyStr' and count(parameter)=0]"
			[Register ("getNotifyStr", "()Ljava/lang/String;", "GetGetNotifyStrHandler")]
			get {
				const string __id = "getNotifyStr.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='setNotifyStr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotifyStr", "(Ljava/lang/String;)V", "GetSetNotifyStr_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNotifyStr.(Ljava/lang/String;)V";
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

		static Delegate cb_getPercent;
#pragma warning disable 0169
		static Delegate GetGetPercentHandler ()
		{
			if (cb_getPercent == null)
				cb_getPercent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPercent);
			return cb_getPercent;
		}

		static int n_GetPercent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Percent;
		}
#pragma warning restore 0169

		static Delegate cb_setPercent_I;
#pragma warning disable 0169
		static Delegate GetSetPercent_IHandler ()
		{
			if (cb_setPercent_I == null)
				cb_setPercent_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetPercent_I);
			return cb_setPercent_I;
		}

		static void n_SetPercent_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Percent = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Percent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='getPercent' and count(parameter)=0]"
			[Register ("getPercent", "()I", "GetGetPercentHandler")]
			get {
				const string __id = "getPercent.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='setPercent' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPercent", "(I)V", "GetSetPercent_IHandler")]
			set {
				const string __id = "setPercent.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_Handler ()
		{
			if (cb_setStatus_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_ == null)
				cb_setStatus_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetStatus_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_);
			return cb_setStatus_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_;
		}

		static void n_SetStatus_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;", "GetGetStatusHandler")]
			get {
				const string __id = "getStatus.()Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.BatteryInfo.ChargeStatus']]"
			[Register ("setStatus", "(Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;)V", "GetSetStatus_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_Handler")]
			set {
				const string __id = "setStatus.(Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Temperature);
		}
#pragma warning restore 0169

		static Delegate cb_setTemperature_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTemperature_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTemperature_Ljava_lang_Integer_ == null)
				cb_setTemperature_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTemperature_Ljava_lang_Integer_);
			return cb_setTemperature_Ljava_lang_Integer_;
		}

		static void n_SetTemperature_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Temperature = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer Temperature {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='getTemperature' and count(parameter)=0]"
			[Register ("getTemperature", "()Ljava/lang/Integer;", "GetGetTemperatureHandler")]
			get {
				const string __id = "getTemperature.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='setTemperature' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTemperature", "(Ljava/lang/Integer;)V", "GetSetTemperature_Ljava_lang_Integer_Handler")]
			set {
				const string __id = "setTemperature.(Ljava/lang/Integer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVoltage;
#pragma warning disable 0169
		static Delegate GetGetVoltageHandler ()
		{
			if (cb_getVoltage == null)
				cb_getVoltage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVoltage);
			return cb_getVoltage;
		}

		static int n_GetVoltage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Voltage;
		}
#pragma warning restore 0169

		static Delegate cb_setVoltage_I;
#pragma warning disable 0169
		static Delegate GetSetVoltage_IHandler ()
		{
			if (cb_setVoltage_I == null)
				cb_setVoltage_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVoltage_I);
			return cb_setVoltage_I;
		}

		static void n_SetVoltage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Voltage = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Voltage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='getVoltage' and count(parameter)=0]"
			[Register ("getVoltage", "()I", "GetGetVoltageHandler")]
			get {
				const string __id = "getVoltage.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='setVoltage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVoltage", "(I)V", "GetSetVoltage_IHandler")]
			set {
				const string __id = "setVoltage.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_canBleTransmission;
#pragma warning disable 0169
		static Delegate GetCanBleTransmissionHandler ()
		{
			if (cb_canBleTransmission == null)
				cb_canBleTransmission = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CanBleTransmission);
			return cb_canBleTransmission;
		}

		static bool n_CanBleTransmission (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanBleTransmission ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='canBleTransmission' and count(parameter)=0]"
		[Register ("canBleTransmission", "()Z", "GetCanBleTransmissionHandler")]
		public virtual unsafe bool CanBleTransmission ()
		{
			const string __id = "canBleTransmission.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canOTA;
#pragma warning disable 0169
		static Delegate GetCanOTAHandler ()
		{
			if (cb_canOTA == null)
				cb_canOTA = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CanOTA);
			return cb_canOTA;
		}

		static bool n_CanOTA (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanOTA ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='canOTA' and count(parameter)=0]"
		[Register ("canOTA", "()Z", "GetCanOTAHandler")]
		public virtual unsafe bool CanOTA ()
		{
			const string __id = "canOTA.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canSampling;
#pragma warning disable 0169
		static Delegate GetCanSamplingHandler ()
		{
			if (cb_canSampling == null)
				cb_canSampling = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CanSampling);
			return cb_canSampling;
		}

		static bool n_CanSampling (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanSampling ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='canSampling' and count(parameter)=0]"
		[Register ("canSampling", "()Z", "GetCanSamplingHandler")]
		public virtual unsafe bool CanSampling ()
		{
			const string __id = "canSampling.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getLevelDiscription_I;
#pragma warning disable 0169
		static Delegate GetGetLevelDiscription_IHandler ()
		{
			if (cb_getLevelDiscription_I == null)
				cb_getLevelDiscription_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetLevelDiscription_I);
			return cb_getLevelDiscription_I;
		}

		static IntPtr n_GetLevelDiscription_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetLevelDiscription (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='getLevelDiscription' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLevelDiscription", "(I)Ljava/lang/String;", "GetGetLevelDiscription_IHandler")]
		public virtual unsafe string GetLevelDiscription (int p0)
		{
			const string __id = "getLevelDiscription.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLevelString_I;
#pragma warning disable 0169
		static Delegate GetGetLevelString_IHandler ()
		{
			if (cb_getLevelString_I == null)
				cb_getLevelString_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetLevelString_I);
			return cb_getLevelString_I;
		}

		static IntPtr n_GetLevelString_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetLevelString (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='getLevelString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLevelString", "(I)Ljava/lang/String;", "GetGetLevelString_IHandler")]
		public virtual unsafe string GetLevelString (int p0)
		{
			const string __id = "getLevelString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getStatusString_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_;
#pragma warning disable 0169
		static Delegate GetGetStatusString_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_Handler ()
		{
			if (cb_getStatusString_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_ == null)
				cb_getStatusString_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetStatusString_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_);
			return cb_getStatusString_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_;
		}

		static IntPtr n_GetStatusString_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStatusString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='getStatusString' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.BatteryInfo.ChargeStatus']]"
		[Register ("getStatusString", "(Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;)Ljava/lang/String;", "GetGetStatusString_Lcom_vivalnk_sdk_model_BatteryInfo_ChargeStatus_Handler")]
		public virtual unsafe string GetStatusString (global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus p0)
		{
			const string __id = "getStatusString.(Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_needWarming;
#pragma warning disable 0169
		static Delegate GetNeedWarmingHandler ()
		{
			if (cb_needWarming == null)
				cb_needWarming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_NeedWarming);
			return cb_needWarming;
		}

		static bool n_NeedWarming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedWarming ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='needWarming' and count(parameter)=0]"
		[Register ("needWarming", "()Z", "GetNeedWarmingHandler")]
		public virtual unsafe bool NeedWarming ()
		{
			const string __id = "needWarming.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='parseLevel' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.model.BatteryInfo.ChargeStatus'] and parameter[2][@type='int']]"
		[Register ("parseLevel", "(Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;I)I", "")]
		public static unsafe int ParseLevel (global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus p0, int p1)
		{
			const string __id = "parseLevel.(Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='parseStatus' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("parseStatus", "(B)Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus ParseStatus (sbyte p0)
		{
			const string __id = "parseStatus.(B)Lcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='parseTemerature' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("parseTemerature", "(B)I", "")]
		public static unsafe int ParseTemerature (sbyte p0)
		{
			const string __id = "parseTemerature.(B)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='parseVoltage' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("parseVoltage", "(BB)I", "")]
		public static unsafe int ParseVoltage (sbyte p0, sbyte p1)
		{
			const string __id = "parseVoltage.(BB)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='parseVoltage' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseVoltage", "([B)I", "")]
		public static unsafe int ParseVoltage (byte[] p0)
		{
			const string __id = "parseVoltage.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='parseVoltage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("parseVoltage", "(I)I", "")]
		public static unsafe int ParseVoltage (int p0)
		{
			const string __id = "parseVoltage.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_toShortString;
#pragma warning disable 0169
		static Delegate GetToShortStringHandler ()
		{
			if (cb_toShortString == null)
				cb_toShortString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToShortString);
			return cb_toShortString;
		}

		static IntPtr n_ToShortString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToShortString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='BatteryInfo']/method[@name='toShortString' and count(parameter)=0]"
		[Register ("toShortString", "()Ljava/lang/String;", "GetToShortStringHandler")]
		public virtual unsafe string ToShortString ()
		{
			const string __id = "toShortString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
