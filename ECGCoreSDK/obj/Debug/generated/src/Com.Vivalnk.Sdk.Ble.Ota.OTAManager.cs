using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Ble.Ota {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/ble/ota/OTAManager", DoNotGenerateAcw=true)]
	public partial class OTAManager : global::Java.Lang.Object, global::Android.OS.Handler.ICallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "OTAManager";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/field[@name='b']"
		[Register ("b")]
		public global::Com.Vivalnk.Sdk.Model.Device B {
			get {
				const string __id = "b.Lcom/vivalnk/sdk/model/Device;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lcom/vivalnk/sdk/model/Device;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/field[@name='c']"
		[Register ("c")]
		public string C {
			get {
				const string __id = "c.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/field[@name='d']"
		[Register ("d")]
		public string D {
			get {
				const string __id = "d.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/field[@name='e']"
		[Register ("e")]
		public global::Java.IO.File E {
			get {
				const string __id = "e.Ljava/io/File;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "e.Ljava/io/File;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/field[@name='f']"
		[Register ("f")]
		public global::Android.Net.Uri F {
			get {
				const string __id = "f.Landroid/net/Uri;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "f.Landroid/net/Uri;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/field[@name='g']"
		[Register ("g")]
		public bool G {
			get {
				const string __id = "g.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "g.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/field[@name='h']"
		[Register ("h")]
		public bool H {
			get {
				const string __id = "h.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "h.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/field[@name='l']"
		[Register ("l")]
		public const int L = (int) 1024;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/ble/ota/OTAManager", typeof (OTAManager));
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

		protected OTAManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/constructor[@name='OTAManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OTAManager ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string A (string p0)
		{
			const string __id = "a.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message p0)
		{
			const string __id = "handleMessage.(Landroid/os/Message;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_registCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_;
#pragma warning disable 0169
		static Delegate GetRegistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_Handler ()
		{
			if (cb_registCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_ == null)
				cb_registCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RegistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_);
			return cb_registCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_;
		}

		static IntPtr n_RegistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Ble.Ota.IOTAListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.IOTAListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegistCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='registCallback' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.ble.ota.OTAListener']]"
		[Register ("registCallback", "(Lcom/vivalnk/sdk/ble/ota/OTAListener;)Lcom/vivalnk/sdk/ble/ota/OTAManager;", "GetRegistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager RegistCallback (global::Com.Vivalnk.Sdk.Ble.Ota.IOTAListener p0)
		{
			const string __id = "registCallback.(Lcom/vivalnk/sdk/ble/ota/OTAListener;)Lcom/vivalnk/sdk/ble/ota/OTAManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDevice_Lcom_vivalnk_sdk_model_Device_;
#pragma warning disable 0169
		static Delegate GetSetDevice_Lcom_vivalnk_sdk_model_Device_Handler ()
		{
			if (cb_setDevice_Lcom_vivalnk_sdk_model_Device_ == null)
				cb_setDevice_Lcom_vivalnk_sdk_model_Device_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDevice_Lcom_vivalnk_sdk_model_Device_);
			return cb_setDevice_Lcom_vivalnk_sdk_model_Device_;
		}

		static IntPtr n_SetDevice_Lcom_vivalnk_sdk_model_Device_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDevice (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='setDevice' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Device']]"
		[Register ("setDevice", "(Lcom/vivalnk/sdk/model/Device;)Lcom/vivalnk/sdk/ble/ota/OTAManager;", "GetSetDevice_Lcom_vivalnk_sdk_model_Device_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager SetDevice (global::Com.Vivalnk.Sdk.Model.Device p0)
		{
			const string __id = "setDevice.(Lcom/vivalnk/sdk/model/Device;)Lcom/vivalnk/sdk/ble/ota/OTAManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetFile_Ljava_io_File_Handler ()
		{
			if (cb_setFile_Ljava_io_File_ == null)
				cb_setFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetFile_Ljava_io_File_);
			return cb_setFile_Ljava_io_File_;
		}

		static IntPtr n_SetFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='setFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setFile", "(Ljava/io/File;)Lcom/vivalnk/sdk/ble/ota/OTAManager;", "GetSetFile_Ljava_io_File_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager SetFile (global::Java.IO.File p0)
		{
			const string __id = "setFile.(Ljava/io/File;)Lcom/vivalnk/sdk/ble/ota/OTAManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_vivalnk_sdk_ble_ota_OTAListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_vivalnk_sdk_ble_ota_OTAListener_Handler ()
		{
			if (cb_setListener_Lcom_vivalnk_sdk_ble_ota_OTAListener_ == null)
				cb_setListener_Lcom_vivalnk_sdk_ble_ota_OTAListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetListener_Lcom_vivalnk_sdk_ble_ota_OTAListener_);
			return cb_setListener_Lcom_vivalnk_sdk_ble_ota_OTAListener_;
		}

		static IntPtr n_SetListener_Lcom_vivalnk_sdk_ble_ota_OTAListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Ble.Ota.IOTAListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.IOTAListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.ble.ota.OTAListener']]"
		[Register ("setListener", "(Lcom/vivalnk/sdk/ble/ota/OTAListener;)Lcom/vivalnk/sdk/ble/ota/OTAManager;", "GetSetListener_Lcom_vivalnk_sdk_ble_ota_OTAListener_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager SetListener (global::Com.Vivalnk.Sdk.Ble.Ota.IOTAListener p0)
		{
			const string __id = "setListener.(Lcom/vivalnk/sdk/ble/ota/OTAListener;)Lcom/vivalnk/sdk/ble/ota/OTAManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNofication_Z;
#pragma warning disable 0169
		static Delegate GetSetNofication_ZHandler ()
		{
			if (cb_setNofication_Z == null)
				cb_setNofication_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetNofication_Z);
			return cb_setNofication_Z;
		}

		static IntPtr n_SetNofication_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNofication (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='setNofication' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNofication", "(Z)Lcom/vivalnk/sdk/ble/ota/OTAManager;", "GetSetNofication_ZHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager SetNofication (bool p0)
		{
			const string __id = "setNofication.(Z)Lcom/vivalnk/sdk/ble/ota/OTAManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUri_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetUri_Landroid_net_Uri_Handler ()
		{
			if (cb_setUri_Landroid_net_Uri_ == null)
				cb_setUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUri_Landroid_net_Uri_);
			return cb_setUri_Landroid_net_Uri_;
		}

		static IntPtr n_SetUri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setUri", "(Landroid/net/Uri;)Lcom/vivalnk/sdk/ble/ota/OTAManager;", "GetSetUri_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager SetUri (global::Android.Net.Uri p0)
		{
			const string __id = "setUri.(Landroid/net/Uri;)Lcom/vivalnk/sdk/ble/ota/OTAManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_startOTA;
#pragma warning disable 0169
		static Delegate GetStartOTAHandler ()
		{
			if (cb_startOTA == null)
				cb_startOTA = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartOTA);
			return cb_startOTA;
		}

		static void n_StartOTA (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartOTA ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='startOTA' and count(parameter)=0]"
		[Register ("startOTA", "()V", "GetStartOTAHandler")]
		public virtual unsafe void StartOTA ()
		{
			const string __id = "startOTA.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unregistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_;
#pragma warning disable 0169
		static Delegate GetUnregistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_Handler ()
		{
			if (cb_unregistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_ == null)
				cb_unregistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_UnregistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_);
			return cb_unregistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_;
		}

		static IntPtr n_UnregistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Ble.Ota.IOTAListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.IOTAListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnregistCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='unregistCallback' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.ble.ota.OTAListener']]"
		[Register ("unregistCallback", "(Lcom/vivalnk/sdk/ble/ota/OTAListener;)Lcom/vivalnk/sdk/ble/ota/OTAManager;", "GetUnregistCallback_Lcom_vivalnk_sdk_ble_ota_OTAListener_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager UnregistCallback (global::Com.Vivalnk.Sdk.Ble.Ota.IOTAListener p0)
		{
			const string __id = "unregistCallback.(Lcom/vivalnk/sdk/ble/ota/OTAListener;)Lcom/vivalnk/sdk/ble/ota/OTAManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unregistCallbackAll;
#pragma warning disable 0169
		static Delegate GetUnregistCallbackAllHandler ()
		{
			if (cb_unregistCallbackAll == null)
				cb_unregistCallbackAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_UnregistCallbackAll);
			return cb_unregistCallbackAll;
		}

		static IntPtr n_UnregistCallbackAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnregistCallbackAll ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.ota']/class[@name='OTAManager']/method[@name='unregistCallbackAll' and count(parameter)=0]"
		[Register ("unregistCallbackAll", "()Lcom/vivalnk/sdk/ble/ota/OTAManager;", "GetUnregistCallbackAllHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager UnregistCallbackAll ()
		{
			const string __id = "unregistCallbackAll.()Lcom/vivalnk/sdk/ble/ota/OTAManager;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Ota.OTAManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
