using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogManager", DoNotGenerateAcw=true)]
	public partial class ErrorDialogManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/field[@name='KEY_EVENT_TYPE_ON_CLOSE']"
		[Register ("KEY_EVENT_TYPE_ON_CLOSE")]
		public const string KeyEventTypeOnClose = (string) "de.greenrobot.eventbus.errordialog.event_type_on_close";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/field[@name='KEY_FINISH_AFTER_DIALOG']"
		[Register ("KEY_FINISH_AFTER_DIALOG")]
		public const string KeyFinishAfterDialog = (string) "de.greenrobot.eventbus.errordialog.finish_after_dialog";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/field[@name='KEY_ICON_ID']"
		[Register ("KEY_ICON_ID")]
		public const string KeyIconId = (string) "de.greenrobot.eventbus.errordialog.icon_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/field[@name='KEY_MESSAGE']"
		[Register ("KEY_MESSAGE")]
		public const string KeyMessage = (string) "de.greenrobot.eventbus.errordialog.message";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/field[@name='KEY_TITLE']"
		[Register ("KEY_TITLE")]
		public const string KeyTitle = (string) "de.greenrobot.eventbus.errordialog.title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/field[@name='TAG_ERROR_DIALOG']"
		[Register ("TAG_ERROR_DIALOG")]
		protected const string TagErrorDialog = (string) "de.greenrobot.eventbus.error_dialog";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/field[@name='TAG_ERROR_DIALOG_MANAGER']"
		[Register ("TAG_ERROR_DIALOG_MANAGER")]
		protected const string TagErrorDialogManager = (string) "de.greenrobot.eventbus.error_dialog_manager";

		static IntPtr factory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/field[@name='factory']"
		[Register ("factory")]
		public static global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogFragmentFactory Factory {
			get {
				if (factory_jfieldId == IntPtr.Zero)
					factory_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "factory", "Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogFragmentFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, factory_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogFragmentFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (factory_jfieldId == IntPtr.Zero)
					factory_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "factory", "Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogFragmentFactory;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, factory_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogManager$HoneycombManagerFragment", DoNotGenerateAcw=true)]
		public partial class HoneycombManagerFragment : global::Android.App.Fragment {


			static IntPtr argumentsForErrorDialog_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']/field[@name='argumentsForErrorDialog']"
			[Register ("argumentsForErrorDialog")]
			protected global::Android.OS.Bundle ArgumentsForErrorDialog {
				get {
					if (argumentsForErrorDialog_jfieldId == IntPtr.Zero)
						argumentsForErrorDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "argumentsForErrorDialog", "Landroid/os/Bundle;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, argumentsForErrorDialog_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (argumentsForErrorDialog_jfieldId == IntPtr.Zero)
						argumentsForErrorDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "argumentsForErrorDialog", "Landroid/os/Bundle;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, argumentsForErrorDialog_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr finishAfterDialog_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']/field[@name='finishAfterDialog']"
			[Register ("finishAfterDialog")]
			protected bool FinishAfterDialog {
				get {
					if (finishAfterDialog_jfieldId == IntPtr.Zero)
						finishAfterDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "finishAfterDialog", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, finishAfterDialog_jfieldId);
				}
				set {
					if (finishAfterDialog_jfieldId == IntPtr.Zero)
						finishAfterDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "finishAfterDialog", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, finishAfterDialog_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogManager$HoneycombManagerFragment", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HoneycombManagerFragment); }
			}

			protected HoneycombManagerFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']/constructor[@name='ErrorDialogManager.HoneycombManagerFragment' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe HoneycombManagerFragment ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (HoneycombManagerFragment)) {
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

			static IntPtr id_attachTo_Landroid_app_Activity_Ljava_lang_Object_ZLandroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']/method[@name='attachTo' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean'] and parameter[4][@type='android.os.Bundle']]"
			[Register ("attachTo", "(Landroid/app/Activity;Ljava/lang/Object;ZLandroid/os/Bundle;)V", "")]
			public static unsafe void AttachTo (global::Android.App.Activity activity, global::Java.Lang.Object executionScope, bool finishAfterDialog, global::Android.OS.Bundle argumentsForErrorDialog)
			{
				if (id_attachTo_Landroid_app_Activity_Ljava_lang_Object_ZLandroid_os_Bundle_ == IntPtr.Zero)
					id_attachTo_Landroid_app_Activity_Ljava_lang_Object_ZLandroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "attachTo", "(Landroid/app/Activity;Ljava/lang/Object;ZLandroid/os/Bundle;)V");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (activity);
					__args [1] = new JValue (executionScope);
					__args [2] = new JValue (finishAfterDialog);
					__args [3] = new JValue (argumentsForErrorDialog);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_attachTo_Landroid_app_Activity_Ljava_lang_Object_ZLandroid_os_Bundle_, __args);
				} finally {
				}
			}

			static Delegate cb_onEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_;
