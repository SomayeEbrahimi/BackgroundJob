using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='DiscoverService']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/request/DiscoverService", DoNotGenerateAcw=true)]
	public partial class DiscoverService : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/interface[@name='DiscoverService.DiscoverServiceListener']"
		[Register ("com/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener", "", "Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService/IDiscoverServiceListenerInvoker")]
		public partial interface IDiscoverServiceListener : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/interface[@name='DiscoverService.DiscoverServiceListener']/method[@name='onComplete' and count(parameter)=0]"
			[Register ("onComplete", "()V", "GetOnCompleteHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService/IDiscoverServiceListenerInvoker, AndriodBinding")]
			void OnComplete ();

		}

		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener", DoNotGenerateAcw=true)]
		internal partial class IDiscoverServiceListenerInvoker : global::Java.Lang.Object, IDiscoverServiceListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDiscoverServiceListenerInvoker); }
			}

			IntPtr class_ref;

			public static IDiscoverServiceListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDiscoverServiceListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.connect.request.DiscoverService.DiscoverServiceListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDiscoverServiceListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onComplete;
#pragma warning disable 0169
			static Delegate GetOnCompleteHandler ()
			{
				if (cb_onComplete == null)
					cb_onComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnComplete);
				return cb_onComplete;
			}

			static void n_OnComplete (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete ();
			}
#pragma warning restore 0169

			IntPtr id_onComplete;
			public unsafe void OnComplete ()
			{
				if (id_onComplete == IntPtr.Zero)
					id_onComplete = JNIEnv.GetMethodID (class_ref, "onComplete", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/request/DiscoverService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiscoverService); }
		}

		protected DiscoverService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='DiscoverService']/constructor[@name='DiscoverService' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.base.IORequestOptions'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.DiscoverService.DiscoverServiceListener']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V", "")]
		public unsafe DiscoverService (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions requestOptions, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService.IDiscoverServiceListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (requestOptions);
				__args [2] = new JValue (listener);
				if (((object) this).GetType () != typeof (DiscoverService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/DiscoverService$DiscoverServiceListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_vivalnk_sdk_common_ble_connect_base_IORequestOptions_Lcom_vivalnk_sdk_common_ble_connect_request_DiscoverService_DiscoverServiceListener_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='DiscoverService']/method[@name='getRequestName' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Process ();
		}
#pragma warning restore 0169

		static IntPtr id_process;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='DiscoverService']/method[@name='process' and count(parameter)=0]"
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

		static Delegate cb_setOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_;
#pragma warning disable 0169
		static Delegate GetSetOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Handler ()
		{
			if (cb_setOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_ == null)
				cb_setOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_);
			return cb_setOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_;
		}

		static void n_SetOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.DiscoverService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.SetOptions (options);
		}
#pragma warning restore 0169

		static IntPtr id_setOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='DiscoverService']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.ble.connect.BleConnectOptions']]"
		[Register ("setOptions", "(Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;)V", "GetSetOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_Handler")]
		public virtual unsafe void SetOptions (global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions options)
		{
			if (id_setOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_ == IntPtr.Zero)
				id_setOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_ = JNIEnv.GetMethodID (class_ref, "setOptions", "(Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (options);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOptions_Lcom_vivalnk_sdk_common_ble_connect_BleConnectOptions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptions", "(Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;)V"), __args);
			} finally {
			}
		}

	}
}
