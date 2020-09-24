using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/BleConnectMaster", DoNotGenerateAcw=true)]
	public partial class BleConnectMaster : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseGattIOOperation, global::Android.OS.Handler.ICallback, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IConnectOperation {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/field[@name='MSG_CONNECT_DISCOVER_SERVICE']"
		[Register ("MSG_CONNECT_DISCOVER_SERVICE")]
		protected const int MsgConnectDiscoverService = (int) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/field[@name='MSG_CONNECT_ON_CONNECTED']"
		[Register ("MSG_CONNECT_ON_CONNECTED")]
		protected const int MsgConnectOnConnected = (int) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/field[@name='MSG_CONNECT_ON_DISCONNECTED']"
		[Register ("MSG_CONNECT_ON_DISCONNECTED")]
		protected const int MsgConnectOnDisconnected = (int) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/field[@name='MSG_CONNECT_TIMEOUT']"
		[Register ("MSG_CONNECT_TIMEOUT")]
		protected const int MsgConnectTimeout = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "BleConnectMaster";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/interface[@name='BleConnectMaster.BluetoothConnectListener']"
		[Register ("com/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener", "", "Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster/IBluetoothConnectListenerInvoker")]
		public partial interface IBluetoothConnectListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/interface[@name='BleConnectMaster.BluetoothConnectListener']/method[@name='onDisconnected' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register ("onDisconnected", "(Ljava/lang/String;Z)V", "GetOnDisconnected_Ljava_lang_String_ZHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster/IBluetoothConnectListenerInvoker, ECGCommonSDK")]
			void OnDisconnected (string p0, bool p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/interface[@name='BleConnectMaster.BluetoothConnectListener']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;ILjava/lang/String;)V", "GetOnError_Ljava_lang_String_ILjava_lang_String_Handler:Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster/IBluetoothConnectListenerInvoker, ECGCommonSDK")]
			void OnError (string p0, int p1, string p2);

		}

		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener", DoNotGenerateAcw=true)]
		internal partial class IBluetoothConnectListenerInvoker : global::Java.Lang.Object, IBluetoothConnectListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener", typeof (IBluetoothConnectListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IBluetoothConnectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBluetoothConnectListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.connect.BleConnectMaster.BluetoothConnectListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBluetoothConnectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDisconnected_Ljava_lang_String_Z;
