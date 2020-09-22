using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.listener']/interface[@name='IBleRequest']"
	[Register ("com/vivalnk/sdk/common/ble/connect/listener/IBleRequest", "", "Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleRequestInvoker")]
	public partial interface IBleRequest : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.listener']/interface[@name='IBleRequest']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleRequestInvoker, AndriodBinding")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.listener']/interface[@name='IBleRequest']/method[@name='process' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.listener.IBleDispatcher']]"
		[Register ("process", "(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V", "GetProcess_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_Handler:Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleRequestInvoker, AndriodBinding")]
		void Process (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/listener/IBleRequest", DoNotGenerateAcw=true)]
	internal partial class IBleRequestInvoker : global::Java.Lang.Object, IBleRequest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/listener/IBleRequest");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBleRequestInvoker); }
		}

		IntPtr class_ref;

		public static IBleRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBleRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.connect.listener.IBleRequest"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBleRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_;
#pragma warning disable 0169
		static Delegate GetProcess_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_Handler ()
		{
			if (cb_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ == null)
				cb_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_);
			return cb_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_;
		}

		static void n_Process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Process (p0);
		}
#pragma warning restore 0169

		IntPtr id_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_;
		public unsafe void Process (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher p0)
		{
			if (id_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ == IntPtr.Zero)
				id_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_ = JNIEnv.GetMethodID (class_ref, "process", "(Lcom/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process_Lcom_vivalnk_sdk_common_ble_connect_listener_IBleDispatcher_, __args);
		}

	}

}
