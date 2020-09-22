using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Response']"
	[global::Android.Runtime.Register ("okhttp3/Response", DoNotGenerateAcw=true)]
	public sealed partial class Response : global::Java.Lang.Object, global::Java.IO.ICloseable {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']"
		[global::Android.Runtime.Register ("okhttp3/Response$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/Response$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/constructor[@name='Response.Builder' and count(parameter)=0]"
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

			static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
				return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddHeader (name, value));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Response$Builder;", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder AddHeader (string name, string value)
			{
				if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Response$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate cb_body_Lokhttp3_ResponseBody_;
#pragma warning disable 0169
			static Delegate GetBody_Lokhttp3_ResponseBody_Handler ()
			{
				if (cb_body_Lokhttp3_ResponseBody_ == null)
					cb_body_Lokhttp3_ResponseBody_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Body_Lokhttp3_ResponseBody_);
				return cb_body_Lokhttp3_ResponseBody_;
			}

			static IntPtr n_Body_Lokhttp3_ResponseBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var body = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Body (body));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_body_Lokhttp3_ResponseBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='body' and count(parameter)=1 and parameter[1][@type='okhttp3.ResponseBody']]"
			[Register ("body", "(Lokhttp3/ResponseBody;)Lokhttp3/Response$Builder;", "GetBody_Lokhttp3_ResponseBody_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Body (global::Okhttp3.ResponseBody body)
			{
				if (id_body_Lokhttp3_ResponseBody_ == IntPtr.Zero)
					id_body_Lokhttp3_ResponseBody_ = JNIEnv.GetMethodID (class_ref, "body", "(Lokhttp3/ResponseBody;)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (body);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_body_Lokhttp3_ResponseBody_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "body", "(Lokhttp3/ResponseBody;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/Response;", "GetBuildHandler")]
			public virtual unsafe global::Okhttp3.Response Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/Response;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lokhttp3/Response;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_cacheResponse_Lokhttp3_Response_;
#pragma warning disable 0169
			static Delegate GetCacheResponse_Lokhttp3_Response_Handler ()
			{
				if (cb_cacheResponse_Lokhttp3_Response_ == null)
					cb_cacheResponse_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CacheResponse_Lokhttp3_Response_);
				return cb_cacheResponse_Lokhttp3_Response_;
			}

			static IntPtr n_CacheResponse_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheResponse)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cacheResponse = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_cacheResponse, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CacheResponse (cacheResponse));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_cacheResponse_Lokhttp3_Response_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='cacheResponse' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
			[Register ("cacheResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;", "GetCacheResponse_Lokhttp3_Response_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder CacheResponse (global::Okhttp3.Response cacheResponse)
			{
				if (id_cacheResponse_Lokhttp3_Response_ == IntPtr.Zero)
					id_cacheResponse_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "cacheResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (cacheResponse);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cacheResponse_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cacheResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_code_I;
#pragma warning disable 0169
			static Delegate GetCode_IHandler ()
			{
				if (cb_code_I == null)
					cb_code_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Code_I);
				return cb_code_I;
			}

			static IntPtr n_Code_I (IntPtr jnienv, IntPtr native__this, int code)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Code (code));
			}
#pragma warning restore 0169

			static IntPtr id_code_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='code' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("code", "(I)Lokhttp3/Response$Builder;", "GetCode_IHandler")]
			public virtual unsafe global::Okhttp3.Response.Builder Code (int code)
			{
				if (id_code_I == IntPtr.Zero)
					id_code_I = JNIEnv.GetMethodID (class_ref, "code", "(I)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (code);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_code_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "code", "(I)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_handshake_Lokhttp3_Handshake_;
#pragma warning disable 0169
			static Delegate GetHandshake_Lokhttp3_Handshake_Handler ()
			{
				if (cb_handshake_Lokhttp3_Handshake_ == null)
					cb_handshake_Lokhttp3_Handshake_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Handshake_Lokhttp3_Handshake_);
				return cb_handshake_Lokhttp3_Handshake_;
			}

			static IntPtr n_Handshake_Lokhttp3_Handshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handshake)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var handshake = global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (native_handshake, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Handshake (handshake));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_handshake_Lokhttp3_Handshake_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='handshake' and count(parameter)=1 and parameter[1][@type='okhttp3.Handshake']]"
			[Register ("handshake", "(Lokhttp3/Handshake;)Lokhttp3/Response$Builder;", "GetHandshake_Lokhttp3_Handshake_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Handshake (global::Okhttp3.Handshake handshake)
			{
				if (id_handshake_Lokhttp3_Handshake_ == IntPtr.Zero)
					id_handshake_Lokhttp3_Handshake_ = JNIEnv.GetMethodID (class_ref, "handshake", "(Lokhttp3/Handshake;)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (handshake);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handshake_Lokhttp3_Handshake_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handshake", "(Lokhttp3/Handshake;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_header_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_header_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_header_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Header_Ljava_lang_String_Ljava_lang_String_);
				return cb_header_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_Header_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Header (name, value));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_header_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='header' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("header", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Response$Builder;", "GetHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Header (string name, string value)
			{
				if (id_header_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_header_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "header", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Response$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_header_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "header", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate cb_headers_Lokhttp3_Headers_;
#pragma warning disable 0169
			static Delegate GetHeaders_Lokhttp3_Headers_Handler ()
			{
				if (cb_headers_Lokhttp3_Headers_ == null)
					cb_headers_Lokhttp3_Headers_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Headers_Lokhttp3_Headers_);
				return cb_headers_Lokhttp3_Headers_;
			}

			static IntPtr n_Headers_Lokhttp3_Headers_ (IntPtr jnienv, IntPtr native__this, IntPtr native_headers)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var headers = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (native_headers, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Headers (headers));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_headers_Lokhttp3_Headers_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='headers' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
			[Register ("headers", "(Lokhttp3/Headers;)Lokhttp3/Response$Builder;", "GetHeaders_Lokhttp3_Headers_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Headers (global::Okhttp3.Headers headers)
			{
				if (id_headers_Lokhttp3_Headers_ == IntPtr.Zero)
					id_headers_Lokhttp3_Headers_ = JNIEnv.GetMethodID (class_ref, "headers", "(Lokhttp3/Headers;)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (headers);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headers_Lokhttp3_Headers_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "headers", "(Lokhttp3/Headers;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_message_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetMessage_Ljava_lang_String_Handler ()
			{
				if (cb_message_Ljava_lang_String_ == null)
					cb_message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Message_Ljava_lang_String_);
				return cb_message_Ljava_lang_String_;
			}

			static IntPtr n_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Message (message));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_message_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='message' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("message", "(Ljava/lang/String;)Lokhttp3/Response$Builder;", "GetMessage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Message (string message)
			{
				if (id_message_Ljava_lang_String_ == IntPtr.Zero)
					id_message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "message", "(Ljava/lang/String;)Lokhttp3/Response$Builder;");
				IntPtr native_message = JNIEnv.NewString (message);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_message);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_message_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "message", "(Ljava/lang/String;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_message);
				}
			}

			static Delegate cb_networkResponse_Lokhttp3_Response_;
#pragma warning disable 0169
			static Delegate GetNetworkResponse_Lokhttp3_Response_Handler ()
			{
				if (cb_networkResponse_Lokhttp3_Response_ == null)
					cb_networkResponse_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NetworkResponse_Lokhttp3_Response_);
				return cb_networkResponse_Lokhttp3_Response_;
			}

			static IntPtr n_NetworkResponse_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_networkResponse)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var networkResponse = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_networkResponse, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NetworkResponse (networkResponse));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_networkResponse_Lokhttp3_Response_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='networkResponse' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
			[Register ("networkResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;", "GetNetworkResponse_Lokhttp3_Response_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder NetworkResponse (global::Okhttp3.Response networkResponse)
			{
				if (id_networkResponse_Lokhttp3_Response_ == IntPtr.Zero)
					id_networkResponse_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "networkResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (networkResponse);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_networkResponse_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "networkResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_priorResponse_Lokhttp3_Response_;
#pragma warning disable 0169
			static Delegate GetPriorResponse_Lokhttp3_Response_Handler ()
			{
				if (cb_priorResponse_Lokhttp3_Response_ == null)
					cb_priorResponse_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PriorResponse_Lokhttp3_Response_);
				return cb_priorResponse_Lokhttp3_Response_;
			}

			static IntPtr n_PriorResponse_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_priorResponse)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var priorResponse = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_priorResponse, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PriorResponse (priorResponse));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_priorResponse_Lokhttp3_Response_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='priorResponse' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
			[Register ("priorResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;", "GetPriorResponse_Lokhttp3_Response_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder PriorResponse (global::Okhttp3.Response priorResponse)
			{
				if (id_priorResponse_Lokhttp3_Response_ == IntPtr.Zero)
					id_priorResponse_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "priorResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (priorResponse);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_priorResponse_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "priorResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_protocol_Lokhttp3_Protocol_;
#pragma warning disable 0169
			static Delegate GetProtocol_Lokhttp3_Protocol_Handler ()
			{
				if (cb_protocol_Lokhttp3_Protocol_ == null)
					cb_protocol_Lokhttp3_Protocol_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Protocol_Lokhttp3_Protocol_);
				return cb_protocol_Lokhttp3_Protocol_;
			}

			static IntPtr n_Protocol_Lokhttp3_Protocol_ (IntPtr jnienv, IntPtr native__this, IntPtr native_protocol)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var protocol = global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (native_protocol, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Protocol (protocol));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_protocol_Lokhttp3_Protocol_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='protocol' and count(parameter)=1 and parameter[1][@type='okhttp3.Protocol']]"
			[Register ("protocol", "(Lokhttp3/Protocol;)Lokhttp3/Response$Builder;", "GetProtocol_Lokhttp3_Protocol_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Protocol (global::Okhttp3.Protocol protocol)
			{
				if (id_protocol_Lokhttp3_Protocol_ == IntPtr.Zero)
					id_protocol_Lokhttp3_Protocol_ = JNIEnv.GetMethodID (class_ref, "protocol", "(Lokhttp3/Protocol;)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (protocol);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_protocol_Lokhttp3_Protocol_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "protocol", "(Lokhttp3/Protocol;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_receivedResponseAtMillis_J;
#pragma warning disable 0169
			static Delegate GetReceivedResponseAtMillis_JHandler ()
			{
				if (cb_receivedResponseAtMillis_J == null)
					cb_receivedResponseAtMillis_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_ReceivedResponseAtMillis_J);
				return cb_receivedResponseAtMillis_J;
			}

			static IntPtr n_ReceivedResponseAtMillis_J (IntPtr jnienv, IntPtr native__this, long receivedResponseAtMillis)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ReceivedResponseAtMillis (receivedResponseAtMillis));
			}
#pragma warning restore 0169

			static IntPtr id_receivedResponseAtMillis_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='receivedResponseAtMillis' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("receivedResponseAtMillis", "(J)Lokhttp3/Response$Builder;", "GetReceivedResponseAtMillis_JHandler")]
			public virtual unsafe global::Okhttp3.Response.Builder ReceivedResponseAtMillis (long receivedResponseAtMillis)
			{
				if (id_receivedResponseAtMillis_J == IntPtr.Zero)
					id_receivedResponseAtMillis_J = JNIEnv.GetMethodID (class_ref, "receivedResponseAtMillis", "(J)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (receivedResponseAtMillis);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_receivedResponseAtMillis_J, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "receivedResponseAtMillis", "(J)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_removeHeader_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRemoveHeader_Ljava_lang_String_Handler ()
			{
				if (cb_removeHeader_Ljava_lang_String_ == null)
					cb_removeHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RemoveHeader_Ljava_lang_String_);
				return cb_removeHeader_Ljava_lang_String_;
			}

			static IntPtr n_RemoveHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveHeader (name));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_removeHeader_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='removeHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeHeader", "(Ljava/lang/String;)Lokhttp3/Response$Builder;", "GetRemoveHeader_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder RemoveHeader (string name)
			{
				if (id_removeHeader_Ljava_lang_String_ == IntPtr.Zero)
					id_removeHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeHeader", "(Ljava/lang/String;)Lokhttp3/Response$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeHeader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeHeader", "(Ljava/lang/String;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_request_Lokhttp3_Request_;
#pragma warning disable 0169
			static Delegate GetRequest_Lokhttp3_Request_Handler ()
			{
				if (cb_request_Lokhttp3_Request_ == null)
					cb_request_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Request_Lokhttp3_Request_);
				return cb_request_Lokhttp3_Request_;
			}

			static IntPtr n_Request_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var request = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_request, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Request (request));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_request_Lokhttp3_Request_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='request' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
			[Register ("request", "(Lokhttp3/Request;)Lokhttp3/Response$Builder;", "GetRequest_Lokhttp3_Request_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Request (global::Okhttp3.Request request)
			{
				if (id_request_Lokhttp3_Request_ == IntPtr.Zero)
					id_request_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "request", "(Lokhttp3/Request;)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (request);

					global::Okhttp3.Response.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_request_Lokhttp3_Request_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Lokhttp3/Request;)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_sentRequestAtMillis_J;
#pragma warning disable 0169
			static Delegate GetSentRequestAtMillis_JHandler ()
			{
				if (cb_sentRequestAtMillis_J == null)
					cb_sentRequestAtMillis_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SentRequestAtMillis_J);
				return cb_sentRequestAtMillis_J;
			}

			static IntPtr n_SentRequestAtMillis_J (IntPtr jnienv, IntPtr native__this, long sentRequestAtMillis)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SentRequestAtMillis (sentRequestAtMillis));
			}
#pragma warning restore 0169

			static IntPtr id_sentRequestAtMillis_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='sentRequestAtMillis' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("sentRequestAtMillis", "(J)Lokhttp3/Response$Builder;", "GetSentRequestAtMillis_JHandler")]
			public virtual unsafe global::Okhttp3.Response.Builder SentRequestAtMillis (long sentRequestAtMillis)
			{
				if (id_sentRequestAtMillis_J == IntPtr.Zero)
					id_sentRequestAtMillis_J = JNIEnv.GetMethodID (class_ref, "sentRequestAtMillis", "(J)Lokhttp3/Response$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (sentRequestAtMillis);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sentRequestAtMillis_J, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sentRequestAtMillis", "(J)Lokhttp3/Response$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Response", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Response); }
		}

		internal Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isRedirect;
		public unsafe bool IsRedirect {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='isRedirect' and count(parameter)=0]"
			[Register ("isRedirect", "()Z", "")]
			get {
				if (id_isRedirect == IntPtr.Zero)
					id_isRedirect = JNIEnv.GetMethodID (class_ref, "isRedirect", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRedirect);
				} finally {
				}
			}
		}

		static IntPtr id_isSuccessful;
		public unsafe bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='isSuccessful' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='body' and count(parameter)=0]"
		[Register ("body", "()Lokhttp3/ResponseBody;", "")]
		public unsafe global::Okhttp3.ResponseBody Body ()
		{
			if (id_body == IntPtr.Zero)
				id_body = JNIEnv.GetMethodID (class_ref, "body", "()Lokhttp3/ResponseBody;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_body), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cacheControl;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='cacheControl' and count(parameter)=0]"
		[Register ("cacheControl", "()Lokhttp3/CacheControl;", "")]
		public unsafe global::Okhttp3.CacheControl CacheControl ()
		{
			if (id_cacheControl == IntPtr.Zero)
				id_cacheControl = JNIEnv.GetMethodID (class_ref, "cacheControl", "()Lokhttp3/CacheControl;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cacheControl), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cacheResponse;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='cacheResponse' and count(parameter)=0]"
		[Register ("cacheResponse", "()Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response CacheResponse ()
		{
			if (id_cacheResponse == IntPtr.Zero)
				id_cacheResponse = JNIEnv.GetMethodID (class_ref, "cacheResponse", "()Lokhttp3/Response;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cacheResponse), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_challenges;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='challenges' and count(parameter)=0]"
		[Register ("challenges", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.Challenge> Challenges ()
		{
			if (id_challenges == IntPtr.Zero)
				id_challenges = JNIEnv.GetMethodID (class_ref, "challenges", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Okhttp3.Challenge>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_challenges), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_code;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='code' and count(parameter)=0]"
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

		static IntPtr id_handshake;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='handshake' and count(parameter)=0]"
		[Register ("handshake", "()Lokhttp3/Handshake;", "")]
		public unsafe global::Okhttp3.Handshake Handshake ()
		{
			if (id_handshake == IntPtr.Zero)
				id_handshake = JNIEnv.GetMethodID (class_ref, "handshake", "()Lokhttp3/Handshake;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handshake), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_header_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='header' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("header", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Header (string name)
		{
			if (id_header_Ljava_lang_String_ == IntPtr.Zero)
				id_header_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "header", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_header_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_header_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='header' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("header", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Header (string name, string defaultValue)
		{
			if (id_header_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_header_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "header", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = JNIEnv.NewString (defaultValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (native_defaultValue);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_header_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static IntPtr id_headers;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='headers' and count(parameter)=0]"
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

		static IntPtr id_headers_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='headers' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("headers", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> Headers (string name)
		{
			if (id_headers_Ljava_lang_String_ == IntPtr.Zero)
				id_headers_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "headers", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headers_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_message;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='message' and count(parameter)=0]"
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

		static IntPtr id_networkResponse;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='networkResponse' and count(parameter)=0]"
		[Register ("networkResponse", "()Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response NetworkResponse ()
		{
			if (id_networkResponse == IntPtr.Zero)
				id_networkResponse = JNIEnv.GetMethodID (class_ref, "networkResponse", "()Lokhttp3/Response;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_networkResponse), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lokhttp3/Response$Builder;", "")]
		public unsafe global::Okhttp3.Response.Builder NewBuilder ()
		{
			if (id_newBuilder == IntPtr.Zero)
				id_newBuilder = JNIEnv.GetMethodID (class_ref, "newBuilder", "()Lokhttp3/Response$Builder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_peekBody_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='peekBody' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("peekBody", "(J)Lokhttp3/ResponseBody;", "")]
		public unsafe global::Okhttp3.ResponseBody PeekBody (long byteCount)
		{
			if (id_peekBody_J == IntPtr.Zero)
				id_peekBody_J = JNIEnv.GetMethodID (class_ref, "peekBody", "(J)Lokhttp3/ResponseBody;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (byteCount);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peekBody_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_priorResponse;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='priorResponse' and count(parameter)=0]"
		[Register ("priorResponse", "()Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response PriorResponse ()
		{
			if (id_priorResponse == IntPtr.Zero)
				id_priorResponse = JNIEnv.GetMethodID (class_ref, "priorResponse", "()Lokhttp3/Response;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_priorResponse), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_protocol;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='protocol' and count(parameter)=0]"
		[Register ("protocol", "()Lokhttp3/Protocol;", "")]
		public unsafe global::Okhttp3.Protocol Protocol ()
		{
			if (id_protocol == IntPtr.Zero)
				id_protocol = JNIEnv.GetMethodID (class_ref, "protocol", "()Lokhttp3/Protocol;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_protocol), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_receivedResponseAtMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='receivedResponseAtMillis' and count(parameter)=0]"
		[Register ("receivedResponseAtMillis", "()J", "")]
		public unsafe long ReceivedResponseAtMillis ()
		{
			if (id_receivedResponseAtMillis == IntPtr.Zero)
				id_receivedResponseAtMillis = JNIEnv.GetMethodID (class_ref, "receivedResponseAtMillis", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_receivedResponseAtMillis);
			} finally {
			}
		}

		static IntPtr id_request;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='request' and count(parameter)=0]"
		[Register ("request", "()Lokhttp3/Request;", "")]
		public unsafe global::Okhttp3.Request Request ()
		{
			if (id_request == IntPtr.Zero)
				id_request = JNIEnv.GetMethodID (class_ref, "request", "()Lokhttp3/Request;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_request), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_sentRequestAtMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='sentRequestAtMillis' and count(parameter)=0]"
		[Register ("sentRequestAtMillis", "()J", "")]
		public unsafe long SentRequestAtMillis ()
		{
			if (id_sentRequestAtMillis == IntPtr.Zero)
				id_sentRequestAtMillis = JNIEnv.GetMethodID (class_ref, "sentRequestAtMillis", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_sentRequestAtMillis);
			} finally {
			}
		}

		static IntPtr id_trailers;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='trailers' and count(parameter)=0]"
		[Register ("trailers", "()Lokhttp3/Headers;", "")]
		public unsafe global::Okhttp3.Headers Trailers ()
		{
			if (id_trailers == IntPtr.Zero)
				id_trailers = JNIEnv.GetMethodID (class_ref, "trailers", "()Lokhttp3/Headers;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trailers), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
