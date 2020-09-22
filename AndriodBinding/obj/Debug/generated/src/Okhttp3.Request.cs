using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Request']"
	[global::Android.Runtime.Register ("okhttp3/Request", DoNotGenerateAcw=true)]
	public sealed partial class Request : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']"
		[global::Android.Runtime.Register ("okhttp3/Request$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/Request$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/constructor[@name='Request.Builder' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddHeader (name, value));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Request$Builder;", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder AddHeader (string name, string value)
			{
				if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Request$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
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
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/Request;", "GetBuildHandler")]
			public virtual unsafe global::Okhttp3.Request Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/Request;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lokhttp3/Request;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_cacheControl_Lokhttp3_CacheControl_;
#pragma warning disable 0169
			static Delegate GetCacheControl_Lokhttp3_CacheControl_Handler ()
			{
				if (cb_cacheControl_Lokhttp3_CacheControl_ == null)
					cb_cacheControl_Lokhttp3_CacheControl_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CacheControl_Lokhttp3_CacheControl_);
				return cb_cacheControl_Lokhttp3_CacheControl_;
			}

			static IntPtr n_CacheControl_Lokhttp3_CacheControl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheControl)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cacheControl = global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (native_cacheControl, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CacheControl (cacheControl));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_cacheControl_Lokhttp3_CacheControl_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='cacheControl' and count(parameter)=1 and parameter[1][@type='okhttp3.CacheControl']]"
			[Register ("cacheControl", "(Lokhttp3/CacheControl;)Lokhttp3/Request$Builder;", "GetCacheControl_Lokhttp3_CacheControl_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder CacheControl (global::Okhttp3.CacheControl cacheControl)
			{
				if (id_cacheControl_Lokhttp3_CacheControl_ == IntPtr.Zero)
					id_cacheControl_Lokhttp3_CacheControl_ = JNIEnv.GetMethodID (class_ref, "cacheControl", "(Lokhttp3/CacheControl;)Lokhttp3/Request$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (cacheControl);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cacheControl_Lokhttp3_CacheControl_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cacheControl", "(Lokhttp3/CacheControl;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_delete;
#pragma warning disable 0169
			static Delegate GetDeleteHandler ()
			{
				if (cb_delete == null)
					cb_delete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Delete);
				return cb_delete;
			}

			static IntPtr n_Delete (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Delete ());
			}
#pragma warning restore 0169

			static IntPtr id_delete;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='delete' and count(parameter)=0]"
			[Register ("delete", "()Lokhttp3/Request$Builder;", "GetDeleteHandler")]
			public virtual unsafe global::Okhttp3.Request.Builder Delete ()
			{
				if (id_delete == IntPtr.Zero)
					id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()Lokhttp3/Request$Builder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delete), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "()Lokhttp3/Request$Builder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_delete_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetDelete_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_delete_Lokhttp3_RequestBody_ == null)
					cb_delete_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Delete_Lokhttp3_RequestBody_);
				return cb_delete_Lokhttp3_RequestBody_;
			}

			static IntPtr n_Delete_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var body = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Delete (body));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_delete_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("delete", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetDelete_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Delete (global::Okhttp3.RequestBody body)
			{
				if (id_delete_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_delete_Lokhttp3_RequestBody_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (body);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delete_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_get;
#pragma warning disable 0169
			static Delegate GetGetHandler ()
			{
				if (cb_get == null)
					cb_get = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Get);
				return cb_get;
			}

			static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Get ());
			}
#pragma warning restore 0169

			static IntPtr id_get;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='get' and count(parameter)=0]"
			[Register ("get", "()Lokhttp3/Request$Builder;", "GetGetHandler")]
			public virtual unsafe global::Okhttp3.Request.Builder Get ()
			{
				if (id_get == IntPtr.Zero)
					id_get = JNIEnv.GetMethodID (class_ref, "get", "()Lokhttp3/Request$Builder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()Lokhttp3/Request$Builder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_head;
#pragma warning disable 0169
			static Delegate GetHeadHandler ()
			{
				if (cb_head == null)
					cb_head = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Head);
				return cb_head;
			}

			static IntPtr n_Head (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Head ());
			}
