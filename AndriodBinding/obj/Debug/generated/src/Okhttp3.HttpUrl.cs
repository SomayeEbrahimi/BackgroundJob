using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']"
	[global::Android.Runtime.Register ("okhttp3/HttpUrl", DoNotGenerateAcw=true)]
	public sealed partial class HttpUrl : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']"
		[global::Android.Runtime.Register ("okhttp3/HttpUrl$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/HttpUrl$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/constructor[@name='HttpUrl.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_addEncodedPathSegment_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='addEncodedPathSegment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addEncodedPathSegment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder AddEncodedPathSegment (string encodedPathSegment)
			{
				if (id_addEncodedPathSegment_Ljava_lang_String_ == IntPtr.Zero)
					id_addEncodedPathSegment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addEncodedPathSegment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedPathSegment = JNIEnv.NewString (encodedPathSegment);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_encodedPathSegment);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addEncodedPathSegment_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedPathSegment);
				}
			}

			static IntPtr id_addEncodedPathSegments_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='addEncodedPathSegments' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addEncodedPathSegments", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder AddEncodedPathSegments (string encodedPathSegments)
			{
				if (id_addEncodedPathSegments_Ljava_lang_String_ == IntPtr.Zero)
					id_addEncodedPathSegments_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addEncodedPathSegments", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedPathSegments = JNIEnv.NewString (encodedPathSegments);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_encodedPathSegments);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addEncodedPathSegments_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedPathSegments);
				}
			}

			static IntPtr id_addEncodedQueryParameter_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='addEncodedQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addEncodedQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder AddEncodedQueryParameter (string encodedName, string encodedValue)
			{
				if (id_addEncodedQueryParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addEncodedQueryParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addEncodedQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedName = JNIEnv.NewString (encodedName);
				IntPtr native_encodedValue = JNIEnv.NewString (encodedValue);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_encodedName);
					__args [1] = new JValue (native_encodedValue);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addEncodedQueryParameter_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedName);
					JNIEnv.DeleteLocalRef (native_encodedValue);
				}
			}

			static IntPtr id_addPathSegment_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='addPathSegment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addPathSegment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder AddPathSegment (string pathSegment)
			{
				if (id_addPathSegment_Ljava_lang_String_ == IntPtr.Zero)
					id_addPathSegment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addPathSegment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_pathSegment = JNIEnv.NewString (pathSegment);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_pathSegment);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addPathSegment_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_pathSegment);
				}
			}

			static IntPtr id_addPathSegments_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='addPathSegments' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addPathSegments", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder AddPathSegments (string pathSegments)
			{
				if (id_addPathSegments_Ljava_lang_String_ == IntPtr.Zero)
					id_addPathSegments_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addPathSegments", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_pathSegments = JNIEnv.NewString (pathSegments);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_pathSegments);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addPathSegments_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_pathSegments);
				}
			}

			static IntPtr id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='addQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder AddQueryParameter (string name, string value)
			{
				if (id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/HttpUrl;", "")]
			public unsafe global::Okhttp3.HttpUrl Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/HttpUrl;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_encodedFragment_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='encodedFragment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("encodedFragment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder EncodedFragment (string encodedFragment)
			{
				if (id_encodedFragment_Ljava_lang_String_ == IntPtr.Zero)
					id_encodedFragment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encodedFragment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedFragment = JNIEnv.NewString (encodedFragment);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_encodedFragment);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedFragment_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedFragment);
				}
			}

			static IntPtr id_encodedPassword_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='encodedPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("encodedPassword", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder EncodedPassword (string encodedPassword)
			{
				if (id_encodedPassword_Ljava_lang_String_ == IntPtr.Zero)
					id_encodedPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encodedPassword", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedPassword = JNIEnv.NewString (encodedPassword);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_encodedPassword);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedPassword_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedPassword);
				}
			}

			static IntPtr id_encodedPath_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='encodedPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("encodedPath", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder EncodedPath (string encodedPath)
			{
				if (id_encodedPath_Ljava_lang_String_ == IntPtr.Zero)
					id_encodedPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encodedPath", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedPath = JNIEnv.NewString (encodedPath);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_encodedPath);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedPath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedPath);
				}
			}

			static IntPtr id_encodedQuery_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='encodedQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("encodedQuery", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder EncodedQuery (string encodedQuery)
			{
				if (id_encodedQuery_Ljava_lang_String_ == IntPtr.Zero)
					id_encodedQuery_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encodedQuery", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedQuery = JNIEnv.NewString (encodedQuery);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_encodedQuery);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedQuery_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedQuery);
				}
			}

			static IntPtr id_encodedUsername_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='encodedUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("encodedUsername", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder EncodedUsername (string encodedUsername)
			{
				if (id_encodedUsername_Ljava_lang_String_ == IntPtr.Zero)
					id_encodedUsername_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encodedUsername", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedUsername = JNIEnv.NewString (encodedUsername);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_encodedUsername);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedUsername_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedUsername);
				}
			}

			static IntPtr id_fragment_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='fragment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fragment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Fragment (string fragment)
			{
				if (id_fragment_Ljava_lang_String_ == IntPtr.Zero)
					id_fragment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fragment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_fragment = JNIEnv.NewString (fragment);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_fragment);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fragment_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_fragment);
				}
			}

			static IntPtr id_host_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='host' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("host", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Host (string host)
			{
				if (id_host_Ljava_lang_String_ == IntPtr.Zero)
					id_host_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "host", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_host = JNIEnv.NewString (host);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_host);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_host_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_host);
				}
			}

			static IntPtr id_password_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='password' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("password", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Password (string password)
			{
				if (id_password_Ljava_lang_String_ == IntPtr.Zero)
					id_password_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "password", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_password = JNIEnv.NewString (password);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_password);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_password_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_password);
				}
			}

			static IntPtr id_port_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='port' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("port", "(I)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Port (int port)
			{
				if (id_port_I == IntPtr.Zero)
					id_port_I = JNIEnv.GetMethodID (class_ref, "port", "(I)Lokhttp3/HttpUrl$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (port);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_port_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_query_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='query' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("query", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Query (string query)
			{
				if (id_query_Ljava_lang_String_ == IntPtr.Zero)
					id_query_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_query = JNIEnv.NewString (query);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_query);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_query);
				}
			}

			static IntPtr id_removeAllEncodedQueryParameters_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='removeAllEncodedQueryParameters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeAllEncodedQueryParameters", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder RemoveAllEncodedQueryParameters (string encodedName)
			{
				if (id_removeAllEncodedQueryParameters_Ljava_lang_String_ == IntPtr.Zero)
					id_removeAllEncodedQueryParameters_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAllEncodedQueryParameters", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedName = JNIEnv.NewString (encodedName);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_encodedName);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeAllEncodedQueryParameters_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedName);
				}
			}

			static IntPtr id_removeAllQueryParameters_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='removeAllQueryParameters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeAllQueryParameters", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder RemoveAllQueryParameters (string name)
			{
				if (id_removeAllQueryParameters_Ljava_lang_String_ == IntPtr.Zero)
					id_removeAllQueryParameters_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAllQueryParameters", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeAllQueryParameters_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_removePathSegment_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='removePathSegment' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("removePathSegment", "(I)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder RemovePathSegment (int index)
			{
				if (id_removePathSegment_I == IntPtr.Zero)
					id_removePathSegment_I = JNIEnv.GetMethodID (class_ref, "removePathSegment", "(I)Lokhttp3/HttpUrl$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (index);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removePathSegment_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_scheme_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='scheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("scheme", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Scheme (string scheme)
			{
				if (id_scheme_Ljava_lang_String_ == IntPtr.Zero)
					id_scheme_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "scheme", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_scheme = JNIEnv.NewString (scheme);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_scheme);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scheme_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_scheme);
				}
			}

			static IntPtr id_setEncodedPathSegment_ILjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='setEncodedPathSegment' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("setEncodedPathSegment", "(ILjava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder SetEncodedPathSegment (int index, string encodedPathSegment)
			{
				if (id_setEncodedPathSegment_ILjava_lang_String_ == IntPtr.Zero)
					id_setEncodedPathSegment_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEncodedPathSegment", "(ILjava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedPathSegment = JNIEnv.NewString (encodedPathSegment);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (index);
					__args [1] = new JValue (native_encodedPathSegment);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEncodedPathSegment_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedPathSegment);
				}
			}

			static IntPtr id_setEncodedQueryParameter_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='setEncodedQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setEncodedQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder SetEncodedQueryParameter (string encodedName, string encodedValue)
			{
				if (id_setEncodedQueryParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_setEncodedQueryParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEncodedQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_encodedName = JNIEnv.NewString (encodedName);
				IntPtr native_encodedValue = JNIEnv.NewString (encodedValue);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_encodedName);
					__args [1] = new JValue (native_encodedValue);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEncodedQueryParameter_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedName);
					JNIEnv.DeleteLocalRef (native_encodedValue);
				}
			}

			static IntPtr id_setPathSegment_ILjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='setPathSegment' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("setPathSegment", "(ILjava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder SetPathSegment (int index, string pathSegment)
			{
				if (id_setPathSegment_ILjava_lang_String_ == IntPtr.Zero)
					id_setPathSegment_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPathSegment", "(ILjava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_pathSegment = JNIEnv.NewString (pathSegment);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (index);
					__args [1] = new JValue (native_pathSegment);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPathSegment_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_pathSegment);
				}
			}

			static IntPtr id_setQueryParameter_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='setQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder SetQueryParameter (string name, string value)
			{
				if (id_setQueryParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_setQueryParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setQueryParameter_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_username_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='username' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("username", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Username (string username)
			{
				if (id_username_Ljava_lang_String_ == IntPtr.Zero)
					id_username_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "username", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
				IntPtr native_username = JNIEnv.NewString (username);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_username);
					global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_username_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_username);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/HttpUrl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpUrl); }
		}

		internal HttpUrl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isHttps;
		public unsafe bool IsHttps {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='isHttps' and count(parameter)=0]"
			[Register ("isHttps", "()Z", "")]
			get {
				if (id_isHttps == IntPtr.Zero)
					id_isHttps = JNIEnv.GetMethodID (class_ref, "isHttps", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHttps);
				} finally {
				}
			}
		}

		static IntPtr id_defaultPort_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='defaultPort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("defaultPort", "(Ljava/lang/String;)I", "")]
		public static unsafe int DefaultPort (string scheme)
		{
			if (id_defaultPort_Ljava_lang_String_ == IntPtr.Zero)
				id_defaultPort_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "defaultPort", "(Ljava/lang/String;)I");
			IntPtr native_scheme = JNIEnv.NewString (scheme);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_scheme);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_defaultPort_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
			}
		}

		static IntPtr id_encodedFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedFragment' and count(parameter)=0]"
		[Register ("encodedFragment", "()Ljava/lang/String;", "")]
		public unsafe string EncodedFragment ()
		{
			if (id_encodedFragment == IntPtr.Zero)
				id_encodedFragment = JNIEnv.GetMethodID (class_ref, "encodedFragment", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedFragment), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_encodedPassword;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedPassword' and count(parameter)=0]"
		[Register ("encodedPassword", "()Ljava/lang/String;", "")]
		public unsafe string EncodedPassword ()
		{
			if (id_encodedPassword == IntPtr.Zero)
				id_encodedPassword = JNIEnv.GetMethodID (class_ref, "encodedPassword", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedPassword), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_encodedPath;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedPath' and count(parameter)=0]"
		[Register ("encodedPath", "()Ljava/lang/String;", "")]
		public unsafe string EncodedPath ()
		{
			if (id_encodedPath == IntPtr.Zero)
				id_encodedPath = JNIEnv.GetMethodID (class_ref, "encodedPath", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedPath), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_encodedPathSegments;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedPathSegments' and count(parameter)=0]"
		[Register ("encodedPathSegments", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> EncodedPathSegments ()
		{
			if (id_encodedPathSegments == IntPtr.Zero)
				id_encodedPathSegments = JNIEnv.GetMethodID (class_ref, "encodedPathSegments", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedPathSegments), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_encodedQuery;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedQuery' and count(parameter)=0]"
		[Register ("encodedQuery", "()Ljava/lang/String;", "")]
		public unsafe string EncodedQuery ()
		{
			if (id_encodedQuery == IntPtr.Zero)
				id_encodedQuery = JNIEnv.GetMethodID (class_ref, "encodedQuery", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedQuery), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_encodedUsername;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedUsername' and count(parameter)=0]"
		[Register ("encodedUsername", "()Ljava/lang/String;", "")]
		public unsafe string EncodedUsername ()
		{
			if (id_encodedUsername == IntPtr.Zero)
				id_encodedUsername = JNIEnv.GetMethodID (class_ref, "encodedUsername", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedUsername), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='fragment' and count(parameter)=0]"
		[Register ("fragment", "()Ljava/lang/String;", "")]
		public unsafe string Fragment ()
		{
			if (id_fragment == IntPtr.Zero)
				id_fragment = JNIEnv.GetMethodID (class_ref, "fragment", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fragment), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lokhttp3/HttpUrl;", "")]
		public static unsafe global::Okhttp3.HttpUrl Get (string url)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)Lokhttp3/HttpUrl;");
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_url);
				global::Okhttp3.HttpUrl __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static IntPtr id_get_Ljava_net_URI_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register ("get", "(Ljava/net/URI;)Lokhttp3/HttpUrl;", "")]
		public static unsafe global::Okhttp3.HttpUrl Get (global::Java.Net.URI uri)
		{
			if (id_get_Ljava_net_URI_ == IntPtr.Zero)
				id_get_Ljava_net_URI_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/net/URI;)Lokhttp3/HttpUrl;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (uri);
				global::Okhttp3.HttpUrl __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_net_URI_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_get_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("get", "(Ljava/net/URL;)Lokhttp3/HttpUrl;", "")]
		public static unsafe global::Okhttp3.HttpUrl Get (global::Java.Net.URL url)
		{
			if (id_get_Ljava_net_URL_ == IntPtr.Zero)
				id_get_Ljava_net_URL_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/net/URL;)Lokhttp3/HttpUrl;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (url);
				global::Okhttp3.HttpUrl __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_host;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='host' and count(parameter)=0]"
		[Register ("host", "()Ljava/lang/String;", "")]
		public unsafe string Host ()
		{
			if (id_host == IntPtr.Zero)
				id_host = JNIEnv.GetMethodID (class_ref, "host", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_host), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lokhttp3/HttpUrl$Builder;", "")]
		public unsafe global::Okhttp3.HttpUrl.Builder NewBuilder ()
		{
			if (id_newBuilder == IntPtr.Zero)
				id_newBuilder = JNIEnv.GetMethodID (class_ref, "newBuilder", "()Lokhttp3/HttpUrl$Builder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newBuilder_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='newBuilder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newBuilder", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
		public unsafe global::Okhttp3.HttpUrl.Builder NewBuilder (string link)
		{
			if (id_newBuilder_Ljava_lang_String_ == IntPtr.Zero)
				id_newBuilder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "newBuilder", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;");
			IntPtr native_link = JNIEnv.NewString (link);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_link);
				global::Okhttp3.HttpUrl.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newBuilder_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_link);
			}
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lokhttp3/HttpUrl;", "")]
		public static unsafe global::Okhttp3.HttpUrl Parse (string url)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lokhttp3/HttpUrl;");
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_url);
				global::Okhttp3.HttpUrl __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static IntPtr id_password;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='password' and count(parameter)=0]"
		[Register ("password", "()Ljava/lang/String;", "")]
		public unsafe string Password ()
		{
			if (id_password == IntPtr.Zero)
				id_password = JNIEnv.GetMethodID (class_ref, "password", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_password), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_pathSegments;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='pathSegments' and count(parameter)=0]"
		[Register ("pathSegments", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> PathSegments ()
		{
			if (id_pathSegments == IntPtr.Zero)
				id_pathSegments = JNIEnv.GetMethodID (class_ref, "pathSegments", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pathSegments), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_pathSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='pathSize' and count(parameter)=0]"
		[Register ("pathSize", "()I", "")]
		public unsafe int PathSize ()
		{
			if (id_pathSize == IntPtr.Zero)
				id_pathSize = JNIEnv.GetMethodID (class_ref, "pathSize", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_pathSize);
			} finally {
			}
		}

		static IntPtr id_port;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='port' and count(parameter)=0]"
		[Register ("port", "()I", "")]
		public unsafe int Port ()
		{
			if (id_port == IntPtr.Zero)
				id_port = JNIEnv.GetMethodID (class_ref, "port", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_port);
			} finally {
			}
		}

		static IntPtr id_query;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='query' and count(parameter)=0]"
		[Register ("query", "()Ljava/lang/String;", "")]
		public unsafe string Query ()
		{
			if (id_query == IntPtr.Zero)
				id_query = JNIEnv.GetMethodID (class_ref, "query", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_queryParameter_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='queryParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryParameter", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string QueryParameter (string name)
		{
			if (id_queryParameter_Ljava_lang_String_ == IntPtr.Zero)
				id_queryParameter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queryParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryParameter_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_queryParameterName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='queryParameterName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("queryParameterName", "(I)Ljava/lang/String;", "")]
		public unsafe string QueryParameterName (int index)
		{
			if (id_queryParameterName_I == IntPtr.Zero)
				id_queryParameterName_I = JNIEnv.GetMethodID (class_ref, "queryParameterName", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryParameterName_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_queryParameterNames;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='queryParameterNames' and count(parameter)=0]"
		[Register ("queryParameterNames", "()Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<string> QueryParameterNames ()
		{
			if (id_queryParameterNames == IntPtr.Zero)
				id_queryParameterNames = JNIEnv.GetMethodID (class_ref, "queryParameterNames", "()Ljava/util/Set;");
			try {
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryParameterNames), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_queryParameterValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='queryParameterValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("queryParameterValue", "(I)Ljava/lang/String;", "")]
		public unsafe string QueryParameterValue (int index)
		{
			if (id_queryParameterValue_I == IntPtr.Zero)
				id_queryParameterValue_I = JNIEnv.GetMethodID (class_ref, "queryParameterValue", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryParameterValue_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_queryParameterValues_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='queryParameterValues' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryParameterValues", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> QueryParameterValues (string name)
		{
			if (id_queryParameterValues_Ljava_lang_String_ == IntPtr.Zero)
				id_queryParameterValues_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queryParameterValues", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryParameterValues_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_querySize;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='querySize' and count(parameter)=0]"
		[Register ("querySize", "()I", "")]
		public unsafe int QuerySize ()
		{
			if (id_querySize == IntPtr.Zero)
				id_querySize = JNIEnv.GetMethodID (class_ref, "querySize", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_querySize);
			} finally {
			}
		}

		static IntPtr id_redact;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='redact' and count(parameter)=0]"
		[Register ("redact", "()Ljava/lang/String;", "")]
		public unsafe string Redact ()
		{
			if (id_redact == IntPtr.Zero)
				id_redact = JNIEnv.GetMethodID (class_ref, "redact", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_redact), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_resolve_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='resolve' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("resolve", "(Ljava/lang/String;)Lokhttp3/HttpUrl;", "")]
		public unsafe global::Okhttp3.HttpUrl Resolve (string link)
		{
			if (id_resolve_Ljava_lang_String_ == IntPtr.Zero)
				id_resolve_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "resolve", "(Ljava/lang/String;)Lokhttp3/HttpUrl;");
			IntPtr native_link = JNIEnv.NewString (link);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_link);
				global::Okhttp3.HttpUrl __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_resolve_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_link);
			}
		}

		static IntPtr id_scheme;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='scheme' and count(parameter)=0]"
		[Register ("scheme", "()Ljava/lang/String;", "")]
		public unsafe string Scheme ()
		{
			if (id_scheme == IntPtr.Zero)
				id_scheme = JNIEnv.GetMethodID (class_ref, "scheme", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scheme), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_topPrivateDomain;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='topPrivateDomain' and count(parameter)=0]"
		[Register ("topPrivateDomain", "()Ljava/lang/String;", "")]
		public unsafe string TopPrivateDomain ()
		{
			if (id_topPrivateDomain == IntPtr.Zero)
				id_topPrivateDomain = JNIEnv.GetMethodID (class_ref, "topPrivateDomain", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_topPrivateDomain), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_uri;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='uri' and count(parameter)=0]"
		[Register ("uri", "()Ljava/net/URI;", "")]
		public unsafe global::Java.Net.URI Uri ()
		{
			if (id_uri == IntPtr.Zero)
				id_uri = JNIEnv.GetMethodID (class_ref, "uri", "()Ljava/net/URI;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_uri), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_url;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Ljava/net/URL;", "")]
		public unsafe global::Java.Net.URL Url ()
		{
			if (id_url == IntPtr.Zero)
				id_url = JNIEnv.GetMethodID (class_ref, "url", "()Ljava/net/URL;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_url), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_username;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='username' and count(parameter)=0]"
		[Register ("username", "()Ljava/lang/String;", "")]
		public unsafe string Username ()
		{
			if (id_username == IntPtr.Zero)
				id_username = JNIEnv.GetMethodID (class_ref, "username", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_username), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
