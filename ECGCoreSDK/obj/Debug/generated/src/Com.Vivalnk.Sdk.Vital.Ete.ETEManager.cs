using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Vital.Ete {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/vital/ete/ETEManager", DoNotGenerateAcw=true)]
	public partial class ETEManager : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Vital.Ete.IETEOperation {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "ETEManagerProxy";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/field[@name='a']"
		[Register ("a")]
		public global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl A {
			get {
				const string __id = "a.Lcom/vivalnk/sdk/vital/ete/ETEManagerImpl;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/vivalnk/sdk/vital/ete/ETEManagerImpl;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/vital/ete/ETEManager", typeof (ETEManager));
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

		protected ETEManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/constructor[@name='ETEManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ETEManager ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETEVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string ETEVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='getETEVersion' and count(parameter)=0]"
			[Register ("getETEVersion", "()Ljava/lang/String;", "GetGetETEVersionHandler")]
			get {
				const string __id = "getETEVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AnalyzerData (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='analyzerData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.SampleData']]"
		[Register ("analyzerData", "(Lcom/vivalnk/sdk/model/SampleData;)I", "GetAnalyzerData_Lcom_vivalnk_sdk_model_SampleData_Handler")]
		public virtual unsafe int AnalyzerData (global::Com.Vivalnk.Sdk.Model.SampleData p0)
		{
			const string __id = "analyzerData.(Lcom/vivalnk/sdk/model/SampleData;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_Z;
#pragma warning disable 0169
		static Delegate GetAnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZHandler ()
		{
			if (cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_Z == null)
				cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJLLZ_I) n_AnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_Z);
			return cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_Z;
		}

		static int n_AnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_Z (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (global::Com.Vivalnk.Sdk.Vital.Ete.Motion[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Vital.Ete.Motion));
			int __ret = __this.AnalyzerData (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='analyzerData' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int[]'] and parameter[3][@type='com.vivalnk.sdk.vital.ete.Motion[]'] and parameter[4][@type='boolean']]"
		[Register ("analyzerData", "(J[I[Lcom/vivalnk/sdk/vital/ete/Motion;Z)I", "GetAnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZHandler")]
		public virtual unsafe int AnalyzerData (long p0, int[] p1, global::Com.Vivalnk.Sdk.Vital.Ete.Motion[] p2, bool p3)
		{
			const string __id = "analyzerData.(J[I[Lcom/vivalnk/sdk/vital/ete/Motion;Z)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZI;
#pragma warning disable 0169
		static Delegate GetAnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZIHandler ()
		{
			if (cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZI == null)
				cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJLLZZI_I) n_AnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZI);
			return cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZI;
		}

		static int n_AnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZI (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2, bool p3, bool p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (global::Com.Vivalnk.Sdk.Vital.Ete.Motion[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Vital.Ete.Motion));
			int __ret = __this.AnalyzerData (p0, p1, p2, p3, p4, p5);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='analyzerData' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='int[]'] and parameter[3][@type='com.vivalnk.sdk.vital.ete.Motion[]'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='int']]"
		[Register ("analyzerData", "(J[I[Lcom/vivalnk/sdk/vital/ete/Motion;ZZI)I", "GetAnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZIHandler")]
		public virtual unsafe int AnalyzerData (long p0, int[] p1, global::Com.Vivalnk.Sdk.Vital.Ete.Motion[] p2, bool p3, bool p4, int p5)
		{
			const string __id = "analyzerData.(J[I[Lcom/vivalnk/sdk/vital/ete/Motion;ZZI)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getResultSync_J;
#pragma warning disable 0169
		static Delegate GetGetResultSync_JHandler ()
		{
			if (cb_getResultSync_J == null)
				cb_getResultSync_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_GetResultSync_J);
			return cb_getResultSync_J;
		}

		static IntPtr n_GetResultSync_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetResultSync (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='getResultSync' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getResultSync", "(J)Lcom/vivalnk/sdk/vital/ete/ETEResult;", "GetGetResultSync_JHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult GetResultSync (long p0)
		{
			const string __id = "getResultSync.(J)Lcom/vivalnk/sdk/vital/ete/ETEResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initParameter;
#pragma warning disable 0169
		static Delegate GetInitParameterHandler ()
		{
			if (cb_initParameter == null)
				cb_initParameter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_InitParameter);
			return cb_initParameter;
		}

		static void n_InitParameter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitParameter ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='initParameter' and count(parameter)=0]"
		[Register ("initParameter", "()V", "GetInitParameterHandler")]
		public virtual unsafe void InitParameter ()
		{
			const string __id = "initParameter.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterETEDataReceiveListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='registerETEDataReceiveListener' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.vital.ete.ETEDataReceiveListener']]"
		[Register ("registerETEDataReceiveListener", "(Lcom/vivalnk/sdk/vital/ete/ETEDataReceiveListener;)V", "GetRegisterETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_Handler")]
		public virtual unsafe void RegisterETEDataReceiveListener (global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener p0)
		{
			const string __id = "registerETEDataReceiveListener.(Lcom/vivalnk/sdk/vital/ete/ETEDataReceiveListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEParameter> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetETEParameters (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='setETEParameters' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.vital.ete.ETEParameter']]"
		[Register ("setETEParameters", "(Lcom/vivalnk/sdk/vital/ete/ETEParameter;)I", "GetSetETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_Handler")]
		public virtual unsafe int SetETEParameters (global::Com.Vivalnk.Sdk.Vital.Ete.ETEParameter p0)
		{
			const string __id = "setETEParameters.(Lcom/vivalnk/sdk/vital/ete/ETEParameter;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterETEDataReceiveListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManager']/method[@name='unregisterETEDataReceiveListener' and count(parameter)=0]"
		[Register ("unregisterETEDataReceiveListener", "()V", "GetUnregisterETEDataReceiveListenerHandler")]
		public virtual unsafe void UnregisterETEDataReceiveListener ()
		{
			const string __id = "unregisterETEDataReceiveListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
