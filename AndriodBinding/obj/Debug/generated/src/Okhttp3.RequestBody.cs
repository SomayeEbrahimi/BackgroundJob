using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']"
	[global::Android.Runtime.Register ("okhttp3/RequestBody", DoNotGenerateAcw=true)]
	public abstract partial class RequestBody : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/RequestBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestBody); }
		}

		protected RequestBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/constructor[@name='RequestBody' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestBody ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RequestBody)) {
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

		static Delegate cb_isDuplex;
#pragma warning disable 0169
		static Delegate GetIsDuplexHandler ()
		{
			if (cb_isDuplex == null)
				cb_isDuplex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDuplex);
			return cb_isDuplex;
		}

		static bool n_IsDuplex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDuplex;
		}
#pragma warning restore 0169

		static IntPtr id_isDuplex;
		public virtual unsafe bool IsDuplex {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='isDuplex' and count(parameter)=0]"
			[Register ("isDuplex", "()Z", "GetIsDuplexHandler")]
			get {
				if (id_isDuplex == IntPtr.Zero)
					id_isDuplex = JNIEnv.GetMethodID (class_ref, "isDuplex", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDuplex);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDuplex", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isOneShot;
#pragma warning disable 0169
		static Delegate GetIsOneShotHandler ()
		{
			if (cb_isOneShot == null)
				cb_isOneShot = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsOneShot);
			return cb_isOneShot;
		}

		static bool n_IsOneShot (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOneShot;
		}
#pragma warning restore 0169

		static IntPtr id_isOneShot;
		public virtual unsafe bool IsOneShot {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='isOneShot' and count(parameter)=0]"
			[Register ("isOneShot", "()Z", "GetIsOneShotHandler")]
			get {
				if (id_isOneShot == IntPtr.Zero)
					id_isOneShot = JNIEnv.GetMethodID (class_ref, "isOneShot", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOneShot);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOneShot", "()Z"));
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength ();
		}
#pragma warning restore 0169

		static IntPtr id_contentLength;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='contentLength' and count(parameter)=0]"
		[Register ("contentLength", "()J", "GetContentLengthHandler")]
		public virtual unsafe long ContentLength ()
		{
			if (id_contentLength == IntPtr.Zero)
				id_contentLength = JNIEnv.GetMethodID (class_ref, "contentLength", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_contentLength);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contentLength", "()J"));
			} finally {
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "GetContentTypeHandler")]
		public abstract global::Okhttp3.MediaType ContentType ();

		static IntPtr id_create_Lokhttp3_MediaType_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='byte[]']]"
		[Register ("create", "(Lokhttp3/MediaType;[B)Lokhttp3/RequestBody;", "")]
		public static unsafe global::Okhttp3.RequestBody Create (global::Okhttp3.MediaType contentType, byte[] content)
		{
			if (id_create_Lokhttp3_MediaType_arrayB == IntPtr.Zero)
				id_create_Lokhttp3_MediaType_arrayB = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lokhttp3/MediaType;[B)Lokhttp3/RequestBody;");
			IntPtr native_content = JNIEnv.NewArray (content);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (contentType);
				__args [1] = new JValue (native_content);
				global::Okhttp3.RequestBody __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lokhttp3_MediaType_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (content != null) {
					JNIEnv.CopyArray (native_content, content);
					JNIEnv.DeleteLocalRef (native_content);
				}
			}
		}

		static IntPtr id_create_Lokhttp3_MediaType_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='create' and count(parameter)=4 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("create", "(Lokhttp3/MediaType;[BII)Lokhttp3/RequestBody;", "")]
		public static unsafe global::Okhttp3.RequestBody Create (global::Okhttp3.MediaType contentType, byte[] content, int offset, int byteCount)
		{
			if (id_create_Lokhttp3_MediaType_arrayBII == IntPtr.Zero)
				id_create_Lokhttp3_MediaType_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lokhttp3/MediaType;[BII)Lokhttp3/RequestBody;");
			IntPtr native_content = JNIEnv.NewArray (content);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (contentType);
				__args [1] = new JValue (native_content);
				__args [2] = new JValue (offset);
				__args [3] = new JValue (byteCount);
				global::Okhttp3.RequestBody __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lokhttp3_MediaType_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (content != null) {
					JNIEnv.CopyArray (native_content, content);
					JNIEnv.DeleteLocalRef (native_content);
				}
			}
		}

		static IntPtr id_create_Lokhttp3_MediaType_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='java.io.File']]"
		[Register ("create", "(Lokhttp3/MediaType;Ljava/io/File;)Lokhttp3/RequestBody;", "")]
		public static unsafe global::Okhttp3.RequestBody Create (global::Okhttp3.MediaType contentType, global::Java.IO.File file)
		{
			if (id_create_Lokhttp3_MediaType_Ljava_io_File_ == IntPtr.Zero)
				id_create_Lokhttp3_MediaType_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lokhttp3/MediaType;Ljava/io/File;)Lokhttp3/RequestBody;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (contentType);
				__args [1] = new JValue (file);
				global::Okhttp3.RequestBody __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lokhttp3_MediaType_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create_Lokhttp3_MediaType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Lokhttp3/MediaType;Ljava/lang/String;)Lokhttp3/RequestBody;", "")]
		public static unsafe global::Okhttp3.RequestBody Create (global::Okhttp3.MediaType contentType, string content)
		{
			if (id_create_Lokhttp3_MediaType_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Lokhttp3_MediaType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lokhttp3/MediaType;Ljava/lang/String;)Lokhttp3/RequestBody;");
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (contentType);
				__args [1] = new JValue (native_content);
				global::Okhttp3.RequestBody __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lokhttp3_MediaType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

	}

	[global::Android.Runtime.Register ("okhttp3/RequestBody", DoNotGenerateAcw=true)]
	internal partial class RequestBodyInvoker : RequestBody {

		public RequestBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestBodyInvoker); }
		}

		static IntPtr id_contentType;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='contentType' and count(parameter)=0]"
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
