using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']"
	[global::Android.Runtime.Register ("com/google/gson/Gson", DoNotGenerateAcw=true)]
	public sealed partial class Gson : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/Gson", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Gson); }
		}

		internal Gson (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/constructor[@name='Gson' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Gson ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Gson)) {
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

		static IntPtr id_excluder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='excluder' and count(parameter)=0]"
		[Register ("excluder", "()Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder Excluder ()
		{
			if (id_excluder == IntPtr.Zero)
				id_excluder = JNIEnv.GetMethodID (class_ref, "excluder", "()Lcom/google/gson/internal/Excluder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_excluder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fieldNamingStrategy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fieldNamingStrategy' and count(parameter)=0]"
		[Register ("fieldNamingStrategy", "()Lcom/google/gson/FieldNamingStrategy;", "")]
		public unsafe global::Com.Google.Gson.IFieldNamingStrategy FieldNamingStrategy ()
		{
			if (id_fieldNamingStrategy == IntPtr.Zero)
				id_fieldNamingStrategy = JNIEnv.GetMethodID (class_ref, "fieldNamingStrategy", "()Lcom/google/gson/FieldNamingStrategy;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IFieldNamingStrategy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fieldNamingStrategy), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Lcom/google/gson/JsonElement;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Com.Google.Gson.JsonElement json, global::Java.Lang.Class classOfT)
		{
			if (id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_Class_ == IntPtr.Zero)
				id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Lcom/google/gson/JsonElement;Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (json);
				__args [1] = new JValue (classOfT);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Com.Google.Gson.JsonElement json, global::Java.Lang.Reflect.IType typeOfT)
		{
			if (id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (json);
				__args [1] = new JValue (typeOfT);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Lcom_google_gson_stream_JsonReader_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonReader'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Lcom/google/gson/stream/JsonReader;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Com.Google.Gson.Stream.JsonReader reader, global::Java.Lang.Reflect.IType typeOfT)
		{
			if (id_fromJson_Lcom_google_gson_stream_JsonReader_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_fromJson_Lcom_google_gson_stream_JsonReader_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Lcom/google/gson/stream/JsonReader;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (reader);
				__args [1] = new JValue (typeOfT);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Lcom_google_gson_stream_JsonReader_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Ljava_io_Reader_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Ljava/io/Reader;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Java.IO.Reader json, global::Java.Lang.Class classOfT)
		{
			if (id_fromJson_Ljava_io_Reader_Ljava_lang_Class_ == IntPtr.Zero)
				id_fromJson_Ljava_io_Reader_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/io/Reader;Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (json);
				__args [1] = new JValue (classOfT);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Ljava_io_Reader_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Ljava_io_Reader_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Ljava/io/Reader;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Java.IO.Reader json, global::Java.Lang.Reflect.IType typeOfT)
		{
			if (id_fromJson_Ljava_io_Reader_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_fromJson_Ljava_io_Reader_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/io/Reader;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (json);
				__args [1] = new JValue (typeOfT);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Ljava_io_Reader_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (string json, global::Java.Lang.Class classOfT)
		{
			if (id_fromJson_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_fromJson_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_json);
				__args [1] = new JValue (classOfT);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static IntPtr id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (string json, global::Java.Lang.Reflect.IType typeOfT)
		{
			if (id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_json);
				__args [1] = new JValue (typeOfT);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static IntPtr id_getAdapter_Lcom_google_gson_reflect_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='getAdapter' and count(parameter)=1 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("getAdapter", "(Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter GetAdapter (global::Com.Google.Gson.Reflect.TypeToken type)
		{
			if (id_getAdapter_Lcom_google_gson_reflect_TypeToken_ == IntPtr.Zero)
				id_getAdapter_Lcom_google_gson_reflect_TypeToken_ = JNIEnv.GetMethodID (class_ref, "getAdapter", "(Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::Com.Google.Gson.TypeAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapter_Lcom_google_gson_reflect_TypeToken_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAdapter_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='getAdapter' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAdapter", "(Ljava/lang/Class;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter GetAdapter (global::Java.Lang.Class type)
		{
			if (id_getAdapter_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAdapter_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getAdapter", "(Ljava/lang/Class;)Lcom/google/gson/TypeAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::Com.Google.Gson.TypeAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapter_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDelegateAdapter_Lcom_google_gson_TypeAdapterFactory_Lcom_google_gson_reflect_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='getDelegateAdapter' and count(parameter)=2 and parameter[1][@type='com.google.gson.TypeAdapterFactory'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("getDelegateAdapter", "(Lcom/google/gson/TypeAdapterFactory;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter GetDelegateAdapter (global::Com.Google.Gson.ITypeAdapterFactory skipPast, global::Com.Google.Gson.Reflect.TypeToken type)
		{
			if (id_getDelegateAdapter_Lcom_google_gson_TypeAdapterFactory_Lcom_google_gson_reflect_TypeToken_ == IntPtr.Zero)
				id_getDelegateAdapter_Lcom_google_gson_TypeAdapterFactory_Lcom_google_gson_reflect_TypeToken_ = JNIEnv.GetMethodID (class_ref, "getDelegateAdapter", "(Lcom/google/gson/TypeAdapterFactory;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (skipPast);
				__args [1] = new JValue (type);
				global::Com.Google.Gson.TypeAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDelegateAdapter_Lcom_google_gson_TypeAdapterFactory_Lcom_google_gson_reflect_TypeToken_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_htmlSafe;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='htmlSafe' and count(parameter)=0]"
		[Register ("htmlSafe", "()Z", "")]
		public unsafe bool HtmlSafe ()
		{
			if (id_htmlSafe == IntPtr.Zero)
				id_htmlSafe = JNIEnv.GetMethodID (class_ref, "htmlSafe", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_htmlSafe);
			} finally {
			}
		}

		static IntPtr id_newBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder NewBuilder ()
		{
			if (id_newBuilder == IntPtr.Zero)
				id_newBuilder = JNIEnv.GetMethodID (class_ref, "newBuilder", "()Lcom/google/gson/GsonBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newJsonReader_Ljava_io_Reader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='newJsonReader' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("newJsonReader", "(Ljava/io/Reader;)Lcom/google/gson/stream/JsonReader;", "")]
		public unsafe global::Com.Google.Gson.Stream.JsonReader NewJsonReader (global::Java.IO.Reader reader)
		{
			if (id_newJsonReader_Ljava_io_Reader_ == IntPtr.Zero)
				id_newJsonReader_Ljava_io_Reader_ = JNIEnv.GetMethodID (class_ref, "newJsonReader", "(Ljava/io/Reader;)Lcom/google/gson/stream/JsonReader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (reader);
				global::Com.Google.Gson.Stream.JsonReader __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newJsonReader_Ljava_io_Reader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newJsonWriter_Ljava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='newJsonWriter' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register ("newJsonWriter", "(Ljava/io/Writer;)Lcom/google/gson/stream/JsonWriter;", "")]
		public unsafe global::Com.Google.Gson.Stream.JsonWriter NewJsonWriter (global::Java.IO.Writer writer)
		{
			if (id_newJsonWriter_Ljava_io_Writer_ == IntPtr.Zero)
				id_newJsonWriter_Ljava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "newJsonWriter", "(Ljava/io/Writer;)Lcom/google/gson/stream/JsonWriter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (writer);
				global::Com.Google.Gson.Stream.JsonWriter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newJsonWriter_Ljava_io_Writer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_serializeNulls;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='serializeNulls' and count(parameter)=0]"
		[Register ("serializeNulls", "()Z", "")]
		public unsafe bool SerializeNulls ()
		{
			if (id_serializeNulls == IntPtr.Zero)
				id_serializeNulls = JNIEnv.GetMethodID (class_ref, "serializeNulls", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_serializeNulls);
			} finally {
			}
		}

		static IntPtr id_toJson_Lcom_google_gson_JsonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("toJson", "(Lcom/google/gson/JsonElement;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Com.Google.Gson.JsonElement jsonElement)
		{
			if (id_toJson_Lcom_google_gson_JsonElement_ == IntPtr.Zero)
				id_toJson_Lcom_google_gson_JsonElement_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Lcom/google/gson/JsonElement;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (jsonElement);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Lcom_google_gson_JsonElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toJson_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='com.google.gson.stream.JsonWriter']]"
		[Register ("toJson", "(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V", "")]
		public unsafe void ToJson (global::Com.Google.Gson.JsonElement jsonElement, global::Com.Google.Gson.Stream.JsonWriter writer)
		{
			if (id_toJson_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_ == IntPtr.Zero)
				id_toJson_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (jsonElement);
				__args [1] = new JValue (writer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_, __args);
			} finally {
			}
		}

		static IntPtr id_toJson_Lcom_google_gson_JsonElement_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.Appendable']]"
		[Register ("toJson", "(Lcom/google/gson/JsonElement;Ljava/lang/Appendable;)V", "")]
		public unsafe void ToJson (global::Com.Google.Gson.JsonElement jsonElement, global::Java.Lang.IAppendable writer)
		{
			if (id_toJson_Lcom_google_gson_JsonElement_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_toJson_Lcom_google_gson_JsonElement_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Lcom/google/gson/JsonElement;Ljava/lang/Appendable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (jsonElement);
				__args [1] = new JValue (writer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Lcom_google_gson_JsonElement_Ljava_lang_Appendable_, __args);
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toJson", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Java.Lang.Object src)
		{
			if (id_toJson_Ljava_lang_Object_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (src);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Appendable']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/Appendable;)V", "")]
		public unsafe void ToJson (global::Java.Lang.Object src, global::Java.Lang.IAppendable writer)
		{
			if (id_toJson_Ljava_lang_Object_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;Ljava/lang/Appendable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (src);
				__args [1] = new JValue (writer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_Ljava_lang_Appendable_, __args);
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Java.Lang.Object src, global::Java.Lang.Reflect.IType typeOfSrc)
		{
			if (id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (src);
				__args [1] = new JValue (typeOfSrc);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_stream_JsonWriter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='com.google.gson.stream.JsonWriter']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Lcom/google/gson/stream/JsonWriter;)V", "")]
		public unsafe void ToJson (global::Java.Lang.Object src, global::Java.Lang.Reflect.IType typeOfSrc, global::Com.Google.Gson.Stream.JsonWriter writer)
		{
			if (id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_stream_JsonWriter_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_stream_JsonWriter_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Lcom/google/gson/stream/JsonWriter;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (src);
				__args [1] = new JValue (typeOfSrc);
				__args [2] = new JValue (writer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_stream_JsonWriter_, __args);
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='java.lang.Appendable']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/Appendable;)V", "")]
		public unsafe void ToJson (global::Java.Lang.Object src, global::Java.Lang.Reflect.IType typeOfSrc, global::Java.Lang.IAppendable writer)
		{
			if (id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/Appendable;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (src);
				__args [1] = new JValue (typeOfSrc);
				__args [2] = new JValue (writer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Ljava_lang_Appendable_, __args);
			} finally {
			}
		}

		static IntPtr id_toJsonTree_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJsonTree' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toJsonTree", "(Ljava/lang/Object;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement ToJsonTree (global::Java.Lang.Object src)
		{
			if (id_toJsonTree_Ljava_lang_Object_ == IntPtr.Zero)
				id_toJsonTree_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toJsonTree", "(Ljava/lang/Object;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (src);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJsonTree_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toJsonTree_Ljava_lang_Object_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJsonTree' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("toJsonTree", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement ToJsonTree (global::Java.Lang.Object src, global::Java.Lang.Reflect.IType typeOfSrc)
		{
			if (id_toJsonTree_Ljava_lang_Object_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_toJsonTree_Ljava_lang_Object_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "toJsonTree", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (src);
				__args [1] = new JValue (typeOfSrc);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJsonTree_Ljava_lang_Object_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
