using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Vdireaderimpl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']"
	[global::Android.Runtime.Register ("com/vivalnk/vdireaderimpl/VDIBleService", DoNotGenerateAcw=true)]
	public partial class VDIBleService : global::Android.App.Service {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService.LocalBinder']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireaderimpl/VDIBleService$LocalBinder", DoNotGenerateAcw=true)]
		public partial class LocalBinder : global::Android.OS.Binder {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/vdireaderimpl/VDIBleService$LocalBinder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LocalBinder); }
			}

			protected LocalBinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_vivalnk_vdireaderimpl_VDIBleService_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService.LocalBinder']/constructor[@name='VDIBleService.LocalBinder' and count(parameter)=1 and parameter[1][@type='com.vivalnk.vdireaderimpl.VDIBleService']]"
			[Register (".ctor", "(Lcom/vivalnk/vdireaderimpl/VDIBleService;)V", "")]
			public unsafe LocalBinder (global::Com.Vivalnk.Vdireaderimpl.VDIBleService __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (LocalBinder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_vivalnk_vdireaderimpl_VDIBleService_ == IntPtr.Zero)
						id_ctor_Lcom_vivalnk_vdireaderimpl_VDIBleService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vivalnk/vdireaderimpl/VDIBleService;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vivalnk_vdireaderimpl_VDIBleService_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vivalnk_vdireaderimpl_VDIBleService_, __args);
				} finally {
				}
			}

			static Delegate cb_getService;
#pragma warning disable 0169
			static Delegate GetGetServiceHandler ()
			{
				if (cb_getService == null)
					cb_getService = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetService);
				return cb_getService;
			}

			static IntPtr n_GetService (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleService.LocalBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Service);
			}
#pragma warning restore 0169

			static IntPtr id_getService;
			public virtual unsafe global::Com.Vivalnk.Vdireaderimpl.VDIBleService Service {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService.LocalBinder']/method[@name='getService' and count(parameter)=0]"
				[Register ("getService", "()Lcom/vivalnk/vdireaderimpl/VDIBleService;", "GetGetServiceHandler")]
				get {
					if (id_getService == IntPtr.Zero)
						id_getService = JNIEnv.GetMethodID (class_ref, "getService", "()Lcom/vivalnk/vdireaderimpl/VDIBleService;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getService), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleService> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getService", "()Lcom/vivalnk/vdireaderimpl/VDIBleService;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/vdireaderimpl/VDIBleService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VDIBleService); }
		}

		protected VDIBleService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']/constructor[@name='VDIBleService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VDIBleService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VDIBleService)) {
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

		static Delegate cb_background;
#pragma warning disable 0169
		static Delegate GetBackgroundHandler ()
		{
			if (cb_background == null)
				cb_background = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Background);
			return cb_background;
		}

		static void n_Background (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Background ();
		}
#pragma warning restore 0169

		static IntPtr id_background;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']/method[@name='background' and count(parameter)=0]"
		[Register ("background", "()V", "GetBackgroundHandler")]
		public virtual unsafe void Background ()
		{
			if (id_background == IntPtr.Zero)
				id_background = JNIEnv.GetMethodID (class_ref, "background", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_background);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "background", "()V"));
			} finally {
			}
		}

		static Delegate cb_foreground;
#pragma warning disable 0169
		static Delegate GetForegroundHandler ()
		{
			if (cb_foreground == null)
				cb_foreground = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Foreground);
			return cb_foreground;
		}

		static void n_Foreground (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Foreground ();
		}
#pragma warning restore 0169

		static IntPtr id_foreground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']/method[@name='foreground' and count(parameter)=0]"
		[Register ("foreground", "()V", "GetForegroundHandler")]
		public virtual unsafe void Foreground ()
		{
			if (id_foreground == IntPtr.Zero)
				id_foreground = JNIEnv.GetMethodID (class_ref, "foreground", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_foreground);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "foreground", "()V"));
			} finally {
			}
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.IBinder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setNotification_Landroid_app_Notification_;
#pragma warning disable 0169
		static Delegate GetSetNotification_Landroid_app_Notification_Handler ()
		{
			if (cb_setNotification_Landroid_app_Notification_ == null)
				cb_setNotification_Landroid_app_Notification_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNotification_Landroid_app_Notification_);
			return cb_setNotification_Landroid_app_Notification_;
		}

		static void n_SetNotification_Landroid_app_Notification_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Notification> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNotification (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNotification_Landroid_app_Notification_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']/method[@name='setNotification' and count(parameter)=1 and parameter[1][@type='android.app.Notification']]"
		[Register ("setNotification", "(Landroid/app/Notification;)V", "GetSetNotification_Landroid_app_Notification_Handler")]
		public virtual unsafe void SetNotification (global::Android.App.Notification p0)
		{
			if (id_setNotification_Landroid_app_Notification_ == IntPtr.Zero)
				id_setNotification_Landroid_app_Notification_ = JNIEnv.GetMethodID (class_ref, "setNotification", "(Landroid/app/Notification;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotification_Landroid_app_Notification_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotification", "(Landroid/app/Notification;)V"), __args);
			} finally {
			}
		}

	}
}
