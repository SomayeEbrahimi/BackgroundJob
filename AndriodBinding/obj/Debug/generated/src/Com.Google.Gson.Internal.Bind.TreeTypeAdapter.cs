using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/TreeTypeAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class TreeTypeAdapter : global::Com.Google.Gson.TypeAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/bind/TreeTypeAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TreeTypeAdapter); }
		}

		internal TreeTypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_gson_JsonSerializer_Lcom_google_gson_JsonDeserializer_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_Lcom_google_gson_TypeAdapterFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/constructor[@name='TreeTypeAdapter' and count(parameter)=5 and parameter[1][@type='com.google.gson.JsonSerializer&lt;T&gt;'] and parameter[2][@type='com.google.gson.JsonDeserializer&lt;T&gt;'] and parameter[3][@type='com.google.gson.Gson'] and parameter[4][@type='com.google.gson.reflect.TypeToken&lt;T&gt;'] and parameter[5][@type='com.google.gson.TypeAdapterFactory']]"
		[Register (".ctor", "(Lcom/google/gson/JsonSerializer;Lcom/google/gson/JsonDeserializer;Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;Lcom/google/gson/TypeAdapterFactory;)V", "")]
		public unsafe TreeTypeAdapter (global::Com.Google.Gson.IJsonSerializer serializer, global::Com.Google.Gson.IJsonDeserializer deserializer, global::Com.Google.Gson.Gson gson, global::Com.Google.Gson.Reflect.TypeToken typeToken, global::Com.Google.Gson.ITypeAdapterFactory skipPast)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (serializer);
				__args [1] = new JValue (deserializer);
				__args [2] = new JValue (gson);
				__args [3] = new JValue (typeToken);
				__args [4] = new JValue (skipPast);
				if (((object) this).GetType () != typeof (TreeTypeAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/google/gson/JsonSerializer;Lcom/google/gson/JsonDeserializer;Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;Lcom/google/gson/TypeAdapterFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/gson/JsonSerializer;Lcom/google/gson/JsonDeserializer;Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;Lcom/google/gson/TypeAdapterFactory;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_gson_JsonSerializer_Lcom_google_gson_JsonDeserializer_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_Lcom_google_gson_TypeAdapterFactory_ == IntPtr.Zero)
					id_ctor_Lcom_google_gson_JsonSerializer_Lcom_google_gson_JsonDeserializer_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_Lcom_google_gson_TypeAdapterFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/gson/JsonSerializer;Lcom/google/gson/JsonDeserializer;Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;Lcom/google/gson/TypeAdapterFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_gson_JsonSerializer_Lcom_google_gson_JsonDeserializer_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_Lcom_google_gson_TypeAdapterFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_gson_JsonSerializer_Lcom_google_gson_JsonDeserializer_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_Lcom_google_gson_TypeAdapterFactory_, __args);
			} finally {
			}
		}

		static IntPtr id_newFactory_Lcom_google_gson_reflect_TypeToken_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/method[@name='newFactory' and count(parameter)=2 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;?&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("newFactory", "(Lcom/google/gson/reflect/TypeToken;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;", "")]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewFactory (global::Com.Google.Gson.Reflect.TypeToken exactType, global::Java.Lang.Object typeAdapter)
		{
			if (id_newFactory_Lcom_google_gson_reflect_TypeToken_Ljava_lang_Object_ == IntPtr.Zero)
				id_newFactory_Lcom_google_gson_reflect_TypeToken_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "newFactory", "(Lcom/google/gson/reflect/TypeToken;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (exactType);
				__args [1] = new JValue (typeAdapter);
				global::Com.Google.Gson.ITypeAdapterFactory __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newFactory_Lcom_google_gson_reflect_TypeToken_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newFactoryWithMatchRawType_Lcom_google_gson_reflect_TypeToken_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/method[@name='newFactoryWithMatchRawType' and count(parameter)=2 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;?&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("newFactoryWithMatchRawType", "(Lcom/google/gson/reflect/TypeToken;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;", "")]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewFactoryWithMatchRawType (global::Com.Google.Gson.Reflect.TypeToken exactType, global::Java.Lang.Object typeAdapter)
		{
			if (id_newFactoryWithMatchRawType_Lcom_google_gson_reflect_TypeToken_Ljava_lang_Object_ == IntPtr.Zero)
				id_newFactoryWithMatchRawType_Lcom_google_gson_reflect_TypeToken_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "newFactoryWithMatchRawType", "(Lcom/google/gson/reflect/TypeToken;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (exactType);
				__args [1] = new JValue (typeAdapter);
				global::Com.Google.Gson.ITypeAdapterFactory __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newFactoryWithMatchRawType_Lcom_google_gson_reflect_TypeToken_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newTypeHierarchyFactory_Ljava_lang_Class_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/method[@name='newTypeHierarchyFactory' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("newTypeHierarchyFactory", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;", "")]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewTypeHierarchyFactory (global::Java.Lang.Class hierarchyType, global::Java.Lang.Object typeAdapter)
		{
			if (id_newTypeHierarchyFactory_Ljava_lang_Class_Ljava_lang_Object_ == IntPtr.Zero)
				id_newTypeHierarchyFactory_Ljava_lang_Class_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "newTypeHierarchyFactory", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/google/gson/TypeAdapterFactory;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (hierarchyType);
				__args [1] = new JValue (typeAdapter);
				global::Com.Google.Gson.ITypeAdapterFactory __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newTypeHierarchyFactory_Ljava_lang_Class_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_read_Lcom_google_gson_stream_JsonReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader @in)
		{
			if (id_read_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
				id_read_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_google_gson_stream_JsonReader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TreeTypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
		[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V", "")]
		public override unsafe void Write (global::Com.Google.Gson.Stream.JsonWriter @out, global::Java.Lang.Object value)
		{
			if (id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ == IntPtr.Zero)
				id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@out);
				__args [1] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
