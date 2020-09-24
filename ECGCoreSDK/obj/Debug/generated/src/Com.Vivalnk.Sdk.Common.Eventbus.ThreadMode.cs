using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/ThreadMode", DoNotGenerateAcw=true)]
	public sealed partial class ThreadMode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/field[@name='ASYNC']"
		[Register ("ASYNC")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode Async {
			get {
				const string __id = "ASYNC.Lcom/vivalnk/sdk/common/eventbus/ThreadMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/field[@name='BACKGROUND']"
		[Register ("BACKGROUND")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode Background {
			get {
				const string __id = "BACKGROUND.Lcom/vivalnk/sdk/common/eventbus/ThreadMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/field[@name='MAIN']"
		[Register ("MAIN")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode Main {
			get {
				const string __id = "MAIN.Lcom/vivalnk/sdk/common/eventbus/ThreadMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/field[@name='MAIN_ORDERED']"
		[Register ("MAIN_ORDERED")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode MainOrdered {
			get {
				const string __id = "MAIN_ORDERED.Lcom/vivalnk/sdk/common/eventbus/ThreadMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/field[@name='POSTING']"
		[Register ("POSTING")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode Posting {
			get {
				const string __id = "POSTING.Lcom/vivalnk/sdk/common/eventbus/ThreadMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/ThreadMode", typeof (ThreadMode));
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

		internal ThreadMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/common/eventbus/ThreadMode;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/sdk/common/eventbus/ThreadMode;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='ThreadMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vivalnk/sdk/common/eventbus/ThreadMode;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode[] Values ()
		{
			const string __id = "values.()[Lcom/vivalnk/sdk/common/eventbus/ThreadMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode));
			} finally {
			}
		}

	}
}
