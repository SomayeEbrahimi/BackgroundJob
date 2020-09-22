using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Proxy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/interface[@name='ProxyInterceptor']"
	[Register ("com/vivalnk/sdk/common/utils/proxy/ProxyInterceptor", "", "Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptorInvoker")]
	public partial interface IProxyInterceptor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/interface[@name='ProxyInterceptor']/method[@name='onIntercept' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("onIntercept", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z", "GetOnIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler:Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptorInvoker, AndriodBinding")]
		bool OnIntercept (global::Java.Lang.Object p0, global::Java.Lang.Reflect.Method p1, global::Java.Lang.Object[] p2);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/proxy/ProxyInterceptor", DoNotGenerateAcw=true)]
	internal partial class IProxyInterceptorInvoker : global::Java.Lang.Object, IProxyInterceptor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/proxy/ProxyInterceptor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IProxyInterceptorInvoker); }
		}

		IntPtr class_ref;

		public static IProxyInterceptor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProxyInterceptor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProxyInterceptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler ()
		{
			if (cb_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
				cb_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_OnIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_);
			return cb_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		}

		static bool n_OnIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			bool __ret = __this.OnIntercept (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		public unsafe bool OnIntercept (global::Java.Lang.Object p0, global::Java.Lang.Reflect.Method p1, global::Java.Lang.Object[] p2)
		{
			if (id_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onIntercept", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onIntercept_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}

}
