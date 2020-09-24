using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='DeviceUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/DeviceUtils", DoNotGenerateAcw=true)]
	public partial class DeviceUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/utils/DeviceUtils", typeof (DeviceUtils));
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

		protected DeviceUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='DeviceUtils']/constructor[@name='DeviceUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeviceUtils ()
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

		static Delegate cb_collectDeviceInfo_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCollectDeviceInfo_Landroid_content_Context_Handler ()
		{
			if (cb_collectDeviceInfo_Landroid_content_Context_ == null)
				cb_collectDeviceInfo_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CollectDeviceInfo_Landroid_content_Context_);
			return cb_collectDeviceInfo_Landroid_content_Context_;
		}

		static IntPtr n_CollectDeviceInfo_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.DeviceUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CollectDeviceInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='DeviceUtils']/method[@name='collectDeviceInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("collectDeviceInfo", "(Landroid/content/Context;)Ljava/util/Map;", "GetCollectDeviceInfo_Landroid_content_Context_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CollectDeviceInfo (global::Android.Content.Context p0)
		{
			const string __id = "collectDeviceInfo.(Landroid/content/Context;)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
