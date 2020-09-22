using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']"
	[global::Android.Runtime.Register ("io/reactivex/Maybe", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class Maybe : global::Java.Lang.Object, global::IO.Reactivex.IMaybeSource {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/Maybe", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Maybe); }
		}

		protected Maybe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/constructor[@name='Maybe' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Maybe ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Maybe)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='amb' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.MaybeSource&lt;? extends T&gt;&gt;']]"
		[Register ("amb", "(Ljava/lang/Iterable;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe Amb (global::Java.Lang.IIterable sources)
		{
			if (id_amb_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_amb_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "amb", "(Ljava/lang/Iterable;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_amb_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ambArray_arrayLio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='ambArray' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;...']]"
		[Register ("ambArray", "([Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe AmbArray (params global::IO.Reactivex.IMaybeSource[] sources)
		{
			if (id_ambArray_arrayLio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_ambArray_arrayLio_reactivex_MaybeSource_ = JNIEnv.GetStaticMethodID (class_ref, "ambArray", "([Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ambArray_arrayLio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_ambWith_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='ambWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;']]"
		[Register ("ambWith", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe AmbWith (global::IO.Reactivex.IMaybeSource other)
		{
			if (id_ambWith_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_ambWith_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "ambWith", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ambWith_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_as_Lio_reactivex_MaybeConverter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='as' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeConverter&lt;T, ? extends R&gt;']]"
		[Register ("as", "(Lio/reactivex/MaybeConverter;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Java.Lang.Object As (global::IO.Reactivex.IMaybeConverter converter)
		{
			if (id_as_Lio_reactivex_MaybeConverter_ == IntPtr.Zero)
				id_as_Lio_reactivex_MaybeConverter_ = JNIEnv.GetMethodID (class_ref, "as", "(Lio/reactivex/MaybeConverter;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (converter);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_as_Lio_reactivex_MaybeConverter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_blockingGet;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='blockingGet' and count(parameter)=0]"
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

		static IntPtr id_blockingGet_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='blockingGet' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("blockingGet", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object BlockingGet (global::Java.Lang.Object defaultValue)
		{
			if (id_blockingGet_Ljava_lang_Object_ == IntPtr.Zero)
				id_blockingGet_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "blockingGet", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultValue);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingGet_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static IntPtr id_cache;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='cache' and count(parameter)=0]"
		[Register ("cache", "()Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Cache ()
		{
			if (id_cache == IntPtr.Zero)
				id_cache = JNIEnv.GetMethodID (class_ref, "cache", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cache), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cast_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='cast' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends U&gt;']]"
		[Register ("cast", "(Ljava/lang/Class;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Maybe Cast (global::Java.Lang.Class clazz)
		{
			if (id_cast_Ljava_lang_Class_ == IntPtr.Zero)
				id_cast_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "cast", "(Ljava/lang/Class;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clazz);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cast_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_compose_Lio_reactivex_MaybeTransformer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='compose' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeTransformer&lt;? super T, ? extends R&gt;']]"
		[Register ("compose", "(Lio/reactivex/MaybeTransformer;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Maybe Compose (global::IO.Reactivex.IMaybeTransformer transformer)
		{
			if (id_compose_Lio_reactivex_MaybeTransformer_ == IntPtr.Zero)
				id_compose_Lio_reactivex_MaybeTransformer_ = JNIEnv.GetMethodID (class_ref, "compose", "(Lio/reactivex/MaybeTransformer;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (transformer);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compose_Lio_reactivex_MaybeTransformer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMap_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='concatMap' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;']]"
		[Register ("concatMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Maybe ConcatMap (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMap_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMap_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMap_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_contains_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("contains", "(Ljava/lang/Object;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Contains (global::Java.Lang.Object item)
		{
			if (id_contains_Ljava_lang_Object_ == IntPtr.Zero)
				id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (item);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_count;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Count ()
		{
			if (id_count == IntPtr.Zero)
				id_count = JNIEnv.GetMethodID (class_ref, "count", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_count), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_Lio_reactivex_MaybeOnSubscribe_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='create' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeOnSubscribe&lt;T&gt;']]"
		[Register ("create", "(Lio/reactivex/MaybeOnSubscribe;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe Create (global::IO.Reactivex.IMaybeOnSubscribe onSubscribe)
		{
			if (id_create_Lio_reactivex_MaybeOnSubscribe_ == IntPtr.Zero)
				id_create_Lio_reactivex_MaybeOnSubscribe_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lio/reactivex/MaybeOnSubscribe;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSubscribe);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lio_reactivex_MaybeOnSubscribe_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_defaultIfEmpty_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='defaultIfEmpty' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("defaultIfEmpty", "(Ljava/lang/Object;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DefaultIfEmpty (global::Java.Lang.Object defaultItem)
		{
			if (id_defaultIfEmpty_Ljava_lang_Object_ == IntPtr.Zero)
				id_defaultIfEmpty_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "defaultIfEmpty", "(Ljava/lang/Object;)Lio/reactivex/Maybe;");
			IntPtr native_defaultItem = JNIEnv.ToLocalJniHandle (defaultItem);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultItem);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_defaultIfEmpty_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultItem);
			}
		}

		static IntPtr id_defer_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='defer' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.MaybeSource&lt;? extends T&gt;&gt;']]"
		[Register ("defer", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe Defer (global::Java.Util.Concurrent.ICallable maybeSupplier)
		{
			if (id_defer_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_defer_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "defer", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (maybeSupplier);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defer_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='delay' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Delay (long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='delay' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Delay (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='delaySubscription' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("delaySubscription", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DelaySubscription (long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_delaySubscription_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_delaySubscription_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='delaySubscription' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("delaySubscription", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DelaySubscription (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doAfterSuccess_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='doAfterSuccess' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("doAfterSuccess", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DoAfterSuccess (global::IO.Reactivex.Functions.IConsumer onAfterSuccess)
		{
			if (id_doAfterSuccess_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doAfterSuccess_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doAfterSuccess", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onAfterSuccess);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doAfterSuccess_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doAfterTerminate_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='doAfterTerminate' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doAfterTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DoAfterTerminate (global::IO.Reactivex.Functions.IAction onAfterTerminate)
		{
			if (id_doAfterTerminate_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doAfterTerminate_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doAfterTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onAfterTerminate);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doAfterTerminate_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doFinally_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='doFinally' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doFinally", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DoFinally (global::IO.Reactivex.Functions.IAction onFinally)
		{
			if (id_doFinally_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doFinally_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doFinally", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onFinally);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doFinally_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnComplete_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='doOnComplete' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnComplete", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DoOnComplete (global::IO.Reactivex.Functions.IAction onComplete)
		{
			if (id_doOnComplete_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnComplete_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnComplete", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onComplete);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnComplete_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnDispose_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='doOnDispose' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnDispose", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DoOnDispose (global::IO.Reactivex.Functions.IAction onDispose)
		{
			if (id_doOnDispose_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnDispose_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnDispose", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onDispose);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnDispose_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnError_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='doOnError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
		[Register ("doOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DoOnError (global::IO.Reactivex.Functions.IConsumer onError)
		{
			if (id_doOnError_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnError_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onError);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnError_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnEvent_Lio_reactivex_functions_BiConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='doOnEvent' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiConsumer&lt;? super T, ? super java.lang.Throwable&gt;']]"
		[Register ("doOnEvent", "(Lio/reactivex/functions/BiConsumer;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DoOnEvent (global::IO.Reactivex.Functions.IBiConsumer onEvent)
		{
			if (id_doOnEvent_Lio_reactivex_functions_BiConsumer_ == IntPtr.Zero)
				id_doOnEvent_Lio_reactivex_functions_BiConsumer_ = JNIEnv.GetMethodID (class_ref, "doOnEvent", "(Lio/reactivex/functions/BiConsumer;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onEvent);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnEvent_Lio_reactivex_functions_BiConsumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnSubscribe_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='doOnSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register ("doOnSubscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DoOnSubscribe (global::IO.Reactivex.Functions.IConsumer onSubscribe)
		{
			if (id_doOnSubscribe_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnSubscribe_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnSubscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSubscribe);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnSubscribe_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnSuccess_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='doOnSuccess' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("doOnSuccess", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DoOnSuccess (global::IO.Reactivex.Functions.IConsumer onSuccess)
		{
			if (id_doOnSuccess_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnSuccess_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnSuccess", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSuccess);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnSuccess_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnTerminate_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='doOnTerminate' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe DoOnTerminate (global::IO.Reactivex.Functions.IAction onTerminate)
		{
			if (id_doOnTerminate_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnTerminate_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onTerminate);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnTerminate_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_empty;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe Empty ()
		{
			if (id_empty == IntPtr.Zero)
				id_empty = JNIEnv.GetStaticMethodID (class_ref, "empty", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_empty), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/Throwable;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe Error (global::Java.Lang.Throwable exception)
		{
			if (id_error_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Throwable;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (exception);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_error_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends java.lang.Throwable&gt;']]"
		[Register ("error", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe Error (global::Java.Util.Concurrent.ICallable supplier)
		{
			if (id_error_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_error_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (supplier);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_filter_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='flatMap' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Maybe FlatMap (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='flatMap' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Throwable, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;'] and parameter[3][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Maybe FlatMap (global::IO.Reactivex.Functions.IFunction onSuccessMapper, global::IO.Reactivex.Functions.IFunction onErrorMapper, global::Java.Util.Concurrent.ICallable onCompleteSupplier)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (onSuccessMapper);
				__args [1] = new JValue (onErrorMapper);
				__args [2] = new JValue (onCompleteSupplier);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='flatMap' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends U&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Maybe FlatMap (global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Functions.IBiFunction resultSelector)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (resultSelector);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapCompletable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='flatMapCompletable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;']]"
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

		static IntPtr id_flatMapObservable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='flatMapObservable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;']]"
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

		static IntPtr id_flatMapSingle_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='flatMapSingle' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMapSingle", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Single FlatMapSingle (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMapSingle_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMapSingle_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMapSingle", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapSingle_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapSingleElement_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='flatMapSingleElement' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMapSingleElement", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Maybe FlatMapSingleElement (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMapSingleElement_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMapSingleElement_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMapSingleElement", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapSingleElement_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flattenAsObservable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='flattenAsObservable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends java.lang.Iterable&lt;? extends U&gt;&gt;']]"
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

		static IntPtr id_fromAction_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='fromAction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("fromAction", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe FromAction (global::IO.Reactivex.Functions.IAction run)
		{
			if (id_fromAction_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_fromAction_Lio_reactivex_functions_Action_ = JNIEnv.GetStaticMethodID (class_ref, "fromAction", "(Lio/reactivex/functions/Action;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (run);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAction_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromCallable_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='fromCallable' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends T&gt;']]"
		[Register ("fromCallable", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe FromCallable (global::Java.Util.Concurrent.ICallable callable)
		{
			if (id_fromCallable_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_fromCallable_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "fromCallable", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (callable);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCallable_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromCompletable_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='fromCompletable' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("fromCompletable", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe FromCompletable (global::IO.Reactivex.ICompletableSource completableSource)
		{
			if (id_fromCompletable_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_fromCompletable_Lio_reactivex_CompletableSource_ = JNIEnv.GetStaticMethodID (class_ref, "fromCompletable", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (completableSource);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCompletable_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='fromFuture' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe FromFuture (global::Java.Util.Concurrent.IFuture future)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (future);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='fromFuture' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe FromFuture (global::Java.Util.Concurrent.IFuture future, long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (future);
				__args [1] = new JValue (timeout);
				__args [2] = new JValue (unit);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='fromRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("fromRunnable", "(Ljava/lang/Runnable;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe FromRunnable (global::Java.Lang.IRunnable run)
		{
			if (id_fromRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_fromRunnable_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "fromRunnable", "(Ljava/lang/Runnable;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (run);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromRunnable_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromSingle_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='fromSingle' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;T&gt;']]"
		[Register ("fromSingle", "(Lio/reactivex/SingleSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe FromSingle (global::IO.Reactivex.ISingleSource singleSource)
		{
			if (id_fromSingle_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_fromSingle_Lio_reactivex_SingleSource_ = JNIEnv.GetStaticMethodID (class_ref, "fromSingle", "(Lio/reactivex/SingleSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (singleSource);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromSingle_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hide;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hide), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ignoreElement;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='ignoreElement' and count(parameter)=0]"
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

		static IntPtr id_isEmpty;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='isEmpty' and count(parameter)=0]"
		[Register ("isEmpty", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single IsEmpty ()
		{
			if (id_isEmpty == IntPtr.Zero)
				id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_just_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='just' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe Just (global::Java.Lang.Object item)
		{
			if (id_just_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;)Lio/reactivex/Maybe;");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_item);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item);
			}
		}

		static IntPtr id_lift_Lio_reactivex_MaybeOperator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='lift' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeOperator&lt;? extends R, ? super T&gt;']]"
		[Register ("lift", "(Lio/reactivex/MaybeOperator;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Maybe Lift (global::IO.Reactivex.IMaybeOperator lift)
		{
			if (id_lift_Lio_reactivex_MaybeOperator_ == IntPtr.Zero)
				id_lift_Lio_reactivex_MaybeOperator_ = JNIEnv.GetMethodID (class_ref, "lift", "(Lio/reactivex/MaybeOperator;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (lift);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_lift_Lio_reactivex_MaybeOperator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_map_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='map' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends R&gt;']]"
		[Register ("map", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Maybe Map (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_map_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_map_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "map", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_materialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='materialize' and count(parameter)=0]"
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

		static IntPtr id_merge_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends io.reactivex.MaybeSource&lt;? extends T&gt;&gt;']]"
		[Register ("merge", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe Merge (global::IO.Reactivex.IMaybeSource source)
		{
			if (id_merge_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_merge_Lio_reactivex_MaybeSource_ = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_never;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='never' and count(parameter)=0]"
		[Register ("never", "()Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe Never ()
		{
			if (id_never == IntPtr.Zero)
				id_never = JNIEnv.GetStaticMethodID (class_ref, "never", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_never), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_observeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='observeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("observeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe ObserveOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_observeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_observeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "observeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_observeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ofType_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='ofType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;U&gt;']]"
		[Register ("ofType", "(Ljava/lang/Class;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Maybe OfType (global::Java.Lang.Class clazz)
		{
			if (id_ofType_Ljava_lang_Class_ == IntPtr.Zero)
				id_ofType_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "ofType", "(Ljava/lang/Class;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clazz);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ofType_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='onErrorComplete' and count(parameter)=0]"
		[Register ("onErrorComplete", "()Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe OnErrorComplete ()
		{
			if (id_onErrorComplete == IntPtr.Zero)
				id_onErrorComplete = JNIEnv.GetMethodID (class_ref, "onErrorComplete", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorComplete), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_onErrorComplete_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='onErrorComplete' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super java.lang.Throwable&gt;']]"
		[Register ("onErrorComplete", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe OnErrorComplete (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_onErrorComplete_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_onErrorComplete_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "onErrorComplete", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorComplete_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorResumeNext_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='onErrorResumeNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Throwable, ? extends io.reactivex.MaybeSource&lt;? extends T&gt;&gt;']]"
		[Register ("onErrorResumeNext", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe OnErrorResumeNext (global::IO.Reactivex.Functions.IFunction resumeFunction)
		{
			if (id_onErrorResumeNext_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_onErrorResumeNext_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "onErrorResumeNext", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resumeFunction);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorResumeNext_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorResumeNext_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='onErrorResumeNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;']]"
		[Register ("onErrorResumeNext", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe OnErrorResumeNext (global::IO.Reactivex.IMaybeSource next)
		{
			if (id_onErrorResumeNext_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_onErrorResumeNext_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "onErrorResumeNext", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (next);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorResumeNext_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorReturn_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='onErrorReturn' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Throwable, ? extends T&gt;']]"
		[Register ("onErrorReturn", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe OnErrorReturn (global::IO.Reactivex.Functions.IFunction valueSupplier)
		{
			if (id_onErrorReturn_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_onErrorReturn_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "onErrorReturn", "(Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (valueSupplier);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorReturn_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorReturnItem_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='onErrorReturnItem' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onErrorReturnItem", "(Ljava/lang/Object;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe OnErrorReturnItem (global::Java.Lang.Object item)
		{
			if (id_onErrorReturnItem_Ljava_lang_Object_ == IntPtr.Zero)
				id_onErrorReturnItem_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onErrorReturnItem", "(Ljava/lang/Object;)Lio/reactivex/Maybe;");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_item);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorReturnItem_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item);
			}
		}

		static IntPtr id_onExceptionResumeNext_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='onExceptionResumeNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;']]"
		[Register ("onExceptionResumeNext", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe OnExceptionResumeNext (global::IO.Reactivex.IMaybeSource next)
		{
			if (id_onExceptionResumeNext_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_onExceptionResumeNext_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "onExceptionResumeNext", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (next);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onExceptionResumeNext_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onTerminateDetach;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='onTerminateDetach' and count(parameter)=0]"
		[Register ("onTerminateDetach", "()Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe OnTerminateDetach ()
		{
			if (id_onTerminateDetach == IntPtr.Zero)
				id_onTerminateDetach = JNIEnv.GetMethodID (class_ref, "onTerminateDetach", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onTerminateDetach), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_retry;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='retry' and count(parameter)=0]"
		[Register ("retry", "()Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Retry ()
		{
			if (id_retry == IntPtr.Zero)
				id_retry = JNIEnv.GetMethodID (class_ref, "retry", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_retry_Lio_reactivex_functions_BiPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiPredicate&lt;? super java.lang.Integer, ? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Retry (global::IO.Reactivex.Functions.IBiPredicate predicate)
		{
			if (id_retry_Lio_reactivex_functions_BiPredicate_ == IntPtr.Zero)
				id_retry_Lio_reactivex_functions_BiPredicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_Lio_reactivex_functions_BiPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retry_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Retry (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_retry_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_retry_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retry_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("retry", "(J)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Retry (long count)
		{
			if (id_retry_J == IntPtr.Zero)
				id_retry_J = JNIEnv.GetMethodID (class_ref, "retry", "(J)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_retry_JLio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='retry' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='io.reactivex.functions.Predicate&lt;? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(JLio/reactivex/functions/Predicate;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Retry (long times, global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_retry_JLio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_retry_JLio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(JLio/reactivex/functions/Predicate;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (times);
				__args [1] = new JValue (predicate);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_JLio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retryUntil_Lio_reactivex_functions_BooleanSupplier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='retryUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BooleanSupplier']]"
		[Register ("retryUntil", "(Lio/reactivex/functions/BooleanSupplier;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe RetryUntil (global::IO.Reactivex.Functions.IBooleanSupplier stop)
		{
			if (id_retryUntil_Lio_reactivex_functions_BooleanSupplier_ == IntPtr.Zero)
				id_retryUntil_Lio_reactivex_functions_BooleanSupplier_ = JNIEnv.GetMethodID (class_ref, "retryUntil", "(Lio/reactivex/functions/BooleanSupplier;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (stop);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retryUntil_Lio_reactivex_functions_BooleanSupplier_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sequenceEqual_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='sequenceEqual' and count(parameter)=2 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T&gt;']]"
		[Register ("sequenceEqual", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single SequenceEqual (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2)
		{
			if (id_sequenceEqual_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_sequenceEqual_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_ = JNIEnv.GetStaticMethodID (class_ref, "sequenceEqual", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sequenceEqual_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sequenceEqual_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='sequenceEqual' and count(parameter)=3 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.functions.BiPredicate&lt;? super T, ? super T&gt;']]"
		[Register ("sequenceEqual", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single SequenceEqual (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2, global::IO.Reactivex.Functions.IBiPredicate isEqual)
		{
			if (id_sequenceEqual_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiPredicate_ == IntPtr.Zero)
				id_sequenceEqual_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiPredicate_ = JNIEnv.GetStaticMethodID (class_ref, "sequenceEqual", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (isEqual);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sequenceEqual_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='subscribe' and count(parameter)=0]"
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

		static IntPtr id_subscribe_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
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

		static IntPtr id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;'] and parameter[3][@type='io.reactivex.functions.Action']]"
		[Register ("subscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe (global::IO.Reactivex.Functions.IConsumer onSuccess, global::IO.Reactivex.Functions.IConsumer onError, global::IO.Reactivex.Functions.IAction onComplete)
		{
			if (id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (onSuccess);
				__args [1] = new JValue (onError);
				__args [2] = new JValue (onComplete);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/MaybeObserver;)V", "")]
		public unsafe void Subscribe (global::IO.Reactivex.IMaybeObserver observer)
		{
			if (id_subscribe_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_MaybeObserver_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/MaybeObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_MaybeObserver_, __args);
			} finally {
			}
		}

		static Delegate cb_subscribeActual_Lio_reactivex_MaybeObserver_;
#pragma warning disable 0169
		static Delegate GetSubscribeActual_Lio_reactivex_MaybeObserver_Handler ()
		{
			if (cb_subscribeActual_Lio_reactivex_MaybeObserver_ == null)
				cb_subscribeActual_Lio_reactivex_MaybeObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SubscribeActual_Lio_reactivex_MaybeObserver_);
			return cb_subscribeActual_Lio_reactivex_MaybeObserver_;
		}

		static void n_SubscribeActual_Lio_reactivex_MaybeObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.IMaybeObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubscribeActual (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/MaybeObserver;)V", "GetSubscribeActual_Lio_reactivex_MaybeObserver_Handler")]
		protected abstract void SubscribeActual (global::IO.Reactivex.IMaybeObserver p0);

		static IntPtr id_subscribeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='subscribeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("subscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe SubscribeOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_subscribeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_subscribeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "subscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribeWith_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='subscribeWith' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("subscribeWith", "(Lio/reactivex/MaybeObserver;)Lio/reactivex/MaybeObserver;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends io.reactivex.MaybeObserver<? super T>"})]
		public unsafe global::Java.Lang.Object SubscribeWith (global::Java.Lang.Object observer)
		{
			if (id_subscribeWith_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_subscribeWith_Lio_reactivex_MaybeObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeWith", "(Lio/reactivex/MaybeObserver;)Lio/reactivex/MaybeObserver;");
			IntPtr native_observer = JNIEnv.ToLocalJniHandle (observer);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_observer);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeWith_Lio_reactivex_MaybeObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_observer);
			}
		}

		static IntPtr id_switchIfEmpty_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='switchIfEmpty' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;']]"
		[Register ("switchIfEmpty", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe SwitchIfEmpty (global::IO.Reactivex.IMaybeSource other)
		{
			if (id_switchIfEmpty_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_switchIfEmpty_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "switchIfEmpty", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchIfEmpty_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchIfEmpty_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='switchIfEmpty' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T&gt;']]"
		[Register ("switchIfEmpty", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single SwitchIfEmpty (global::IO.Reactivex.ISingleSource other)
		{
			if (id_switchIfEmpty_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_switchIfEmpty_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "switchIfEmpty", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchIfEmpty_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeUntil_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='takeUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;U&gt;']]"
		[Register ("takeUntil", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Maybe TakeUntil (global::IO.Reactivex.IMaybeSource other)
		{
			if (id_takeUntil_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_takeUntil_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "takeUntil", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeUntil_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_test;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='test' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='test' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static IntPtr id_timeout_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='timeout' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;U&gt;']]"
		[Register ("timeout", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Maybe Timeout (global::IO.Reactivex.IMaybeSource timeoutIndicator)
		{
			if (id_timeout_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_timeout_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeoutIndicator);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='timeout' and count(parameter)=2 and parameter[1][@type='io.reactivex.MaybeSource&lt;U&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T&gt;']]"
		[Register ("timeout", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Maybe Timeout (global::IO.Reactivex.IMaybeSource timeoutIndicator, global::IO.Reactivex.IMaybeSource fallback)
		{
			if (id_timeout_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_timeout_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeoutIndicator);
				__args [1] = new JValue (fallback);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='timeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (timeUnit);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='timeout' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.MaybeSource&lt;? extends T&gt;']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit, global::IO.Reactivex.IMaybeSource fallback)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (timeUnit);
				__args [2] = new JValue (fallback);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='timeout' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (timeUnit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='timeout' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='io.reactivex.MaybeSource&lt;? extends T&gt;']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit, global::IO.Reactivex.Scheduler scheduler, global::IO.Reactivex.IMaybeSource fallback)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (timeUnit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (fallback);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timer_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='timer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timer", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Maybe;", "")]
		public static unsafe global::IO.Reactivex.Maybe Timer (long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_timer_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timer_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "timer", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_timer_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='timer' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("timer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;", "")]
		public static unsafe global::IO.Reactivex.Maybe Timer (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "timer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_to_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='to' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Maybe&lt;T&gt;, R&gt;']]"
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

		static IntPtr id_toObservable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='toObservable' and count(parameter)=0]"
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

		static IntPtr id_toSingle;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='toSingle' and count(parameter)=0]"
		[Register ("toSingle", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ToSingle ()
		{
			if (id_toSingle == IntPtr.Zero)
				id_toSingle = JNIEnv.GetMethodID (class_ref, "toSingle", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toSingle), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toSingle_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='toSingle' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("toSingle", "(Ljava/lang/Object;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ToSingle (global::Java.Lang.Object defaultValue)
		{
			if (id_toSingle_Ljava_lang_Object_ == IntPtr.Zero)
				id_toSingle_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toSingle", "(Ljava/lang/Object;)Lio/reactivex/Single;");
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultValue);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toSingle_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static IntPtr id_unsafeCreate_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='unsafeCreate' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;T&gt;']]"
		[Register ("unsafeCreate", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe UnsafeCreate (global::IO.Reactivex.IMaybeSource onSubscribe)
		{
			if (id_unsafeCreate_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_unsafeCreate_Lio_reactivex_MaybeSource_ = JNIEnv.GetStaticMethodID (class_ref, "unsafeCreate", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSubscribe);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_unsafeCreate_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_unsubscribeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='unsubscribeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("unsubscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe UnsubscribeOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_unsubscribeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_unsubscribeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "unsubscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='using' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends D&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super D, ? extends io.reactivex.MaybeSource&lt;? extends T&gt;&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super D&gt;']]"
		[Register ("using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "D"})]
		public static unsafe global::IO.Reactivex.Maybe Using (global::Java.Util.Concurrent.ICallable resourceSupplier, global::IO.Reactivex.Functions.IFunction sourceSupplier, global::IO.Reactivex.Functions.IConsumer resourceDisposer)
		{
			if (id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (resourceSupplier);
				__args [1] = new JValue (sourceSupplier);
				__args [2] = new JValue (resourceDisposer);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='using' and count(parameter)=4 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends D&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super D, ? extends io.reactivex.MaybeSource&lt;? extends T&gt;&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super D&gt;'] and parameter[4][@type='boolean']]"
		[Register ("using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "D"})]
		public static unsafe global::IO.Reactivex.Maybe Using (global::Java.Util.Concurrent.ICallable resourceSupplier, global::IO.Reactivex.Functions.IFunction sourceSupplier, global::IO.Reactivex.Functions.IConsumer resourceDisposer, bool eager)
		{
			if (id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z == IntPtr.Zero)
				id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z = JNIEnv.GetStaticMethodID (class_ref, "using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (resourceSupplier);
				__args [1] = new JValue (sourceSupplier);
				__args [2] = new JValue (resourceDisposer);
				__args [3] = new JValue (eager);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_wrap_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;T&gt;']]"
		[Register ("wrap", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Maybe Wrap (global::IO.Reactivex.IMaybeSource source)
		{
			if (id_wrap_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_wrap_Lio_reactivex_MaybeSource_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zip' and count(parameter)=3 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.functions.BiFunction&lt;? super T1, ? super T2, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "R"})]
		public static unsafe global::IO.Reactivex.Maybe Zip (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2, global::IO.Reactivex.Functions.IBiFunction zipper)
		{
			if (id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (zipper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zip' and count(parameter)=4 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.MaybeSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.functions.Function3&lt;? super T1, ? super T2, ? super T3, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function3;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "R"})]
		public static unsafe global::IO.Reactivex.Maybe Zip (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2, global::IO.Reactivex.IMaybeSource source3, global::IO.Reactivex.Functions.IFunction3 zipper)
		{
			if (id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function3_ == IntPtr.Zero)
				id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function3_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function3;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (zipper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function3_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function4_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zip' and count(parameter)=5 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.MaybeSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.MaybeSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.functions.Function4&lt;? super T1, ? super T2, ? super T3, ? super T4, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function4;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "R"})]
		public static unsafe global::IO.Reactivex.Maybe Zip (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2, global::IO.Reactivex.IMaybeSource source3, global::IO.Reactivex.IMaybeSource source4, global::IO.Reactivex.Functions.IFunction4 zipper)
		{
			if (id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function4_ == IntPtr.Zero)
				id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function4_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function4;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (zipper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function4_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function5_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zip' and count(parameter)=6 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.MaybeSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.MaybeSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.MaybeSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.functions.Function5&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function5;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "R"})]
		public static unsafe global::IO.Reactivex.Maybe Zip (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2, global::IO.Reactivex.IMaybeSource source3, global::IO.Reactivex.IMaybeSource source4, global::IO.Reactivex.IMaybeSource source5, global::IO.Reactivex.Functions.IFunction5 zipper)
		{
			if (id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function5_ == IntPtr.Zero)
				id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function5_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function5;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (zipper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function5_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zip' and count(parameter)=7 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.MaybeSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.MaybeSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.MaybeSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.MaybeSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.functions.Function6&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function6;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "R"})]
		public static unsafe global::IO.Reactivex.Maybe Zip (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2, global::IO.Reactivex.IMaybeSource source3, global::IO.Reactivex.IMaybeSource source4, global::IO.Reactivex.IMaybeSource source5, global::IO.Reactivex.IMaybeSource source6, global::IO.Reactivex.Functions.IFunction6 zipper)
		{
			if (id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function6_ == IntPtr.Zero)
				id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function6_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function6;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (source6);
				__args [6] = new JValue (zipper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function6_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function7_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zip' and count(parameter)=8 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.MaybeSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.MaybeSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.MaybeSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.MaybeSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.MaybeSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.functions.Function7&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function7;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "R"})]
		public static unsafe global::IO.Reactivex.Maybe Zip (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2, global::IO.Reactivex.IMaybeSource source3, global::IO.Reactivex.IMaybeSource source4, global::IO.Reactivex.IMaybeSource source5, global::IO.Reactivex.IMaybeSource source6, global::IO.Reactivex.IMaybeSource source7, global::IO.Reactivex.Functions.IFunction7 zipper)
		{
			if (id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function7_ == IntPtr.Zero)
				id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function7_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function7;)Lio/reactivex/Maybe;");
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
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function7_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function8_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zip' and count(parameter)=9 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.MaybeSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.MaybeSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.MaybeSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.MaybeSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.MaybeSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.MaybeSource&lt;? extends T8&gt;'] and parameter[9][@type='io.reactivex.functions.Function8&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function8;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "R"})]
		public static unsafe global::IO.Reactivex.Maybe Zip (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2, global::IO.Reactivex.IMaybeSource source3, global::IO.Reactivex.IMaybeSource source4, global::IO.Reactivex.IMaybeSource source5, global::IO.Reactivex.IMaybeSource source6, global::IO.Reactivex.IMaybeSource source7, global::IO.Reactivex.IMaybeSource source8, global::IO.Reactivex.Functions.IFunction8 zipper)
		{
			if (id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function8_ == IntPtr.Zero)
				id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function8_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function8;)Lio/reactivex/Maybe;");
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
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function8_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function9_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zip' and count(parameter)=10 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.MaybeSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.MaybeSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.MaybeSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.MaybeSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.MaybeSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.MaybeSource&lt;? extends T8&gt;'] and parameter[9][@type='io.reactivex.MaybeSource&lt;? extends T9&gt;'] and parameter[10][@type='io.reactivex.functions.Function9&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? super T9, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function9;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "R"})]
		public static unsafe global::IO.Reactivex.Maybe Zip (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2, global::IO.Reactivex.IMaybeSource source3, global::IO.Reactivex.IMaybeSource source4, global::IO.Reactivex.IMaybeSource source5, global::IO.Reactivex.IMaybeSource source6, global::IO.Reactivex.IMaybeSource source7, global::IO.Reactivex.IMaybeSource source8, global::IO.Reactivex.IMaybeSource source9, global::IO.Reactivex.Functions.IFunction9 zipper)
		{
			if (id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function9_ == IntPtr.Zero)
				id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function9_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function9;)Lio/reactivex/Maybe;");
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
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_Function9_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zip' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.MaybeSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register ("zip", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Maybe Zip (global::Java.Lang.IIterable sources, global::IO.Reactivex.Functions.IFunction zipper)
		{
			if (id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (zipper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zipArray_Lio_reactivex_functions_Function_arrayLio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zipArray' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T&gt;...']]"
		[Register ("zipArray", "(Lio/reactivex/functions/Function;[Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Maybe ZipArray (global::IO.Reactivex.Functions.IFunction zipper, params global::IO.Reactivex.IMaybeSource[] sources)
		{
			if (id_zipArray_Lio_reactivex_functions_Function_arrayLio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_zipArray_Lio_reactivex_functions_Function_arrayLio_reactivex_MaybeSource_ = JNIEnv.GetStaticMethodID (class_ref, "zipArray", "(Lio/reactivex/functions/Function;[Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (zipper);
				__args [1] = new JValue (native_sources);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zipArray_Lio_reactivex_functions_Function_arrayLio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_zipWith_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='zipWith' and count(parameter)=2 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends U&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;']]"
		[Register ("zipWith", "(Lio/reactivex/MaybeSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Maybe ZipWith (global::IO.Reactivex.IMaybeSource other, global::IO.Reactivex.Functions.IBiFunction zipper)
		{
			if (id_zipWith_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_zipWith_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "zipWith", "(Lio/reactivex/MaybeSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (other);
				__args [1] = new JValue (zipper);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zipWith_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/Maybe", DoNotGenerateAcw=true)]
	internal partial class MaybeInvoker : Maybe, global::IO.Reactivex.IMaybeSource {

		public MaybeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaybeInvoker); }
		}

		static IntPtr id_subscribeActual_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Maybe']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/MaybeObserver;)V", "GetSubscribeActual_Lio_reactivex_MaybeObserver_Handler")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IMaybeObserver p0)
		{
			if (id_subscribeActual_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_MaybeObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/MaybeObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_MaybeObserver_, __args);
			} finally {
			}
		}

	}

}
