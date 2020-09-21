using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Poster {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/poster/AbsPoster", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class AbsPoster : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Ble.Poster.IPoster {


		static IntPtr handler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/field[@name='handler']"
		[Register ("handler")]
		protected global::Android.OS.Handler Handler {
			get {
				if (handler_jfieldId == IntPtr.Zero)
					handler_jfieldId = JNIEnv.GetFieldID (class_ref, "handler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, handler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (handler_jfieldId == IntPtr.Zero)
					handler_jfieldId = JNIEnv.GetFieldID (class_ref, "handler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, handler_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/poster/AbsPoster", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbsPoster); }
		}

		protected AbsPoster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/constructor[@name='AbsPoster' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbsPoster ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AbsPoster)) {
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

		static Delegate cb_getCallbackList;
#pragma warning disable 0169
		static Delegate GetGetCallbackListHandler ()
		{
			if (cb_getCallbackList == null)
				cb_getCallbackList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCallbackList);
			return cb_getCallbackList;
		}

		static IntPtr n_GetCallbackList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Poster.AbsPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet.ToLocalJniHandle (__this.CallbackList);
		}
#pragma warning restore 0169

		static IntPtr id_getCallbackList;
		public virtual unsafe global::System.Collections.ICollection CallbackList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/method[@name='getCallbackList' and count(parameter)=0]"
			[Register ("getCallbackList", "()Ljava/util/Set;", "GetGetCallbackListHandler")]
			get {
				if (id_getCallbackList == IntPtr.Zero)
					id_getCallbackList = JNIEnv.GetMethodID (class_ref, "getCallbackList", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallbackList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallbackList", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_registCallback_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRegistCallback_Ljava_lang_Object_Handler ()
		{
			if (cb_registCallback_Ljava_lang_Object_ == null)
				cb_registCallback_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegistCallback_Ljava_lang_Object_);
			return cb_registCallback_Ljava_lang_Object_;
		}

		static void n_RegistCallback_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Poster.AbsPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RegistCallback (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_registCallback_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/method[@name='registCallback' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("registCallback", "(Ljava/lang/Object;)V", "GetRegistCallback_Ljava_lang_Object_Handler")]
		public virtual unsafe void RegistCallback (global::Java.Lang.Object @callback)
		{
			if (id_registCallback_Ljava_lang_Object_ == IntPtr.Zero)
				id_registCallback_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "registCallback", "(Ljava/lang/Object;)V");
			IntPtr native__callback = JNIEnv.ToLocalJniHandle (@callback);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registCallback_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registCallback", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__callback);
			}
		}

		static Delegate cb_setHandler_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetSetHandler_Landroid_os_Handler_Handler ()
		{
			if (cb_setHandler_Landroid_os_Handler_ == null)
				cb_setHandler_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHandler_Landroid_os_Handler_);
			return cb_setHandler_Landroid_os_Handler_;
		}

		static void n_SetHandler_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Poster.AbsPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var handler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_handler, JniHandleOwnership.DoNotTransfer);
			__this.SetHandler (handler);
		}
#pragma warning restore 0169

		static IntPtr id_setHandler_Landroid_os_Handler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/method[@name='setHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("setHandler", "(Landroid/os/Handler;)V", "GetSetHandler_Landroid_os_Handler_Handler")]
		public virtual unsafe void SetHandler (global::Android.OS.Handler handler)
		{
			if (id_setHandler_Landroid_os_Handler_ == IntPtr.Zero)
				id_setHandler_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "setHandler", "(Landroid/os/Handler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (handler);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHandler_Landroid_os_Handler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHandler", "(Landroid/os/Handler;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregistCallback_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUnregistCallback_Ljava_lang_Object_Handler ()
		{
			if (cb_unregistCallback_Ljava_lang_Object_ == null)
				cb_unregistCallback_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UnregistCallback_Ljava_lang_Object_);
			return cb_unregistCallback_Ljava_lang_Object_;
		}

		static void n_UnregistCallback_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Poster.AbsPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.UnregistCallback (t);
		}
#pragma warning restore 0169

		static IntPtr id_unregistCallback_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/method[@name='unregistCallback' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("unregistCallback", "(Ljava/lang/Object;)V", "GetUnregistCallback_Ljava_lang_Object_Handler")]
		public virtual unsafe void UnregistCallback (global::Java.Lang.Object t)
		{
			if (id_unregistCallback_Ljava_lang_Object_ == IntPtr.Zero)
				id_unregistCallback_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "unregistCallback", "(Ljava/lang/Object;)V");
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_t);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregistCallback_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregistCallback", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_t);
			}
		}

		static Delegate cb_unregistCallbackAll;
#pragma warning disable 0169
		static Delegate GetUnregistCallbackAllHandler ()
		{
			if (cb_unregistCallbackAll == null)
				cb_unregistCallbackAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UnregistCallbackAll);
			return cb_unregistCallbackAll;
		}

		static void n_UnregistCallbackAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Poster.AbsPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregistCallbackAll ();
		}
#pragma warning restore 0169

		static IntPtr id_unregistCallbackAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/method[@name='unregistCallbackAll' and count(parameter)=0]"
		[Register ("unregistCallbackAll", "()V", "GetUnregistCallbackAllHandler")]
		public virtual unsafe void UnregistCallbackAll ()
		{
			if (id_unregistCallbackAll == IntPtr.Zero)
				id_unregistCallbackAll = JNIEnv.GetMethodID (class_ref, "unregistCallbackAll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregistCallbackAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregistCallbackAll", "()V"));
			} finally {
			}
		}

	}
}