#pragma warning disable 0169
			static Delegate GetOnDisconnected_Ljava_lang_String_ZHandler ()
			{
				if (cb_onDisconnected_Ljava_lang_String_Z == null)
					cb_onDisconnected_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnDisconnected_Ljava_lang_String_Z);
				return cb_onDisconnected_Ljava_lang_String_Z;
			}

			static void n_OnDisconnected_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDisconnected (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDisconnected_Ljava_lang_String_Z;
			public unsafe void OnDisconnected (string p0, bool p1)
			{
				if (id_onDisconnected_Ljava_lang_String_Z == IntPtr.Zero)
					id_onDisconnected_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onDisconnected", "(Ljava/lang/String;Z)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnected_Ljava_lang_String_Z, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onError_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_String_ILjava_lang_String_Handler ()
			{
				if (cb_onError_Ljava_lang_String_ILjava_lang_String_ == null)
					cb_onError_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnError_Ljava_lang_String_ILjava_lang_String_);
				return cb_onError_Ljava_lang_String_ILjava_lang_String_;
			}

			static void n_OnError_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_String_ILjava_lang_String_;
			public unsafe void OnError (string p0, int p1, string p2)
			{
				if (id_onError_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
					id_onError_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/String;ILjava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_String_ILjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}

		// event args for com.vivalnk.sdk.common.ble.connect.BleConnectMaster.BluetoothConnectListener.onDisconnected
		public partial class DisconnectedEventArgs : global::System.EventArgs {

			public DisconnectedEventArgs (string p0, bool p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			bool p1;
			public bool P1 {
				get { return p1; }
			}
		}

		// event args for com.vivalnk.sdk.common.ble.connect.BleConnectMaster.BluetoothConnectListener.onError
		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (string p0, int p1, string p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			string p2;
			public string P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vivalnk/sdk/common/ble/connect/BleConnectMaster_BluetoothConnectListenerImplementor")]
		internal sealed partial class IBluetoothConnectListenerImplementor : global::Java.Lang.Object, IBluetoothConnectListener {

			object sender;

			public IBluetoothConnectListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vivalnk/sdk/common/ble/connect/BleConnectMaster_BluetoothConnectListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DisconnectedEventArgs> OnDisconnectedHandler;
#pragma warning restore 0649

			public void OnDisconnected (string p0, bool p1)
			{
				var __h = OnDisconnectedHandler;
				if (__h != null)
					__h (sender, new DisconnectedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

			public void OnError (string p0, int p1, string p2)
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IBluetoothConnectListenerImplementor value)
			{
				return value.OnDisconnectedHandler == null && value.OnErrorHandler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/BleConnectMaster", typeof (BleConnectMaster));
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

		protected BleConnectMaster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/constructor[@name='BleConnectMaster' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe BleConnectMaster (global::Android.Content.Context context, string mac)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_mac);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_getBleGattProfile;
#pragma warning disable 0169
		static Delegate GetGetBleGattProfileHandler ()
		{
			if (cb_getBleGattProfile == null)
				cb_getBleGattProfile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBleGattProfile);
			return cb_getBleGattProfile;
		}

		static IntPtr n_GetBleGattProfile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BleGattProfile);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile BleGattProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='getBleGattProfile' and count(parameter)=0]"
			[Register ("getBleGattProfile", "()Lcom/vivalnk/sdk/common/ble/model/BleGattProfile;", "GetGetBleGattProfileHandler")]
			get {
				const string __id = "getBleGattProfile.()Lcom/vivalnk/sdk/common/ble/model/BleGattProfile;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Model.BleGattProfile> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBluetoothDevice;
#pragma warning disable 0169
		static Delegate GetGetBluetoothDeviceHandler ()
		{
			if (cb_getBluetoothDevice == null)
				cb_getBluetoothDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBluetoothDevice);
			return cb_getBluetoothDevice;
		}

		static IntPtr n_GetBluetoothDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BluetoothDevice);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Bluetooth.BluetoothDevice BluetoothDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='getBluetoothDevice' and count(parameter)=0]"
			[Register ("getBluetoothDevice", "()Landroid/bluetooth/BluetoothDevice;", "GetGetBluetoothDeviceHandler")]
			get {
				const string __id = "getBluetoothDevice.()Landroid/bluetooth/BluetoothDevice;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBluetoothGatt;
#pragma warning disable 0169
		static Delegate GetGetBluetoothGattHandler ()
		{
			if (cb_getBluetoothGatt == null)
				cb_getBluetoothGatt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBluetoothGatt);
			return cb_getBluetoothGatt;
		}

		static IntPtr n_GetBluetoothGatt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BluetoothGatt);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Bluetooth.BluetoothGatt BluetoothGatt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='getBluetoothGatt' and count(parameter)=0]"
			[Register ("getBluetoothGatt", "()Landroid/bluetooth/BluetoothGatt;", "GetGetBluetoothGattHandler")]
			get {
				const string __id = "getBluetoothGatt.()Landroid/bluetooth/BluetoothGatt;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectStatus;
#pragma warning disable 0169
		static Delegate GetGetConnectStatusHandler ()
		{
			if (cb_getConnectStatus == null)
				cb_getConnectStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetConnectStatus);
			return cb_getConnectStatus;
		}

		static int n_GetConnectStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectStatus;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectStatus_I;
#pragma warning disable 0169
		static Delegate GetSetConnectStatus_IHandler ()
		{
			if (cb_setConnectStatus_I == null)
				cb_setConnectStatus_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetConnectStatus_I);
			return cb_setConnectStatus_I;
		}

		static void n_SetConnectStatus_I (IntPtr jnienv, IntPtr native__this, int status)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectStatus = status;
		}
