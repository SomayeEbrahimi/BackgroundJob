using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.listener']/interface[@name='IBleDispatcher']"
	[Register ("com/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher", "", "Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcherInvoker")]
	public partial interface IBleDispatcher : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.listener']/interface[@name='IBleDispatcher']/method[@name='onRequestFinsh' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.base.BaseIORequest']]"
		[Register ("onRequestFinsh", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V", "GetOnRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_Handler:Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcherInvoker, AndriodBinding")]
		void OnRequestFinsh (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher", DoNotGenerateAcw=true)]
	internal partial class IBleDispatcherInvoker : global::Java.Lang.Object, IBleDispatcher {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/listener/IBleDispatcher");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBleDispatcherInvoker); }
		}

		IntPtr class_ref;

		public static IBleDispatcher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBleDispatcher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.connect.listener.IBleDispatcher"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBleDispatcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
#pragma warning disable 0169
		static Delegate GetOnRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_Handler ()
		{
			if (cb_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ == null)
				cb_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_);
			return cb_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
		}

		static void n_OnRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Listener.IBleDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestFinsh (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_;
		public unsafe void OnRequestFinsh (global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest p0)
		{
			if (id_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ == IntPtr.Zero)
				id_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_ = JNIEnv.GetMethodID (class_ref, "onRequestFinsh", "(Lcom/vivalnk/sdk/common/ble/connect/base/BaseIORequest;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestFinsh_Lcom_vivalnk_sdk_common_ble_connect_base_BaseIORequest_, __args);
		}

	}

}
