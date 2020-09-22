using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex']/class[@name='Single']"
	[global::Android.Runtime.Register ("io/reactivex/Single", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class Single : global::Java.Lang.Object, global::IO.Reactivex.ISingleSource {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/Single", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Single); }
		}

		protected Single (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/constructor[@name='Single' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Single ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Single)) {
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

		static IntPtr id_amb_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='amb' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.SingleSource&lt;? extends T&gt;&gt;']]"
		[Register ("amb", "(Ljava/lang/Iterable;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single Amb (global::Java.Lang.IIterable sources)
		{
			if (id_amb_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_amb_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "amb", "(Ljava/lang/Iterable;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_amb_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ambArray_arrayLio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='ambArray' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T&gt;...']]"
		[Register ("ambArray", "([Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single AmbArray (params global::IO.Reactivex.ISingleSource[] sources)
		{
			if (id_ambArray_arrayLio_reactivex_SingleSource_ == IntPtr.Zero)
				id_ambArray_arrayLio_reactivex_SingleSource_ = JNIEnv.GetStaticMethodID (class_ref, "ambArray", "([Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ambArray_arrayLio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_ambWith_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='ambWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T&gt;']]"
		[Register ("ambWith", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single AmbWith (global::IO.Reactivex.ISingleSource other)
		{
			if (id_ambWith_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_ambWith_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "ambWith", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ambWith_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_as_Lio_reactivex_SingleConverter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='as' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleConverter&lt;T, ? extends R&gt;']]"
		[Register ("as", "(Lio/reactivex/SingleConverter;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Java.Lang.Object As (global::IO.Reactivex.ISingleConverter converter)
		{
			if (id_as_Lio_reactivex_SingleConverter_ == IntPtr.Zero)
				id_as_Lio_reactivex_SingleConverter_ = JNIEnv.GetMethodID (class_ref, "as", "(Lio/reactivex/SingleConverter;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (converter);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_as_Lio_reactivex_SingleConverter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_blockingGet;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='blockingGet' and count(parameter)=0]"
		[Register ("blockingGet", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object BlockingGet ()
		{
			if (id_blockingGet == IntPtr.Zero)
				id_blockingGet = JNIEnv.GetMethodID (class_ref, "blockingGet", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingGet), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cache;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='cache' and count(parameter)=0]"
		[Register ("cache", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Cache ()
		{
			if (id_cache == IntPtr.Zero)
				id_cache = JNIEnv.GetMethodID (class_ref, "cache", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cache), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cast_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='cast' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends U&gt;']]"
		[Register ("cast", "(Ljava/lang/Class;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Single Cast (global::Java.Lang.Class clazz)
		{
			if (id_cast_Ljava_lang_Class_ == IntPtr.Zero)
				id_cast_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "cast", "(Ljava/lang/Class;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clazz);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cast_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_compose_Lio_reactivex_SingleTransformer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='compose' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleTransformer&lt;? super T, ? extends R&gt;']]"
		[Register ("compose", "(Lio/reactivex/SingleTransformer;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Single Compose (global::IO.Reactivex.ISingleTransformer transformer)
		{
			if (id_compose_Lio_reactivex_SingleTransformer_ == IntPtr.Zero)
				id_compose_Lio_reactivex_SingleTransformer_ = JNIEnv.GetMethodID (class_ref, "compose", "(Lio/reactivex/SingleTransformer;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (transformer);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compose_Lio_reactivex_SingleTransformer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concat_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='concat' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.SingleSource&lt;? extends T&gt;&gt;']]"
		[Register ("concat", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Concat (global::IO.Reactivex.IObservableSource sources)
		{
			if (id_concat_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concat_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concat", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concat_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_contains_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("contains", "(Ljava/lang/Object;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Contains (global::Java.Lang.Object value)
		{
			if (id_contains_Ljava_lang_Object_ == IntPtr.Zero)
				id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_contains_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='io.reactivex.functions.BiPredicate&lt;java.lang.Object, java.lang.Object&gt;']]"
		[Register ("contains", "(Ljava/lang/Object;Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Contains (global::Java.Lang.Object value, global::IO.Reactivex.Functions.IBiPredicate comparer)
		{
			if (id_contains_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_ == IntPtr.Zero)
				id_contains_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (value);
				__args [1] = new JValue (comparer);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create_Lio_reactivex_SingleOnSubscribe_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='create' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleOnSubscribe&lt;T&gt;']]"
		[Register ("create", "(Lio/reactivex/SingleOnSubscribe;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single Create (global::IO.Reactivex.ISingleOnSubscribe source)
		{
			if (id_create_Lio_reactivex_SingleOnSubscribe_ == IntPtr.Zero)
				id_create_Lio_reactivex_SingleOnSubscribe_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lio/reactivex/SingleOnSubscribe;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lio_reactivex_SingleOnSubscribe_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_defer_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='defer' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.SingleSource&lt;? extends T&gt;&gt;']]"
		[Register ("defer", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single Defer (global::Java.Util.Concurrent.ICallable singleSupplier)
		{
			if (id_defer_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_defer_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "defer", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (singleSupplier);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defer_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='delay' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Delay (long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='delay' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='boolean']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Delay (long time, global::Java.Util.Concurrent.TimeUnit unit, bool delayError)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_Z == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_Z = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (delayError);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='delay' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Delay (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='delay' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='boolean']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Delay (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool delayError)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (delayError);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='delaySubscription' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("delaySubscription", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DelaySubscription (global::IO.Reactivex.ICompletableSource other)
		{
			if (id_delaySubscription_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_delaySubscription_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='delaySubscription' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;']]"
		[Register ("delaySubscription", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Single DelaySubscription (global::IO.Reactivex.IObservableSource other)
		{
			if (id_delaySubscription_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_delaySubscription_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='delaySubscription' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;U&gt;']]"
		[Register ("delaySubscription", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Single DelaySubscription (global::IO.Reactivex.ISingleSource other)
		{
			if (id_delaySubscription_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_delaySubscription_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='delaySubscription' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("delaySubscription", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DelaySubscription (long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_delaySubscription_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_delaySubscription_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='delaySubscription' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("delaySubscription", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DelaySubscription (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_dematerialize_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='dematerialize' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, io.reactivex.Notification&lt;R&gt;&gt;']]"
		[Register ("dematerialize", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Maybe Dematerialize (global::IO.Reactivex.Functions.IFunction selector)
		{
			if (id_dematerialize_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_dematerialize_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "dematerialize", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (selector);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dematerialize_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doAfterSuccess_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='doAfterSuccess' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("doAfterSuccess", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DoAfterSuccess (global::IO.Reactivex.Functions.IConsumer onAfterSuccess)
		{
			if (id_doAfterSuccess_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doAfterSuccess_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doAfterSuccess", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onAfterSuccess);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doAfterSuccess_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doAfterTerminate_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='doAfterTerminate' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doAfterTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DoAfterTerminate (global::IO.Reactivex.Functions.IAction onAfterTerminate)
		{
			if (id_doAfterTerminate_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doAfterTerminate_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doAfterTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onAfterTerminate);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doAfterTerminate_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doFinally_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='doFinally' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doFinally", "(Lio/reactivex/functions/Action;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DoFinally (global::IO.Reactivex.Functions.IAction onFinally)
		{
			if (id_doFinally_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doFinally_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doFinally", "(Lio/reactivex/functions/Action;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onFinally);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doFinally_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnDispose_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='doOnDispose' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnDispose", "(Lio/reactivex/functions/Action;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DoOnDispose (global::IO.Reactivex.Functions.IAction onDispose)
		{
			if (id_doOnDispose_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnDispose_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnDispose", "(Lio/reactivex/functions/Action;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onDispose);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnDispose_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnError_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='doOnError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
		[Register ("doOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DoOnError (global::IO.Reactivex.Functions.IConsumer onError)
		{
			if (id_doOnError_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnError_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onError);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnError_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnEvent_Lio_reactivex_functions_BiConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='doOnEvent' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiConsumer&lt;? super T, ? super java.lang.Throwable&gt;']]"
		[Register ("doOnEvent", "(Lio/reactivex/functions/BiConsumer;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DoOnEvent (global::IO.Reactivex.Functions.IBiConsumer onEvent)
		{
			if (id_doOnEvent_Lio_reactivex_functions_BiConsumer_ == IntPtr.Zero)
				id_doOnEvent_Lio_reactivex_functions_BiConsumer_ = JNIEnv.GetMethodID (class_ref, "doOnEvent", "(Lio/reactivex/functions/BiConsumer;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onEvent);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnEvent_Lio_reactivex_functions_BiConsumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnSubscribe_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='doOnSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register ("doOnSubscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DoOnSubscribe (global::IO.Reactivex.Functions.IConsumer onSubscribe)
		{
			if (id_doOnSubscribe_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnSubscribe_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnSubscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSubscribe);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnSubscribe_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnSuccess_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='doOnSuccess' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("doOnSuccess", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DoOnSuccess (global::IO.Reactivex.Functions.IConsumer onSuccess)
		{
			if (id_doOnSuccess_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnSuccess_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnSuccess", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSuccess);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnSuccess_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnTerminate_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='doOnTerminate' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single DoOnTerminate (global::IO.Reactivex.Functions.IAction onTerminate)
		{
			if (id_doOnTerminate_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnTerminate_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onTerminate);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnTerminate_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_equals_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T&gt;']]"
		[Register ("equals", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single Equals (global::IO.Reactivex.ISingleSource first, global::IO.Reactivex.ISingleSource second)
		{
			if (id_equals_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_equals_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (first);
				__args [1] = new JValue (second);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_equals_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/Throwable;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single Error (global::Java.Lang.Throwable exception)
		{
			if (id_error_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Throwable;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (exception);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_error_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends java.lang.Throwable&gt;']]"
		[Register ("error", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single Error (global::Java.Util.Concurrent.ICallable errorSupplier)
		{
			if (id_error_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_error_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorSupplier);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_filter_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
		[Register ("filter", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Filter (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_filter_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_filter_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "filter", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_filter_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='flatMap' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Single FlatMap (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapCompletable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='flatMapCompletable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("flatMapCompletable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable FlatMapCompletable (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMapCompletable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMapCompletable_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMapCompletable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapCompletable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapMaybe_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='flatMapMaybe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMapMaybe", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Maybe FlatMapMaybe (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMapMaybe_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMapMaybe_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMapMaybe", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapMaybe_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapObservable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='flatMapObservable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMapObservable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMapObservable (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMapObservable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMapObservable_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMapObservable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapObservable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flattenAsObservable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='flattenAsObservable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends java.lang.Iterable&lt;? extends U&gt;&gt;']]"
		[Register ("flattenAsObservable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable FlattenAsObservable (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flattenAsObservable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flattenAsObservable_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flattenAsObservable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flattenAsObservable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromCallable_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='fromCallable' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends T&gt;']]"
		[Register ("fromCallable", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single FromCallable (global::Java.Util.Concurrent.ICallable callable)
		{
			if (id_fromCallable_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_fromCallable_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "fromCallable", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (callable);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCallable_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='fromFuture' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single FromFuture (global::Java.Util.Concurrent.IFuture future)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (future);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='fromFuture' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.Scheduler']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;Lio/reactivex/Scheduler;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single FromFuture (global::Java.Util.Concurrent.IFuture future, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;Lio/reactivex/Scheduler;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (future);
				__args [1] = new JValue (scheduler);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='fromFuture' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single FromFuture (global::Java.Util.Concurrent.IFuture future, long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (future);
				__args [1] = new JValue (timeout);
				__args [2] = new JValue (unit);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='fromFuture' and count(parameter)=4 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single FromFuture (global::Java.Util.Concurrent.IFuture future, long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (future);
				__args [1] = new JValue (timeout);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromObservable_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='fromObservable' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("fromObservable", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single FromObservable (global::IO.Reactivex.IObservableSource observableSource)
		{
			if (id_fromObservable_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_fromObservable_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "fromObservable", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observableSource);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromObservable_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hide;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hide), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ignoreElement;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='ignoreElement' and count(parameter)=0]"
		[Register ("ignoreElement", "()Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable IgnoreElement ()
		{
			if (id_ignoreElement == IntPtr.Zero)
				id_ignoreElement = JNIEnv.GetMethodID (class_ref, "ignoreElement", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ignoreElement), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_just_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='just' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single Just (global::Java.Lang.Object item)
		{
			if (id_just_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;)Lio/reactivex/Single;");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_item);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item);
			}
		}

		static IntPtr id_lift_Lio_reactivex_SingleOperator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='lift' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleOperator&lt;? extends R, ? super T&gt;']]"
		[Register ("lift", "(Lio/reactivex/SingleOperator;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Single Lift (global::IO.Reactivex.ISingleOperator lift)
		{
			if (id_lift_Lio_reactivex_SingleOperator_ == IntPtr.Zero)
				id_lift_Lio_reactivex_SingleOperator_ = JNIEnv.GetMethodID (class_ref, "lift", "(Lio/reactivex/SingleOperator;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (lift);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_lift_Lio_reactivex_SingleOperator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_map_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='map' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends R&gt;']]"
		[Register ("map", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Single Map (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_map_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_map_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "map", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_materialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='materialize' and count(parameter)=0]"
		[Register ("materialize", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Materialize ()
		{
			if (id_materialize == IntPtr.Zero)
				id_materialize = JNIEnv.GetMethodID (class_ref, "materialize", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_materialize), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_merge_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends io.reactivex.SingleSource&lt;? extends T&gt;&gt;']]"
		[Register ("merge", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single Merge (global::IO.Reactivex.ISingleSource source)
		{
			if (id_merge_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_merge_Lio_reactivex_SingleSource_ = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_never;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='never' and count(parameter)=0]"
		[Register ("never", "()Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single Never ()
		{
			if (id_never == IntPtr.Zero)
				id_never = JNIEnv.GetStaticMethodID (class_ref, "never", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_never), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_observeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='observeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("observeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ObserveOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_observeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_observeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "observeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_observeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorResumeNext_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='onErrorResumeNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Throwable, ? extends io.reactivex.SingleSource&lt;? extends T&gt;&gt;']]"
		[Register ("onErrorResumeNext", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single OnErrorResumeNext (global::IO.Reactivex.Functions.IFunction resumeFunctionInCaseOfError)
		{
			if (id_onErrorResumeNext_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_onErrorResumeNext_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "onErrorResumeNext", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resumeFunctionInCaseOfError);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorResumeNext_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorResumeNext_Lio_reactivex_Single_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='onErrorResumeNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.Single&lt;? extends T&gt;']]"
		[Register ("onErrorResumeNext", "(Lio/reactivex/Single;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single OnErrorResumeNext (global::IO.Reactivex.Single resumeSingleInCaseOfError)
		{
			if (id_onErrorResumeNext_Lio_reactivex_Single_ == IntPtr.Zero)
				id_onErrorResumeNext_Lio_reactivex_Single_ = JNIEnv.GetMethodID (class_ref, "onErrorResumeNext", "(Lio/reactivex/Single;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resumeSingleInCaseOfError);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorResumeNext_Lio_reactivex_Single_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorReturn_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='onErrorReturn' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;java.lang.Throwable, ? extends T&gt;']]"
		[Register ("onErrorReturn", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single OnErrorReturn (global::IO.Reactivex.Functions.IFunction resumeFunction)
		{
			if (id_onErrorReturn_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_onErrorReturn_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "onErrorReturn", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resumeFunction);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorReturn_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorReturnItem_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='onErrorReturnItem' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onErrorReturnItem", "(Ljava/lang/Object;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single OnErrorReturnItem (global::Java.Lang.Object value)
		{
			if (id_onErrorReturnItem_Ljava_lang_Object_ == IntPtr.Zero)
				id_onErrorReturnItem_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onErrorReturnItem", "(Ljava/lang/Object;)Lio/reactivex/Single;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorReturnItem_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_onTerminateDetach;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='onTerminateDetach' and count(parameter)=0]"
		[Register ("onTerminateDetach", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single OnTerminateDetach ()
		{
			if (id_onTerminateDetach == IntPtr.Zero)
				id_onTerminateDetach = JNIEnv.GetMethodID (class_ref, "onTerminateDetach", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onTerminateDetach), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_retry;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='retry' and count(parameter)=0]"
		[Register ("retry", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Retry ()
		{
			if (id_retry == IntPtr.Zero)
				id_retry = JNIEnv.GetMethodID (class_ref, "retry", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_retry_Lio_reactivex_functions_BiPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiPredicate&lt;? super java.lang.Integer, ? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Retry (global::IO.Reactivex.Functions.IBiPredicate predicate)
		{
			if (id_retry_Lio_reactivex_functions_BiPredicate_ == IntPtr.Zero)
				id_retry_Lio_reactivex_functions_BiPredicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_Lio_reactivex_functions_BiPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retry_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Retry (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_retry_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_retry_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retry_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("retry", "(J)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Retry (long times)
		{
			if (id_retry_J == IntPtr.Zero)
				id_retry_J = JNIEnv.GetMethodID (class_ref, "retry", "(J)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (times);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_retry_JLio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='retry' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='io.reactivex.functions.Predicate&lt;? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(JLio/reactivex/functions/Predicate;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Retry (long times, global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_retry_JLio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_retry_JLio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(JLio/reactivex/functions/Predicate;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (times);
				__args [1] = new JValue (predicate);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_JLio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='subscribe' and count(parameter)=0]"
		[Register ("subscribe", "()Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe ()
		{
			if (id_subscribe == IntPtr.Zero)
				id_subscribe = JNIEnv.GetMethodID (class_ref, "subscribe", "()Lio/reactivex/disposables/Disposable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_functions_BiConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiConsumer&lt;? super T, ? super java.lang.Throwable&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/functions/BiConsumer;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe (global::IO.Reactivex.Functions.IBiConsumer onCallback)
		{
			if (id_subscribe_Lio_reactivex_functions_BiConsumer_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_functions_BiConsumer_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/functions/BiConsumer;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onCallback);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_functions_BiConsumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe (global::IO.Reactivex.Functions.IConsumer onSuccess)
		{
			if (id_subscribe_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSuccess);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe (global::IO.Reactivex.Functions.IConsumer onSuccess, global::IO.Reactivex.Functions.IConsumer onError)
		{
			if (id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (onSuccess);
				__args [1] = new JValue (onError);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/SingleObserver;)V", "")]
		public unsafe void Subscribe (global::IO.Reactivex.ISingleObserver observer)
		{
			if (id_subscribe_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/SingleObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

		static Delegate cb_subscribeActual_Lio_reactivex_SingleObserver_;
#pragma warning disable 0169
		static Delegate GetSubscribeActual_Lio_reactivex_SingleObserver_Handler ()
		{
			if (cb_subscribeActual_Lio_reactivex_SingleObserver_ == null)
				cb_subscribeActual_Lio_reactivex_SingleObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SubscribeActual_Lio_reactivex_SingleObserver_);
			return cb_subscribeActual_Lio_reactivex_SingleObserver_;
		}

		static void n_SubscribeActual_Lio_reactivex_SingleObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.ISingleObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.ISingleObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubscribeActual (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/SingleObserver;)V", "GetSubscribeActual_Lio_reactivex_SingleObserver_Handler")]
		protected abstract void SubscribeActual (global::IO.Reactivex.ISingleObserver p0);

		static IntPtr id_subscribeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='subscribeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("subscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single SubscribeOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_subscribeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_subscribeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "subscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribeWith_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='subscribeWith' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("subscribeWith", "(Lio/reactivex/SingleObserver;)Lio/reactivex/SingleObserver;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends io.reactivex.SingleObserver<? super T>"})]
		public unsafe global::Java.Lang.Object SubscribeWith (global::Java.Lang.Object observer)
		{
			if (id_subscribeWith_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_subscribeWith_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeWith", "(Lio/reactivex/SingleObserver;)Lio/reactivex/SingleObserver;");
			IntPtr native_observer = JNIEnv.ToLocalJniHandle (observer);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_observer);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeWith_Lio_reactivex_SingleObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_observer);
			}
		}

		static IntPtr id_takeUntil_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='takeUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("takeUntil", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single TakeUntil (global::IO.Reactivex.ICompletableSource other)
		{
			if (id_takeUntil_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_takeUntil_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "takeUntil", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeUntil_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeUntil_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='takeUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends E&gt;']]"
		[Register ("takeUntil", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public unsafe global::IO.Reactivex.Single TakeUntil (global::IO.Reactivex.ISingleSource other)
		{
			if (id_takeUntil_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_takeUntil_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "takeUntil", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeUntil_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_test;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='test' and count(parameter)=0]"
		[Register ("test", "()Lio/reactivex/observers/TestObserver;", "")]
		public unsafe global::IO.Reactivex.Observers.TestObserver Test ()
		{
			if (id_test == IntPtr.Zero)
				id_test = JNIEnv.GetMethodID (class_ref, "test", "()Lio/reactivex/observers/TestObserver;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_test), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_test_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='test' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("test", "(Z)Lio/reactivex/observers/TestObserver;", "")]
		public unsafe global::IO.Reactivex.Observers.TestObserver Test (bool cancelled)
		{
			if (id_test_Z == IntPtr.Zero)
				id_test_Z = JNIEnv.GetMethodID (class_ref, "test", "(Z)Lio/reactivex/observers/TestObserver;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cancelled);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_test_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='timeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='timeout' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='timeout' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='io.reactivex.SingleSource&lt;? extends T&gt;']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, global::IO.Reactivex.ISingleSource other)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (other);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='timeout' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.SingleSource&lt;? extends T&gt;']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.ISingleSource other)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (other);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timer_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='timer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timer", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Single;", "")]
		public static unsafe global::IO.Reactivex.Single Timer (long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_timer_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timer_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "timer", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_timer_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='timer' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("timer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Single;", "")]
		public static unsafe global::IO.Reactivex.Single Timer (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "timer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_to_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='to' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Single&lt;T&gt;, R&gt;']]"
		[Register ("to", "(Lio/reactivex/functions/Function;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Java.Lang.Object To (global::IO.Reactivex.Functions.IFunction convert)
		{
			if (id_to_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_to_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "to", "(Lio/reactivex/functions/Function;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (convert);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_to_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toCompletable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='toCompletable' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("toCompletable", "()Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable ToCompletable ()
		{
			if (id_toCompletable == IntPtr.Zero)
				id_toCompletable = JNIEnv.GetMethodID (class_ref, "toCompletable", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toCompletable), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toFuture;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='toFuture' and count(parameter)=0]"
		[Register ("toFuture", "()Ljava/util/concurrent/Future;", "")]
		public unsafe global::Java.Util.Concurrent.IFuture ToFuture ()
		{
			if (id_toFuture == IntPtr.Zero)
				id_toFuture = JNIEnv.GetMethodID (class_ref, "toFuture", "()Ljava/util/concurrent/Future;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toFuture), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toMaybe;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='toMaybe' and count(parameter)=0]"
		[Register ("toMaybe", "()Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe ToMaybe ()
		{
			if (id_toMaybe == IntPtr.Zero)
				id_toMaybe = JNIEnv.GetMethodID (class_ref, "toMaybe", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toMaybe), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toObservable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='toObservable' and count(parameter)=0]"
		[Register ("toObservable", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ToObservable ()
		{
			if (id_toObservable == IntPtr.Zero)
				id_toObservable = JNIEnv.GetMethodID (class_ref, "toObservable", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toObservable), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_unsafeCreate_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='unsafeCreate' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;T&gt;']]"
		[Register ("unsafeCreate", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single UnsafeCreate (global::IO.Reactivex.ISingleSource onSubscribe)
		{
			if (id_unsafeCreate_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_unsafeCreate_Lio_reactivex_SingleSource_ = JNIEnv.GetStaticMethodID (class_ref, "unsafeCreate", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSubscribe);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_unsafeCreate_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_unsubscribeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='unsubscribeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("unsubscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single UnsubscribeOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_unsubscribeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_unsubscribeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "unsubscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='using' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Callable&lt;U&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super U, ? extends io.reactivex.SingleSource&lt;? extends T&gt;&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super U&gt;']]"
		[Register ("using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::IO.Reactivex.Single Using (global::Java.Util.Concurrent.ICallable resourceSupplier, global::IO.Reactivex.Functions.IFunction singleFunction, global::IO.Reactivex.Functions.IConsumer disposer)
		{
			if (id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (resourceSupplier);
				__args [1] = new JValue (singleFunction);
				__args [2] = new JValue (disposer);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='using' and count(parameter)=4 and parameter[1][@type='java.util.concurrent.Callable&lt;U&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super U, ? extends io.reactivex.SingleSource&lt;? extends T&gt;&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super U&gt;'] and parameter[4][@type='boolean']]"
		[Register ("using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::IO.Reactivex.Single Using (global::Java.Util.Concurrent.ICallable resourceSupplier, global::IO.Reactivex.Functions.IFunction singleFunction, global::IO.Reactivex.Functions.IConsumer disposer, bool eager)
		{
			if (id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z == IntPtr.Zero)
				id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z = JNIEnv.GetStaticMethodID (class_ref, "using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (resourceSupplier);
				__args [1] = new JValue (singleFunction);
				__args [2] = new JValue (disposer);
				__args [3] = new JValue (eager);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_wrap_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;T&gt;']]"
		[Register ("wrap", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single Wrap (global::IO.Reactivex.ISingleSource source)
		{
			if (id_wrap_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_wrap_Lio_reactivex_SingleSource_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zip' and count(parameter)=3 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.functions.BiFunction&lt;? super T1, ? super T2, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "R"})]
		public static unsafe global::IO.Reactivex.Single Zip (global::IO.Reactivex.ISingleSource source1, global::IO.Reactivex.ISingleSource source2, global::IO.Reactivex.Functions.IBiFunction zipper)
		{
			if (id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (zipper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zip' and count(parameter)=4 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.SingleSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.functions.Function3&lt;? super T1, ? super T2, ? super T3, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function3;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "R"})]
		public static unsafe global::IO.Reactivex.Single Zip (global::IO.Reactivex.ISingleSource source1, global::IO.Reactivex.ISingleSource source2, global::IO.Reactivex.ISingleSource source3, global::IO.Reactivex.Functions.IFunction3 zipper)
		{
			if (id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function3_ == IntPtr.Zero)
				id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function3_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function3;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (zipper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function3_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function4_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zip' and count(parameter)=5 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.SingleSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.SingleSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.functions.Function4&lt;? super T1, ? super T2, ? super T3, ? super T4, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function4;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "R"})]
		public static unsafe global::IO.Reactivex.Single Zip (global::IO.Reactivex.ISingleSource source1, global::IO.Reactivex.ISingleSource source2, global::IO.Reactivex.ISingleSource source3, global::IO.Reactivex.ISingleSource source4, global::IO.Reactivex.Functions.IFunction4 zipper)
		{
			if (id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function4_ == IntPtr.Zero)
				id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function4_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function4;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (zipper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function4_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function5_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zip' and count(parameter)=6 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.SingleSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.SingleSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.SingleSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.functions.Function5&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function5;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "R"})]
		public static unsafe global::IO.Reactivex.Single Zip (global::IO.Reactivex.ISingleSource source1, global::IO.Reactivex.ISingleSource source2, global::IO.Reactivex.ISingleSource source3, global::IO.Reactivex.ISingleSource source4, global::IO.Reactivex.ISingleSource source5, global::IO.Reactivex.Functions.IFunction5 zipper)
		{
			if (id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function5_ == IntPtr.Zero)
				id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function5_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function5;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (zipper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function5_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zip' and count(parameter)=7 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.SingleSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.SingleSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.SingleSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.SingleSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.functions.Function6&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function6;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "R"})]
		public static unsafe global::IO.Reactivex.Single Zip (global::IO.Reactivex.ISingleSource source1, global::IO.Reactivex.ISingleSource source2, global::IO.Reactivex.ISingleSource source3, global::IO.Reactivex.ISingleSource source4, global::IO.Reactivex.ISingleSource source5, global::IO.Reactivex.ISingleSource source6, global::IO.Reactivex.Functions.IFunction6 zipper)
		{
			if (id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function6_ == IntPtr.Zero)
				id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function6_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function6;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (source6);
				__args [6] = new JValue (zipper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function6_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function7_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zip' and count(parameter)=8 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.SingleSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.SingleSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.SingleSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.SingleSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.SingleSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.functions.Function7&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function7;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "R"})]
		public static unsafe global::IO.Reactivex.Single Zip (global::IO.Reactivex.ISingleSource source1, global::IO.Reactivex.ISingleSource source2, global::IO.Reactivex.ISingleSource source3, global::IO.Reactivex.ISingleSource source4, global::IO.Reactivex.ISingleSource source5, global::IO.Reactivex.ISingleSource source6, global::IO.Reactivex.ISingleSource source7, global::IO.Reactivex.Functions.IFunction7 zipper)
		{
			if (id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function7_ == IntPtr.Zero)
				id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function7_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function7;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (source6);
				__args [6] = new JValue (source7);
				__args [7] = new JValue (zipper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function7_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function8_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zip' and count(parameter)=9 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.SingleSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.SingleSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.SingleSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.SingleSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.SingleSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.SingleSource&lt;? extends T8&gt;'] and parameter[9][@type='io.reactivex.functions.Function8&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function8;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "R"})]
		public static unsafe global::IO.Reactivex.Single Zip (global::IO.Reactivex.ISingleSource source1, global::IO.Reactivex.ISingleSource source2, global::IO.Reactivex.ISingleSource source3, global::IO.Reactivex.ISingleSource source4, global::IO.Reactivex.ISingleSource source5, global::IO.Reactivex.ISingleSource source6, global::IO.Reactivex.ISingleSource source7, global::IO.Reactivex.ISingleSource source8, global::IO.Reactivex.Functions.IFunction8 zipper)
		{
			if (id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function8_ == IntPtr.Zero)
				id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function8_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function8;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (source6);
				__args [6] = new JValue (source7);
				__args [7] = new JValue (source8);
				__args [8] = new JValue (zipper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function8_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function9_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zip' and count(parameter)=10 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.SingleSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.SingleSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.SingleSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.SingleSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.SingleSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.SingleSource&lt;? extends T8&gt;'] and parameter[9][@type='io.reactivex.SingleSource&lt;? extends T9&gt;'] and parameter[10][@type='io.reactivex.functions.Function9&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? super T9, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function9;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "R"})]
		public static unsafe global::IO.Reactivex.Single Zip (global::IO.Reactivex.ISingleSource source1, global::IO.Reactivex.ISingleSource source2, global::IO.Reactivex.ISingleSource source3, global::IO.Reactivex.ISingleSource source4, global::IO.Reactivex.ISingleSource source5, global::IO.Reactivex.ISingleSource source6, global::IO.Reactivex.ISingleSource source7, global::IO.Reactivex.ISingleSource source8, global::IO.Reactivex.ISingleSource source9, global::IO.Reactivex.Functions.IFunction9 zipper)
		{
			if (id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function9_ == IntPtr.Zero)
				id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function9_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;Lio/reactivex/functions/Function9;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (source6);
				__args [6] = new JValue (source7);
				__args [7] = new JValue (source8);
				__args [8] = new JValue (source9);
				__args [9] = new JValue (zipper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function9_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zip' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.SingleSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register ("zip", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Single Zip (global::Java.Lang.IIterable sources, global::IO.Reactivex.Functions.IFunction zipper)
		{
			if (id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (zipper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zipArray_Lio_reactivex_functions_Function_arrayLio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zipArray' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T&gt;...']]"
		[Register ("zipArray", "(Lio/reactivex/functions/Function;[Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Single ZipArray (global::IO.Reactivex.Functions.IFunction zipper, params global::IO.Reactivex.ISingleSource[] sources)
		{
			if (id_zipArray_Lio_reactivex_functions_Function_arrayLio_reactivex_SingleSource_ == IntPtr.Zero)
				id_zipArray_Lio_reactivex_functions_Function_arrayLio_reactivex_SingleSource_ = JNIEnv.GetStaticMethodID (class_ref, "zipArray", "(Lio/reactivex/functions/Function;[Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (zipper);
				__args [1] = new JValue (native_sources);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zipArray_Lio_reactivex_functions_Function_arrayLio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_zipWith_Lio_reactivex_SingleSource_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='zipWith' and count(parameter)=2 and parameter[1][@type='io.reactivex.SingleSource&lt;U&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;']]"
		[Register ("zipWith", "(Lio/reactivex/SingleSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Single ZipWith (global::IO.Reactivex.ISingleSource other, global::IO.Reactivex.Functions.IBiFunction zipper)
		{
			if (id_zipWith_Lio_reactivex_SingleSource_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_zipWith_Lio_reactivex_SingleSource_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "zipWith", "(Lio/reactivex/SingleSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (other);
				__args [1] = new JValue (zipper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zipWith_Lio_reactivex_SingleSource_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/Single", DoNotGenerateAcw=true)]
	internal partial class SingleInvoker : Single, global::IO.Reactivex.ISingleSource {

		public SingleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleInvoker); }
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Single']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/SingleObserver;)V", "GetSubscribeActual_Lio_reactivex_SingleObserver_Handler")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ISingleObserver p0)
		{
			if (id_subscribeActual_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/SingleObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

	}

}
