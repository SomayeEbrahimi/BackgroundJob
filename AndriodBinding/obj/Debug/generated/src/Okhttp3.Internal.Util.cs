using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']"
	[global::Android.Runtime.Register ("okhttp3/internal/Util", DoNotGenerateAcw=true)]
	public sealed partial class Util : global::Java.Lang.Object {


		static IntPtr EMPTY_BYTE_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='EMPTY_BYTE_ARRAY']"
		[Register ("EMPTY_BYTE_ARRAY")]
		public static IList<byte> EmptyByteArray {
			get {
				if (EMPTY_BYTE_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_BYTE_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_BYTE_ARRAY", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_BYTE_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_HEADERS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='EMPTY_HEADERS']"
		[Register ("EMPTY_HEADERS")]
		public static global::Okhttp3.Headers EmptyHeaders {
			get {
				if (EMPTY_HEADERS_jfieldId == IntPtr.Zero)
					EMPTY_HEADERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_HEADERS", "Lokhttp3/Headers;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_HEADERS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_REQUEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='EMPTY_REQUEST']"
		[Register ("EMPTY_REQUEST")]
		public static global::Okhttp3.RequestBody EmptyRequest {
			get {
				if (EMPTY_REQUEST_jfieldId == IntPtr.Zero)
					EMPTY_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_REQUEST", "Lokhttp3/RequestBody;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_REQUEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_RESPONSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='EMPTY_RESPONSE']"
		[Register ("EMPTY_RESPONSE")]
		public static global::Okhttp3.ResponseBody EmptyResponse {
			get {
				if (EMPTY_RESPONSE_jfieldId == IntPtr.Zero)
					EMPTY_RESPONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_RESPONSE", "Lokhttp3/ResponseBody;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_RESPONSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_STRING_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='EMPTY_STRING_ARRAY']"
		[Register ("EMPTY_STRING_ARRAY")]
		public static IList<string> EmptyStringArray {
			get {
				if (EMPTY_STRING_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_STRING_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_STRING_ARRAY", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_STRING_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NATURAL_ORDER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='NATURAL_ORDER']"
		[Register ("NATURAL_ORDER")]
		public static global::Java.Util.IComparator NaturalOrder {
			get {
				if (NATURAL_ORDER_jfieldId == IntPtr.Zero)
					NATURAL_ORDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NATURAL_ORDER", "Ljava/util/Comparator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NATURAL_ORDER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UTC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/field[@name='UTC']"
		[Register ("UTC")]
		public static global::Java.Util.TimeZone Utc {
			get {
				if (UTC_jfieldId == IntPtr.Zero)
					UTC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTC", "Ljava/util/TimeZone;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UTC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		internal Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_addSuppressedIfPossible_Ljava_lang_Throwable_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='addSuppressedIfPossible' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("addSuppressedIfPossible", "(Ljava/lang/Throwable;Ljava/lang/Throwable;)V", "")]
		public static unsafe void AddSuppressedIfPossible (global::Java.Lang.Throwable e, global::Java.Lang.Throwable suppressed)
		{
			if (id_addSuppressedIfPossible_Ljava_lang_Throwable_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_addSuppressedIfPossible_Ljava_lang_Throwable_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "addSuppressedIfPossible", "(Ljava/lang/Throwable;Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (e);
				__args [1] = new JValue (suppressed);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addSuppressedIfPossible_Ljava_lang_Throwable_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_canonicalizeHost_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='canonicalizeHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("canonicalizeHost", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CanonicalizeHost (string host)
		{
			if (id_canonicalizeHost_Ljava_lang_String_ == IntPtr.Zero)
				id_canonicalizeHost_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "canonicalizeHost", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_host);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_canonicalizeHost_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		static IntPtr id_checkDuration_Ljava_lang_String_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='checkDuration' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("checkDuration", "(Ljava/lang/String;JLjava/util/concurrent/TimeUnit;)I", "")]
		public static unsafe int CheckDuration (string name, long duration, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_checkDuration_Ljava_lang_String_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_checkDuration_Ljava_lang_String_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "checkDuration", "(Ljava/lang/String;JLjava/util/concurrent/TimeUnit;)I");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (duration);
				__args [2] = new JValue (unit);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_checkDuration_Ljava_lang_String_JLjava_util_concurrent_TimeUnit_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_checkOffsetAndCount_JJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='checkOffsetAndCount' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("checkOffsetAndCount", "(JJJ)V", "")]
		public static unsafe void CheckOffsetAndCount (long arrayLength, long offset, long count)
		{
			if (id_checkOffsetAndCount_JJJ == IntPtr.Zero)
				id_checkOffsetAndCount_JJJ = JNIEnv.GetStaticMethodID (class_ref, "checkOffsetAndCount", "(JJJ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (arrayLength);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (count);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkOffsetAndCount_JJJ, __args);
			} finally {
			}
		}

		static IntPtr id_closeQuietly_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseQuietly (global::Java.IO.ICloseable closeable)
		{
			if (id_closeQuietly_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeQuietly_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "(Ljava/io/Closeable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (closeable);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_Ljava_io_Closeable_, __args);
			} finally {
			}
		}

		static IntPtr id_closeQuietly_Ljava_net_ServerSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.net.ServerSocket']]"
		[Register ("closeQuietly", "(Ljava/net/ServerSocket;)V", "")]
		public static unsafe void CloseQuietly (global::Java.Net.ServerSocket serverSocket)
		{
			if (id_closeQuietly_Ljava_net_ServerSocket_ == IntPtr.Zero)
				id_closeQuietly_Ljava_net_ServerSocket_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "(Ljava/net/ServerSocket;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (serverSocket);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_Ljava_net_ServerSocket_, __args);
			} finally {
			}
		}

		static IntPtr id_closeQuietly_Ljava_net_Socket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("closeQuietly", "(Ljava/net/Socket;)V", "")]
		public static unsafe void CloseQuietly (global::Java.Net.Socket socket)
		{
			if (id_closeQuietly_Ljava_net_Socket_ == IntPtr.Zero)
				id_closeQuietly_Ljava_net_Socket_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "(Ljava/net/Socket;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (socket);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_Ljava_net_Socket_, __args);
			} finally {
			}
		}

		static IntPtr id_concat_arrayLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='concat' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("concat", "([Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] Concat (string[] array, string value)
		{
			if (id_concat_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_concat_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "concat", "([Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_value);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_concat_arrayLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_decodeHexDigit_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='decodeHexDigit' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("decodeHexDigit", "(C)I", "")]
		public static unsafe int DecodeHexDigit (char c)
		{
			if (id_decodeHexDigit_C == IntPtr.Zero)
				id_decodeHexDigit_C = JNIEnv.GetStaticMethodID (class_ref, "decodeHexDigit", "(C)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (c);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_decodeHexDigit_C, __args);
			} finally {
			}
		}

		static IntPtr id_delimiterOffset_Ljava_lang_String_IIC;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='delimiterOffset' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='char']]"
		[Register ("delimiterOffset", "(Ljava/lang/String;IIC)I", "")]
		public static unsafe int DelimiterOffset (string input, int pos, int limit, char delimiter)
		{
			if (id_delimiterOffset_Ljava_lang_String_IIC == IntPtr.Zero)
				id_delimiterOffset_Ljava_lang_String_IIC = JNIEnv.GetStaticMethodID (class_ref, "delimiterOffset", "(Ljava/lang/String;IIC)I");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (pos);
				__args [2] = new JValue (limit);
				__args [3] = new JValue (delimiter);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_delimiterOffset_Ljava_lang_String_IIC, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_delimiterOffset_Ljava_lang_String_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='delimiterOffset' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("delimiterOffset", "(Ljava/lang/String;IILjava/lang/String;)I", "")]
		public static unsafe int DelimiterOffset (string input, int pos, int limit, string delimiters)
		{
			if (id_delimiterOffset_Ljava_lang_String_IILjava_lang_String_ == IntPtr.Zero)
				id_delimiterOffset_Ljava_lang_String_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "delimiterOffset", "(Ljava/lang/String;IILjava/lang/String;)I");
			IntPtr native_input = JNIEnv.NewString (input);
			IntPtr native_delimiters = JNIEnv.NewString (delimiters);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (pos);
				__args [2] = new JValue (limit);
				__args [3] = new JValue (native_delimiters);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_delimiterOffset_Ljava_lang_String_IILjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_delimiters);
			}
		}

		static IntPtr id_format_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string Format (string format, params global::Java.Lang.Object[] args)
		{
			if (id_format_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_format_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_format);
				__args [1] = new JValue (native_args);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_getSystemProperty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='getSystemProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSystemProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSystemProperty (string key, string defaultValue)
		{
			if (id_getSystemProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getSystemProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getSystemProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_defaultValue = JNIEnv.NewString (defaultValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_defaultValue);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSystemProperty_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static IntPtr id_hostHeader_Lokhttp3_HttpUrl_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='hostHeader' and count(parameter)=2 and parameter[1][@type='okhttp3.HttpUrl'] and parameter[2][@type='boolean']]"
		[Register ("hostHeader", "(Lokhttp3/HttpUrl;Z)Ljava/lang/String;", "")]
		public static unsafe string HostHeader (global::Okhttp3.HttpUrl url, bool includeDefaultPort)
		{
			if (id_hostHeader_Lokhttp3_HttpUrl_Z == IntPtr.Zero)
				id_hostHeader_Lokhttp3_HttpUrl_Z = JNIEnv.GetStaticMethodID (class_ref, "hostHeader", "(Lokhttp3/HttpUrl;Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (url);
				__args [1] = new JValue (includeDefaultPort);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hostHeader_Lokhttp3_HttpUrl_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_immutableList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='immutableList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("immutableList", "(Ljava/util/List;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList ImmutableList (global::System.Collections.IList list)
		{
			if (id_immutableList_Ljava_util_List_ == IntPtr.Zero)
				id_immutableList_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "immutableList", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_list = global::Android.Runtime.JavaList.ToLocalJniHandle (list);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_list);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_immutableList_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
			}
		}

		static IntPtr id_immutableList_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='immutableList' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("immutableList", "([Ljava/lang/Object;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList ImmutableList (params global::Java.Lang.Object[] elements)
		{
			if (id_immutableList_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_immutableList_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "immutableList", "([Ljava/lang/Object;)Ljava/util/List;");
			IntPtr native_elements = JNIEnv.NewArray (elements);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_elements);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_immutableList_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (elements != null) {
					JNIEnv.CopyArray (native_elements, elements);
					JNIEnv.DeleteLocalRef (native_elements);
				}
			}
		}

		static IntPtr id_immutableMap_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='immutableMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;K, V&gt;']]"
		[Register ("immutableMap", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe global::System.Collections.IDictionary ImmutableMap (global::System.Collections.IDictionary map)
		{
			if (id_immutableMap_Ljava_util_Map_ == IntPtr.Zero)
				id_immutableMap_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "immutableMap", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_map = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (map);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_map);
				global::System.Collections.IDictionary __ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_immutableMap_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		static IntPtr id_indexOf_Ljava_util_Comparator_arrayLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='java.util.Comparator&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("indexOf", "(Ljava/util/Comparator;[Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int IndexOf (global::Java.Util.IComparator comparator, string[] array, string value)
		{
			if (id_indexOf_Ljava_util_Comparator_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_indexOf_Ljava_util_Comparator_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "(Ljava/util/Comparator;[Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (comparator);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (native_value);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_Ljava_util_Comparator_arrayLjava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_indexOfControlOrNonAscii_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='indexOfControlOrNonAscii' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("indexOfControlOrNonAscii", "(Ljava/lang/String;)I", "")]
		public static unsafe int IndexOfControlOrNonAscii (string input)
		{
			if (id_indexOfControlOrNonAscii_Ljava_lang_String_ == IntPtr.Zero)
				id_indexOfControlOrNonAscii_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfControlOrNonAscii", "(Ljava/lang/String;)I");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfControlOrNonAscii_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_intersect_Ljava_util_Comparator_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='intersect' and count(parameter)=3 and parameter[1][@type='java.util.Comparator&lt;? super java.lang.String&gt;'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("intersect", "(Ljava/util/Comparator;[Ljava/lang/String;[Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] Intersect (global::Java.Util.IComparator comparator, string[] first, string[] second)
		{
			if (id_intersect_Ljava_util_Comparator_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_intersect_Ljava_util_Comparator_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "intersect", "(Ljava/util/Comparator;[Ljava/lang/String;[Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_first = JNIEnv.NewArray (first);
			IntPtr native_second = JNIEnv.NewArray (second);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (comparator);
				__args [1] = new JValue (native_first);
				__args [2] = new JValue (native_second);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_intersect_Ljava_util_Comparator_arrayLjava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				if (first != null) {
					JNIEnv.CopyArray (native_first, first);
					JNIEnv.DeleteLocalRef (native_first);
				}
				if (second != null) {
					JNIEnv.CopyArray (native_second, second);
					JNIEnv.DeleteLocalRef (native_second);
				}
			}
		}

		static IntPtr id_isAndroidGetsocknameError_Ljava_lang_AssertionError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='isAndroidGetsocknameError' and count(parameter)=1 and parameter[1][@type='java.lang.AssertionError']]"
		[Register ("isAndroidGetsocknameError", "(Ljava/lang/AssertionError;)Z", "")]
		public static unsafe bool IsAndroidGetsocknameError (global::Java.Lang.AssertionError e)
		{
			if (id_isAndroidGetsocknameError_Ljava_lang_AssertionError_ == IntPtr.Zero)
				id_isAndroidGetsocknameError_Ljava_lang_AssertionError_ = JNIEnv.GetStaticMethodID (class_ref, "isAndroidGetsocknameError", "(Ljava/lang/AssertionError;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAndroidGetsocknameError_Ljava_lang_AssertionError_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_nonEmptyIntersection_Ljava_util_Comparator_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='nonEmptyIntersection' and count(parameter)=3 and parameter[1][@type='java.util.Comparator&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("nonEmptyIntersection", "(Ljava/util/Comparator;[Ljava/lang/String;[Ljava/lang/String;)Z", "")]
		public static unsafe bool NonEmptyIntersection (global::Java.Util.IComparator comparator, string[] first, string[] second)
		{
			if (id_nonEmptyIntersection_Ljava_util_Comparator_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_nonEmptyIntersection_Ljava_util_Comparator_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "nonEmptyIntersection", "(Ljava/util/Comparator;[Ljava/lang/String;[Ljava/lang/String;)Z");
			IntPtr native_first = JNIEnv.NewArray (first);
			IntPtr native_second = JNIEnv.NewArray (second);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (comparator);
				__args [1] = new JValue (native_first);
				__args [2] = new JValue (native_second);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_nonEmptyIntersection_Ljava_util_Comparator_arrayLjava_lang_String_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (first != null) {
					JNIEnv.CopyArray (native_first, first);
					JNIEnv.DeleteLocalRef (native_first);
				}
				if (second != null) {
					JNIEnv.CopyArray (native_second, second);
					JNIEnv.DeleteLocalRef (native_second);
				}
			}
		}

		static IntPtr id_platformTrustManager;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='platformTrustManager' and count(parameter)=0]"
		[Register ("platformTrustManager", "()Ljavax/net/ssl/X509TrustManager;", "")]
		public static unsafe global::Javax.Net.Ssl.IX509TrustManager PlatformTrustManager ()
		{
			if (id_platformTrustManager == IntPtr.Zero)
				id_platformTrustManager = JNIEnv.GetStaticMethodID (class_ref, "platformTrustManager", "()Ljavax/net/ssl/X509TrustManager;");
			try {
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_platformTrustManager), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_sameConnection_Lokhttp3_HttpUrl_Lokhttp3_HttpUrl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='sameConnection' and count(parameter)=2 and parameter[1][@type='okhttp3.HttpUrl'] and parameter[2][@type='okhttp3.HttpUrl']]"
		[Register ("sameConnection", "(Lokhttp3/HttpUrl;Lokhttp3/HttpUrl;)Z", "")]
		public static unsafe bool SameConnection (global::Okhttp3.HttpUrl a, global::Okhttp3.HttpUrl b)
		{
			if (id_sameConnection_Lokhttp3_HttpUrl_Lokhttp3_HttpUrl_ == IntPtr.Zero)
				id_sameConnection_Lokhttp3_HttpUrl_Lokhttp3_HttpUrl_ = JNIEnv.GetStaticMethodID (class_ref, "sameConnection", "(Lokhttp3/HttpUrl;Lokhttp3/HttpUrl;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_sameConnection_Lokhttp3_HttpUrl_Lokhttp3_HttpUrl_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skipLeadingAsciiWhitespace_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='skipLeadingAsciiWhitespace' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("skipLeadingAsciiWhitespace", "(Ljava/lang/String;II)I", "")]
		public static unsafe int SkipLeadingAsciiWhitespace (string input, int pos, int limit)
		{
			if (id_skipLeadingAsciiWhitespace_Ljava_lang_String_II == IntPtr.Zero)
				id_skipLeadingAsciiWhitespace_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "skipLeadingAsciiWhitespace", "(Ljava/lang/String;II)I");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (pos);
				__args [2] = new JValue (limit);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_skipLeadingAsciiWhitespace_Ljava_lang_String_II, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_skipTrailingAsciiWhitespace_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='skipTrailingAsciiWhitespace' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("skipTrailingAsciiWhitespace", "(Ljava/lang/String;II)I", "")]
		public static unsafe int SkipTrailingAsciiWhitespace (string input, int pos, int limit)
		{
			if (id_skipTrailingAsciiWhitespace_Ljava_lang_String_II == IntPtr.Zero)
				id_skipTrailingAsciiWhitespace_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "skipTrailingAsciiWhitespace", "(Ljava/lang/String;II)I");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (pos);
				__args [2] = new JValue (limit);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_skipTrailingAsciiWhitespace_Ljava_lang_String_II, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_threadFactory_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='threadFactory' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("threadFactory", "(Ljava/lang/String;Z)Ljava/util/concurrent/ThreadFactory;", "")]
		public static unsafe global::Java.Util.Concurrent.IThreadFactory ThreadFactory (string name, bool daemon)
		{
			if (id_threadFactory_Ljava_lang_String_Z == IntPtr.Zero)
				id_threadFactory_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "threadFactory", "(Ljava/lang/String;Z)Ljava/util/concurrent/ThreadFactory;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (daemon);
				global::Java.Util.Concurrent.IThreadFactory __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IThreadFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_threadFactory_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_toHeaderBlock_Lokhttp3_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='toHeaderBlock' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("toHeaderBlock", "(Lokhttp3/Headers;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> ToHeaderBlock (global::Okhttp3.Headers headers)
		{
			if (id_toHeaderBlock_Lokhttp3_Headers_ == IntPtr.Zero)
				id_toHeaderBlock_Lokhttp3_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "toHeaderBlock", "(Lokhttp3/Headers;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (headers);
				global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> __ret = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHeaderBlock_Lokhttp3_Headers_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toHeaders_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='toHeaders' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;']]"
		[Register ("toHeaders", "(Ljava/util/List;)Lokhttp3/Headers;", "")]
		public static unsafe global::Okhttp3.Headers ToHeaders (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> headerBlock)
		{
			if (id_toHeaders_Ljava_util_List_ == IntPtr.Zero)
				id_toHeaders_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "toHeaders", "(Ljava/util/List;)Lokhttp3/Headers;");
			IntPtr native_headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (headerBlock);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_headerBlock);
				global::Okhttp3.Headers __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHeaders_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_headerBlock);
			}
		}

		static IntPtr id_trimSubstring_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='trimSubstring' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("trimSubstring", "(Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string TrimSubstring (string @string, int pos, int limit)
		{
			if (id_trimSubstring_Ljava_lang_String_II == IntPtr.Zero)
				id_trimSubstring_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "trimSubstring", "(Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native__string);
				__args [1] = new JValue (pos);
				__args [2] = new JValue (limit);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_trimSubstring_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static IntPtr id_verifyAsIpAddress_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Util']/method[@name='verifyAsIpAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("verifyAsIpAddress", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool VerifyAsIpAddress (string host)
		{
			if (id_verifyAsIpAddress_Ljava_lang_String_ == IntPtr.Zero)
				id_verifyAsIpAddress_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "verifyAsIpAddress", "(Ljava/lang/String;)Z");
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_host);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_verifyAsIpAddress_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

	}
}
