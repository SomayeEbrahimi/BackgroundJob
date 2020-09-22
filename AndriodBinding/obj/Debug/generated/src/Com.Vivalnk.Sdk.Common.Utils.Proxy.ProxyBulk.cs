using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Proxy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyBulk']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/proxy/ProxyBulk", DoNotGenerateAcw=true)]
	public partial class ProxyBulk : global::Java.Lang.Object {


		static IntPtr args_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyBulk']/field[@name='args']"
		[Register ("args")]
		public IList<Java.Lang.Object> Args {
			get {
				if (args_jfieldId == IntPtr.Zero)
					args_jfieldId = JNIEnv.GetFieldID (class_ref, "args", "[Ljava/lang/Object;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Object>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, args_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (args_jfieldId == IntPtr.Zero)
					args_jfieldId = JNIEnv.GetFieldID (class_ref, "args", "[Ljava/lang/Object;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, args_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr method_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyBulk']/field[@name='method']"
		[Register ("method")]
		public global::Java.Lang.Reflect.Method Method {
			get {
				if (method_jfieldId == IntPtr.Zero)
					method_jfieldId = JNIEnv.GetFieldID (class_ref, "method", "Ljava/lang/reflect/Method;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, method_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (method_jfieldId == IntPtr.Zero)
					method_jfieldId = JNIEnv.GetFieldID (class_ref, "method", "Ljava/lang/reflect/Method;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, method_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr object_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyBulk']/field[@name='object']"
		[Register ("object")]
		public global::Java.Lang.Object Object {
			get {
				if (object_jfieldId == IntPtr.Zero)
					object_jfieldId = JNIEnv.GetFieldID (class_ref, "object", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, object_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (object_jfieldId == IntPtr.Zero)
					object_jfieldId = JNIEnv.GetFieldID (class_ref, "object", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, object_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/proxy/ProxyBulk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProxyBulk); }
		}

		protected ProxyBulk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyBulk']/constructor[@name='ProxyBulk' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)V", "")]
		public unsafe ProxyBulk (global::Java.Lang.Object @object, global::Java.Lang.Reflect.Method method, global::Java.Lang.Object[] args)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (method);
				__args [2] = new JValue (native_args);
				if (((object) this).GetType () != typeof (ProxyBulk)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, __args);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static Delegate cb_safeInvoke;
#pragma warning disable 0169
		static Delegate GetSafeInvokeHandler ()
		{
			if (cb_safeInvoke == null)
				cb_safeInvoke = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SafeInvoke);
			return cb_safeInvoke;
		}

		static IntPtr n_SafeInvoke (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Proxy.ProxyBulk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SafeInvoke ());
		}
#pragma warning restore 0169

		static IntPtr id_safeInvoke;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyBulk']/method[@name='safeInvoke' and count(parameter)=0]"
		[Register ("safeInvoke", "()Ljava/lang/Object;", "GetSafeInvokeHandler")]
		public virtual unsafe global::Java.Lang.Object SafeInvoke ()
		{
			if (id_safeInvoke == IntPtr.Zero)
				id_safeInvoke = JNIEnv.GetMethodID (class_ref, "safeInvoke", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_safeInvoke), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "safeInvoke", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_safeInvoke_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyBulk']/method[@name='safeInvoke' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("safeInvoke", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object SafeInvoke (global::Java.Lang.Object obj)
		{
			if (id_safeInvoke_Ljava_lang_Object_ == IntPtr.Zero)
				id_safeInvoke_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "safeInvoke", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_safeInvoke_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
