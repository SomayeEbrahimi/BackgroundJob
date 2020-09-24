using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/ConnectEventPoster", DoNotGenerateAcw=true)]
	public partial class ConnectEventPoster : global::Com.Vivalnk.Sdk.Common.Ble.Poster.AbsPoster, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/ConnectEventPoster", typeof (ConnectEventPoster));
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

		protected ConnectEventPoster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/constructor[@name='ConnectEventPoster' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectEventPoster ()
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

		static Delegate cb_onConnected_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Ljava_lang_String_Handler ()
		{
			if (cb_onConnected_Ljava_lang_String_ == null)
				cb_onConnected_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnConnected_Ljava_lang_String_);
			return cb_onConnected_Ljava_lang_String_;
		}

		static void n_OnConnected_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.ConnectEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (mac);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConnected", "(Ljava/lang/String;)V", "GetOnConnected_Ljava_lang_String_Handler")]
		public virtual unsafe void OnConnected (string mac)
		{
			const string __id = "onConnected.(Ljava/lang/String;)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_onDisconnected_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnDisconnected_Ljava_lang_String_ZHandler ()
		{
			if (cb_onDisconnected_Ljava_lang_String_Z == null)
				cb_onDisconnected_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnDisconnected_Ljava_lang_String_Z);
			return cb_onDisconnected_Ljava_lang_String_Z;
		}

		static void n_OnDisconnected_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, bool isForce)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.ConnectEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (mac, isForce);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onDisconnected' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("onDisconnected", "(Ljava/lang/String;Z)V", "GetOnDisconnected_Ljava_lang_String_ZHandler")]
		public virtual unsafe void OnDisconnected (string mac, bool isForce)
		{
			const string __id = "onDisconnected.(Ljava/lang/String;Z)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue (isForce);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_onError_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_String_ILjava_lang_String_Handler ()
		{
			if (cb_onError_Ljava_lang_String_ILjava_lang_String_ == null)
				cb_onError_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnError_Ljava_lang_String_ILjava_lang_String_);
			return cb_onError_Ljava_lang_String_ILjava_lang_String_;
		}

		static void n_OnError_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, int code, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.ConnectEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.OnError (mac, code, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onError", "(Ljava/lang/String;ILjava/lang/String;)V", "GetOnError_Ljava_lang_String_ILjava_lang_String_Handler")]
		public virtual unsafe void OnError (string mac, int code, string msg)
		{
			const string __id = "onError.(Ljava/lang/String;ILjava/lang/String;)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue (code);
				__args [2] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_onRetryConnect_Ljava_lang_String_IIJ;
#pragma warning disable 0169
		static Delegate GetOnRetryConnect_Ljava_lang_String_IIJHandler ()
		{
			if (cb_onRetryConnect_Ljava_lang_String_IIJ == null)
				cb_onRetryConnect_Ljava_lang_String_IIJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIJ_V) n_OnRetryConnect_Ljava_lang_String_IIJ);
			return cb_onRetryConnect_Ljava_lang_String_IIJ;
		}

		static void n_OnRetryConnect_Ljava_lang_String_IIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac, int totalRetryCount, int currentCount, long gapTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.ConnectEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			__this.OnRetryConnect (mac, totalRetryCount, currentCount, gapTime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onRetryConnect' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("onRetryConnect", "(Ljava/lang/String;IIJ)V", "GetOnRetryConnect_Ljava_lang_String_IIJHandler")]
		public virtual unsafe void OnRetryConnect (string mac, int totalRetryCount, int currentCount, long gapTime)
		{
			const string __id = "onRetryConnect.(Ljava/lang/String;IIJ)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_mac);
				__args [1] = new JniArgumentValue (totalRetryCount);
				__args [2] = new JniArgumentValue (currentCount);
				__args [3] = new JniArgumentValue (gapTime);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_onServiceReady_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnServiceReady_Ljava_lang_String_Handler ()
		{
			if (cb_onServiceReady_Ljava_lang_String_ == null)
				cb_onServiceReady_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnServiceReady_Ljava_lang_String_);
			return cb_onServiceReady_Ljava_lang_String_;
		}

		static void n_OnServiceReady_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.ConnectEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceReady (mac);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onServiceReady' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onServiceReady", "(Ljava/lang/String;)V", "GetOnServiceReady_Ljava_lang_String_Handler")]
		public virtual unsafe void OnServiceReady (string mac)
		{
			const string __id = "onServiceReady.(Ljava/lang/String;)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_onStart_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnStart_Ljava_lang_String_Handler ()
		{
			if (cb_onStart_Ljava_lang_String_ == null)
				cb_onStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnStart_Ljava_lang_String_);
			return cb_onStart_Ljava_lang_String_;
		}

		static void n_OnStart_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.ConnectEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			__this.OnStart (mac);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onStart' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onStart", "(Ljava/lang/String;)V", "GetOnStart_Ljava_lang_String_Handler")]
		public virtual unsafe void OnStart (string mac)
		{
			const string __id = "onStart.(Ljava/lang/String;)V";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

	}
}
