using System;
using System.Collections.Generic;
using Android.Runtime;

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

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/constructor[@name='BleConnectOptions.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;", "GetBuildHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions;")), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_setAutoConnect_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='setAutoConnect' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoConnect", "(Z)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;", "GetSetAutoConnect_ZHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder SetAutoConnect (bool autoConnect)
			{
				if (id_setAutoConnect_Z == IntPtr.Zero)
					id_setAutoConnect_Z = JNIEnv.GetMethodID (class_ref, "setAutoConnect", "(Z)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (autoConnect);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAutoConnect_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoConnect", "(Z)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_setConnectRetry_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='setConnectRetry' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectRetry", "(I)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;", "GetSetConnectRetry_IHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder SetConnectRetry (int retry)
			{
				if (id_setConnectRetry_I == IntPtr.Zero)
					id_setConnectRetry_I = JNIEnv.GetMethodID (class_ref, "setConnectRetry", "(I)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (retry);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setConnectRetry_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectRetry", "(I)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_setConnectTimeout_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='setConnectTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setConnectTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;", "GetSetConnectTimeout_JHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder SetConnectTimeout (long timeout)
			{
				if (id_setConnectTimeout_J == IntPtr.Zero)
					id_setConnectTimeout_J = JNIEnv.GetMethodID (class_ref, "setConnectTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (timeout);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setConnectTimeout_J, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_setServiceDiscoverRetry_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='setServiceDiscoverRetry' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setServiceDiscoverRetry", "(I)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;", "GetSetServiceDiscoverRetry_IHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder SetServiceDiscoverRetry (int retry)
			{
				if (id_setServiceDiscoverRetry_I == IntPtr.Zero)
					id_setServiceDiscoverRetry_I = JNIEnv.GetMethodID (class_ref, "setServiceDiscoverRetry", "(I)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (retry);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setServiceDiscoverRetry_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServiceDiscoverRetry", "(I)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_setServiceDiscoverTimeout_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions.Builder']/method[@name='setServiceDiscoverTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setServiceDiscoverTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;", "GetSetServiceDiscoverTimeout_JHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder SetServiceDiscoverTimeout (long timeout)
			{
				if (id_setServiceDiscoverTimeout_J == IntPtr.Zero)
					id_setServiceDiscoverTimeout_J = JNIEnv.GetMethodID (class_ref, "setServiceDiscoverTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (timeout);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setServiceDiscoverTimeout_J, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.BleConnectOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServiceDiscoverTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/BleConnectOptions$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/BleConnectOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleConnectOptions); }
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

		static IntPtr id_getConnectRetry;
		public virtual unsafe int ConnectRetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/method[@name='getConnectRetry' and count(parameter)=0]"
			[Register ("getConnectRetry", "()I", "GetGetConnectRetryHandler")]
			get {
				if (id_getConnectRetry == IntPtr.Zero)
					id_getConnectRetry = JNIEnv.GetMethodID (class_ref, "getConnectRetry", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConnectRetry);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectRetry", "()I"));
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

		static IntPtr id_getConnectTimeout;
		public virtual unsafe long ConnectTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/method[@name='getConnectTimeout' and count(parameter)=0]"
			[Register ("getConnectTimeout", "()J", "GetGetConnectTimeoutHandler")]
			get {
				if (id_getConnectTimeout == IntPtr.Zero)
					id_getConnectTimeout = JNIEnv.GetMethodID (class_ref, "getConnectTimeout", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getConnectTimeout);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectTimeout", "()J"));
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

		static IntPtr id_isAutoConnect;
		public virtual unsafe bool IsAutoConnect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/method[@name='isAutoConnect' and count(parameter)=0]"
			[Register ("isAutoConnect", "()Z", "GetIsAutoConnectHandler")]
			get {
				if (id_isAutoConnect == IntPtr.Zero)
					id_isAutoConnect = JNIEnv.GetMethodID (class_ref, "isAutoConnect", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAutoConnect);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAutoConnect", "()Z"));
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

		static IntPtr id_getServiceDiscoverRetry;
		public virtual unsafe int ServiceDiscoverRetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/method[@name='getServiceDiscoverRetry' and count(parameter)=0]"
			[Register ("getServiceDiscoverRetry", "()I", "GetGetServiceDiscoverRetryHandler")]
			get {
				if (id_getServiceDiscoverRetry == IntPtr.Zero)
					id_getServiceDiscoverRetry = JNIEnv.GetMethodID (class_ref, "getServiceDiscoverRetry", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getServiceDiscoverRetry);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceDiscoverRetry", "()I"));
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

		static IntPtr id_getServiceDiscoverTimeout;
		public virtual unsafe long ServiceDiscoverTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect']/class[@name='BleConnectOptions']/method[@name='getServiceDiscoverTimeout' and count(parameter)=0]"
			[Register ("getServiceDiscoverTimeout", "()J", "GetGetServiceDiscoverTimeoutHandler")]
			get {
				if (id_getServiceDiscoverTimeout == IntPtr.Zero)
					id_getServiceDiscoverTimeout = JNIEnv.GetMethodID (class_ref, "getServiceDiscoverTimeout", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getServiceDiscoverTimeout);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceDiscoverTimeout", "()J"));
				} finally {
				}
			}
		}

	}
}
