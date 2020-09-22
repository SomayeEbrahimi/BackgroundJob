using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']"
	[global::Android.Runtime.Register ("com/google/gson/internal/Streams", DoNotGenerateAcw=true)]
	public sealed partial class Streams : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/Streams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Streams); }
		}

		internal Streams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_parse_Lcom_google_gson_stream_JsonReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("parse", "(Lcom/google/gson/stream/JsonReader;)Lcom/google/gson/JsonElement;", "")]
		public static unsafe global::Com.Google.Gson.JsonElement Parse (global::Com.Google.Gson.Stream.JsonReader reader)
		{
			if (id_parse_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
				id_parse_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Lcom/google/gson/stream/JsonReader;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (reader);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Lcom_google_gson_stream_JsonReader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_write_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='com.google.gson.stream.JsonWriter']]"
		[Register ("write", "(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V", "")]
		public static unsafe void Write (global::Com.Google.Gson.JsonElement element, global::Com.Google.Gson.Stream.JsonWriter writer)
		{
			if (id_write_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_ == IntPtr.Zero)
				id_write_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_ = JNIEnv.GetStaticMethodID (class_ref, "write", "(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (element);
				__args [1] = new JValue (writer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_write_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_, __args);
			} finally {
			}
		}

		static IntPtr id_writerForAppendable_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']/method[@name='writerForAppendable' and count(parameter)=1 and parameter[1][@type='java.lang.Appendable']]"
		[Register ("writerForAppendable", "(Ljava/lang/Appendable;)Ljava/io/Writer;", "")]
		public static unsafe global::Java.IO.Writer WriterForAppendable (global::Java.Lang.IAppendable appendable)
		{
			if (id_writerForAppendable_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_writerForAppendable_Ljava_lang_Appendable_ = JNIEnv.GetStaticMethodID (class_ref, "writerForAppendable", "(Ljava/lang/Appendable;)Ljava/io/Writer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (appendable);
				global::Java.IO.Writer __ret = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_writerForAppendable_Ljava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
