using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Excutors {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/excutors/LooperPool", DoNotGenerateAcw=true)]
	public partial class LooperPool : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/excutors/LooperPool", typeof (LooperPool));
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

		protected LooperPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Android.OS.Handler MainHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='getMainHandler' and count(parameter)=0]"
			[Register ("getMainHandler", "()Landroid/os/Handler;", "")]
			get {
				const string __id = "getMainHandler.()Landroid/os/Handler;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Android.OS.Looper MainLooper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='getMainLooper' and count(parameter)=0]"
			[Register ("getMainLooper", "()Landroid/os/Looper;", "")]
			get {
				const string __id = "getMainLooper.()Landroid/os/Looper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='createHandler' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.excutors.LooperType']]"
		[Register ("createHandler", "(Lcom/vivalnk/sdk/common/excutors/LooperType;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler CreateHandler (global::Com.Vivalnk.Sdk.Common.Excutors.LooperType type)
		{
			const string __id = "createHandler.(Lcom/vivalnk/sdk/common/excutors/LooperType;)Landroid/os/Handler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='createHandler' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.excutors.LooperType'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("createHandler", "(Lcom/vivalnk/sdk/common/excutors/LooperType;Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler CreateHandler (global::Com.Vivalnk.Sdk.Common.Excutors.LooperType type, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "createHandler.(Lcom/vivalnk/sdk/common/excutors/LooperType;Landroid/os/Handler$Callback;)Landroid/os/Handler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='getLooper' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.excutors.LooperType']]"
		[Register ("getLooper", "(Lcom/vivalnk/sdk/common/excutors/LooperType;)Landroid/os/Looper;", "")]
		public static unsafe global::Android.OS.Looper GetLooper (global::Com.Vivalnk.Sdk.Common.Excutors.LooperType type)
		{
			const string __id = "getLooper.(Lcom/vivalnk/sdk/common/excutors/LooperType;)Landroid/os/Looper;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperPool']/method[@name='getMainHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler.Callback']]"
		[Register ("getMainHandler", "(Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler GetMainHandler (global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "getMainHandler.(Landroid/os/Handler$Callback;)Landroid/os/Handler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
