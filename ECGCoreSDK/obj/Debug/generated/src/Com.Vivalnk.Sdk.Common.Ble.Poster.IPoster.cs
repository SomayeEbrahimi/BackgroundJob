using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Ble.Poster {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/interface[@name='Poster']"
	[Register ("com/vivalnk/sdk/common/ble/poster/Poster", "", "Com.Vivalnk.Sdk.Common.Ble.Poster.IPosterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IPoster : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/interface[@name='Poster']/method[@name='registCallback' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("registCallback", "(Ljava/lang/Object;)V", "GetRegistCallback_Ljava_lang_Object_Handler:Com.Vivalnk.Sdk.Common.Ble.Poster.IPosterInvoker, ECGCoreSDK")]
		void RegistCallback (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/interface[@name='Poster']/method[@name='setHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("setHandler", "(Landroid/os/Handler;)V", "GetSetHandler_Landroid_os_Handler_Handler:Com.Vivalnk.Sdk.Common.Ble.Poster.IPosterInvoker, ECGCoreSDK")]
		void SetHandler (global::Android.OS.Handler p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/interface[@name='Poster']/method[@name='unregistCallback' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("unregistCallback", "(Ljava/lang/Object;)V", "GetUnregistCallback_Ljava_lang_Object_Handler:Com.Vivalnk.Sdk.Common.Ble.Poster.IPosterInvoker, ECGCoreSDK")]
		void UnregistCallback (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.poster']/interface[@name='Poster']/method[@name='unregistCallbackAll' and count(parameter)=0]"
		[Register ("unregistCallbackAll", "()V", "GetUnregistCallbackAllHandler:Com.Vivalnk.Sdk.Common.Ble.Poster.IPosterInvoker, ECGCoreSDK")]
		void UnregistCallbackAll ();

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/poster/Poster", DoNotGenerateAcw=true)]
	internal partial class IPosterInvoker : global::Java.Lang.Object, IPoster {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/ble/poster/Poster", typeof (IPosterInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPoster GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPoster> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.ble.poster.Poster"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPosterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_registCallback_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRegistCallback_Ljava_lang_Object_Handler ()
		{
			if (cb_registCallback_Ljava_lang_Object_ == null)
				cb_registCallback_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegistCallback_Ljava_lang_Object_);
			return cb_registCallback_Ljava_lang_Object_;
		}

		static void n_RegistCallback_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Poster.IPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegistCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_registCallback_Ljava_lang_Object_;
		public unsafe void RegistCallback (global::Java.Lang.Object p0)
		{
			if (id_registCallback_Ljava_lang_Object_ == IntPtr.Zero)
				id_registCallback_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "registCallback", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registCallback_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setHandler_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetSetHandler_Landroid_os_Handler_Handler ()
		{
			if (cb_setHandler_Landroid_os_Handler_ == null)
				cb_setHandler_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHandler_Landroid_os_Handler_);
			return cb_setHandler_Landroid_os_Handler_;
		}

		static void n_SetHandler_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Poster.IPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHandler (p0);
		}
#pragma warning restore 0169

		IntPtr id_setHandler_Landroid_os_Handler_;
		public unsafe void SetHandler (global::Android.OS.Handler p0)
		{
			if (id_setHandler_Landroid_os_Handler_ == IntPtr.Zero)
				id_setHandler_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "setHandler", "(Landroid/os/Handler;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHandler_Landroid_os_Handler_, __args);
		}

		static Delegate cb_unregistCallback_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUnregistCallback_Ljava_lang_Object_Handler ()
		{
			if (cb_unregistCallback_Ljava_lang_Object_ == null)
				cb_unregistCallback_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UnregistCallback_Ljava_lang_Object_);
			return cb_unregistCallback_Ljava_lang_Object_;
		}

		static void n_UnregistCallback_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Poster.IPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregistCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregistCallback_Ljava_lang_Object_;
		public unsafe void UnregistCallback (global::Java.Lang.Object p0)
		{
			if (id_unregistCallback_Ljava_lang_Object_ == IntPtr.Zero)
				id_unregistCallback_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "unregistCallback", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregistCallback_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Ble.Poster.IPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregistCallbackAll ();
		}
#pragma warning restore 0169

		IntPtr id_unregistCallbackAll;
		public unsafe void UnregistCallbackAll ()
		{
			if (id_unregistCallbackAll == IntPtr.Zero)
				id_unregistCallbackAll = JNIEnv.GetMethodID (class_ref, "unregistCallbackAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregistCallbackAll);
		}

	}

}
