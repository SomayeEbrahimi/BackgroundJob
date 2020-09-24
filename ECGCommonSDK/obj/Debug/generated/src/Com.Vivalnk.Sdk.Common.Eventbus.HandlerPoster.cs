using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='HandlerPoster']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/HandlerPoster", DoNotGenerateAcw=true)]
	public partial class HandlerPoster : global::Android.OS.Handler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/HandlerPoster", typeof (HandlerPoster));
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

		protected HandlerPoster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='HandlerPoster']/constructor[@name='HandlerPoster' and count(parameter)=3 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.EventBus'] and parameter[2][@type='android.os.Looper'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Landroid/os/Looper;I)V", "")]
		protected unsafe HandlerPoster (global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus eventBus, global::Android.OS.Looper looper, int maxMillisInsideHandleMessage)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/common/eventbus/EventBus;Landroid/os/Looper;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((eventBus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventBus).Handle);
				__args [1] = new JniArgumentValue ((looper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) looper).Handle);
				__args [2] = new JniArgumentValue (maxMillisInsideHandleMessage);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
