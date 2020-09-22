using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/ErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCode : global::Java.Lang.Enum {


		static IntPtr CANCEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='CANCEL']"
		[Register ("CANCEL")]
		public static global::Okhttp3.Internal.Http2.ErrorCode Cancel {
			get {
				if (CANCEL_jfieldId == IntPtr.Zero)
					CANCEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCEL", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCEL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COMPRESSION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='COMPRESSION_ERROR']"
		[Register ("COMPRESSION_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode CompressionError {
			get {
				if (COMPRESSION_ERROR_jfieldId == IntPtr.Zero)
					COMPRESSION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPRESSION_ERROR", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPRESSION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONNECT_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='CONNECT_ERROR']"
		[Register ("CONNECT_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode ConnectError {
			get {
				if (CONNECT_ERROR_jfieldId == IntPtr.Zero)
					CONNECT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECT_ERROR", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECT_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ENHANCE_YOUR_CALM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='ENHANCE_YOUR_CALM']"
		[Register ("ENHANCE_YOUR_CALM")]
		public static global::Okhttp3.Internal.Http2.ErrorCode EnhanceYourCalm {
			get {
				if (ENHANCE_YOUR_CALM_jfieldId == IntPtr.Zero)
					ENHANCE_YOUR_CALM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENHANCE_YOUR_CALM", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENHANCE_YOUR_CALM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FLOW_CONTROL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='FLOW_CONTROL_ERROR']"
		[Register ("FLOW_CONTROL_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode FlowControlError {
			get {
				if (FLOW_CONTROL_ERROR_jfieldId == IntPtr.Zero)
					FLOW_CONTROL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOW_CONTROL_ERROR", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOW_CONTROL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HTTP_1_1_REQUIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='HTTP_1_1_REQUIRED']"
		[Register ("HTTP_1_1_REQUIRED")]
		public static global::Okhttp3.Internal.Http2.ErrorCode Http11Required {
			get {
				if (HTTP_1_1_REQUIRED_jfieldId == IntPtr.Zero)
					HTTP_1_1_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_1_1_REQUIRED", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_1_1_REQUIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INADEQUATE_SECURITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='INADEQUATE_SECURITY']"
		[Register ("INADEQUATE_SECURITY")]
		public static global::Okhttp3.Internal.Http2.ErrorCode InadequateSecurity {
			get {
				if (INADEQUATE_SECURITY_jfieldId == IntPtr.Zero)
					INADEQUATE_SECURITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INADEQUATE_SECURITY", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INADEQUATE_SECURITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTERNAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode InternalError {
			get {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='NO_ERROR']"
		[Register ("NO_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode NoError {
			get {
				if (NO_ERROR_jfieldId == IntPtr.Zero)
					NO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_ERROR", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PROTOCOL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='PROTOCOL_ERROR']"
		[Register ("PROTOCOL_ERROR")]
		public static global::Okhttp3.Internal.Http2.ErrorCode ProtocolError {
			get {
				if (PROTOCOL_ERROR_jfieldId == IntPtr.Zero)
					PROTOCOL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_ERROR", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REFUSED_STREAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='REFUSED_STREAM']"
		[Register ("REFUSED_STREAM")]
		public static global::Okhttp3.Internal.Http2.ErrorCode RefusedStream {
			get {
				if (REFUSED_STREAM_jfieldId == IntPtr.Zero)
					REFUSED_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUSED_STREAM", "Lokhttp3/internal/http2/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUSED_STREAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr httpCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/field[@name='httpCode']"
		[Register ("httpCode")]
		public int HttpCode {
			get {
				if (httpCode_jfieldId == IntPtr.Zero)
					httpCode_jfieldId = JNIEnv.GetFieldID (class_ref, "httpCode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, httpCode_jfieldId);
			}
			set {
				if (httpCode_jfieldId == IntPtr.Zero)
					httpCode_jfieldId = JNIEnv.GetFieldID (class_ref, "httpCode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, httpCode_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http2/ErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCode); }
		}

		internal ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromHttp2_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/method[@name='fromHttp2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromHttp2", "(I)Lokhttp3/internal/http2/ErrorCode;", "")]
		public static unsafe global::Okhttp3.Internal.Http2.ErrorCode FromHttp2 (int code)
		{
			if (id_fromHttp2_I == IntPtr.Zero)
				id_fromHttp2_I = JNIEnv.GetStaticMethodID (class_ref, "fromHttp2", "(I)Lokhttp3/internal/http2/ErrorCode;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromHttp2_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lokhttp3/internal/http2/ErrorCode;", "")]
		public static unsafe global::Okhttp3.Internal.Http2.ErrorCode ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lokhttp3/internal/http2/ErrorCode;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Okhttp3.Internal.Http2.ErrorCode __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='ErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lokhttp3/internal/http2/ErrorCode;", "")]
		public static unsafe global::Okhttp3.Internal.Http2.ErrorCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lokhttp3/internal/http2/ErrorCode;");
			try {
				return (global::Okhttp3.Internal.Http2.ErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Okhttp3.Internal.Http2.ErrorCode));
			} finally {
			}
		}

	}
}