#pragma warning restore 0169

		public virtual unsafe int ConnectStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='getConnectStatus' and count(parameter)=0]"
			[Register ("getConnectStatus", "()I", "GetGetConnectStatusHandler")]
			get {
				const string __id = "getConnectStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='setConnectStatus' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectStatus", "(I)V", "GetSetConnectStatus_IHandler")]
			set {
				const string __id = "setConnectStatus.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceProfile;
#pragma warning disable 0169
		static Delegate GetGetDeviceProfileHandler ()
		{
			if (cb_getDeviceProfile == null)
				cb_getDeviceProfile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceProfile);
			return cb_getDeviceProfile;
		}

		static IntPtr n_GetDeviceProfile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>>.ToLocalJniHandle (__this.DeviceProfile);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>> DeviceProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='getDeviceProfile' and count(parameter)=0]"
			[Register ("getDeviceProfile", "()Ljava/util/Map;", "GetGetDeviceProfileHandler")]
			get {
				const string __id = "getDeviceProfile.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Java.Util.UUID, global::System.Collections.Generic.IDictionary<global::Java.Util.UUID, global::Android.Bluetooth.BluetoothGattCharacteristic>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isConnecting;
#pragma warning disable 0169
		static Delegate GetIsConnectingHandler ()
		{
			if (cb_isConnecting == null)
				cb_isConnecting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnecting);
			return cb_isConnecting;
		}

		static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				const string __id = "isConnecting.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_checkBleRuntime;