#pragma warning restore 0169

			static IntPtr id_head;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='head' and count(parameter)=0]"
			[Register ("head", "()Lokhttp3/Request$Builder;", "GetHeadHandler")]
			public virtual unsafe global::Okhttp3.Request.Builder Head ()
			{
				if (id_head == IntPtr.Zero)
					id_head = JNIEnv.GetMethodID (class_ref, "head", "()Lokhttp3/Request$Builder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_head), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "head", "()Lokhttp3/Request$Builder;")), JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Header (name, value));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_header_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='header' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("header", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Request$Builder;", "GetHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Header (string name, string value)
			{
				if (id_header_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_header_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "header", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Request$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_header_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "header", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var headers = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (native_headers, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Headers (headers));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_headers_Lokhttp3_Headers_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='headers' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
			[Register ("headers", "(Lokhttp3/Headers;)Lokhttp3/Request$Builder;", "GetHeaders_Lokhttp3_Headers_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Headers (global::Okhttp3.Headers headers)
			{
				if (id_headers_Lokhttp3_Headers_ == IntPtr.Zero)
					id_headers_Lokhttp3_Headers_ = JNIEnv.GetMethodID (class_ref, "headers", "(Lokhttp3/Headers;)Lokhttp3/Request$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (headers);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headers_Lokhttp3_Headers_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "headers", "(Lokhttp3/Headers;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_method_Ljava_lang_String_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetMethod_Ljava_lang_String_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_method_Ljava_lang_String_Lokhttp3_RequestBody_ == null)
					cb_method_Ljava_lang_String_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Method_Ljava_lang_String_Lokhttp3_RequestBody_);
				return cb_method_Ljava_lang_String_Lokhttp3_RequestBody_;
			}

			static IntPtr n_Method_Ljava_lang_String_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_method, IntPtr native_body)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var method = JNIEnv.GetString (native_method, JniHandleOwnership.DoNotTransfer);
				var body = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Method (method, body));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_method_Ljava_lang_String_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='method' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='okhttp3.RequestBody']]"
			[Register ("method", "(Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetMethod_Ljava_lang_String_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Method (string method, global::Okhttp3.RequestBody body)
			{
				if (id_method_Ljava_lang_String_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_method_Ljava_lang_String_Lokhttp3_RequestBody_ = JNIEnv.GetMethodID (class_ref, "method", "(Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;");
				IntPtr native_method = JNIEnv.NewString (method);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_method);
					__args [1] = new JValue (body);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_method_Ljava_lang_String_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "method", "(Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_method);
				}
			}

			static Delegate cb_patch_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetPatch_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_patch_Lokhttp3_RequestBody_ == null)
					cb_patch_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Patch_Lokhttp3_RequestBody_);
				return cb_patch_Lokhttp3_RequestBody_;
			}

			static IntPtr n_Patch_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var body = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Patch (body));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_patch_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='patch' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("patch", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetPatch_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Patch (global::Okhttp3.RequestBody body)
			{
				if (id_patch_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_patch_Lokhttp3_RequestBody_ = JNIEnv.GetMethodID (class_ref, "patch", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (body);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_patch_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "patch", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_post_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetPost_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_post_Lokhttp3_RequestBody_ == null)
					cb_post_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Post_Lokhttp3_RequestBody_);
				return cb_post_Lokhttp3_RequestBody_;
			}

			static IntPtr n_Post_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var body = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (body));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_post_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='post' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("post", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetPost_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Post (global::Okhttp3.RequestBody body)
			{
				if (id_post_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_post_Lokhttp3_RequestBody_ = JNIEnv.GetMethodID (class_ref, "post", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (body);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_put_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetPut_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_put_Lokhttp3_RequestBody_ == null)
					cb_put_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Put_Lokhttp3_RequestBody_);
				return cb_put_Lokhttp3_RequestBody_;
			}

			static IntPtr n_Put_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var body = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (body));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_put_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='put' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("put", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetPut_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Put (global::Okhttp3.RequestBody body)
			{
				if (id_put_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_put_Lokhttp3_RequestBody_ = JNIEnv.GetMethodID (class_ref, "put", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (body);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_put_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
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
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveHeader (name));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_removeHeader_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='removeHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeHeader", "(Ljava/lang/String;)Lokhttp3/Request$Builder;", "GetRemoveHeader_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder RemoveHeader (string name)
			{
				if (id_removeHeader_Ljava_lang_String_ == IntPtr.Zero)
					id_removeHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeHeader", "(Ljava/lang/String;)Lokhttp3/Request$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeHeader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeHeader", "(Ljava/lang/String;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_tag_Ljava_lang_Class_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetTag_Ljava_lang_Class_Ljava_lang_Object_Handler ()
			{
				if (cb_tag_Ljava_lang_Class_Ljava_lang_Object_ == null)
					cb_tag_Ljava_lang_Class_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Tag_Ljava_lang_Class_Ljava_lang_Object_);
				return cb_tag_Ljava_lang_Class_Ljava_lang_Object_;
			}

			static IntPtr n_Tag_Ljava_lang_Class_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_tag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var type = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_type, JniHandleOwnership.DoNotTransfer);
				var tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Tag (type, tag));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_tag_Ljava_lang_Class_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='tag' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? super T&gt;'] and parameter[2][@type='T']]"
			[Register ("tag", "(Ljava/lang/Class;Ljava/lang/Object;)Lokhttp3/Request$Builder;", "GetTag_Ljava_lang_Class_Ljava_lang_Object_Handler")]
			[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
			public virtual unsafe global::Okhttp3.Request.Builder Tag (global::Java.Lang.Class type, global::Java.Lang.Object tag)
			{
				if (id_tag_Ljava_lang_Class_Ljava_lang_Object_ == IntPtr.Zero)
					id_tag_Ljava_lang_Class_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "tag", "(Ljava/lang/Class;Ljava/lang/Object;)Lokhttp3/Request$Builder;");
				IntPtr native_tag = JNIEnv.ToLocalJniHandle (tag);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (type);
					__args [1] = new JValue (native_tag);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tag_Ljava_lang_Class_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tag", "(Ljava/lang/Class;Ljava/lang/Object;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_tag);
				}
			}

			static Delegate cb_tag_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetTag_Ljava_lang_Object_Handler ()
			{
				if (cb_tag_Ljava_lang_Object_ == null)
					cb_tag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Tag_Ljava_lang_Object_);
				return cb_tag_Ljava_lang_Object_;
			}

			static IntPtr n_Tag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Tag (tag));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_tag_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='tag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("tag", "(Ljava/lang/Object;)Lokhttp3/Request$Builder;", "GetTag_Ljava_lang_Object_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Tag (global::Java.Lang.Object tag)
			{
				if (id_tag_Ljava_lang_Object_ == IntPtr.Zero)
					id_tag_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "tag", "(Ljava/lang/Object;)Lokhttp3/Request$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (tag);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tag_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tag", "(Ljava/lang/Object;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_url_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetUrl_Ljava_lang_String_Handler ()
			{
				if (cb_url_Ljava_lang_String_ == null)
					cb_url_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Url_Ljava_lang_String_);
				return cb_url_Ljava_lang_String_;
			}

			static IntPtr n_Url_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Url (url));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_url_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='url' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("url", "(Ljava/lang/String;)Lokhttp3/Request$Builder;", "GetUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Url (string url)
			{
				if (id_url_Ljava_lang_String_ == IntPtr.Zero)
					id_url_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "url", "(Ljava/lang/String;)Lokhttp3/Request$Builder;");
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_url);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_url_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "url", "(Ljava/lang/String;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_url);
				}
			}

			static Delegate cb_url_Ljava_net_URL_;
