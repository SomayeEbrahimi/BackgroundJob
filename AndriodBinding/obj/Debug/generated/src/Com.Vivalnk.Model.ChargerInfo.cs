using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/model/ChargerInfo", DoNotGenerateAcw=true)]
	public partial class ChargerInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/model/ChargerInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChargerInfo); }
		}

		protected ChargerInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/constructor[@name='ChargerInfo' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.vivalnk.vdireader.VDIType.CHARGER_BATTERY_STATUS'] and parameter[4][@type='float']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;F)V", "")]
		public unsafe ChargerInfo (string p0, string p1, global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS p2, float p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (ChargerInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;F)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_F == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_F = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_F, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_F, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getChargerBatteryStatus;
#pragma warning disable 0169
		static Delegate GetGetChargerBatteryStatusHandler ()
		{
			if (cb_getChargerBatteryStatus == null)
				cb_getChargerBatteryStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChargerBatteryStatus);
			return cb_getChargerBatteryStatus;
		}

		static IntPtr n_GetChargerBatteryStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChargerBatteryStatus);
		}
#pragma warning restore 0169

		static Delegate cb_setChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_;
#pragma warning disable 0169
		static Delegate GetSetChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_Handler ()
		{
			if (cb_setChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_ == null)
				cb_setChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_);
			return cb_setChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_;
		}

		static void n_SetChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChargerBatteryStatus = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChargerBatteryStatus;
		static IntPtr id_setChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_;
		public virtual unsafe global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS ChargerBatteryStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='getChargerBatteryStatus' and count(parameter)=0]"
			[Register ("getChargerBatteryStatus", "()Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;", "GetGetChargerBatteryStatusHandler")]
			get {
				if (id_getChargerBatteryStatus == IntPtr.Zero)
					id_getChargerBatteryStatus = JNIEnv.GetMethodID (class_ref, "getChargerBatteryStatus", "()Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChargerBatteryStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHARGER_BATTERY_STATUS> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChargerBatteryStatus", "()Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='setChargerBatteryStatus' and count(parameter)=1 and parameter[1][@type='com.vivalnk.vdireader.VDIType.CHARGER_BATTERY_STATUS']]"
			[Register ("setChargerBatteryStatus", "(Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;)V", "GetSetChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_Handler")]
			set {
				if (id_setChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_ == IntPtr.Zero)
					id_setChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_ = JNIEnv.GetMethodID (class_ref, "setChargerBatteryStatus", "(Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChargerBatteryStatus_Lcom_vivalnk_vdireader_VDIType_CHARGER_BATTERY_STATUS_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChargerBatteryStatus", "(Lcom/vivalnk/vdireader/VDIType$CHARGER_BATTERY_STATUS;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getChargerFW;
#pragma warning disable 0169
		static Delegate GetGetChargerFWHandler ()
		{
			if (cb_getChargerFW == null)
				cb_getChargerFW = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChargerFW);
			return cb_getChargerFW;
		}

		static IntPtr n_GetChargerFW (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChargerFW);
		}
#pragma warning restore 0169

		static Delegate cb_setChargerFW_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChargerFW_Ljava_lang_String_Handler ()
		{
			if (cb_setChargerFW_Ljava_lang_String_ == null)
				cb_setChargerFW_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetChargerFW_Ljava_lang_String_);
			return cb_setChargerFW_Ljava_lang_String_;
		}

		static void n_SetChargerFW_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChargerFW = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChargerFW;
		static IntPtr id_setChargerFW_Ljava_lang_String_;
		public virtual unsafe string ChargerFW {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='getChargerFW' and count(parameter)=0]"
			[Register ("getChargerFW", "()Ljava/lang/String;", "GetGetChargerFWHandler")]
			get {
				if (id_getChargerFW == IntPtr.Zero)
					id_getChargerFW = JNIEnv.GetMethodID (class_ref, "getChargerFW", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChargerFW), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChargerFW", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='setChargerFW' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChargerFW", "(Ljava/lang/String;)V", "GetSetChargerFW_Ljava_lang_String_Handler")]
			set {
				if (id_setChargerFW_Ljava_lang_String_ == IntPtr.Zero)
					id_setChargerFW_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChargerFW", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChargerFW_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChargerFW", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MacAddress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMacAddress;
		static IntPtr id_setMacAddress_Ljava_lang_String_;
		public virtual unsafe string MacAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='getMacAddress' and count(parameter)=0]"
			[Register ("getMacAddress", "()Ljava/lang/String;", "GetGetMacAddressHandler")]
			get {
				if (id_getMacAddress == IntPtr.Zero)
					id_getMacAddress = JNIEnv.GetMethodID (class_ref, "getMacAddress", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMacAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMacAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='setMacAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMacAddress", "(Ljava/lang/String;)V", "GetSetMacAddress_Ljava_lang_String_Handler")]
			set {
				if (id_setMacAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_setMacAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMacAddress", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMacAddress_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMacAddress", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetOffset);
			return cb_getOffset;
		}

		static float n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset;
		}
#pragma warning restore 0169

		static Delegate cb_setOffset_F;
#pragma warning disable 0169
		static Delegate GetSetOffset_FHandler ()
		{
			if (cb_setOffset_F == null)
				cb_setOffset_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetOffset_F);
			return cb_setOffset_F;
		}

		static void n_SetOffset_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOffset;
		static IntPtr id_setOffset_F;
		public virtual unsafe float Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()F", "GetGetOffsetHandler")]
			get {
				if (id_getOffset == IntPtr.Zero)
					id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getOffset);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setOffset", "(F)V", "GetSetOffset_FHandler")]
			set {
				if (id_setOffset_F == IntPtr.Zero)
					id_setOffset_F = JNIEnv.GetMethodID (class_ref, "setOffset", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOffset_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOffset", "(F)V"), __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RSSI = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRSSI;
		static IntPtr id_setRSSI_I;
		public virtual unsafe int RSSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='getRSSI' and count(parameter)=0]"
			[Register ("getRSSI", "()I", "GetGetRSSIHandler")]
			get {
				if (id_getRSSI == IntPtr.Zero)
					id_getRSSI = JNIEnv.GetMethodID (class_ref, "getRSSI", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRSSI);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRSSI", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='setRSSI' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRSSI", "(I)V", "GetSetRSSI_IHandler")]
			set {
				if (id_setRSSI_I == IntPtr.Zero)
					id_setRSSI_I = JNIEnv.GetMethodID (class_ref, "setRSSI", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRSSI_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRSSI", "(I)V"), __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SN = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSN;
		static IntPtr id_setSN_Ljava_lang_String_;
		public virtual unsafe string SN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='getSN' and count(parameter)=0]"
			[Register ("getSN", "()Ljava/lang/String;", "GetGetSNHandler")]
			get {
				if (id_getSN == IntPtr.Zero)
					id_getSN = JNIEnv.GetMethodID (class_ref, "getSN", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSN), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSN", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='ChargerInfo']/method[@name='setSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSN", "(Ljava/lang/String;)V", "GetSetSN_Ljava_lang_String_Handler")]
			set {
				if (id_setSN_Ljava_lang_String_ == IntPtr.Zero)
					id_setSN_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSN", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSN_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSN", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
