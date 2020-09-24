using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.listener']/interface[@name='BluetoothStateListener']"
	[Register ("com/vivalnk/sdk/common/ble/listener/BluetoothStateListener", "", "Com.Vivalnk.Sdk.Common.Ble.Listener.IBluetoothStateListenerInvoker")]
	public partial interface IBluetoothStateListener : global::Com.Vivalnk.Sdk.Common.Ble.Listener.IBleListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.listener']/interface[@name='BluetoothStateListener']/method[@name='onBlutoothClose' and count(parameter)=0]"
		[Register ("onBlutoothClose", "()V", "GetOnBlutoothCloseHandler:Com.Vivalnk.Sdk.Common.Ble.Listener.IBluetoothStateListenerInvoker, ECGCommonSDK")]
		void OnBlutoothClose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.listener']/interface[@name='BluetoothStateListener']/method[@name='onBlutoothOpen' and count(parameter)=0]"
		[Register ("onBlutoothOpen", "()V", "GetOnBlutoothOpenHandler:Com.Vivalnk.Sdk.Common.Ble.Listener.IBluetoothStateListenerInvoker, ECGCommonSDK")]
		void OnBlutoothOpen ();

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/listener/BluetoothStateListener", DoNotGenerateAcw=true)]
	internal partial class IBluetoothStateListenerInvoker : global::Java.Lang.Object, IBluetoothStateListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/listener/BluetoothStateListener", typeof (IBluetoothStateListenerInvoker));

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

		public static IBluetoothStateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBluetoothStateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.listener.BluetoothStateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBluetoothStateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBlutoothClose;
#pragma warning disable 0169
		static Delegate GetOnBlutoothCloseHandler ()
		{
			if (cb_onBlutoothClose == null)
				cb_onBlutoothClose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBlutoothClose);
			return cb_onBlutoothClose;
		}

		static void n_OnBlutoothClose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Listener.IBluetoothStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBlutoothClose ();
		}
#pragma warning restore 0169

		IntPtr id_onBlutoothClose;
		public unsafe void OnBlutoothClose ()
		{
			if (id_onBlutoothClose == IntPtr.Zero)
				id_onBlutoothClose = JNIEnv.GetMethodID (class_ref, "onBlutoothClose", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBlutoothClose);
		}

		static Delegate cb_onBlutoothOpen;
#pragma warning disable 0169
		static Delegate GetOnBlutoothOpenHandler ()
		{
			if (cb_onBlutoothOpen == null)
				cb_onBlutoothOpen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBlutoothOpen);
			return cb_onBlutoothOpen;
		}

		static void n_OnBlutoothOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Listener.IBluetoothStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBlutoothOpen ();
		}
#pragma warning restore 0169

		IntPtr id_onBlutoothOpen;
		public unsafe void OnBlutoothOpen ()
		{
			if (id_onBlutoothOpen == IntPtr.Zero)
				id_onBlutoothOpen = JNIEnv.GetMethodID (class_ref, "onBlutoothOpen", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBlutoothOpen);
		}

	}

}
