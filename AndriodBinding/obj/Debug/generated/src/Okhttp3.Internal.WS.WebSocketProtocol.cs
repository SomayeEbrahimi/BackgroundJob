using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.WS {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='WebSocketProtocol']"
	[global::Android.Runtime.Register ("okhttp3/internal/ws/WebSocketProtocol", DoNotGenerateAcw=true)]
	public sealed partial class WebSocketProtocol : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/ws/WebSocketProtocol", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebSocketProtocol); }
		}

		internal WebSocketProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_acceptHeader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='WebSocketProtocol']/method[@name='acceptHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("acceptHeader", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AcceptHeader (string key)
		{
			if (id_acceptHeader_Ljava_lang_String_ == IntPtr.Zero)
				id_acceptHeader_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "acceptHeader", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_acceptHeader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

	}
}
