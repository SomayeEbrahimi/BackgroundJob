using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Retrofit2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']"
	[global::Android.Runtime.Register ("retrofit2/Retrofit", DoNotGenerateAcw=true)]
	public sealed partial class Retrofit : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']"
		[global::Android.Runtime.Register ("retrofit2/Retrofit$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("retrofit2/Retrofit$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/constructor[@name='Retrofit.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_addCallAdapterFactory_Lretrofit2_CallAdapter_Factory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='addCallAdapterFactory' and count(parameter)=1 and parameter[1][@type='retrofit2.CallAdapter.Factory']]"
			[Register ("addCallAdapterFactory", "(Lretrofit2/CallAdapter$Factory;)Lretrofit2/Retrofit$Builder;", "")]
			public unsafe global::Retrofit2.Retrofit.Builder AddCallAdapterFactory (global::Retrofit2.CallAdapterFactory factory)
			{
				if (id_addCallAdapterFactory_Lretrofit2_CallAdapter_Factory_ == IntPtr.Zero)
					id_addCallAdapterFactory_Lretrofit2_CallAdapter_Factory_ = JNIEnv.GetMethodID (class_ref, "addCallAdapterFactory", "(Lretrofit2/CallAdapter$Factory;)Lretrofit2/Retrofit$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (factory);
					global::Retrofit2.Retrofit.Builder __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addCallAdapterFactory_Lretrofit2_CallAdapter_Factory_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_addConverterFactory_Lretrofit2_Converter_Factory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='addConverterFactory' and count(parameter)=1 and parameter[1][@type='retrofit2.Converter.Factory']]"
			[Register ("addConverterFactory", "(Lretrofit2/Converter$Factory;)Lretrofit2/Retrofit$Builder;", "")]
			public unsafe global::Retrofit2.Retrofit.Builder AddConverterFactory (global::Retrofit2.ConverterFactory factory)
			{
				if (id_addConverterFactory_Lretrofit2_Converter_Factory_ == IntPtr.Zero)
					id_addConverterFactory_Lretrofit2_Converter_Factory_ = JNIEnv.GetMethodID (class_ref, "addConverterFactory", "(Lretrofit2/Converter$Factory;)Lretrofit2/Retrofit$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (factory);
					global::Retrofit2.Retrofit.Builder __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addConverterFactory_Lretrofit2_Converter_Factory_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_baseUrl_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='baseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("baseUrl", "(Ljava/lang/String;)Lretrofit2/Retrofit$Builder;", "")]
			public unsafe global::Retrofit2.Retrofit.Builder BaseUrl (string baseUrl)
			{
				if (id_baseUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_baseUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "baseUrl", "(Ljava/lang/String;)Lretrofit2/Retrofit$Builder;");
				IntPtr native_baseUrl = JNIEnv.NewString (baseUrl);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_baseUrl);
					global::Retrofit2.Retrofit.Builder __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_baseUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_baseUrl);
				}
			}

			static IntPtr id_baseUrl_Lokhttp3_HttpUrl_;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='baseUrl' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
			[Register ("baseUrl", "(Lokhttp3/HttpUrl;)Lretrofit2/Retrofit$Builder;", "")]
			public unsafe global::Retrofit2.Retrofit.Builder BaseUrl (global::Okhttp3.HttpUrl baseUrl)
			{
				if (id_baseUrl_Lokhttp3_HttpUrl_ == IntPtr.Zero)
					id_baseUrl_Lokhttp3_HttpUrl_ = JNIEnv.GetMethodID (class_ref, "baseUrl", "(Lokhttp3/HttpUrl;)Lretrofit2/Retrofit$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (baseUrl);
					global::Retrofit2.Retrofit.Builder __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_baseUrl_Lokhttp3_HttpUrl_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lretrofit2/Retrofit;", "")]
			public unsafe global::Retrofit2.Retrofit Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lretrofit2/Retrofit;");
				try {
					return global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_callAdapterFactories;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='callAdapterFactories' and count(parameter)=0]"
			[Register ("callAdapterFactories", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Retrofit2.CallAdapterFactory> CallAdapterFactories ()
			{
				if (id_callAdapterFactories == IntPtr.Zero)
					id_callAdapterFactories = JNIEnv.GetMethodID (class_ref, "callAdapterFactories", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Retrofit2.CallAdapterFactory>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_callAdapterFactories), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_callFactory_Lokhttp3_Call_Factory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='callFactory' and count(parameter)=1 and parameter[1][@type='okhttp3.Call.Factory']]"
			[Register ("callFactory", "(Lokhttp3/Call$Factory;)Lretrofit2/Retrofit$Builder;", "")]
			public unsafe global::Retrofit2.Retrofit.Builder CallFactory (global::Okhttp3.ICallFactory factory)
			{
				if (id_callFactory_Lokhttp3_Call_Factory_ == IntPtr.Zero)
					id_callFactory_Lokhttp3_Call_Factory_ = JNIEnv.GetMethodID (class_ref, "callFactory", "(Lokhttp3/Call$Factory;)Lretrofit2/Retrofit$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (factory);
					global::Retrofit2.Retrofit.Builder __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_callFactory_Lokhttp3_Call_Factory_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_callbackExecutor_Ljava_util_concurrent_Executor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='callbackExecutor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
			[Register ("callbackExecutor", "(Ljava/util/concurrent/Executor;)Lretrofit2/Retrofit$Builder;", "")]
			public unsafe global::Retrofit2.Retrofit.Builder CallbackExecutor (global::Java.Util.Concurrent.IExecutor executor)
			{
				if (id_callbackExecutor_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
					id_callbackExecutor_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID (class_ref, "callbackExecutor", "(Ljava/util/concurrent/Executor;)Lretrofit2/Retrofit$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (executor);
					global::Retrofit2.Retrofit.Builder __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_callbackExecutor_Ljava_util_concurrent_Executor_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_client_Lokhttp3_OkHttpClient_;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='client' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
			[Register ("client", "(Lokhttp3/OkHttpClient;)Lretrofit2/Retrofit$Builder;", "")]
			public unsafe global::Retrofit2.Retrofit.Builder Client (global::Okhttp3.OkHttpClient client)
			{
				if (id_client_Lokhttp3_OkHttpClient_ == IntPtr.Zero)
					id_client_Lokhttp3_OkHttpClient_ = JNIEnv.GetMethodID (class_ref, "client", "(Lokhttp3/OkHttpClient;)Lretrofit2/Retrofit$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (client);
					global::Retrofit2.Retrofit.Builder __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_client_Lokhttp3_OkHttpClient_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_converterFactories;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='converterFactories' and count(parameter)=0]"
			[Register ("converterFactories", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Retrofit2.ConverterFactory> ConverterFactories ()
			{
				if (id_converterFactories == IntPtr.Zero)
					id_converterFactories = JNIEnv.GetMethodID (class_ref, "converterFactories", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Retrofit2.ConverterFactory>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_converterFactories), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_validateEagerly_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit.Builder']/method[@name='validateEagerly' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("validateEagerly", "(Z)Lretrofit2/Retrofit$Builder;", "")]
			public unsafe global::Retrofit2.Retrofit.Builder ValidateEagerly (bool validateEagerly)
			{
				if (id_validateEagerly_Z == IntPtr.Zero)
					id_validateEagerly_Z = JNIEnv.GetMethodID (class_ref, "validateEagerly", "(Z)Lretrofit2/Retrofit$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (validateEagerly);
					return global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_validateEagerly_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("retrofit2/Retrofit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Retrofit); }
		}

		internal Retrofit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_baseUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='baseUrl' and count(parameter)=0]"
		[Register ("baseUrl", "()Lokhttp3/HttpUrl;", "")]
		public unsafe global::Okhttp3.HttpUrl BaseUrl ()
		{
			if (id_baseUrl == IntPtr.Zero)
				id_baseUrl = JNIEnv.GetMethodID (class_ref, "baseUrl", "()Lokhttp3/HttpUrl;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_baseUrl), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_callAdapter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='callAdapter' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.annotation.Annotation[]']]"
		[Register ("callAdapter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;)Lretrofit2/CallAdapter;", "")]
		public unsafe global::Retrofit2.ICallAdapter CallAdapter (global::Java.Lang.Reflect.IType returnType, global::Java.Lang.Annotation.IAnnotation[] annotations)
		{
			if (id_callAdapter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_ == IntPtr.Zero)
				id_callAdapter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "callAdapter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;)Lretrofit2/CallAdapter;");
			IntPtr native_annotations = JNIEnv.NewArray (annotations);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (returnType);
				__args [1] = new JValue (native_annotations);
				global::Retrofit2.ICallAdapter __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.ICallAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_callAdapter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (annotations != null) {
					JNIEnv.CopyArray (native_annotations, annotations);
					JNIEnv.DeleteLocalRef (native_annotations);
				}
			}
		}

		static IntPtr id_callAdapterFactories;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='callAdapterFactories' and count(parameter)=0]"
		[Register ("callAdapterFactories", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Retrofit2.CallAdapterFactory> CallAdapterFactories ()
		{
			if (id_callAdapterFactories == IntPtr.Zero)
				id_callAdapterFactories = JNIEnv.GetMethodID (class_ref, "callAdapterFactories", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Retrofit2.CallAdapterFactory>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_callAdapterFactories), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_callFactory;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='callFactory' and count(parameter)=0]"
		[Register ("callFactory", "()Lokhttp3/Call$Factory;", "")]
		public unsafe global::Okhttp3.ICallFactory CallFactory ()
		{
			if (id_callFactory == IntPtr.Zero)
				id_callFactory = JNIEnv.GetMethodID (class_ref, "callFactory", "()Lokhttp3/Call$Factory;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ICallFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_callFactory), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_callbackExecutor;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='callbackExecutor' and count(parameter)=0]"
		[Register ("callbackExecutor", "()Ljava/util/concurrent/Executor;", "")]
		public unsafe global::Java.Util.Concurrent.IExecutor CallbackExecutor ()
		{
			if (id_callbackExecutor == IntPtr.Zero)
				id_callbackExecutor = JNIEnv.GetMethodID (class_ref, "callbackExecutor", "()Ljava/util/concurrent/Executor;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_callbackExecutor), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_converterFactories;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='converterFactories' and count(parameter)=0]"
		[Register ("converterFactories", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Retrofit2.ConverterFactory> ConverterFactories ()
		{
			if (id_converterFactories == IntPtr.Zero)
				id_converterFactories = JNIEnv.GetMethodID (class_ref, "converterFactories", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Retrofit2.ConverterFactory>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_converterFactories), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("create", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object Create (global::Java.Lang.Class service)
		{
			if (id_create_Ljava_lang_Class_ == IntPtr.Zero)
				id_create_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "create", "(Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (service);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lretrofit2/Retrofit$Builder;", "")]
		public unsafe global::Retrofit2.Retrofit.Builder NewBuilder ()
		{
			if (id_newBuilder == IntPtr.Zero)
				id_newBuilder = JNIEnv.GetMethodID (class_ref, "newBuilder", "()Lretrofit2/Retrofit$Builder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_nextCallAdapter_Lretrofit2_CallAdapter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='nextCallAdapter' and count(parameter)=3 and parameter[1][@type='retrofit2.CallAdapter.Factory'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='java.lang.annotation.Annotation[]']]"
		[Register ("nextCallAdapter", "(Lretrofit2/CallAdapter$Factory;Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;)Lretrofit2/CallAdapter;", "")]
		public unsafe global::Retrofit2.ICallAdapter NextCallAdapter (global::Retrofit2.CallAdapterFactory skipPast, global::Java.Lang.Reflect.IType returnType, global::Java.Lang.Annotation.IAnnotation[] annotations)
		{
			if (id_nextCallAdapter_Lretrofit2_CallAdapter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_ == IntPtr.Zero)
				id_nextCallAdapter_Lretrofit2_CallAdapter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "nextCallAdapter", "(Lretrofit2/CallAdapter$Factory;Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;)Lretrofit2/CallAdapter;");
			IntPtr native_annotations = JNIEnv.NewArray (annotations);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (skipPast);
				__args [1] = new JValue (returnType);
				__args [2] = new JValue (native_annotations);
				global::Retrofit2.ICallAdapter __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.ICallAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextCallAdapter_Lretrofit2_CallAdapter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (annotations != null) {
					JNIEnv.CopyArray (native_annotations, annotations);
					JNIEnv.DeleteLocalRef (native_annotations);
				}
			}
		}

		static IntPtr id_nextRequestBodyConverter_Lretrofit2_Converter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='nextRequestBodyConverter' and count(parameter)=4 and parameter[1][@type='retrofit2.Converter.Factory'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='java.lang.annotation.Annotation[]'] and parameter[4][@type='java.lang.annotation.Annotation[]']]"
		[Register ("nextRequestBodyConverter", "(Lretrofit2/Converter$Factory;Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;[Ljava/lang/annotation/Annotation;)Lretrofit2/Converter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Retrofit2.IConverter NextRequestBodyConverter (global::Retrofit2.ConverterFactory skipPast, global::Java.Lang.Reflect.IType type, global::Java.Lang.Annotation.IAnnotation[] parameterAnnotations, global::Java.Lang.Annotation.IAnnotation[] methodAnnotations)
		{
			if (id_nextRequestBodyConverter_Lretrofit2_Converter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_ == IntPtr.Zero)
				id_nextRequestBodyConverter_Lretrofit2_Converter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "nextRequestBodyConverter", "(Lretrofit2/Converter$Factory;Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;[Ljava/lang/annotation/Annotation;)Lretrofit2/Converter;");
			IntPtr native_parameterAnnotations = JNIEnv.NewArray (parameterAnnotations);
			IntPtr native_methodAnnotations = JNIEnv.NewArray (methodAnnotations);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (skipPast);
				__args [1] = new JValue (type);
				__args [2] = new JValue (native_parameterAnnotations);
				__args [3] = new JValue (native_methodAnnotations);
				global::Retrofit2.IConverter __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextRequestBodyConverter_Lretrofit2_Converter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (parameterAnnotations != null) {
					JNIEnv.CopyArray (native_parameterAnnotations, parameterAnnotations);
					JNIEnv.DeleteLocalRef (native_parameterAnnotations);
				}
				if (methodAnnotations != null) {
					JNIEnv.CopyArray (native_methodAnnotations, methodAnnotations);
					JNIEnv.DeleteLocalRef (native_methodAnnotations);
				}
			}
		}

		static IntPtr id_nextResponseBodyConverter_Lretrofit2_Converter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='nextResponseBodyConverter' and count(parameter)=3 and parameter[1][@type='retrofit2.Converter.Factory'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='java.lang.annotation.Annotation[]']]"
		[Register ("nextResponseBodyConverter", "(Lretrofit2/Converter$Factory;Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;)Lretrofit2/Converter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Retrofit2.IConverter NextResponseBodyConverter (global::Retrofit2.ConverterFactory skipPast, global::Java.Lang.Reflect.IType type, global::Java.Lang.Annotation.IAnnotation[] annotations)
		{
			if (id_nextResponseBodyConverter_Lretrofit2_Converter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_ == IntPtr.Zero)
				id_nextResponseBodyConverter_Lretrofit2_Converter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "nextResponseBodyConverter", "(Lretrofit2/Converter$Factory;Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;)Lretrofit2/Converter;");
			IntPtr native_annotations = JNIEnv.NewArray (annotations);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (skipPast);
				__args [1] = new JValue (type);
				__args [2] = new JValue (native_annotations);
				global::Retrofit2.IConverter __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextResponseBodyConverter_Lretrofit2_Converter_Factory_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (annotations != null) {
					JNIEnv.CopyArray (native_annotations, annotations);
					JNIEnv.DeleteLocalRef (native_annotations);
				}
			}
		}

		static IntPtr id_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='requestBodyConverter' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.annotation.Annotation[]'] and parameter[3][@type='java.lang.annotation.Annotation[]']]"
		[Register ("requestBodyConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;[Ljava/lang/annotation/Annotation;)Lretrofit2/Converter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Retrofit2.IConverter RequestBodyConverter (global::Java.Lang.Reflect.IType type, global::Java.Lang.Annotation.IAnnotation[] parameterAnnotations, global::Java.Lang.Annotation.IAnnotation[] methodAnnotations)
		{
			if (id_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_ == IntPtr.Zero)
				id_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "requestBodyConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;[Ljava/lang/annotation/Annotation;)Lretrofit2/Converter;");
			IntPtr native_parameterAnnotations = JNIEnv.NewArray (parameterAnnotations);
			IntPtr native_methodAnnotations = JNIEnv.NewArray (methodAnnotations);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (type);
				__args [1] = new JValue (native_parameterAnnotations);
				__args [2] = new JValue (native_methodAnnotations);
				global::Retrofit2.IConverter __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (parameterAnnotations != null) {
					JNIEnv.CopyArray (native_parameterAnnotations, parameterAnnotations);
					JNIEnv.DeleteLocalRef (native_parameterAnnotations);
				}
				if (methodAnnotations != null) {
					JNIEnv.CopyArray (native_methodAnnotations, methodAnnotations);
					JNIEnv.DeleteLocalRef (native_methodAnnotations);
				}
			}
		}

		static IntPtr id_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='responseBodyConverter' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.annotation.Annotation[]']]"
		[Register ("responseBodyConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;)Lretrofit2/Converter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Retrofit2.IConverter ResponseBodyConverter (global::Java.Lang.Reflect.IType type, global::Java.Lang.Annotation.IAnnotation[] annotations)
		{
			if (id_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_ == IntPtr.Zero)
				id_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "responseBodyConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;)Lretrofit2/Converter;");
			IntPtr native_annotations = JNIEnv.NewArray (annotations);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (type);
				__args [1] = new JValue (native_annotations);
				global::Retrofit2.IConverter __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (annotations != null) {
					JNIEnv.CopyArray (native_annotations, annotations);
					JNIEnv.DeleteLocalRef (native_annotations);
				}
			}
		}

		static IntPtr id_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Retrofit']/method[@name='stringConverter' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.annotation.Annotation[]']]"
		[Register ("stringConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;)Lretrofit2/Converter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Retrofit2.IConverter StringConverter (global::Java.Lang.Reflect.IType type, global::Java.Lang.Annotation.IAnnotation[] annotations)
		{
			if (id_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_ == IntPtr.Zero)
				id_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "stringConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;)Lretrofit2/Converter;");
			IntPtr native_annotations = JNIEnv.NewArray (annotations);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (type);
				__args [1] = new JValue (native_annotations);
				global::Retrofit2.IConverter __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (annotations != null) {
					JNIEnv.CopyArray (native_annotations, annotations);
					JNIEnv.DeleteLocalRef (native_annotations);
				}
			}
		}

	}
}
