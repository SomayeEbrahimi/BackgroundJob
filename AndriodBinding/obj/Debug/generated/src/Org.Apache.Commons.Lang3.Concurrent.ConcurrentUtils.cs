using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/ConcurrentUtils", DoNotGenerateAcw=true)]
	public partial class ConcurrentUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/ConcurrentUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConcurrentUtils); }
		}

		protected ConcurrentUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_constantFuture_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']/method[@name='constantFuture' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("constantFuture", "(Ljava/lang/Object;)Ljava/util/concurrent/Future;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.IFuture ConstantFuture (global::Java.Lang.Object value)
		{
			if (id_constantFuture_Ljava_lang_Object_ == IntPtr.Zero)
				id_constantFuture_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "constantFuture", "(Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::Java.Util.Concurrent.IFuture __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_constantFuture_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_createIfAbsent_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']/method[@name='createIfAbsent' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.ConcurrentMap&lt;K, V&gt;'] and parameter[2][@type='K'] and parameter[3][@type='org.apache.commons.lang3.concurrent.ConcurrentInitializer&lt;V&gt;']]"
		[Register ("createIfAbsent", "(Ljava/util/concurrent/ConcurrentMap;Ljava/lang/Object;Lorg/apache/commons/lang3/concurrent/ConcurrentInitializer;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe global::Java.Lang.Object CreateIfAbsent (global::Java.Util.Concurrent.IConcurrentMap map, global::Java.Lang.Object key, global::Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializer init)
		{
			if (id_createIfAbsent_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_ == IntPtr.Zero)
				id_createIfAbsent_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_ = JNIEnv.GetStaticMethodID (class_ref, "createIfAbsent", "(Ljava/util/concurrent/ConcurrentMap;Ljava/lang/Object;Lorg/apache/commons/lang3/concurrent/ConcurrentInitializer;)Ljava/lang/Object;");
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (map);
				__args [1] = new JValue (native_key);
				__args [2] = new JValue (init);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createIfAbsent_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_createIfAbsentUnchecked_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']/method[@name='createIfAbsentUnchecked' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.ConcurrentMap&lt;K, V&gt;'] and parameter[2][@type='K'] and parameter[3][@type='org.apache.commons.lang3.concurrent.ConcurrentInitializer&lt;V&gt;']]"
		[Register ("createIfAbsentUnchecked", "(Ljava/util/concurrent/ConcurrentMap;Ljava/lang/Object;Lorg/apache/commons/lang3/concurrent/ConcurrentInitializer;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe global::Java.Lang.Object CreateIfAbsentUnchecked (global::Java.Util.Concurrent.IConcurrentMap map, global::Java.Lang.Object key, global::Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializer init)
		{
			if (id_createIfAbsentUnchecked_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_ == IntPtr.Zero)
				id_createIfAbsentUnchecked_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_ = JNIEnv.GetStaticMethodID (class_ref, "createIfAbsentUnchecked", "(Ljava/util/concurrent/ConcurrentMap;Ljava/lang/Object;Lorg/apache/commons/lang3/concurrent/ConcurrentInitializer;)Ljava/lang/Object;");
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (map);
				__args [1] = new JValue (native_key);
				__args [2] = new JValue (init);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createIfAbsentUnchecked_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_extractCause_Ljava_util_concurrent_ExecutionException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']/method[@name='extractCause' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutionException']]"
		[Register ("extractCause", "(Ljava/util/concurrent/ExecutionException;)Lorg/apache/commons/lang3/concurrent/ConcurrentException;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Concurrent.ConcurrentException ExtractCause (global::Java.Util.Concurrent.ExecutionException ex)
		{
			if (id_extractCause_Ljava_util_concurrent_ExecutionException_ == IntPtr.Zero)
				id_extractCause_Ljava_util_concurrent_ExecutionException_ = JNIEnv.GetStaticMethodID (class_ref, "extractCause", "(Ljava/util/concurrent/ExecutionException;)Lorg/apache/commons/lang3/concurrent/ConcurrentException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ex);
				global::Org.Apache.Commons.Lang3.Concurrent.ConcurrentException __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ConcurrentException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractCause_Ljava_util_concurrent_ExecutionException_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_extractCauseUnchecked_Ljava_util_concurrent_ExecutionException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']/method[@name='extractCauseUnchecked' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutionException']]"
		[Register ("extractCauseUnchecked", "(Ljava/util/concurrent/ExecutionException;)Lorg/apache/commons/lang3/concurrent/ConcurrentRuntimeException;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Concurrent.ConcurrentRuntimeException ExtractCauseUnchecked (global::Java.Util.Concurrent.ExecutionException ex)
		{
			if (id_extractCauseUnchecked_Ljava_util_concurrent_ExecutionException_ == IntPtr.Zero)
				id_extractCauseUnchecked_Ljava_util_concurrent_ExecutionException_ = JNIEnv.GetStaticMethodID (class_ref, "extractCauseUnchecked", "(Ljava/util/concurrent/ExecutionException;)Lorg/apache/commons/lang3/concurrent/ConcurrentRuntimeException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ex);
				global::Org.Apache.Commons.Lang3.Concurrent.ConcurrentRuntimeException __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ConcurrentRuntimeException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractCauseUnchecked_Ljava_util_concurrent_ExecutionException_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_handleCause_Ljava_util_concurrent_ExecutionException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']/method[@name='handleCause' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutionException']]"
		[Register ("handleCause", "(Ljava/util/concurrent/ExecutionException;)V", "")]
		public static unsafe void HandleCause (global::Java.Util.Concurrent.ExecutionException ex)
		{
			if (id_handleCause_Ljava_util_concurrent_ExecutionException_ == IntPtr.Zero)
				id_handleCause_Ljava_util_concurrent_ExecutionException_ = JNIEnv.GetStaticMethodID (class_ref, "handleCause", "(Ljava/util/concurrent/ExecutionException;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ex);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_handleCause_Ljava_util_concurrent_ExecutionException_, __args);
			} finally {
			}
		}

		static IntPtr id_handleCauseUnchecked_Ljava_util_concurrent_ExecutionException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']/method[@name='handleCauseUnchecked' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutionException']]"
		[Register ("handleCauseUnchecked", "(Ljava/util/concurrent/ExecutionException;)V", "")]
		public static unsafe void HandleCauseUnchecked (global::Java.Util.Concurrent.ExecutionException ex)
		{
			if (id_handleCauseUnchecked_Ljava_util_concurrent_ExecutionException_ == IntPtr.Zero)
				id_handleCauseUnchecked_Ljava_util_concurrent_ExecutionException_ = JNIEnv.GetStaticMethodID (class_ref, "handleCauseUnchecked", "(Ljava/util/concurrent/ExecutionException;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ex);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_handleCauseUnchecked_Ljava_util_concurrent_ExecutionException_, __args);
			} finally {
			}
		}

		static IntPtr id_initialize_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.concurrent.ConcurrentInitializer&lt;T&gt;']]"
		[Register ("initialize", "(Lorg/apache/commons/lang3/concurrent/ConcurrentInitializer;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Initialize (global::Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializer initializer)
		{
			if (id_initialize_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_ == IntPtr.Zero)
				id_initialize_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Lorg/apache/commons/lang3/concurrent/ConcurrentInitializer;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (initializer);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initialize_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initializeUnchecked_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']/method[@name='initializeUnchecked' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.concurrent.ConcurrentInitializer&lt;T&gt;']]"
		[Register ("initializeUnchecked", "(Lorg/apache/commons/lang3/concurrent/ConcurrentInitializer;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InitializeUnchecked (global::Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializer initializer)
		{
			if (id_initializeUnchecked_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_ == IntPtr.Zero)
				id_initializeUnchecked_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_ = JNIEnv.GetStaticMethodID (class_ref, "initializeUnchecked", "(Lorg/apache/commons/lang3/concurrent/ConcurrentInitializer;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (initializer);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initializeUnchecked_Lorg_apache_commons_lang3_concurrent_ConcurrentInitializer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_putIfAbsent_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ConcurrentUtils']/method[@name='putIfAbsent' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.ConcurrentMap&lt;K, V&gt;'] and parameter[2][@type='K'] and parameter[3][@type='V']]"
		[Register ("putIfAbsent", "(Ljava/util/concurrent/ConcurrentMap;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe global::Java.Lang.Object PutIfAbsent (global::Java.Util.Concurrent.IConcurrentMap map, global::Java.Lang.Object key, global::Java.Lang.Object value)
		{
			if (id_putIfAbsent_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_putIfAbsent_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "putIfAbsent", "(Ljava/util/concurrent/ConcurrentMap;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (map);
				__args [1] = new JValue (native_key);
				__args [2] = new JValue (native_value);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_putIfAbsent_Ljava_util_concurrent_ConcurrentMap_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
