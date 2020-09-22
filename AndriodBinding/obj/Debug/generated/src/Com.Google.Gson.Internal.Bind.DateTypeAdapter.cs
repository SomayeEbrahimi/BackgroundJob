using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Google.Gson.Stream;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='DateTypeAdapter']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/DateTypeAdapter", DoNotGenerateAcw=true)]
	public sealed partial class DateTypeAdapter : global::Com.Google.Gson.TypeAdapter {


		static IntPtr FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='DateTypeAdapter']/field[@name='FACTORY']"
		[Register ("FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory Factory {
			get {
				if (FACTORY_jfieldId == IntPtr.Zero)
					FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/bind/DateTypeAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateTypeAdapter); }
		}

		internal DateTypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='DateTypeAdapter']/constructor[@name='DateTypeAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateTypeAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateTypeAdapter)) {
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

		static IntPtr id_read_Lcom_google_gson_stream_JsonReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='DateTypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/util/Date;", "")]
		public unsafe global::Java.Util.Date Read (global::Com.Google.Gson.Stream.JsonReader @in)
		{
			if (id_read_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
				id_read_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/google/gson/stream/JsonReader;)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_google_gson_stream_JsonReader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_write_Lcom_google_gson_stream_JsonWriter_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='DateTypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='java.util.Date']]"
		[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/util/Date;)V", "")]
		public unsafe void Write (global::Com.Google.Gson.Stream.JsonWriter @out, global::Java.Util.Date value)
		{
			if (id_write_Lcom_google_gson_stream_JsonWriter_Ljava_util_Date_ == IntPtr.Zero)
				id_write_Lcom_google_gson_stream_JsonWriter_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/google/gson/stream/JsonWriter;Ljava/util/Date;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@out);
				__args [1] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lcom_google_gson_stream_JsonWriter_Ljava_util_Date_, __args);
			} finally {
			}
		}

        public override void Write(JsonWriter p0, Java.Lang.Object p1)
        {
            throw new NotImplementedException();
        }
    }
}
