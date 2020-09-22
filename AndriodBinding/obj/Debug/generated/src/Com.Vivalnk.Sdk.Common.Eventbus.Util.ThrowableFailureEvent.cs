using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ThrowableFailureEvent']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent", DoNotGenerateAcw=true)]
	public partial class ThrowableFailureEvent : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.Util.IHasExecutionScope {


		static IntPtr suppressErrorUi_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ThrowableFailureEvent']/field[@name='suppressErrorUi']"
		[Register ("suppressErrorUi")]
		protected bool SuppressErrorUi {
			get {
				if (suppressErrorUi_jfieldId == IntPtr.Zero)
					suppressErrorUi_jfieldId = JNIEnv.GetFieldID (class_ref, "suppressErrorUi", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, suppressErrorUi_jfieldId);
			}
			set {
				if (suppressErrorUi_jfieldId == IntPtr.Zero)
					suppressErrorUi_jfieldId = JNIEnv.GetFieldID (class_ref, "suppressErrorUi", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, suppressErrorUi_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/ThrowableFailureEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThrowableFailureEvent); }
		}

		protected ThrowableFailureEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ThrowableFailureEvent']/constructor[@name='ThrowableFailureEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe ThrowableFailureEvent (global::Java.Lang.Throwable throwable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				if (((object) this).GetType () != typeof (ThrowableFailureEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Throwable_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ThrowableFailureEvent']/constructor[@name='ThrowableFailureEvent' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/Throwable;Z)V", "")]
		public unsafe ThrowableFailureEvent (global::Java.Lang.Throwable throwable, bool suppressErrorUi)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (throwable);
				__args [1] = new JValue (suppressErrorUi);
				if (((object) this).GetType () != typeof (ThrowableFailureEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Throwable;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Throwable;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Throwable_Z, __args);
			} finally {
			}
		}

		static Delegate cb_getExecutionScope;
#pragma warning disable 0169
		static Delegate GetGetExecutionScopeHandler ()
		{
			if (cb_getExecutionScope == null)
				cb_getExecutionScope = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExecutionScope);
			return cb_getExecutionScope;
		}

		static IntPtr n_GetExecutionScope (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExecutionScope);
		}
#pragma warning restore 0169

		static Delegate cb_setExecutionScope_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetExecutionScope_Ljava_lang_Object_Handler ()
		{
			if (cb_setExecutionScope_Ljava_lang_Object_ == null)
				cb_setExecutionScope_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExecutionScope_Ljava_lang_Object_);
			return cb_setExecutionScope_Ljava_lang_Object_;
		}

		static void n_SetExecutionScope_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_executionContext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var executionContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_executionContext, JniHandleOwnership.DoNotTransfer);
			__this.ExecutionScope = executionContext;
		}
#pragma warning restore 0169

		static IntPtr id_getExecutionScope;
		static IntPtr id_setExecutionScope_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object ExecutionScope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ThrowableFailureEvent']/method[@name='getExecutionScope' and count(parameter)=0]"
			[Register ("getExecutionScope", "()Ljava/lang/Object;", "GetGetExecutionScopeHandler")]
			get {
				if (id_getExecutionScope == IntPtr.Zero)
					id_getExecutionScope = JNIEnv.GetMethodID (class_ref, "getExecutionScope", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExecutionScope), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExecutionScope", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ThrowableFailureEvent']/method[@name='setExecutionScope' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setExecutionScope", "(Ljava/lang/Object;)V", "GetSetExecutionScope_Ljava_lang_Object_Handler")]
			set {
				if (id_setExecutionScope_Ljava_lang_Object_ == IntPtr.Zero)
					id_setExecutionScope_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setExecutionScope", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExecutionScope_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExecutionScope", "(Ljava/lang/Object;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSuppressErrorUi;
#pragma warning disable 0169
		static Delegate GetIsSuppressErrorUiHandler ()
		{
			if (cb_isSuppressErrorUi == null)
				cb_isSuppressErrorUi = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuppressErrorUi);
			return cb_isSuppressErrorUi;
		}

		static bool n_IsSuppressErrorUi (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuppressErrorUi;
		}
#pragma warning restore 0169

		static IntPtr id_isSuppressErrorUi;
		public virtual unsafe bool IsSuppressErrorUi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ThrowableFailureEvent']/method[@name='isSuppressErrorUi' and count(parameter)=0]"
			[Register ("isSuppressErrorUi", "()Z", "GetIsSuppressErrorUiHandler")]
			get {
				if (id_isSuppressErrorUi == IntPtr.Zero)
					id_isSuppressErrorUi = JNIEnv.GetMethodID (class_ref, "isSuppressErrorUi", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuppressErrorUi);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuppressErrorUi", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getThrowable;
#pragma warning disable 0169
		static Delegate GetGetThrowableHandler ()
		{
			if (cb_getThrowable == null)
				cb_getThrowable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThrowable);
			return cb_getThrowable;
		}

		static IntPtr n_GetThrowable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ThrowableFailureEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Throwable);
		}
#pragma warning restore 0169

		static IntPtr id_getThrowable;
		public virtual unsafe global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ThrowableFailureEvent']/method[@name='getThrowable' and count(parameter)=0]"
			[Register ("getThrowable", "()Ljava/lang/Throwable;", "GetGetThrowableHandler")]
			get {
				if (id_getThrowable == IntPtr.Zero)
					id_getThrowable = JNIEnv.GetMethodID (class_ref, "getThrowable", "()Ljava/lang/Throwable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThrowable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThrowable", "()Ljava/lang/Throwable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
