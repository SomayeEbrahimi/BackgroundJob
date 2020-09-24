using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/BleConnectOptions", DoNotGenerateAcw=true)]
	public partial class BleConnectOptions : global::Java.Lang.Object, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/field[@name='CONNECT_RETRY_INFINITY']"
		[Register ("CONNECT_RETRY_INFINITY")]
		public const int ConnectRetryInfinity = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/field[@name='DEFAULT_CONNECT_RETRY']"
		[Register ("DEFAULT_CONNECT_RETRY")]
		public const int DefaultConnectRetry = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/field[@name='DEFAULT_CONNECT_TIMEOUT']"
		[Register ("DEFAULT_CONNECT_TIMEOUT")]
		public const long DefaultConnectTimeout = (long) 30000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/field[@name='DEFAULT_SERVICE_DISCOVER_RETRY']"
		[Register ("DEFAULT_SERVICE_DISCOVER_RETRY")]
		public const int DefaultServiceDiscoverRetry = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/field[@name='DEFAULT_SERVICE_DISCOVER_TIMEOUT']"
		[Register ("DEFAULT_SERVICE_DISCOVER_TIMEOUT")]
		public const long DefaultServiceDiscoverTimeout = (long) 30000;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/constructor[@name='BleConnectOptions.Builder' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;", "GetBuildHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions Build ()
			{
				const string __id = "build.()Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAutoConnect_Z;
#pragma warning disable 0169
			static Delegate GetSetAutoConnect_ZHandler ()
			{
				if (cb_setAutoConnect_Z == null)
					cb_setAutoConnect_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAutoConnect_Z);
				return cb_setAutoConnect_Z;
			}

			static IntPtr n_SetAutoConnect_Z (IntPtr jnienv, IntPtr native__this, bool autoConnect)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetAutoConnect (autoConnect));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='setAutoConnect' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoConnect", "(Z)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;", "GetSetAutoConnect_ZHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder SetAutoConnect (bool autoConnect)
			{
				const string __id = "setAutoConnect.(Z)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (autoConnect);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setConnectRetry_I;
#pragma warning disable 0169
			static Delegate GetSetConnectRetry_IHandler ()
			{
				if (cb_setConnectRetry_I == null)
					cb_setConnectRetry_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetConnectRetry_I);
				return cb_setConnectRetry_I;
			}

			static IntPtr n_SetConnectRetry_I (IntPtr jnienv, IntPtr native__this, int retry)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetConnectRetry (retry));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='setConnectRetry' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectRetry", "(I)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;", "GetSetConnectRetry_IHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder SetConnectRetry (int retry)
			{
				const string __id = "setConnectRetry.(I)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (retry);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setConnectTimeout_J;
#pragma warning disable 0169
			static Delegate GetSetConnectTimeout_JHandler ()
			{
				if (cb_setConnectTimeout_J == null)
					cb_setConnectTimeout_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SetConnectTimeout_J);
				return cb_setConnectTimeout_J;
			}

			static IntPtr n_SetConnectTimeout_J (IntPtr jnienv, IntPtr native__this, long timeout)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetConnectTimeout (timeout));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='setConnectTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setConnectTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;", "GetSetConnectTimeout_JHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder SetConnectTimeout (long timeout)
			{
				const string __id = "setConnectTimeout.(J)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (timeout);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setServiceDiscoverRetry_I;
#pragma warning disable 0169
			static Delegate GetSetServiceDiscoverRetry_IHandler ()
			{
				if (cb_setServiceDiscoverRetry_I == null)
					cb_setServiceDiscoverRetry_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetServiceDiscoverRetry_I);
				return cb_setServiceDiscoverRetry_I;
			}

			static IntPtr n_SetServiceDiscoverRetry_I (IntPtr jnienv, IntPtr native__this, int retry)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetServiceDiscoverRetry (retry));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='setServiceDiscoverRetry' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setServiceDiscoverRetry", "(I)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;", "GetSetServiceDiscoverRetry_IHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder SetServiceDiscoverRetry (int retry)
			{
				const string __id = "setServiceDiscoverRetry.(I)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (retry);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setServiceDiscoverTimeout_J;
#pragma warning disable 0169
			static Delegate GetSetServiceDiscoverTimeout_JHandler ()
			{
				if (cb_setServiceDiscoverTimeout_J == null)
					cb_setServiceDiscoverTimeout_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SetServiceDiscoverTimeout_J);
				return cb_setServiceDiscoverTimeout_J;
			}

			static IntPtr n_SetServiceDiscoverTimeout_J (IntPtr jnienv, IntPtr native__this, long timeout)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetServiceDiscoverTimeout (timeout));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='setServiceDiscoverTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setServiceDiscoverTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;", "GetSetServiceDiscoverTimeout_JHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder SetServiceDiscoverTimeout (long timeout)
			{
				const string __id = "setServiceDiscoverTimeout.(J)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (timeout);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/connect/BleConnectOptions", typeof (BleConnectOptions));
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

		protected BleConnectOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getConnectRetry;
