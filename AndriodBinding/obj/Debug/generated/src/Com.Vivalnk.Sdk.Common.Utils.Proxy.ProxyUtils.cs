using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Proxy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/proxy/ProxyUtils", DoNotGenerateAcw=true)]
	public partial class ProxyUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/proxy/ProxyUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProxyUtils); }
		}

		protected ProxyUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/constructor[@name='ProxyUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProxyUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ProxyUtils)) {
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

		static IntPtr id_getProxy_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getProxy' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor']]"
		[Register ("getProxy", "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetProxy (global::Java.Lang.Object @object, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor)
		{
			if (id_getProxy_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ == IntPtr.Zero)
				id_getProxy_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ = JNIEnv.GetStaticMethodID (class_ref, "getProxy", "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (interceptor);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProxy_Ljava_lang_Object_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getProxy' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor']]"
		[Register ("getProxy", "(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetProxy (global::Java.Lang.Object @object, global::Java.Lang.Class clazz, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor)
		{
			if (id_getProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ == IntPtr.Zero)
				id_getProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ = JNIEnv.GetStaticMethodID (class_ref, "getProxy", "(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (clazz);
				__args [2] = new JValue (interceptor);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getProxy' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("getProxy", "(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetProxy (global::Java.Lang.Object @object, global::Java.Lang.Class clazz, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor, bool weakRef, bool postUI)
		{
			if (id_getProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ == IntPtr.Zero)
				id_getProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ = JNIEnv.GetStaticMethodID (class_ref, "getProxy", "(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (clazz);
				__args [2] = new JValue (interceptor);
				__args [3] = new JValue (weakRef);
				__args [4] = new JValue (postUI);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getProxy_Ljava_lang_Object_arrayLjava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getProxy' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;[]'] and parameter[3][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("getProxy", "(Ljava/lang/Object;[Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetProxy (global::Java.Lang.Object @object, global::Java.Lang.Class[] intfs, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor, bool weakRef, bool postUI)
		{
			if (id_getProxy_Ljava_lang_Object_arrayLjava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ == IntPtr.Zero)
				id_getProxy_Ljava_lang_Object_arrayLjava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ = JNIEnv.GetStaticMethodID (class_ref, "getProxy", "(Ljava/lang/Object;[Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)Ljava/lang/Object;");
			IntPtr native_intfs = JNIEnv.NewArray (intfs);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_intfs);
				__args [2] = new JValue (interceptor);
				__args [3] = new JValue (weakRef);
				__args [4] = new JValue (postUI);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProxy_Ljava_lang_Object_arrayLjava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (intfs != null) {
					JNIEnv.CopyArray (native_intfs, intfs);
					JNIEnv.DeleteLocalRef (native_intfs);
				}
			}
		}

		static IntPtr id_getUIProxy_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getUIProxy' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getUIProxy", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetUIProxy (global::Java.Lang.Object @object)
		{
			if (id_getUIProxy_Ljava_lang_Object_ == IntPtr.Zero)
				id_getUIProxy_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getUIProxy", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUIProxy_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUIProxy_Ljava_lang_Object_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getUIProxy' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getUIProxy", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetUIProxy (global::Java.Lang.Object @object, global::Java.Lang.Class clazz)
		{
			if (id_getUIProxy_Ljava_lang_Object_Ljava_lang_Class_ == IntPtr.Zero)
				id_getUIProxy_Ljava_lang_Object_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getUIProxy", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (clazz);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUIProxy_Ljava_lang_Object_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUIProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getUIProxy' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor']]"
		[Register ("getUIProxy", "(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetUIProxy (global::Java.Lang.Object @object, global::Java.Lang.Class clazz, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor)
		{
			if (id_getUIProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ == IntPtr.Zero)
				id_getUIProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ = JNIEnv.GetStaticMethodID (class_ref, "getUIProxy", "(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (clazz);
				__args [2] = new JValue (interceptor);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUIProxy_Ljava_lang_Object_Ljava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUIProxy_Ljava_lang_Object_arrayLjava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getUIProxy' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;[]'] and parameter[3][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor']]"
		[Register ("getUIProxy", "(Ljava/lang/Object;[Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetUIProxy (global::Java.Lang.Object @object, global::Java.Lang.Class[] intfs, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor)
		{
			if (id_getUIProxy_Ljava_lang_Object_arrayLjava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ == IntPtr.Zero)
				id_getUIProxy_Ljava_lang_Object_arrayLjava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_ = JNIEnv.GetStaticMethodID (class_ref, "getUIProxy", "(Ljava/lang/Object;[Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;");
			IntPtr native_intfs = JNIEnv.NewArray (intfs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_intfs);
				__args [2] = new JValue (interceptor);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUIProxy_Ljava_lang_Object_arrayLjava_lang_Class_Lcom_vivalnk_sdk_common_utils_proxy_ProxyInterceptor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (intfs != null) {
					JNIEnv.CopyArray (native_intfs, intfs);
					JNIEnv.DeleteLocalRef (native_intfs);
				}
			}
		}

		static IntPtr id_getWeakUIProxy_Ljava_lang_Object_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getWeakUIProxy' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getWeakUIProxy", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetWeakUIProxy (global::Java.Lang.Object @object, global::Java.Lang.Class clazz)
		{
			if (id_getWeakUIProxy_Ljava_lang_Object_Ljava_lang_Class_ == IntPtr.Zero)
				id_getWeakUIProxy_Ljava_lang_Object_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getWeakUIProxy", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (clazz);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getWeakUIProxy_Ljava_lang_Object_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
