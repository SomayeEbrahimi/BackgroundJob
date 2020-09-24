using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Meta {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/interface[@name='SubscriberInfoIndex']"
	[Register ("com/vivalnk/sdk/common/eventbus/meta/SubscriberInfoIndex", "", "Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoIndexInvoker")]
	public partial interface ISubscriberInfoIndex : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/interface[@name='SubscriberInfoIndex']/method[@name='getSubscriberInfo' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getSubscriberInfo", "(Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfo;", "GetGetSubscriberInfo_Ljava_lang_Class_Handler:Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoIndexInvoker, ECGCommonSDK")]
		global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo GetSubscriberInfo (global::Java.Lang.Class p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/meta/SubscriberInfoIndex", DoNotGenerateAcw=true)]
	internal partial class ISubscriberInfoIndexInvoker : global::Java.Lang.Object, ISubscriberInfoIndex {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/meta/SubscriberInfoIndex", typeof (ISubscriberInfoIndexInvoker));

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

		public static ISubscriberInfoIndex GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubscriberInfoIndex> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.eventbus.meta.SubscriberInfoIndex"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubscriberInfoIndexInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSubscriberInfo_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetSubscriberInfo_Ljava_lang_Class_Handler ()
		{
			if (cb_getSubscriberInfo_Ljava_lang_Class_ == null)
				cb_getSubscriberInfo_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetSubscriberInfo_Ljava_lang_Class_);
			return cb_getSubscriberInfo_Ljava_lang_Class_;
		}

		static IntPtr n_GetSubscriberInfo_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSubscriberInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSubscriberInfo_Ljava_lang_Class_;
		public unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo GetSubscriberInfo (global::Java.Lang.Class p0)
		{
			if (id_getSubscriberInfo_Ljava_lang_Class_ == IntPtr.Zero)
				id_getSubscriberInfo_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getSubscriberInfo", "(Ljava/lang/Class;)Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfo;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriberInfo_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
