using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='ReadHelper']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/base/ReadHelper", DoNotGenerateAcw=true)]
	public partial class ReadHelper : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='ReadHelper']/field[@name='b']"
		[Register ("b")]
		public static global::Com.Vivalnk.Sdk.Base.ReadHelper B {
			get {
				const string __id = "b.Lcom/vivalnk/sdk/base/ReadHelper;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.ReadHelper> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lcom/vivalnk/sdk/base/ReadHelper;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/base/ReadHelper", typeof (ReadHelper));
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

		protected ReadHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='ReadHelper']/constructor[@name='ReadHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReadHelper ()
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

		public static unsafe global::Com.Vivalnk.Sdk.Base.ReadHelper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='ReadHelper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/vivalnk/sdk/base/ReadHelper;", "")]
			get {
				const string __id = "getInstance.()Lcom/vivalnk/sdk/base/ReadHelper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.ReadHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='ReadHelper']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool A (string p0)
		{
			const string __id = "a.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='ReadHelper']/method[@name='isOldAck' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Device']]"
		[Register ("isOldAck", "(Lcom/vivalnk/sdk/model/Device;)Z", "")]
		public static unsafe bool IsOldAck (global::Com.Vivalnk.Sdk.Model.Device p0)
		{
			const string __id = "isOldAck.(Lcom/vivalnk/sdk/model/Device;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='ReadHelper']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			const string __id = "main.([Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_readDeviceInfo_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_;
#pragma warning disable 0169
		static Delegate GetReadDeviceInfo_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_Handler ()
		{
			if (cb_readDeviceInfo_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_ == null)
				cb_readDeviceInfo_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ReadDeviceInfo_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_);
			return cb_readDeviceInfo_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_;
		}

		static void n_ReadDeviceInfo_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.ReadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReadDeviceInfo (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='ReadHelper']/method[@name='readDeviceInfo' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='com.vivalnk.sdk.base.RealCommand']]"
		[Register ("readDeviceInfo", "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/base/RealCommand;)V", "GetReadDeviceInfo_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_Handler")]
		public virtual unsafe void ReadDeviceInfo (global::Com.Vivalnk.Sdk.Model.Device p0, global::Com.Vivalnk.Sdk.Base.RealCommand p1)
		{
			const string __id = "readDeviceInfo.(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/base/RealCommand;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_readFWVersion_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_;
#pragma warning disable 0169
		static Delegate GetReadFWVersion_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_Handler ()
		{
			if (cb_readFWVersion_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_ == null)
				cb_readFWVersion_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ReadFWVersion_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_);
			return cb_readFWVersion_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_;
		}

		static void n_ReadFWVersion_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.ReadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReadFWVersion (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='ReadHelper']/method[@name='readFWVersion' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='com.vivalnk.sdk.base.RealCommand']]"
		[Register ("readFWVersion", "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/base/RealCommand;)V", "GetReadFWVersion_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_base_RealCommand_Handler")]
		public virtual unsafe void ReadFWVersion (global::Com.Vivalnk.Sdk.Model.Device p0, global::Com.Vivalnk.Sdk.Base.RealCommand p1)
		{
			const string __id = "readFWVersion.(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/base/RealCommand;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
