using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Vdireaderimpl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']"
	[global::Android.Runtime.Register ("com/vivalnk/vdireaderimpl/VDIBleService", DoNotGenerateAcw=true)]
	public partial class VDIBleService : global::Android.App.Service {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService.LocalBinder']"
		[global::Android.Runtime.Register ("com/vivalnk/vdireaderimpl/VDIBleService$LocalBinder", DoNotGenerateAcw=true)]
		public partial class LocalBinder : global::Android.OS.Binder {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireaderimpl/VDIBleService$LocalBinder", typeof (LocalBinder));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected LocalBinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService.LocalBinder']/constructor[@name='VDIBleService.LocalBinder' and count(parameter)=1 and parameter[1][@type='com.vivalnk.vdireaderimpl.VDIBleService']]"
			[Register (".ctor", "(Lcom/vivalnk/vdireaderimpl/VDIBleService;)V", "")]
			public unsafe LocalBinder (global::Com.Vivalnk.Vdireaderimpl.VDIBleService __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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

			public virtual unsafe global::Com.Vivalnk.Vdireaderimpl.VDIBleService Service {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService.LocalBinder']/method[@name='getService' and count(parameter)=0]"
				[Register ("getService", "()Lcom/vivalnk/vdireaderimpl/VDIBleService;", "GetGetServiceHandler")]
				get {
					const string __id = "getService.()Lcom/vivalnk/vdireaderimpl/VDIBleService;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireaderimpl/VDIBleService", typeof (VDIBleService));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected VDIBleService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']/constructor[@name='VDIBleService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VDIBleService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']/method[@name='background' and count(parameter)=0]"
		[Register ("background", "()V", "GetBackgroundHandler")]
		public virtual unsafe void Background ()
		{
			const string __id = "background.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']/method[@name='foreground' and count(parameter)=0]"
		[Register ("foreground", "()V", "GetForegroundHandler")]
		public virtual unsafe void Foreground ()
		{
			const string __id = "foreground.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			const string __id = "onBind.(Landroid/content/Intent;)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleService']/method[@name='setNotification' and count(parameter)=1 and parameter[1][@type='android.app.Notification']]"
		[Register ("setNotification", "(Landroid/app/Notification;)V", "GetSetNotification_Landroid_app_Notification_Handler")]
		public virtual unsafe void SetNotification (global::Android.App.Notification p0)
		{
			const string __id = "setNotification.(Landroid/app/Notification;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
