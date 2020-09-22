using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogConfig']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig", DoNotGenerateAcw=true)]
	public partial class ErrorDialogConfig : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorDialogConfig); }
		}

		protected ErrorDialogConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_res_Resources_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogConfig']/constructor[@name='ErrorDialogConfig' and count(parameter)=3 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/res/Resources;II)V", "")]
		public unsafe ErrorDialogConfig (global::Android.Content.Res.Resources resources, int defaultTitleId, int defaultMsgId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (resources);
				__args [1] = new JValue (defaultTitleId);
				__args [2] = new JValue (defaultMsgId);
				if (((object) this).GetType () != typeof (ErrorDialogConfig)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/res/Resources;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/res/Resources;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_res_Resources_II == IntPtr.Zero)
					id_ctor_Landroid_content_res_Resources_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/res/Resources;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_res_Resources_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_res_Resources_II, __args);
			} finally {
			}
		}

		static Delegate cb_addMapping_Ljava_lang_Class_I;
#pragma warning disable 0169
		static Delegate GetAddMapping_Ljava_lang_Class_IHandler ()
		{
			if (cb_addMapping_Ljava_lang_Class_I == null)
				cb_addMapping_Ljava_lang_Class_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AddMapping_Ljava_lang_Class_I);
			return cb_addMapping_Ljava_lang_Class_I;
		}

		static IntPtr n_AddMapping_Ljava_lang_Class_I (IntPtr jnienv, IntPtr native__this, IntPtr native_clazz, int msgId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMapping (clazz, msgId));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMapping_Ljava_lang_Class_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogConfig']/method[@name='addMapping' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.Throwable&gt;'] and parameter[2][@type='int']]"
		[Register ("addMapping", "(Ljava/lang/Class;I)Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;", "GetAddMapping_Ljava_lang_Class_IHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig AddMapping (global::Java.Lang.Class clazz, int msgId)
		{
			if (id_addMapping_Ljava_lang_Class_I == IntPtr.Zero)
				id_addMapping_Ljava_lang_Class_I = JNIEnv.GetMethodID (class_ref, "addMapping", "(Ljava/lang/Class;I)Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (clazz);
				__args [1] = new JValue (msgId);

				global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMapping_Ljava_lang_Class_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMapping", "(Ljava/lang/Class;I)Lcom/vivalnk/sdk/common/eventbus/util/ErrorDialogConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_disableExceptionLogging;
#pragma warning disable 0169
		static Delegate GetDisableExceptionLoggingHandler ()
		{
			if (cb_disableExceptionLogging == null)
				cb_disableExceptionLogging = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DisableExceptionLogging);
			return cb_disableExceptionLogging;
		}

		static void n_DisableExceptionLogging (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableExceptionLogging ();
		}
#pragma warning restore 0169

		static IntPtr id_disableExceptionLogging;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogConfig']/method[@name='disableExceptionLogging' and count(parameter)=0]"
		[Register ("disableExceptionLogging", "()V", "GetDisableExceptionLoggingHandler")]
		public virtual unsafe void DisableExceptionLogging ()
		{
			if (id_disableExceptionLogging == IntPtr.Zero)
				id_disableExceptionLogging = JNIEnv.GetMethodID (class_ref, "disableExceptionLogging", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableExceptionLogging);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableExceptionLogging", "()V"));
			} finally {
			}
		}

		static Delegate cb_getMessageIdForThrowable_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetGetMessageIdForThrowable_Ljava_lang_Throwable_Handler ()
		{
			if (cb_getMessageIdForThrowable_Ljava_lang_Throwable_ == null)
				cb_getMessageIdForThrowable_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetMessageIdForThrowable_Ljava_lang_Throwable_);
			return cb_getMessageIdForThrowable_Ljava_lang_Throwable_;
		}

		static int n_GetMessageIdForThrowable_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetMessageIdForThrowable (throwable);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageIdForThrowable_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogConfig']/method[@name='getMessageIdForThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getMessageIdForThrowable", "(Ljava/lang/Throwable;)I", "GetGetMessageIdForThrowable_Ljava_lang_Throwable_Handler")]
		public virtual unsafe int GetMessageIdForThrowable (global::Java.Lang.Throwable throwable)
		{
			if (id_getMessageIdForThrowable_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getMessageIdForThrowable_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "getMessageIdForThrowable", "(Ljava/lang/Throwable;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMessageIdForThrowable_Ljava_lang_Throwable_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageIdForThrowable", "(Ljava/lang/Throwable;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDefaultDialogIconId_I;
#pragma warning disable 0169
		static Delegate GetSetDefaultDialogIconId_IHandler ()
		{
			if (cb_setDefaultDialogIconId_I == null)
				cb_setDefaultDialogIconId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDefaultDialogIconId_I);
			return cb_setDefaultDialogIconId_I;
		}

		static void n_SetDefaultDialogIconId_I (IntPtr jnienv, IntPtr native__this, int defaultDialogIconId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultDialogIconId (defaultDialogIconId);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultDialogIconId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogConfig']/method[@name='setDefaultDialogIconId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDefaultDialogIconId", "(I)V", "GetSetDefaultDialogIconId_IHandler")]
		public virtual unsafe void SetDefaultDialogIconId (int defaultDialogIconId)
		{
			if (id_setDefaultDialogIconId_I == IntPtr.Zero)
				id_setDefaultDialogIconId_I = JNIEnv.GetMethodID (class_ref, "setDefaultDialogIconId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultDialogIconId);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultDialogIconId_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultDialogIconId", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSetDefaultEventTypeOnDialogClosed_Ljava_lang_Class_Handler ()
		{
			if (cb_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_ == null)
				cb_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDefaultEventTypeOnDialogClosed_Ljava_lang_Class_);
			return cb_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_;
		}

		static void n_SetDefaultEventTypeOnDialogClosed_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_defaultEventTypeOnDialogClosed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var defaultEventTypeOnDialogClosed = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_defaultEventTypeOnDialogClosed, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultEventTypeOnDialogClosed (defaultEventTypeOnDialogClosed);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogConfig']/method[@name='setDefaultEventTypeOnDialogClosed' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("setDefaultEventTypeOnDialogClosed", "(Ljava/lang/Class;)V", "GetSetDefaultEventTypeOnDialogClosed_Ljava_lang_Class_Handler")]
		public virtual unsafe void SetDefaultEventTypeOnDialogClosed (global::Java.Lang.Class defaultEventTypeOnDialogClosed)
		{
			if (id_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_ == IntPtr.Zero)
				id_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setDefaultEventTypeOnDialogClosed", "(Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (defaultEventTypeOnDialogClosed);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultEventTypeOnDialogClosed_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultEventTypeOnDialogClosed", "(Ljava/lang/Class;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
#pragma warning disable 0169
		static Delegate GetSetEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_Handler ()
		{
			if (cb_setEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_ == null)
				cb_setEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_);
			return cb_setEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
		}

		static void n_SetEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventBus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventBus = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (native_eventBus, JniHandleOwnership.DoNotTransfer);
			__this.SetEventBus (eventBus);
		}
#pragma warning restore 0169

		static IntPtr id_setEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogConfig']/method[@name='setEventBus' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.EventBus']]"
		[Register ("setEventBus", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)V", "GetSetEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_Handler")]
		public virtual unsafe void SetEventBus (global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus eventBus)
		{
			if (id_setEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_ == IntPtr.Zero)
				id_setEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_ = JNIEnv.GetMethodID (class_ref, "setEventBus", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (eventBus);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventBus_Lcom_vivalnk_sdk_common_eventbus_EventBus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventBus", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTagForLoggingExceptions_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTagForLoggingExceptions_Ljava_lang_String_Handler ()
		{
			if (cb_setTagForLoggingExceptions_Ljava_lang_String_ == null)
				cb_setTagForLoggingExceptions_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTagForLoggingExceptions_Ljava_lang_String_);
			return cb_setTagForLoggingExceptions_Ljava_lang_String_;
		}

		static void n_SetTagForLoggingExceptions_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tagForLoggingExceptions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ErrorDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tagForLoggingExceptions = JNIEnv.GetString (native_tagForLoggingExceptions, JniHandleOwnership.DoNotTransfer);
			__this.SetTagForLoggingExceptions (tagForLoggingExceptions);
		}
#pragma warning restore 0169

		static IntPtr id_setTagForLoggingExceptions_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ErrorDialogConfig']/method[@name='setTagForLoggingExceptions' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTagForLoggingExceptions", "(Ljava/lang/String;)V", "GetSetTagForLoggingExceptions_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTagForLoggingExceptions (string tagForLoggingExceptions)
		{
			if (id_setTagForLoggingExceptions_Ljava_lang_String_ == IntPtr.Zero)
				id_setTagForLoggingExceptions_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTagForLoggingExceptions", "(Ljava/lang/String;)V");
			IntPtr native_tagForLoggingExceptions = JNIEnv.NewString (tagForLoggingExceptions);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_tagForLoggingExceptions);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTagForLoggingExceptions_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTagForLoggingExceptions", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tagForLoggingExceptions);
			}
		}

	}
}
