using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/base/IORequestOptions", DoNotGenerateAcw=true)]
	public partial class IORequestOptions : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions.Builder']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions.Builder']/field[@name='DEFAULT_TIME_OUT']"
			[Register ("DEFAULT_TIME_OUT")]
			public const long DefaultTimeOut = (long) 30000;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions.Builder']/constructor[@name='IORequestOptions.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;", "GetBuildHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions Build ()
			{
				const string __id = "build.()Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setLoggable_Z;
#pragma warning disable 0169
			static Delegate GetSetLoggable_ZHandler ()
			{
				if (cb_setLoggable_Z == null)
					cb_setLoggable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetLoggable_Z);
				return cb_setLoggable_Z;
			}

			static IntPtr n_SetLoggable_Z (IntPtr jnienv, IntPtr native__this, bool loggable)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetLoggable (loggable));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions.Builder']/method[@name='setLoggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLoggable", "(Z)Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder;", "GetSetLoggable_ZHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder SetLoggable (bool loggable)
			{
				const string __id = "setLoggable.(Z)Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (loggable);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setTimeout_J;
#pragma warning disable 0169
			static Delegate GetSetTimeout_JHandler ()
			{
				if (cb_setTimeout_J == null)
					cb_setTimeout_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SetTimeout_J);
				return cb_setTimeout_J;
			}

			static IntPtr n_SetTimeout_J (IntPtr jnienv, IntPtr native__this, long timeout)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetTimeout (timeout));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions.Builder']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder;", "GetSetTimeout_JHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder SetTimeout (long timeout)
			{
				const string __id = "setTimeout.(J)Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (timeout);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/base/IORequestOptions", typeof (IORequestOptions));
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

		protected IORequestOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isLoggable;
#pragma warning disable 0169
		static Delegate GetIsLoggableHandler ()
		{
			if (cb_isLoggable == null)
				cb_isLoggable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLoggable);
			return cb_isLoggable;
		}

		static bool n_IsLoggable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoggable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLoggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions']/method[@name='isLoggable' and count(parameter)=0]"
			[Register ("isLoggable", "()Z", "GetIsLoggableHandler")]
			get {
				const string __id = "isLoggable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRequestTimeout;
#pragma warning disable 0169
		static Delegate GetGetRequestTimeoutHandler ()
		{
			if (cb_getRequestTimeout == null)
				cb_getRequestTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetRequestTimeout);
			return cb_getRequestTimeout;
		}

		static long n_GetRequestTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestTimeout;
		}
#pragma warning restore 0169

		public virtual unsafe long RequestTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions']/method[@name='getRequestTimeout' and count(parameter)=0]"
			[Register ("getRequestTimeout", "()J", "GetGetRequestTimeoutHandler")]
			get {
				const string __id = "getRequestTimeout.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
