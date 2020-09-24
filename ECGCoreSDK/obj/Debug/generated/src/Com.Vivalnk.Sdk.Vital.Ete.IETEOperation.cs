using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Vital.Ete {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETEOperation']"
	[Register ("com/vivalnk/sdk/vital/ete/ETEOperation", "", "Com.Vivalnk.Sdk.Vital.Ete.IETEOperationInvoker")]
	public partial interface IETEOperation : IJavaObject, IJavaPeerable {

		string ETEVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETEOperation']/method[@name='getETEVersion' and count(parameter)=0]"
			[Register ("getETEVersion", "()Ljava/lang/String;", "GetGetETEVersionHandler:Com.Vivalnk.Sdk.Vital.Ete.IETEOperationInvoker, ECGCoreSDK")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETEOperation']/method[@name='analyzerData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.SampleData']]"
		[Register ("analyzerData", "(Lcom/vivalnk/sdk/model/SampleData;)I", "GetAnalyzerData_Lcom_vivalnk_sdk_model_SampleData_Handler:Com.Vivalnk.Sdk.Vital.Ete.IETEOperationInvoker, ECGCoreSDK")]
		int AnalyzerData (global::Com.Vivalnk.Sdk.Model.SampleData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETEOperation']/method[@name='registerETEDataReceiveListener' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.vital.ete.ETEDataReceiveListener']]"
		[Register ("registerETEDataReceiveListener", "(Lcom/vivalnk/sdk/vital/ete/ETEDataReceiveListener;)V", "GetRegisterETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_Handler:Com.Vivalnk.Sdk.Vital.Ete.IETEOperationInvoker, ECGCoreSDK")]
		void RegisterETEDataReceiveListener (global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETEOperation']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Vivalnk.Sdk.Vital.Ete.IETEOperationInvoker, ECGCoreSDK")]
		void Reset ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETEOperation']/method[@name='setETEParameters' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.vital.ete.ETEParameter']]"
		[Register ("setETEParameters", "(Lcom/vivalnk/sdk/vital/ete/ETEParameter;)I", "GetSetETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_Handler:Com.Vivalnk.Sdk.Vital.Ete.IETEOperationInvoker, ECGCoreSDK")]
		int SetETEParameters (global::Com.Vivalnk.Sdk.Vital.Ete.ETEParameter p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETEOperation']/method[@name='unregisterETEDataReceiveListener' and count(parameter)=0]"
		[Register ("unregisterETEDataReceiveListener", "()V", "GetUnregisterETEDataReceiveListenerHandler:Com.Vivalnk.Sdk.Vital.Ete.IETEOperationInvoker, ECGCoreSDK")]
		void UnregisterETEDataReceiveListener ();

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/vital/ete/ETEOperation", DoNotGenerateAcw=true)]
	internal partial class IETEOperationInvoker : global::Java.Lang.Object, IETEOperation {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/vital/ete/ETEOperation", typeof (IETEOperationInvoker));

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

		public static IETEOperation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IETEOperation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.vital.ete.ETEOperation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IETEOperationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getETEVersion;
#pragma warning disable 0169
		static Delegate GetGetETEVersionHandler ()
		{
			if (cb_getETEVersion == null)
				cb_getETEVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetETEVersion);
			return cb_getETEVersion;
		}

		static IntPtr n_GetETEVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETEVersion);
		}
#pragma warning restore 0169

		IntPtr id_getETEVersion;
		public unsafe string ETEVersion {
			get {
				if (id_getETEVersion == IntPtr.Zero)
					id_getETEVersion = JNIEnv.GetMethodID (class_ref, "getETEVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getETEVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_analyzerData_Lcom_vivalnk_sdk_model_SampleData_;
#pragma warning disable 0169
		static Delegate GetAnalyzerData_Lcom_vivalnk_sdk_model_SampleData_Handler ()
		{
			if (cb_analyzerData_Lcom_vivalnk_sdk_model_SampleData_ == null)
				cb_analyzerData_Lcom_vivalnk_sdk_model_SampleData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_AnalyzerData_Lcom_vivalnk_sdk_model_SampleData_);
			return cb_analyzerData_Lcom_vivalnk_sdk_model_SampleData_;
		}

		static int n_AnalyzerData_Lcom_vivalnk_sdk_model_SampleData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AnalyzerData (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_analyzerData_Lcom_vivalnk_sdk_model_SampleData_;
		public unsafe int AnalyzerData (global::Com.Vivalnk.Sdk.Model.SampleData p0)
		{
			if (id_analyzerData_Lcom_vivalnk_sdk_model_SampleData_ == IntPtr.Zero)
				id_analyzerData_Lcom_vivalnk_sdk_model_SampleData_ = JNIEnv.GetMethodID (class_ref, "analyzerData", "(Lcom/vivalnk/sdk/model/SampleData;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_analyzerData_Lcom_vivalnk_sdk_model_SampleData_, __args);
			return __ret;
		}

		static Delegate cb_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_;
#pragma warning disable 0169
		static Delegate GetRegisterETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_Handler ()
		{
			if (cb_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_ == null)
				cb_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_);
			return cb_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_;
		}

		static void n_RegisterETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterETEDataReceiveListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_;
		public unsafe void RegisterETEDataReceiveListener (global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener p0)
		{
			if (id_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_ == IntPtr.Zero)
				id_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_ = JNIEnv.GetMethodID (class_ref, "registerETEDataReceiveListener", "(Lcom/vivalnk/sdk/vital/ete/ETEDataReceiveListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_, __args);
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
		}

		static Delegate cb_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_;
#pragma warning disable 0169
		static Delegate GetSetETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_Handler ()
		{
			if (cb_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_ == null)
				cb_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_SetETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_);
			return cb_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_;
		}

		static int n_SetETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEParameter> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetETEParameters (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_;
		public unsafe int SetETEParameters (global::Com.Vivalnk.Sdk.Vital.Ete.ETEParameter p0)
		{
			if (id_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_ == IntPtr.Zero)
				id_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_ = JNIEnv.GetMethodID (class_ref, "setETEParameters", "(Lcom/vivalnk/sdk/vital/ete/ETEParameter;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_, __args);
			return __ret;
		}

		static Delegate cb_unregisterETEDataReceiveListener;
#pragma warning disable 0169
		static Delegate GetUnregisterETEDataReceiveListenerHandler ()
		{
			if (cb_unregisterETEDataReceiveListener == null)
				cb_unregisterETEDataReceiveListener = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UnregisterETEDataReceiveListener);
			return cb_unregisterETEDataReceiveListener;
		}

		static void n_UnregisterETEDataReceiveListener (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterETEDataReceiveListener ();
		}
#pragma warning restore 0169

		IntPtr id_unregisterETEDataReceiveListener;
		public unsafe void UnregisterETEDataReceiveListener ()
		{
			if (id_unregisterETEDataReceiveListener == IntPtr.Zero)
				id_unregisterETEDataReceiveListener = JNIEnv.GetMethodID (class_ref, "unregisterETEDataReceiveListener", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterETEDataReceiveListener);
		}

	}

}
