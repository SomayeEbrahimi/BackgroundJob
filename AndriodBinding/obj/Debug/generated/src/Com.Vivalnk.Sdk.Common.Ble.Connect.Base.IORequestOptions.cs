using System;
using System.Collections.Generic;
using Android.Runtime;

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
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions.Builder']/constructor[@name='IORequestOptions.Builder' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;", "GetBuildHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions;")), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_setLoggable_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions.Builder']/method[@name='setLoggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLoggable", "(Z)Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder;", "GetSetLoggable_ZHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder SetLoggable (bool loggable)
			{
				if (id_setLoggable_Z == IntPtr.Zero)
					id_setLoggable_Z = JNIEnv.GetMethodID (class_ref, "setLoggable", "(Z)Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (loggable);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLoggable_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoggable", "(Z)Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_setTimeout_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions.Builder']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder;", "GetSetTimeout_JHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder SetTimeout (long timeout)
			{
				if (id_setTimeout_J == IntPtr.Zero)
					id_setTimeout_J = JNIEnv.GetMethodID (class_ref, "setTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (timeout);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTimeout_J, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Connect.Base.IORequestOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(J)Lcom/vivalnk/sdk/common/ble/connect/base/IORequestOptions$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/base/IORequestOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IORequestOptions); }
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

		static IntPtr id_isLoggable;
		public virtual unsafe bool IsLoggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions']/method[@name='isLoggable' and count(parameter)=0]"
			[Register ("isLoggable", "()Z", "GetIsLoggableHandler")]
			get {
				if (id_isLoggable == IntPtr.Zero)
					id_isLoggable = JNIEnv.GetMethodID (class_ref, "isLoggable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoggable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLoggable", "()Z"));
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

		static IntPtr id_getRequestTimeout;
		public virtual unsafe long RequestTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.base']/class[@name='IORequestOptions']/method[@name='getRequestTimeout' and count(parameter)=0]"
			[Register ("getRequestTimeout", "()J", "GetGetRequestTimeoutHandler")]
			get {
				if (id_getRequestTimeout == IntPtr.Zero)
					id_getRequestTimeout = JNIEnv.GetMethodID (class_ref, "getRequestTimeout", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRequestTimeout);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestTimeout", "()J"));
				} finally {
				}
			}
		}

	}
}
