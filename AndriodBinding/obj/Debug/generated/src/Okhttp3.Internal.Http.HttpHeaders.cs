using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/HttpHeaders", DoNotGenerateAcw=true)]
	public sealed partial class HttpHeaders : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http/HttpHeaders", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpHeaders); }
		}

		internal HttpHeaders (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_contentLength_Lokhttp3_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='contentLength' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("contentLength", "(Lokhttp3/Headers;)J", "")]
		public static unsafe long ContentLength (global::Okhttp3.Headers headers)
		{
			if (id_contentLength_Lokhttp3_Headers_ == IntPtr.Zero)
				id_contentLength_Lokhttp3_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "contentLength", "(Lokhttp3/Headers;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (headers);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_contentLength_Lokhttp3_Headers_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_contentLength_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='contentLength' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("contentLength", "(Lokhttp3/Response;)J", "")]
		public static unsafe long ContentLength (global::Okhttp3.Response response)
		{
			if (id_contentLength_Lokhttp3_Response_ == IntPtr.Zero)
				id_contentLength_Lokhttp3_Response_ = JNIEnv.GetStaticMethodID (class_ref, "contentLength", "(Lokhttp3/Response;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_contentLength_Lokhttp3_Response_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hasBody_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='hasBody' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("hasBody", "(Lokhttp3/Response;)Z", "")]
		public static unsafe bool HasBody (global::Okhttp3.Response response)
		{
			if (id_hasBody_Lokhttp3_Response_ == IntPtr.Zero)
				id_hasBody_Lokhttp3_Response_ = JNIEnv.GetStaticMethodID (class_ref, "hasBody", "(Lokhttp3/Response;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasBody_Lokhttp3_Response_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hasVaryAll_Lokhttp3_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='hasVaryAll' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("hasVaryAll", "(Lokhttp3/Headers;)Z", "")]
		public static unsafe bool HasVaryAll (global::Okhttp3.Headers responseHeaders)
		{
			if (id_hasVaryAll_Lokhttp3_Headers_ == IntPtr.Zero)
				id_hasVaryAll_Lokhttp3_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "hasVaryAll", "(Lokhttp3/Headers;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (responseHeaders);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasVaryAll_Lokhttp3_Headers_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hasVaryAll_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='hasVaryAll' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("hasVaryAll", "(Lokhttp3/Response;)Z", "")]
		public static unsafe bool HasVaryAll (global::Okhttp3.Response response)
		{
			if (id_hasVaryAll_Lokhttp3_Response_ == IntPtr.Zero)
				id_hasVaryAll_Lokhttp3_Response_ = JNIEnv.GetStaticMethodID (class_ref, "hasVaryAll", "(Lokhttp3/Response;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasVaryAll_Lokhttp3_Response_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseChallenges_Lokhttp3_Headers_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='parseChallenges' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='java.lang.String']]"
		[Register ("parseChallenges", "(Lokhttp3/Headers;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Okhttp3.Challenge> ParseChallenges (global::Okhttp3.Headers responseHeaders, string headerName)
		{
			if (id_parseChallenges_Lokhttp3_Headers_Ljava_lang_String_ == IntPtr.Zero)
				id_parseChallenges_Lokhttp3_Headers_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseChallenges", "(Lokhttp3/Headers;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_headerName = JNIEnv.NewString (headerName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (responseHeaders);
				__args [1] = new JValue (native_headerName);
				global::System.Collections.Generic.IList<global::Okhttp3.Challenge> __ret = global::Android.Runtime.JavaList<global::Okhttp3.Challenge>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseChallenges_Lokhttp3_Headers_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_headerName);
			}
		}

		static IntPtr id_parseSeconds_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='parseSeconds' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("parseSeconds", "(Ljava/lang/String;I)I", "")]
		public static unsafe int ParseSeconds (string value, int defaultValue)
		{
			if (id_parseSeconds_Ljava_lang_String_I == IntPtr.Zero)
				id_parseSeconds_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "parseSeconds", "(Ljava/lang/String;I)I");
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_value);
				__args [1] = new JValue (defaultValue);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseSeconds_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_receiveHeaders_Lokhttp3_CookieJar_Lokhttp3_HttpUrl_Lokhttp3_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='receiveHeaders' and count(parameter)=3 and parameter[1][@type='okhttp3.CookieJar'] and parameter[2][@type='okhttp3.HttpUrl'] and parameter[3][@type='okhttp3.Headers']]"
		[Register ("receiveHeaders", "(Lokhttp3/CookieJar;Lokhttp3/HttpUrl;Lokhttp3/Headers;)V", "")]
		public static unsafe void ReceiveHeaders (global::Okhttp3.ICookieJar cookieJar, global::Okhttp3.HttpUrl url, global::Okhttp3.Headers headers)
		{
			if (id_receiveHeaders_Lokhttp3_CookieJar_Lokhttp3_HttpUrl_Lokhttp3_Headers_ == IntPtr.Zero)
				id_receiveHeaders_Lokhttp3_CookieJar_Lokhttp3_HttpUrl_Lokhttp3_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "receiveHeaders", "(Lokhttp3/CookieJar;Lokhttp3/HttpUrl;Lokhttp3/Headers;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cookieJar);
				__args [1] = new JValue (url);
				__args [2] = new JValue (headers);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_receiveHeaders_Lokhttp3_CookieJar_Lokhttp3_HttpUrl_Lokhttp3_Headers_, __args);
			} finally {
			}
		}

		static IntPtr id_skipUntil_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='skipUntil' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("skipUntil", "(Ljava/lang/String;ILjava/lang/String;)I", "")]
		public static unsafe int SkipUntil (string input, int pos, string characters)
		{
			if (id_skipUntil_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_skipUntil_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "skipUntil", "(Ljava/lang/String;ILjava/lang/String;)I");
			IntPtr native_input = JNIEnv.NewString (input);
			IntPtr native_characters = JNIEnv.NewString (characters);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (pos);
				__args [2] = new JValue (native_characters);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_skipUntil_Ljava_lang_String_ILjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_characters);
			}
		}

		static IntPtr id_skipWhitespace_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='skipWhitespace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("skipWhitespace", "(Ljava/lang/String;I)I", "")]
		public static unsafe int SkipWhitespace (string input, int pos)
		{
			if (id_skipWhitespace_Ljava_lang_String_I == IntPtr.Zero)
				id_skipWhitespace_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "skipWhitespace", "(Ljava/lang/String;I)I");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (pos);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_skipWhitespace_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_varyFields_Lokhttp3_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='varyFields' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("varyFields", "(Lokhttp3/Headers;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> VaryFields (global::Okhttp3.Headers responseHeaders)
		{
			if (id_varyFields_Lokhttp3_Headers_ == IntPtr.Zero)
				id_varyFields_Lokhttp3_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "varyFields", "(Lokhttp3/Headers;)Ljava/util/Set;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (responseHeaders);
				global::System.Collections.Generic.ICollection<string> __ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_varyFields_Lokhttp3_Headers_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_varyHeaders_Lokhttp3_Headers_Lokhttp3_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='varyHeaders' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='okhttp3.Headers']]"
		[Register ("varyHeaders", "(Lokhttp3/Headers;Lokhttp3/Headers;)Lokhttp3/Headers;", "")]
		public static unsafe global::Okhttp3.Headers VaryHeaders (global::Okhttp3.Headers requestHeaders, global::Okhttp3.Headers responseHeaders)
		{
			if (id_varyHeaders_Lokhttp3_Headers_Lokhttp3_Headers_ == IntPtr.Zero)
				id_varyHeaders_Lokhttp3_Headers_Lokhttp3_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "varyHeaders", "(Lokhttp3/Headers;Lokhttp3/Headers;)Lokhttp3/Headers;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (requestHeaders);
				__args [1] = new JValue (responseHeaders);
				global::Okhttp3.Headers __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallStaticObjectMethod  (class_ref, id_varyHeaders_Lokhttp3_Headers_Lokhttp3_Headers_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_varyHeaders_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='varyHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("varyHeaders", "(Lokhttp3/Response;)Lokhttp3/Headers;", "")]
		public static unsafe global::Okhttp3.Headers VaryHeaders (global::Okhttp3.Response response)
		{
			if (id_varyHeaders_Lokhttp3_Response_ == IntPtr.Zero)
				id_varyHeaders_Lokhttp3_Response_ = JNIEnv.GetStaticMethodID (class_ref, "varyHeaders", "(Lokhttp3/Response;)Lokhttp3/Headers;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				global::Okhttp3.Headers __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallStaticObjectMethod  (class_ref, id_varyHeaders_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_varyMatches_Lokhttp3_Response_Lokhttp3_Headers_Lokhttp3_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='varyMatches' and count(parameter)=3 and parameter[1][@type='okhttp3.Response'] and parameter[2][@type='okhttp3.Headers'] and parameter[3][@type='okhttp3.Request']]"
		[Register ("varyMatches", "(Lokhttp3/Response;Lokhttp3/Headers;Lokhttp3/Request;)Z", "")]
		public static unsafe bool VaryMatches (global::Okhttp3.Response cachedResponse, global::Okhttp3.Headers cachedRequest, global::Okhttp3.Request newRequest)
		{
			if (id_varyMatches_Lokhttp3_Response_Lokhttp3_Headers_Lokhttp3_Request_ == IntPtr.Zero)
				id_varyMatches_Lokhttp3_Response_Lokhttp3_Headers_Lokhttp3_Request_ = JNIEnv.GetStaticMethodID (class_ref, "varyMatches", "(Lokhttp3/Response;Lokhttp3/Headers;Lokhttp3/Request;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cachedResponse);
				__args [1] = new JValue (cachedRequest);
				__args [2] = new JValue (newRequest);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_varyMatches_Lokhttp3_Response_Lokhttp3_Headers_Lokhttp3_Request_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
