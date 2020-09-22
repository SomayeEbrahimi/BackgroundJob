using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Retrofit2.Converter.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='retrofit2.converter.gson']/class[@name='GsonConverterFactory']"
	[global::Android.Runtime.Register ("retrofit2/converter/gson/GsonConverterFactory", DoNotGenerateAcw=true)]
	public sealed partial class GsonConverterFactory : global::Retrofit2.ConverterFactory {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("retrofit2/converter/gson/GsonConverterFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GsonConverterFactory); }
		}

		internal GsonConverterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2.converter.gson']/class[@name='GsonConverterFactory']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lretrofit2/converter/gson/GsonConverterFactory;", "")]
		public static unsafe global::Retrofit2.Converter.Gson.GsonConverterFactory Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lretrofit2/converter/gson/GsonConverterFactory;");
			try {
				return global::Java.Lang.Object.GetObject<global::Retrofit2.Converter.Gson.GsonConverterFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_Lcom_google_gson_Gson_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2.converter.gson']/class[@name='GsonConverterFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='com.google.gson.Gson']]"
		[Register ("create", "(Lcom/google/gson/Gson;)Lretrofit2/converter/gson/GsonConverterFactory;", "")]
		public static unsafe global::Retrofit2.Converter.Gson.GsonConverterFactory Create (global::Com.Google.Gson.Gson gson)
		{
			if (id_create_Lcom_google_gson_Gson_ == IntPtr.Zero)
				id_create_Lcom_google_gson_Gson_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/google/gson/Gson;)Lretrofit2/converter/gson/GsonConverterFactory;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (gson);
				global::Retrofit2.Converter.Gson.GsonConverterFactory __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Converter.Gson.GsonConverterFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_google_gson_Gson_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
