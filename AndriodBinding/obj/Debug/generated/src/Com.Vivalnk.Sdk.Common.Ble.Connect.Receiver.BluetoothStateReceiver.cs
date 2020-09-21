using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Receiver {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/receiver/BluetoothStateReceiver", DoNotGenerateAcw=true)]
	public partial class BluetoothStateReceiver : global::Android.Content.BroadcastReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "BluetoothStateReceiver";

		static IntPtr delegate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/field[@name='delegate']"
		[Register ("delegate")]
		public global::Android.Content.BroadcastReceiver Delegate {
			get {
				if (delegate_jfieldId == IntPtr.Zero)
					delegate_jfieldId = JNIEnv.GetFieldID (class_ref, "delegate", "Landroid/content/BroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, delegate_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (delegate_jfieldId == IntPtr.Zero)
					delegate_jfieldId = JNIEnv.GetFieldID (class_ref, "delegate", "Landroid/content/BroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, delegate_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/receiver/BluetoothStateReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BluetoothStateReceiver); }
		}

		protected BluetoothStateReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/constructor[@name='BluetoothStateReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BluetoothStateReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BluetoothStateReceiver)) {
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

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (intent);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
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

		static IntPtr id_regist_Landroid_content_BroadcastReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/method[@name='regist' and count(parameter)=1 and parameter[1][@type='android.content.BroadcastReceiver']]"
		[Register ("regist", "(Landroid/content/BroadcastReceiver;)V", "GetRegist_Landroid_content_BroadcastReceiver_Handler")]
		public virtual unsafe void Regist (global::Android.Content.BroadcastReceiver @delegate)
		{
			if (id_regist_Landroid_content_BroadcastReceiver_ == IntPtr.Zero)
				id_regist_Landroid_content_BroadcastReceiver_ = JNIEnv.GetMethodID (class_ref, "regist", "(Landroid/content/BroadcastReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@delegate);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_regist_Landroid_content_BroadcastReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "regist", "(Landroid/content/BroadcastReceiver;)V"), __args);
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

		static IntPtr id_unregist;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.receiver']/class[@name='BluetoothStateReceiver']/method[@name='unregist' and count(parameter)=0]"
		[Register ("unregist", "()V", "GetUnregistHandler")]
		public virtual unsafe void Unregist ()
		{
			if (id_unregist == IntPtr.Zero)
				id_unregist = JNIEnv.GetMethodID (class_ref, "unregist", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregist);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregist", "()V"));
			} finally {
			}
		}

	}
}