#pragma warning disable 0169
			static Delegate GetOnEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Handler ()
			{
				if (cb_onEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ == null)
					cb_onEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_);
				return cb_onEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_;
			}

			static void n_OnEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogManager.HoneycombManagerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var e = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				__this.OnEventMainThread (e);
			}
#pragma warning restore 0169

			static IntPtr id_onEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']/method[@name='onEventMainThread' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.ThrowableFailureEvent']]"
			[Register ("onEventMainThread", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;)V", "GetOnEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_Handler")]
			public virtual unsafe void OnEventMainThread (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent e)
			{
				if (id_onEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ == IntPtr.Zero)
					id_onEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ = JNIEnv.GetMethodID (class_ref, "onEventMainThread", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (e);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEventMainThread_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onEventMainThread", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorDialogManager); }
		}

		protected ErrorDialogManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/constructor[@name='ErrorDialogManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorDialogManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ErrorDialogManager)) {
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

		static IntPtr id_attachTo_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/method[@name='attachTo' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("attachTo", "(Landroid/app/Activity;)V", "")]
		public static unsafe void AttachTo (global::Android.App.Activity activity)
		{
			if (id_attachTo_Landroid_app_Activity_ == IntPtr.Zero)
				id_attachTo_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "attachTo", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (activity);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_attachTo_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_attachTo_Landroid_app_Activity_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/method[@name='attachTo' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean']]"
		[Register ("attachTo", "(Landroid/app/Activity;Z)V", "")]
		public static unsafe void AttachTo (global::Android.App.Activity activity, bool finishAfterDialog)
		{
			if (id_attachTo_Landroid_app_Activity_Z == IntPtr.Zero)
				id_attachTo_Landroid_app_Activity_Z = JNIEnv.GetStaticMethodID (class_ref, "attachTo", "(Landroid/app/Activity;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (activity);
				__args [1] = new JValue (finishAfterDialog);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_attachTo_Landroid_app_Activity_Z, __args);
			} finally {
			}
		}

		static IntPtr id_attachTo_Landroid_app_Activity_ZLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/method[@name='attachTo' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("attachTo", "(Landroid/app/Activity;ZLandroid/os/Bundle;)V", "")]
		public static unsafe void AttachTo (global::Android.App.Activity activity, bool finishAfterDialog, global::Android.OS.Bundle argumentsForErrorDialog)
		{
			if (id_attachTo_Landroid_app_Activity_ZLandroid_os_Bundle_ == IntPtr.Zero)
				id_attachTo_Landroid_app_Activity_ZLandroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "attachTo", "(Landroid/app/Activity;ZLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (activity);
				__args [1] = new JValue (finishAfterDialog);
				__args [2] = new JValue (argumentsForErrorDialog);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_attachTo_Landroid_app_Activity_ZLandroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_attachTo_Landroid_app_Activity_Ljava_lang_Object_ZLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/method[@name='attachTo' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("attachTo", "(Landroid/app/Activity;Ljava/lang/Object;ZLandroid/os/Bundle;)V", "")]
		public static unsafe void AttachTo (global::Android.App.Activity activity, global::Java.Lang.Object executionScope, bool finishAfterDialog, global::Android.OS.Bundle argumentsForErrorDialog)
		{
			if (id_attachTo_Landroid_app_Activity_Ljava_lang_Object_ZLandroid_os_Bundle_ == IntPtr.Zero)
				id_attachTo_Landroid_app_Activity_Ljava_lang_Object_ZLandroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "attachTo", "(Landroid/app/Activity;Ljava/lang/Object;ZLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (activity);
				__args [1] = new JValue (executionScope);
				__args [2] = new JValue (finishAfterDialog);
				__args [3] = new JValue (argumentsForErrorDialog);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_attachTo_Landroid_app_Activity_Ljava_lang_Object_ZLandroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_checkLogException_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogManager']/method[@name='checkLogException' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.util.ThrowableFailureEvent']]"
		[Register ("checkLogException", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;)V", "")]
		protected static unsafe void CheckLogException (global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent e)
		{
			if (id_checkLogException_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ == IntPtr.Zero)
				id_checkLogException_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_ = JNIEnv.GetStaticMethodID (class_ref, "checkLogException", "(Lcom/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkLogException_Lcom_vivalnk_sdk_common_eventbus_util_ThrowableFailureEvent_, __args);
			} finally {
			}
		}

	}
}
