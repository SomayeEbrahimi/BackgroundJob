using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/model/TemperatureInfo", DoNotGenerateAcw=true)]
	public partial class TemperatureInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/model/TemperatureInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TemperatureInfo); }
		}

		protected TemperatureInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_FI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/constructor[@name='TemperatureInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;FI)V", "")]
		public unsafe TemperatureInfo (string p0, float p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (TemperatureInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;FI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;FI)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_FI == IntPtr.Zero)
					id_ctor_Ljava_lang_String_FI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;FI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_FI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_FI, __args);
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

		static IntPtr id_getFinalTemperature;
		static IntPtr id_setFinalTemperature_F;
		public virtual unsafe float FinalTemperature {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getFinalTemperature' and count(parameter)=0]"
			[Register ("getFinalTemperature", "()F", "GetGetFinalTemperatureHandler")]
			get {
				if (id_getFinalTemperature == IntPtr.Zero)
					id_getFinalTemperature = JNIEnv.GetMethodID (class_ref, "getFinalTemperature", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFinalTemperature);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFinalTemperature", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setFinalTemperature' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFinalTemperature", "(F)V", "GetSetFinalTemperature_FHandler")]
			set {
				if (id_setFinalTemperature_F == IntPtr.Zero)
					id_setFinalTemperature_F = JNIEnv.GetMethodID (class_ref, "setFinalTemperature", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFinalTemperature_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFinalTemperature", "(F)V"), __args);
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

		static IntPtr id_getMacAddress;
		static IntPtr id_setMacAddress_Ljava_lang_String_;
		public virtual unsafe string MacAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getMacAddress' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setMacAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_getPatchBatteryLevel;
		static IntPtr id_setPatchBatteryLevel_I;
		public virtual unsafe int PatchBatteryLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getPatchBatteryLevel' and count(parameter)=0]"
			[Register ("getPatchBatteryLevel", "()I", "GetGetPatchBatteryLevelHandler")]
			get {
				if (id_getPatchBatteryLevel == IntPtr.Zero)
					id_getPatchBatteryLevel = JNIEnv.GetMethodID (class_ref, "getPatchBatteryLevel", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPatchBatteryLevel);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPatchBatteryLevel", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setPatchBatteryLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPatchBatteryLevel", "(I)V", "GetSetPatchBatteryLevel_IHandler")]
			set {
				if (id_setPatchBatteryLevel_I == IntPtr.Zero)
					id_setPatchBatteryLevel_I = JNIEnv.GetMethodID (class_ref, "setPatchBatteryLevel", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPatchBatteryLevel_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPatchBatteryLevel", "(I)V"), __args);
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

		static IntPtr id_getPatchFW;
		static IntPtr id_setPatchFW_Ljava_lang_String_;
		public virtual unsafe string PatchFW {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getPatchFW' and count(parameter)=0]"
			[Register ("getPatchFW", "()Ljava/lang/String;", "GetGetPatchFWHandler")]
			get {
				if (id_getPatchFW == IntPtr.Zero)
					id_getPatchFW = JNIEnv.GetMethodID (class_ref, "getPatchFW", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPatchFW), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPatchFW", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setPatchFW' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPatchFW", "(Ljava/lang/String;)V", "GetSetPatchFW_Ljava_lang_String_Handler")]
			set {
				if (id_setPatchFW_Ljava_lang_String_ == IntPtr.Zero)
					id_setPatchFW_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPatchFW", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPatchFW_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPatchFW", "(Ljava/lang/String;)V"), __args);
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

		static IntPtr id_getRSSI;
		static IntPtr id_setRSSI_I;
		public virtual unsafe int RSSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getRSSI' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setRSSI' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_getRawTemperature;
		static IntPtr id_setRawTemperature_F;
		public virtual unsafe float RawTemperature {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getRawTemperature' and count(parameter)=0]"
			[Register ("getRawTemperature", "()F", "GetGetRawTemperatureHandler")]
			get {
				if (id_getRawTemperature == IntPtr.Zero)
					id_getRawTemperature = JNIEnv.GetMethodID (class_ref, "getRawTemperature", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRawTemperature);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRawTemperature", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setRawTemperature' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRawTemperature", "(F)V", "GetSetRawTemperature_FHandler")]
			set {
				if (id_setRawTemperature_F == IntPtr.Zero)
					id_setRawTemperature_F = JNIEnv.GetMethodID (class_ref, "setRawTemperature", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRawTemperature_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRawTemperature", "(F)V"), __args);
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

		static IntPtr id_getSN;
		static IntPtr id_setSN_Ljava_lang_String_;
		public virtual unsafe string SN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getSN' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_getTemperatureStatus;
		static IntPtr id_setTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_;
		public virtual unsafe global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS TemperatureStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='getTemperatureStatus' and count(parameter)=0]"
			[Register ("getTemperatureStatus", "()Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;", "GetGetTemperatureStatusHandler")]
			get {
				if (id_getTemperatureStatus == IntPtr.Zero)
					id_getTemperatureStatus = JNIEnv.GetMethodID (class_ref, "getTemperatureStatus", "()Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTemperatureStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.TEMPERATURE_STATUS> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTemperatureStatus", "()Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.model']/class[@name='TemperatureInfo']/method[@name='setTemperatureStatus' and count(parameter)=1 and parameter[1][@type='com.vivalnk.vdireader.VDIType.TEMPERATURE_STATUS']]"
			[Register ("setTemperatureStatus", "(Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;)V", "GetSetTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_Handler")]
			set {
				if (id_setTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_ == IntPtr.Zero)
					id_setTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_ = JNIEnv.GetMethodID (class_ref, "setTemperatureStatus", "(Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTemperatureStatus_Lcom_vivalnk_vdireader_VDIType_TEMPERATURE_STATUS_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTemperatureStatus", "(Lcom/vivalnk/vdireader/VDIType$TEMPERATURE_STATUS;)V"), __args);
				} finally {
				}
			}
		}

	}
}
