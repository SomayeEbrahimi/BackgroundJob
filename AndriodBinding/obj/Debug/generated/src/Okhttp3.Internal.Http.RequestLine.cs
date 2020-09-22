using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RequestLine']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/RequestLine", DoNotGenerateAcw=true)]
	public sealed partial class RequestLine : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http/RequestLine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestLine); }
		}

		internal RequestLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_get_Lokhttp3_Request_Ljava_net_Proxy_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RequestLine']/method[@name='get' and count(parameter)=2 and parameter[1][@type='okhttp3.Request'] and parameter[2][@type='java.net.Proxy.Type']]"
		[Register ("get", "(Lokhttp3/Request;Ljava/net/Proxy$Type;)Ljava/lang/String;", "")]
		public static unsafe string Get (global::Okhttp3.Request request, global::Java.Net.Proxy.Type proxyType)
		{
			if (id_get_Lokhttp3_Request_Ljava_net_Proxy_Type_ == IntPtr.Zero)
				id_get_Lokhttp3_Request_Ljava_net_Proxy_Type_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Lokhttp3/Request;Ljava/net/Proxy$Type;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (request);
				__args [1] = new JValue (proxyType);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Lokhttp3_Request_Ljava_net_Proxy_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_requestPath_Lokhttp3_HttpUrl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RequestLine']/method[@name='requestPath' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
		[Register ("requestPath", "(Lokhttp3/HttpUrl;)Ljava/lang/String;", "")]
		public static unsafe string RequestPath (global::Okhttp3.HttpUrl url)
		{
			if (id_requestPath_Lokhttp3_HttpUrl_ == IntPtr.Zero)
				id_requestPath_Lokhttp3_HttpUrl_ = JNIEnv.GetStaticMethodID (class_ref, "requestPath", "(Lokhttp3/HttpUrl;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (url);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_requestPath_Lokhttp3_HttpUrl_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