#pragma warning disable 0169
		static Delegate GetGetConnectRetryHandler ()
		{
			if (cb_getConnectRetry == null)
				cb_getConnectRetry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetConnectRetry);
			return cb_getConnectRetry;
		}

		static int n_GetConnectRetry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectRetry;
		}
#pragma warning restore 0169

		public virtual unsafe int ConnectRetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/method[@name='getConnectRetry' and count(parameter)=0]"
			[Register ("getConnectRetry", "()I", "GetGetConnectRetryHandler")]
			get {
				const string __id = "getConnectRetry.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getConnectTimeout;
#pragma warning disable 0169
		static Delegate GetGetConnectTimeoutHandler ()
		{
			if (cb_getConnectTimeout == null)
				cb_getConnectTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetConnectTimeout);
			return cb_getConnectTimeout;
		}

		static long n_GetConnectTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectTimeout;
		}
#pragma warning restore 0169

		public virtual unsafe long ConnectTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/method[@name='getConnectTimeout' and count(parameter)=0]"
			[Register ("getConnectTimeout", "()J", "GetGetConnectTimeoutHandler")]
			get {
				const string __id = "getConnectTimeout.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAutoConnect;
#pragma warning disable 0169
		static Delegate GetIsAutoConnectHandler ()
		{
			if (cb_isAutoConnect == null)
				cb_isAutoConnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAutoConnect);
			return cb_isAutoConnect;
		}

		static bool n_IsAutoConnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutoConnect;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAutoConnect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/method[@name='isAutoConnect' and count(parameter)=0]"
			[Register ("isAutoConnect", "()Z", "GetIsAutoConnectHandler")]
			get {
				const string __id = "isAutoConnect.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getServiceDiscoverRetry;
#pragma warning disable 0169
		static Delegate GetGetServiceDiscoverRetryHandler ()
		{
			if (cb_getServiceDiscoverRetry == null)
				cb_getServiceDiscoverRetry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetServiceDiscoverRetry);
			return cb_getServiceDiscoverRetry;
		}

		static int n_GetServiceDiscoverRetry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ServiceDiscoverRetry;
		}
#pragma warning restore 0169

		public virtual unsafe int ServiceDiscoverRetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/method[@name='getServiceDiscoverRetry' and count(parameter)=0]"
			[Register ("getServiceDiscoverRetry", "()I", "GetGetServiceDiscoverRetryHandler")]
			get {
				const string __id = "getServiceDiscoverRetry.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getServiceDiscoverTimeout;
#pragma warning disable 0169
		static Delegate GetGetServiceDiscoverTimeoutHandler ()
		{
			if (cb_getServiceDiscoverTimeout == null)
				cb_getServiceDiscoverTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetServiceDiscoverTimeout);
			return cb_getServiceDiscoverTimeout;
		}

		static long n_GetServiceDiscoverTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ServiceDiscoverTimeout;
		}
#pragma warning restore 0169

		public virtual unsafe long ServiceDiscoverTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/method[@name='getServiceDiscoverTimeout' and count(parameter)=0]"
			[Register ("getServiceDiscoverTimeout", "()J", "GetGetServiceDiscoverTimeoutHandler")]
			get {
				const string __id = "getServiceDiscoverTimeout.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
