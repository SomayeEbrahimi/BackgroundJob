using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/ConnectEventPoster", DoNotGenerateAcw=true)]
	public partial class ConnectEventPoster : global::Com.Vivalnk.Sdk.Common.Ble.Poster.AbsPoster, global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectMaster.IBluetoothConnectListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/ConnectEventPoster", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectEventPoster); }
		}

		protected ConnectEventPoster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/constructor[@name='ConnectEventPoster' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectEventPoster ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConnectEventPoster)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
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

		static IntPtr id_onConnected_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConnected", "(Ljava/lang/String;)V", "GetOnConnected_Ljava_lang_String_Handler")]
		public virtual unsafe void OnConnected (string mac)
		{
			if (id_onConnected_Ljava_lang_String_ == IntPtr.Zero)
				id_onConnected_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Ljava/lang/String;)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnected", "(Ljava/lang/String;)V"), __args);
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

		static IntPtr id_onDisconnected_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onDisconnected' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("onDisconnected", "(Ljava/lang/String;Z)V", "GetOnDisconnected_Ljava_lang_String_ZHandler")]
		public virtual unsafe void OnDisconnected (string mac, bool isForce)
		{
			if (id_onDisconnected_Ljava_lang_String_Z == IntPtr.Zero)
				id_onDisconnected_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onDisconnected", "(Ljava/lang/String;Z)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (isForce);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnected_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisconnected", "(Ljava/lang/String;Z)V"), __args);
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

		static IntPtr id_onError_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onError", "(Ljava/lang/String;ILjava/lang/String;)V", "GetOnError_Ljava_lang_String_ILjava_lang_String_Handler")]
		public virtual unsafe void OnError (string mac, int code, string msg)
		{
			if (id_onError_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_onError_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/String;ILjava/lang/String;)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (code);
				__args [2] = new JValue (native_msg);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_String_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Ljava/lang/String;ILjava/lang/String;)V"), __args);
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

		static IntPtr id_onRetryConnect_Ljava_lang_String_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onRetryConnect' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("onRetryConnect", "(Ljava/lang/String;IIJ)V", "GetOnRetryConnect_Ljava_lang_String_IIJHandler")]
		public virtual unsafe void OnRetryConnect (string mac, int totalRetryCount, int currentCount, long gapTime)
		{
			if (id_onRetryConnect_Ljava_lang_String_IIJ == IntPtr.Zero)
				id_onRetryConnect_Ljava_lang_String_IIJ = JNIEnv.GetMethodID (class_ref, "onRetryConnect", "(Ljava/lang/String;IIJ)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (totalRetryCount);
				__args [2] = new JValue (currentCount);
				__args [3] = new JValue (gapTime);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRetryConnect_Ljava_lang_String_IIJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRetryConnect", "(Ljava/lang/String;IIJ)V"), __args);
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

		static IntPtr id_onServiceReady_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onServiceReady' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onServiceReady", "(Ljava/lang/String;)V", "GetOnServiceReady_Ljava_lang_String_Handler")]
		public virtual unsafe void OnServiceReady (string mac)
		{
			if (id_onServiceReady_Ljava_lang_String_ == IntPtr.Zero)
				id_onServiceReady_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onServiceReady", "(Ljava/lang/String;)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onServiceReady_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onServiceReady", "(Ljava/lang/String;)V"), __args);
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

		static IntPtr id_onStart_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='ConnectEventPoster']/method[@name='onStart' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onStart", "(Ljava/lang/String;)V", "GetOnStart_Ljava_lang_String_Handler")]
		public virtual unsafe void OnStart (string mac)
		{
			if (id_onStart_Ljava_lang_String_ == IntPtr.Zero)
				id_onStart_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onStart", "(Ljava/lang/String;)V");
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mac);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStart_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

	}
}
