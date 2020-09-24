using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Poster {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/poster/AbsPoster", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class AbsPoster : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Ble.Poster.IPoster {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/field[@name='handler']"
		[Register ("handler")]
		protected global::Android.OS.Handler Handler {
			get {
				const string __id = "handler.Landroid/os/Handler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "handler.Landroid/os/Handler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/poster/AbsPoster", typeof (AbsPoster));
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

		protected AbsPoster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/constructor[@name='AbsPoster' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbsPoster ()
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

		public virtual unsafe global::System.Collections.ICollection CallbackList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/method[@name='getCallbackList' and count(parameter)=0]"
			[Register ("getCallbackList", "()Ljava/util/Set;", "GetGetCallbackListHandler")]
			get {
				const string __id = "getCallbackList.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/method[@name='registCallback' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("registCallback", "(Ljava/lang/Object;)V", "GetRegistCallback_Ljava_lang_Object_Handler")]
		public virtual unsafe void RegistCallback (global::Java.Lang.Object @callback)
		{
			const string __id = "registCallback.(Ljava/lang/Object;)V";
			IntPtr native__callback = JNIEnv.ToLocalJniHandle (@callback);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__callback);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/method[@name='setHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("setHandler", "(Landroid/os/Handler;)V", "GetSetHandler_Landroid_os_Handler_Handler")]
		public virtual unsafe void SetHandler (global::Android.OS.Handler handler)
		{
			const string __id = "setHandler.(Landroid/os/Handler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/method[@name='unregistCallback' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("unregistCallback", "(Ljava/lang/Object;)V", "GetUnregistCallback_Ljava_lang_Object_Handler")]
		public virtual unsafe void UnregistCallback (global::Java.Lang.Object t)
		{
			const string __id = "unregistCallback.(Ljava/lang/Object;)V";
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_t);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/class[@name='AbsPoster']/method[@name='unregistCallbackAll' and count(parameter)=0]"
		[Register ("unregistCallbackAll", "()V", "GetUnregistCallbackAllHandler")]
		public virtual unsafe void UnregistCallbackAll ()
		{
			const string __id = "unregistCallbackAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
