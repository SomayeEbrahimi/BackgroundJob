using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/StatusLine", DoNotGenerateAcw=true)]
	public sealed partial class StatusLine : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='HTTP_CONTINUE']"
		[Register ("HTTP_CONTINUE")]
		public const int HttpContinue = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='HTTP_PERM_REDIRECT']"
		[Register ("HTTP_PERM_REDIRECT")]
		public const int HttpPermRedirect = (int) 308;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='HTTP_TEMP_REDIRECT']"
		[Register ("HTTP_TEMP_REDIRECT")]
		public const int HttpTempRedirect = (int) 307;

		static IntPtr code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='code']"
		[Register ("code")]
		public int Code {
			get {
				if (code_jfieldId == IntPtr.Zero)
					code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, code_jfieldId);
			}
			set {
				if (code_jfieldId == IntPtr.Zero)
					code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, code_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr message_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='message']"
		[Register ("message")]
		public string Message {
			get {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, message_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, message_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr protocol_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='protocol']"
		[Register ("protocol")]
		public global::Okhttp3.Protocol Protocol {
			get {
				if (protocol_jfieldId == IntPtr.Zero)
					protocol_jfieldId = JNIEnv.GetFieldID (class_ref, "protocol", "Lokhttp3/Protocol;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, protocol_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (protocol_jfieldId == IntPtr.Zero)
					protocol_jfieldId = JNIEnv.GetFieldID (class_ref, "protocol", "Lokhttp3/Protocol;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, protocol_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http/StatusLine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatusLine); }
		}

		internal StatusLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_Protocol_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/constructor[@name='StatusLine' and count(parameter)=3 and parameter[1][@type='okhttp3.Protocol'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lokhttp3/Protocol;ILjava/lang/String;)V", "")]
		public unsafe StatusLine (global::Okhttp3.Protocol protocol, int code, string message)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (protocol);
				__args [1] = new JValue (code);
				__args [2] = new JValue (native_message);
				if (((object) this).GetType () != typeof (StatusLine)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/Protocol;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lokhttp3/Protocol;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lokhttp3_Protocol_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Lokhttp3_Protocol_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/Protocol;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_Protocol_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lokhttp3_Protocol_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_get_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/method[@name='get' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("get", "(Lokhttp3/Response;)Lokhttp3/internal/http/StatusLine;", "")]
		public static unsafe global::Okhttp3.Internal.Http.StatusLine Get (global::Okhttp3.Response response)
		{
			if (id_get_Lokhttp3_Response_ == IntPtr.Zero)
				id_get_Lokhttp3_Response_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Lokhttp3/Response;)Lokhttp3/internal/http/StatusLine;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				global::Okhttp3.Internal.Http.StatusLine __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.StatusLine> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lokhttp3/internal/http/StatusLine;", "")]
		public static unsafe global::Okhttp3.Internal.Http.StatusLine Parse (string statusLine)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lokhttp3/internal/http/StatusLine;");
			IntPtr native_statusLine = JNIEnv.NewString (statusLine);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_statusLine);
				global::Okhttp3.Internal.Http.StatusLine __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.StatusLine> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_statusLine);
			}
		}

	}
}
