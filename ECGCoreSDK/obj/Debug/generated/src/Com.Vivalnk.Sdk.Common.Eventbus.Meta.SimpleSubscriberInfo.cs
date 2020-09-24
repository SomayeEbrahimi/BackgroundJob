using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Meta {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='SimpleSubscriberInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/meta/SimpleSubscriberInfo", DoNotGenerateAcw=true)]
	public partial class SimpleSubscriberInfo : global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.AbstractSubscriberInfo {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/meta/SimpleSubscriberInfo", typeof (SimpleSubscriberInfo));
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

		protected SimpleSubscriberInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='SimpleSubscriberInfo']/constructor[@name='SimpleSubscriberInfo' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='boolean'] and parameter[3][@type='com.vivalnk.sdk.common.eventbus.meta.SubscriberMethodInfo[]']]"
		[Register (".ctor", "(Ljava/lang/Class;Z[Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberMethodInfo;)V", "")]
		public unsafe SimpleSubscriberInfo (global::Java.Lang.Class subscriberClass, bool shouldCheckSuperclass, global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.SubscriberMethodInfo[] methodInfos)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;Z[Lcom/vivalnk/sdk/common/eventbus/meta/SubscriberMethodInfo;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_methodInfos = JNIEnv.NewArray (methodInfos);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((subscriberClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriberClass).Handle);
				__args [1] = new JniArgumentValue (shouldCheckSuperclass);
				__args [2] = new JniArgumentValue (native_methodInfos);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (methodInfos != null) {
					JNIEnv.CopyArray (native_methodInfos, methodInfos);
					JNIEnv.DeleteLocalRef (native_methodInfos);
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Meta.SimpleSubscriberInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSubscriberMethods ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.meta']/class[@name='SimpleSubscriberInfo']/method[@name='getSubscriberMethods' and count(parameter)=0]"
		[Register ("getSubscriberMethods", "()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;", "GetGetSubscriberMethodsHandler")]
		public override unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[] GetSubscriberMethods ()
		{
			const string __id = "getSubscriberMethods.()[Lcom/vivalnk/sdk/common/eventbus/SubscriberMethod;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Eventbus.SubscriberMethod));
			} finally {
			}
		}

	}
}
