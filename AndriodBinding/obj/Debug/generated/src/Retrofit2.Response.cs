using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Retrofit2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='retrofit2']/class[@name='Response']"
	[global::Android.Runtime.Register ("retrofit2/Response", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class Response : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("retrofit2/Response", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Response); }
		}

		internal Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isSuccessful;
		public unsafe bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "")]
			get {
				if (id_isSuccessful == IntPtr.Zero)
					id_isSuccessful = JNIEnv.GetMethodID (class_ref, "isSuccessful", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuccessful);
				} finally {
				}
			}
		}

		static IntPtr id_body;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='body' and count(parameter)=0]"
		[Register ("body", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Body ()
		{
			if (id_body == IntPtr.Zero)
				id_body = JNIEnv.GetMethodID (class_ref, "body", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_body), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_code;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='code' and count(parameter)=0]"
		[Register ("code", "()I", "")]
		public unsafe int Code ()
		{
			if (id_code == IntPtr.Zero)
				id_code = JNIEnv.GetMethodID (class_ref, "code", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_code);
			} finally {
			}
		}

		static IntPtr id_error_ILokhttp3_ResponseBody_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='error' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='okhttp3.ResponseBody']]"
		[Register ("error", "(ILokhttp3/ResponseBody;)Lretrofit2/Response;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Retrofit2.Response Error (int code, global::Okhttp3.ResponseBody body)
		{
			if (id_error_ILokhttp3_ResponseBody_ == IntPtr.Zero)
				id_error_ILokhttp3_ResponseBody_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(ILokhttp3/ResponseBody;)Lretrofit2/Response;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (code);
				__args [1] = new JValue (body);
				global::Retrofit2.Response __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_ILokhttp3_ResponseBody_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_error_Lokhttp3_ResponseBody_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='error' and count(parameter)=2 and parameter[1][@type='okhttp3.ResponseBody'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("error", "(Lokhttp3/ResponseBody;Lokhttp3/Response;)Lretrofit2/Response;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Retrofit2.Response Error (global::Okhttp3.ResponseBody body, global::Okhttp3.Response rawResponse)
		{
			if (id_error_Lokhttp3_ResponseBody_Lokhttp3_Response_ == IntPtr.Zero)
				id_error_Lokhttp3_ResponseBody_Lokhttp3_Response_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Lokhttp3/ResponseBody;Lokhttp3/Response;)Lretrofit2/Response;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (body);
				__args [1] = new JValue (rawResponse);
				global::Retrofit2.Response __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Lokhttp3_ResponseBody_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_errorBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='errorBody' and count(parameter)=0]"
		[Register ("errorBody", "()Lokhttp3/ResponseBody;", "")]
		public unsafe global::Okhttp3.ResponseBody ErrorBody ()
		{
			if (id_errorBody == IntPtr.Zero)
				id_errorBody = JNIEnv.GetMethodID (class_ref, "errorBody", "()Lokhttp3/ResponseBody;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_errorBody), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_headers;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='headers' and count(parameter)=0]"
		[Register ("headers", "()Lokhttp3/Headers;", "")]
		public unsafe global::Okhttp3.Headers Headers ()
		{
			if (id_headers == IntPtr.Zero)
				id_headers = JNIEnv.GetMethodID (class_ref, "headers", "()Lokhttp3/Headers;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headers), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_message;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='message' and count(parameter)=0]"
		[Register ("message", "()Ljava/lang/String;", "")]
		public unsafe string Message ()
		{
			if (id_message == IntPtr.Zero)
				id_message = JNIEnv.GetMethodID (class_ref, "message", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_message), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_raw;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='raw' and count(parameter)=0]"
		[Register ("raw", "()Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response Raw ()
		{
			if (id_raw == IntPtr.Zero)
				id_raw = JNIEnv.GetMethodID (class_ref, "raw", "()Lokhttp3/Response;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_raw), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_success_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='success' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("success", "(ILjava/lang/Object;)Lretrofit2/Response;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Retrofit2.Response Success (int code, global::Java.Lang.Object body)
		{
			if (id_success_ILjava_lang_Object_ == IntPtr.Zero)
				id_success_ILjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "success", "(ILjava/lang/Object;)Lretrofit2/Response;");
			IntPtr native_body = JNIEnv.ToLocalJniHandle (body);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (code);
				__args [1] = new JValue (native_body);
				global::Retrofit2.Response __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_success_ILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_body);
			}
		}

		static IntPtr id_success_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='success' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("success", "(Ljava/lang/Object;)Lretrofit2/Response;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Retrofit2.Response Success (global::Java.Lang.Object body)
		{
			if (id_success_Ljava_lang_Object_ == IntPtr.Zero)
				id_success_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "success", "(Ljava/lang/Object;)Lretrofit2/Response;");
			IntPtr native_body = JNIEnv.ToLocalJniHandle (body);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_body);
				global::Retrofit2.Response __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_success_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_body);
			}
		}

		static IntPtr id_success_Ljava_lang_Object_Lokhttp3_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='success' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='okhttp3.Headers']]"
		[Register ("success", "(Ljava/lang/Object;Lokhttp3/Headers;)Lretrofit2/Response;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Retrofit2.Response Success (global::Java.Lang.Object body, global::Okhttp3.Headers headers)
		{
			if (id_success_Ljava_lang_Object_Lokhttp3_Headers_ == IntPtr.Zero)
				id_success_Ljava_lang_Object_Lokhttp3_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "success", "(Ljava/lang/Object;Lokhttp3/Headers;)Lretrofit2/Response;");
			IntPtr native_body = JNIEnv.ToLocalJniHandle (body);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_body);
				__args [1] = new JValue (headers);
				global::Retrofit2.Response __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_success_Ljava_lang_Object_Lokhttp3_Headers_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_body);
			}
		}

		static IntPtr id_success_Ljava_lang_Object_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Response']/method[@name='success' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("success", "(Ljava/lang/Object;Lokhttp3/Response;)Lretrofit2/Response;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Retrofit2.Response Success (global::Java.Lang.Object body, global::Okhttp3.Response rawResponse)
		{
			if (id_success_Ljava_lang_Object_Lokhttp3_Response_ == IntPtr.Zero)
				id_success_Ljava_lang_Object_Lokhttp3_Response_ = JNIEnv.GetStaticMethodID (class_ref, "success", "(Ljava/lang/Object;Lokhttp3/Response;)Lretrofit2/Response;");
			IntPtr native_body = JNIEnv.ToLocalJniHandle (body);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_body);
				__args [1] = new JValue (rawResponse);
				global::Retrofit2.Response __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_success_Ljava_lang_Object_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_body);
			}
		}

	}
}
