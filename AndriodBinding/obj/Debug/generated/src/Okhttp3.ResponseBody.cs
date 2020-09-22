using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']"
	[global::Android.Runtime.Register ("okhttp3/ResponseBody", DoNotGenerateAcw=true)]
	public abstract partial class ResponseBody : global::Java.Lang.Object, global::Java.IO.ICloseable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/ResponseBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseBody); }
		}

		protected ResponseBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/constructor[@name='ResponseBody' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResponseBody ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ResponseBody)) {
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

		static IntPtr id_byteStream;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='byteStream' and count(parameter)=0]"
		[Register ("byteStream", "()Ljava/io/InputStream;", "")]
		public unsafe global::System.IO.Stream ByteStream ()
		{
			if (id_byteStream == IntPtr.Zero)
				id_byteStream = JNIEnv.GetMethodID (class_ref, "byteStream", "()Ljava/io/InputStream;");
			try {
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_byteStream), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_bytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='bytes' and count(parameter)=0]"
		[Register ("bytes", "()[B", "")]
		public unsafe byte[] Bytes ()
		{
			if (id_bytes == IntPtr.Zero)
				id_bytes = JNIEnv.GetMethodID (class_ref, "bytes", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_bytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_charStream;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='charStream' and count(parameter)=0]"
		[Register ("charStream", "()Ljava/io/Reader;", "")]
		public unsafe global::Java.IO.Reader CharStream ()
		{
			if (id_charStream == IntPtr.Zero)
				id_charStream = JNIEnv.GetMethodID (class_ref, "charStream", "()Ljava/io/Reader;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_charStream), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_contentLength;
#pragma warning disable 0169
		static Delegate GetContentLengthHandler ()
		{
			if (cb_contentLength == null)
				cb_contentLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_ContentLength);
			return cb_contentLength;
		}

		static long n_ContentLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='contentLength' and count(parameter)=0]"
		[Register ("contentLength", "()J", "GetContentLengthHandler")]
		public abstract long ContentLength ();

		static Delegate cb_contentType;
#pragma warning disable 0169
		static Delegate GetContentTypeHandler ()
		{
			if (cb_contentType == null)
				cb_contentType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ContentType);
			return cb_contentType;
		}

		static IntPtr n_ContentType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "GetContentTypeHandler")]
		public abstract global::Okhttp3.MediaType ContentType ();

		static IntPtr id_create_Lokhttp3_MediaType_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='byte[]']]"
		[Register ("create", "(Lokhttp3/MediaType;[B)Lokhttp3/ResponseBody;", "")]
		public static unsafe global::Okhttp3.ResponseBody Create (global::Okhttp3.MediaType contentType, byte[] content)
		{
			if (id_create_Lokhttp3_MediaType_arrayB == IntPtr.Zero)
				id_create_Lokhttp3_MediaType_arrayB = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lokhttp3/MediaType;[B)Lokhttp3/ResponseBody;");
			IntPtr native_content = JNIEnv.NewArray (content);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (contentType);
				__args [1] = new JValue (native_content);
				global::Okhttp3.ResponseBody __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lokhttp3_MediaType_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (content != null) {
					JNIEnv.CopyArray (native_content, content);
					JNIEnv.DeleteLocalRef (native_content);
				}
			}
		}

		static IntPtr id_create_Lokhttp3_MediaType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Lokhttp3/MediaType;Ljava/lang/String;)Lokhttp3/ResponseBody;", "")]
		public static unsafe global::Okhttp3.ResponseBody Create (global::Okhttp3.MediaType contentType, string content)
		{
			if (id_create_Lokhttp3_MediaType_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Lokhttp3_MediaType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lokhttp3/MediaType;Ljava/lang/String;)Lokhttp3/ResponseBody;");
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (contentType);
				__args [1] = new JValue (native_content);
				global::Okhttp3.ResponseBody __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lokhttp3_MediaType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

		static IntPtr id_string;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='string' and count(parameter)=0]"
		[Register ("string", "()Ljava/lang/String;", "")]
		public unsafe string String ()
		{
			if (id_string == IntPtr.Zero)
				id_string = JNIEnv.GetMethodID (class_ref, "string", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_string), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okhttp3/ResponseBody", DoNotGenerateAcw=true)]
	internal partial class ResponseBodyInvoker : ResponseBody {

		public ResponseBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseBodyInvoker); }
		}

		static IntPtr id_contentLength;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='contentLength' and count(parameter)=0]"
		[Register ("contentLength", "()J", "GetContentLengthHandler")]
		public override unsafe long ContentLength ()
		{
			if (id_contentLength == IntPtr.Zero)
				id_contentLength = JNIEnv.GetMethodID (class_ref, "contentLength", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_contentLength);
			} finally {
			}
		}

		static IntPtr id_contentType;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "GetContentTypeHandler")]
		public override unsafe global::Okhttp3.MediaType ContentType ()
		{
			if (id_contentType == IntPtr.Zero)
				id_contentType = JNIEnv.GetMethodID (class_ref, "contentType", "()Lokhttp3/MediaType;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_contentType), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
