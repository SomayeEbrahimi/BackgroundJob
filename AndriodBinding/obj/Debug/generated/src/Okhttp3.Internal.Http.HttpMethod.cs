using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/HttpMethod", DoNotGenerateAcw=true)]
	public sealed partial class HttpMethod : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http/HttpMethod", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpMethod); }
		}

		internal HttpMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_invalidatesCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']/method[@name='invalidatesCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("invalidatesCache", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool InvalidatesCache (string method)
		{
			if (id_invalidatesCache_Ljava_lang_String_ == IntPtr.Zero)
				id_invalidatesCache_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "invalidatesCache", "(Ljava/lang/String;)Z");
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_method);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_invalidatesCache_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		static IntPtr id_permitsRequestBody_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']/method[@name='permitsRequestBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("permitsRequestBody", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool PermitsRequestBody (string method)
		{
			if (id_permitsRequestBody_Ljava_lang_String_ == IntPtr.Zero)
				id_permitsRequestBody_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "permitsRequestBody", "(Ljava/lang/String;)Z");
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_method);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_permitsRequestBody_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		static IntPtr id_redirectsToGet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']/method[@name='redirectsToGet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("redirectsToGet", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool RedirectsToGet (string method)
		{
			if (id_redirectsToGet_Ljava_lang_String_ == IntPtr.Zero)
				id_redirectsToGet_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "redirectsToGet", "(Ljava/lang/String;)Z");
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_method);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_redirectsToGet_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		static IntPtr id_redirectsWithBody_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']/method[@name='redirectsWithBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("redirectsWithBody", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool RedirectsWithBody (string method)
		{
			if (id_redirectsWithBody_Ljava_lang_String_ == IntPtr.Zero)
				id_redirectsWithBody_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "redirectsWithBody", "(Ljava/lang/String;)Z");
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_method);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_redirectsWithBody_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		static IntPtr id_requiresRequestBody_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']/method[@name='requiresRequestBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("requiresRequestBody", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool RequiresRequestBody (string method)
		{
			if (id_requiresRequestBody_Ljava_lang_String_ == IntPtr.Zero)
				id_requiresRequestBody_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "requiresRequestBody", "(Ljava/lang/String;)Z");
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_method);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_requiresRequestBody_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

	}
}