#pragma warning disable 0169
		static Delegate GetCheckBleRuntimeHandler ()
		{
			if (cb_checkBleRuntime == null)
				cb_checkBleRuntime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_CheckBleRuntime);
			return cb_checkBleRuntime;
		}

		static int n_CheckBleRuntime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckBleRuntime ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='checkBleRuntime' and count(parameter)=0]"
		[Register ("checkBleRuntime", "()I", "GetCheckBleRuntimeHandler")]
		public virtual unsafe int CheckBleRuntime ()
		{
			const string __id = "checkBleRuntime.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler ()
		{
			if (cb_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ == null)
				cb_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_);
			return cb_connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
		}

		static void n_Connect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Connect (options, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.BleConnectOptions'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.BleConnectMaster.BluetoothConnectListener']]"
		[Register ("connect", "(Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V", "GetConnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler")]
		public virtual unsafe void Connect (global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions options, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener listener)
		{
			const string __id = "connect.(Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disconnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler ()
		{
			if (cb_disconnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ == null)
				cb_disconnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Disconnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_);
			return cb_disconnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_;
		}

		static void n_Disconnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.BleConnectMaster.BluetoothConnectListener']]"
		[Register ("disconnect", "(Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V", "GetDisconnect_Lcom_vivalnk_sdk_common_ble_connect_BleConnectMaster_BluetoothConnectListener_Handler")]
		public virtual unsafe void Disconnect (global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener listener)
		{
			const string __id = "disconnect.(Lcom/vivalnk/sdk/common/ble/connect/BleConnectMaster$BluetoothConnectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disconnectQuietly;
#pragma warning disable 0169
		static Delegate GetDisconnectQuietlyHandler ()
		{
			if (cb_disconnectQuietly == null)
				cb_disconnectQuietly = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DisconnectQuietly);
			return cb_disconnectQuietly;
		}

		static void n_DisconnectQuietly (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectQuietly ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='disconnectQuietly' and count(parameter)=0]"
		[Register ("disconnectQuietly", "()V", "GetDisconnectQuietlyHandler")]
		public virtual unsafe void DisconnectQuietly ()
		{
			const string __id = "disconnectQuietly.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getCharacter_Ljava_util_UUID_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetGetCharacter_Ljava_util_UUID_Ljava_util_UUID_Handler ()
		{
			if (cb_getCharacter_Ljava_util_UUID_Ljava_util_UUID_ == null)
				cb_getCharacter_Ljava_util_UUID_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetCharacter_Ljava_util_UUID_Ljava_util_UUID_);
			return cb_getCharacter_Ljava_util_UUID_Ljava_util_UUID_;
		}

		static IntPtr n_GetCharacter_Ljava_util_UUID_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_character)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var service = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_service, JniHandleOwnership.DoNotTransfer);
			var character = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_character, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCharacter (service, character));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='getCharacter' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID']]"
		[Register ("getCharacter", "(Ljava/util/UUID;Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattCharacteristic;", "GetGetCharacter_Ljava_util_UUID_Ljava_util_UUID_Handler")]
		public virtual unsafe global::Android.Bluetooth.BluetoothGattCharacteristic GetCharacter (global::Java.Util.UUID service, global::Java.Util.UUID character)
		{
			const string __id = "getCharacter.(Ljava/util/UUID;Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattCharacteristic;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isDeviceConnected_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsDeviceConnected_Ljava_lang_String_Handler ()
		{
			if (cb_isDeviceConnected_Ljava_lang_String_ == null)
				cb_isDeviceConnected_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsDeviceConnected_Ljava_lang_String_);
			return cb_isDeviceConnected_Ljava_lang_String_;
		}

		static bool n_IsDeviceConnected_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDeviceConnected (mac);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='isDeviceConnected' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isDeviceConnected", "(Ljava/lang/String;)Z", "GetIsDeviceConnected_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsDeviceConnected (string mac)
		{
			const string __id = "isDeviceConnected.(Ljava/lang/String;)Z";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_;
#pragma warning disable 0169
		static Delegate GetOnBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_Handler ()
		{
			if (cb_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_ == null)
				cb_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_);
			return cb_onBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_;
		}

		static void n_OnBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.BluetoothStateEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnBluetoothStateChange (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='onBluetoothStateChange' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.event.BluetoothStateEvent']]"
		[Register ("onBluetoothStateChange", "(Lcom/vivalnk/sdk/common/ble/connect/event/BluetoothStateEvent;)V", "GetOnBluetoothStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BluetoothStateEvent_Handler")]
		public virtual unsafe void OnBluetoothStateChange (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.BluetoothStateEvent e)
		{
			const string __id = "onBluetoothStateChange.(Lcom/vivalnk/sdk/common/ble/connect/event/BluetoothStateEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onBondStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BondEvent_;
#pragma warning disable 0169
		static Delegate GetOnBondStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BondEvent_Handler ()
		{
			if (cb_onBondStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BondEvent_ == null)
				cb_onBondStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BondEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnBondStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BondEvent_);
			return cb_onBondStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BondEvent_;
		}

		static void n_OnBondStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BondEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.BondEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnBondStateChange (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='onBondStateChange' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.event.BondEvent']]"
		[Register ("onBondStateChange", "(Lcom/vivalnk/sdk/common/ble/connect/event/BondEvent;)V", "GetOnBondStateChange_Lcom_vivalnk_sdk_common_ble_connect_event_BondEvent_Handler")]
		public virtual unsafe void OnBondStateChange (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.BondEvent e)
		{
			const string __id = "onBondStateChange.(Lcom/vivalnk/sdk/common/ble/connect/event/BondEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionUpdated_III;
#pragma warning disable 0169
		static Delegate GetOnConnectionUpdated_IIIHandler ()
		{
			if (cb_onConnectionUpdated_III == null)
				cb_onConnectionUpdated_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_V) n_OnConnectionUpdated_III);
			return cb_onConnectionUpdated_III;
		}

		static void n_OnConnectionUpdated_III (IntPtr jnienv, IntPtr native__this, int interval, int latency, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionUpdated (interval, latency, timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='onConnectionUpdated' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onConnectionUpdated", "(III)V", "GetOnConnectionUpdated_IIIHandler")]
		protected virtual unsafe void OnConnectionUpdated (int interval, int latency, int timeout)
		{
			const string __id = "onConnectionUpdated.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (interval);
				__args [1] = new JniArgumentValue (latency);
				__args [2] = new JniArgumentValue (timeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onOTAEvent_Lcom_vivalnk_sdk_common_ble_connect_event_OTAEvent_;
#pragma warning disable 0169
		static Delegate GetOnOTAEvent_Lcom_vivalnk_sdk_common_ble_connect_event_OTAEvent_Handler ()
		{
			if (cb_onOTAEvent_Lcom_vivalnk_sdk_common_ble_connect_event_OTAEvent_ == null)
				cb_onOTAEvent_Lcom_vivalnk_sdk_common_ble_connect_event_OTAEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnOTAEvent_Lcom_vivalnk_sdk_common_ble_connect_event_OTAEvent_);
			return cb_onOTAEvent_Lcom_vivalnk_sdk_common_ble_connect_event_OTAEvent_;
		}

		static void n_OnOTAEvent_Lcom_vivalnk_sdk_common_ble_connect_event_OTAEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.OTAEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnOTAEvent (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='onOTAEvent' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.event.OTAEvent']]"
		[Register ("onOTAEvent", "(Lcom/vivalnk/sdk/common/ble/connect/event/OTAEvent;)V", "GetOnOTAEvent_Lcom_vivalnk_sdk_common_ble_connect_event_OTAEvent_Handler")]
		public virtual unsafe void OnOTAEvent (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.OTAEvent e)
		{
			const string __id = "onOTAEvent.(Lcom/vivalnk/sdk/common/ble/connect/event/OTAEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPairRequest_Lcom_vivalnk_sdk_common_ble_connect_event_PairRequestEvent_;
#pragma warning disable 0169
		static Delegate GetOnPairRequest_Lcom_vivalnk_sdk_common_ble_connect_event_PairRequestEvent_Handler ()
		{
			if (cb_onPairRequest_Lcom_vivalnk_sdk_common_ble_connect_event_PairRequestEvent_ == null)
				cb_onPairRequest_Lcom_vivalnk_sdk_common_ble_connect_event_PairRequestEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPairRequest_Lcom_vivalnk_sdk_common_ble_connect_event_PairRequestEvent_);
			return cb_onPairRequest_Lcom_vivalnk_sdk_common_ble_connect_event_PairRequestEvent_;
		}

		static void n_OnPairRequest_Lcom_vivalnk_sdk_common_ble_connect_event_PairRequestEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.PairRequestEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnPairRequest (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='onPairRequest' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.event.PairRequestEvent']]"
		[Register ("onPairRequest", "(Lcom/vivalnk/sdk/common/ble/connect/event/PairRequestEvent;)V", "GetOnPairRequest_Lcom_vivalnk_sdk_common_ble_connect_event_PairRequestEvent_Handler")]
		public virtual unsafe void OnPairRequest (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Event.PairRequestEvent e)
		{
			const string __id = "onPairRequest.(Lcom/vivalnk/sdk/common/ble/connect/event/PairRequestEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startConnectTiming;
#pragma warning disable 0169
		static Delegate GetStartConnectTimingHandler ()
		{
			if (cb_startConnectTiming == null)
				cb_startConnectTiming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartConnectTiming);
			return cb_startConnectTiming;
		}

		static void n_StartConnectTiming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartConnectTiming ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='startConnectTiming' and count(parameter)=0]"
		[Register ("startConnectTiming", "()V", "GetStartConnectTimingHandler")]
		public virtual unsafe void StartConnectTiming ()
		{
			const string __id = "startConnectTiming.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopConnectTiming;
#pragma warning disable 0169
		static Delegate GetStopConnectTimingHandler ()
		{
			if (cb_stopConnectTiming == null)
				cb_stopConnectTiming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopConnectTiming);
			return cb_stopConnectTiming;
		}

		static void n_StopConnectTiming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopConnectTiming ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectMaster']/method[@name='stopConnectTiming' and count(parameter)=0]"
		[Register ("stopConnectTiming", "()V", "GetStopConnectTimingHandler")]
		public virtual unsafe void StopConnectTiming ()
		{
			const string __id = "stopConnectTiming.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
