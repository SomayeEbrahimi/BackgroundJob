using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealResponseBody']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/RealResponseBody", DoNotGenerateAcw=true)]
	public sealed partial class RealResponseBody : global::Okhttp3.ResponseBody {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http/RealResponseBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RealResponseBody); }
		}

		internal RealResponseBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_contentLength;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealResponseBody']/method[@name='contentLength' and count(parameter)=0]"
		[Register ("contentLength", "()J", "")]
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealResponseBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "")]
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
