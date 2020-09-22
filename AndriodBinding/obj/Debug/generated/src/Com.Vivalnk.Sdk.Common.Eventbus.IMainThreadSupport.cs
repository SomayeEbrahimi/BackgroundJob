using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='MainThreadSupport.AndroidHandlerMainThreadSupport']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/MainThreadSupport$AndroidHandlerMainThreadSupport", DoNotGenerateAcw=true)]
	public partial class MainThreadSupportAndroidHandlerMainThreadSupport : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.IMainThreadSupport {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/MainThreadSupport$AndroidHandlerMainThreadSupport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MainThreadSupportAndroidHandlerMainThreadSupport); }
		}

		protected MainThreadSupportAndroidHandlerMainThreadSupport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Looper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='MainThreadSupport.AndroidHandlerMainThreadSupport']/constructor[@name='MainThreadSupport.AndroidHandlerMainThreadSupport' and count(parameter)=1 and parameter[1][@type='android.os.Looper']]"
		[Register (".ctor", "(Landroid/os/Looper;)V", "")]
		public unsafe MainThreadSupportAndroidHandlerMainThreadSupport (global::Android.OS.Looper looper)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (looper);
				if (((object) this).GetType () != typeof (MainThreadSupportAndroidHandlerMainThreadSupport)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Looper;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Looper;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Looper_ == IntPtr.Zero)
					id_ctor_Landroid_os_Looper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Looper;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Looper_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Looper_, __args);
			} finally {
			}
		}

		static Delegate cb_isMainThread;
#pragma warning disable 0169
		static Delegate GetIsMainThreadHandler ()
		{
			if (cb_isMainThread == null)
				cb_isMainThread = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMainThread);
			return cb_isMainThread;
		}

		static bool n_IsMainThread (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.MainThreadSupportAndroidHandlerMainThreadSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMainThread;
		}
#pragma warning restore 0169

		static IntPtr id_isMainThread;
		public virtual unsafe bool IsMainThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='MainThreadSupport.AndroidHandlerMainThreadSupport']/method[@name='isMainThread' and count(parameter)=0]"
			[Register ("isMainThread", "()Z", "GetIsMainThreadHandler")]
			get {
				if (id_isMainThread == IntPtr.Zero)
					id_isMainThread = JNIEnv.GetMethodID (class_ref, "isMainThread", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMainThread);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMainThread", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
#pragma warning disable 0169
		static Delegate GetCreatePoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_Handler ()
		{
			if (cb_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_ == null)
				cb_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreatePoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_);
			return cb_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
		}

		static IntPtr n_CreatePoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventBus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.MainThreadSupportAndroidHandlerMainThreadSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventBus = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (native_eventBus, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePoster (eventBus));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='MainThreadSupport.AndroidHandlerMainThreadSupport']/method[@name='createPoster' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.EventBus']]"
		[Register ("createPoster", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)Lcom/vivalnk/sdk/common/eventbus/Poster;", "GetCreatePoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.IPoster CreatePoster (global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus eventBus)
		{
			if (id_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_ == IntPtr.Zero)
				id_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_ = JNIEnv.GetMethodID (class_ref, "createPoster", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)Lcom/vivalnk/sdk/common/eventbus/Poster;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (eventBus);

				global::Com.Vivalnk.Sdk.Common.Eventbus.IPoster __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.IPoster> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.IPoster> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createPoster", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)Lcom/vivalnk/sdk/common/eventbus/Poster;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='MainThreadSupport']"
	[Register ("com/vivalnk/sdk/common/eventbus/MainThreadSupport", "", "Com.Vivalnk.Sdk.Common.Eventbus.IMainThreadSupportInvoker")]
	public partial interface IMainThreadSupport : IJavaObject {

		bool IsMainThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='MainThreadSupport']/method[@name='isMainThread' and count(parameter)=0]"
			[Register ("isMainThread", "()Z", "GetIsMainThreadHandler:Com.Vivalnk.Sdk.Common.Eventbus.IMainThreadSupportInvoker, AndriodBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='MainThreadSupport']/method[@name='createPoster' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.common.eventbus.EventBus']]"
		[Register ("createPoster", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)Lcom/vivalnk/sdk/common/eventbus/Poster;", "GetCreatePoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_Handler:Com.Vivalnk.Sdk.Common.Eventbus.IMainThreadSupportInvoker, AndriodBinding")]
		global::Com.Vivalnk.Sdk.Common.Eventbus.IPoster CreatePoster (global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/MainThreadSupport", DoNotGenerateAcw=true)]
	internal partial class IMainThreadSupportInvoker : global::Java.Lang.Object, IMainThreadSupport {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/MainThreadSupport");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMainThreadSupportInvoker); }
		}

		IntPtr class_ref;

		public static IMainThreadSupport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMainThreadSupport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.eventbus.MainThreadSupport"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMainThreadSupportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isMainThread;
#pragma warning disable 0169
		static Delegate GetIsMainThreadHandler ()
		{
			if (cb_isMainThread == null)
				cb_isMainThread = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMainThread);
			return cb_isMainThread;
		}

		static bool n_IsMainThread (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.IMainThreadSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMainThread;
		}
#pragma warning restore 0169

		IntPtr id_isMainThread;
		public unsafe bool IsMainThread {
			get {
				if (id_isMainThread == IntPtr.Zero)
					id_isMainThread = JNIEnv.GetMethodID (class_ref, "isMainThread", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMainThread);
			}
		}

		static Delegate cb_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
#pragma warning disable 0169
		static Delegate GetCreatePoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_Handler ()
		{
			if (cb_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_ == null)
				cb_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreatePoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_);
			return cb_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
		}

		static IntPtr n_CreatePoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.IMainThreadSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePoster (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_;
		public unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.IPoster CreatePoster (global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus p0)
		{
			if (id_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_ == IntPtr.Zero)
				id_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_ = JNIEnv.GetMethodID (class_ref, "createPoster", "(Lcom/vivalnk/sdk/common/eventbus/EventBus;)Lcom/vivalnk/sdk/common/eventbus/Poster;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.IPoster> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createPoster_Lcom_vivalnk_sdk_common_eventbus_EventBus_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
