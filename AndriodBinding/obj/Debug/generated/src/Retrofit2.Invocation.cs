using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Retrofit2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='retrofit2']/class[@name='Invocation']"
	[global::Android.Runtime.Register ("retrofit2/Invocation", DoNotGenerateAcw=true)]
	public sealed partial class Invocation : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("retrofit2/Invocation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Invocation); }
		}

		internal Invocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_arguments;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Invocation']/method[@name='arguments' and count(parameter)=0]"
		[Register ("arguments", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<object> Arguments ()
		{
			if (id_arguments == IntPtr.Zero)
				id_arguments = JNIEnv.GetMethodID (class_ref, "arguments", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_arguments), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_method;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Invocation']/method[@name='method' and count(parameter)=0]"
		[Register ("method", "()Ljava/lang/reflect/Method;", "")]
		public unsafe global::Java.Lang.Reflect.Method Method ()
		{
			if (id_method == IntPtr.Zero)
				id_method = JNIEnv.GetMethodID (class_ref, "method", "()Ljava/lang/reflect/Method;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_method), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_of_Ljava_lang_reflect_Method_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Invocation']/method[@name='of' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='java.util.List&lt;?&gt;']]"
		[Register ("of", "(Ljava/lang/reflect/Method;Ljava/util/List;)Lretrofit2/Invocation;", "")]
		public static unsafe global::Retrofit2.Invocation Of (global::Java.Lang.Reflect.Method method, global::System.Collections.Generic.IList<object> arguments)
		{
			if (id_of_Ljava_lang_reflect_Method_Ljava_util_List_ == IntPtr.Zero)
				id_of_Ljava_lang_reflect_Method_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "of", "(Ljava/lang/reflect/Method;Ljava/util/List;)Lretrofit2/Invocation;");
			IntPtr native_arguments = global::Android.Runtime.JavaList<object>.ToLocalJniHandle (arguments);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (method);
				__args [1] = new JValue (native_arguments);
				global::Retrofit2.Invocation __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Invocation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_Ljava_lang_reflect_Method_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_arguments);
			}
		}

	}
}
