using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Meta {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/interface[@name='SubscriberInfo']"
	[Register ("com/vivalnk/sdk/common/eventbus/meta/SubscriberInfo", "", "Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoInvoker")]
	public partial interface ISubscriberInfo : IJavaObject, IJavaPeerable {

		global::Java.Lang.Class SubscriberClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/interface[@name='SubscriberInfo']/method[@name='getSubscriberClass' and count(parameter)=0]"
			[Register ("getSubscriberClass", "()Ljava/lang/Class;", "GetGetSubscriberClassHandler:Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoInvoker, ECGCommonSDK")] get;
		}

		global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo SuperSubscriberInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/interface[@name='SubscriberInfo']/method[@name='getSuperSubscriberInfo' and count(parameter)=0]"
			[Register ("getSuperSubscriberInfo", "()Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfo;", "GetGetSuperSubscriberInfoHandler:Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoInvoker, ECGCommonSDK")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/interface[@name='SubscriberInfo']/method[@name='getSubscriberMethods' and count(parameter)=0]"
		[Register ("getSubscriberMethods", "()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetGetSubscriberMethodsHandler:Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoInvoker, ECGCommonSDK")]
		global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[] GetSubscriberMethods ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/interface[@name='SubscriberInfo']/method[@name='shouldCheckSuperclass' and count(parameter)=0]"
		[Register ("shouldCheckSuperclass", "()Z", "GetShouldCheckSuperclassHandler:Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfoInvoker, ECGCommonSDK")]
		bool ShouldCheckSuperclass ();

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/meta/SubscriberInfo", DoNotGenerateAcw=true)]
	internal partial class ISubscriberInfoInvoker : global::Java.Lang.Object, ISubscriberInfo {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/meta/SubscriberInfo", typeof (ISubscriberInfoInvoker));

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

		public static ISubscriberInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubscriberInfo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.eventbus.meta.SubscriberInfo"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubscriberInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSubscriberClass;
#pragma warning disable 0169
		static Delegate GetGetSubscriberClassHandler ()
		{
			if (cb_getSubscriberClass == null)
				cb_getSubscriberClass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubscriberClass);
			return cb_getSubscriberClass;
		}

		static IntPtr n_GetSubscriberClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscriberClass);
		}
#pragma warning restore 0169

		IntPtr id_getSubscriberClass;
		public unsafe global::Java.Lang.Class SubscriberClass {
			get {
				if (id_getSubscriberClass == IntPtr.Zero)
					id_getSubscriberClass = JNIEnv.GetMethodID (class_ref, "getSubscriberClass", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriberClass), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSuperSubscriberInfo;
#pragma warning disable 0169
		static Delegate GetGetSuperSubscriberInfoHandler ()
		{
			if (cb_getSuperSubscriberInfo == null)
				cb_getSuperSubscriberInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSuperSubscriberInfo);
			return cb_getSuperSubscriberInfo;
		}

		static IntPtr n_GetSuperSubscriberInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SuperSubscriberInfo);
		}
#pragma warning restore 0169

		IntPtr id_getSuperSubscriberInfo;
		public unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo SuperSubscriberInfo {
			get {
				if (id_getSuperSubscriberInfo == IntPtr.Zero)
					id_getSuperSubscriberInfo = JNIEnv.GetMethodID (class_ref, "getSuperSubscriberInfo", "()Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberInfo;");
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSuperSubscriberInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSubscriberMethods;
#pragma warning disable 0169
		static Delegate GetGetSubscriberMethodsHandler ()
		{
			if (cb_getSubscriberMethods == null)
				cb_getSubscriberMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubscriberMethods);
			return cb_getSubscriberMethods;
		}

		static IntPtr n_GetSubscriberMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSubscriberMethods ());
		}
#pragma warning restore 0169

		IntPtr id_getSubscriberMethods;
		public unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[] GetSubscriberMethods ()
		{
			if (id_getSubscriberMethods == IntPtr.Zero)
				id_getSubscriberMethods = JNIEnv.GetMethodID (class_ref, "getSubscriberMethods", "()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;");
			return (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriberMethods), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod));
		}

		static Delegate cb_shouldCheckSuperclass;
#pragma warning disable 0169
		static Delegate GetShouldCheckSuperclassHandler ()
		{
			if (cb_shouldCheckSuperclass == null)
				cb_shouldCheckSuperclass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ShouldCheckSuperclass);
			return cb_shouldCheckSuperclass;
		}

		static bool n_ShouldCheckSuperclass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.ISubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldCheckSuperclass ();
		}
#pragma warning restore 0169

		IntPtr id_shouldCheckSuperclass;
		public unsafe bool ShouldCheckSuperclass ()
		{
			if (id_shouldCheckSuperclass == IntPtr.Zero)
				id_shouldCheckSuperclass = JNIEnv.GetMethodID (class_ref, "shouldCheckSuperclass", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldCheckSuperclass);
		}

	}

}
