using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='MtuRequest']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/request/MtuRequest", DoNotGenerateAcw=true)]
	public partial class MtuRequest : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/interface[@name='MtuRequest.MtuListener']"
		[Register ("com/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener", "", "Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest/IMtuListenerInvoker")]
		public partial interface IMtuListener : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/interface[@name='MtuRequest.MtuListener']/method[@name='onComplete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onComplete", "(II)V", "GetOnComplete_IIHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest/IMtuListenerInvoker, AndriodBinding")]
			void OnComplete (int p0, int p1);

		}

		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener", DoNotGenerateAcw=true)]
		internal partial class IMtuListenerInvoker : global::Java.Lang.Object, IMtuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMtuListenerInvoker); }
			}

			IntPtr class_ref;

			public static IMtuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMtuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.connect.request.MtuRequest.MtuListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMtuListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onComplete_II;
#pragma warning disable 0169
			static Delegate GetOnComplete_IIHandler ()
			{
				if (cb_onComplete_II == null)
					cb_onComplete_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnComplete_II);
				return cb_onComplete_II;
			}

			static void n_OnComplete_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_II;
			public unsafe void OnComplete (int p0, int p1)
			{
				if (id_onComplete_II == IntPtr.Zero)
					id_onComplete_II = JNIEnv.GetMethodID (class_ref, "onComplete", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_II, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/request/MtuRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MtuRequest); }
		}

		protected MtuRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='MtuRequest']/constructor[@name='MtuRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.base.IORequestOptions'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.MtuRequest.MtuListener'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;I)V", "")]
		public unsafe MtuRequest (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions requestOptions, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest.IMtuListener listener, int mtu)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (requestOptions);
				__args [2] = new JValue (listener);
				__args [3] = new JValue (mtu);
				if (((object) this).GetType () != typeof (MtuRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/MtuRequest$MtuListener;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_MtuRequest_MtuListener_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_getRequestName;
#pragma warning disable 0169
		static Delegate GetGetRequestNameHandler ()
		{
			if (cb_getRequestName == null)
				cb_getRequestName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestName);
			return cb_getRequestName;
		}

		static IntPtr n_GetRequestName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='MtuRequest']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")]
			get {
				if (id_getRequestName == IntPtr.Zero)
					id_getRequestName = JNIEnv.GetMethodID (class_ref, "getRequestName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_process;
#pragma warning disable 0169
		static Delegate GetProcessHandler ()
		{
			if (cb_process == null)
				cb_process = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Process);
			return cb_process;
		}

		static void n_Process (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.MtuRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Process ();
		}
#pragma warning restore 0169

		static IntPtr id_process;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='MtuRequest']/method[@name='process' and count(parameter)=0]"
		[Register ("process", "()V", "GetProcessHandler")]
		public override unsafe void Process ()
		{
			if (id_process == IntPtr.Zero)
				id_process = JNIEnv.GetMethodID (class_ref, "process", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "()V"));
			} finally {
			}
		}

	}
}