#pragma warning disable 0169
			static Delegate GetUrl_Ljava_net_URL_Handler ()
			{
				if (cb_url_Ljava_net_URL_ == null)
					cb_url_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Url_Ljava_net_URL_);
				return cb_url_Ljava_net_URL_;
			}

			static IntPtr n_Url_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Url (url));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_url_Ljava_net_URL_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='url' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
			[Register ("url", "(Ljava/net/URL;)Lokhttp3/Request$Builder;", "GetUrl_Ljava_net_URL_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Url (global::Java.Net.URL url)
			{
				if (id_url_Ljava_net_URL_ == IntPtr.Zero)
					id_url_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "url", "(Ljava/net/URL;)Lokhttp3/Request$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (url);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_url_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "url", "(Ljava/net/URL;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_url_Lokhttp3_HttpUrl_;
#pragma warning disable 0169
			static Delegate GetUrl_Lokhttp3_HttpUrl_Handler ()
			{
				if (cb_url_Lokhttp3_HttpUrl_ == null)
					cb_url_Lokhttp3_HttpUrl_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Url_Lokhttp3_HttpUrl_);
				return cb_url_Lokhttp3_HttpUrl_;
			}

			static IntPtr n_Url_Lokhttp3_HttpUrl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var url = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (native_url, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Url (url));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_url_Lokhttp3_HttpUrl_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='url' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
			[Register ("url", "(Lokhttp3/HttpUrl;)Lokhttp3/Request$Builder;", "GetUrl_Lokhttp3_HttpUrl_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Url (global::Okhttp3.HttpUrl url)
			{
				if (id_url_Lokhttp3_HttpUrl_ == IntPtr.Zero)
					id_url_Lokhttp3_HttpUrl_ = JNIEnv.GetMethodID (class_ref, "url", "(Lokhttp3/HttpUrl;)Lokhttp3/Request$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (url);

					global::Okhttp3.Request.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_url_Lokhttp3_HttpUrl_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "url", "(Lokhttp3/HttpUrl;)Lokhttp3/Request$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Request", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Request); }
		}

		internal Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isHttps;
		public unsafe bool IsHttps {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='isHttps' and count(parameter)=0]"
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

		static IntPtr id_body;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='body' and count(parameter)=0]"
		[Register ("body", "()Lokhttp3/RequestBody;", "")]
		public unsafe global::Okhttp3.RequestBody Body ()
		{
			if (id_body == IntPtr.Zero)
				id_body = JNIEnv.GetMethodID (class_ref, "body", "()Lokhttp3/RequestBody;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_body), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cacheControl;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='cacheControl' and count(parameter)=0]"
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

		static IntPtr id_header_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='header' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_headers;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='headers' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='headers' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_method;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='method' and count(parameter)=0]"
		[Register ("method", "()Ljava/lang/String;", "")]
		public unsafe string Method ()
		{
			if (id_method == IntPtr.Zero)
				id_method = JNIEnv.GetMethodID (class_ref, "method", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_method), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lokhttp3/Request$Builder;", "")]
		public unsafe global::Okhttp3.Request.Builder NewBuilder ()
		{
			if (id_newBuilder == IntPtr.Zero)
				id_newBuilder = JNIEnv.GetMethodID (class_ref, "newBuilder", "()Lokhttp3/Request$Builder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_tag;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='tag' and count(parameter)=0]"
		[Register ("tag", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Tag ()
		{
			if (id_tag == IntPtr.Zero)
				id_tag = JNIEnv.GetMethodID (class_ref, "tag", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tag), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_tag_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='tag' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends T&gt;']]"
		[Register ("tag", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object Tag (global::Java.Lang.Class type)
		{
			if (id_tag_Ljava_lang_Class_ == IntPtr.Zero)
				id_tag_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "tag", "(Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tag_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_url;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Lokhttp3/HttpUrl;", "")]
		public unsafe global::Okhttp3.HttpUrl Url ()
		{
			if (id_url == IntPtr.Zero)
				id_url = JNIEnv.GetMethodID (class_ref, "url", "()Lokhttp3/HttpUrl;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_url), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
