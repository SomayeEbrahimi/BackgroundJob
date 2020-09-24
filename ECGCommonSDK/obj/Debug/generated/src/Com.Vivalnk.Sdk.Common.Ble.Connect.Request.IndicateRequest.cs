using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='IndicateRequest']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/request/IndicateRequest", DoNotGenerateAcw=true)]
	public partial class IndicateRequest : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.BaseIORequest {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/interface[@name='IndicateRequest.IndicateListener']"
		[Register ("com/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener", "", "Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest/IIndicateListenerInvoker")]
		public partial interface IIndicateListener : global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IRequestCallback {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/interface[@name='IndicateRequest.IndicateListener']/method[@name='onComplete' and count(parameter)=0]"
			[Register ("onComplete", "()V", "GetOnCompleteHandler:Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest/IIndicateListenerInvoker, ECGCommonSDK")]
			void OnComplete ();

		}

		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener", DoNotGenerateAcw=true)]
		internal partial class IIndicateListenerInvoker : global::Java.Lang.Object, IIndicateListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener", typeof (IIndicateListenerInvoker));

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

			public static IIndicateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IIndicateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IIndicateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/request/IndicateRequest", typeof (IndicateRequest));
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

		protected IndicateRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='IndicateRequest']/constructor[@name='IndicateRequest' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.vivalnk.sdk.common.ble.connect.base.IORequestOptions'] and parameter[3][@type='com.vivalnk.sdk.common.ble.connect.request.IndicateRequest.IndicateListener'] and parameter[4][@type='java.util.UUID'] and parameter[5][@type='java.util.UUID'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Ljava/util/UUID;Ljava/util/UUID;Z)V", "")]
		public unsafe IndicateRequest (string mac, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions requestOptions, global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest.IIndicateListener listener, global::Java.Util.UUID service, global::Java.Util.UUID character, bool enable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;Lcom/vivalnk/sdk/common/ble/connect/request/IndicateRequest$IndicateListener;Ljava/util/UUID;Ljava/util/UUID;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue ((requestOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestOptions).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [4] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				__args [5] = new JniArgumentValue (enable);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='IndicateRequest']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")]
			get {
				const string __id = "getRequestName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Request.IndicateRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Process ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.request']/class[@name='IndicateRequest']/method[@name='process' and count(parameter)=0]"
		[Register ("process", "()V", "GetProcessHandler")]
		protected override unsafe void Process ()
		{
			const string __id = "process.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
