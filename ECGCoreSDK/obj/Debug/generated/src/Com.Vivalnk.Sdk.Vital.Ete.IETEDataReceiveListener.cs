using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Vital.Ete {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETEDataReceiveListener']"
	[Register ("com/vivalnk/sdk/vital/ete/ETEDataReceiveListener", "", "Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListenerInvoker")]
	public partial interface IETEDataReceiveListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/interface[@name='ETEDataReceiveListener']/method[@name='onETEResultUpdated' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.vital.ete.ETEResult']]"
		[Register ("onETEResultUpdated", "(Lcom/vivalnk/sdk/vital/ete/ETEResult;)V", "GetOnETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_Handler:Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListenerInvoker, ECGCoreSDK")]
		void OnETEResultUpdated (global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/vital/ete/ETEDataReceiveListener", DoNotGenerateAcw=true)]
	internal partial class IETEDataReceiveListenerInvoker : global::Java.Lang.Object, IETEDataReceiveListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/vital/ete/ETEDataReceiveListener", typeof (IETEDataReceiveListenerInvoker));

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

		public static IETEDataReceiveListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IETEDataReceiveListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.vital.ete.ETEDataReceiveListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IETEDataReceiveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_;
#pragma warning disable 0169
		static Delegate GetOnETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_Handler ()
		{
			if (cb_onETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_ == null)
				cb_onETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_);
			return cb_onETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_;
		}

		static void n_OnETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnETEResultUpdated (p0);
		}
#pragma warning restore 0169

		IntPtr id_onETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_;
		public unsafe void OnETEResultUpdated (global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult p0)
		{
			if (id_onETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_ == IntPtr.Zero)
				id_onETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_ = JNIEnv.GetMethodID (class_ref, "onETEResultUpdated", "(Lcom/vivalnk/sdk/vital/ete/ETEResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onETEResultUpdated_Lcom_vivalnk_sdk_vital_ete_ETEResult_, __args);
		}

	}

	// event args for com.vivalnk.sdk.vital.ete.ETEDataReceiveListener.onETEResultUpdated
	public partial class ETEDataReceiveEventArgs : global::System.EventArgs {

		public ETEDataReceiveEventArgs (global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult p0;
		public global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/vivalnk/sdk/vital/ete/ETEDataReceiveListenerImplementor")]
	internal sealed partial class IETEDataReceiveListenerImplementor : global::Java.Lang.Object, IETEDataReceiveListener {

		object sender;

		public IETEDataReceiveListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vivalnk/sdk/vital/ete/ETEDataReceiveListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ETEDataReceiveEventArgs> Handler;
#pragma warning restore 0649

		public void OnETEResultUpdated (global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ETEDataReceiveEventArgs (p0));
		}

		internal static bool __IsEmpty (IETEDataReceiveListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
