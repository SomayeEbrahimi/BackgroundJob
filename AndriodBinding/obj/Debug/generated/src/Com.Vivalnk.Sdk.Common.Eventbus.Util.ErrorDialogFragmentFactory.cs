using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogFragmentFactory", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class ErrorDialogFragmentFactory : global::Java.Lang.Object {


		static IntPtr config_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory']/field[@name='config']"
		[Register ("config")]
		protected global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig Config {
			get {
				if (config_jfieldId == IntPtr.Zero)
					config_jfieldId = JNIEnv.GetFieldID (class_ref, "config", "Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, config_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (config_jfieldId == IntPtr.Zero)
					config_jfieldId = JNIEnv.GetFieldID (class_ref, "config", "Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, config_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory.Honeycomb']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogFragmentFactory$Honeycomb", DoNotGenerateAcw=true)]
		public partial class Honeycomb : global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogFragmentFactory {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogFragmentFactory$Honeycomb", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Honeycomb); }
			}

			protected Honeycomb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_vivalnk_sdk_common_eventbus_util_ErrorDialogConfig_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory.Honeycomb']/constructor[@name='ErrorDialogFragmentFactory.Honeycomb' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.ErrorDialogConfig']]"
			[Register (".ctor", "(Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;)V", "")]
			public unsafe Honeycomb (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig config)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (config);
					if (((object) this).GetType () != typeof (Honeycomb)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;)V", __args);
						return;
					}

					if (id_ctor_Lcom_vivalnk_sdk_common_eventbus_util_ErrorDialogConfig_ == IntPtr.Zero)
						id_ctor_Lcom_vivalnk_sdk_common_eventbus_util_ErrorDialogConfig_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vivalnk_sdk_common_eventbus_util_ErrorDialogConfig_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vivalnk_sdk_common_eventbus_util_ErrorDialogConfig_, __args);
				} finally {
				}
			}

			static Delegate cb_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetCreateErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler ()
			{
				if (cb_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == null)
					cb_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_);
				return cb_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
			}

			static IntPtr n_CreateErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_arguments)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogFragmentFactory.Honeycomb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var e = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				var arguments = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_arguments, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateErrorFragment (e, arguments));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory.Honeycomb']/method[@name='createErrorFragment' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("createErrorFragment", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/app/Fragment;", "GetCreateErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
			protected virtual unsafe global::Android.App.Fragment CreateErrorFragment (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent e, global::Android.OS.Bundle arguments)
			{
				if (id_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == IntPtr.Zero)
					id_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "createErrorFragment", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/app/Fragment;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (e);
					__args [1] = new JValue (arguments);

					global::Android.App.Fragment __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.App.Fragment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.App.Fragment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createErrorFragment", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/app/Fragment;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogFragmentFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorDialogFragmentFactory); }
		}

		protected ErrorDialogFragmentFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_vivalnk_sdk_common_eventbus_util_ErrorDialogConfig_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory']/constructor[@name='ErrorDialogFragmentFactory' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.ErrorDialogConfig']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;)V", "")]
		protected unsafe ErrorDialogFragmentFactory (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig config)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (config);
				if (((object) this).GetType () != typeof (ErrorDialogFragmentFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;)V", __args);
					return;
				}

				if (id_ctor_Lcom_vivalnk_sdk_common_eventbus_util_ErrorDialogConfig_ == IntPtr.Zero)
					id_ctor_Lcom_vivalnk_sdk_common_eventbus_util_ErrorDialogConfig_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vivalnk_sdk_common_eventbus_util_ErrorDialogConfig_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vivalnk_sdk_common_eventbus_util_ErrorDialogConfig_, __args);
			} finally {
			}
		}

		static Delegate cb_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetCreateErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler ()
		{
			if (cb_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == null)
				cb_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_);
			return cb_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
		}

		static IntPtr n_CreateErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogFragmentFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateErrorFragment (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory']/method[@name='createErrorFragment' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("createErrorFragment", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/Object;", "GetCreateErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
		protected abstract global::Java.Lang.Object CreateErrorFragment (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent p0, global::Android.OS.Bundle p1);

		static Delegate cb_getMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler ()
		{
			if (cb_getMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == null)
				cb_getMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_);
			return cb_getMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
		}

		static IntPtr n_GetMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogFragmentFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			var arguments = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_arguments, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMessageFor (e, arguments));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory']/method[@name='getMessageFor' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("getMessageFor", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/String;", "GetGetMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
		protected virtual unsafe string GetMessageFor (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent e, global::Android.OS.Bundle arguments)
		{
			if (id_getMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getMessageFor", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (e);
				__args [1] = new JValue (arguments);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageFor", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler ()
		{
			if (cb_getTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == null)
				cb_getTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_);
			return cb_getTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
		}

		static IntPtr n_GetTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogFragmentFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			var arguments = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_arguments, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTitleFor (e, arguments));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory']/method[@name='getTitleFor' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("getTitleFor", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/String;", "GetGetTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
		protected virtual unsafe string GetTitleFor (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent e, global::Android.OS.Bundle arguments)
		{
			if (id_getTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getTitleFor", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (e);
				__args [1] = new JValue (arguments);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitleFor_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitleFor", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_prepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetPrepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_Handler ()
		{
			if (cb_prepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_ == null)
				cb_prepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_L) n_PrepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_);
			return cb_prepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_;
		}

		static IntPtr n_PrepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, bool finishAfterDialog, IntPtr native_argumentsForErrorDialog)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogFragmentFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			var argumentsForErrorDialog = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_argumentsForErrorDialog, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareErrorFragment (e, finishAfterDialog, argumentsForErrorDialog));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory']/method[@name='prepareErrorFragment' and count(parameter)=3 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.ThrowableFailureEvent'] and parameter[2][@type='boolean'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("prepareErrorFragment", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;ZLandroid/os/Bundle;)Ljava/lang/Object;", "GetPrepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_Handler")]
		protected virtual unsafe global::Java.Lang.Object PrepareErrorFragment (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent e, bool finishAfterDialog, global::Android.OS.Bundle argumentsForErrorDialog)
		{
			if (id_prepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_ == IntPtr.Zero)
				id_prepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "prepareErrorFragment", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;ZLandroid/os/Bundle;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (e);
				__args [1] = new JValue (finishAfterDialog);
				__args [2] = new JValue (argumentsForErrorDialog);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prepareErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ZLandroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareErrorFragment", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;ZLandroid/os/Bundle;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogFragmentFactory", DoNotGenerateAcw=true)]
	internal partial class ErrorDialogFragmentFactoryInvoker : ErrorDialogFragmentFactory {

		public ErrorDialogFragmentFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorDialogFragmentFactoryInvoker); }
		}

		static IntPtr id_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragmentFactory']/method[@name='createErrorFragment' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("createErrorFragment", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/Object;", "GetCreateErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
		protected override unsafe global::Java.Lang.Object CreateErrorFragment (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent p0, global::Android.OS.Bundle p1)
		{
			if (id_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == IntPtr.Zero)
				id_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "createErrorFragment", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createErrorFragment_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
