using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Open {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.open']/interface[@name='IBPInterface']"
	[Register ("com/vivalnk/sdk/open/IBPInterface", "", "Com.Vivalnk.Sdk.Open.IBPInterfaceInvoker")]
	public partial interface IBPInterface : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/interface[@name='IBPInterface']/method[@name='addData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.SampleData']]"
		[Register ("addData", "(Lcom/vivalnk/sdk/model/SampleData;)V", "GetAddData_Lcom_vivalnk_sdk_model_SampleData_Handler:Com.Vivalnk.Sdk.Open.IBPInterfaceInvoker, ECGCoreSDK")]
		void AddData (global::Com.Vivalnk.Sdk.Model.SampleData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/interface[@name='IBPInterface']/method[@name='initCalibrationData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;com.vivalnk.sdk.model.SampleData&gt;']]"
		[Register ("initCalibrationData", "(IILjava/util/List;)V", "GetInitCalibrationData_IILjava_util_List_Handler:Com.Vivalnk.Sdk.Open.IBPInterfaceInvoker, ECGCoreSDK")]
		void InitCalibrationData (int p0, int p1, global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.SampleData> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/interface[@name='IBPInterface']/method[@name='initUserInfo' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Person']]"
		[Register ("initUserInfo", "(Lcom/vivalnk/sdk/model/Person;)V", "GetInitUserInfo_Lcom_vivalnk_sdk_model_Person_Handler:Com.Vivalnk.Sdk.Open.IBPInterfaceInvoker, ECGCoreSDK")]
		void InitUserInfo (global::Com.Vivalnk.Sdk.Model.Person p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/interface[@name='IBPInterface']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.open.BPManager.BPResultListener']]"
		[Register ("setListener", "(Lcom/vivalnk/sdk/open/BPManager$BPResultListener;)V", "GetSetListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_Handler:Com.Vivalnk.Sdk.Open.IBPInterfaceInvoker, ECGCoreSDK")]
		void SetListener (global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/open/IBPInterface", DoNotGenerateAcw=true)]
	internal partial class IBPInterfaceInvoker : global::Java.Lang.Object, IBPInterface {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/open/IBPInterface", typeof (IBPInterfaceInvoker));

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

		public static IBPInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBPInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.open.IBPInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBPInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addData_Lcom_vivalnk_sdk_model_SampleData_;
#pragma warning disable 0169
		static Delegate GetAddData_Lcom_vivalnk_sdk_model_SampleData_Handler ()
		{
			if (cb_addData_Lcom_vivalnk_sdk_model_SampleData_ == null)
				cb_addData_Lcom_vivalnk_sdk_model_SampleData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddData_Lcom_vivalnk_sdk_model_SampleData_);
			return cb_addData_Lcom_vivalnk_sdk_model_SampleData_;
		}

		static void n_AddData_Lcom_vivalnk_sdk_model_SampleData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.IBPInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddData (p0);
		}
#pragma warning restore 0169

		IntPtr id_addData_Lcom_vivalnk_sdk_model_SampleData_;
		public unsafe void AddData (global::Com.Vivalnk.Sdk.Model.SampleData p0)
		{
			if (id_addData_Lcom_vivalnk_sdk_model_SampleData_ == IntPtr.Zero)
				id_addData_Lcom_vivalnk_sdk_model_SampleData_ = JNIEnv.GetMethodID (class_ref, "addData", "(Lcom/vivalnk/sdk/model/SampleData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addData_Lcom_vivalnk_sdk_model_SampleData_, __args);
		}

		static Delegate cb_initCalibrationData_IILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetInitCalibrationData_IILjava_util_List_Handler ()
		{
			if (cb_initCalibrationData_IILjava_util_List_ == null)
				cb_initCalibrationData_IILjava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_InitCalibrationData_IILjava_util_List_);
			return cb_initCalibrationData_IILjava_util_List_;
		}

		static void n_InitCalibrationData_IILjava_util_List_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.IBPInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.InitCalibrationData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_initCalibrationData_IILjava_util_List_;
		public unsafe void InitCalibrationData (int p0, int p1, global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.SampleData> p2)
		{
			if (id_initCalibrationData_IILjava_util_List_ == IntPtr.Zero)
				id_initCalibrationData_IILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "initCalibrationData", "(IILjava/util/List;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initCalibrationData_IILjava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_initUserInfo_Lcom_vivalnk_sdk_model_Person_;
#pragma warning disable 0169
		static Delegate GetInitUserInfo_Lcom_vivalnk_sdk_model_Person_Handler ()
		{
			if (cb_initUserInfo_Lcom_vivalnk_sdk_model_Person_ == null)
				cb_initUserInfo_Lcom_vivalnk_sdk_model_Person_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InitUserInfo_Lcom_vivalnk_sdk_model_Person_);
			return cb_initUserInfo_Lcom_vivalnk_sdk_model_Person_;
		}

		static void n_InitUserInfo_Lcom_vivalnk_sdk_model_Person_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.IBPInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Person> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitUserInfo (p0);
		}
#pragma warning restore 0169

		IntPtr id_initUserInfo_Lcom_vivalnk_sdk_model_Person_;
		public unsafe void InitUserInfo (global::Com.Vivalnk.Sdk.Model.Person p0)
		{
			if (id_initUserInfo_Lcom_vivalnk_sdk_model_Person_ == IntPtr.Zero)
				id_initUserInfo_Lcom_vivalnk_sdk_model_Person_ = JNIEnv.GetMethodID (class_ref, "initUserInfo", "(Lcom/vivalnk/sdk/model/Person;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initUserInfo_Lcom_vivalnk_sdk_model_Person_, __args);
		}

		static Delegate cb_setListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_Handler ()
		{
			if (cb_setListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_ == null)
				cb_setListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_);
			return cb_setListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_;
		}

		static void n_SetListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.IBPInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_;
		public unsafe void SetListener (global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener p0)
		{
			if (id_setListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_ == IntPtr.Zero)
				id_setListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/vivalnk/sdk/open/BPManager$BPResultListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_vivalnk_sdk_open_BPManager_BPResultListener_, __args);
		}

	}

}
