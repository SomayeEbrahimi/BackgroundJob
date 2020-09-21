using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Vdireader {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleListener']"
	[Register ("com/vivalnk/vdireader/VDICommonBleListener", "", "Com.Vivalnk.Vdireader.IVDICommonBleListenerInvoker")]
	public partial interface IVDICommonBleListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleListener']/method[@name='onChargerInfoUpdate' and count(parameter)=1 and parameter[1][@type='com.vivalnk.model.ChargerInfo']]"
		[Register ("onChargerInfoUpdate", "(Lcom/vivalnk/model/ChargerInfo;)V", "GetOnChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_Handler:Com.Vivalnk.Vdireader.IVDICommonBleListenerInvoker, AndriodBinding")]
		void OnChargerInfoUpdate (global::Com.Vivalnk.Model.ChargerInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleListener']/method[@name='onDeviceLost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onDeviceLost", "(Ljava/lang/String;)V", "GetOnDeviceLost_Ljava_lang_String_Handler:Com.Vivalnk.Vdireader.IVDICommonBleListenerInvoker, AndriodBinding")]
		void OnDeviceLost (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleListener']/method[@name='onNewDeviceDiscovered' and count(parameter)=1 and parameter[1][@type='com.vivalnk.model.DeviceInfo']]"
		[Register ("onNewDeviceDiscovered", "(Lcom/vivalnk/model/DeviceInfo;)V", "GetOnNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_Handler:Com.Vivalnk.Vdireader.IVDICommonBleListenerInvoker, AndriodBinding")]
		void OnNewDeviceDiscovered (global::Com.Vivalnk.Model.DeviceInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleListener']/method[@name='onTemperatureAbnormalStatusUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS']]"
		[Register ("onTemperatureAbnormalStatusUpdate", "(Ljava/lang/String;Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;)V", "GetOnTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_Handler:Com.Vivalnk.Vdireader.IVDICommonBleListenerInvoker, AndriodBinding")]
		void OnTemperatureAbnormalStatusUpdate (string p0, global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleListener']/method[@name='onTemperatureMissed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onTemperatureMissed", "(Ljava/lang/String;)V", "GetOnTemperatureMissed_Ljava_lang_String_Handler:Com.Vivalnk.Vdireader.IVDICommonBleListenerInvoker, AndriodBinding")]
		void OnTemperatureMissed (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleListener']/method[@name='onTemperatureUpdated' and count(parameter)=1 and parameter[1][@type='com.vivalnk.model.TemperatureInfo']]"
		[Register ("onTemperatureUpdated", "(Lcom/vivalnk/model/TemperatureInfo;)V", "GetOnTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_Handler:Com.Vivalnk.Vdireader.IVDICommonBleListenerInvoker, AndriodBinding")]
		void OnTemperatureUpdated (global::Com.Vivalnk.Model.TemperatureInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleListener']/method[@name='phoneBluetoothOff' and count(parameter)=0]"
		[Register ("phoneBluetoothOff", "()V", "GetPhoneBluetoothOffHandler:Com.Vivalnk.Vdireader.IVDICommonBleListenerInvoker, AndriodBinding")]
		void PhoneBluetoothOff ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleListener']/method[@name='phoneLocationOff' and count(parameter)=0]"
		[Register ("phoneLocationOff", "()V", "GetPhoneLocationOffHandler:Com.Vivalnk.Vdireader.IVDICommonBleListenerInvoker, AndriodBinding")]
		void PhoneLocationOff ();

	}

	[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDICommonBleListener", DoNotGenerateAcw=true)]
	internal partial class IVDICommonBleListenerInvoker : global::Java.Lang.Object, IVDICommonBleListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/vdireader/VDICommonBleListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVDICommonBleListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVDICommonBleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVDICommonBleListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.vdireader.VDICommonBleListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVDICommonBleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_;
#pragma warning disable 0169
		static Delegate GetOnChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_Handler ()
		{
			if (cb_onChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_ == null)
				cb_onChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_);
			return cb_onChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_;
		}

		static void n_OnChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.ChargerInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnChargerInfoUpdate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_;
		public unsafe void OnChargerInfoUpdate (global::Com.Vivalnk.Model.ChargerInfo p0)
		{
			if (id_onChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_ == IntPtr.Zero)
				id_onChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_ = JNIEnv.GetMethodID (class_ref, "onChargerInfoUpdate", "(Lcom/vivalnk/model/ChargerInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChargerInfoUpdate_Lcom_vivalnk_model_ChargerInfo_, __args);
		}

		static Delegate cb_onDeviceLost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDeviceLost_Ljava_lang_String_Handler ()
		{
			if (cb_onDeviceLost_Ljava_lang_String_ == null)
				cb_onDeviceLost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDeviceLost_Ljava_lang_String_);
			return cb_onDeviceLost_Ljava_lang_String_;
		}

		static void n_OnDeviceLost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDeviceLost (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDeviceLost_Ljava_lang_String_;
		public unsafe void OnDeviceLost (string p0)
		{
			if (id_onDeviceLost_Ljava_lang_String_ == IntPtr.Zero)
				id_onDeviceLost_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDeviceLost", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDeviceLost_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_;
#pragma warning disable 0169
		static Delegate GetOnNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_Handler ()
		{
			if (cb_onNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_ == null)
				cb_onNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_);
			return cb_onNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_;
		}

		static void n_OnNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.DeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNewDeviceDiscovered (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_;
		public unsafe void OnNewDeviceDiscovered (global::Com.Vivalnk.Model.DeviceInfo p0)
		{
			if (id_onNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_ == IntPtr.Zero)
				id_onNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_ = JNIEnv.GetMethodID (class_ref, "onNewDeviceDiscovered", "(Lcom/vivalnk/model/DeviceInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewDeviceDiscovered_Lcom_vivalnk_model_DeviceInfo_, __args);
		}

		static Delegate cb_onTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_;
#pragma warning disable 0169
		static Delegate GetOnTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_Handler ()
		{
			if (cb_onTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_ == null)
				cb_onTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_);
			return cb_onTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_;
		}

		static void n_OnTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTemperatureAbnormalStatusUpdate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_;
		public unsafe void OnTemperatureAbnormalStatusUpdate (string p0, global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS p1)
		{
			if (id_onTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_ == IntPtr.Zero)
				id_onTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_ = JNIEnv.GetMethodID (class_ref, "onTemperatureAbnormalStatusUpdate", "(Ljava/lang/String;Lcom/vivalnk/vdireader/VDIType$ABNORMAL_TEMPERATURE_STATUS;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTemperatureAbnormalStatusUpdate_Ljava_lang_String_Lcom_vivalnk_vdireader_VDIType_ABNORMAL_TEMPERATURE_STATUS_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onTemperatureMissed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnTemperatureMissed_Ljava_lang_String_Handler ()
		{
			if (cb_onTemperatureMissed_Ljava_lang_String_ == null)
				cb_onTemperatureMissed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTemperatureMissed_Ljava_lang_String_);
			return cb_onTemperatureMissed_Ljava_lang_String_;
		}

		static void n_OnTemperatureMissed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTemperatureMissed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTemperatureMissed_Ljava_lang_String_;
		public unsafe void OnTemperatureMissed (string p0)
		{
			if (id_onTemperatureMissed_Ljava_lang_String_ == IntPtr.Zero)
				id_onTemperatureMissed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onTemperatureMissed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTemperatureMissed_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_;
#pragma warning disable 0169
		static Delegate GetOnTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_Handler ()
		{
			if (cb_onTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_ == null)
				cb_onTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_);
			return cb_onTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_;
		}

		static void n_OnTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Model.TemperatureInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTemperatureUpdated (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_;
		public unsafe void OnTemperatureUpdated (global::Com.Vivalnk.Model.TemperatureInfo p0)
		{
			if (id_onTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_ == IntPtr.Zero)
				id_onTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_ = JNIEnv.GetMethodID (class_ref, "onTemperatureUpdated", "(Lcom/vivalnk/model/TemperatureInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTemperatureUpdated_Lcom_vivalnk_model_TemperatureInfo_, __args);
		}

		static Delegate cb_phoneBluetoothOff;
#pragma warning disable 0169
		static Delegate GetPhoneBluetoothOffHandler ()
		{
			if (cb_phoneBluetoothOff == null)
				cb_phoneBluetoothOff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PhoneBluetoothOff);
			return cb_phoneBluetoothOff;
		}

		static void n_PhoneBluetoothOff (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PhoneBluetoothOff ();
		}
#pragma warning restore 0169

		IntPtr id_phoneBluetoothOff;
		public unsafe void PhoneBluetoothOff ()
		{
			if (id_phoneBluetoothOff == IntPtr.Zero)
				id_phoneBluetoothOff = JNIEnv.GetMethodID (class_ref, "phoneBluetoothOff", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_phoneBluetoothOff);
		}

		static Delegate cb_phoneLocationOff;
#pragma warning disable 0169
		static Delegate GetPhoneLocationOffHandler ()
		{
			if (cb_phoneLocationOff == null)
				cb_phoneLocationOff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PhoneLocationOff);
			return cb_phoneLocationOff;
		}

		static void n_PhoneLocationOff (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PhoneLocationOff ();
		}
#pragma warning restore 0169

		IntPtr id_phoneLocationOff;
		public unsafe void PhoneLocationOff ()
		{
			if (id_phoneLocationOff == IntPtr.Zero)
				id_phoneLocationOff = JNIEnv.GetMethodID (class_ref, "phoneLocationOff", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_phoneLocationOff);
		}

	}

	// event args for com.vivalnk.vdireader.VDICommonBleListener.onChargerInfoUpdate
	public partial class ChargerInfoUpdateEventArgs : global::System.EventArgs {

		public ChargerInfoUpdateEventArgs (global::Com.Vivalnk.Model.ChargerInfo p0)
		{
			this.p0 = p0;
		}

		global::Com.Vivalnk.Model.ChargerInfo p0;
		public global::Com.Vivalnk.Model.ChargerInfo P0 {
			get { return p0; }
		}
	}

	// event args for com.vivalnk.vdireader.VDICommonBleListener.onDeviceLost
	public partial class DeviceLostEventArgs : global::System.EventArgs {

		public DeviceLostEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	// event args for com.vivalnk.vdireader.VDICommonBleListener.onNewDeviceDiscovered
	public partial class NewDeviceDiscoveredEventArgs : global::System.EventArgs {

		public NewDeviceDiscoveredEventArgs (global::Com.Vivalnk.Model.DeviceInfo p0)
		{
			this.p0 = p0;
		}

		global::Com.Vivalnk.Model.DeviceInfo p0;
		public global::Com.Vivalnk.Model.DeviceInfo P0 {
			get { return p0; }
		}
	}

	// event args for com.vivalnk.vdireader.VDICommonBleListener.onTemperatureAbnormalStatusUpdate
	public partial class TemperatureAbnormalStatusUpdateEventArgs : global::System.EventArgs {

		public TemperatureAbnormalStatusUpdateEventArgs (string p0, global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS p1;
		public global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS P1 {
			get { return p1; }
		}
	}

	// event args for com.vivalnk.vdireader.VDICommonBleListener.onTemperatureMissed
	public partial class TemperatureMissedEventArgs : global::System.EventArgs {

		public TemperatureMissedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	// event args for com.vivalnk.vdireader.VDICommonBleListener.onTemperatureUpdated
	public partial class TemperatureUpdatedEventArgs : global::System.EventArgs {

		public TemperatureUpdatedEventArgs (global::Com.Vivalnk.Model.TemperatureInfo p0)
		{
			this.p0 = p0;
		}

		global::Com.Vivalnk.Model.TemperatureInfo p0;
		public global::Com.Vivalnk.Model.TemperatureInfo P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/vivalnk/vdireader/VDICommonBleListenerImplementor")]
	internal sealed partial class IVDICommonBleListenerImplementor : global::Java.Lang.Object, IVDICommonBleListener {

		object sender;

		public IVDICommonBleListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vivalnk/vdireader/VDICommonBleListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ChargerInfoUpdateEventArgs> OnChargerInfoUpdateHandler;
#pragma warning restore 0649

		public void OnChargerInfoUpdate (global::Com.Vivalnk.Model.ChargerInfo p0)
		{
			var __h = OnChargerInfoUpdateHandler;
			if (__h != null)
				__h (sender, new ChargerInfoUpdateEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<DeviceLostEventArgs> OnDeviceLostHandler;
#pragma warning restore 0649

		public void OnDeviceLost (string p0)
		{
			var __h = OnDeviceLostHandler;
			if (__h != null)
				__h (sender, new DeviceLostEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<NewDeviceDiscoveredEventArgs> OnNewDeviceDiscoveredHandler;
#pragma warning restore 0649

		public void OnNewDeviceDiscovered (global::Com.Vivalnk.Model.DeviceInfo p0)
		{
			var __h = OnNewDeviceDiscoveredHandler;
			if (__h != null)
				__h (sender, new NewDeviceDiscoveredEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<TemperatureAbnormalStatusUpdateEventArgs> OnTemperatureAbnormalStatusUpdateHandler;
#pragma warning restore 0649

		public void OnTemperatureAbnormalStatusUpdate (string p0, global::Com.Vivalnk.Vdireader.VDIType.ABNORMAL_TEMPERATURE_STATUS p1)
		{
			var __h = OnTemperatureAbnormalStatusUpdateHandler;
			if (__h != null)
				__h (sender, new TemperatureAbnormalStatusUpdateEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<TemperatureMissedEventArgs> OnTemperatureMissedHandler;
#pragma warning restore 0649

		public void OnTemperatureMissed (string p0)
		{
			var __h = OnTemperatureMissedHandler;
			if (__h != null)
				__h (sender, new TemperatureMissedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<TemperatureUpdatedEventArgs> OnTemperatureUpdatedHandler;
#pragma warning restore 0649

		public void OnTemperatureUpdated (global::Com.Vivalnk.Model.TemperatureInfo p0)
		{
			var __h = OnTemperatureUpdatedHandler;
			if (__h != null)
				__h (sender, new TemperatureUpdatedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler PhoneBluetoothOffHandler;
#pragma warning restore 0649

		public void PhoneBluetoothOff ()
		{
			var __h = PhoneBluetoothOffHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler PhoneLocationOffHandler;
#pragma warning restore 0649

		public void PhoneLocationOff ()
		{
			var __h = PhoneLocationOffHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IVDICommonBleListenerImplementor value)
		{
			return value.OnChargerInfoUpdateHandler == null && value.OnDeviceLostHandler == null && value.OnNewDeviceDiscoveredHandler == null && value.OnTemperatureAbnormalStatusUpdateHandler == null && value.OnTemperatureMissedHandler == null && value.OnTemperatureUpdatedHandler == null && value.PhoneBluetoothOffHandler == null && value.PhoneLocationOffHandler == null;
		}
	}

}
