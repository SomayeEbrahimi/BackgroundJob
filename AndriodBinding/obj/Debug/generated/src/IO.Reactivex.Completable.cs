using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']"
	[global::Android.Runtime.Register ("io/reactivex/Completable", DoNotGenerateAcw=true)]
	public abstract partial class Completable : global::Java.Lang.Object, global::IO.Reactivex.ICompletableSource {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/Completable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Completable); }
		}

		protected Completable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/constructor[@name='Completable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Completable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Completable)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='amb' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("amb", "(Ljava/lang/Iterable;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Amb (global::Java.Lang.IIterable sources)
		{
			if (id_amb_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_amb_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "amb", "(Ljava/lang/Iterable;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_amb_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ambArray_arrayLio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='ambArray' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource...']]"
		[Register ("ambArray", "([Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable AmbArray (params global::IO.Reactivex.ICompletableSource[] sources)
		{
			if (id_ambArray_arrayLio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_ambArray_arrayLio_reactivex_CompletableSource_ = JNIEnv.GetStaticMethodID (class_ref, "ambArray", "([Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ambArray_arrayLio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_ambWith_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='ambWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("ambWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable AmbWith (global::IO.Reactivex.ICompletableSource other)
		{
			if (id_ambWith_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_ambWith_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "ambWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ambWith_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_andThen_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='andThen' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("andThen", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable AndThen (global::IO.Reactivex.ICompletableSource next)
		{
			if (id_andThen_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_andThen_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "andThen", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (next);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_andThen_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_andThen_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='andThen' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;T&gt;']]"
		[Register ("andThen", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::IO.Reactivex.Maybe AndThen (global::IO.Reactivex.IMaybeSource next)
		{
			if (id_andThen_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_andThen_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "andThen", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (next);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_andThen_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_andThen_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='andThen' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;']]"
		[Register ("andThen", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::IO.Reactivex.Observable AndThen (global::IO.Reactivex.IObservableSource next)
		{
			if (id_andThen_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_andThen_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "andThen", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (next);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_andThen_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_andThen_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='andThen' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;T&gt;']]"
		[Register ("andThen", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::IO.Reactivex.Single AndThen (global::IO.Reactivex.ISingleSource next)
		{
			if (id_andThen_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_andThen_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "andThen", "(Lio/reactivex/SingleSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (next);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_andThen_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_as_Lio_reactivex_CompletableConverter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='as' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableConverter&lt;? extends R&gt;']]"
		[Register ("as", "(Lio/reactivex/CompletableConverter;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Java.Lang.Object As (global::IO.Reactivex.ICompletableConverter converter)
		{
			if (id_as_Lio_reactivex_CompletableConverter_ == IntPtr.Zero)
				id_as_Lio_reactivex_CompletableConverter_ = JNIEnv.GetMethodID (class_ref, "as", "(Lio/reactivex/CompletableConverter;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (converter);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_as_Lio_reactivex_CompletableConverter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_blockingAwait;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='blockingAwait' and count(parameter)=0]"
		[Register ("blockingAwait", "()V", "")]
		public unsafe void BlockingAwait ()
		{
			if (id_blockingAwait == IntPtr.Zero)
				id_blockingAwait = JNIEnv.GetMethodID (class_ref, "blockingAwait", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockingAwait);
			} finally {
			}
		}

		static IntPtr id_blockingAwait_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='blockingAwait' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("blockingAwait", "(JLjava/util/concurrent/TimeUnit;)Z", "")]
		public unsafe bool BlockingAwait (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_blockingAwait_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_blockingAwait_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "blockingAwait", "(JLjava/util/concurrent/TimeUnit;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_blockingAwait_JLjava_util_concurrent_TimeUnit_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_blockingGet;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='blockingGet' and count(parameter)=0]"
		[Register ("blockingGet", "()Ljava/lang/Throwable;", "")]
		public unsafe global::Java.Lang.Throwable BlockingGet ()
		{
			if (id_blockingGet == IntPtr.Zero)
				id_blockingGet = JNIEnv.GetMethodID (class_ref, "blockingGet", "()Ljava/lang/Throwable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingGet), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockingGet_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='blockingGet' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("blockingGet", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Throwable;", "")]
		public unsafe global::Java.Lang.Throwable BlockingGet (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_blockingGet_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_blockingGet_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "blockingGet", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Throwable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::Java.Lang.Throwable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingGet_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_cache;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='cache' and count(parameter)=0]"
		[Register ("cache", "()Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Cache ()
		{
			if (id_cache == IntPtr.Zero)
				id_cache = JNIEnv.GetMethodID (class_ref, "cache", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cache), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_complete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='complete' and count(parameter)=0]"
		[Register ("complete", "()Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Complete ()
		{
			if (id_complete == IntPtr.Zero)
				id_complete = JNIEnv.GetStaticMethodID (class_ref, "complete", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_complete), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_compose_Lio_reactivex_CompletableTransformer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='compose' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableTransformer']]"
		[Register ("compose", "(Lio/reactivex/CompletableTransformer;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Compose (global::IO.Reactivex.ICompletableTransformer transformer)
		{
			if (id_compose_Lio_reactivex_CompletableTransformer_ == IntPtr.Zero)
				id_compose_Lio_reactivex_CompletableTransformer_ = JNIEnv.GetMethodID (class_ref, "compose", "(Lio/reactivex/CompletableTransformer;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (transformer);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compose_Lio_reactivex_CompletableTransformer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concat_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='concat' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("concat", "(Ljava/lang/Iterable;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Concat (global::Java.Lang.IIterable sources)
		{
			if (id_concat_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_concat_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "concat", "(Ljava/lang/Iterable;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concat_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatArray_arrayLio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='concatArray' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource...']]"
		[Register ("concatArray", "([Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable ConcatArray (params global::IO.Reactivex.ICompletableSource[] sources)
		{
			if (id_concatArray_arrayLio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_concatArray_arrayLio_reactivex_CompletableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concatArray", "([Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatArray_arrayLio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_concatWith_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='concatWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("concatWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable ConcatWith (global::IO.Reactivex.ICompletableSource other)
		{
			if (id_concatWith_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_concatWith_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "concatWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatWith_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create_Lio_reactivex_CompletableOnSubscribe_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='create' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableOnSubscribe']]"
		[Register ("create", "(Lio/reactivex/CompletableOnSubscribe;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Create (global::IO.Reactivex.ICompletableOnSubscribe source)
		{
			if (id_create_Lio_reactivex_CompletableOnSubscribe_ == IntPtr.Zero)
				id_create_Lio_reactivex_CompletableOnSubscribe_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lio/reactivex/CompletableOnSubscribe;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lio_reactivex_CompletableOnSubscribe_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_defer_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='defer' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("defer", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Defer (global::Java.Util.Concurrent.ICallable completableSupplier)
		{
			if (id_defer_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_defer_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "defer", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (completableSupplier);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defer_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='delay' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Delay (long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='delay' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Delay (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='delay' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='boolean']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Delay (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool delayError)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (delayError);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='delaySubscription' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("delaySubscription", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable DelaySubscription (long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_delaySubscription_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_delaySubscription_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='delaySubscription' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("delaySubscription", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable DelaySubscription (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doAfterTerminate_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='doAfterTerminate' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doAfterTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable DoAfterTerminate (global::IO.Reactivex.Functions.IAction onAfterTerminate)
		{
			if (id_doAfterTerminate_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doAfterTerminate_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doAfterTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onAfterTerminate);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doAfterTerminate_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doFinally_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='doFinally' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doFinally", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable DoFinally (global::IO.Reactivex.Functions.IAction onFinally)
		{
			if (id_doFinally_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doFinally_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doFinally", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onFinally);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doFinally_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnComplete_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='doOnComplete' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnComplete", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable DoOnComplete (global::IO.Reactivex.Functions.IAction onComplete)
		{
			if (id_doOnComplete_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnComplete_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnComplete", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onComplete);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnComplete_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnDispose_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='doOnDispose' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnDispose", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable DoOnDispose (global::IO.Reactivex.Functions.IAction onDispose)
		{
			if (id_doOnDispose_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnDispose_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnDispose", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onDispose);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnDispose_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnError_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='doOnError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
		[Register ("doOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable DoOnError (global::IO.Reactivex.Functions.IConsumer onError)
		{
			if (id_doOnError_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnError_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onError);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnError_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnEvent_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='doOnEvent' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
		[Register ("doOnEvent", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable DoOnEvent (global::IO.Reactivex.Functions.IConsumer onEvent)
		{
			if (id_doOnEvent_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnEvent_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnEvent", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onEvent);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnEvent_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnSubscribe_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='doOnSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register ("doOnSubscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable DoOnSubscribe (global::IO.Reactivex.Functions.IConsumer onSubscribe)
		{
			if (id_doOnSubscribe_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnSubscribe_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnSubscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSubscribe);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnSubscribe_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnTerminate_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='doOnTerminate' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable DoOnTerminate (global::IO.Reactivex.Functions.IAction onTerminate)
		{
			if (id_doOnTerminate_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnTerminate_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onTerminate);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnTerminate_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/Throwable;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Error (global::Java.Lang.Throwable error)
		{
			if (id_error_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Throwable;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (error);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_error_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends java.lang.Throwable&gt;']]"
		[Register ("error", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Error (global::Java.Util.Concurrent.ICallable errorSupplier)
		{
			if (id_error_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_error_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorSupplier);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromAction_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='fromAction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("fromAction", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable FromAction (global::IO.Reactivex.Functions.IAction run)
		{
			if (id_fromAction_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_fromAction_Lio_reactivex_functions_Action_ = JNIEnv.GetStaticMethodID (class_ref, "fromAction", "(Lio/reactivex/functions/Action;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (run);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAction_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromCallable_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='fromCallable' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;?&gt;']]"
		[Register ("fromCallable", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable FromCallable (global::Java.Util.Concurrent.ICallable callable)
		{
			if (id_fromCallable_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_fromCallable_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "fromCallable", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (callable);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCallable_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='fromFuture' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Future&lt;?&gt;']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable FromFuture (global::Java.Util.Concurrent.IFuture future)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (future);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromMaybe_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='fromMaybe' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;T&gt;']]"
		[Register ("fromMaybe", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Completable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Completable FromMaybe (global::IO.Reactivex.IMaybeSource maybe)
		{
			if (id_fromMaybe_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_fromMaybe_Lio_reactivex_MaybeSource_ = JNIEnv.GetStaticMethodID (class_ref, "fromMaybe", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (maybe);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromMaybe_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromObservable_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='fromObservable' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;']]"
		[Register ("fromObservable", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Completable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Completable FromObservable (global::IO.Reactivex.IObservableSource observable)
		{
			if (id_fromObservable_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_fromObservable_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "fromObservable", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observable);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromObservable_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='fromRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("fromRunnable", "(Ljava/lang/Runnable;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable FromRunnable (global::Java.Lang.IRunnable run)
		{
			if (id_fromRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_fromRunnable_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "fromRunnable", "(Ljava/lang/Runnable;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (run);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromRunnable_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromSingle_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='fromSingle' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;T&gt;']]"
		[Register ("fromSingle", "(Lio/reactivex/SingleSource;)Lio/reactivex/Completable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Completable FromSingle (global::IO.Reactivex.ISingleSource single)
		{
			if (id_fromSingle_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_fromSingle_Lio_reactivex_SingleSource_ = JNIEnv.GetStaticMethodID (class_ref, "fromSingle", "(Lio/reactivex/SingleSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (single);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromSingle_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hide;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hide), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_lift_Lio_reactivex_CompletableOperator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='lift' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableOperator']]"
		[Register ("lift", "(Lio/reactivex/CompletableOperator;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Lift (global::IO.Reactivex.ICompletableOperator onLift)
		{
			if (id_lift_Lio_reactivex_CompletableOperator_ == IntPtr.Zero)
				id_lift_Lio_reactivex_CompletableOperator_ = JNIEnv.GetMethodID (class_ref, "lift", "(Lio/reactivex/CompletableOperator;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onLift);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_lift_Lio_reactivex_CompletableOperator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_materialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='materialize' and count(parameter)=0]"
		[Register ("materialize", "()Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::IO.Reactivex.Single Materialize ()
		{
			if (id_materialize == IntPtr.Zero)
				id_materialize = JNIEnv.GetMethodID (class_ref, "materialize", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_materialize), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_merge_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("merge", "(Ljava/lang/Iterable;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Merge (global::Java.Lang.IIterable sources)
		{
			if (id_merge_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_merge_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Ljava/lang/Iterable;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeArray_arrayLio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='mergeArray' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource...']]"
		[Register ("mergeArray", "([Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable MergeArray (params global::IO.Reactivex.ICompletableSource[] sources)
		{
			if (id_mergeArray_arrayLio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_mergeArray_arrayLio_reactivex_CompletableSource_ = JNIEnv.GetStaticMethodID (class_ref, "mergeArray", "([Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeArray_arrayLio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_mergeArrayDelayError_arrayLio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='mergeArrayDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource...']]"
		[Register ("mergeArrayDelayError", "([Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable MergeArrayDelayError (params global::IO.Reactivex.ICompletableSource[] sources)
		{
			if (id_mergeArrayDelayError_arrayLio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_mergeArrayDelayError_arrayLio_reactivex_CompletableSource_ = JNIEnv.GetStaticMethodID (class_ref, "mergeArrayDelayError", "([Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeArrayDelayError_arrayLio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_mergeDelayError_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='mergeDelayError' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("mergeDelayError", "(Ljava/lang/Iterable;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable MergeDelayError (global::Java.Lang.IIterable sources)
		{
			if (id_mergeDelayError_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_mergeDelayError_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "mergeDelayError", "(Ljava/lang/Iterable;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeDelayError_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeWith_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='mergeWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("mergeWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable MergeWith (global::IO.Reactivex.ICompletableSource other)
		{
			if (id_mergeWith_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_mergeWith_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "mergeWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mergeWith_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_never;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='never' and count(parameter)=0]"
		[Register ("never", "()Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Never ()
		{
			if (id_never == IntPtr.Zero)
				id_never = JNIEnv.GetStaticMethodID (class_ref, "never", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_never), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_observeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='observeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("observeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable ObserveOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_observeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_observeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "observeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_observeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='onErrorComplete' and count(parameter)=0]"
		[Register ("onErrorComplete", "()Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable OnErrorComplete ()
		{
			if (id_onErrorComplete == IntPtr.Zero)
				id_onErrorComplete = JNIEnv.GetMethodID (class_ref, "onErrorComplete", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorComplete), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_onErrorComplete_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='onErrorComplete' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super java.lang.Throwable&gt;']]"
		[Register ("onErrorComplete", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable OnErrorComplete (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_onErrorComplete_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_onErrorComplete_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "onErrorComplete", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorComplete_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorResumeNext_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='onErrorResumeNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Throwable, ? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("onErrorResumeNext", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable OnErrorResumeNext (global::IO.Reactivex.Functions.IFunction errorMapper)
		{
			if (id_onErrorResumeNext_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_onErrorResumeNext_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "onErrorResumeNext", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorMapper);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorResumeNext_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onTerminateDetach;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='onTerminateDetach' and count(parameter)=0]"
		[Register ("onTerminateDetach", "()Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable OnTerminateDetach ()
		{
			if (id_onTerminateDetach == IntPtr.Zero)
				id_onTerminateDetach = JNIEnv.GetMethodID (class_ref, "onTerminateDetach", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onTerminateDetach), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_repeat;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='repeat' and count(parameter)=0]"
		[Register ("repeat", "()Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Repeat ()
		{
			if (id_repeat == IntPtr.Zero)
				id_repeat = JNIEnv.GetMethodID (class_ref, "repeat", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_repeat), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_repeat_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='repeat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("repeat", "(J)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Repeat (long times)
		{
			if (id_repeat_J == IntPtr.Zero)
				id_repeat_J = JNIEnv.GetMethodID (class_ref, "repeat", "(J)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (times);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_repeat_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_repeatUntil_Lio_reactivex_functions_BooleanSupplier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='repeatUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BooleanSupplier']]"
		[Register ("repeatUntil", "(Lio/reactivex/functions/BooleanSupplier;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable RepeatUntil (global::IO.Reactivex.Functions.IBooleanSupplier stop)
		{
			if (id_repeatUntil_Lio_reactivex_functions_BooleanSupplier_ == IntPtr.Zero)
				id_repeatUntil_Lio_reactivex_functions_BooleanSupplier_ = JNIEnv.GetMethodID (class_ref, "repeatUntil", "(Lio/reactivex/functions/BooleanSupplier;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (stop);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_repeatUntil_Lio_reactivex_functions_BooleanSupplier_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retry;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='retry' and count(parameter)=0]"
		[Register ("retry", "()Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Retry ()
		{
			if (id_retry == IntPtr.Zero)
				id_retry = JNIEnv.GetMethodID (class_ref, "retry", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_retry_Lio_reactivex_functions_BiPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiPredicate&lt;? super java.lang.Integer, ? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Retry (global::IO.Reactivex.Functions.IBiPredicate predicate)
		{
			if (id_retry_Lio_reactivex_functions_BiPredicate_ == IntPtr.Zero)
				id_retry_Lio_reactivex_functions_BiPredicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_Lio_reactivex_functions_BiPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retry_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Retry (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_retry_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_retry_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retry_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("retry", "(J)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Retry (long times)
		{
			if (id_retry_J == IntPtr.Zero)
				id_retry_J = JNIEnv.GetMethodID (class_ref, "retry", "(J)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (times);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_retry_JLio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='retry' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='io.reactivex.functions.Predicate&lt;? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(JLio/reactivex/functions/Predicate;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Retry (long times, global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_retry_JLio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_retry_JLio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(JLio/reactivex/functions/Predicate;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (times);
				__args [1] = new JValue (predicate);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_JLio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_startWith_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='startWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("startWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable StartWith (global::IO.Reactivex.ICompletableSource other)
		{
			if (id_startWith_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_startWith_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "startWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startWith_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_startWith_Lio_reactivex_Observable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='startWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observable&lt;T&gt;']]"
		[Register ("startWith", "(Lio/reactivex/Observable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::IO.Reactivex.Observable StartWith (global::IO.Reactivex.Observable other)
		{
			if (id_startWith_Lio_reactivex_Observable_ == IntPtr.Zero)
				id_startWith_Lio_reactivex_Observable_ = JNIEnv.GetMethodID (class_ref, "startWith", "(Lio/reactivex/Observable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startWith_Lio_reactivex_Observable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='subscribe' and count(parameter)=0]"
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

		static IntPtr id_subscribe_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
		[Register ("subscribe", "(Lio/reactivex/CompletableObserver;)V", "")]
		public unsafe void Subscribe (global::IO.Reactivex.ICompletableObserver observer)
		{
			if (id_subscribe_Lio_reactivex_CompletableObserver_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_CompletableObserver_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/CompletableObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_CompletableObserver_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("subscribe", "(Lio/reactivex/functions/Action;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe (global::IO.Reactivex.Functions.IAction onComplete)
		{
			if (id_subscribe_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/functions/Action;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onComplete);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Action'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/functions/Action;Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe (global::IO.Reactivex.Functions.IAction onComplete, global::IO.Reactivex.Functions.IConsumer onError)
		{
			if (id_subscribe_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/functions/Action;Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (onComplete);
				__args [1] = new JValue (onError);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_subscribeActual_Lio_reactivex_CompletableObserver_;
#pragma warning disable 0169
		static Delegate GetSubscribeActual_Lio_reactivex_CompletableObserver_Handler ()
		{
			if (cb_subscribeActual_Lio_reactivex_CompletableObserver_ == null)
				cb_subscribeActual_Lio_reactivex_CompletableObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SubscribeActual_Lio_reactivex_CompletableObserver_);
			return cb_subscribeActual_Lio_reactivex_CompletableObserver_;
		}

		static void n_SubscribeActual_Lio_reactivex_CompletableObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.ICompletableObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.ICompletableObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubscribeActual (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
		[Register ("subscribeActual", "(Lio/reactivex/CompletableObserver;)V", "GetSubscribeActual_Lio_reactivex_CompletableObserver_Handler")]
		protected abstract void SubscribeActual (global::IO.Reactivex.ICompletableObserver p0);

		static IntPtr id_subscribeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='subscribeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("subscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable SubscribeOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_subscribeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_subscribeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "subscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribeWith_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='subscribeWith' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("subscribeWith", "(Lio/reactivex/CompletableObserver;)Lio/reactivex/CompletableObserver;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends io.reactivex.CompletableObserver"})]
		public unsafe global::Java.Lang.Object SubscribeWith (global::Java.Lang.Object observer)
		{
			if (id_subscribeWith_Lio_reactivex_CompletableObserver_ == IntPtr.Zero)
				id_subscribeWith_Lio_reactivex_CompletableObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeWith", "(Lio/reactivex/CompletableObserver;)Lio/reactivex/CompletableObserver;");
			IntPtr native_observer = JNIEnv.ToLocalJniHandle (observer);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_observer);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeWith_Lio_reactivex_CompletableObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_observer);
			}
		}

		static IntPtr id_takeUntil_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='takeUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("takeUntil", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable TakeUntil (global::IO.Reactivex.ICompletableSource other)
		{
			if (id_takeUntil_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_takeUntil_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "takeUntil", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeUntil_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_test;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='test' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='test' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='timeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='timeout' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.CompletableSource']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.ICompletableSource other)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (other);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='timeout' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='timeout' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='io.reactivex.CompletableSource']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, global::IO.Reactivex.ICompletableSource other)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (other);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timer_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='timer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timer", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Timer (long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_timer_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timer_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "timer", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_timer_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='timer' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("timer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Timer (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "timer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_to_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='to' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Completable, U&gt;']]"
		[Register ("to", "(Lio/reactivex/functions/Function;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::Java.Lang.Object To (global::IO.Reactivex.Functions.IFunction converter)
		{
			if (id_to_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_to_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "to", "(Lio/reactivex/functions/Function;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (converter);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_to_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMaybe;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='toMaybe' and count(parameter)=0]"
		[Register ("toMaybe", "()Lio/reactivex/Maybe;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='toObservable' and count(parameter)=0]"
		[Register ("toObservable", "()Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::IO.Reactivex.Observable ToObservable ()
		{
			if (id_toObservable == IntPtr.Zero)
				id_toObservable = JNIEnv.GetMethodID (class_ref, "toObservable", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toObservable), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toSingle_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='toSingle' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends T&gt;']]"
		[Register ("toSingle", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::IO.Reactivex.Single ToSingle (global::Java.Util.Concurrent.ICallable completionValueSupplier)
		{
			if (id_toSingle_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_toSingle_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "toSingle", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (completionValueSupplier);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toSingle_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toSingleDefault_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='toSingleDefault' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("toSingleDefault", "(Ljava/lang/Object;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::IO.Reactivex.Single ToSingleDefault (global::Java.Lang.Object completionValue)
		{
			if (id_toSingleDefault_Ljava_lang_Object_ == IntPtr.Zero)
				id_toSingleDefault_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toSingleDefault", "(Ljava/lang/Object;)Lio/reactivex/Single;");
			IntPtr native_completionValue = JNIEnv.ToLocalJniHandle (completionValue);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_completionValue);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toSingleDefault_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_completionValue);
			}
		}

		static IntPtr id_unsafeCreate_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='unsafeCreate' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("unsafeCreate", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable UnsafeCreate (global::IO.Reactivex.ICompletableSource source)
		{
			if (id_unsafeCreate_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_unsafeCreate_Lio_reactivex_CompletableSource_ = JNIEnv.GetStaticMethodID (class_ref, "unsafeCreate", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_unsafeCreate_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_unsubscribeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='unsubscribeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("unsubscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable UnsubscribeOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_unsubscribeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_unsubscribeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "unsubscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='using' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Callable&lt;R&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super R, ? extends io.reactivex.CompletableSource&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super R&gt;']]"
		[Register ("using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;)Lio/reactivex/Completable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::IO.Reactivex.Completable Using (global::Java.Util.Concurrent.ICallable resourceSupplier, global::IO.Reactivex.Functions.IFunction completableFunction, global::IO.Reactivex.Functions.IConsumer disposer)
		{
			if (id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (resourceSupplier);
				__args [1] = new JValue (completableFunction);
				__args [2] = new JValue (disposer);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='using' and count(parameter)=4 and parameter[1][@type='java.util.concurrent.Callable&lt;R&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super R, ? extends io.reactivex.CompletableSource&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super R&gt;'] and parameter[4][@type='boolean']]"
		[Register ("using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)Lio/reactivex/Completable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::IO.Reactivex.Completable Using (global::Java.Util.Concurrent.ICallable resourceSupplier, global::IO.Reactivex.Functions.IFunction completableFunction, global::IO.Reactivex.Functions.IConsumer disposer, bool eager)
		{
			if (id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z == IntPtr.Zero)
				id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z = JNIEnv.GetStaticMethodID (class_ref, "using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (resourceSupplier);
				__args [1] = new JValue (completableFunction);
				__args [2] = new JValue (disposer);
				__args [3] = new JValue (eager);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_wrap_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("wrap", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;", "")]
		public static unsafe global::IO.Reactivex.Completable Wrap (global::IO.Reactivex.ICompletableSource source)
		{
			if (id_wrap_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_wrap_Lio_reactivex_CompletableSource_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/Completable", DoNotGenerateAcw=true)]
	internal partial class CompletableInvoker : Completable {

		public CompletableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompletableInvoker); }
		}

		static IntPtr id_subscribeActual_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Completable']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
		[Register ("subscribeActual", "(Lio/reactivex/CompletableObserver;)V", "GetSubscribeActual_Lio_reactivex_CompletableObserver_Handler")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ICompletableObserver p0)
		{
			if (id_subscribeActual_Lio_reactivex_CompletableObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_CompletableObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/CompletableObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_CompletableObserver_, __args);
			} finally {
			}
		}

	}

}
