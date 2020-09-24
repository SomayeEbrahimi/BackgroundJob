using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Receiver {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/receiver/BluetoothStateReceiver", DoNotGenerateAcw=true)]
	public partial class BluetoothStateReceiver : global::Android.Content.BroadcastReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "BluetoothStateReceiver";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/field[@name='delegate']"
		[Register ("delegate")]
		public global::Android.Content.BroadcastReceiver Delegate {
			get {
				const string __id = "delegate.Landroid/content/BroadcastReceiver;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "delegate.Landroid/content/BroadcastReceiver;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/receiver/BluetoothStateReceiver", typeof (BluetoothStateReceiver));
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

		protected BluetoothStateReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/constructor[@name='BluetoothStateReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BluetoothStateReceiver ()
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

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Receiver.BluetoothStateReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (context, intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			const string __id = "onReceive.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_regist_Landroid_content_BroadcastReceiver_;
#pragma warning disable 0169
		static Delegate GetRegist_Landroid_content_BroadcastReceiver_Handler ()
		{
			if (cb_regist_Landroid_content_BroadcastReceiver_ == null)
				cb_regist_Landroid_content_BroadcastReceiver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Regist_Landroid_content_BroadcastReceiver_);
			return cb_regist_Landroid_content_BroadcastReceiver_;
		}

		static void n_Regist_Landroid_content_BroadcastReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native__delegate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Receiver.BluetoothStateReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @delegate = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native__delegate, JniHandleOwnership.DoNotTransfer);
			__this.Regist (@delegate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/method[@name='regist' and count(parameter)=1 and parameter[1][@type='android.content.BroadcastReceiver']]"
		[Register ("regist", "(Landroid/content/BroadcastReceiver;)V", "GetRegist_Landroid_content_BroadcastReceiver_Handler")]
		public virtual unsafe void Regist (global::Android.Content.BroadcastReceiver @delegate)
		{
			const string __id = "regist.(Landroid/content/BroadcastReceiver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@delegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @delegate).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregist;
#pragma warning disable 0169
		static Delegate GetUnregistHandler ()
		{
			if (cb_unregist == null)
				cb_unregist = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Unregist);
			return cb_unregist;
		}

		static void n_Unregist (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Receiver.BluetoothStateReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unregist ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/method[@name='unregist' and count(parameter)=0]"
		[Register ("unregist", "()V", "GetUnregistHandler")]
		public virtual unsafe void Unregist ()
		{
			const string __id = "unregist.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
