using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='SubscriberMethod']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/SubscriberMethod", DoNotGenerateAcw=true)]
	public partial class SubscriberMethod : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/SubscriberMethod", typeof (SubscriberMethod));
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

		protected SubscriberMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='SubscriberMethod']/constructor[@name='SubscriberMethod' and count(parameter)=5 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.eventbus.ThreadMode'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/reflect/Method;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)V", "")]
		public unsafe SubscriberMethod (global::Java.Lang.Reflect.Method method, global::Java.Lang.Class eventType, global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode threadMode, int priority, bool sticky)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/reflect/Method;Ljava/lang/Class;Lcom/vivalnk/sdk/common/eventbus/ThreadMode;IZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
				__args [1] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				__args [2] = new JniArgumentValue ((threadMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) threadMode).Handle);
				__args [3] = new JniArgumentValue (priority);
				__args [4] = new JniArgumentValue (sticky);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
