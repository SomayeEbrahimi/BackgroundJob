using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Proxy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyInvocationHandler']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/proxy/ProxyInvocationHandler", DoNotGenerateAcw=true)]
	public partial class ProxyInvocationHandler : global::Java.Lang.Object, global::Android.OS.Handler.ICallback, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor, global::Java.Lang.Reflect.IInvocationHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/proxy/ProxyInvocationHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProxyInvocationHandler); }
		}

		protected ProxyInvocationHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyInvocationHandler']/constructor[@name='ProxyInvocationHandler' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe ProxyInvocationHandler (global::Java.Lang.Object subject)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (subject);
				if (((object) this).GetType () != typeof (ProxyInvocationHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyInvocationHandler']/constructor[@name='ProxyInvocationHandler' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor']]"
		[Register (".ctor", "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)V", "")]
		public unsafe ProxyInvocationHandler (global::Java.Lang.Object subject, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (subject);
				__args [1] = new JValue (interceptor);
				if (((object) this).GetType () != typeof (ProxyInvocationHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyInvocationHandler']/constructor[@name='ProxyInvocationHandler' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;Z)V", "")]
		public unsafe ProxyInvocationHandler (global::Java.Lang.Object subject, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor, bool weakRef)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (subject);
				__args [1] = new JValue (interceptor);
				__args [2] = new JValue (weakRef);
				if (((object) this).GetType () != typeof (ProxyInvocationHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyInvocationHandler']/constructor[@name='ProxyInvocationHandler' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)V", "")]
		public unsafe ProxyInvocationHandler (global::Java.Lang.Object subject, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor, bool weakRef, bool postUI)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (subject);
				__args [1] = new JValue (interceptor);
				__args [2] = new JValue (weakRef);
				__args [3] = new JValue (postUI);
				if (((object) this).GetType () != typeof (ProxyInvocationHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ, __args);
			} finally {
			}
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Proxy.ProxyInvocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (msg);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyInvocationHandler']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message msg)
		{
			if (id_handleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_handleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/os/Message;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (msg);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleMessage_Landroid_os_Message_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMessage", "(Landroid/os/Message;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler ()
		{
			if (cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
				cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_);
			return cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		}

		static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_proxy, IntPtr native_method, IntPtr native_args)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Proxy.ProxyInvocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var proxy = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_proxy, JniHandleOwnership.DoNotTransfer);
			var method = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (native_method, JniHandleOwnership.DoNotTransfer);
			var args = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (proxy, method, args));
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyInvocationHandler']/method[@name='invoke' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Invoke (global::Java.Lang.Object proxy, global::Java.Lang.Reflect.Method method, global::Java.Lang.Object[] args)
		{
			if (id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (proxy);
				__args [1] = new JValue (method);
				__args [2] = new JValue (native_args);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static Delegate cb_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler ()
		{
			if (cb_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
				cb_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_OnIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_);
			return cb_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		}

		static bool n_OnIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object, IntPtr native_method, IntPtr native_args)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Proxy.ProxyInvocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			var method = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (native_method, JniHandleOwnership.DoNotTransfer);
			var args = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			bool __ret = __this.OnIntercept (@object, method, args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyInvocationHandler']/method[@name='onIntercept' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("onIntercept", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z", "GetOnIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
		public virtual unsafe bool OnIntercept (global::Java.Lang.Object @object, global::Java.Lang.Reflect.Method method, global::Java.Lang.Object[] args)
		{
			if (id_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onIntercept", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (method);
				__args [2] = new JValue (native_args);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onIntercept", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

	}
}
