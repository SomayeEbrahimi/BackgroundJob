using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragments']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogFragments", DoNotGenerateAcw=true)]
	public partial class ErrorDialogFragments : global::Java.Lang.Object {


		static IntPtr ERROR_DIALOG_ICON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragments']/field[@name='ERROR_DIALOG_ICON']"
		[Register ("ERROR_DIALOG_ICON")]
		public static int ErrorDialogIcon {
			get {
				if (ERROR_DIALOG_ICON_jfieldId == IntPtr.Zero)
					ERROR_DIALOG_ICON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_DIALOG_ICON", "I");
				return JNIEnv.GetStaticIntField (class_ref, ERROR_DIALOG_ICON_jfieldId);
			}
			set {
				if (ERROR_DIALOG_ICON_jfieldId == IntPtr.Zero)
					ERROR_DIALOG_ICON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_DIALOG_ICON", "I");
				try {
					JNIEnv.SetStaticField (class_ref, ERROR_DIALOG_ICON_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr EVENT_TYPE_ON_CLICK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragments']/field[@name='EVENT_TYPE_ON_CLICK']"
		[Register ("EVENT_TYPE_ON_CLICK")]
		public static global::Java.Lang.Class EventTypeOnClick {
			get {
				if (EVENT_TYPE_ON_CLICK_jfieldId == IntPtr.Zero)
					EVENT_TYPE_ON_CLICK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_TYPE_ON_CLICK", "Ljava/lang/Class;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_TYPE_ON_CLICK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EVENT_TYPE_ON_CLICK_jfieldId == IntPtr.Zero)
					EVENT_TYPE_ON_CLICK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_TYPE_ON_CLICK", "Ljava/lang/Class;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, EVENT_TYPE_ON_CLICK_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragments.Honeycomb']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogFragments$Honeycomb", DoNotGenerateAcw=true)]
		public partial class Honeycomb : global::Android.App.DialogFragment, global::Android.Content.IDialogInterfaceOnClickListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogFragments$Honeycomb", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Honeycomb); }
			}

			protected Honeycomb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragments.Honeycomb']/constructor[@name='ErrorDialogFragments.Honeycomb' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Honeycomb ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Honeycomb)) {
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

			static Delegate cb_onClick_Landroid_content_DialogInterface_I;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_content_DialogInterface_IHandler ()
			{
				if (cb_onClick_Landroid_content_DialogInterface_I == null)
					cb_onClick_Landroid_content_DialogInterface_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnClick_Landroid_content_DialogInterface_I);
				return cb_onClick_Landroid_content_DialogInterface_I;
			}

			static void n_OnClick_Landroid_content_DialogInterface_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int which)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogFragments.Honeycomb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dialog = (global::Android.Content.IDialogInterface)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterface> (native_dialog, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (dialog, which);
			}
#pragma warning restore 0169

			static IntPtr id_onClick_Landroid_content_DialogInterface_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragments.Honeycomb']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='android.content.DialogInterface'] and parameter[2][@type='int']]"
			[Register ("onClick", "(Landroid/content/DialogInterface;I)V", "GetOnClick_Landroid_content_DialogInterface_IHandler")]
			public virtual unsafe void OnClick (global::Android.Content.IDialogInterface dialog, int which)
			{
				if (id_onClick_Landroid_content_DialogInterface_I == IntPtr.Zero)
					id_onClick_Landroid_content_DialogInterface_I = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/content/DialogInterface;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (dialog);
					__args [1] = new JValue (which);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_content_DialogInterface_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/content/DialogInterface;I)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogFragments", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorDialogFragments); }
		}

		protected ErrorDialogFragments (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragments']/constructor[@name='ErrorDialogFragments' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorDialogFragments ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ErrorDialogFragments)) {
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

		static IntPtr id_createDialog_Landroid_content_Context_Landroid_os_Bundle_Landroid_content_DialogInterface_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragments']/method[@name='createDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("createDialog", "(Landroid/content/Context;Landroid/os/Bundle;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/Dialog;", "")]
		public static unsafe global::Android.App.Dialog CreateDialog (global::Android.Content.Context context, global::Android.OS.Bundle arguments, global::Android.Content.IDialogInterfaceOnClickListener onClickListener)
		{
			if (id_createDialog_Landroid_content_Context_Landroid_os_Bundle_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
				id_createDialog_Landroid_content_Context_Landroid_os_Bundle_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetStaticMethodID (class_ref, "createDialog", "(Landroid/content/Context;Landroid/os/Bundle;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/Dialog;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (arguments);
				__args [2] = new JValue (onClickListener);
				global::Android.App.Dialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDialog_Landroid_content_Context_Landroid_os_Bundle_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_handleOnClick_Landroid_content_DialogInterface_ILandroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogFragments']/method[@name='handleOnClick' and count(parameter)=4 and parameter[1][@type='android.content.DialogInterface'] and parameter[2][@type='int'] and parameter[3][@type='android.app.Activity'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("handleOnClick", "(Landroid/content/DialogInterface;ILandroid/app/Activity;Landroid/os/Bundle;)V", "")]
		public static unsafe void HandleOnClick (global::Android.Content.IDialogInterface dialog, int which, global::Android.App.Activity activity, global::Android.OS.Bundle arguments)
		{
			if (id_handleOnClick_Landroid_content_DialogInterface_ILandroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_handleOnClick_Landroid_content_DialogInterface_ILandroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "handleOnClick", "(Landroid/content/DialogInterface;ILandroid/app/Activity;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (dialog);
				__args [1] = new JValue (which);
				__args [2] = new JValue (activity);
				__args [3] = new JValue (arguments);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_handleOnClick_Landroid_content_DialogInterface_ILandroid_app_Activity_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

	}
}
