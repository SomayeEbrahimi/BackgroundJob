using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']"
	[global::Android.Runtime.Register ("okhttp3/Cookie", DoNotGenerateAcw=true)]
	public sealed partial class Cookie : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']"
		[global::Android.Runtime.Register ("okhttp3/Cookie$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/Cookie$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/constructor[@name='Cookie.Builder' and count(parameter)=0]"
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/Cookie;", "")]
			public unsafe global::Okhttp3.Cookie Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/Cookie;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_domain_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='domain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("domain", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder Domain (string domain)
			{
				if (id_domain_Ljava_lang_String_ == IntPtr.Zero)
					id_domain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "domain", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;");
				IntPtr native_domain = JNIEnv.NewString (domain);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_domain);
					global::Okhttp3.Cookie.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_domain_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
				}
			}

			static IntPtr id_expiresAt_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='expiresAt' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("expiresAt", "(J)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder ExpiresAt (long expiresAt)
			{
				if (id_expiresAt_J == IntPtr.Zero)
					id_expiresAt_J = JNIEnv.GetMethodID (class_ref, "expiresAt", "(J)Lokhttp3/Cookie$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (expiresAt);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_expiresAt_J, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_hostOnlyDomain_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='hostOnlyDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("hostOnlyDomain", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder HostOnlyDomain (string domain)
			{
				if (id_hostOnlyDomain_Ljava_lang_String_ == IntPtr.Zero)
					id_hostOnlyDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hostOnlyDomain", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;");
				IntPtr native_domain = JNIEnv.NewString (domain);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_domain);
					global::Okhttp3.Cookie.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hostOnlyDomain_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
				}
			}

			static IntPtr id_httpOnly;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='httpOnly' and count(parameter)=0]"
			[Register ("httpOnly", "()Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder HttpOnly ()
			{
				if (id_httpOnly == IntPtr.Zero)
					id_httpOnly = JNIEnv.GetMethodID (class_ref, "httpOnly", "()Lokhttp3/Cookie$Builder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_httpOnly), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_name_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("name", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder Name (string name)
			{
				if (id_name_Ljava_lang_String_ == IntPtr.Zero)
					id_name_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "name", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Okhttp3.Cookie.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_name_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_path_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='path' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("path", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder Path (string path)
			{
				if (id_path_Ljava_lang_String_ == IntPtr.Zero)
					id_path_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "path", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;");
				IntPtr native_path = JNIEnv.NewString (path);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_path);
					global::Okhttp3.Cookie.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_path_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_path);
				}
			}

			static IntPtr id_secure;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='secure' and count(parameter)=0]"
			[Register ("secure", "()Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder Secure ()
			{
				if (id_secure == IntPtr.Zero)
					id_secure = JNIEnv.GetMethodID (class_ref, "secure", "()Lokhttp3/Cookie$Builder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_secure), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_value_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("value", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder Value (string value)
			{
				if (id_value_Ljava_lang_String_ == IntPtr.Zero)
					id_value_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "value", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					global::Okhttp3.Cookie.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Cookie", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Cookie); }
		}

		internal Cookie (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_domain;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='domain' and count(parameter)=0]"
		[Register ("domain", "()Ljava/lang/String;", "")]
		public unsafe string Domain ()
		{
			if (id_domain == IntPtr.Zero)
				id_domain = JNIEnv.GetMethodID (class_ref, "domain", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_domain), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_expiresAt;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='expiresAt' and count(parameter)=0]"
		[Register ("expiresAt", "()J", "")]
		public unsafe long ExpiresAt ()
		{
			if (id_expiresAt == IntPtr.Zero)
				id_expiresAt = JNIEnv.GetMethodID (class_ref, "expiresAt", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_expiresAt);
			} finally {
			}
		}

		static IntPtr id_hostOnly;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='hostOnly' and count(parameter)=0]"
		[Register ("hostOnly", "()Z", "")]
		public unsafe bool HostOnly ()
		{
			if (id_hostOnly == IntPtr.Zero)
				id_hostOnly = JNIEnv.GetMethodID (class_ref, "hostOnly", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hostOnly);
			} finally {
			}
		}

		static IntPtr id_httpOnly;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='httpOnly' and count(parameter)=0]"
		[Register ("httpOnly", "()Z", "")]
		public unsafe bool HttpOnly ()
		{
			if (id_httpOnly == IntPtr.Zero)
				id_httpOnly = JNIEnv.GetMethodID (class_ref, "httpOnly", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_httpOnly);
			} finally {
			}
		}

		static IntPtr id_matches_Lokhttp3_HttpUrl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
		[Register ("matches", "(Lokhttp3/HttpUrl;)Z", "")]
		public unsafe bool Matches (global::Okhttp3.HttpUrl url)
		{
			if (id_matches_Lokhttp3_HttpUrl_ == IntPtr.Zero)
				id_matches_Lokhttp3_HttpUrl_ = JNIEnv.GetMethodID (class_ref, "matches", "(Lokhttp3/HttpUrl;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (url);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_Lokhttp3_HttpUrl_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_name;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "")]
		public unsafe string Name ()
		{
			if (id_name == IntPtr.Zero)
				id_name = JNIEnv.GetMethodID (class_ref, "name", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_name), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_parse_Lokhttp3_HttpUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='okhttp3.HttpUrl'] and parameter[2][@type='java.lang.String']]"
		[Register ("parse", "(Lokhttp3/HttpUrl;Ljava/lang/String;)Lokhttp3/Cookie;", "")]
		public static unsafe global::Okhttp3.Cookie Parse (global::Okhttp3.HttpUrl url, string setCookie)
		{
			if (id_parse_Lokhttp3_HttpUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Lokhttp3_HttpUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Lokhttp3/HttpUrl;Ljava/lang/String;)Lokhttp3/Cookie;");
			IntPtr native_setCookie = JNIEnv.NewString (setCookie);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (url);
				__args [1] = new JValue (native_setCookie);
				global::Okhttp3.Cookie __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Lokhttp3_HttpUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_setCookie);
			}
		}

		static IntPtr id_parseAll_Lokhttp3_HttpUrl_Lokhttp3_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='parseAll' and count(parameter)=2 and parameter[1][@type='okhttp3.HttpUrl'] and parameter[2][@type='okhttp3.Headers']]"
		[Register ("parseAll", "(Lokhttp3/HttpUrl;Lokhttp3/Headers;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Okhttp3.Cookie> ParseAll (global::Okhttp3.HttpUrl url, global::Okhttp3.Headers headers)
		{
			if (id_parseAll_Lokhttp3_HttpUrl_Lokhttp3_Headers_ == IntPtr.Zero)
				id_parseAll_Lokhttp3_HttpUrl_Lokhttp3_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "parseAll", "(Lokhttp3/HttpUrl;Lokhttp3/Headers;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (url);
				__args [1] = new JValue (headers);
				global::System.Collections.Generic.IList<global::Okhttp3.Cookie> __ret = global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseAll_Lokhttp3_HttpUrl_Lokhttp3_Headers_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_path;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='path' and count(parameter)=0]"
		[Register ("path", "()Ljava/lang/String;", "")]
		public unsafe string Path ()
		{
			if (id_path == IntPtr.Zero)
				id_path = JNIEnv.GetMethodID (class_ref, "path", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_path), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_persistent;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='persistent' and count(parameter)=0]"
		[Register ("persistent", "()Z", "")]
		public unsafe bool Persistent ()
		{
			if (id_persistent == IntPtr.Zero)
				id_persistent = JNIEnv.GetMethodID (class_ref, "persistent", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_persistent);
			} finally {
			}
		}

		static IntPtr id_secure;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='secure' and count(parameter)=0]"
		[Register ("secure", "()Z", "")]
		public unsafe bool Secure ()
		{
			if (id_secure == IntPtr.Zero)
				id_secure = JNIEnv.GetMethodID (class_ref, "secure", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_secure);
			} finally {
			}
		}

		static IntPtr id_value;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()Ljava/lang/String;", "")]
		public unsafe string Value ()
		{
			if (id_value == IntPtr.Zero)
				id_value = JNIEnv.GetMethodID (class_ref, "value", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
