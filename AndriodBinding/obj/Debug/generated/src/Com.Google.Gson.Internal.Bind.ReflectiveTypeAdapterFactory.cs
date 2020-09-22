using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory", DoNotGenerateAcw=true)]
	public sealed partial class ReflectiveTypeAdapterFactory : global::Java.Lang.Object, global::Com.Google.Gson.ITypeAdapterFactory {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory.Adapter']"
		[global::Android.Runtime.Register ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory$Adapter", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public sealed partial class Adapter : global::Com.Google.Gson.TypeAdapter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory$Adapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Adapter); }
			}

			internal Adapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_read_Lcom_google_gson_stream_JsonReader_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory.Adapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory.Adapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/bind/ReflectiveTypeAdapterFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReflectiveTypeAdapterFactory); }
		}

		internal ReflectiveTypeAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_gson_internal_ConstructorConstructor_Lcom_google_gson_FieldNamingStrategy_Lcom_google_gson_internal_Excluder_Lcom_google_gson_internal_bind_JsonAdapterAnnotationTypeAdapterFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory']/constructor[@name='ReflectiveTypeAdapterFactory' and count(parameter)=4 and parameter[1][@type='com.google.gson.internal.ConstructorConstructor'] and parameter[2][@type='com.google.gson.FieldNamingStrategy'] and parameter[3][@type='com.google.gson.internal.Excluder'] and parameter[4][@type='com.google.gson.internal.bind.JsonAdapterAnnotationTypeAdapterFactory']]"
		[Register (".ctor", "(Lcom/google/gson/internal/ConstructorConstructor;Lcom/google/gson/FieldNamingStrategy;Lcom/google/gson/internal/Excluder;Lcom/google/gson/internal/bind/JsonAdapterAnnotationTypeAdapterFactory;)V", "")]
		public unsafe ReflectiveTypeAdapterFactory (global::Com.Google.Gson.Internal.ConstructorConstructor constructorConstructor, global::Com.Google.Gson.IFieldNamingStrategy fieldNamingPolicy, global::Com.Google.Gson.Internal.Excluder excluder, global::Com.Google.Gson.Internal.Bind.JsonAdapterAnnotationTypeAdapterFactory jsonAdapterFactory)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (constructorConstructor);
				__args [1] = new JValue (fieldNamingPolicy);
				__args [2] = new JValue (excluder);
				__args [3] = new JValue (jsonAdapterFactory);
				if (((object) this).GetType () != typeof (ReflectiveTypeAdapterFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/google/gson/internal/ConstructorConstructor;Lcom/google/gson/FieldNamingStrategy;Lcom/google/gson/internal/Excluder;Lcom/google/gson/internal/bind/JsonAdapterAnnotationTypeAdapterFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/gson/internal/ConstructorConstructor;Lcom/google/gson/FieldNamingStrategy;Lcom/google/gson/internal/Excluder;Lcom/google/gson/internal/bind/JsonAdapterAnnotationTypeAdapterFactory;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_gson_internal_ConstructorConstructor_Lcom_google_gson_FieldNamingStrategy_Lcom_google_gson_internal_Excluder_Lcom_google_gson_internal_bind_JsonAdapterAnnotationTypeAdapterFactory_ == IntPtr.Zero)
					id_ctor_Lcom_google_gson_internal_ConstructorConstructor_Lcom_google_gson_FieldNamingStrategy_Lcom_google_gson_internal_Excluder_Lcom_google_gson_internal_bind_JsonAdapterAnnotationTypeAdapterFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/gson/internal/ConstructorConstructor;Lcom/google/gson/FieldNamingStrategy;Lcom/google/gson/internal/Excluder;Lcom/google/gson/internal/bind/JsonAdapterAnnotationTypeAdapterFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_gson_internal_ConstructorConstructor_Lcom_google_gson_FieldNamingStrategy_Lcom_google_gson_internal_Excluder_Lcom_google_gson_internal_bind_JsonAdapterAnnotationTypeAdapterFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_gson_internal_ConstructorConstructor_Lcom_google_gson_FieldNamingStrategy_Lcom_google_gson_internal_Excluder_Lcom_google_gson_internal_bind_JsonAdapterAnnotationTypeAdapterFactory_, __args);
			} finally {
			}
		}

		static IntPtr id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter Create (global::Com.Google.Gson.Gson gson, global::Com.Google.Gson.Reflect.TypeToken type)
		{
			if (id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ == IntPtr.Zero)
				id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ = JNIEnv.GetMethodID (class_ref, "create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (gson);
				__args [1] = new JValue (type);
				global::Com.Google.Gson.TypeAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_excludeField_Ljava_lang_reflect_Field_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ReflectiveTypeAdapterFactory']/method[@name='excludeField' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='boolean']]"
		[Register ("excludeField", "(Ljava/lang/reflect/Field;Z)Z", "")]
		public unsafe bool ExcludeField (global::Java.Lang.Reflect.Field f, bool serialize)
		{
			if (id_excludeField_Ljava_lang_reflect_Field_Z == IntPtr.Zero)
				id_excludeField_Ljava_lang_reflect_Field_Z = JNIEnv.GetMethodID (class_ref, "excludeField", "(Ljava/lang/reflect/Field;Z)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (f);
				__args [1] = new JValue (serialize);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_excludeField_Ljava_lang_reflect_Field_Z, __args);
				return __ret;
			} finally {
			}
		}

	}
}
