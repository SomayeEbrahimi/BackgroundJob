using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Hook {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook']/class[@name='BluetoothManagerProxyHandler']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/hook/BluetoothManagerProxyHandler", DoNotGenerateAcw=true)]
	public partial class BluetoothManagerProxyHandler : global::Java.Lang.Object, global::Java.Lang.Reflect.IInvocationHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/hook/BluetoothManagerProxyHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BluetoothManagerProxyHandler); }
		}

		protected BluetoothManagerProxyHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Hook.BluetoothManagerProxyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook']/class[@name='BluetoothManagerProxyHandler']/method[@name='invoke' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
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

	}
}
